using atFrameWork2.BaseFramework.LogTools;
using atFrameWork2.SeleniumFramework;
using ATframework3demo.TestEntities;
using OpenQA.Selenium;

namespace ATframework3demo.PageObjects
{
    public class NewsPage
    {
        public NewsPage(IWebDriver driver = default)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }

        public NewsPostForm AddPost()
        {
            //Клик в Написать сообщение
            var btnPostCreate = new WebItem("//div[@id='microoPostFormLHE_blogPostForm_inner']", "Область в новостях 'Написать сообщение'");
            btnPostCreate.Click(Driver);
            return new NewsPostForm(Driver);
        }

        public NewsPage VerifyPostAppearsInFeed(Bitrix24_Project messageText)
        {
            WebItem ActualTextMessage = new WebItem($"//div[@class='feed-post-text' and text()='{messageText.MessageText}']",
                "Текст поста в проекте");
            if(messageText.MessageText != ActualTextMessage.InnerText())
            {
                Log.Error($"Текст поста в созданном проекте не соответсвует ожидаемому тексту: {messageText.MessageText}");
            }
            return new NewsPage();
        }
    }
}
