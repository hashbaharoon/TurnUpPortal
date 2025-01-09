using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnUp_Portal.Pages
{
    public class LoginPage
    {
        //Functions that allow users to login to TurUpPortal
        public void LoginActions(IWebDriver driver)
        {
            //Launch TurnUp Portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

            //Explicit Wait
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
           // wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("UserName")));


            //Identify Username TextBox and enter valid username
            IWebElement UsernameTextbox = driver.FindElement(By.Id("UserName"));
            UsernameTextbox.SendKeys("hari");

            Utilities.Wait.WaitToBeViSible(driver, "Id", "Password", 4);

            try
            {
                //Identify password Textbox and enter valid password
                IWebElement PasswordTextbox = driver.FindElement(By.Id("Password"));
                PasswordTextbox.SendKeys("123123");
            }
            catch (Exception ex)
            {
                Assert.Fail("Username Textbox not located");
            }

            //Identify Loginbutton and click on it
            IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            LoginButton.Click();
            Thread.Sleep(3000);

        }

    }   }    
