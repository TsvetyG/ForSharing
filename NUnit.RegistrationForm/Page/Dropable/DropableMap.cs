﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.RegistrationForm.Page.Dropable
{
          public partial class Dropable
          {
                    public IWebElement Source
                    { get {
                                        return this.Driver.FindElement(By.XPath("//*[@id=\"draggableview\"]/p"));
                          }
                    }
                    public IWebElement Target
                    {
                              get
                              {
                                        return this.Driver.FindElement(By.Id("droppableview"));
                              }
                    }
          }
}
