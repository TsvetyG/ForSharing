using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.RegistrationForm.Page.HomePageMap
{
          public partial class HomePage:BasePage
          {
               public HomePage(IWebDriver driver) : base(driver)
               {
               }

               public IWebElement RegistratonButton
               {
                         get
                         {
                                   return this.Driver.FindElement(By.Id("menu-item-374"));
                         }
               }

          }

}
