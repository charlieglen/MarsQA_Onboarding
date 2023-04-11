using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using ProfilePage.Pages;
using System;
using TechTalk.SpecFlow;
using ProfilePage.Utilities;

namespace ProfilePage.StepDefinitions
{
    [Binding]
    public class CertificationFeatureStepDefinitions
    {
        CertificationTab certificationTabObj = new CertificationTab();
        LoginPage loginPageObj = new LoginPage();
        IWebDriver driver = new ChromeDriver();
        CommonDriver commonDriver0bj = new CommonDriver();

        [Given(@"I launch and log into MarsQA portal successfully"), Scope(Tag = "certificationBinding")]
        public void GivenILaunchAndLogIntoMarsQAPortalSuccessfully()
        {
            loginPageObj.LogInActions(driver);
        }
    
        [When(@"I add a new certification details")]
        public void WhenIAddANewCertificationDetails()
        {
            
            certificationTabObj.Certifications(driver);
        }

        [Then(@"The new certification details should be added successfully")]
        public void ThenTheNewCertificationDetailsShouldBeAddedSuccessfully()
        {
            string newCertification = commonDriver0bj.alertWindow(driver);
            Assert.That(newCertification == "CCNA has been added to your certification", "Failed to add certification details");
        }
    }
}
