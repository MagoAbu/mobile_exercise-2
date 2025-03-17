
using atFrameWork2.SeleniumFramework;
using ATframework3demo.PageObjects.Mobile.CRM.Deal;

namespace ATframework3demo.PageObjects.Mobile.CRM
{
    public class CRMEntityList
    {
        public DealCreationPage SelectDeal()
        {
            var dealItemOnEntityList = new MobileItem("//android.view.ViewGroup[@content-desc=\"CRM_ENTITY_TAB_DEAL_CONTEXT_MENU_2\"]" +
                "/android.view.ViewGroup[1]/android.view.ViewGroup[2]/android.view.ViewGroup[1]" +
                "/android.view.ViewGroup/android.view.ViewGroup", 
                "Пункт списка сущностей \"Сделки\"");
            dealItemOnEntityList.Click();
            return new DealCreationPage();
        }
    }
}
