using System;
using System.Collections.Generic;
using System.Linq;

namespace uiExp.Shared
{
    public class Hashtags
    {
        public static List<Hashtag> Tags = new List<Hashtag>();
        private static List<string> tagNames = new List<string>{
            "cold war",
            "central banks",
            "currency",
            "real estate",
            "cities",
            "serendipity",
            "stagnation",
            "startups",
            "high school",
            "community",
            "second brain",
            "Roam",
            "altered states",
            "neurotech",
            "neuroscience",
            "higher education",
            "social mobility",
            "privacy",
            "American exceptionalism",
            "bitcoin",
            "music",
            "entrepreneurship",
            "China",
            "marriage",
            "gen z",
            "sex",
            "consent",
            "longevity",
            "governance",
            "media",
            "coding",
            "reading",
            "deepfakes",
            "free speech",
            "surveillance",
            "contact tracing",
            "copyright",
            "cycling",
            "attention spans",
            "memory",
            "content moderation",
            "big tech",
            "dancefloors",
            "existentialism",
            "revolution",
            "suffering",
            "love",
            "philosophy",
            "aesthetics",
            "postmodernism",
            "honesty",
            "authenticity",
            "religion",
            "blockchain",
            "VC",
            "geopolitics",
            "business",
            "militiary history",
            "data",
            "cybersecurity",
            "crypto",
            "computation",
            "game theory",
            "machine learning",
            "psychedelics",
            "consciousness",
            "India",
            "AI",
            "politics",
            "social media"};


        static Hashtags()
        {
            foreach (var tag in tagNames)
            {
                Tags.Add(new Hashtag(tag));
            }
        }

        public static Hashtag GetTagByName(string name)
        {
            foreach (var tag in Tags)
            {
                if (tag.GetText() == name)
                {
                    return tag;
                }
            }
            Console.WriteLine("will return null. no tag by that name: " + name);
            return null;
        }
    }
}

