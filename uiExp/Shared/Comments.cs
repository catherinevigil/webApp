using System;
using System.Collections.Generic;
using System.Linq;

namespace uiExp.Shared
{
    public class Comments
    {
        List<Comment> CommentSet = new List<Comment>();

        public Comments(string[] rawtext)
        {
            MakeSet(rawtext);
        }
        public List<Comment> GetComments()
        { return this.CommentSet; }

        public void MakeSet(string[] rawtext)
        {
            foreach (var line in rawtext)
            {
                if (line.EndsWith(":"))
                {
                    var person = Users.GetUserByName(line.Remove(line.Length - 1));
                    this.CommentSet.Add(new Comment(person));
                }
                else if (line == null)
                {

                }
                else
                {
                    this.CommentSet.Last().AddLine(line);
                }
            }
        }
    }

    public class Comment
    {
        private User Commenter;
        private List<Message> Bubbles = new List<Message>();
        private double fractionTimeLeft;
        private DateTime postTime;
        private static int totalMinutesPublic = 1440;
        private bool currentUserReplied = false;
        private List<User> repliers = new List<User>();
        private int repliesAccepted;
        private int repliesRecieved;
        private bool acceptingReplies = true;

        Random Rand = new Random();

        public Comment(User commenter)
        {
            this.Commenter = commenter;
            this.fractionTimeLeft = (double) Rand.Next(1000) / (double) 1000;
            this.repliesAccepted = Rand.Next(15);
            this.repliesRecieved = Rand.Next(30);

            FixReplies();
        }
        public void FixReplies()
        {
            if (this.repliesRecieved > this.repliesAccepted)
            {
                this.repliesRecieved = this.repliesAccepted;
                this.acceptingReplies = false;
            }
        }
        public Comment(User commenter, List<Message> bubbles)
        {
            this.Bubbles = bubbles;
            this.Commenter = commenter;
        }

        public String getColor()
        {
            string color = ("rgb(" + (this.fractionTimeLeft * 255).ToString() + ", " + (this.fractionTimeLeft * 140).ToString() + ", 0)");
            Console.WriteLine(color);
            return color;
        }
        public void AddReply(User user, List<Message> reply)
        {
            AddReplier(user);
        }
        public void AddReplier (User replier)
        {
            this.repliers.Add(replier);
            this.repliesRecieved = this.repliesRecieved + 1;

            if (this.repliesRecieved == this.repliesAccepted)
            {
                this.acceptingReplies = false;
            }
        }
        public bool checkReply(User replier)
        {
            return this.repliers.Contains(replier);
        }

        public List<Message> GetBubbles()
        {
            return this.Bubbles;
        }
        public void AddLine(String line)
        {
            this.Bubbles.Add(new Message(line));
        }
        public String GetFirstText()
        {
            return this.Bubbles.First().Text;
        }
        public User GetCommenter()
        {
            return this.Commenter;
        }
        public String GetCommenterName()
        {
            return this.Commenter.GetName();
        }
        public String GetCommenterFirstName()
        {
            return this.Commenter.GetFirstName();
        }
        public String GetCommenterImg()
        {
            return this.Commenter.GetImg();
        }
    }
}
