using NUnit.Framework;

namespace NUnit.RegistrationForm.Page.Dropable
{
          public static class DropableAsserter
          {
                    public static void AssertTargetAtribut(this Dropable page, string classValue)
                    {
                              Assert.AreEqual(classValue, page.Target.GetAttribute("class"));
                    }
          }
}
