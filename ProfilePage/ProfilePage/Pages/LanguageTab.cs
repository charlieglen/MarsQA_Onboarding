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
            SelectElement languageLevel = new SelectElement(languageLevelDropdown);
            languageLevel.SelectByValue("Basic");

            IWebElement addLanguangeButton = driver.FindElement(By.XPath("//*[@value='Add']"));
            addLanguangeButton.Click();

        }
        public string alertWindow(IWebDriver driver)
        {

            WaitForELementToExist(driver, "CssSelector", "[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]", 5);

            IWebElement confirmationAlert = driver.FindElement(By.CssSelector("[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]"));
            return confirmationAlert.Text;

        }
    }
}
