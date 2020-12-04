using System;
using System.Collections.Generic;

namespace uiExp.Shared
{
    public class MessageGroup
    {
        public Boolean Left { get; }
        public List<Message> Messages = new List<Message>();
        public User Texter;

        public MessageGroup(User texter)
        {
            this.Texter = texter;

        }

    }
}

