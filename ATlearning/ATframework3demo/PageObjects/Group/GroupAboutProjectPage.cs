
using atFrameWork2.SeleniumFramework;
using ATframework3demo.BaseFramework;
using ATframework3demo.TestEntities;

namespace ATframework3demo.PageObjects.Group
{
    public class GroupAboutProjectPage
    {
        WebItem ProjectNameInputField => new WebItem("//input[@id='GROUP_NAME_input']", 
            "Поле ввода названия проекта");

        WebItem ContinueBtn => new WebItem("//button[@id='sonet_group_create_popup_form_button_submit']", 
            "Кнопка \"Продолжить\" страницы \"Возможности\"");

        public GroupPrivacyLevelsPage EnterProjectName(Bitrix24_Project fileName)
        {
            ProjectNameInputField.SendKeys($"{fileName.ProjectName}");
            ContinueBtn.Click();
            return new GroupPrivacyLevelsPage();
        }
    }
}
