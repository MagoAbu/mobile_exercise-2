using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Disk
{
    public class DiskConfirmDeletePopup
    {
        WebItem PermanentlyDeleteFile => new WebItem("//div[@class='popup-window-buttons']/span[text()='Удалить навсегда']", "Кнопка \"Удалить навсегда\"");

        public DiskBasePage PermanentlyFileRemove()
        {
            PermanentlyDeleteFile.Click();
            return new DiskBasePage();
        }
    }
}
