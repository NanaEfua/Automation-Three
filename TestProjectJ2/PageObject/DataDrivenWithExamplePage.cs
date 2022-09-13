using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestProjectJ2.Utilities;

namespace TestProjectJ2.PageObject
{
    class DataDrivenWithExamplePage
    {
        public DataDrivenWithExamplePage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;


        IWebElement SignUp => driver.FindElement(By.XPath("/html/body/div/app-header/nav/div/ul[1]/li[3]/a"));
        IWebElement UsernameText => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(1) > input"));
        IWebElement EmailText => driver.FindElement(By.XPath("/html / body / div / div / div / div / div / div / form / fieldset / fieldset[2] / input"));
        IWebElement PasswordText => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[3]/input"));
        IWebElement SignUpButton => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > button"));
        IWebElement NewArticle => driver.FindElement(By.XPath("(//a[@class='nav-link'])[3]"));



        public void ClickOnSignUp()
        {
            SignUp.Click();
        }

        public void EnterUsername(string Username)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            UsernameText.SendKeys(Username + randomInt);
            //Username.SendKeys(username);
        }

        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void EnterEmail(string Email)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            EmailText.SendKeys(Email + randomInt + "@yahoo.com");
            //Email.SendKeys(email);
        }

        public void EnterPassword(string Password)
        {
            PasswordText.SendKeys(Password);
        }

        public void ClickOnSignUpButton()
        {
            SignUpButton.Click();
        }

        public bool IsNewArticleDisplayed()
        {
            return NewArticle.Displayed;
        }
















    }
}
