using System;
using System.Collections.Generic;
using uiExp.Shared;
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
            Console.WriteLine("seperate was called");
            List<Conversation> ConvoList = new List<Conversation>();
            int index = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(ConvoList.Count);
                if (lines[i] == "")
                {
                    ConvoList.Add(new Conversation());
                }
                else if (lines[i].Contains(":"))
                {
                    var name = lines[i].Remove(lines[i].Length - 1);
                    if (ConvoList.LastOrDefault().Conversants == null)
                    {
                        index = 1;
                        ConvoList.LastOrDefault().Conversants.Add(name);
                    }
                    else
                    {
                        index = ConvoList.LastOrDefault().Conversants.IndexOf(name);
                        if (index != -1)
                            ConvoList.LastOrDefault().Conversants.Add(name);
                        index = ConvoList.LastOrDefault().Conversants.Count - 1;
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
