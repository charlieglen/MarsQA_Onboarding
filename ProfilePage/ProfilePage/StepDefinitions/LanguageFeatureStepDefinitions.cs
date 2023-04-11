using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using ProfilePage.Pages;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using ProfilePage.Utilities;

namespace ProfilePage.StepDefinitions
{
    [Binding]
    public class LanguageFeatureStepDefinitions
    {
        LoginPage loginPageObj = new LoginPage();
        IWebDriver driver = new ChromeDriver();
        LanguageTab languageTabObj = new LanguageTab();
        CommonDriver commonDriver0bj = new CommonDriver();


        [Given(@"I launch and log into MarsQA portal successfully"), Scope(Tag = "languageBinding")]
        public void GivenILaunchAndLogIntoMarsQAPortalSuccessfully()
        {
            loginPageObj.LogInActions(driver);
        }
        [When(@"I add a new language")]
        public void WhenIAddANewLanguage()
        {
            languageTabObj.Languages(driver);
        }

        [Then(@"The new language should be added successfully")]
        public void ThenTheNewLanguageShouldBeAddedSuccessfully()
        {
            string newLanguage = commonDriver0bj.alertWindow(driver);
            Assert.That(newLanguage == "Filipino has been added to your languages", "Failed to add Language");
        }
    }
}
