using DemoProject123.PageObject;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace DemoProject123.StepDefinition
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registrationPage;

        public RegistrationSteps()
        {
            registrationPage = new RegistrationPage();
        }




        [Given(@"I navigate to Amazon website")]
        public void GivenINavigateToAmazonWebsite()
        {
            Thread.Sleep(5000);
            registrationPage.NavigateToWebsite();
                    
                                                                                                                                                                                                                                                                                                        
        }
        
        [When(@"I click on Hello sign in")]
        public void WhenIClickOnHelloSignIn()
        {
            registrationPage.ClickOnHelloSignIn();
        }
        
        [When(@"I click on create your amazon account")]
        public void WhenIClickOnCreateYourAmazonAccount()
        {
            registrationPage.ClickOnCreateYourAmazonAccount1();
        }


        
        [When(@"I enter my name")]
        public void WhenIEnterMyName()
        {
            registrationPage.EnterYourName();
        }
        
        [When(@"I enter my email")]
        public void WhenIEnterMyEmail()
        {
            registrationPage.EnterEmail();
        }
        
        [When(@"I enter my password")]
        public void WhenIEnterMyPassword()
        {
            registrationPage.EnterPassword();
        }
        
        [When(@"I re enter my password")]
        public void WhenIReEnterMyPassword()
        {
            registrationPage.EnterPassword2();
        }
        
        [When(@"I create your amazon account on the registration page")]
        public void WhenICreateYourAmazonAccountOnTheRegistrationPage()
        {
            registrationPage.ClickOnCreateYourAmazonAccount2();
            
        }
        
        [Then(@"my account should be created")]
        public void ThenMyAccountShouldBeCreated()
        {
            // Different types of Aseertion
            // 1. NUnit Assertion
            // 2. JUnit Assertion
            // 3. MSTest
            Assert.That(registrationPage.IsHelloDemoDisplayed);
        }

        [When(@"I created another step for demo purpose")]
        public void WhenICreatedAnotherStepForDemoPurpose()
        {
            ScenarioContext.Current.Pending();

        }
    }
}
