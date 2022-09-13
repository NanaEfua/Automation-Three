using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using TestProjectJ2.PageObject;

namespace TestProjectJ2.StepDefinition
{
    [Binding]
    public class DataDrivenWithExampleSteps
    {
        DataDrivenWithExamplePage dataDrivenWithExamplePage;

        public DataDrivenWithExampleSteps()
        {
            dataDrivenWithExamplePage = new DataDrivenWithExamplePage();
        }






        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            dataDrivenWithExamplePage.NavigateToWebsite(url);
        }
        
        [Given(@"I click on Sign up")]
        public void GivenIClickOnSignUp()
        {
            dataDrivenWithExamplePage.ClickOnSignUp();
        }
        
        [Given(@"I enter my Username text""(.*)""")]
        public void GivenIEnterMyUsernameText(string Username)
        {
            dataDrivenWithExamplePage.EnterUsername(Username);
        }
        
        [Given(@"I enter email text""(.*)""")]
        public void GivenIEnterEmailText(string Email)
        {
            dataDrivenWithExamplePage.EnterEmail(Email);
        }
        
        [Given(@"I enter password text""(.*)""")]
        public void GivenIEnterPasswordText(string Password)
        {
            dataDrivenWithExamplePage.EnterPassword(Password);
        }
        
        [When(@"I click on sign up button")]
        public void WhenIClickOnSignUpButton()
        {
            dataDrivenWithExamplePage.ClickOnSignUpButton();
        }
        
        [Then(@"I can register successfully")]
        public void ThenICanRegisterSuccessfully()
        {
            Thread.Sleep(5000);
            Assert.That(dataDrivenWithExamplePage.IsNewArticleDisplayed);
        }
    }
}
