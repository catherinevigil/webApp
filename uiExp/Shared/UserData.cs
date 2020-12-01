using System;
namespace uiExp.Shared
{
    public class UserData
    {
        private int DateOfBirth;
        private int PhoneNumber;
        private String Name;
        private String ImageUrl;


        public UserData(string name, String img)
        {
            Name = name;
            ImageUrl = img;
        }
        public String GetName()
        {
            return this.Name;
        }
        public String GetImg()
        {
            return this.ImageUrl;
        }
    }

}
