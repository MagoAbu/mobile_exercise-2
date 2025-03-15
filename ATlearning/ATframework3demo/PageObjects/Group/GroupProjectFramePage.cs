using atFrameWork2.SeleniumFramework;
using ATframework3demo.TestEntities;

namespace ATframework3demo.PageObjects.Group
{
    public class GroupProjectFramePage
    {
        WebItem ProjectFrame => new WebItem("//iframe[contains(@src, '/workgroups/group')]", 
            "Карточка нашего проекта");

        WebItem MessageBtn => new WebItem("//span[@id='feed-add-post-form-tab-message']",
            "Кнопка \"Сообщение\" в поле \"Лента\"");

        WebItem InputFieldFrame => new WebItem("//iframe[@class='bx-editor-iframe']",
            "Фрейи поля ввода сообщения в поле \"Лента\"");

        WebItem BodyField => new WebItem("//body[@contenteditable='true']", 
            "Поле, в которое вводим сообщение поста");

        WebItem CloseProjectCardButton => new WebItem("//div[@class='side-panel-label-icon side-panel-label-icon-close']" +
            "/ancestor::div[@class='side-panel-label']", 
            "Крестик закрытия карточки проекта");

        WebItem PostSubmitButton => new WebItem("//span[@id='blog-submit-button-save']",
            "Кнопка \"Отправить\" в карточке проекта");

        public GroupProjectFramePage NavigateToProjectCardThroughFrame()
        {
            ProjectFrame.SwitchToFrame();
            return new GroupProjectFramePage();
        }

        public GroupProjectFramePage AddPostToFeed(Bitrix24_Project text)
        {
            MessageBtn.Click();
            InputFieldFrame.SwitchToFrame();
            BodyField.SendKeys($"{text.MessageText}");
            WebDriverActions.SwitchToParentFrame();
            PostSubmitButton.Click();
            return new GroupProjectFramePage();
        }

        public GroupBasePage CloseCreatedProjectCard()
        {
            WebDriverActions.SwitchToDefaultContent();
            CloseProjectCardButton.Click();
            return new GroupBasePage();
        }
    }
}
