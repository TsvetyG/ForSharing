using NUnit.Framework;
using NUnit.RegistrationForm.Models;
using NUnit.RegistrationForm.Page.HomePage;
using NUnit.RegistrationForm.Page.RegPage;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace RegistrationForm
{
          [TestFixture]
    public class TestClass
    {
        private IWebDriver driver;
        [SetUp]
        public void Init()
        {
            this.driver = new ChromeDriver();
        }
        [TearDown]
        public void CleanUp()
        {
            this.driver.Quit();
        }

        [Test]
        public void NavigateToRegPage()
        {
            HomePage homePage = new HomePage(this.driver);
            var registrationPage = new RegistrationPage(this.driver);
            
            
            PageFactory.InitElements(this.driver,homePage);
            homePage.Navigate();
            this.driver.FindElement(By.Id("menu-item-374")).Click();
            //RegistratonButton.Click();
            registrationPage.AssertRegistrationPageIsOpen("Registration");
                       
        }
        [Test]
        public void RegistrationValid()
        {
                              
                              RegistrationPage regPage = new RegistrationPage(this.driver);
                              RegistrationUser user = new RegistrationUser(
                                                                             "Tsvetana",
                                                                             "Gigova",
                                                                              new List<bool>(new bool[] { true, false, false }),
                                                                              new List<bool>(new bool[] { true, true, true }),
                                                                              "Bulgaria",
                                                                              "5",
                                                                              "29",
                                                                              "1988",
                                                                              "359895665588",
                                                                              "Tsvety",
                                                                              "cvetana.gigova@gmail.com",
                                                                              @"D:\Programs\TeamViewer\email.jpg",
                                                                              "TEST",                                                                           
                                                                              "123456789",
                                                                              "123456789");
                              
                              regPage.NavigateTo();
                              regPage.FillRegistrationForm(user);

                              regPage.AssertSuccessMessige("Thank you for your registration");
                    }
            

       
        [Test]
        public void RegistrationWithoutFirstName()
        {
                              //var erorMsg = driver.FindElement(By.Id("name_3_firstname"));
                              RegistrationPage regPage = new RegistrationPage(this.driver);
                              RegistrationUser user = new RegistrationUser(
                                                                             "Tsvetana",
                                                                             "",
                                                                              new List<bool>(new bool[] { true, false, false }),
                                                                              new List<bool>(new bool[] { true, true, true }),
                                                                              "Bulgaria",
                                                                              "5",
                                                                              "29",
                                                                              "1988",
                                                                              "359895665588",
                                                                              "Tsvety",
                                                                              "cvetana.gigova@gmail.com",
                                                                              @"D:\Programs\TeamViewer\email.jpg",
                                                                              "TEST",
                                                                              "123456789",
                                                                              "123456789");




                              regPage.NavigateTo();
                              regPage.FillRegistrationForm(user);
                              regPage.AssertRegistrationPageWithoutFirstNames("Very weak");

                              //Assert.IsTrue(driver.PageSource.Contains("This field is requierd"));

                    }

    
        [Test]
        public void RegistrationWithoutLastName()
        {
                              RegistrationPage regPage = new RegistrationPage(this.driver);
                              RegistrationUser user = new RegistrationUser(
                                                                             "Tsvetana",
                                                                             "",
                                                                              new List<bool>(new bool[] { true, false, false }),
                                                                              new List<bool>(new bool[] { true, true, true }),
                                                                              "Bulgaria",
                                                                              "5",
                                                                              "29",
                                                                              "1988",
                                                                              "0895667484",
                                                                              "Tsvety",
                                                                              "cvetana.gigova@gmail.com",
                                                                              @"C:\Users\tgigova\Desktop\email.jpg",
                                                                              "TEST",
                                                                              "Zq@123456T",
                                                                              "Zq@123456T");
                              regPage.NavigateTo();
                              regPage.FillRegistrationForm(user);
                             
                              regPage.AssertRegistrationPageWithoutLastNames("This field is required");

                    }
            [Test]
            public void RegistrationWithoutPhone()
            {
                              RegistrationPage regPage = new RegistrationPage(this.driver);
                              RegistrationUser user = new RegistrationUser(
                                                                             "Tsvetana",
                                                                             "Gigova",
                                                                              new List<bool>(new bool[] { true, false, false }),
                                                                              new List<bool>(new bool[] { true, true, true }),
                                                                              "Bulgaria",
                                                                              "5",
                                                                              "29",
                                                                              "1988",
                                                                              "",
                                                                              "Tsvety",
                                                                              "cvetana.gigova@gmail.com",
                                                                              @"C:\Users\tgigova\Desktop\email.jpg",
                                                                              "TEST",
                                                                              "123456",
                                                                              "123456");
                              regPage.NavigateTo();
                              regPage.FillRegistrationForm(user);

                              regPage.AssertRegistrationPagePhone("This field is required");

                    }
                    [Test]
                    public void RegistrationIncorectPhone()
                    {
                              RegistrationPage regPage = new RegistrationPage(this.driver);
                              RegistrationUser user = new RegistrationUser(
                                                                             "Tsvetana",
                                                                             "Gigova",
                                                                              new List<bool>(new bool[] { true, false, false }),
                                                                              new List<bool>(new bool[] { true, true, true }),
                                                                              "Bulgaria",
                                                                              "5",
                                                                              "29",
                                                                              "1988",
                                                                              "12",
                                                                              "Tsvety",
                                                                              "cvetana.gigova@gmail.com",
                                                                              @"C:\Users\tgigova\Desktop\email.jpg",
                                                                              "TEST",
                                                                              "123456",
                                                                              "123456");
                              regPage.NavigateTo();
                              regPage.FillRegistrationForm(user);

                              regPage.AssertRegistrationIncorectPhone(" Minimum 10 Digits starting with Country Code");

                    }
                    [Test]
              public void RegistrationWithIncorectPictureFormat()
              {
                              RegistrationPage regPage = new RegistrationPage(this.driver);
                              RegistrationUser user = new RegistrationUser(
                                                                             "Tsvetana",
                                                                             "Gigova",
                                                                              new List<bool>(new bool[] { true, false, false }),
                                                                              new List<bool>(new bool[] { true, true, true }),
                                                                              "Bulgaria",
                                                                              "3",
                                                                              "1",
                                                                              "1988",
                                                                              "0895667484",
                                                                              "Tsvety",
                                                                              "cvetana.gigova@gmail.com",
                                                                              @"C:\Users\tgigova\Desktop\email.jpgg",
                                                                              "TEST",
                                                                              "123456",
                                                                              "123456");
                             regPage.NavigateTo();
                             regPage.FillRegistrationForm(user);
                             
                             regPage.AssertRegistrationWrongFile("Invalid file");
                    }
               [Test]
               public void RegistrationWithoutSelectedMatrialSatus()
               {
                              RegistrationPage regPage = new RegistrationPage(this.driver);
                              RegistrationUser user = new RegistrationUser(
                                                                             "Tsvetana",
                                                                             "Gigova",
                                                                              new List<bool>(new bool[] { false, false, false }),
                                                                              new List<bool>(new bool[] { true, true, true }),
                                                                              "Bulgaria",
                                                                              "3",
                                                                              "1",
                                                                              "1988",
                                                                              "0895667484",
                                                                              "Tsvety",
                                                                              "cvetana.gigova@gmail.com",
                                                                              @"C:\Users\tgigova\Desktop\email.jpg",
                                                                              "TEST",
                                                                              "123456",
                                                                              "123456");
                              regPage.NavigateTo();
                              regPage.FillRegistrationForm(user);

                              regPage.AssertSuccessMessige("Thank you for your registration");
                    }
                    [Test]
                    public void RegistrationWithoutSelectedHoby()
                    {
                              RegistrationPage regPage = new RegistrationPage(this.driver);
                              RegistrationUser user = new RegistrationUser(
                                                                             "Tsvetana",
                                                                             "Gigova",
                                                                              new List<bool>(new bool[] { true, false, false }),
                                                                              new List<bool>(new bool[] { false, false, false }),
                                                                              "Bulgaria",
                                                                              "3",
                                                                              "1",
                                                                              "1988",
                                                                              "0895667484",
                                                                              "Tsvety",
                                                                              "cvetana.gigova@gmail.com",
                                                                              @"C:\Users\tgigova\Desktop\email.jpg",
                                                                              "TEST",
                                                                              "123456",
                                                                              "123456");
                              regPage.NavigateTo();
                              regPage.FillRegistrationForm(user);

                              regPage.AssertSuccessMessige("Thank you for your registration");
                    }
                    [Test]
                    public void RegistrationWithoutEmail()
                    {
                              RegistrationPage regPage = new RegistrationPage(this.driver);
                              RegistrationUser user = new RegistrationUser(
                                                                             "Tsvetana",
                                                                             "Gigova",
                                                                              new List<bool>(new bool[] { true, false, false }),
                                                                              new List<bool>(new bool[] { true, true, true }),
                                                                              "Bulgaria",
                                                                              "3",
                                                                              "1",
                                                                              "1988",
                                                                              "0895667484",
                                                                              "Tsvety",
                                                                              "",
                                                                              @"C:\Users\tgigova\Desktop\email.jpg",
                                                                              "TEST",
                                                                              "123456",
                                                                              "123456");
                              regPage.NavigateTo();
                              regPage.FillRegistrationForm(user);

                              regPage.AssertRegistrationEmailAddres("This fiels is required");


                    }
                    public void RegistrationIncorectEmail()
                    {
                              RegistrationPage regPage = new RegistrationPage(this.driver);
                              RegistrationUser user = new RegistrationUser(
                                                                             "Tsvetana",
                                                                             "Gigova",
                                                                              new List<bool>(new bool[] { true, false, false }),
                                                                              new List<bool>(new bool[] { true, true, true }),
                                                                              "Bulgaria",
                                                                              "3",
                                                                              "1",
                                                                              "1988",
                                                                              "0895667484",
                                                                              "Tsvety",
                                                                              "c",
                                                                              @"C:\Users\tgigova\Desktop\email.jpg",
                                                                              "TEST",
                                                                              "123456",
                                                                              "123456");
                              regPage.NavigateTo();
                              regPage.FillRegistrationForm(user);

                              regPage.AssertRegistrationEmailAddres("Invalid email address");


                    }
                    [Test]
                    public void RegistrationWithoutBDayMonth()
                    {
                              RegistrationPage regPage = new RegistrationPage(this.driver);
                              RegistrationUser user = new RegistrationUser(
                                                                             "Tsvetana",
                                                                             "Gigova",
                                                                              new List<bool>(new bool[] { true, false, false }),
                                                                              new List<bool>(new bool[] { true, true, true }),
                                                                              "Bulgaria",
                                                                              "29",
                                                                              "",
                                                                              "1988",
                                                                              "123",
                                                                              "Tsvety",
                                                                              "cvetana.gigova@gmail.com",
                                                                              @"C:\Users\tgigova\Desktop\email.jpg",
                                                                              "TEST",
                                                                              "123456",
                                                                              "123456");
                    }
                    [Test]
                    public void RegistrationWithoutBDay()
                    {
                              RegistrationPage regPage = new RegistrationPage(this.driver);
                              RegistrationUser user = new RegistrationUser(
                                                                             "Tsvetana",
                                                                             "Gigova",
                                                                              new List<bool>(new bool[] { true, false, false }),
                                                                              new List<bool>(new bool[] { true, true, true }),
                                                                              "Bulgaria",
                                                                              "",
                                                                              "5",
                                                                              "1988",
                                                                              "123",
                                                                              "Tsvety",
                                                                              "cvetana.gigova@gmail.com",
                                                                              @"D:\Programs\TeamViewer\Terminal strip.jpg",
                                                                              "TEST",
                                                                              "123456",
                                                                              "123456");
                    }
                    [Test]
                    public void RegistrationWithoutBDayYear()
                    {
                              RegistrationPage regPage = new RegistrationPage(this.driver);
                              RegistrationUser user = new RegistrationUser(
                                                                             "Tsvetana",
                                                                             "Gigova",
                                                                              new List<bool>(new bool[] { true, false, false }),
                                                                              new List<bool>(new bool[] { true, true, true }),
                                                                              "Bulgaria",
                                                                              "3",
                                                                              "1",
                                                                              "",
                                                                              "123",
                                                                              "Tsvety",
                                                                              "cvetana.gigova@gmail.com",
                                                                              @"D:\Programs\TeamViewer\Terminal strip.jpg",
                                                                              "TEST",
                                                                              "123456",
                                                                              "123456");
                    }
                    [Test]
                    public void RegistrationWithoutUserName()
                    {
                              RegistrationPage regPage = new RegistrationPage(this.driver);
                              RegistrationUser user = new RegistrationUser(
                                                                             "Tsvetana",
                                                                             "Gigova",
                                                                              new List<bool>(new bool[] { true, false, false }),
                                                                              new List<bool>(new bool[] { true, true, true }),
                                                                              "Bulgaria",
                                                                              "3",
                                                                              "1",
                                                                              "1988",
                                                                              "123",
                                                                              "",
                                                                              "cvetana.gigova@gmail.com",
                                                                              @"D:\Programs\TeamViewer\Terminal strip.jpg",
                                                                              "TEST",
                                                                              "123456",
                                                                              "123456");
                    }
                    [Test]
                    public void RegistrationWithoutDescription()
                    {
                              RegistrationPage regPage = new RegistrationPage(this.driver);
                              RegistrationUser user = new RegistrationUser(
                                                                             "Tsvetana",
                                                                             "Gigova",
                                                                              new List<bool>(new bool[] { true, false, false }),
                                                                              new List<bool>(new bool[] { true, true, true }),
                                                                              "Bulgaria",
                                                                              "3",
                                                                              "1",
                                                                              "1988",
                                                                              "123",
                                                                              "Tsvety",
                                                                              "cvetana.gigova@gmail.com",
                                                                              @"D:\Programs\TeamViewer\Terminal strip.jpg",
                                                                              "",
                                                                              "123456",
                                                                              "123456");
                    }
                    [Test]
                    public void RegistrationWithoutPassword()
                    {
                              RegistrationPage regPage = new RegistrationPage(this.driver);
                              RegistrationUser user = new RegistrationUser(
                                                                             "Tsvetana",
                                                                             "Gigova",
                                                                              new List<bool>(new bool[] { true, false, false }),
                                                                              new List<bool>(new bool[] { true, true, true }),
                                                                              "Bulgaria",
                                                                              "3",
                                                                              "1",
                                                                              "1988",
                                                                              "123",
                                                                              "Tsvety",
                                                                              "cvetana.gigova@gmail.com",
                                                                              @"D:\Programs\TeamViewer\Terminal strip.jpg",
                                                                              "TEST",
                                                                              "",
                                                                              "123456");
                    }
                    [Test]
                    public void RegistrationIncorrectConfirm()
                    {
                              RegistrationPage regPage = new RegistrationPage(this.driver);
                              RegistrationUser user = new RegistrationUser(
                                                                             "Tsvetana",
                                                                             "Gigova",
                                                                              new List<bool>(new bool[] { true, false, false }),
                                                                              new List<bool>(new bool[] { true, true, true }),
                                                                              "Bulgaria",
                                                                              "3",
                                                                              "1",
                                                                              "1988",
                                                                              "123",
                                                                              "Tsvety",
                                                                              "cvetana.gigova@gmail.com",
                                                                              @"D:\Programs\TeamViewer\Terminal strip.jpg",
                                                                              "TEST",
                                                                              "123456",
                                                                              "123457");
                    }
                    [Test]
                    public void RegistrationWrongYear()
                    {
                              RegistrationPage regPage = new RegistrationPage(this.driver);
                              RegistrationUser user = new RegistrationUser(
                                                                             "Tsvetana",
                                                                             "Gigova",
                                                                              new List<bool>(new bool[] { true, false, false }),
                                                                              new List<bool>(new bool[] { true, true, true }),
                                                                              "Bulgaria",
                                                                              "3",
                                                                              "1",
                                                                              "19888",
                                                                              "123",
                                                                              "Tsvety",
                                                                              "cvetana.gigova@gmail.com",
                                                                              @"D:\Programs\TeamViewer\Terminal strip.jpg",
                                                                              "TEST",
                                                                              "123456",
                                                                              "123456");
                    }
                    [Test]
                    public void RegistrationWrongMonth()
                    {
                              RegistrationPage regPage = new RegistrationPage(this.driver);
                              RegistrationUser user = new RegistrationUser(
                                                                             "Tsvetana",
                                                                             "Gigova",
                                                                              new List<bool>(new bool[] { true, false, false }),
                                                                              new List<bool>(new bool[] { true, true, true }),
                                                                              "Bulgaria",
                                                                              "3",
                                                                              "13",
                                                                              "1988",
                                                                              "123",
                                                                              "Tsvety",
                                                                              "cvetana.gigova@gmail.com",
                                                                              @"D:\Programs\TeamViewer\Terminal strip.jpg",
                                                                              "TEST",
                                                                              "123456",
                                                                              "123456");
                    }
                    [Test]
                    public void RegistrationWrongDay()
                    {
                              RegistrationPage regPage = new RegistrationPage(this.driver);
                              RegistrationUser user = new RegistrationUser(
                                                                             "Tsvetana",
                                                                             "Gigova",
                                                                              new List<bool>(new bool[] { true, false, false }),
                                                                              new List<bool>(new bool[] { true, true, true }),
                                                                              "Bulgaria",
                                                                              "31",
                                                                              "1",
                                                                              "1988",
                                                                              "123",
                                                                              "Tsvety",
                                                                              "cvetana.gigova@gmail.com",
                                                                              @"D:\Programs\TeamViewer\Terminal strip.jpg",
                                                                              "TEST",
                                                                              "123456",
                                                                              "123456");
                    }
                    [Test]
                    public void RegistrationWrongEmailAdress()
                    {
                              RegistrationPage regPage = new RegistrationPage(this.driver);
                              RegistrationUser user = new RegistrationUser(
                                                                             "Tsvetana",
                                                                             "Gigova",
                                                                              new List<bool>(new bool[] { true, false, false }),
                                                                              new List<bool>(new bool[] { true, true, true }),
                                                                              "Bulgaria",
                                                                              "3",
                                                                              "1",
                                                                              "1988",
                                                                              "123",
                                                                              "Tsvety",
                                                                              "cvetana.gigovagmail.com",
                                                                              @"D:\Programs\TeamViewer\Terminal strip.jpg",
                                                                              "TEST",
                                                                              "123456",
                                                                              "123456");
                    }
                    [Test]
                    public void RegistrationIncorrectPictureFormat()
                    {
                              RegistrationPage regPage = new RegistrationPage(this.driver);
                              RegistrationUser user = new RegistrationUser(
                                                                             "Tsvetana",
                                                                             "Gigova",
                                                                              new List<bool>(new bool[] { true, false, false }),
                                                                              new List<bool>(new bool[] { true, true, true }),
                                                                              "Bulgaria",
                                                                              "3",
                                                                              "1",
                                                                              "1988",
                                                                              "123",
                                                                              "Tsvety",
                                                                              "cvetana.gigovagmail.com",
                                                                              @"D:\Programs\TeamViewer\Terminal strip.jpgg",
                                                                              "TEST",
                                                                              "123456",
                                                                              "123456");
                    }

                    public void Type(IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }
    }

}

