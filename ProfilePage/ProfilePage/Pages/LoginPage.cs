using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ProfilePage.Pages
{
    public class LoginPage
    {
        
        public void LogInActions(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/Home");

            IWebElement signinButton = driver.FindElement(By.CssSelector("[class=\"item\"]"));
            signinButton.Click();

            IWebElement emailTextbox = driver.FindElement(By.Name("email"));
            emailTextbox.SendKeys("charlie.penaredondo@gmail.com");

            IWebElement passwordTextbox = driver.FindElement(By.Name("password"));
            passwordTextbox.SendKeys("password123");

            IWebElement rememberMeCheckbox = driver.FindElement(By.Name("rememberDetails"));
            rememberMeCheckbox.Click();

            IWebElement loginButton = driver.FindElement(By.XPath("//*[contains(text(),'Login')]"));
            loginButton.Click();

        }

    }
}
