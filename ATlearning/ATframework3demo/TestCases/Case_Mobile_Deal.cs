using atFrameWork2.BaseFramework;
using atFrameWork2.TestEntities;
using ATframework3demo.BaseFramework;
using ATframework3demo.PageObjects.Mobile;
using ATframework3demo.TestEntities;
using Bitrix24_Project = atFrameWork2.TestEntities.Bitrix24_Project;

namespace ATframework3demo.TestCases
{
    public class Case_Mobile_Deal : CaseCollectionBuilder
    {
        protected override List<TestCase> GetCases()
        {
            var caseCollection = new List<TestCase>();
            caseCollection.Add(
                new TestCase("Создание сделки", mobileHomePage => CreateDeal(mobileHomePage)));
            return caseCollection;
        }

        void CreateDeal(MobileHomePage homePage)
        {
            var dealEntity = new Bitrix24_MobileCRMDeal
            {
                dealName = "TestDeal" + DateTime.Now.Ticks,
                sumOfDeal = 10000.00
            };
            var contactName = new Bitrix24_Project() { Name = "Ivan" + DateTime.Now.Ticks };

            homePage
                .TabsPanel
            //Перейти в ЦРМ
                .OpenMenu()
                .OpenCRM()
            //Открыть страницу создания сделки
                .SelectEntityType()
                .SelectDeal()
            //Заполнить поля формы создания сделки
                .FillDealCreationFields(dealEntity)
            //Добавить контакт
                .AddContact()
                .CreateContact(contactName)
            //Завершить создание сделки
                .FinishCreateDeal()
                .ReturnOnDealListPage()
            //Проверить, что сделка создана
                .OpenMenu()
                .IsDealCreated(dealEntity);
        }
    }
}
