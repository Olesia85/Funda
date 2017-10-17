using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Drawing;

namespace Web.QA.E2E.Utilities
{
    class FundaDriver : IWebDriver
    {
        private static IWebDriver driver;
        private static WebDriverWait wait;
        private static IJavaScriptExecutor jsExecutor;
        private static Actions builder;
        
        private static readonly Destructor Finalise = new Destructor();
        static FundaDriver()
        {
            driver = Initialize();
        }

        private static IWebDriver Initialize()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            jsExecutor = driver as IJavaScriptExecutor;

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            builder = new Actions(driver);

            return driver;
        }
        private sealed class Destructor
        {
            ~Destructor()
            {
                driver.Quit();
            }
        }
        public string Url { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Title => throw new NotImplementedException();

        public string PageSource => throw new NotImplementedException();

        public string CurrentWindowHandle => throw new NotImplementedException();

        public ReadOnlyCollection<string> WindowHandles => throw new NotImplementedException();

        public void Close()
        {
            driver.Close();
        }

        public void Dispose()
        {
            driver.Dispose();
        }

        public IWebElement FindElement(By by)
        {
            return driver.FindElement(by);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return driver.FindElements(by);
        }

        public IOptions Manage()
        {
            throw new NotImplementedException();
        }

        public INavigation Navigate()
        {
            return driver.Navigate();
        }

        public void Quit()
        {
            driver.Quit();
        }

        public void HowerOnElement(IWebElement onElement)
        {
            builder.MoveToElement(onElement).Click().Build().Perform();
        }
        public ITargetLocator SwitchTo()
        {
            throw new NotImplementedException();
        }
    }
}
