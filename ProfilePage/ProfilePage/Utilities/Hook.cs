using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProfilePage.Pages;
using TechTalk.SpecFlow;

namespace ProfilePage.Utilities
{
    [Binding]
    public class Hooks : CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();

        [BeforeScenario]
        public void BeforeScenarioWithTag()
        {
            driver = new ChromeDriver();
            loginPageObj.LogInActions(driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
} 