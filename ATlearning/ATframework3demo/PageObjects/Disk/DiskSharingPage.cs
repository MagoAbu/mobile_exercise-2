
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Disk
{
    public class DiskSharingPage
    {
        WebItem InputAddedUsers => new WebItem("//div[@id='feed-add-post-destination-container']",
            "Кнопка \"Добавить ещё\" в окне \"Общий доступ\"");
        //После нажатия на кнопку "Добавить еще" открывается окно с пользователями 
        //Здесь переходим в это кно
        public DiskAddUserPage AddUser()
        {
            InputAddedUsers.Click();
            return new DiskAddUserPage();
        }

        WebItem AccessRights => new WebItem("//a[@class='bx-disk-filepage-used-people-permission']",
            "Кнопка выбора прав доступа");

        WebItem ReadAccess => new WebItem("//span[@class='menu-popup-item-text' and text()='Чтение']",
            "Вкладка \"Чтение\"");
        //После выдачи прав на чтение попадаем на страницу "Общий доступ"
        public DiskSharingPage GrantReadAccess()
        {
            AccessRights.Click();
            ReadAccess.Click();
            return new DiskSharingPage();
        }

        WebItem BtnSaveWindowsSharing => new WebItem("//span[@class='ui-btn ui-btn-success']",
            "Кнопка \"Сохранить\" окна \"Общий доступ\"");

        //После всех действий с юзером нажимаем "Сохранить" и попадаем на главную страницу Диска
        public DiskBasePage SaveAccessAndUserSettings()
        {
            BtnSaveWindowsSharing.Click();
            WebDriverActions.Refresh();
            return new DiskBasePage();
        }
    }
}
