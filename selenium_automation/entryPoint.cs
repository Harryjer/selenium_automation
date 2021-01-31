using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using selenium_automation.UIelements;
using NUnit.Framework;

namespace selenium_automation
{
    public class entryPoint
    {
        IAlert alert;
        static void Main()
        {           
            
        }

        [SetUp]
        public void Initialize()
        {
            Action.InitializedDriver();
        }

        [Test]
        public void ValidLogin()
        {
            NavigateTo.LoginFormThroughTheMenu();
            Action.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);

            alert = Driver.driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMessages.SuccessfullLogin, alert.Text);
            alert.Accept();
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
