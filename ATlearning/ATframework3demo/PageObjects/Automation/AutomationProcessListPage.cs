
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Automation
{
    public class AutomationProcessListPage
    {

        WebItem OutgoingProcessItem => new WebItem("//a[@class='bp-bx-application-title' " +
            "and text()='Исходящие документы']", 
            "Бизнес-процесс \"Исходящие документы\" на странице со списком бизнесс-процессов");

        public AutomationOutgoingDocumentsProcessPage SelectOutgoingDocumentsProcess()
        {
            OutgoingProcessItem.Click();
            return new AutomationOutgoingDocumentsProcessPage();
        }
    }
}
