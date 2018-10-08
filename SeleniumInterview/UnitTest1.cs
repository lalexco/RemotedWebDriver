using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace SeleniumInterview
{
    [TestClass]
    public class UnitTest1
    {
        Chrome chrome;
        ReadTxt readTxt;

        [TestInitialize]
        public void CreateBrowser()
        {
            chrome = new Chrome();
            readTxt = new ReadTxt();
            chrome.CreateBrowser();
            chrome.GoTo(readTxt.GetURL);
        }

        [TestMethod]
        public void PositiveScenario()
        {
            IWebElement WelcomePageTitle = null;
            IWebElement Login = null;

            IWebElement UserName = null;
            IWebElement Password = null;

            IWebElement MyNotestitle = null;

            WelcomePageTitle = chrome.Find(By.XPath("//div[@id = 'welcome-page']//child::h1"));
            Assert.AreEqual("Welcome to our test page!", WelcomePageTitle.Text.Trim(), "The expected message for the welcome page is not correct... " + WelcomePageTitle.Text.Trim());

            Login = chrome.Find(By.CssSelector(".button-login"));
            chrome.Click(Login);

            UserName = chrome.Find(By.Name("login.username"));
            Password = chrome.Find(By.Name("login.password"));
            Login = chrome.Find(By.CssSelector(".button-login"));

            bool VerifyUser = chrome.verifyElementVisible(UserName);
            bool VerifyPassword = chrome.verifyElementVisible(Password);

            Assert.IsTrue(VerifyUser, "Username is present on the DOM but not for the user");
            Assert.IsTrue(VerifyPassword, "Password is present on the DOM but not for the user");

            chrome.SendText(UserName, readTxt.GetUsername);
            chrome.SendText(Password, readTxt.GetPassword);
            chrome.Click(Login);

            MyNotestitle = chrome.Find(By.CssSelector("div#my-notes-page > h2"));

            Assert.AreEqual("My Notes", MyNotestitle.Text.Trim());
        }

        [TestCleanup]
        public void FinishBrowser()
        {
            chrome.EndBrowser();

        }
    }
}
