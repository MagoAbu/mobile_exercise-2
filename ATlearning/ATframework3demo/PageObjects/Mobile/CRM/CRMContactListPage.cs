
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Mobile.CRM
{
    public class CRMContactListPage
    {
        public CRMContactCreationPage AddContact()
        {
            var addContact = new MobileItem("//android.widget.FrameLayout[@content-desc=\"ENTITY_SELECTOR_PLUS_BUTTON\"]/android.widget.FrameLayout",
                "Иконка плюс (Создание нового контакта)");
            addContact.Click();
            return new CRMContactCreationPage();
        }
    }
}
