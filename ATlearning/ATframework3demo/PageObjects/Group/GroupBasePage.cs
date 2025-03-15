
using atFrameWork2.BaseFramework;
using atFrameWork2.BaseFramework.LogTools;
using atFrameWork2.PageObjects;
using atFrameWork2.SeleniumFramework;
using atFrameWork2.TestEntities;
using ATframework3demo.TestEntities;
using Bitrix24_Project = ATframework3demo.TestEntities.Bitrix24_Project;

namespace ATframework3demo.PageObjects.Group
{
    public class GroupBasePage
    {
        WebItem BtnCreateProject => new WebItem("//a[@id='projectAddButton']", 
            "Кнопка \"Создать\" в шапке страницы \"Группы\"");

        WebItem ProjectCreationFormFrame => new WebItem("//iframe[contains(@src, " +
            "'/company/personal/user/1/groups/create/')]",
            "Переход во фрейм создания проекта");
       
        public GroupProjectCreationPage CreateProject()
        {
            BtnCreateProject.Click();
            ProjectCreationFormFrame.SwitchToFrame();
            return new GroupProjectCreationPage();
        }

        public GroupBasePage RefreshGroupBasePage()
        {
            WebDriverActions.Refresh();
            return new GroupBasePage();
        }

        public GroupBasePage VerifyProjectNameIsCorrect(TestEntities.Bitrix24_Project projectName)
        {
            WebItem ActualProjectName = new WebItem($"//a[text()='{projectName.ProjectName}']",
                "Название проекта в списке проектов");
            if (projectName.ProjectName != ActualProjectName.InnerText())
            {
                Log.Error($"Название созданного проекта " +
                    $"не соответсвует ожидаемому названию: {projectName.ProjectName}");
            }
            return new GroupBasePage();
        }

        WebItem ActualPrivacyLevel => new WebItem("//span[@class='main-grid-cell-content' and text()='Закрытый']",
            "Уровень приватности созданного проекта");
        
        public GroupBasePage VerifyPrivacyLevelIsCorrect(TestEntities.Bitrix24_Project privacyType)
        {
            if(privacyType.PrivacyType != ActualPrivacyLevel.InnerText())
            {
                Log.Error($"Уровень приватности созданного проекта " +
                    $"не соответсвует ожидаемому названию: {privacyType.PrivacyType}");
            }
            return new GroupBasePage();
        }

        WebItem NewsFeed => new WebItem("//li[@id='bx_left_menu_menu_live_feed']", 
            "Вкладка \"Лента\" левого меню");

        public NewsPage NavigateToNewsFeed()
        {
            NewsFeed.Click();
            return new NewsPage();
        }

        public GroupBasePage VerifyProjectNameRights(TestEntities.Bitrix24_Project projectName)
        {
            var ActualProjectName = new WebItem($"//a[@class='sonet-group-grid-name-text' " +
                $"and text()='{projectName.ProjectName}']",
                "Нужный нам проект в списке проектов в разделе Группы");
            if (ActualProjectName.InnerText() != projectName.ProjectName)
            {
                Log.Error($"Название проекта в списке проектов в разделе Группы " +
                    $"не соответствует ожидаемому навзанию {projectName.ProjectName}");
            }
            return new GroupBasePage();
        }

        public GroupBasePage VerifyUserInProjectMembers(Bitrix24_Project role)
        {
            WebItem ActualUserRole = new WebItem(" //span[@class='ui-label-inner' and text()='Участник проекта']",
                "Поле \"Роль\" для описания роли в проекте");
            if (ActualUserRole.InnerText() != role.ProjectRole)
            {
                Log.Error($"Роль участника не не соответствует ожидаемому значению {role.ProjectRole}");

            }
                return new GroupBasePage();
        }
    }
}
