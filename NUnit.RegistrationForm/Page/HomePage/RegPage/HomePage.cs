using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.RegistrationForm.Page.HomePage
{
    public partial class  HomePage:BasePage
    {
        protected string url= "http://www.demoqa.com";
        public HomePage(IWebDriver driver):base(driver)
                    {

                    }
     
        public void Navigate()
        {
            this.Driver.Navigate().GoToUrl(this.url);
        }
    }
}
