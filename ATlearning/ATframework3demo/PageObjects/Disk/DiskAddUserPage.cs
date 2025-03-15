
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Disk
{
    public class DiskAddUserPage
    {

        WebItem EmployeesAndDepartmentsList => new WebItem("//a[@id='destDepartmentTab_folder-list-destFormName']",
            "Вкладка \"Сотрудники и Отделы\"");

        WebItem User => new WebItem("//div[@class='bx-finder-company-department-employee-name'" +
            " and text()='ИванIIILILXXIIIXXXIIII ЧёXIIIILILXXIIIXXXIIII']",
            "Конкретный юзер в окне \"Люди\"");

        WebItem UserSelectionPageClose => new WebItem("//span[@class='popup-window-close-icon']", 
            "Крестик закрытия окна");

        //Заметка для себя
        //После добавления юзера закрываем окно и попадаем в окно "Общий доступ"  
        public DiskSharingPage CloseAddUserWindow()
        {
            EmployeesAndDepartmentsList.Click();
            User.Click();
            UserSelectionPageClose.Click();
            return new DiskSharingPage();
        }
    }
}
