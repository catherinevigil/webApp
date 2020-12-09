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
        private float fractionTimeLeft;
        private static int totalMinutesPublic = 1440;
        private bool currentUserReplied = false;
        private List<User> repliers = new List<User>();

        public Comment(User commenter)
        {
            this.Commenter = commenter;
        }
        public Comment(User commenter, List<Message> bubbles)
        {
            this.Bubbles = bubbles;
            this.Commenter = commenter;
        }
        public void AddReplier (User replier)
        {
            this.repliers.Add(replier);
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
