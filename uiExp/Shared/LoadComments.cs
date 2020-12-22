using System;
using System.Collections.Generic;
using System.Linq;

namespace uiExp.Shared
{
    public class LoadComments
    {
        public static List<Comments> CommentsList = new List<Comments>();
        private static string[] convo0 { get; } =
        {
            "Eli Burnes:",
            "I'd like to take a stance on this aesthetic. Of course the places are clean, the interactions go smoothly (at least for people used to such interiors), yet this smoothly is the smoothness of a boy on morphine idly talking to his fastidious nurse. The coffee is generally top notch. And the whiteness of the whole thing does instill an air of possibility into the room. A youthful orientation. I'm mixed on the vibe.",
            "consectetur adipiscing. Enim sit amet venenatis urna cursus eget nunc scelerisque. Adipiscing enim eu turpis egestas. Mattis pellentesque id nibh tortor id aliquet lectus proin.",
            "Saffron Huang:",
            "Yes you can smell the efficiency of it. These places are comforting, though. Young, friendly, usually attractive staff...",
            "Noah Redlich:",
            "This is an embodiment of the elites' dream to escape the world of dirt, toil, disease, inefficiency, spontaneity. the playlists probably come down from corporate.",
            "Marshall Sloane:",
            "All I need is a quick cup of coffee. Just a hit of caffeine and some blue light to stimulate the nerves and I'm out.",
            "Campbell Erickson:",
            "Of course I love the incandescent bulbs and the plants. Honestly vibe depends on the barista's mood.",
            "Ligula ullamcorper malesuada proin libero nunc consequat interdum varius?",
             "Massa ultricies mi quis hendrerit dolor magna eget est lorem",
            "Regan Brady:",
            "Lorem ipsum dolor sit amet",
            "Emily Markowitz:",
            "consectetur adipiscing elit.",
            "consectetur adipiscing.",
            "Kush Sharma:",
            "consectetur adipiscing."
        };
        private static string[] convo1 { get; } =
        {
            "Regan Brady:",
            "Lorem ipsum dolor sit amet",
            "Emily Markowitz:",
            "consectetur adipiscing elit.",
            "Kush Sharma:",
            "consectetur adipiscing. Enim sit amet venenatis urna cursus eget nunc scelerisque. Adipiscing enim eu turpis egestas. Mattis pellentesque id nibh tortor id aliquet lectus proin. Nulla aliquet porttitor lacus luctus accumsan tortor posuere ac.",
            "Caleb Rhodes:",
            "eiusmod",
            "Sahil Handa:",
            "tempor incididunt ut labore",
            "Jonah Berger:",
            "et dolore magna",
            "Eli Burnes:",
            "Ligula ullamcorper malesuada proin libero nunc consequat interdum varius",
            "Noah Redlich:",
            "et dolore magna aliqua",
            "Henry Burnes:",
            "Elementum nisi"
        };
        private static string[] convo2 { get; } =
        {
            "Caleb Rhodes:",
            "eiusmod",
            "Sahil Handa:",
            "tempor incididunt ut labore",
            "Jonah Berger:",
            "et dolore magna",
            "Jonah Berger:",
            "Ligula ullamcorper malesuada proin libero nunc consequat interdum varius",
            "Noah Redlich:",
            "et dolore magna aliqua",
            "Henry Burnes:",
            "Elementum nisi"
        };
        private static string[] convo3 { get; } =
        {
            "Regan Brady:",
            "Lorem ipsum dolor sit amet",
            "Emily Markowitz:",
            "consectetur adipiscing elit.",
            "Kush Sharma:",
            "consectetur adipiscing. Enim sit amet venenatis urna cursus eget nunc scelerisque. Adipiscing enim eu turpis egestas. Mattis pellentesque id nibh tortor id aliquet lectus proin. Nulla aliquet porttitor lacus luctus accumsan tortor posuere ac. ",
            "Jasmine Wang:",
            "sed do",
            "Tunc Otzemir:",
            "eiusmod tempor incididunt",
            "Caleb Rhodes:",
            "eiusmod tempore et urna cursus"
        };
        private static string[] convo4 { get; } =
        {
            "Sahil Handa:",
            "tempor incididunt ut labore",
            "Jonah Berger:",
            "et dolore magna"
        };
        private static string[] convo5 { get; } =
        {
            "Eli Burnes:",
            "Ligula ullamcorper malesuada proin libero nunc consequat interdum varius",
           
        };
        private static string[] convo6 { get; } =
        {
            "Noah Redlich:",
            "tristique et egestas quis ipsum. Scelerisque in dictum non consectetur a erat nam at lectus. Vitae proin sagittis nisl rhoncus. Urna id volutpat lacus laoreet non curabitur.",
            "Sahil Handa:",
            "Eu volutpat odio facilisis",
            "Ethan Fogarty:",
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
            "Noah Redlich:",
            "et dolore magna aliqua",
            "Henry Burnes:",
            "Elementum nisi",
            "Emily Markowitz:",
            "Enim sit amet venenatis urna cursus eget nunc scelerisque. Adipiscing enim eu turpis egestas. Mattis pellentesque id nibh tortor id aliquet lectus proin. Nulla aliquet porttitor lacus luctus accumsan tortor posuere ac. Nulla aliquet enim tortor at auctor urna. Aliquam sem fringilla ut morbi tincidunt augue",
            "Garrett Walker:",
            "quis eleifend quam adipiscing vitae"
        };

        static LoadComments()
        {
            CommentsList.Add(new Comments(convo0));
            CommentsList.Add(new Comments(convo1));
            CommentsList.Add(new Comments(convo2));
            CommentsList.Add(new Comments(convo3));
            CommentsList.Add(new Comments(convo4));
            CommentsList.Add(new Comments(convo5));
            CommentsList.Add(new Comments(convo6));

        }
    }
}
