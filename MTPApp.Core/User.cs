using System;
using System.Collections.Generic;
using System.Text;

namespace MTPApp.Core
{
    public class User
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public User(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;

        }

    }
}
