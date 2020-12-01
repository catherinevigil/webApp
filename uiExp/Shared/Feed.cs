using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;


namespace uiExp.Shared
{

    public class Feed
    {
        private static string[] Lines { get; } = {
            "",
            "Eli Burnes:",
            "Dude what do you think of contemporary interior design / architecture. Like the aesthetic of all the new coffee shops",
            "Tunc Otzemir:",
            "I think it’s good for the cafes",
            "It is nice but not super cozy",
            "",
            "Kush Sharma:",
            "Creating guilt among the powerful functions in a fractal way. The aristocrats of the Roman republic had the same internal dynamics - e.g. Gaius Marius, a low-born but extremely competent military general who denounced the high aristocracy of his day for responding to crises with haughty arrogance that didn't correspond to their abilities. They had power, but competence isn't hereditary like power is/was, so the critiques hit on a legitimate point.",
            "Eli Burnes:",
            "What do you mean by fractal?",
            "",
            "Jasmine Wang:",
            "china is so full of contradictions ",
            "",
            "Ethan Fields:",
            "Even prior to the pandemic, the art and museum world was in a state of flux as institutions were critiqued for accepting dubious donations",
            "So the board members clearly wanted to mitigate any sense of controversy that could have exposed them to public dissatisfaction",
            "Caleb Rhodes:",
            "Yeah this is definitely a defensive move, but was it motivated by money or just fear of outrage?",
            "",
            "Emily Markowitz:",
            "I definitely think that in quarantine time felt that it was going by much quicker",
            "Regan Brady:",
            "yeah i agree- the spring felt like I was reliving the same day over and over",
            "and honestly, i couldn’t tell you anything that happened to me this summer",
            "Emily Markowitz:",
            "exactly, it molds together",
            "",
            "Ian Liefer:",
            "Why do you think Biden is gonna win?",
            "Trump has unprecedented black and Latino support",
            "And hasn’t lost any of his base",
            "Henry Burnes:",
            "elderly people and suburban women are going for Biden, two critical demographics for Trump",
            "Ian Liefer:",
            "but it’s unclear if the data supports that in key swing states",
            "",
            "Eli Burnes:",
            "The culture of the nouveau riche is taking over. Because “class” as a state of mind and manners is less and less respected",
            "Simpler and more vulgar ways are being used to assert dominance and prestige" };

        public static List<Conversation> FeedList = new List<Conversation>();
        public String name = "i am a feed";

        static Feed()
        {
            FeedList = Seperate(Lines);
        }

        private static List<int> convoBreaks (string[] lines)
        {
            var positionList = new List<int>();
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] == "")
                {
                    positionList.Add(i);
                }
            }
            return positionList;
        }

        //private static List<Conversation> MakeFeed( string[] lines)
        //{

        //    List<Conversation> ConvoList = new List<Conversation>();

        //    var list = convoBreaks(lines);
        //    list.Add(lines.Length);
        //    list.Insert(0, 0);

        //    var length = list.Count;

        //    for (int i = 0; i < length-1; i++)
        //    {
        //        var segLength = list[i + 1] - list[i];
        //        var upTo = lines.Skip(list[i]).Take(segLength).ToArray();
        //        ConvoList.Add(new Conversation(upTo));
        //    }
        //    return ConvoList;
        //}

        private static List<Conversation> Seperate(string[] lines)
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
                        ConvoList.LastOrDefault().Conversants.Add(Users.GetUserByName(name));
                        Console.WriteLine("added conversant" + ConvoList.LastOrDefault().Conversants.Last().GetName());
                    }
                    else
                    {
                        if (ConvoList.LastOrDefault().Conversants.IndexOf(Users.GetUserByName(name)) == -1)//could maybe replace this with ==
                            ConvoList.LastOrDefault().Conversants.Add(Users.GetUserByName(name));
                        Console.WriteLine("added conversant" + ConvoList.LastOrDefault().Conversants.Last().GetName());
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
