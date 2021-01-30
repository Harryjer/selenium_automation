using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static System.Console;
using static System.Math;

namespace selenium_automation.UIelements
{
    public class UsernameFieldPost
    {
        public UsernameFieldPost()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
        [FindsBy(How = How.Name, Using = "userid")]
        public IWebElement LoginFormLink { get; set; }
    }
}
