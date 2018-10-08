using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumInterview
{
    internal class Chrome
    {
        internal IWebDriver Driver;

        internal void CreateBrowser()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Driver.Manage().Window.Maximize();

        }

        public void GoTo(string value)
        {
            Driver.Navigate().GoToUrl(value);

        }

        public IWebElement Find(By path)
        {
            IWebElement element = Driver.FindElement(path);
            return element;

        }

        public void SendText(IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        public void Click(IWebElement element)
        {
            element.Click();

        }

        public bool verifyElementVisible(IWebElement element)
        {
            bool isVisible = false;

            if (element.Displayed)
            {
                isVisible = true;
            }

            return isVisible;

        }

        public void EndBrowser()
        {
            Driver.Close();
            Driver.Quit();

        }
    }
}
