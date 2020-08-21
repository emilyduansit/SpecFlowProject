using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTrademe.Pages
{
    public class Car
    {

        [FindsBy(How = How.CssSelector, Using = "a[href*='search?q=motor']")]
        private IWebElement imagelink;

        public void assermaplink()
        {

            Assert.IsTrue(Browser.driver.FindElement(By.CssSelector("a[href*='search?q=motor']")).Displayed);
        }

    }
}
