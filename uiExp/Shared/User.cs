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
        private String Username;
        private String Password;
        private String Bio;

        private string[] Names;


        public User(string name, String img)
        {
            Name = name;
            ImageUrl = img;
            MakeFirstName();
        }
        public User(string name, String username, String password, String img)
        {
            this.Name = name;
            this.ImageUrl = img;
            this.Password = password;
            this.Username = username;

            MakeFirstName();
        }

        public User(string name, string bio, String img)
        {
            this.Name = name;
            this.Bio = bio;
            this.ImageUrl = img;

            MakeFirstName();
        }


        public void MakeFirstName()
        {
            this.Names = this.Name.Split(' ');
            this.FirstName = this.Names[0];
        }
        public bool LogIn(string username, string password)
        {
            Console.WriteLine("in user class method, username:" + username);

            if (!(this.Username == null || this.Password == null)) {
                Console.WriteLine("inside user class method if statement");
                if (this.Username == username && this.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
        public String GetFirstName()
        {
            return this.FirstName;
        }
        public String GetName()
        {
            return this.Name;
        }
        public String GetBio()
        {
            return this.Bio;
        }
        public String GetImg()
        {
            return this.ImageUrl;
        }
    }

}
