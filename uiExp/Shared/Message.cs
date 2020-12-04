using System;
using System.Linq;
using uiExp.Shared;

namespace uiExp.Shared
{
    public class Message
    {
        public String Text { get; }

        public enum type
        {
            //1: link;
            //2: image;
            //3: plaintext;
        }

        public enum Reaction
        {
            //thumbsUp:1;
        }

        public Message(String text)
        {
            Text = text;
        }
    }
}

