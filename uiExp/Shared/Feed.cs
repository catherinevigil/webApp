using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;


namespace uiExp.Shared
{

    public class Feed
    {
        public List<Conversation> FeedList = new List<Conversation>();
        public String name = "i am a feed";

        public Feed(String[] lines)
        {
            FeedList = Seperate(lines);
        }

        private List<Conversation> Seperate(string[] lines)
        {
            //Console.WriteLine("seperate was called");
            List<Conversation> ConvoList = new List<Conversation>();

            for (int i = 0; i < lines.Length; i++)
            {
                //Console.WriteLine(ConvoList.Count);
                if (lines[i] == "")
                {
                    ConvoList.Add(new Conversation());
                }
                else if (lines[i].Contains(":"))
                {
                    var name = lines[i].Remove(lines[i].Length - 1);
                    if (!ConvoList.LastOrDefault().Conversants.Any())//if list does not have any elements
                    {
                        ConvoList.LastOrDefault().Conversants.Add(name);
                        Console.WriteLine("added conversant" + ConvoList.LastOrDefault().Conversants.Last());
                    }
                    else
                    {
                        if (ConvoList.LastOrDefault().Conversants.IndexOf(name) == -1)
                            ConvoList.LastOrDefault().Conversants.Add(name);
                        Console.WriteLine("added conversant" + ConvoList.LastOrDefault().Conversants.Last());
                    }


                    ConvoList.LastOrDefault().Groups.Add(new MessageGroup());
                }
                else
                {
                    ConvoList.Last().Groups.Last().Messages.Add(new Message(lines[i]));
                }

            }

            return ConvoList;
        }
    }
}
