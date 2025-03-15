
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Group
{
    public class GroupProjectMembersPage
    {
        WebItem AddMemberField => new WebItem("//div[@id='GROUP_USERS_selector']/div[@class='ui-tag-selector-outer-container']", 
            "Поле выбора участников проекта на странице \"Участники\"");

        public GroupMembersListPage OpenProjectMembersPage()
        {
            AddMemberField.Click();
            return new GroupMembersListPage();
        }
    }
}
