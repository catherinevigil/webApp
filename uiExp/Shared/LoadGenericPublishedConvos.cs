using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
namespace uiExp.Shared
{
    public class LoadGenericPublishedConvos
    {
        private static List<PublishedMessage> inboxList = new List<PublishedMessage>();

        private static string[] lines0 { get; } =
            {
                "Noah Redlich:",
                "tristique et egestas quis ipsum. Scelerisque in dictum non consectetur a erat nam at lectus. Vitae proin sagittis nisl rhoncus. Urna id volutpat lacus laoreet non curabitur.",
                "Sahil Handa:",
                "Eu volutpat odio facilisis",
                "Ethan Fields:",
                "mauris sit amet. Dignissim enim sit amet venenatis",
                "Eli Burnes:",
                "urna cursus eget nunc scelerisque",
                "Jasmine Wang:",
                "Integer enim neque volutpat ac tincidunt. Vestibulum mattis ullamcorper velit sed ullamcorper morbi tincidunt ornare.",
                "Sahil Handa:",
                "Massa ultricies mi quis",
                "Henry Burnes:",
                "Massa ultricies mi quis hendrerit dolor magna eget est lorem",
                "Jonah Berger:",
                "Et malesuada fames.",
                "Campbell Erickson:",
                "Tortor vitae purus faucibus ornare",
                "Tunc Otzemir:",
                "Sit amet",
                "Marshall Sloane:",
                "nulla facilisi morbi. suspendisse sed nisi lacus. Volutpat commodo sed egestas egestas fringilla phasellus faucibus scelerisque eleifend",
                "Kush Sharma:",
                "ac turpis...",
                "Henry Burnes:",
                "Dui nunc mattis enim ut tellus elementum??",
                "Ian Liefer:",
                "Quisque id diam vel quam elementum",
                "Caleb Rhodes:",
                "aliquam vestibulum morbi. In ante metus dictum at tempor commodo ullamcorper. In cursus turpis massa tincidunt dui ut ornare lectus. Suspendisse interdum",
                "Saffron Huang:",
                "Amet venenatis urna cursus",
                "Jasmine Wang:",
                "Quisque id diam vel quam",
                "Emily Markowitz:",
                "neque aliquam vestibulum morbi blandit cursus risus at",
                "Regan Brady:",
                "Amet venenatis urna cursus eget nunc scelerisque",
                "Garrett Walker:",
                "pellentesque diam volutpat commodo. Quisque sagittis purus sit amet volutpat",
                "Jake Sylvestre:",
                "justo laoreet sit amet",
                "David Grant",
                "Erat imperdiet sed euismod nisi",
                "Rahul Vohra",
                "pretium aenean pharetra. Mi in nulla posuere sollicitudin",
                "Soroush Ghodsi:",
                "Dui vivamus arcu felis bibendum"
            };

        private static string[] lines1 { get; } =
            {
                
            };
        private static string[] lines2 { get; } =
            {

            };

        private static string[] lines3 { get; } =
            {

            };
        private static string[] lines4 { get; } =
            {

            };
        private static string[] lines5 { get; } =
            {
            };

        public static List<PublishedMessage> InboxList { get => inboxList; set => inboxList = value; }

        private static string user = "Sahil Handa";

        static LoadGenericPublishedConvos()
        {
            InboxList.Add(new PublishedMessage(lines0, user, "Noah Redlich", "Latin groupchat"));
            //InboxList.Add(new PublishedMessage(lines1, user));
            //InboxList.Add(new PublishedMessage(lines2, user));
        }
    }
}

