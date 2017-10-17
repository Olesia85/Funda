using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Web.QA.E2E.PageObjects
{
    class MainPage
    {
        //Objects
        [FindsBy(How = How.CssSelector, Using = "#autocomplete-input")]
        public IWebElement AddressField { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#range-filter-selector-select-filter_koopprijsvan")]   
        public IWebElement FromDropDown { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#range-filter-selector-select-filter_huurprijsvan")]
        public IWebElement FromDropDownForRent { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#range-filter-selector-select-filter_koopprijstot")]
        public IWebElement ToDropDown { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#range-filter-selector-select-filter_huurprijstot")]
        public IWebElement ToDropDownForRent { get; set; }
        [FindsBy(How = How.CssSelector, Using = "div.search-block__submit")]
        public IWebElement SearchButton { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='content']/div[1]/div[3]/form/nav/ul/li[2]/a")]
        public IWebElement ForRentButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div[1]/div[3]/form/nav/ul/li[3]/ul/li[1]/a")]
        public IWebElement NewConstructionButton { get; set; }


        public void AddressFieldSendNewKeys(string value)
        {
            AddressField.Clear();
            AddressField.SendKeys(value);
        }

        public void AdressFieldSearchByReturn(string value)
        {
            int wait = 3000;
            AddressFieldSendNewKeys(value);
            Thread.Sleep(wait);
            AddressField.SendKeys(Keys.Return);
            Thread.Sleep(wait);
            AddressField.SendKeys(Keys.Return);
        }

    }
}

