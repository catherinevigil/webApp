using System;
using System.Collections.Generic;
using System.Linq;

namespace uiExp.Shared
{
    public class Conversation
    {
        public FeedPreview feedPreview;

        public List<MessageGroup> Groups = new List<MessageGroup>();
        public List<User> Conversants = new List<User>(); //left is conversant 0
        public String Title;

        public Conversation()
        {
        }

        public Conversation(String[] convo, String[] feed)
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

            for (int i = 0; i < lines.Length - 1; i++)
            {
                if (lines[i].EndsWith(":"))
                {
                    var name = lines[i].Remove(lines[i].Length - 1);
                    var texter = Users.GetUserByName(name);
                    if (!this.Conversants.Any())//if list does not have any elements
                    {
                        this.Conversants.Add(texter);
                        if (texter == null)
                        {
                            Console.WriteLine("no user by this name:" + name);
                        }
                        Console.WriteLine("added conversant" + this.Conversants.Last().GetName());
                    }
                    else
                    {
                        if (this.Conversants.IndexOf(texter) == -1)
                            this.Conversants.Add(texter);
                        Console.WriteLine("added conversant" + texter.GetName());
                    }


                    this.Groups.Add(new MessageGroup(texter));
                }
                else
                {
                    this.Groups.Last().Messages.Add(new Message(lines[i]));
                }

            }
            this.Title = lines[lines.Length - 1];
        }
        public String GetNames()
        {
            string names = "";
            if (this.Conversants.Count == 1)
            {
                return (string)this.Conversants[0].GetName();
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
}

