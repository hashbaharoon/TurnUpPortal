using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using TurnUp_Portal.Pages;

public class Program
{
    private static void Main(string[] args)
    {
        //Open Chrome Browser
        IWebDriver driver = new ChromeDriver();


        //Login page object initialiazation and definition
        LoginPage loginPageObject = new LoginPage();
        loginPageObject.LoginActions(driver);

        //Home page object initialization and definition
        HomePage homePageObj= new HomePage();
        homePageObj.NavigateToTMPage(driver);

        //TM page object initialization and definition
        TMPage tMPageObj = new TMPage();
        Thread.Sleep(3000);
        tMPageObj.CreateTimeRecord(driver);

        //Edit time record
        tMPageObj.EditTimeRecord(driver);

        //Delete time record
        tMPageObj.DeleteTimeRecord(driver);
    }
}