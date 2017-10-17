using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Web.QA.E2E.PageObjects;
using Web.QA.E2E.Utilities;


namespace Web.QA.E2E.Steps
{
    [Binding]
    class MainPageSteps
    {
        private FundaDriver driver = new FundaDriver();
        private MainPage fundaMainPage = new MainPage();
        private SearchResultsPage fundaSearchResultPage = new SearchResultsPage();

        public MainPageSteps()
        {
            PageFactory.InitElements(driver, fundaMainPage);
            PageFactory.InitElements(driver, fundaSearchResultPage);
        }

        [Given(@"I navigate to '(.*)' page")]
        [Then(@"I navigate to '(.*)' page")]
        public void GivenINavigateToPage(string value)
        {
            switch (value)
            {
                case "Main":
                    driver.Navigate().GoToUrl(Properties.Settings.Default.UrlWeb);
                    break;

                case "Search":
                    driver.Navigate().GoToUrl("https://www.funda.nl/en/koop/diemen/50000-75000/");
                    break;

                default:
                    Assert.IsFalse(true, "Case undefined");
                    break;
            }
        }

        [When(@"I enter '(.*)' in to the address field")]
        [Then(@"I enter '(.*)' in to the address field")]
        public void WhenIEnterInToTheAddressField(string value)
        {
            fundaMainPage.AddressFieldSendNewKeys(value);
        }
        
        [Then(@"I enter '(.*)' in to the address field and press return button")]
        public void ThenIEnterInToTheAddressFieldAndPressReturnButton(string value)
        {
            fundaMainPage.AdressFieldSearchByReturn(value);
        }
        
        [When(@"I select price '(.*)' from the drop-down '(.*)'")]
        [Then(@"I select price '(.*)' from the drop-down '(.*)'")]
        public void WhenISelectPriceFromTheDrop_Down(string value, string dropDown)
        {
            switch (dropDown)
            {
                case "From, for by":
                    fundaMainPage.FromDropDown.Click();
                    new SelectElement(fundaMainPage.FromDropDown).SelectByValue(value);
                    break;

                case "To, for buy":
                    fundaMainPage.ToDropDown.Click();
                    new SelectElement(fundaMainPage.ToDropDown).SelectByValue(value);
                    break;

                case "From, for rent":
                    fundaMainPage.FromDropDownForRent.Click();
                    new SelectElement(fundaMainPage.FromDropDownForRent).SelectByValue(value);
                    break;

                case "To, for rent":
                    fundaMainPage.ToDropDownForRent.Click();
                    new SelectElement(fundaMainPage.ToDropDownForRent).SelectByValue(value);
                    break;

                default:
                    Assert.IsFalse(true, "Case undefined");
                    break;
            }
        }

        [When(@"I click '(.*)'")]
        [Then(@"I click '(.*)'")]
        public void WhenIClick(string value)
        {
            switch (value)
            {
                case "Search button":
                    Thread.Sleep(5000);
                    fundaMainPage.SearchButton.Click();
                    break;

                case "For rent button":
                    driver.HowerOnElement(fundaMainPage.ForRentButton);
                    break;

                case "New construction button":
                    driver.HowerOnElement(fundaMainPage.NewConstructionButton);
                    break;

                case "4+ rooms radiobutton":
                    fundaSearchResultPage.fourplusRadiobutton.Click();
                    break;

                case "75+ m2":
                    fundaSearchResultPage.SeventyFivePlusRadiobutton.Click();
                    break;

                default:
                    Assert.IsFalse(true, "Case undefined");
                    break;
            }
        }

    }




}
