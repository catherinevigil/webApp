using System;
using System.Collections.Generic;
using System.Linq;

namespace uiExp.Shared
{
    public class Line
    {
        private User Poster;
        private List<Message> Bubbles = new List<Message>();
        private double fractionTimeLeft;
        private DateTime postTime;
        private bool currentUserReplied = false;
        private List<User> repliers = new List<User>();
        private int repliesRecieved;
        

        Random Rand = new Random();

        public Line()
        {
            this.fractionTimeLeft = (double)Rand.Next(1000) / (double)1000;
        }

        public Line(User poster)
        {
            this.Poster = poster;
            this.fractionTimeLeft = (double)Rand.Next(1000) / (double)1000;

        }
      
        public Line(User poster, List<Message> bubbles)
        {
            this.fractionTimeLeft = (double)Rand.Next(1000) / (double)1000;
            this.Bubbles = bubbles;
            this.Poster = poster;
        }

        public String getColor()
        {
            string color = ("rgb(" + (this.fractionTimeLeft * 255).ToString() + ", " + (this.fractionTimeLeft * 140).ToString() + ", 0)");
            Console.WriteLine(color);
            return color;
        }
        //public void AddReply(User user, List<Message> reply)
        //{
        //    AddReplier(user);
        //}

        public bool checkReply(User replier)
        {
            return this.repliers.Contains(replier);
        }

        public List<Message> GetBubbles()
        {
            return this.Bubbles;
        }
        public void SetBubbles(List<Message> bubbles)
        {
            this.Bubbles=bubbles;
        }
        public void AddLine(String line)
        {
            this.Bubbles.Add(new Message(line));
        }
        public String GetFirstText()
        {
            return this.Bubbles.First().Text;
        }
        public void SetPoster(string poster)
        {
            this.Poster = Users.GetUserByName(poster);
        }
        public void SetPoster(User poster)
        {
            this.Poster = poster;
        }

        public User GetPoster()
        {
            return this.Poster;
        }
        public String GetPosterName()
        {
            return this.Poster.GetName();
        }
        public String GetPosterFirstName()
        {
            return this.Poster.GetFirstName();
        }
        public String GetPosterImg()
        {
            return this.Poster.GetImg();
        }
    }
}