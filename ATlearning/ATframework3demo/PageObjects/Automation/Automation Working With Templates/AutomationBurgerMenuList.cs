using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Automation
{
    public class AutomationBurgerMenuList
    {
        WebItem EditMenuItem => new WebItem("//td[@title='Изменить']/ancestor::" +
            "div[@class='popupitem']", 
            "Пункт бургер-меню \"Изменить\"");

        public AutomationBusinessProcessTemplateEditPage SelectEditItemFromBurgerMenu()
        {
            EditMenuItem.Click();
            return new AutomationBusinessProcessTemplateEditPage();
        }
    }
}
