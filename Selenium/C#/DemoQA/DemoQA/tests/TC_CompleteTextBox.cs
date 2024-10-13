using DemoQA.pages;
using DemoQA.utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQA.tests
{
    internal class TC_CompleteTextBox : BaseTest
    {
        [Test]
        public void CompleteTextBox()
        {
            Helpers helper = new Helpers(driver);
            HomePage home = new HomePage(driver);

            helper.WaitForElementToBeDisplayed(20, home.cards, true);
            home.SelectItemByType("elements");

        }
    }
}
