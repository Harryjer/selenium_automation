using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using selenium_automation.UIelements;

namespace selenium_automation
{
    public class entryPoint
    {
        static void Main()
        {
            
            Driver.driver.Navigate().GoToUrl("https://testing.todorvachev.com/");
            NavigateTo.LoginFormThroughTheMenu();
            Action.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);

        }
    }
}
