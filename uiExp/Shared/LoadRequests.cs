using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace uiExp.Shared
{
    public class LoadRequests
    {
        public static List<Line> LineList = new List<Line>();

        private static string[] lines0 { get; } =
            {
                "Eli Burnes:",
                "Why did the Democratic Party let Sanders run? He's not a democrat.",
                "I feel like American politics would be wayy better if the parties had more power."
            };

            private static string[] lines1 { get; } =
            {
               "Sahil Handa:",
               "Almond butter is the the best nut butter",
               "Best macros best micros best fiber best taste.",

            };

            private static string[] lines2 { get; } =
            {
                "Tunc Otzemir:",
                "I need some new music",
                "Pls send me a playlist!"
            };

            private static string[] lines3 { get; } =
            {
                "Henry Burnes:",
                "How did we manage such massive behavior change under to covid?",
                "Didn't expect so much obedience from the liberal democracies. Is it just plain fear?"
            };

            private static string[] lines4 { get; } =
            {
                "Emily Markowitz:",
                "How did you experience time in quarantine?",
                "it's both faster and slower and something else entirely"
            };

            private static string[] lines5 { get; } =
            {
                "Jonah Berger:",
                "Democrat's allocation of capital this election was atrocious.",
                "tens of millions to Stacey Abrams? how can we fix this?"
            };

            private static string[] lines6 { get; } =
            {
                "Campbell Erickson:",
                "runnning is the purest sport.",
                "practice directly translates to performance. you can quickly reach the limit. "
            };

            private static string[] lines7 { get; } =
            {
                "Ian Liefer:",
                "space mining should be done under the jurisdiction of no nation state",
                "we should form a space government with no land boundaries. government by internet, a democracy of space going citizens from all over the globe."
            };

        static LoadRequests()
        {
            LineList.Add(new Line(lines0));
            LineList.Add(new Line(lines1));
            LineList.Add(new Line(lines2));
            LineList.Add(new Line(lines3));
            LineList.Add(new Line(lines4));
            LineList.Add(new Line(lines5));
            LineList.Add(new Line(lines6));


        }
    }
}
