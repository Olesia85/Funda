using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.QA.E2E.PageObjects
{
    class SearchResultsPage
    {
        //Objects
        [FindsBy(How = How.CssSelector, Using = ".button-applied-filter")]
        public IWebElement FilterParametrs { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#content .search-result-price")]
        public IWebElement Price { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#content .search-result-subtitle")]
        public IWebElement Address { get; set; }
        [FindsBy(How = How.CssSelector, Using = "div.search-content-output > ol:nth-child(3) > li:nth-child(1) > div.search-result-main > div.search-result-content > div > div:nth-child(3) > ul > li:nth-child(2)")]
        public IWebElement Rooms { get; set; }
        [FindsBy(How = How.CssSelector, Using = "div.search-content > div.search-content-output > ol:nth-child(3) > li:nth-child(1) > div.search-result-main > div.search-result-content > div > div:nth-child(3) > ul > li:nth-child(1) > span")]
        public IWebElement Area { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#filters > div.search-sidebar-filters > div:nth-child(8) > fieldset > ul > li:nth-child(5) > div > label > span:nth-child(1)")]
        public IWebElement fourplusRadiobutton { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#filters > div.search-sidebar-filters > div:nth-child(9) > fieldset > ul > li:nth-child(3) > div > label")]
        public IWebElement SeventyFivePlusRadiobutton { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#content > form > div.container.search-main > div.search-content > div.search-content-header > div.applied-filters.is-visible > div > button:nth-child(2)")]
        public IWebElement RoomFilterParametrs { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#content > form > div.container.search-main > div.search-content > div.search-content-header > div.applied-filters.is-visible > div > button:nth-child(3)")]
        public IWebElement FloorAreaParametrs { get; set; }
    }
}
