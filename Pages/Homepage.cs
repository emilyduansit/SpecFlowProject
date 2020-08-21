using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTrademe.Pages
{
    public class Homepage
    {
        [FindsBy(How = How.CssSelector, Using = "input[name='q']")]
        private IWebElement searchinput;

        [FindsBy(How = How.CssSelector, Using = "input[name='btnK']")]
        private IWebElement googlesearchbtn;

        [FindsBy(How = How.CssSelector, Using = "input[name='btnI']")]
        private IWebElement googleluckybtn;


        public void gotomotor()
        {
           Browser.gotoUrl();
            Browser.driver.Manage().Window.Maximize();
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            searchinput.SendKeys("motor");
            googlesearchbtn.Click();

        }

        public void gotolucky()
        {
            Browser.gotoUrl();

            searchinput.SendKeys("motor");
            googleluckybtn.Click();
        }

    }
}
