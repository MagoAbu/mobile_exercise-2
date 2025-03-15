using atFrameWork2.BaseFramework;
using atFrameWork2.PageObjects;
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.TestCases
{
    public class Case_Bitrix24_BusinessProcessManager : CaseCollectionBuilder
    {
        protected override List<TestCase> GetCases()
        {
            var caseCollection = new List<TestCase>();
            caseCollection.Add(new TestCase("Запуск стандартного БП \"Исходящие документы\" через страницу Бизнес-процессы", homePage => StartOutgoingDocumentsProcess(homePage)));
            return caseCollection;
        }

        void StartOutgoingDocumentsProcess(PortalHomePage homePage)
        {
            //Создать сотрудников
            var firstUser = TestCase.RunningTestCase.CreatePortalTestUser(false);
            var secondUser = TestCase.RunningTestCase.CreatePortalTestUser(false);

            //Перейти в раздел левого меню "Автоматизация"
            homePage
                .LeftMenu
                .OpenAutomation()
            //Открыть список БП
                .OpenBusinessProcessList()
            //Выбрать пункт процессы в ленте новостей
                .SelectProcessesInNewsFeed()
            //Выбрать процесс "Исходящие документы"
                .SelectOutgoingDocumentsProcess()
            //Добавить в константу "Кто фиксирует" одного из добавленных юзеров
                .NavigateToProcessSettings()
                .SelectConfigureBusinessProcessesItem()
                .ClickBurgerMenu()
                .SelectEditItemFromBurgerMenu()
                .ClickTemplateParameters()
                .SelectConstantsItem()
                .AddDocumentRegistrar(firstUser)
                .SaveTemplateParametersChanges()
                .SaveTemplateParametersBusinessProcesses();
            //Зайти под вторым добавленным юзером
            WebItem.DefaultDriver.Quit();
            WebItem.DefaultDriver = default;
            new PortalLoginPage(TestCase.RunningTestCase.TestPortal)
                .Login(secondUser);
            homePage
                .LeftMenu
            //Запустить бизнес-процесс
                .OpenAutomation()
                .StartBusinessProcess()
                .SelectOutgoingDocumentsBusinessProcess()
                .NavigateToBusinessProcessCreationFrame()
                .FillFieldsBusinessProcess();
            //Зайти под первым добавленным юзером
            WebItem.DefaultDriver.Quit();
            WebItem.DefaultDriver = default;
            new PortalLoginPage(TestCase.RunningTestCase.TestPortal)
                .Login(firstUser);
            homePage
                .LeftMenu
                .OpenAutomation()
            //Зафиксировать исходящий документ
                .ClickToOutgoingDocument()
                .NavigateToOutgoingDocumentsTasksFrame()
            //Рефрешнуть страницу
                .RefreshAutomationBasePage()
            //Проверить, что статус бизнес-процесса стал "Завершён"
                .CheckDocumentStatus();
            //Проверить, что у юзера создавшего бп процесс завершен
            WebItem.DefaultDriver.Quit();
            WebItem.DefaultDriver = default;
            new PortalLoginPage(TestCase.RunningTestCase.TestPortal)
                .Login(secondUser);
            homePage 
                .LeftMenu
                .OpenAutomation()
                .RefreshAutomationBasePage()
                .CheckDocumentStatus();
        }
    }
}

