using System;
using System.Collections.Generic;
using System.Linq;

namespace uiExp.Shared

{
    public static class CurrentUser
    {
        private static User cUser;
        private static DateTime loginTime;

        static CurrentUser()
        {
        }
        public static void SetUser(User user)
        {
            cUser = user;
        }
        public static User GetUser()
        {
            return cUser;
        }
    }
}
