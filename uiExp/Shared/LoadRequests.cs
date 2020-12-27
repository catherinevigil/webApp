using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace uiExp.Shared
{
    public class LoadRequests
    {
        public static List<Request> RequestList = new List<Request>();

        private static string[] lines0 { get; } =
            {
                "Eli Burnes",
                "Why did the Democratic Party let Sanders run? He's not a democrat.",
            };

            private static string[] lines1 { get; } =
            {
               "Sahil Handa",
               "Almond butter is the the best nut butter",
            };

            private static string[] lines2 { get; } =
            {
                "Tunc Otzemir",
                "I need some new music",
            };

            private static string[] lines3 { get; } =
            {
                "Henry Burnes",
                "How did we manage such massive behavior change under to covid?",
            };

            private static string[] lines4 { get; } =
            {
                "Emily Markowitz",
                "How did you experience time in quarantine?",
            };

            private static string[] lines5 { get; } =
            {
                "Jonah Berger",
                "Democrat's allocation of capital this election was atrocious.",
            };

            private static string[] lines6 { get; } =
            {
                "Campbell Erickson",
                "runnning is the purest sport.",
            };

            private static string[] lines7 { get; } =
            {
                "Ian Liefer",
                "space mining should be done under the jurisdiction of no nation state",
            };

        static LoadRequests()
        {
            RequestList.Add(new Request(lines0));
            RequestList.Add(new Request(lines1));
            RequestList.Add(new Request(lines2));
            RequestList.Add(new Request(lines3));
            RequestList.Add(new Request(lines4));
            RequestList.Add(new Request(lines5));
            RequestList.Add(new Request(lines6));
        }
    }
}
