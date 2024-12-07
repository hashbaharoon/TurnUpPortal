using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;


namespace TurnUp_Portal.Utilities
{
    public class Wait
    {
        //Generic Function to wait for an element to be Clickable
        public static void WaitToBeClickable(IWebDriver driver,string locatorType, string locatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0,0,seconds));

            if(locatorType =="XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
            }

            if(locatorType =="Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
            }

        }
        //Generic Function to wait for an element to be Visible
        public static void WaitToBeViSible( IWebDriver driver, string locatorType, string locatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0,0,seconds));

            if (locatorType == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(locatorValue)));
            }

            if (locatorType == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(locatorValue)));
            }

        }

       



    }
}
