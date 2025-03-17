using atFrameWork2.BaseFramework.LogTools;
using atFrameWork2.SeleniumFramework;
using ATframework3demo.TestEntities;

namespace ATframework3demo.PageObjects.Mobile.CRM
{
    public class CRMBasePage
    {
        public CRMEntityList SelectEntityType()
        {
            var addEntityButton = new MobileItem($"//android.widget.FrameLayout[@content-desc=\"KANBAN_STAGE_ADD_BTN\"]",
                "Кнопка \"Плюс(создать сущность\" в футере страницы \"Сделки\"");
            addEntityButton.Click();
            return new CRMEntityList();
        }
    }
}
