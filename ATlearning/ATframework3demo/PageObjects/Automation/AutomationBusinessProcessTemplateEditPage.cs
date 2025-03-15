
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Automation
{
    public class AutomationBusinessProcessTemplateEditPage
    {

        WebItem TemplateParametersItem => new WebItem("//a[contains(@title, 'Параметры шаблона')]", 
            "Пукнт меню \"Параметры шаблона\" в шапке страницы");

        public AutomationTemplateParametersWindow ClickTemplateParameters()
        {
            TemplateParametersItem.Click();
            return new AutomationTemplateParametersWindow();
        }

        WebItem BusinessProcessSaveButton => new WebItem("//button[@id='bizprocdesigner-btn-save']", 
            "Кнопка \"Сохранить\" на странице редактирования шаблона бизнес-процесса");

        public AutomationBusinessProcessTemplatesPage SaveTemplateParametersBusinessProcesses()
        {
            BusinessProcessSaveButton.Click();
            return new AutomationBusinessProcessTemplatesPage();
        }
    }
}
