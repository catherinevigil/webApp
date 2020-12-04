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
                "Lily Heath",
                "I need some new music",
                "Pls send me a playlist!"
            };

            private static string[] lines3 { get; } =
            {
                "Henry Burnes",
                "How did we manage such massive behavior change under to covid?",
                "Didn't expect so much obedience from the liberal democracies. Is it just plain fear?"
            };

        static LoadRequests()
        {
            LineList.Add(new Line(lines0));
            LineList.Add(new Line(lines1));
            LineList.Add(new Line(lines2));
            LineList.Add(new Line(lines3));

        }
    }
}
