using atFrameWork2.BaseFramework;
using atFrameWork2.PageObjects;
using atFrameWork2.SeleniumFramework;
using atFrameWork2.TestEntities;
using ATframework3demo.TestEntities;

namespace ATframework3demo.TestCases
{
    public class Case_Bitrix24_Disk : CaseCollectionBuilder
    {
        protected override List<TestCase> GetCases()
        {
            var caseCollection = new List<TestCase>();
            caseCollection.Add(new TestCase("Загрузка файла в мой диск с выдачей прав на чтение второму юзеру", homePage => UploadFileWithReadPermissions(homePage)));
            return caseCollection;
        }

        void UploadFileWithReadPermissions(PortalHomePage homePage)
        {
            //var newResponsible = TestCase.RunningTestCase.CreatePortalTestUser(false);
            var userName = new Bitrix24_Diskuser { Name = "ИванIIILILXXIIIXXXIIII ЧёXIIIILILXXIIIXXXIIII" };
            var fileName = new Bitrix24_Diskfile { FileName = "ALBO4718.MP4" };
            var fileSize = new Bitrix24_Diskfile { FileName = "38.07 МБ" };

            //проверить загружен ли уже файл с таким имененем
            //homePage
            //    .LeftMenu
            //    .OpenDisk()
            //    .CheckFileUpload();

            //Перейти в раздел "Диск"
            homePage
                .LeftMenu
                .OpenDisk()
            //Добавить файл
                .UploadFile()
            //Закрыть окно добавления файла
                .СloseUploadWindow()
            //Добавить доступ
                .AddAccess()
            //Добавить юзера
                .AddUser()
            //Закрыть окно добавления юзера
                .CloseAddUserWindow()
            //Добавить права на чтение
                .GrantReadAccess()
            //Сохранить
                .SaveAccessAndUserSettings()
            //Рефрешнуть страницу
            //Открыть файл
                .OpenFile()
            //Проверить, что имя файла верное
                .CheckFileName()
            //Проверить, что имя пользователя верное
                .CheckUserName()
            //Проверить, что размер файла верный
                .CheckFileSize();
        }
    }
}
