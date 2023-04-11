using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfilePage.Utilities;

namespace ProfilePage.Pages
{
    public class CertificationTab : Wait
    {
        public void Certifications(IWebDriver driver)
        {

            WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 5);

            IWebElement CertificationsTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
            CertificationsTab.Click();

            IWebElement addNewCert = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            addNewCert.Click();

            IWebElement certAwardTextbox = driver.FindElement(By.Name("certificationName"));
            certAwardTextbox.SendKeys("CCNA");

            IWebElement certifiedFromTextbox = driver.FindElement(By.Name("certificationFrom"));
            certifiedFromTextbox.SendKeys("Cisco");

            IWebElement certYearDropdown = driver.FindElement(By.Name("certificationYear"));
            certYearDropdown.Click();

            IWebElement certYear = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[7]"));
            certYear.Click();

            IWebElement addCertification = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            addCertification.Click();
        }
    }
}
