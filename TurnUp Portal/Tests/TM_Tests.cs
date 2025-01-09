using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUp_Portal.Pages;
using TurnUp_Portal.Utilities;

namespace TurnUp_Portal.Tests
{
    [TestFixture]
    public class TM_Tests : CommonDriver
    {
        [SetUp]
        public void SetUpSteps()
        {
            //Open Chrome Browser
            driver = new ChromeDriver();

            //Login page object initialiazation and definition
            LoginPage loginPageObject = new LoginPage();
            loginPageObject.LoginActions(driver);

            //Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.NavigateToTMPage(driver);

        }

        [Test]
        public void CreateTimeTest()
        {

            //TM page object initialization and definition
            TMPage tMPageObj = new TMPage();
            Thread.Sleep(3000);
            tMPageObj.CreateTimeRecord(driver);
        }

        [Test]
        public void EditTimeTest()
        {
            //Edit time record
            TMPage tMPageObj = new TMPage();
            tMPageObj.EditTimeRecord(driver);
        }

        [Test]
        public void DeleteTimeTest()
        {
            //Delete time record
            TMPage tMPageObj = new TMPage();
            tMPageObj.DeleteTimeRecord(driver);


        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }

}


