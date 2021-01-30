﻿using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static System.Console;
using static System.Math;

namespace selenium_automation.UIelements
{
    public class TestScenarioPage
    {
        public TestScenarioPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }
        [FindsBy(How =How.CssSelector, Using = "#main-content > article.mh-loop-item.mh-clearfix.post-72.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-test-scenarios > div > header > h3 > a")]
        public IWebElement LoginForm { get; set; }
    }

}
