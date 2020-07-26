using DemoProject123.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject123.PageObject
{
    class DataDrivenWithParameterPage
    {

        public DataDrivenWithParameterPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;


        IWebElement usernameInput => driver.FindElement(By.XPath("//input[@placeholder = 'Username']"));

        IWebElement emailInput => driver.FindElement(By.XPath("//input[@placeholder = 'Email']"));

        IWebElement passwordInput => driver.FindElement(By.XPath("//input[@placeholder = 'Password']"));

        IWebElement signUpButton => driver.FindElement(By.XPath("//button[@type='submit']"));

        IWebElement userLogin => driver.FindElement(By.XPath("//a[@class='nav-link ng-binding']"));


        IWebElement emailAddress => driver.FindElement(By.XPath("//*[@id='user_email']"));

        IWebElement passwordText => driver.FindElement(By.XPath("//*[@id='user_password']"));

        IWebElement signIn => driver.FindElement(By.XPath("//*[@id='btn_signin']"));

        IWebElement akinOladeji => driver.FindElement(By.XPath("//span[text()='Akin Oladeji']"));

        IWebElement accountDetails => driver.FindElement(By.XPath("(//a[text()='Account Details'])[1]"));

        IWebElement cameraIcon => driver.FindElement(By.XPath("//*[@id='bannerBtnlnk']"));

        IWebElement chooseFile => driver.FindElement(By.XPath("//*[@id='image_upload_banner']"));










        public void EnterUsername(string username)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            usernameInput.SendKeys(username + randomInt);
            //usernameInput.SendKeys(username);
        }

        public void EnterEmailAddress(string email)
        {
           
            emailAddress.SendKeys(email);
        }

        public void EnterPasswordText()
        {

            passwordText.SendKeys("12345");
        }


        public void ClickOnSignIn()
        {

            signIn.Click();
        }

        public void ClickOnAkinOladeji()
        {

            akinOladeji.Click();
        }

        public void ClickOnAccountDetails()
        {

            accountDetails.Click();
        }

        public void ClickOnCameraIcon()
        {

            cameraIcon.Click();
        }

        public void ClickOnChooseFile()
        {

            ();
        }


        public void EnterEmail(string amala)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            emailInput.SendKeys(amala + randomInt + "@hushpuppi.com");
            //emailInput.SendKeys(amala);
        }

        public void EnterPassword(string password)
        {
            passwordInput.SendKeys(password);
        }

        public void ClickSignUpButton()
        {
            signUpButton.Click();
        }

        public bool IsUserLoginDisplayed()
        {
            return userLogin.Displayed;
        }

        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

            
    }
}
