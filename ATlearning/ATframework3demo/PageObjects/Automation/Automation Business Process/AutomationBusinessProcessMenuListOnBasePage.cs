
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Automation
{
    public class AutomationBusinessProcessMenuListOnBasePage
    {
        WebItem OutgoingDocumentsItem => new WebItem("//span[text()='Исходящие документы']" +
            "/ancestor::span[@class='menu-popup-item feed-add-post-form-link-lists ']", 
            "Пункт выпадающего меню \"Исходящие документы\"");

        public AutomationBusinessProcessFrame SelectOutgoingDocumentsBusinessProcess()
        {
            OutgoingDocumentsItem.Click();
            return new AutomationBusinessProcessFrame();
        }
    }
}
