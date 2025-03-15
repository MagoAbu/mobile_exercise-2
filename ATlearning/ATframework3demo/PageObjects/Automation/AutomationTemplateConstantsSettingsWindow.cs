

using atFrameWork2.SeleniumFramework;
using atFrameWork2.TestEntities;

namespace ATframework3demo.PageObjects.Automation
{
    public class AutomationTemplateConstantsSettingsWindow
    {

        WebItem СonstantValueInputField => new WebItem("//input[@id='id_WFSFormDefaultC']", 
            "Поле ввода значения константы");

        WebItem OkButton => new WebItem("//input[@id='dpsavebuttonformC']", 
            "Кнопка \"ОК\" в пункте \"Константы\"");

        public AutomationTemplateParametersWindow AddDocumentRegistrar(Bitrix24_Project user)
        {
            СonstantValueInputField.Clear();
            СonstantValueInputField.SendKeys($"{user.NameLastName}");
            OkButton.Click();
            return new AutomationTemplateParametersWindow();
        }
    }
}
