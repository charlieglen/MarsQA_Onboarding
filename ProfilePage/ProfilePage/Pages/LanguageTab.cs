using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfilePage.Utilities;

namespace ProfilePage.Pages
{
    public class LanguageTab : Wait
    {
        public void Languages(IWebDriver driver)
        {

            WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 5);

            IWebElement addNewLanguageButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewLanguageButton.Click();

            IWebElement addLanguageTextbox = driver.FindElement(By.Name("name"));
            addLanguageTextbox.SendKeys("Filipino");

            IWebElement languageLevelDropdown = driver.FindElement(By.Name("level"));
            languageLevelDropdown.Click();

            IWebElement languageLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[4]"));
            languageLevel.Click();

            IWebElement addLanguangeButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addLanguangeButton.Click();

        }
    }
}
