using NUnit.RegistrationForm.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.RegistrationForm.Page.Dropable
{
          public partial class Dropable:BasePage
          {
                    
                    
                    public Dropable(IWebDriver driver):base(driver)
                    {

                    }
                    public string URL
                    {
                              get
                              {
                                        return base.url + "droppable/";
                              }
                    }
                    public void Navigate()
                    {
                              this.Driver.Navigate().GoToUrl(this.URL);
                    }
                    public void DragAndDrop()
                    {
                              this.Driver.Url = "http://demoqa.com/droppable/";
                              Actions builder = new Actions(this.Driver);
                              var drag = builder.DragAndDrop(this.Source, this.Target);
                              drag.Perform();
                    }

          }
}
