using System;
using System.Collections.Generic;
using System.Text;

namespace EventDelegates
{
    public class User
    {
        public string FirstName { get; set; }

        public User(string firstName)
        {
            this.FirstName = firstName;
        }
    }
}
