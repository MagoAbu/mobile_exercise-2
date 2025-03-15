using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Automation
{
    public class AutomationOutgoingDocumentsProcessSettingsList
    {
        WebItem СonfigureBusinessProcessesItem => new WebItem("//span[@class='menu-popup-item-text' " +
            "and text()='Настроить бизнес-процессы']/ancestor::a[@class='menu-popup-item menu-popup-no-icon ']",
            "Пункт списка настроек \"Настроить бизнес-процессы\"");

        public AutomationBusinessProcessTemplatesPage SelectConfigureBusinessProcessesItem()
        {
            СonfigureBusinessProcessesItem.Click();
            return new AutomationBusinessProcessTemplatesPage();
        }
    }
}
