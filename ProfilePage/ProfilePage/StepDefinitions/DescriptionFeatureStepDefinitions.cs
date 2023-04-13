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
    public class DescriptionFeatureStepDefinitions : CommonDriver
    {

        DescriptionTab descriptionTabObj = new DescriptionTab();
       
        [Given(@"I add a new description")]
        public void GivenIAddANewDescription()
        {
            descriptionTabObj.Description(driver);
        }

        [Then(@"The new description should be added successfully")]
        public void ThenTheNewDescriptionShouldBeAddedSuccessfully()
        {
            string newDescription = descriptionTabObj.alertWindow(driver);
            Assert.That(newDescription == "Description has been saved successfully", "Actual & expected result does not match");
        }
    }
}
