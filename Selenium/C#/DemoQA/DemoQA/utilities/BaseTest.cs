using NUnit.Framework;
using NUnit.Framework.Internal.Commands;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA.utilities
{
    public class BaseTest
    {
        public IWebDriver driver;
        String url = "https://demoqa.com/";
        String browser = "firefox";

        [SetUp]
        public void SetUp() {

            switch (browser)
            {
                case "chrome":
                    {
                        driver = new ChromeDriver();
                        break;
                    }
                case "firefox":
                    {
                        driver = new FirefoxDriver();
                        break;
                    }
                case "edge":
                    {
                        driver = new EdgeDriver();
                        break;
                    }
                default:
                    {
                        driver = new ChromeDriver();
                        break; 
                    }
            }

            driver.Url = url;
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            //driver.Close();
        }
    }
}
