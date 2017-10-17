using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Web.QA.E2E.PageObjects;
using Web.QA.E2E.Utilities;

namespace Web.QA.E2E.Steps
{

    [Binding]
    class SearchResultsPageSteps
    {
        private FundaDriver driver = new FundaDriver();
        private SearchResultsPage fundaSearchResultsPage = new SearchResultsPage();

        public SearchResultsPageSteps()
        {
            PageFactory.InitElements(driver, fundaSearchResultsPage);
        }

        [When(@"I see range '(.*)' in filter parameters")]
        [Then(@"I see range '(.*)' in filter parameters")]
        public void ThenISeeEnterdInFilterParameters(string value)
        {
            Assert.AreEqual(value, fundaSearchResultsPage.FilterParametrs.GetAttribute("title"));
        }

        [Then(@"I see right price and address in search results")]
        public void ThenISeeRightPriceAndAddressInSearchResults()
        {
            Assert.AreEqual("1111 HJ Diemen", fundaSearchResultsPage.Address.Text);
            Assert.AreEqual("€ 50,000 k.k.", fundaSearchResultsPage.Price.Text);
        }

        [Then(@"I see right price '(.*)' and address '(.*)' in first search result")]
        public void ThenISeeRightPriceAndAddressInFirstSearchResult(string price, string address)
        {
            Assert.AreEqual(address, fundaSearchResultsPage.Address.Text);
            Assert.AreEqual(price, fundaSearchResultsPage.Price.Text);
        }

        [Then(@"I see right place '(.*)' in first search result")]
        public void ThenISeeRightPlaceInFirstSearchResult(string address)
        {
            Assert.AreEqual(address, fundaSearchResultsPage.Address.Text);
        }

        [Then(@"I see right number of rooms '(.*)' and floor area '(.*)' in first search result")]
        public void ThenISeeRightNumberOfRoomsAndFloorAreaInFirstSearchResult(string rooms, string area)
        {
            Thread.Sleep(5000);
            Assert.AreEqual(rooms, fundaSearchResultsPage.Rooms.Text);
            Assert.AreEqual(area, fundaSearchResultsPage.Area.Text);
        }

        [When(@"I see '(.*)' in  '(.*)' filter parameters")]
        [Then(@"I see '(.*)' in  '(.*)' filter parameters")]
        public void ThenISeeInFilterParameters(string value, string parametr)
        {
            switch (parametr)
            {
                case "number of rooms":
                    Assert.AreEqual(value, fundaSearchResultsPage.RoomFilterParametrs.GetAttribute("title"));
                    break;

                case "floor area":
                    Assert.AreEqual(value, fundaSearchResultsPage.FloorAreaParametrs.GetAttribute("title"));
                    break;

                default:
                    Assert.IsFalse(true, "Case undefined");
                    break;
            }
        }
            




    }
}

