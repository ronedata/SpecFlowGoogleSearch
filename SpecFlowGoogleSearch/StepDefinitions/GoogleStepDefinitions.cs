using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowGoogleSearch.StepDefinitions
{
    [Binding]
    public class GoogleStepDefinitions
    {
        readonly WebDriver driver;


        string baseUrl = "https://www.bing.com/";
        public GoogleStepDefinitions()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("--remote-debugging-pipe");
            option.AddArgument("--headless");
            option.AddArgument("no-sandbox");
            option.AddArgument("--window-size=1920,1080");
            driver = new ChromeDriver(option);           
        }

        [Given(@"Go to google page")]
        public void GivenGoToGooglePage()
        {
            Thread.Sleep(2000);
            //driver.Navigate().GoToUrl(baseUrl);
            driver.Url = baseUrl;
            driver.Manage().Window.Maximize();
        }

        [When(@"I search for ""([^""]*)""")]
        public void WhenISearchFor(string SearchText)
        {
            //var search = driver.FindElement(By.XPath("//input[@id='sb_form_q']"));
            //search.SendKeys(SearchText);

            //var searchButton = driver.FindElement(By.XPath("(//input[@name='btnK'])[2]"));
            //searchButton.Click();
            //search.Submit();
            //Actions actions = new Actions(driver);
            //actions.SendKeys(Keys.Enter).Perform();
        }


        [Then(@"I should see title ""([^""]*)""")]
        public void ThenIShouldSeeTitle(string title)
        {
            Thread.Sleep(2000);
            var driverTitle = driver.Title;
            //var driverTitle = "Bing";
            Assert.AreEqual(driverTitle, title);
            driver.Quit();
        }


    }
}

