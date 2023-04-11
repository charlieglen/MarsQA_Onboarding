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
    public class DescriptionFeatureStepDefinitions
    {
        LoginPage loginPageObj = new LoginPage();
        IWebDriver driver = new ChromeDriver();
        DescriptionTab descriptionTabObj = new DescriptionTab();
        CommonDriver commonDriver0bj = new CommonDriver();


        [Given(@"I launch and log into MarsQA portal successfully"), Scope(Tag = "descriptionBinding")]
        public void GivenILaunchAndLogIntoMarsQAPortalSuccessfully()
        {
            loginPageObj.LogInActions(driver);
        }
        [When(@"I add a new description")]
        public void WhenIAddANewDescription()
        {
            descriptionTabObj.Description(driver);
        }

        [Then(@"The new description should be added successfully")]
        public void ThenTheNewDescriptionShouldBeAddedSuccessfully()
        {
            string newDescription = commonDriver0bj.alertWindow(driver);
            Assert.That(newDescription == "Description has been saved successfully", "Failed to save description");
        }
    }
}
