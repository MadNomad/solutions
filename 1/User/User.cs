using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    class User
    {
        public string userLogin;
        public string userFirstName;
        public string userLastName;
        public int userAge;
        private DateTime userProfileDate;


        public User(string uLogin, string uFirstName, string uLastName, int uAge)
        {
            userLogin = uLogin;
            userFirstName = uFirstName;
            userLastName = uLastName;
            userAge = uAge;
            userProfileDate = DateTime.Now;
        }


        public void ShowInfo()
        {
            Console.WriteLine("Login\t:\t{0}\nName\t:\t{1} {2}\nAge\t:\t{3}\nAdded\t:\t{4}", userLogin, userFirstName, userLastName, userAge, userProfileDate.ToString("dd MMMM yyyy"));
        }
    }
}
