
using atFrameWork2.SeleniumFramework;
using atFrameWork2.TestEntities;
using ATframework3demo.TestEntities;

namespace ATframework3demo.PageObjects.Mobile.CRM.Deal
{
    public class DealCreationPage
    {
        public CRMContactListPage FillDealCreationFields(Bitrix24_MobileCRMDeal dealEntity)
        {
            //Вводим название сделки
            var dealNameitem = new MobileItem("//android.widget.TextView[@content-desc=\"deal_0_details_editor_TITLE_NAME\"]", 
                "Пункт формы \"Название\"");
            dealNameitem.Click();

            var dealNameTextInput = new MobileItem("//android.widget.EditText[@text=\"Deal #\"]", 
                "Поле ввода названия сделки");
            dealNameTextInput.SendKeys($"{dealEntity.dealName}");

            var saveDealNameButton = new MobileItem("(//android.widget.LinearLayout[@resource-id=\"com.bitrix24.android:id/rightButtonContainer\"])[4]", 
                "Кнопка \"Сохранить\" в поле ввода названия сделки");
            saveDealNameButton.Click();

            //Вводим сумму сделки
            var dealSum = new MobileItem("//android.widget.EditText[@text=\"0\"]", 
                "Поле ввода суммы сделки");
            dealSum.SendKeys($"{dealEntity.sumOfDeal}");

            //Добавить контакт
            var contactItem = new MobileItem("//android.widget.TextView[@text=\"Add contact\"]", 
                "Пункт \"Add Contact/Добавить контакт\"");
            contactItem.Click();

            return new CRMContactListPage();
        }

        public DealCreationPage FinishCreateDeal()
        {
            var createDealButton = new MobileItem("//android.widget.TextView[@text=\"Create\"]", 
                "Кнопка \"Create/Создать\" сделку");
            createDealButton.Click();
            return new DealCreationPage();
        }

        public MobileMainPanel ReturnOnDealListPage()
        {
            var returnButton = new MobileItem("//android.view.ViewGroup[@resource-id=\"com.bitrix24.android:id/global_avatar_view\"]/android.view.View", 
                "Кнопка вовзрата к списку созданных сделок");
            returnButton.Click();
            return new MobileMainPanel();
        }
    }
}
