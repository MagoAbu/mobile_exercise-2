
using atFrameWork2.BaseFramework;
using atFrameWork2.SeleniumFramework;

namespace ATframework3demo.PageObjects.Disk
{
    public class DiskUploadFilePage
    {
        //После загрузки файла нажимаю на кнопку "Закрыть". Здесь возвращаемый тип, это базовая страница пункта "Диск"
        //После закрытия окна попадем на базовую страницу Диска. Это класс "DiskBasePage"
        WebItem СloseNewDocumentUploadButton => new WebItem("//a[@id='FolderListButtonClose']", 
            "Кнопка \"Закрыть\" в окне загрзки документов");

        WebItem FileCard => new WebItem("\"//input[@value='ALBO4718.MP4']/../../../../div[@class='disk-folder-list-item-image']\"",
            "Карточка добавленного файла");

        public DiskBasePage СloseUploadWindow()
        {
            СloseNewDocumentUploadButton.Click();
            Waiters.WaitForCondition(() =>
            {
                bool dispalayed = FileCard.WaitElementDisplayed();
                return dispalayed;
            }, 1, 3, $"Ожидание появления: {FileCard}");
            return new DiskBasePage();
        }
    }
}
