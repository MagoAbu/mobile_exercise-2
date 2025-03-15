
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Automation
{
    public class AutomationBusinessProcessTemplatesPage
    {

        WebItem BurgerMenu => new WebItem("//a[@title='Действия']/ancestor::td[@class='bx-actions-col bx-left']", 
            "Бургер меню \"Действия\" слева от названия бизнес-процесса");

        public AutomationBurgerMenuList ClickBurgerMenu()
        {
            BurgerMenu.Click();
            return new AutomationBurgerMenuList();
        }
    }
}
