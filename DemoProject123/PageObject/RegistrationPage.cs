using DemoProject123.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoProject123.PageObject
{
    class RegistrationPage
    {
        public RegistrationPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement helloSignIn => driver.FindElement(By.XPath("//*[@id='nav-link-accountList']/div/span"));

        IWebElement createYourAmazonAccount1 => driver.FindElement(By.Id("createAccountSubmit"));

        IWebElement yourName => driver.FindElement(By.XPath("//input[@id='ap_customer_name']"));

        IWebElement email => driver.FindElement(By.CssSelector("#ap_email"));

        IWebElement password => driver.FindElement(By.CssSelector("#ap_password"));

        IWebElement reEnterpassword => driver.FindElement(By.CssSelector("#ap_password_check"));

        IWebElement createYourAmazonAccount2 => driver.FindElement(By.CssSelector("#continue"));

        IWebElement confirmHelloDemo => driver.FindElement(By.XPath("//span[text()='Hello, Demo']"));




        public void ClickOnHelloSignIn()
        {
            helloSignIn.Click();
        }

        public void ClickOnCreateYourAmazonAccount1()
        {
            createYourAmazonAccount1.Click();
        }

        public void EnterYourName()
        {
            yourName.SendKeys("DemoTest");
        }
        
        
        public void EnterEmail()
        {
            email.SendKeys("info@learnwithpride.co.uk");
        }

        public void EnterPassword()
        {
            password.SendKeys("PasswordSecure");
        }

        public void EnterPassword2()
        {
            reEnterpassword.SendKeys("PasswordSecure");
        }

        public void ClickOnCreateYourAmazonAccount2()
        {
            createYourAmazonAccount2.Click();
        }

        public bool IsHelloDemoDisplayed()
        {
            return confirmHelloDemo.Displayed;
        }

        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://www.amazon.co.uk/");
        }


    }
}
