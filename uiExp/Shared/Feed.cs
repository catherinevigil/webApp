//this class is no longer used. keeping it around to 1. have the text of the feed in string format and 2. to suggest maybe in the future to edit then use this class

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
    }
}
