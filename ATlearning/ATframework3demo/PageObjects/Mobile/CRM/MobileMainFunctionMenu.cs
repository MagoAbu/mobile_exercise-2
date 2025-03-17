
using atFrameWork2.BaseFramework.LogTools;
using atFrameWork2.SeleniumFramework;
using ATframework3demo.PageObjects.Mobile.CRM;
using ATframework3demo.TestEntities;

namespace ATframework3demo.PageObjects.Mobile.Deal
{
    public class MobileMainFunctionMenu
    {
        public CRMBasePage OpenCRM()
        {
            var crmItem = new MobileItem("//android.widget.TextView[@resource-id=\"com.bitrix24.android:id/title\" " +
                "and @text=\"CRM\"]", 
                "Пункт \"CRM\" в меню");
            crmItem.Click();
            return new CRMBasePage();
        }

        public CRMBasePage IsDealCreated(Bitrix24_MobileCRMDeal dealEntity)
        {
            var createdDealName = new MobileItem($"//android.widget.TextView[@content-desc=\"KANBAN_STAGE_SECTION_TITLE\" and @text=\"{dealEntity.dealName}\"]",
                "Созданная сделка на странице со списком сделок");
            if (createdDealName.GetText() != dealEntity.dealName)
            {
                Log.Error($"Название сделки не соответсвует ожидаемому. Ожидалось следующее название {dealEntity.dealName}");
            }
            return new CRMBasePage();
        }
    }
}
