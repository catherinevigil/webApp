using System;
using System.Collections.Generic;
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
    

    public class Conversation
    {
        public FeedPreview feedPreview;

        public List<MessageGroup> Groups = new List<MessageGroup>();
        public List<User> Conversants = new List<User>(); //left is conversant 0
        public String Title;

        public Conversation()
        {
        }

        public Conversation (String[] convo, String[] feed)
        {
            SeperateConvo(convo);
            feedPreview = new FeedPreview(feed);
        }

        public Conversation(String[] convo)
        {
            SeperateConvo(convo);
        }

        private void SeperateConvo(string[] lines)
        {
            //Console.WriteLine("seperate was called");

            for (int i = 0; i < lines.Length-1; i++)
            {
                if (lines[i].EndsWith(":"))
                {
                    var name = lines[i].Remove(lines[i].Length - 1);
                    if (!this.Conversants.Any())//if list does not have any elements
                    {
                        this.Conversants.Add(Users.GetUserByName(name));
                        if (!(Users.GetUserByName(name)==null))
                        {
                            Console.WriteLine("no user by this name:" + name);
                        }
                        Console.WriteLine("added conversant" + this.Conversants.Last().GetName());
                    }
                    else
                    {
                        if (this.Conversants.IndexOf(Users.GetUserByName(name)) == -1)
                            this.Conversants.Add(Users.GetUserByName(name));
                            Console.WriteLine("added conversant" + this.Conversants.Last().GetName());
                    }


                    this.Groups.Add(new MessageGroup());
                }
                else
                {
                    this.Groups.Last().Messages.Add(new Message(lines[i]));
                }

            }
            this.Title = lines[lines.Length-1];
        }
        public String GetNames()
        {
            string names="";
            if (this.Conversants.Count == 1)
            {
                return (string) this.Conversants[0].GetName();
            }
            else if (this.Conversants.Count == 2)
            {
                return (this.Conversants[0].GetName() + " & " + this.Conversants[1].GetName());
            }
            return "the squad";
            
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

