using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumInterview
{
    public class Chrome
    {
        internal RemoteWebDriver Driver;

        internal RemoteWebDriver CreateBrowser()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Driver.Manage().Window.Maximize();
            //Driver.Navigate().GoToUrl("http://testapp.galenframework.com/");
            return Driver;

        }

        protected void GoTo(RemoteWebDriver driver, string value)
        {
            driver.Navigate().GoToUrl("http://testapp.galenframework.com/");

        }

        protected IWebElement Find(By path)
        {
            IWebElement element = Driver.FindElement(path);
            return element;

        }

        protected void SendText(IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        protected void Click(IWebElement element)
        {
            element.Click();

        }

        protected bool verifyElementVisible(IWebElement element)
        {
            bool isVisible = false;

            if (element.Displayed)
            {
                isVisible = true;
            }

            return isVisible;

        }

        protected void EndBrowser()
        {
            Driver.Close();
            Driver.Quit();

        }
    }
}
