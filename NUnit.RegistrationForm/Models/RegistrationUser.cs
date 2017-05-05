using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.RegistrationForm.Models
{
          public class RegistrationUser
          {
                    private String firstName;
                    private String lastName;
                    private List<bool> matrialStatus;
                    private List<bool> hobbys;
                    private String country;
                    private String birthMonth;
                    private String birthDay;
                    private String birthYear;
                    private String phone;
                    private String userName;
                    private String email;
                    private String picture;
                    private String description;
                    private String password;
                    private String confirmPass;
         public RegistrationUser( 
                     String firstName,
                     String lastName,
                     List<bool> matrialStatus,
                     List<bool> hobbys,
                     String country,
                     String birthMonth,
                     String birthDay,
                     String birthYear,
                     String phone,
                     String userName,
                     String email,
                     String picture,
                     String description,
                     String password,
                     String confirmPass
                   )
                    {
                              this.firstName =firstName;
                              this.lastName = lastName;
                              this.matrialStatus = matrialStatus;
                              this.hobbys = hobbys;
                              this.country = country;
                              this.birthMonth = birthMonth;
                              this.birthDay = birthDay;
                              this.birthYear = birthYear;
                              this.phone = phone;
                              this.userName = userName;
                              this.email = email;
                              this.picture = picture;
                              this.description = description;
                              this.password = password;
                              this.confirmPass = confirmPass;

                    }
                    public string FirstName
                    {
                              get { return this.firstName;}
                              set { this.firstName = value;}
                    }
                    public string LastName
                    {
                              get { return this.lastName; }
                              set { this.lastName = value; }
                    }

                    public List<bool> MatrialStatus
                    {
                              get { return this.matrialStatus; }
                              set { this.matrialStatus = value; }
                    }
                    public List<bool> Hobis
                    {
                              get { return this.hobbys; }
                              set { this.hobbys = value; }
                    }
                    public string Country
                    {
                              get { return this.country; }
                              set { this.country = value; }
                    }
                    public string BirthMonth
                    {
                              get { return this.birthMonth; }
                              set { this.birthMonth = value; }
                    }
                    public string BirthDay
                    {
                              get { return this.birthDay; }
                              set { this.birthDay = value; }
                    }
                    public string BirthYear
                    {
                              get { return this.birthYear; }
                              set { this.birthYear = value; }
                    }
                    public string Phone
                    {
                              get { return this.phone; }
                              set { this.phone = value; }
                    }
                    public string UserName
                    {
                              get { return this.userName; }
                              set { this.userName = value; }
                    }
                    public string Email
                    {
                              get { return this.email; }
                              set { this.email = value; }
                    }
                    public string Picture
                    {
                              get { return this.picture; }
                              set { this.picture = value; }
                    }
                    public string Description
                    {
                              get { return this.description; }
                              set { this.description = value; }
                    }
                    public string Password
                    {
                              get { return this.password; }
                              set { this.password = value; }
                    }
                    public string ConfirmPass
                    {
                              get { return this.confirmPass; }
                              set { this.confirmPass = value; }
                    }
          }
}
