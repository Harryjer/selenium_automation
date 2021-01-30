using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using System.Threading;
using static System.Console;
using static System.Math;
using selenium_automation.UIelements;

namespace selenium_automation
{
    public static class NavigateTo
    {
        public static void LoginFormThroughTheMenu()
        {
            Menu menu = new Menu();
            TestScenarioPage tsPage = new TestScenarioPage();
            menu.TestScenarios.Click();
            Thread.Sleep(500);
            tsPage.LoginForm.Click();
            Thread.Sleep(500);

        }

        public static void LoginFormThroughThePost()
        {
            Menu menu = new Menu();
            TestCasesPage tcPage = new TestCasesPage();
            UsernameFieldPost ufPost = new UsernameFieldPost();
            menu.TestCases.Click();
            Thread.Sleep(500);
            tcPage.RegisterForm.Click();
            Thread.Sleep(500);
            ufPost.LoginFormLink.Click();
            Thread.Sleep(500);
        }
    }
}
