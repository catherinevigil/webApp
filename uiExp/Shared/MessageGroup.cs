using System;
using System.Collections.Generic;

namespace uiExp.Shared
{
    public class MessageGroup
    {
        public Boolean Left { get; set; }
        public List<Message> Messages = new List<Message>();
        public User Texter;

        public MessageGroup(User texter)
        {
            this.Texter = texter;
        }
        public User GetTexter()
        {
            return this.Texter;
        }
        public void SetLeft()
        {
            this.Left = true;
            //Console.WriteLine("set left");
        }
        public void SetRight()
        {
            this.Left = false;
           // Console.WriteLine("set right");
        }

    }
}

