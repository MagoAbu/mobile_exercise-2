
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Automation
{
    public class AutomationBusinessProcessFrame
    {

        WebItem BusinessProcessCreationFrame => new WebItem("//iframe[@class='side-panel-iframe']", 
            "Фрейм создания бизнес-процесса");

        WebItem ContinueButton => new WebItem("//button[@id='lists-element-creation-guide-next-button']", 
            "Кнопка \"Продолжить\" во фрейме создания бизнес-процесса");

        public AutomationBusinessProcessCreationPage NavigateToBusinessProcessCreationFrame()
        {
            BusinessProcessCreationFrame.SwitchToFrame();
            ContinueButton.Click();
            return new AutomationBusinessProcessCreationPage();
        }
    }
}
