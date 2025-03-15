
using atFrameWork2.BaseFramework;
using atFrameWork2.BaseFramework.LogTools;
using atFrameWork2.SeleniumFramework;
using ATframework3demo.BaseFramework;
using ATframework3demo.TestEntities;
using OpenQA.Selenium;

namespace ATframework3demo.PageObjects.Disk
{
    public class DiskBasePage
    {

        WebItem MenuBtn => new WebItem("//button/span[@class='ui-btn-text']",
            "Кнопка \"Добавить\" на странице \"Диск\"");

        WebItem FileMenuItem => new WebItem("//input[@id='inputContainerFolderList']",
            "Кнопка \"Файл\", в выпадающем меню, появляющаяся при нажатии на кнопку \"Добавить\"");

        WebItem StatusCheckBox => new WebItem("//span[@class='bx-disk-popup-upload-file-progress-btn-end']",
            "Знак \"Галочка\", после загрузки файла ");

        WebItem ShareBtn => new WebItem("//div[@class='ui-action-panel-item ']/span[text()='Поделиться']",
            "Кнопка \"Поделиться\" на странице \"Диск\"");

        WebItem GenerallAccessBtn => new WebItem("//span[@class='menu-popup-item-text' and text()='Общий доступ']",
            "Пункт \"Общий доступ\" меню \"Поделиться\"");

        //После загрузки файла появляется окно загрузки.
        //Это окно есть класс "DiskUploadFilePage"
        public DiskUploadFilePage UploadFile()
        {
            MenuBtn.Click();
            FileMenuItem.SendKeys("C:\\me\\личное\\iPhone_magic\\ALBO4718.MP4");
            Waiters.WaitForCondition(() =>
            {
                bool dispalayed = StatusCheckBox.WaitElementDisplayed();
                return dispalayed;
            }, 5, 60, "Ожидание появления галочки");
            return new DiskUploadFilePage();
        }

        //После нажатия на кнопку "Поделиться" => "Общий доступ" появляется окно "Общий доступ"
        //Это окно есть класс "DiskSharingPage"   
        internal DiskSharingPage AddAccess()
        {
            ShareBtn.Click();
            GenerallAccessBtn.Click();
            return new DiskSharingPage();
        }


        WebItem CheckFileCard => new WebItem("//div[@class='disk-folder-list-item']" +
            "/div[@class='disk-folder-list-item-bottom']" +
            "/div/div/a[@title='ALBO4718.MP4']", "Карточка загруженного файла");

        WebItem MoreDetailsLink => new WebItem("//a[@title='Подробнее']",
            "Cсылка меню действий с файлом \"Подробнее\"");
        public DiskBasePage CheckReadAccess()
        {
            CheckFileCard.Click();
            MoreDetailsLink.Click();
            return new DiskBasePage();
        }

        WebItem FileFrame => new WebItem("//Iframe[contains(@src,'/company/personal/user/1/disk/file/ALBO4718.MP4')]", "Фрейм карточки добавленного файла");

        WebItem FileBurgerMenu => new WebItem("//a[@title='ALBO4718.MP4']/../../../../div[@class='disk-folder-list-item-action']", "Бурнер-меню карточки файла");
        

        public DiskFileCardFrame OpenFile()
        {
            FileBurgerMenu.Click();
            MoreDetailsLink.Click();
            FileFrame.SwitchToFrame();
            return new DiskFileCardFrame();     
        }

        //WebItem FileTitle => new WebItem("//a[@title='ALBO4718.MP4']", "Имя файла");

        //WebItem RemoveFile => new WebItem("//span[@onclick]/span[text()='Удалить']", "Пункт меню \"Удалить\" при клике на карточку файла");

        //public DiskConfirmDeletePopup CheckFileUpload()
        //{
        //    if (FileTitle.WaitElementDisplayed())
        //    {
        //        FileBurgerMenu.Click();
        //        RemoveFile.Click();
        //        Log.Info("Файл с таким именем уже загружен и, следовательно, будет выполнена замена");
        //    }
            
        //    return new DiskConfirmDeletePopup();
   
        //}
    }
}
