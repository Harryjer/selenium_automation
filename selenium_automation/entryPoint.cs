using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace selenium_automation
{
    class entryPoint
    {
        static void Main()
        {
            
            Driver.driver.Navigate().GoToUrl("https://testing.todorvachev.com/");
            NavigateTo.LoginFormThroughTheMenu();
            Thread.Sleep(500);

            Driver.driver.Navigate().GoToUrl("https://testing.todorvachev.com/");
            NavigateTo.LoginFormThroughThePost();
            Thread.Sleep(5000);
        }
    }
}
