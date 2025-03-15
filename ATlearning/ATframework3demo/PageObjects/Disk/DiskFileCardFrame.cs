using atFrameWork2.BaseFramework.LogTools;
using atFrameWork2.SeleniumFramework;
using OpenQA.Selenium;

namespace ATframework3demo.PageObjects.Disk
{
    public class DiskFileCardFrame
    {
        WebItem FileName => new WebItem("//span[@id='pagetitle' and text()='ALBO4718.MP4']", "Имя файла в шапке страницы");

        public DiskFileCardFrame CheckFileName()
        {
            string actualFileName = FileName.InnerText();
            string expectedFileName = "ALBO4718.MP4";
            if (actualFileName != expectedFileName)
            {
                Log.Error($"Имя файла не соответсвует ожидаемому имени: {expectedFileName}");
            }
            return new DiskFileCardFrame();
        }

        WebItem UserName => new WebItem("//a[@class='disk-detail-sidebar-user-access-link'" +
            " and text()='ИванIIILILXXIIIXXXIIII ЧёXIIIILILXXIIIXXXIIII']", 
            "Имя юзера в колонке \"Общий доступ\"");

        public DiskFileCardFrame CheckUserName()
        {
            string actualUserName = UserName.InnerText();
            string expectedUserName = "ИванIIILILXXIIIXXXIIII ЧёXIIIILILXXIIIXXXIIII";
            if (actualUserName != expectedUserName)
            {
                Log.Error($"Имя пользователя не соответсвует ожидаемому имени: {expectedUserName}");
            }
            return new DiskFileCardFrame();
        }

        WebItem FileSize => new WebItem("//td[text()='38.07 МБ']", "Размер файла в поле с инфомрацией о файле");

        public DiskFileCardFrame CheckFileSize()
        {
            string actualFileSize = FileSize.InnerText();
            string expectedFileSize = "38.07 МБ";
            if (actualFileSize != expectedFileSize)
            {
                Log.Error($"Размер файла не соответсвует ожидаемому размеру: {expectedFileSize}");
            }

            return new DiskFileCardFrame();
        }

        WebItem FrameFileCardClose => new WebItem("//div[@title='Закрыть']", "Крестик закрытия страницы фрейма карточки файла");

        WebItem FileFrame => new WebItem("//Iframe[contains(@src,'/company/personal/user/1/disk/file/ALBO4718.MP4')]", "Фрейм карточки добавленного файла");
    }
}
