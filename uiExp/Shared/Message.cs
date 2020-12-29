using System;
using System.Linq;
using uiExp.Shared;

namespace uiExp.Shared
{
    public class Message
    {
        public String Text { get; }
        public SelectionManager selectionManager = new SelectionManager();

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
        //public int numInConvo;

        public Message(String text)
        {
            this.Text = text;
        }

        //public Message(String text, int num)
        //{
        //    Text = text;
        //    this.numInConvo = num;
        //}

        public Message()
        {
        }
    }
}

