using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSystem.App_Code
{
    class UserInfo
    {
        static string username = "";
        static int role = 2;

        public static string getUsername()
        {
            return username;
        }

        public static void setUsername(string value)
        {
            username = value;
        }

        public static int getUserRole()
        {
            return role;
        }

        public static void setUserRole(int value)
        {
            role = value;
        }
    }
}
