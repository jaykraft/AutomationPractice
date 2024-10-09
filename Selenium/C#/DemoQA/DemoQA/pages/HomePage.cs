using DemoQA.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA.pages
{
    public class HomePage
    {
        IWebDriver driver;

        public HomePage(IWebDriver driver) {
            this.driver = driver;
        }

        //Locators
        public By cards = By.XPath("//*[@id=\"app\"]/div/div/div[2]/div/div");

        //Methods
        public void SelectItemByType(string type)
        {
            switch (type)
            {
                case "elements":
                    driver.FindElements(cards)[1].Click(); break;
                case "forms":
                    driver.FindElements(cards)[2].Click(); break;
                case "alerts":
                    driver.FindElements(cards)[3].Click(); break;
                case "widgets":
                    driver.FindElements(cards)[4].Click(); break;
                case "interactions":
                    driver.FindElements(cards)[2].Click(); break;
                case "application":
                    driver.FindElements(cards)[2].Click(); break;
                default:
                    Console.WriteLine("Unspecified type selected");
                    break;
            }

        }
    }
}
