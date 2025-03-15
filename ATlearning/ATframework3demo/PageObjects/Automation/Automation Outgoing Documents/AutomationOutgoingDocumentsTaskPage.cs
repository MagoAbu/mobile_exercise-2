
using atFrameWork2.SeleniumFramework;
using ATframework3demo.BaseFramework;

namespace ATframework3demo.PageObjects.Automation
{
    public class AutomationOutgoingDocumentsTaskPage
    {

        WebItem OutgoingDocumentsTasksFrame => new WebItem("//iframe[@class='side-panel-iframe']", 
            "Страница-фрейм с задачей зафиксировать исходящий документ(ввести номер документа)");

        WebItem DocumentNumberEntryField => new WebItem("//input[@name='bpriact_NUM']", 
            "Поле ввода номера документа на странице \"Задание\"");

        WebItem SaveButton => new WebItem("//button[@class='ui-btn ui-btn-md ui-btn-success ui-btn-round']", 
            "Кнопка \"Сохранить\" на странице \"Задание\"");

        public AutomationBasePage NavigateToOutgoingDocumentsTasksFrame()
        {
            OutgoingDocumentsTasksFrame.SwitchToFrame();
            DocumentNumberEntryField.SendKeys(HelperMethods.GetCurrentDateString());
            SaveButton.Click();
            return new AutomationBasePage();
        }
    }
}
