using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static System.Console;
using static System.Math;

namespace selenium_automation.UIelements
{
    public class TestCasesPage
    {
        public TestCasesPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
        [FindsBy(How = How.CssSelector, Using = "#main-content > article.mh-loop-item.mh-clearfix.post-70.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-test-scenarios > div > header > h3 > a")]
        public IWebElement RegisterForm { get; set; }

    }
}
