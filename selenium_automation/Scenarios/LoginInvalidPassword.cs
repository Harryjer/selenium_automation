using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using NUnit.Framework;

namespace selenium_automation.Scenarios
{
    public class LoginInvalidPassword
    {
        IAlert alert;

        public LoginInvalidPassword()
        {

        }

        [SetUp]
        public void Initialize()
        {
            Action.InitializedDriver();
            NavigateTo.LoginFormThroughThePost();
        }

        [Test]
        public void LessThan5Chars()
        {
            Action.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.InValid.Password.FourCharactors, Config.Credentials.InValid.Password.FourCharactors);

            alert = Driver.driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMessages.PasswordLengthOutofRange, alert.Text);
            alert.Accept();
        }

        [Test]
        public void MoreThan12Chars()
        {
            Action.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.InValid.Password.ThirteenCharactors, Config.Credentials.InValid.Password.ThirteenCharactors);
            alert = Driver.driver.SwitchTo().Alert();
            Assert.AreEqual(Config.AlertMessages.PasswordLengthOutofRange, alert.Text);
            alert.Accept();
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
}
