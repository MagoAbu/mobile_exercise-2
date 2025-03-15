
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Group
{
    public class GroupPrivacyLevelsPage
    {
        WebItem ClosedPrivacyLevel => new WebItem("//div[text()='Закрытый']/ancestor::" +
            "div[@class='socialnetwork-group-create-ex__group-selector']",
            "Поле выбора уровня конфиденциальности проекта \"Закрытый\"");

        WebItem ContinueBtn => new WebItem("//button[@id='sonet_group_create_popup_form_button_submit']",
            "Кнопка \"Продолжить страницы \"Возможности\"");

        public GroupProjectMembersPage SelectProjectPrivacyLevel()
        {
            ClosedPrivacyLevel.Click();
            ContinueBtn.Click();
            return new GroupProjectMembersPage();
        }
    }
}
