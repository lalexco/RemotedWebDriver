using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumInterview.PageObjects
{
    public class BasePage : Chrome
    {
        private static RemoteWebDriver _driver;
        public static RemoteWebDriver DriverContext
        {
            get { return _driver; }
            set { _driver = value; }
        }

        public void InitPages()
        {
            DriverContext = CreateBrowser();
        }
    }
}
