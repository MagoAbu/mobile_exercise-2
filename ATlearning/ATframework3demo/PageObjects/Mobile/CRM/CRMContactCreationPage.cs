
using atFrameWork2.SeleniumFramework;
using atFrameWork2.TestEntities;
using ATframework3demo.PageObjects.Mobile.CRM.Deal;

namespace ATframework3demo.PageObjects.Mobile.CRM
{
    public class CRMContactCreationPage
    {
        public DealCreationPage CreateContact(Bitrix24_Project name)
        {
            var contactName = new MobileItem("//android.widget.TextView[@content-desc=\"deal_0_details_editor_OPPORTUNITY_WITH_CURRENCY_amount_NAME\"]", 
                "Пункт \"Name/Имя\" на странице создания контакта");
            contactName.Click();

            //Вписали имя контакта
            var contactNameInput = new MobileItem("//*[@text=\"Complete the field\"]", 
                "Поле ввода имени контакта");
            contactNameInput.SendKeys($"{name.Name}");

            //Сохранили контакт
            var saveContactInfo = new MobileItem("//android.widget.TextView[@text=\"Save\"]", 
                "Кнопка \"Save/Сохранить\"");
            saveContactInfo.Click();

            //Завершаем создание контакта 
            var createContactButton = new MobileItem("(//android.widget.TextView[@text=\"Create\"])[2]", 
                "Кнопка \"Create/Создать\"");
            createContactButton.Click();

            return new DealCreationPage();
        }
    }
}
