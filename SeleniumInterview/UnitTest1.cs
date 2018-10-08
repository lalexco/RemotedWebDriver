using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumInterview.PageObjects;

namespace SeleniumInterview
{
    [TestClass]
    public class UnitTest1
    {
        BasePage basePage;
        Welcome welcome;
        Login login;
        ReadTxt readText;

        [TestInitialize]
        public void BeforeEachTest()
        {
            basePage = new BasePage();
            readText = new ReadTxt();
            basePage.InitPages();
            welcome = new Welcome();
            login = new Login();
        }

        [TestMethod]
        public void PositiveScenario()
        {
            welcome.GoToPage(readText.GetURL)
                .DoClick(login.LoginBtn);

            login.SendValue(login.Username, readText.GetUsername)
                .SendValue(login.Password, readText.GetPassword)
                .DoClick(login.LoginBtn);

        }

        [TestCleanup]
        public void FinishBrowser()
        {

        }
    }
}
