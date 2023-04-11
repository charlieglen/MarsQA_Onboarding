using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using ProfilePage.Utilities;


namespace ProfilePage.Pages
{
    public class EducationTab : Wait
    {
        public void addEducation(IWebDriver driver, string uniName, string uniCountry, string uniTitle, string degree, string year)
        {

            WaitToBeClickable(driver, "XPath", "//*[@class=\"ui top attached tabular menu\"]/a[3]", 5);

            IWebElement educationTab = driver.FindElement(By.XPath("//*[@class=\"ui top attached tabular menu\"]/a[3]"));
            educationTab.Click();

            IWebElement addNewEducation = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            addNewEducation.Click();

            IWebElement instituteTextbox = driver.FindElement(By.Name("instituteName"));
            instituteTextbox.SendKeys(uniName);

            IWebElement instituteCountryDropdown = driver.FindElement(By.Name("country"));
            instituteCountryDropdown.Click();
            SelectElement instituteCountry = new SelectElement(instituteCountryDropdown);
            instituteCountry.SelectByValue(uniCountry);

            IWebElement titleDropdown = driver.FindElement(By.Name("title"));
            titleDropdown.Click();
            SelectElement title = new SelectElement(titleDropdown);
            title.SelectByValue(uniTitle);

            IWebElement degreeTextbox = driver.FindElement(By.Name("degree"));
            degreeTextbox.SendKeys(degree);

            IWebElement yearGraduatedDropdown = driver.FindElement(By.Name("yearOfGraduation"));
            yearGraduatedDropdown.Click();
            SelectElement yearGraduated = new SelectElement(yearGraduatedDropdown);
            yearGraduated.SelectByValue(year);

            IWebElement addEducationButton = driver.FindElement(By.XPath("//*[@value='Add']"));
            addEducationButton.Click();

        }
        public void editEducation(IWebDriver driver)
        {

            WaitToBeClickable(driver, "XPath", "//*[@class=\"ui top attached tabular menu\"]/a[3]", 5);

            IWebElement educationTab = driver.FindElement(By.XPath("//*[@class=\"ui top attached tabular menu\"]/a[3]"));
            educationTab.Click();

            IWebElement editIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[1]/i"));
            editIcon.Click();

            IWebElement instituteTextbox = driver.FindElement(By.Name("instituteName"));
            instituteTextbox.Clear();
            instituteTextbox.SendKeys("Avengers Academy");

            IWebElement instituteCountryDropdown = driver.FindElement(By.Name("country"));
            instituteCountryDropdown.Click();
            SelectElement instituteCountry = new SelectElement(instituteCountryDropdown);
            instituteCountry.SelectByValue("Bulgaria");

            IWebElement titleDropdown = driver.FindElement(By.Name("title"));
            titleDropdown.Click();
            SelectElement title = new SelectElement(titleDropdown);
            title.SelectByValue("BFA");

            IWebElement degreeTextbox = driver.FindElement(By.Name("degree"));
            degreeTextbox.Clear();
            degreeTextbox.SendKeys("Intergalactic Space Ambassasdor");

            IWebElement yearGraduatedDropdown = driver.FindElement(By.Name("yearOfGraduation"));
            yearGraduatedDropdown.Click();
            SelectElement yearGraduated = new SelectElement(yearGraduatedDropdown);
            yearGraduated.SelectByValue("2023");

            IWebElement updateEducationButton = driver.FindElement(By.XPath("//*[@value='Update']"));
            updateEducationButton.Click();

        }
        public void deleteEducation(IWebDriver driver)
        {
            WaitToBeClickable(driver, "XPath", "//*[@class=\"ui top attached tabular menu\"]/a[3]", 5);

            IWebElement educationTab = driver.FindElement(By.XPath("//*[@class=\"ui top attached tabular menu\"]/a[3]"));
            educationTab.Click();

            IWebElement deleteIcon = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[6]/span[2]/i"));
            deleteIcon.Click();

        }
        
    }
}
