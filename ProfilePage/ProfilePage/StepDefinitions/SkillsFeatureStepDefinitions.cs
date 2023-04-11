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
    public class SkillsFeatureStepDefinitions
    {
        LoginPage loginPageObj = new LoginPage();
        IWebDriver driver = new ChromeDriver();
        SkillsTab skillsTabObj = new SkillsTab();
        CommonDriver commonDriver0bj = new CommonDriver();

        [Given(@"I launch and log into MarsQA portal successfully"), Scope(Tag = "skillsBinding")]
        public void GivenILaunchAndLogIntoMarsQAPortalSuccessfully()
        {
            loginPageObj.LogInActions(driver);
        }
        [When(@"I add a new skill")]
        public void WhenIAddANewSkill()
        {
            skillsTabObj.Skills(driver);
        }

        [Then(@"The new skill should be added successfully")]
        public void ThenTheNewSkillShouldBeAddedSuccessfully()
        {
            string newSkill = commonDriver0bj.alertWindow(driver);
            Assert.That(newSkill == "Specflow has been added to your skills", "Failed to add skills");
        }
    }
}
