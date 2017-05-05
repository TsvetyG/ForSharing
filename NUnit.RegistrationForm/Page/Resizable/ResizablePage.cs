using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.RegistrationForm.Page.ResizablePage
{
           public partial class ResizablePage:BasePage

          { private int width;
            private int height;

          public ResizablePage(IWebDriver driver) : base(driver)
         {
         }
                    public int Width { get; set; }
                    public int Height { get; set; }
                    public string URL
                   {
                    get
                   {
                     return base.url + "/resizable/";

                    }
                    }

                    public object resizeWindow { get; private set; }

                    public void NavigateTo()
                    {
                              this.Driver.Navigate().GoToUrl(this.URL);
                    }
                    public void ResizableWidthHeight()
                    {
                              this.NavigateTo();
                              this.width = this.windowResize.Size.Width;
                    }

          }
}
