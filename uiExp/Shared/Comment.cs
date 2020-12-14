using System;
using System.Collections.Generic;

namespace uiExp.Shared
{
    public class Comment
    {
        private Line cLine;
        private static int totalMinutesPublic = 1440;
        private ReplyManager cReplies;

        Random Rand = new Random();

        public Comment(User commenter)
        {
            this.cLine = new Line(commenter);
            this.cReplies = new ReplyManager(Rand.Next(15), Rand.Next(30));
        }

        public Comment(User commenter, List<Message> bubbles)
        {
            this.cLine = new Line(commenter,bubbles);
            this.cReplies = new ReplyManager(Rand.Next(15), Rand.Next(30));
        }

        public String getColor()
        {
            return this.cLine.getColor();
        }


        public void AddReplier(User replier)
        {
            this.cReplies.AddReplier(replier);
            
        }
        public bool checkReply(User replier)
        {
            return this.cReplies.checkReplier(replier);
        }

        public List<Message> GetBubbles()
        {
            return this.cLine.GetBubbles();
        }
        public void AddLine(String line)
        {
            this.cLine.AddLine(line);
        }
        public String GetFirstText()
        {
            return this.cLine.GetFirstText();
        }
        public User GetCommenter()
        {
            return this.cLine.GetPoster();
        }
        public String GetCommenterName()
        {
            return this.cLine.GetPoster().GetName();
        }
        public String GetCommenterFirstName()
        {
            return this.cLine.GetPoster().GetFirstName();
        }
        public String GetCommenterImg()
        {
            return this.cLine.GetPoster().GetImg();
        }
    }
}




