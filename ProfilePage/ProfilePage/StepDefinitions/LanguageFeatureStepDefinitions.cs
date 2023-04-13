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
    public class LanguageFeatureStepDefinitions : CommonDriver
    {
        LanguageTab languageTabObj = new LanguageTab();
       
        [Given(@"I add a new language")]
        public void GivenIAddANewLanguage()
        {
            languageTabObj.Languages(driver);
        }

        [Then(@"The new language should be added successfully")]
        public void ThenTheNewLanguageShouldBeAddedSuccessfully()
        {
            string newLanguage = languageTabObj.alertWindow(driver);
            Assert.That(newLanguage == "Filipino has been added to your languages", "Actual & expected result does not match");
        }
    }
}
