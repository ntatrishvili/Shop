using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    internal class Procedures
    {
        public static bool RegisterUser(User user)
        {
            //code
            if (user == null) return false;
            return true;
        }

        public static User LogIn(string email, string Password)
        {
            //findUserByEmail + checkPassword
            return new User();
        }
    }
}
