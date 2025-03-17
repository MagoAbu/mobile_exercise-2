using atFrameWork2.SeleniumFramework;
using ATframework3demo.PageObjects.Mobile.Deal;

namespace ATframework3demo.PageObjects.Mobile
{
    /// <summary>
    /// Главная панель приложения
    /// </summary>
    public class MobileMainPanel
    {
        public MobileTasksListPage SelectTasks()
        {
            var tasksTab = new MobileItem("//android.widget.TextView[@resource-id=\"com.bitrix24.android:id/bb_bottom_bar_title\" and @text=\"Tasks\"]",
                "Таб 'Задачи'");
            tasksTab.Click();

            return new MobileTasksListPage();
        }

        public MobileMainFunctionMenu OpenMenu()
        {
            var moreButton = new MobileItem("//android.widget.FrameLayout[@content-desc=\"bottombar_tab_more_counter_1\"]/android.widget.LinearLayout/android.widget.ImageView", 
                "Кнопке \"More/Ещё\" в футере базовой страницы приложения");
            moreButton.Click();
            return new MobileMainFunctionMenu();
        }
    }
}