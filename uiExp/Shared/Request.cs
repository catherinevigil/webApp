using System;
using System.Collections.Generic;

namespace uiExp.Shared
{
    public class Request
    {
        public Line rLine;
        public List<User> Scope = new List<User>();
        private ReplyManager rReplies;

        public Request(string[] text)
        {
            this.rLine = new Line();
            this.rLine.SetPoster(text[0]);
            this.rLine.SetBubbles(MakeBubbles(text));
            this.rReplies = new ReplyManager(0);//each request starts with 0 replies recieved. this data not currently visible in UI
        }
        public List<Message> MakeBubbles(string[] text)
        {
            var bubbleList = new List<Message>();
            foreach (var line in text)
            {
                bubbleList.Add(new Message(line));
            }
            return bubbleList;
        }

        public void AddReplier(User replier)
        {
            this.rReplies.AddReplier(replier);

        }
        public bool checkReply(User replier)
        {
            return this.rReplies.checkReplier(replier);
        }

        public List<Message> GetBubbles()
        {
            return this.rLine.GetBubbles();
        }
        public void AddLine(String line)
        {
            this.rLine.AddLine(line);
        }
        public String GetFirstText()
        {
            return this.rLine.GetFirstText();
        }
        public User GetPoster()
        {
            return this.rLine.GetPoster();
        }
        public String GetPosterName()
        {
            return this.rLine.GetPoster().GetName();
        }
        public String GetPosterFirstName()
        {
            return this.rLine.GetPoster().GetFirstName();
        }
        public String GetPosterImg()
        {
            return this.rLine.GetPoster().GetImg();
        }
    }
}
