using System;
namespace uiExp.Shared
{
    public class User
    {
        private int DateOfBirth;
        private int PhoneNumber;
        private String Name;
        private String ImageUrl;
        private String Bio;

        public User(string name, String img)
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

        public String GetBio()
        {
            return this.Bio
        }
    }

}
