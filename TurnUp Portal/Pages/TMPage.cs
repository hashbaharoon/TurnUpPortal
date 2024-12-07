using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnUp_Portal.Utilities;

namespace TurnUp_Portal.Pages
{
    internal class TMPage
    {
        public void CreateTimeRecord(IWebDriver driver)
        {
            //Click on Create New
             IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a\r\n"));
            createNewButton.Click();

            //Select Time from dropdown
            IWebElement timeAndMaterialDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            timeAndMaterialDropdown.Click();

            Thread.Sleep(2000);
            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeOption.Click();

            //Type Code into Code textbox
            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.SendKeys("hashbah");

            //Type description into Description textBox
            IWebElement descriptionTextBox = driver.FindElement(By.Id("Description"));
            descriptionTextBox.SendKeys("hashsweet");
            Thread.Sleep(2000);

            //Type price into Price textbox
            IWebElement priceTagOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTagOverlap.Click();

            IWebElement priceTextBox = driver.FindElement(By.Id("Price"));
            priceTextBox.SendKeys("1050");

            Wait.WaitToBeClickable(driver,"Id", "SaveButton",5 );

            //Click on Save textbox
            IWebElement saveTextBox = driver.FindElement(By.Id("SaveButton"));
            saveTextBox.Click();
            Thread.Sleep(3000);

            //Check if Time record is created successfully
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (newCode.Text == "hashbah")
            {
                Console.WriteLine("Time Record created successfully!");
            }
            else
            {
                Console.WriteLine("New Time Record not created");
            }
            Thread.Sleep(5000);
        }
        public void EditTimeRecord(IWebDriver driver)
        {
            // Edit Time Record


            //Click on Edit Button
            IWebElement editTextBox = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editTextBox.Click();

            //Edit Code on the Code Textbox
            IWebElement editCodeTextBox = driver.FindElement(By.Id("Code"));
            editCodeTextBox.Clear();
            editCodeTextBox.SendKeys("Zain");
            Thread.Sleep(1000);

            //Edit Description in the Description Textbox

            IWebElement editDescriptionTextBox = driver.FindElement(By.Id("Description"));
            editDescriptionTextBox.Clear();
            editDescriptionTextBox.SendKeys("good");
            Thread.Sleep(1000);

            //Click on Save TextBox
            IWebElement editSave = driver.FindElement(By.Id("SaveButton"));
            editSave.Click();
            Thread.Sleep(1000);

            //Check if the Edit is done, so need to Click on last page button
            IWebElement goToLastPageButtonEdit = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButtonEdit.Click();
            Thread.Sleep(2000);



        }

        public void DeleteTimeRecord(IWebDriver driver)
        {
            // Delete Time Record


            //Click on Delete Button
            IWebElement delete = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            delete.Click();
            Thread.Sleep(2000);

            //Accept the PopUp
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(3000);

            driver.Navigate().Refresh();
            Thread.Sleep(3000);

            //Check if the record is deleted
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            lastPageButton.Click();

            IWebElement deletedCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Thread.Sleep(2000);

            if (deletedCode.Text != "Zain")
            {
                Console.WriteLine("The record is deleted successfully!");
            }
            else
            {
                Console.WriteLine("The record has not been deleted");
            }




        }
    }
}
