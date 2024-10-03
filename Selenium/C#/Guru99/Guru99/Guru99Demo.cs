using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Guru99
{
    [TestFixture]
    public class Guru99Demo
    {
        public static IWebDriver driver;
        String browser = "chrome";

        [SetUp]
        public void StartBrowser()
        {
            switch (browser)
            {
                case "chrome":
                    driver = new ChromeDriver(); break;
                case "firefox":
                    driver = new FirefoxDriver(); break;
                case "edge":
                    driver = new EdgeDriver(); break;
                default:
                    driver = new ChromeDriver(); break;
            }
        }

        [Test]
        public static void CreateAccount()
        {
            //Navigate to page
            driver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/");
            driver.Manage().Window.Maximize();

            //Retrieve title
            String title = driver.Title;
            Console.WriteLine(title);

            //Create an account
            driver.FindElement(By.LinkText("Create an Account")).Click();
            driver.FindElement(By.Id("firstname")).SendKeys("Jason");
            driver.FindElement(By.Id("lastname")).SendKeys("Kraft");

            driver.FindElement(By.Id("email_address")).SendKeys("jasonk@testing.com");
            driver.FindElement(By.Id("password")).SendKeys("Password@123");
            driver.FindElement(By.Id("password-confirmation")).SendKeys("Password@123");

            driver.FindElement(By.CssSelector(".submit")).Click();
        }

        [Test]
        public void SignIn()
        {

        }


        [TearDown]
        public void closeBrowser(){
            Thread.Sleep(3000);
            //driver.Close();
            Console.WriteLine("Browser is closed");
        } 
    }
}
