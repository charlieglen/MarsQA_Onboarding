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
    public class EducationFeatureStepDefinitions : CommonDriver 
    {
        EducationTab educationTabObj = new EducationTab();
        
        [Given(@"I add a new education record, '([^']*)', '([^']*)', '([^']*)', '([^']*)', '([^']*)'")]
        public void GivenIAddANewEducationRecord(string uniName, string uniCountry, string uniTitle, string degree, string year)
        {
            educationTabObj.addEducation(driver, uniName, uniCountry, uniTitle, degree, year);
        }

        [Then(@"The new education record should be added successfully, '([^']*)', '([^']*)', '([^']*)', '([^']*)', '([^']*)'")]
        public void ThenTheNewEducationRecordShouldBeAddedSuccessfully(string uniName, string uniCountry, string uniTitle, string degree, string year)
        
        {
            string newEducation = educationTabObj.alertWindow(driver);
            Assert.That(newEducation == "Education has been added", "Failed to add education record");
        }
      
        [Given(@"I edit an existing education record")]
        public void GivenIEditAnExistingEducationRecord()
        {
            educationTabObj.editEducation(driver);
        }

        [Then(@"The new education record should be updated successfully")]
        public void ThenTheNewEducationRecordShouldBeUpdatedSuccessfully()
        {
            string updatedEducation = educationTabObj.alertWindow(driver);
            Assert.That(updatedEducation == "Education as been updated", "Failed to update education record");
        }
        [Given(@"I delete an existing education record")]
        public void GivenIDeleteAnExistingEducationRecord()
        {
            educationTabObj.deleteEducation(driver);
        }

        [Then(@"The new education record should be deleted successfully")]
        public void ThenTheNewEducationRecordShouldBeDeletedSuccessfully()
        {
            string deleteEducation = educationTabObj.alertWindow(driver);
            Assert.That(deleteEducation == "Education entry successfully removed", "Actual & expected result does not match");
        }
    }
}
