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
                else if (line==null)
                {
             
                }
                else
                {
                    this.CommentSet.Last().setText(line);
                }
            }
        }
    }
    public class Comment
    {
        private User Commenter;
        private String Text;

        public Comment(User commenter)
        {
            this.Commenter = commenter;
        }
        public Comment(User commenter, String comment)
        {
            this.Text = comment;
            this.Commenter = commenter;
        }
        public void setText(string text)
        {
            this.Text = text;
        }

        public String GetText()
        {
            return this.Text;
        }
        public String GetCommenterName()
        {
            return this.Commenter.GetName();
        }
    }
}
