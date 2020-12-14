using System;
using System.Collections.Generic;

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
        private List<int> Favorites;

        private string[] Names;


        public User(string name, String img)
        {
            this.Favorites = MakeFavorites();
            Name = name;
            ImageUrl = img;
            MakeFirstName();
        }
        public User(string name, String username, String password, String img)
        {
            this.Favorites = MakeFavorites();
            this.Name = name;
            this.ImageUrl = img;
            this.Password = password;
            this.Username = username;

            MakeFirstName();
        }

        public User(string name, String username, String password, String bio, String img)
        {
            this.Favorites = MakeFavorites();
            this.Name = name;
            this.ImageUrl = img;
            this.Password = password;
            this.Bio = bio;
            this.Username = username;

            MakeFirstName();
        }

        public User(string name, string bio, String img)
        {
            this.Favorites = MakeFavorites();
            this.Name = name;
            this.Bio = bio;
            this.ImageUrl = img;

            MakeFirstName();
        }
        public List<int> GetFavorites()
        {
            return this.Favorites;
        }
        private List<int> MakeFavorites()
        {
            List<int> favs = new List<int>();
            var rand = new Random();
            for (int x = 0; x < 7; x++)
            {
                var chance1 = rand.Next(100);
                var chance2 = rand.Next(80);
                if (chance1 > chance2)
                    favs.Add(x);
            }
            return favs;
        }

        private void MakeFirstName()
        {
            this.Names = this.Name.Split(' ');
            this.FirstName = this.Names[0];
        }
        public int GetUri()
        {
            return this.GetHashCode();
        }
        public bool LogIn(string username, string password)
        {
            //Console.WriteLine("in user class method, username:" + username);

            if (!(this.Username == null || this.Password == null)) {
                //Console.WriteLine("inside user class method if statement");
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
