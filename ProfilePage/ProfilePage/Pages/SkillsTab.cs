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
    public class SkillsTab : Wait
    {
        public void Skills(IWebDriver driver)
        {
            WaitToBeClickable(driver, "XPath", "//*[@class=\"ui top attached tabular menu\"]/a[2]", 5);

            IWebElement skillTab = driver.FindElement(By.XPath("//*[@class=\"ui top attached tabular menu\"]/a[2]"));
            skillTab.Click();

            IWebElement addNewSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewSkill.Click();

            IWebElement addSkillTextbox = driver.FindElement(By.Name("name"));
            addSkillTextbox.SendKeys("Specflow");

            IWebElement skillLevelDropdown = driver.FindElement(By.Name("level"));
            skillLevelDropdown.Click();
            SelectElement skillLevel = new SelectElement(skillLevelDropdown);
            skillLevel.SelectByValue("Beginner");

            IWebElement addSkillButton = driver.FindElement(By.XPath("//*[@value='Add']"));
            addSkillButton.Click();

        }
        public string alertWindow(IWebDriver driver)
        {

            WaitForELementToExist(driver, "CssSelector", "[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]", 5);

            IWebElement confirmationAlert = driver.FindElement(By.CssSelector("[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]"));
            return confirmationAlert.Text;

        }
    }
}
