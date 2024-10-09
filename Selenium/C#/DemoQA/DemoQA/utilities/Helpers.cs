using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA.utilities
{
    public class Helpers
    {
        IWebDriver driver;

        public Helpers(IWebDriver driver) { this.driver = driver; }

        public void WaitForElementToBeDisplayed(int timeoutSec, By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutSec));
            wait.Until(drv => drv.FindElement(locator).Displayed);
        }
    }
}
