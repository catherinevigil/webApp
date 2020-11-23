using System;
using System.Collections.Generic;
using System.Linq;

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

    public class Conversation
    {
        public List<MessageGroup> Groups = new List<MessageGroup>();
        public List<String> Conversants = new List<String>(); //left is conversant 0

        public Conversation()
        {

        }

        public void output()
        {
            foreach (var group in Groups)
                foreach (var message in group.Messages)
                    Console.WriteLine(message.Text);
        }

    }


    public class MessageGroup
    {
        public Boolean Left { get; }
        public List<Message> Messages = new List<Message>();

        public MessageGroup()
        {
            //Random rand = new Random();
            //Left = rand.Next() > (Int32.MaxValue / 2);
            //Messages.Add(new Message("blah blah blah"));
            //Messages.Add(new Message("blah blah blah"));

        }

        public MessageGroup(Boolean left)
        {
            //Left = left;
            //Random rand = new Random();
            //left = rand.Next() > (Int32.MaxValue / 2);
            //Messages.Add(new Message("blah blah ah blahah blahah blahah blahah blahah blahah blahah blahblah"));
            //Messages.Add(new Message(
            //    "blah blah ah blahah blahah blahah blahah blahah blahah blahah blahah blahah blahah blahah blahah blahah blahah blahah blahah blahah blahah blahah blahblah"));

        }

    }
}

