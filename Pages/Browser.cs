using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTrademe.Pages
{
    public class Browser
    {
        public static IWebDriver driver = new ChromeDriver();

        public static void gotoUrl()
        {
            
            driver.Navigate().GoToUrl("https://www.google.co.nz/");
        }

        public static void back()
        {
            driver.Navigate().Back();
        }



        public static void close()
        {
            driver.Close();
        }
    }
}
