﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.RegistrationForm.Page.RegPage
{
    public partial class RegistrationPage
    {
                  
                    public IWebElement Title
                    {
                              get
                              {
                                        return this.Driver.FindElement(By.TagName("Home"));
                              }
                    }

                    public IWebElement Header
                    {
                              get
                              {
                                        return this.Driver.FindElement(By.ClassName("entry-title"));
                              }
                    }

                    public IWebElement FirstName
                    {
                              get
                              {
                                        return this.Driver.FindElement(By.Id("name_3_firstname"));
                              }
                    }

                    public IWebElement LastName
                    {
                              get
                              {
                                        return this.Driver.FindElement(By.Id("name_3_lastname"));
                              }
                    }

                    public List<IWebElement> MartialStatus
                    {
                              get
                              {
                                        return this.Driver.FindElements(By.Name("radio_4[]")).ToList();
                              }
                    }

                    public List<IWebElement> Hobbys
                    {
                              get
                              {
                                        return this.Driver.FindElements(By.Name("checkbox_5[]")).ToList();
                              }
                    }

                    private IWebElement CountryDD
                    {
                              get
                              {
                                        return this.Driver.FindElement(By.Id("dropdown_7"));
                              }
                    }

                    public SelectElement CountryOption
                    {
                              get
                              {
                                        return new SelectElement(CountryDD);
                              }
                    }

                    private IWebElement MounthDD
                    {
                              get
                              {
                                        return this.Driver.FindElement(By.Id("mm_date_8"));
                              }
                    }

                    public SelectElement MounthOption
                    {
                              get
                              {
                                        return new SelectElement(MounthDD);
                              }
                    }

                    private IWebElement DayDD
                    {
                              get
                              {
                                        return this.Driver.FindElement(By.Id("dd_date_8"));
                              }
                    }

                    public SelectElement DayOption
                    {
                              get
                              {
                                        return new SelectElement(DayDD);
                              }
                    }

                    private IWebElement YearDD
                    {
                              get
                              {
                                        return this.Driver.FindElement(By.Id("yy_date_8"));
                              }
                    }

                    public SelectElement YearOption
                    {
                              get
                              {
                                        return new SelectElement(YearDD);
                              }
                    }

                    public IWebElement Phone
                    {
                              get
                              {
                                        return this.Driver.FindElement(By.Id("phone_9"));
                              }
                    }

                    public IWebElement UserName
                    {
                              get
                              {
                                        return this.Driver.FindElement(By.Id("username"));
                              }
                    }

                    public IWebElement Email
                    {
                              get
                              {
                                        return this.Driver.FindElement(By.Id("email_1"));
                              }
                    }

                    public IWebElement UploadButton
                    {
                              get
                              {
                                        return this.Driver.FindElement(By.Id("profile_pic_10"));
                              }
                    }

                    public IWebElement Description
                    {
                              get
                              {
                                        return this.Driver.FindElement(By.Id("description"));
                              }
                    }

                    public IWebElement Password
                    {
                              get
                              {
                                        return this.Driver.FindElement(By.Id("password_2"));
                              }
                    }

                    public IWebElement ConfirmPass
                    {
                              get
                              {
                                        return this.Driver.FindElement(By.Id("confirm_password_password_2"));
                              }
                    }

                    public IWebElement SubmitButton
                    {
                              get
                              {
                                        return this.Driver.FindElement(By.Name("pie_submit"));
                              }
                    }

                    public IWebElement SuccessMessage
                    {
                              get
                              {
                                        return this.Driver.FindElement(By.ClassName("piereg_message"));
                              }
                    }

                    public IWebElement ErrorMessagesForFirstNames
                    {
                              get
                              {
                                        this.Wait.Until(ExpectedConditions.ElementExists(By.Id("piereg_passwordStrength")));
                                        return this.Driver.FindElement(By.Id("piereg_passwordStrength"));
                                        //this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pie_register\"]/li[1]/div[1]/div[2]/span")));
                                        //return this.Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[1]/div[1]/div[2]/span"));

                              }
                    }
                    public IWebElement ErrorMessagesForLastNames
                    {
                              get
                              {
                                        //this.Wait.Until(ExpectedConditions.ElementExists(By.Id("piereg_passwordStrength")));
                                        //return this.Driver.FindElement(By.Id("piereg_passwordStrength"));
                                        this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pie_register\"]/li[1]/div[1]/div[2]/span")));
                                        return this.Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[1]/div[1]/div[2]/span"));
                              }
                    }

                    public IWebElement ErrorMessagesForPhone
                    {
                              get
                              {
                                       
                                        this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pie_register\"]/li[6]/div/div/span")));
                                        return this.Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[6]/div/div/span"));
                              }
                    }
                    public IWebElement ErrorMessagesIncorrectPhone
                    {
                              get
                              {

                                        this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pie_register\"]/li[6]/div/div/span")));
                                        return this.Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[6]/div/div/span"));
                              }
                    }
                    public IWebElement ErrorMessagesForElail
                    {
                              get
                              {

                                        this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pie_register\"]/li[8]/div/div/span")));
                                        return this.Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[8]/div/div/span"));
                              }
                    }
                    public IWebElement ErrorMessagesForIncorectElail
                    {
                              get
                              {

                                        this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pie_register\"]/li[8]/div/div/span")));
                                        return this.Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[8]/div/div/span"));
                              }
                    }
                    public IWebElement ErrorMessagesUserName
                    {
                              get
                              {

                                        this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pie_register\"]/li[6]/div/div/span")));
                                        return this.Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[6]/div/div/span"));
                              }
                    }
                    public IWebElement ErrorMessagesForInvalidFormatFile
                    {
                              get
                              {

                                        this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pie_register\"]/li[9]/div/div/span")));
                                        return this.Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[9]/div/div/span"));
                              }
                    }
                    public IWebElement ErrorMessagesForCharactersPassword
                    {
                              get
                              {

                                        this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pie_register\"]/li[6]/div/div/span")));
                                        return this.Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[6]/div/div/span"));
                              }
                    }
                    public IWebElement ErrorMessagesForCharactersDoNotMatch
                    {
                              get
                              {

                                        this.Wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@id=\"pie_register\"]/li[6]/div/div/span")));
                                        return this.Driver.FindElement(By.XPath("//*[@id=\"pie_register\"]/li[6]/div/div/span"));
                              }
                    }


          }
}
