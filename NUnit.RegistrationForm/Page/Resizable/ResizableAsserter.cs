
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.RegistrationForm.Page.ResizablePage
{
          public static class ResizableAsserter
          {
                    public static void AssertNewSize(this ResizablePage page, int pixelToWidth, int pixelsToheight)
                    {
                              Assert.AreEqual(page.Width + 100, page.windowResize.Size.Width);
                              Assert.AreEqual(page.Height + 100, page.windowResize.Size.Height);
                    }
          }
}
