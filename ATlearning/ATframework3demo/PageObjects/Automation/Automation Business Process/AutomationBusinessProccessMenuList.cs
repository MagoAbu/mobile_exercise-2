using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Automation
{
    public class AutomationBusinessProccessMenuList
    {

        WebItem ProcessInNewsFeedItem => new WebItem("//span[@class='main-buttons-item-text-box' " +
            "and text()='Процессы в ленте новостей']",
            "Пункт выпадающего меню бизнес-процессы \"Процессы в ленте новостей\" на главной странице автоматизации");

        public AutomationProcessListPage SelectProcessesInNewsFeed()
        {
            ProcessInNewsFeedItem.Click();
            return new AutomationProcessListPage();
        }
    }
}
