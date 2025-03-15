
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Group
{
    public class GroupProjectCreationPage
    {
        WebItem ItemProject => new WebItem("//div[contains(text(), 'Проект')]" +
            "/ancestor::div[@class='socialnetwork-group-create-ex__group-selector " +
            "socialnetwork-group-create-ex__type-preset-selector --active']", 
            "Пункт \"Проект\" в окне выбора типа проектов");

        WebItem ContinueBtn => new WebItem("//button[@id='sonet_group_create_popup_form_button_submit']", 
            "Кнопка \"Продолжить\" в окне выбора типа проектов");

        public GroupAboutProjectPage SelectProjectType()
        {
            ItemProject.Click();
            ContinueBtn.Click();
            return new GroupAboutProjectPage();
        }
    }
}
