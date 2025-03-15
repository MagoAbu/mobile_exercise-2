
using atFrameWork2.SeleniumFramework;
using ATframework3demo.BaseFramework;

namespace ATframework3demo.PageObjects.Automation
{
    public class AutomationBusinessProcessCreationPage
    {

        WebItem DateField => new WebItem("//input[@class='ui-ctl-element']", 
            "Поле ввода даты");

        WebItem PreviewTextField => new WebItem("//textarea[@name='PREVIEW_TEXT']",
            "Поле ввода текстовой информации о документе");

        WebItem StartBusinessProcessButton => new WebItem("//button[@id='lists-element-creation-guide-create-button']",
            "Кнопка \"Запустить\" бизнес-процесс");

        public void FillFieldsBusinessProcess()
        {
            DateField.SendKeys(HelperMethods.GetCurrentDateString());
            PreviewTextField.SendKeys("Какое-то описание документа " + HelperMethods.GetDateTimeSaltString());
            StartBusinessProcessButton.Click();
        }
    }
}
