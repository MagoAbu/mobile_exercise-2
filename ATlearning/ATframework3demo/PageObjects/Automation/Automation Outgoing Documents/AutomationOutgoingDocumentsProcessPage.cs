
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Automation
{
    public class AutomationOutgoingDocumentsProcessPage
    {

        WebItem SettingsButton => new WebItem("//button[@class='ui-btn ui-btn-light-border " +
            "ui-btn-icon-setting ui-btn-themes']", 
            "Шестерёнка настроек на странице Исходящие документы");

        public AutomationOutgoingDocumentsProcessSettingsList NavigateToProcessSettings()
        {
            SettingsButton.Click();
            return new AutomationOutgoingDocumentsProcessSettingsList();
        }
    }
}
