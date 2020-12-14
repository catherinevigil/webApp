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
}
