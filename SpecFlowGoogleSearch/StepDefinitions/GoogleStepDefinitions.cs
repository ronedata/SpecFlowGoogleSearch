using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowGoogleSearch.StepDefinitions
{
    [Binding]
    public class GoogleStepDefinitions
    {
        WebDriver driver;
        string baseUrl = "https://www.google.com/";
        public GoogleStepDefinitions()
        {
            driver = new ChromeDriver();
        }

        [Given(@"Go to google page")]
        public void GivenGoToGooglePage()
        {
            //driver.Navigate().GoToUrl(baseUrl);
            driver.Url = baseUrl;
            driver.Manage().Window.Maximize();
        }

        [When(@"I search for ""([^""]*)""")]
        public void WhenISearchFor(string SearchText)
        {
            var search = driver.FindElement(By.Name("q"));
            search.SendKeys(SearchText);

            var searchButton = driver.FindElement(By.XPath("(//input[@name='btnK'])[2]"));
            searchButton.Click();
            //search.Submit();
        }


        [Then(@"I should see title ""([^""]*)""")]
        public void ThenIShouldSeeTitle(string title)
        {
            Thread.Sleep(2000);
            var driverTitle = driver.Title;
            Assert.AreEqual(driverTitle, title);
            driver.Quit();
        }


    }
}

