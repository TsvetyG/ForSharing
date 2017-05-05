using NUnit.Framework;
using NUnit.RegistrationForm.Models;
using NUnit.RegistrationForm.Page.Dropable;
using NUnit.RegistrationForm.Page.HomePage;
using NUnit.RegistrationForm.Page.RegPage;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.RegistrationForm
{
          [TestFixture]
          public class TestClass
          {
                    private IWebDriver driver;

                    [Test]
                    [Property("ToolsQA", 1)]
                    public void Dropable()
                    {
                              this.driver = new ChromeDriver();
                              var dropablePage = new Dropable(this.driver);
                              dropablePage.DragAndDrop();
                              dropablePage.AssertTargetAtribut("ui-widget-header ui-droppable ui-state-highlight");

                    }
                    [Test]
        public void NavigateToQaAutomation()
                    {
                              HomePage homePage = new HomePage(this.driver);
                              var registrationPage = new RegistrationPage(this.driver);


                              PageFactory.InitElements(this.driver, homePage);
                              homePage.Navigate();
                              this.driver.FindElement(By.Id("menu-item-374")).Click();
                              //RegistratonButton.Click();
                              registrationPage.AssertRegistrationPageIsOpen("Registration");

                              var registrationUser = ExcelDB.GetTestData("Login");
                              IWebElement firstName = driver.FindElement(By.Name("FirstName"));
                              firstName.Clear();
                              firstName.SendKeys(registrationUser.FirstName);
                              IWebElement lastName = driver.FindElement(By.Name("LastName"));
                              firstName.Clear();
                              firstName.SendKeys(registrationUser.LastName);
                              IWebElement password = driver.FindElement(By.Name("password"));
                              password.Clear();
                              password.SendKeys(registrationUser.Password);
                              IWebElement login = driver.FindElement(By.XPath("/html/body/div/div[2]/div[2]/div[2]/div[1]/form/input[2]"));
                              login.Click();
                              IWebElement logo = driver.FindElement(By.XPath("//*[@id=\"page-header\"]/div[1]/div/div/div[1]/a/img[1]"));


                              Assert.IsTrue(logo.Displayed);
                    }
          }
                   
          
}
