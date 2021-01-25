using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace selenium_automation
{
    class entryPoint
    {
        static void Main()
        {
            Menu menu = new Menu();
            Driver.driver.Navigate().GoToUrl("https://testing.todorvachev.com/");
            menu.Selectors.Click();
        }
    }
}
