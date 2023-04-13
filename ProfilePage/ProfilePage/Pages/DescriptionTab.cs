using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V109.Database;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using ProfilePage.Utilities;


namespace ProfilePage.Pages
{
    public class DescriptionTab : Wait
    {
        public void Description(IWebDriver driver)
        {

            WaitToBeClickable(driver, "CssSelector", "[class=\"outline write icon\"]", 5);

            IWebElement addDescriptionButton = driver.FindElement(By.CssSelector("[class=\"outline write icon\"]"));
            addDescriptionButton.Click();

            IWebElement descriptionTextArea = driver.FindElement(By.Name("value"));
            descriptionTextArea.SendKeys(Keys.Control + "a");
            descriptionTextArea.Clear();
            descriptionTextArea.SendKeys("I am a Test Analyst.");

            IWebElement saveDescription = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            saveDescription.Click();
        }
        public string alertWindow(IWebDriver driver)
        {

            WaitForELementToExist(driver, "CssSelector", "[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]", 5);

            IWebElement confirmationAlert = driver.FindElement(By.CssSelector("[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]"));
            return confirmationAlert.Text;

        }
    }
}
