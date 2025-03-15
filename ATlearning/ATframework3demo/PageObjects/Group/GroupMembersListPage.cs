
using atFrameWork2.SeleniumFramework;
using atFrameWork2.TestEntities;

namespace ATframework3demo.PageObjects.Group
{
    public class GroupMembersListPage
    {
        WebItem ContinueBtn => new WebItem("//span[@class='ui-btn-text' and text()='Продолжить']", 
            "Кнопка продолжить на странице \"Участники\"");

        public GroupMembersListPage SelectMembers(Bitrix24_Project user)
        {
            var SelectedUser = new WebItem($"//div[@class='ui-selector-item-title' and text()='{user.NameLastName}']", 
                "Выбираем добавленного нами на портал юзера");
            SelectedUser.Click();   
            ContinueBtn.Click();
            return new GroupMembersListPage();
        }

        public GroupProjectFramePage ExitPreviousFrame()
        {
            WebDriverActions.SwitchToDefaultContent();
            return new GroupProjectFramePage();
        }
    }
}
