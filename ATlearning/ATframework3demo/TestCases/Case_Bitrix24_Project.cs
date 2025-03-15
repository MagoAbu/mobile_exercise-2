
using atFrameWork2.BaseFramework;
using atFrameWork2.PageObjects;
using atFrameWork2.SeleniumFramework;
using ATframework3demo.BaseFramework;
using ATframework3demo.TestEntities;

namespace ATframework3demo.TestCases
{
    public class Case_Bitrix24_Project : CaseCollectionBuilder
    {
        protected override List<TestCase> GetCases()
        {
            var caseCollection = new List<TestCase>();
            caseCollection.Add(new TestCase("Создание проекта и добавление поста в его ленту", homePage => CreateProjectAndAddPostToFeed(homePage)));
            return caseCollection;
        }

        void CreateProjectAndAddPostToFeed(PortalHomePage homePage)
        {
            //Создать сотрудника
            var newMember = TestCase.RunningTestCase.CreatePortalTestUser(false);
            //Добавить имя проекта в переменную
            var projectName = new Bitrix24_Project() { ProjectName = "Test project" + HelperMethods.GetDateTimeSaltString() };
            //Добавить текст сообщения в переменную
            var messageText = new Bitrix24_Project() { MessageText = "Тестовое сообщение" + HelperMethods.GetDateTimeSaltString() };
            //Добавить уровень приватности в переменную
            var privacyType = new Bitrix24_Project() { PrivacyType = "Закрытый" };
            //Добавить роль участника проекта в переменную
            var role = new Bitrix24_Project() { ProjectRole = "Участник проекта" };


            //Перейти в раздел левого меню "Группы"
            homePage
               .LeftMenu
               .OpenGroup()
               //Начать создание проекта
               .CreateProject()
               //Выбрать тип проекта
               .SelectProjectType()
               //Ввести название проекта
               .EnterProjectName(projectName)
               //Выбрать уровень доступности
               .SelectProjectPrivacyLevel()
               //Открыть страницу добавления участников проекта
               .OpenProjectMembersPage()
               //Добавить участников проекта
               .SelectMembers(newMember)
               //Выйти из предудщего фрейма
               .ExitPreviousFrame()
               //Перейти в карточку проекта через вход во фрейм
               .NavigateToProjectCardThroughFrame()
               //Написать пост в ленту проекта
               .AddPostToFeed(messageText)
               //Закрыть карточку созданного проекта
               .CloseCreatedProjectCard()
               //Рефрешнуть страницу
               .RefreshGroupBasePage()
               //Проверить, что название проекта верное
               .VerifyProjectNameIsCorrect(projectName)
               //Проверить, что тип приватности верный
               .VerifyPrivacyLevelIsCorrect(privacyType)
               //Перейти в Ленту
               .NavigateToNewsFeed()
               //Проверить, что пост появился в ленте
               .VerifyPostAppearsInFeed(messageText);
            //Перелогиниться под приглашенным пользователем
            WebItem.DefaultDriver.Quit();
            WebItem.DefaultDriver = default;
            new PortalLoginPage(TestCase.RunningTestCase.TestPortal)
                .Login(newMember);
            homePage
                .LeftMenu
                //Перейти во вкладку Группы
                .OpenGroup()
                //Проверить, что проект отображается в списке проектов у юзера
                .VerifyProjectNameRights(projectName)
                //Проверить, что юзер является участником
                .VerifyUserInProjectMembers(role);
        }
    }
}
