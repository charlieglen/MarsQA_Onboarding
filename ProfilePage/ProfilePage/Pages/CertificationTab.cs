using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfilePage.Utilities;
using OpenQA.Selenium.Support.UI;

namespace ProfilePage.Pages
{
    public class CertificationTab : Wait
    {
        public void Certifications(IWebDriver driver)
        {

            WaitToBeClickable(driver, "XPath", "//*[@class=\"ui top attached tabular menu\"]/a[4]", 5);

            IWebElement CertificationsTab = driver.FindElement(By.XPath("//*[@class=\"ui top attached tabular menu\"]/a[4]"));
            CertificationsTab.Click();

            IWebElement addNewCert = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            addNewCert.Click();

            IWebElement certAwardTextbox = driver.FindElement(By.Name("certificationName"));
            certAwardTextbox.SendKeys("CCNA");

            IWebElement certifiedFromTextbox = driver.FindElement(By.Name("certificationFrom"));
            certifiedFromTextbox.SendKeys("Cisco");

            IWebElement certYearDropdown = driver.FindElement(By.Name("certificationYear"));
            certYearDropdown.Click();
            SelectElement certYear = new SelectElement(certYearDropdown);
            certYear.SelectByValue("2023");
            
            IWebElement addCertification = driver.FindElement(By.XPath("//*[@value='Add']"));
            addCertification.Click();
        }
        public string alertWindow(IWebDriver driver)
        {

            WaitForELementToExist(driver, "CssSelector", "[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]", 5);

            IWebElement confirmationAlert = driver.FindElement(By.CssSelector("[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]"));
            return confirmationAlert.Text;

        }
    }
}
