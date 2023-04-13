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
    public class CertificationFeatureStepDefinitions : CommonDriver
    {
        CertificationTab certificationTabObj = new CertificationTab();
        
        [Given(@"I add a new certification details")]
        public void GivenIAddANewCertificationDetails()
        {
            
            certificationTabObj.Certifications(driver);
        }

        [Then(@"The new certification details should be added successfully")]
        public void ThenTheNewCertificationDetailsShouldBeAddedSuccessfully()
        {
            
            string newCertification = certificationTabObj.alertWindow(driver);
            Assert.That(newCertification == "CCNA has been added to your certification", "Actual & expected result does not match");
        }
    }
}
