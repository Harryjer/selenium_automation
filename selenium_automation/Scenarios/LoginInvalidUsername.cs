using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using NUnit.Framework;

namespace selenium_automation.Scenarios
{
    public class LoginInvalidUsername
    {
        IAlert alert;

        public LoginInvalidUsername()
        {

        }

        [SetUp]
        public void Initialize()
        {
            Action.InitializedDriver();
            NavigateTo.LoginFormThroughTheMenu();
        }

        [Test]
        public void LessThan5Chars()
        {
            Action.FillLoginForm(Config.Credentials.InValid.Username.FourCharactors, Config.Credentials.Valid.Password, Config.Credentials.Valid.Password);

            alert = Driver.driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMessages.UsernameLengthOutofRange, alert.Text);
            alert.Accept();
        }

        [Test]
        public void MoreThan12Chars()
        {
            Action.FillLoginForm(Config.Credentials.InValid.Username.ThirteenCharactors, Config.Credentials.Valid.Password, Config.Credentials.Valid.Password);
            alert = Driver.driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMessages.UsernameLengthOutofRange, alert.Text);
            alert.Accept();
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
}
