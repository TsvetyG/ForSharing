using NUnit.RegistrationForm.Models;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace NUnit.RegistrationForm.Page.RegPage
{
          public partial class RegistrationPage:BasePage
    {
                   

                    public RegistrationPage(IWebDriver driver):base(driver)
        {
        }
                    public void NavigateTo()
                    {
                              this.Driver.Navigate().GoToUrl("http://demoqa.com/registration/");
                    }

                    public void FillRegistrationForm(RegistrationUser user)
                    {
                              Type(this.FirstName, user.FirstName);
                              Type(this.LastName, user.LastName);
                              ClickOnElements(this.MartialStatus, user.MatrialStatus);
                              ClickOnElements(this.Hobbys, user.Hobis);
                              this.CountryOption.SelectByText(user.Country);
                              this.MounthOption.SelectByText(user.BirthMonth);
                              this.DayOption.SelectByText(user.BirthDay);
                              this.YearOption.SelectByText(user.BirthYear);
                              Type(this.Phone, user.Phone);
                              Type(this.UserName, user.UserName);
                              Type(this.Email, user.Email);
                              this.UploadButton.Click();
                              this.Driver.SwitchTo().ActiveElement().SendKeys(user.Picture);
                              Type(this.Description, user.Description);
                              Type(this.Password, user.Password);
                              Type(this.ConfirmPass, user.ConfirmPass);
                              this.SubmitButton.Click();
                    }

                    private void ClickOnElements(List<IWebElement> elements, List<bool> conditions)
                    {
                              for (int i = 0; i < conditions.Count; i++)
                              {
                                        if (conditions[i])
                                        {
                                                  elements[i].Click();
                                        }
                              }
                    }

                    private void Type(IWebElement element, string text)
                    {
                              element.Clear();
                              element.SendKeys(text);
                    }


          }
}
