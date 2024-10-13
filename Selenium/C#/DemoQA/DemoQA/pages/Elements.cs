using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA.pages
{
    internal class Elements
    {
        IWebDriver driver;
        public Elements(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Locators
        //Dropdowns
        By elementsDropDown = By.XPath("//div[div[text()='Elements']]");
        By formsDropDown = By.XPath("//div[div[text()='Forms']]");
        By alertsDropDown = By.XPath("//div[div[text()='Alerts, Frame & Windows']]");
        By widgetsDropDown = By.XPath("//div[div[text()='Widgets']]");
        By interactionsDropDown = By.XPath("//div[div[text()='Interactions']]");
        By bookStoreApp = By.XPath("//div[div[text()='Book Store Application']]");

        //Items - Elements
        By textBoxItem = By.XPath("//li[span[text()='Text Box']]");
        By checkBoxItem = By.XPath("//li[span[text()='Check Box']]");
        By radioButtonItem = By.XPath("//li[span[text()='Radio Button']]");
        By webTablesItem = By.XPath("//li[span[text()='Web Tables']]");
        By buttonsItem = By.XPath("//li[span[text()='Buttons']]");
        By linksItem = By.XPath("//li[span[text()='Links']]");
        By brokenLinksItem = By.XPath("//li[span[text()='Broken Links - Images']]");
        By uploadDownloadItem = By.XPath("//li[span[text()='Upload and Download']]");
        By dynamicPropertiesItem = By.XPath("//li[span[text()='Dynamic Properties']]");

        //Methods
        public void selectDropDown(String dropDownValue)
        {
            switch (dropDownValue)
            {
                case "elements":
                    driver.FindElement(elementsDropDown).Click(); break;
                case "forms":
                    driver.FindElement(formsDropDown).Click(); break;
                case "alerts":
                    driver.FindElement(alertsDropDown).Click(); break;
                case "widgets":
                    driver.FindElement(widgetsDropDown).Click(); break;
                case "interactions":
                    driver.FindElement(interactionsDropDown).Click(); break;
                case "books":
                    driver.FindElement(bookStoreApp).Click(); break;
                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }
        }

    }
}
