using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProfilePage.Pages;
using ProfilePage.Utilities;
using System;
using TechTalk.SpecFlow;


namespace ProfilePage.StepDefinitions
{
    [Binding]
    public class EducationFeatureStepDefinitions
    {
        LoginPage loginPageObj = new LoginPage();
        EducationTab educationTabObj = new EducationTab();
        IWebDriver driver = new ChromeDriver();
        CommonDriver commonDriver0bj = new CommonDriver();

        [Given(@"I launch and log into MarsQA portal successfully")]
        public void GivenILaunchAndLogIntoMarsQAPortalSuccessfully()
        {
            loginPageObj.LogInActions(driver);
        }
     
        [When(@"I add a new education record, '([^']*)', '([^']*)', '([^']*)', '([^']*)', '([^']*)'")]
        public void WhenIAddANewEducationRecord(string uniName, string uniCountry, string uniTitle, string degree, string year)
        {
            educationTabObj.addEducation(driver, uniName, uniCountry, uniTitle, degree, year);
        }

        [Then(@"The new education record should be added successfully, '([^']*)', '([^']*)', '([^']*)', '([^']*)', '([^']*)'")]
        public void ThenTheNewEducationRecordShouldBeAddedSuccessfully(string uniName, string uniCountry, string uniTitle, string degree, string year)
        
        {
            string newEducation = commonDriver0bj.alertWindow(driver);
            Assert.That(newEducation == "Education has been added", "Failed to add education record");
        }

        [Then(@"The new education record should be added successfully")]
        public void ThenTheNewEducationDetailsShouldBeAddedSuccessfully()
        {
            string newEducation = commonDriver0bj.alertWindow(driver);
            Assert.That(newEducation == "Education has been added", "Failed to add education record");
        }

        [When(@"I edit an existing education record")]
        public void WhenIEditAnExistingEducationRecord()
        {
            educationTabObj.editEducation(driver);
        }

        [Then(@"The new education record should be updated successfully")]
        public void ThenTheNewEducationRecordShouldBeUpdatedSuccessfully()
        {
            string updatedEducation = commonDriver0bj.alertWindow(driver);
            Assert.That(updatedEducation == "Education as been updated", "Failed to update education record");
        }
        [When(@"I delete an existing education record")]
        public void WhenIDeleteAnExistingEducationRecord()
        {
            educationTabObj.deleteEducation(driver);
        }

        [Then(@"The new education record should be deleted successfully")]
        public void ThenTheNewEducationRecordShouldBeDeletedSuccessfully()
        {
            string deleteEducation = commonDriver0bj.alertWindow(driver);
            Assert.That(deleteEducation == "Education entry successfully removed", "Failed to delete education record");
        }

        [AfterScenario]
        public void tearDown()
        {
            driver.Quit();
        }
    }
}
