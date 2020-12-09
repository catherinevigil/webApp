using System;
namespace uiExp.Shared
{
    public class User
    {
        private int DateOfBirth;
        private int PhoneNumber;
        private String Name;
        private String ImageUrl;
        private String FirstName;
        private string[] Names;


        public User(string name, String img)
        {
            Name = name;
            ImageUrl = img;
            MakeFirstName();
        }
        public void MakeFirstName()
        {
            this.Names = this.Name.Split(' ');
            this.FirstName = this.Names[0];
        }
        public String GetFirstName()
        {
            return this.FirstName;
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
