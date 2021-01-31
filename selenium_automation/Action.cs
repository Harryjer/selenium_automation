using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using System.Threading;
using static System.Console;
using static System.Math;
using selenium_automation.UIelements;
using System;

namespace selenium_automation
{
    public static class Action
    {
        public static void InitializedDriver()
        {
            Driver.driver.Navigate().GoToUrl(Config.BaseUrl);
        }
        public static void FillLoginForm(string username, string password, string repeatPassword)
        {
            LoginScenarioPost lsPost = new LoginScenarioPost();

            lsPost.UsernameField.SendKeys(username);
            lsPost.PasswordField.SendKeys(password);
            lsPost.RepeatPasswordField.SendKeys(repeatPassword);
            lsPost.LoginButton.Click();
        }

        internal static void FillLoginForm(string username, object fourCharactors1, object fourCharactors2)
        {
            throw new NotImplementedException();
        }
    }
}
