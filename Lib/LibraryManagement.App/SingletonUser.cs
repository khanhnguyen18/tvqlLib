using System;
using System.Collections.Generic;
using System.Text;
using LibraryManagement.Domain;

namespace LibraryManagement.App
{
    public class SingletonUser
    {
        private static User currentUser;

        public static void SetUser(User input)
        {
            currentUser = input;
        }

        public static User GetUser()
        {
            return currentUser;
        }
    }
}
