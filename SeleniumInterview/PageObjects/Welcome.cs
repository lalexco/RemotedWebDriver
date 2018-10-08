using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumInterview.PageObjects
{
    public class Welcome : BasePage
    {
        public IWebElement WelComeTitle => DriverContext.FindElementByXPath("//div[@id = 'welcome-page']//child::h1");

        public Welcome GoToPage(string value)
        {
            GoTo(DriverContext, value);
            return this;
        }

        public Welcome DoClick(IWebElement elemement)
        {
            Click(elemement);
            return this;
        }

    }
}
