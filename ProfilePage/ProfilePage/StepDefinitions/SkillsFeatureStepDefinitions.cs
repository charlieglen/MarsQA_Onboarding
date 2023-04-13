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
    public class SkillsFeatureStepDefinitions : CommonDriver
    {
        SkillsTab skillsTabObj = new SkillsTab();
        
        [Given(@"I add a new skill")]
        public void GivenIAddANewSkill()
        {
            skillsTabObj.Skills(driver);
        }

        [Then(@"The new skill should be added successfully")]
        public void ThenTheNewSkillShouldBeAddedSuccessfully()
        {
            string newSkill = skillsTabObj.alertWindow(driver);
            Assert.That(newSkill == "Specflow has been added to your skills", "Actual & expected result does not match");
        }
    }
}
