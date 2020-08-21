using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTrademe.Pages
{
    public class PageInit
    {
        public static Homepage Homepage
        {
            get
            {
                var Homepage = new Homepage();
                PageFactory.InitElements(Browser.driver, Homepage);
                return Homepage;
            }
        }

        public static Motor Motor
        {
            get
            {
                var Motor = new Motor();
                PageFactory.InitElements(Browser.driver, Motor);
                return Motor;
            }
        }

        public static Car Car
        {
            get
            {
                var Car = new Car();
                PageFactory.InitElements(Browser.driver, Car);
                return Car;
            }
        }

        
    }
}
