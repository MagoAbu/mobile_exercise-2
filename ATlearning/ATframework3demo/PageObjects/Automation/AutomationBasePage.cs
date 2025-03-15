
using atFrameWork2.BaseFramework.LogTools;
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Automation
{
    public class AutomationBasePage
    {
        WebItem BusinessProcessMenuList => new WebItem("//span[@class='main-buttons-item-text-box' " +
            "and text()='Бизнес-процессы']/ancestor::span[@class='main-buttons-item-link']", 
            "Выпадающее при наведении на него меню \"Бизнесс-процессы\" со списком процессов в шапке страницы");

        public AutomationBusinessProccessMenuList OpenBusinessProcessList()
        {
            BusinessProcessMenuList.Click();
            return new AutomationBusinessProccessMenuList();
        }

        WebItem StartBusinessProcessButton => new WebItem("//div[@class='ui-toolbar-after-title-buttons']", 
            "Кнопка \"Запустить\" на главной странице автоматизации");

        public AutomationBusinessProcessMenuListOnBasePage StartBusinessProcess()
        {
            StartBusinessProcessButton.Click();
            return new AutomationBusinessProcessMenuListOnBasePage();
        }

        WebItem OutgoingDocumentLink => new WebItem("//a[@class='bp-user-processes__title-link ui-typography-text-lg']", 
            "Ссылка с сообщением \"Зафиксировать исходящий документ\" на главной странице автоматизации");

        public AutomationOutgoingDocumentsTaskPage ClickToOutgoingDocument()
        {
            OutgoingDocumentLink.Click();
            return new AutomationOutgoingDocumentsTaskPage();
        }

        WebItem CloseFilterBtn => new WebItem("//div[@class='main-ui-item-icon main-ui-square-delete']", 
            "Крестик сброса фильтра на главной странице автоматизации");

        public AutomationBasePage RefreshAutomationBasePage()
        {
            WebDriverActions.Refresh();
            CloseFilterBtn.Click();
            return new AutomationBasePage();
        }

        WebItem DocumentStatus => new WebItem("//div[@class='bp-status-name']", 
            "Поле со статусом документа на главной странице автоматизации");

        public AutomationBasePage CheckDocumentStatus()
        {
            if (DocumentStatus.InnerText() != "ЗАВЕРШЕН")
                Log.Error("Значение статуса документа не соответсвует ожидаемому. Ожидалось, что статус будет - Завершен");
            return new AutomationBasePage();
        }
    }
}
