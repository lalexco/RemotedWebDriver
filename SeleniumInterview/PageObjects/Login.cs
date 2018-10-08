using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumInterview.PageObjects
{
    public class Login : BasePage
    {
       public IWebElement Username => DriverContext.FindElementByName("login.username");
       public IWebElement Password => DriverContext.FindElementByName("login.password");
       public IWebElement LoginBtn => DriverContext.FindElementByCssSelector(".button-login");


        public Login SendValue(IWebElement elemement, string value)
        {
            SendText(elemement, value);
            return this;
        }

        public Login DoClick(IWebElement elemement)
        {
            Click(elemement);
            return this;
        }
    }
}
