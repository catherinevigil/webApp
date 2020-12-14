using System;
using System.Collections.Generic;
using System.Linq;

namespace uiExp.Shared
{
    public class ReplyManager
    {
        private bool replyLimit = true;
        private int repliesAccepted;
        private int repliesRecieved;
        private bool acceptingReplies = true;
        List<User> Repliers;

        public ReplyManager(int accepted, int recieved)
        {
            this.repliesAccepted = accepted;
            this.repliesRecieved = recieved;
            FixReplies();
        }

        public ReplyManager(int recieved) //constructor for reply manager with no limit on # of replies
        {
            this.repliesRecieved = recieved;
            this.replyLimit = false;
        }

        public void FixReplies()
        {
            if (this.repliesRecieved > this.repliesAccepted)
            {
                this.repliesRecieved = this.repliesAccepted;
                this.acceptingReplies = false;
            }
        }
        public void AddReplier(User replier)
        {
            this.Repliers.Add(replier);
            this.repliesRecieved++;
            if (this.replyLimit && this.repliesRecieved == this.repliesAccepted)
            {
                this.acceptingReplies = false;
            }
        }
        public bool checkReplier(User replier)
        {
            return this.Repliers.Contains(replier);
        }
    }
}
