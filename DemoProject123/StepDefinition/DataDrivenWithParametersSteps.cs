using DemoProject123.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace DemoProject123.StepDefinition
{
    [Binding]
    public class DataDrivenWithParametersSteps
    {

        DataDrivenWithParameterPage dataDrivenWithParameterPage;

        public DataDrivenWithParametersSteps()
        {
            dataDrivenWithParameterPage = new DataDrivenWithParameterPage();
        }

        IWebDriver driver;



        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            dataDrivenWithParameterPage.NavigateToWebsite(url);
        }
        
        [When(@"I enter Username text ""(.*)""")]
        public void WhenIEnterUsernameText(string username)
        {
            dataDrivenWithParameterPage.EnterUsername(username);
        }
        
        [When(@"I enter email text ""(.*)""")]
        public void WhenIEnterEmailText(string amala)
        {
            dataDrivenWithParameterPage.EnterEmail(amala);
        }
        
        [When(@"I enter password text ""(.*)""")]
        public void WhenIEnterPasswordText(string password)
        {
            dataDrivenWithParameterPage.EnterPassword(password);
        }
        
        [When(@"I click on sign up button")]
        public void WhenIClickOnSignUpButton()
        {
            dataDrivenWithParameterPage.ClickSignUpButton();
        }
        
        [Then(@"I am logged in with my username displayed")]
        public void ThenIAmLoggedInWithMyUsernameDisplayed()
        {
            Assert.That(dataDrivenWithParameterPage.IsUserLoginDisplayed);
        }

        [When(@"I enter my email address ""(.*)""")]
        public void WhenIEnterMyEmailAddress(string email)
        {
            dataDrivenWithParameterPage.EnterEmailAddress(email);
        }

        //[When(@"I enter my password in the text box ""(.*)""")]
        //public void WhenIEnterMyPasswordInTheTextBox(int p0)
        //{
        //    dataWithParameterPage.EnterPasswordText();
        //}

        [When(@"I enter my password in the text box")]
        public void WhenIEnterMyPasswordInTheTextBox()
        {
            dataDrivenWithParameterPage.EnterPasswordText();
        }


        [When(@"I click on Sign in button")]
        public void WhenIClickOnSignInButton()
        {
            dataDrivenWithParameterPage.ClickOnSignIn();
        }

        [When(@"I click on Akin Oladeji")]
        public void WhenIClickOnAkinOladeji()
        {
            //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            //    //WebDriverWait(IWebDriver driver, TimeSpan.FromSeconds(20));
            //    var element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[text()='Akin Oladeji']")));
            //    Actions action = new Actions(driver);
            //    action.MoveToElement(element).Perform();
            //    //Waiting for the menu to be displayed    
            //    System.Threading.Thread.Sleep(4000);
            dataDrivenWithParameterPage.ClickOnAkinOladeji();
        }

        [When(@"I click on Account Details")]
        public void WhenIClickOnAccountDetails()
        {
            dataDrivenWithParameterPage.ClickOnAccountDetails();
        }

        [When(@"I click on Camera Icon")]
        public void WhenIClickOnCameraIcon()
        {
            dataDrivenWithParameterPage.ClickOnCameraIcon();
        }

        [When(@"I click on Choose File")]
        public void WhenIClickOnChooseFile()
        {
            ScenarioContext.Current.Pending();
        }




    }
}
