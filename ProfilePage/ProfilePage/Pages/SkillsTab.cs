using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfilePage.Utilities;


namespace ProfilePage.Pages
{
    public class SkillsTab : Wait
    {
        public void Skills(IWebDriver driver)
        {
            WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 5);

            IWebElement skillTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillTab.Click();

            IWebElement addNewSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewSkill.Click();

            IWebElement addSkillTextbox = driver.FindElement(By.Name("name"));
            addSkillTextbox.SendKeys("Specflow");

            IWebElement skillLevelDropdown = driver.FindElement(By.Name("level"));
            skillLevelDropdown.Click();

            IWebElement skillLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]"));
            skillLevel.Click();

            IWebElement addSkillButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            addSkillButton.Click();

        }
    }
}
