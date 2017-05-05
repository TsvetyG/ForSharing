using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.RegistrationForm.Page.RegPage
{
    public static class RegistrationPageAsserter
    {
                public static void AssertRegistrationPageIsOpen(this RegistrationPage page,string text)
               {
                         Assert.AreEqual("Registration", page.Header.Text);
               }
                public static void AssertSuccessMessige(this RegistrationPage page, string text)
               {
                          Assert.IsTrue(page.SuccessMessage.Displayed);
                          Assert.AreEqual(text,page.SuccessMessage.Text);
               }
               public static void AssertRegistrationPageWithoutFirstNames(this RegistrationPage page, string text)
              {
                         Assert.IsTrue(page.ErrorMessagesForFirstNames.Displayed);
                         StringAssert.Contains(text, page.ErrorMessagesForFirstNames.Text);
                         //Assert.AreEqual("This field is required", page.FirstName.Text);
                    }
               public static void AssertRegistrationPageWithoutLastNames(this RegistrationPage page, string text)
               {
                         Assert.IsTrue(page.ErrorMessagesForLastNames.Displayed);
                         StringAssert.Contains(text, page.ErrorMessagesForLastNames.Text);
               }
                    public static void AssertRegistrationPagePhone(this RegistrationPage page, string text)
               {
                              Assert.IsTrue(page.ErrorMessagesForPhone.Displayed);
                              StringAssert.Contains(text, page.ErrorMessagesForPhone.Text);
                              //Assert.AreEqual("Minimum 10 Digits starting with Country Code", page.Phone.Text);
                    }
                    public static void AssertRegistrationIncorectPhone(this RegistrationPage page, string text)
               {
                         Assert.IsTrue(page.ErrorMessagesForPhone.Displayed);
                         StringAssert.Contains(text, page.ErrorMessagesForPhone.Text);
               }

                    public static void AssertRegistrationPageUserName(this RegistrationPage page, string text)
               {
                         Assert.IsTrue(page.ErrorMessagesUserName.Displayed);
                         StringAssert.Contains(text, page.ErrorMessagesUserName.Text);
               }
               public static void AssertRegistrationEmailAddres(this RegistrationPage page, string text)
               {
                         Assert.IsTrue(page.ErrorMessagesForElail.Displayed);
                         StringAssert.Contains(text, page.ErrorMessagesForElail.Text);

               }
               public static void AssertRegistrationIncorectEmailAddres(this RegistrationPage page, string text)
               {
                         Assert.IsTrue(page.ErrorMessagesForIncorectElail.Displayed);
                         StringAssert.Contains(text, page.ErrorMessagesForIncorectElail.Text);

               }
               public static void AssertRegistrationWrongFile(this RegistrationPage page, string text)
               {
                         Assert.IsTrue(page.ErrorMessagesForInvalidFormatFile.Displayed);
                         StringAssert.Contains(text, page.ErrorMessagesForInvalidFormatFile.Text);

               }
               public static void AssertRegistratioWithoutPassword(this RegistrationPage page, string text)
               {
                         Assert.IsTrue(page.ErrorMessagesForCharactersPassword.Displayed);
                         StringAssert.Contains(text, page.ErrorMessagesForCharactersPassword.Text);

               }
               public static void AssertRegistratioPasswordDoNotMatch(this RegistrationPage page, string text)
               {
                         Assert.IsTrue(page.ErrorMessagesForCharactersDoNotMatch.Displayed);
                         StringAssert.Contains(text, page.ErrorMessagesForCharactersDoNotMatch.Text);

               }


          }

}
