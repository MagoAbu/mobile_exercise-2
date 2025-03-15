
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Automation
{
    public class AutomationTemplateParametersWindow
    {

        WebItem ConstatnsItem => new WebItem("//span[contains(@title, 'Константы бизнес-процесса')]", 
            "Пункт списка \"Константы\"");

        WebItem RegistrarMenuItem => new WebItem("//a[text()='Кто фиксирует']", 
            "Пункт \"Кто фиксирует\" поля \"Название\" на странице \"Константы\" окна \"Параметры шаблона\"");

        public AutomationTemplateConstantsSettingsWindow SelectConstantsItem()
        {
            ConstatnsItem.Click();
            RegistrarMenuItem.Click();
            return new AutomationTemplateConstantsSettingsWindow();
        }

        WebItem SaveButton => new WebItem("//input[@id='dpsavebutton']", 
            "Кнопка \"Сохранить\" в окне редактирования шаблона бизнес-процесса");

        public AutomationBusinessProcessTemplateEditPage SaveTemplateParametersChanges()
        {
            SaveButton.Click();
            return new AutomationBusinessProcessTemplateEditPage();
        }
    }
}
