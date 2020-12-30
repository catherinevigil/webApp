using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace uiExp.Shared
{
    public class LoadGenericTagConvos
    {
        public static List<PublicConvo> ConvoList = new List<PublicConvo>();

        private static string[] lines0 { get; } =
        {
                "Bruno Macaes:",
                "Philosophy has made no progress whatsoever",
                "I still believe - and maybe this view cannot hold - that philosophy is like a slot machine.",
                "You try and try and one day one lucky bastard will hit a jackpot. Progress makes no sense here",
                "Agnes Callard:",
                "one question I wonder about: suppose it made lots of progress--suppose we hit the jackpot--how would we know it?",
                "Bruno Macaes:",
                "That’s the reason I say it might not hold.",
                "But I still think a radically new and simultaneously compelling view of the world could  be found - to be followed by a kind of generalized acceptance",
                "We have that in the realm of practical knowledge. The wheel, language, the city, etc. I am thinking the same could happen in the realm of theory.",
                "Obviously has not happened yet, but we have only been trying for 3000 years and often it’s been the wrong kind of people trying",
                "Agnes Callard:",
                "Wheel, language, city have paved the way for further inventions/discoveries, do you think that is how it would work for theorizing, or we would just be 'done'?",
                "Bruno Macaes:",
                "I think a framework would have to come all at once.",
                "Could then be filled in.",
                "But yes as opposed to science philosophy is a view of the whole, can’t see adding pieces to make a whole",
                "Agnes Callard:",
                "Do you think that, after this discovery has been made, human beings will have no cause to think in a universal way about the meaning of human life, the metaphysical structure of the universe, the problems of knowledge, etc.?",
                "Bruno Macaes:",
                "Possibly no",
                "The question of whether it was the right theory could remain in principle open",
                "There would be critics. There would be many scientific and technologicial questions still to address.",
                "Many people would not care. But yes it would be there as the answer to main questions",
                "Agnes Callard:",
                "Suppose I told you (and suppose you had reason to believe me) that I had in my possession a book containing the right theory.",
                "Would you be inclined to read it?",
                "Bruno Macaes:",
                "Yes. I have been looking for that book for at least 30 years. But I would know after just a few pages. Looking forward!",
                "Agnes Callard:",
                "How would you know?",
                "Bruno Macaes:",
                "I have tried all available alternatives.",
                "If this one appeared much superior to them, would be a good sign. Do you have it? In digital format?",
                "It seems you already have the knowledge you seek.",
                "Bruno Macaes",
                "Haha. Very nice Platonic dialogue we just had. But I still want the book! It must be out there",
                "Agnes Callard:",
                "I am currently writing a book that will attempt to persuade you otherwise (i.e. it argues that the book isn't & can't be 'out there').",
                "When I have a draft (will be a while yet...) I will send to you.",
                "Bruno Macaes",
                "That sounds very interesting",
                "No, I am pretty sure it is not out there. But I think it could and probably will be written (perhaps by a computer)",
                "But maybe you disagree with that too (with the whole premise)",
            };

        private static string[] lines1 { get; } =
        {
                "Bruno Macaes:",
                "I am not surprised that virtue signalling has come to dominate our conversations. I am surprised people respond to virtue signalling as anything other than virtue signalling",
                "Agnes Callard:",
                "A lot of us cannot tell when it is happening.",
                "don’t all of us want to believe that we are virtuous?",
                "so we have incentive to self-signal",
                "or a third possibility: what if I want to perceive myself as virtuous?",
                "Bruno Macaes:",
                "Desire to be perceived as virtuous is not virtue signalling.",
                "If a Machiavellian prince pretends to be virtuous that is not VS",
                "VS is the desire to be perceived as wanting to be perceived as virtuous",
                "To draw a parallel: it is not the desire to look like X. It’s the desire to look like a good actor at being X",
                "Agnes Callard:",
                "that's helpful!",
                "now it reminds me of Sartre and the wairee",
                "Bruno Macaes:",
                "I think this goes even deeper.",
                "From what I remember in Sartre the waiter is so divorced from the substance of life he has to act.",
                "But he does not openly celebrate his acting",
                "Agnes Callard:",
                "I see, so it's important that that virtue signaler celebrate her own desire to look like a good actor at being X?",
                "Bruno Macaes:",
                "Of course",
                "The woke way is: I am not virtuous, but I am fully aware and fully competent at acting virtuously.",
                "I am a supremely good actor (in the sense of act out)",
                "Agnes Callard:",
                "so if a woke person sincerely believed she was virtuous, nothing she did could, any longer, count as virtue-signaling?",
                "Bruno Macaes:",
                "Right, unless on a separate area of behavior",
                "Also if she genuinely was pretending to be virtuous (not wanting to be seen as pretending)",
                "Agnes Callard:",
                "Got it, that's really helpful.  In that case I don't think there's so much virtue-signaling going on.",
                "I think people really do believe they are virtuous, and tend to want to be seen as really being virtuous.",
                "(e.g. this seems true of the 'I take responsibility' video)",
                "Bruno Macaes:",
                "No one believes they are virtuous and no one is pretending to be virtuous. They are pretending to pretend",
                "virtue acting is a new ideal, still awaiting its Aristotle",
                "Agnes Callard:",
                "Unsuspicious interpretation might be a competing new ideal, awaiting its Socrates.",
            };

        private static string[] lines2 { get; } =
        {
            "Albert Camus:",
            "Mate.",
            "I still believe - and maybe this view cannot hold - that philosophy is like a slot machine.",
            "You try and try and one day one lucky bastard will hit a jackpot. Progress makes no sense here",
            "Jean-Paul Sartre:",
            "one question I wonder about: suppose it made lots of progress--suppose we hit the jackpot--how would we know it?",
            "Albert Camus:",
            "That’s the reason I say it might not hold.",
            "But I still think a radically new and simultaneously compelling view of the world could  be found - to be followed by a kind of generalized acceptance",
            "We have that in the realm of practical knowledge. The wheel, language, the city, etc. I am thinking the same could happen in the realm of theory.",
            "Obviously has not happened yet, but we have only been trying for 3000 years and often it’s been the wrong kind of people trying",
            "Jean-Paul Sartre:",
            "Wheel, language, city have paved the way for further inventions/discoveries, do you think that is how it would work for theorizing, or we would just be 'done'?",
            "Albert Camus:",
            "I think a framework would have to come all at once.",
            "Could then be filled in.",
            "But yes as opposed to science philosophy is a view of the whole, can’t see adding pieces to make a whole",
            "Jean-Paul Sartre:",
            "Do you think that, after this discovery has been made, human beings will have no cause to think in a universal way about the meaning of human life, the metaphysical structure of the universe, the problems of knowledge, etc.?",
            "Albert Camus:",
            "Possibly no",
            };

        private static string[] lines3 { get; } =
        {
            "Michel Foucault:",
            "Philosophy has made no progress whatsoever",
            "I still believe - and maybe this view cannot hold - that philosophy is like a slot machine.",
            "You try and try and one day one lucky bastard will hit a jackpot. Progress makes no sense here",
            "Martin Heidegger:",
            "one question I wonder about: suppose it made lots of progress--suppose we hit the jackpot--how would we know it?",
            "Michel Foucault:",
            "That’s the reason I say it might not hold.",
            "But I still think a radically new and simultaneously compelling view of the world could  be found - to be followed by a kind of generalized acceptance",
            "We have that in the realm of practical knowledge. The wheel, language, the city, etc. I am thinking the same could happen in the realm of theory.",
            "Obviously has not happened yet, but we have only been trying for 3000 years and often it’s been the wrong kind of people trying",
            "Martin Heidegger:",
            "Wheel, language, city have paved the way for further inventions/discoveries, do you think that is how it would work for theorizing, or we would just be 'done'?",
            "Michel Foucault:",
            "I think a framework would have to come all at once.",
            "Could then be filled in.",
            "But yes as opposed to science philosophy is a view of the whole, can’t see adding pieces to make a whole",
            "Martin Heidegger:",
            "Do you think that, after this discovery has been made, human beings will have no cause to think in a universal way about the meaning of human life, the metaphysical structure of the universe, the problems of knowledge, etc.?",
            "Michel Foucault:",
            "Possibly no",
            };

        private static string[] lines4 { get; } =
        {
            "Camille Paglia:",
            "Philosophy has made no progress whatsoever",
            "I still believe - and maybe this view cannot hold - that philosophy is like a slot machine.",
            "You try and try and one day one lucky bastard will hit a jackpot. Progress makes no sense here",
            "Andy Warhol:",
            "one question I wonder about: suppose it made lots of progress--suppose we hit the jackpot--how would we know it?",
            "Camille Paglia:",
            "That’s the reason I say it might not hold.",
            "But I still think a radically new and simultaneously compelling view of the world could  be found - to be followed by a kind of generalized acceptance",
            "We have that in the realm of practical knowledge. The wheel, language, the city, etc. I am thinking the same could happen in the realm of theory.",
            "Obviously has not happened yet, but we have only been trying for 3000 years and often it’s been the wrong kind of people trying",
            "Andy Warhol:",
            "Wheel, language, city have paved the way for further inventions/discoveries, do you think that is how it would work for theorizing, or we would just be 'done'?",
            "Camille Paglia:",
            "I think a framework would have to come all at once.",
            "Could then be filled in.",
            "But yes as opposed to science philosophy is a view of the whole, can’t see adding pieces to make a whole",
            "Andy Warhol:",
            "Do you think that, after this discovery has been made, human beings will have no cause to think in a universal way about the meaning of human life, the metaphysical structure of the universe, the problems of knowledge, etc.?",
            "Camille Paglia:",
            "Possibly no",
            };

        private static string[] lines5 { get; } =
        {
            "Adrienne Rich:",
            "Philosophy has made no progress whatsoever",
            "I still believe - and maybe this view cannot hold - that philosophy is like a slot machine.",
            "You try and try and one day one lucky bastard will hit a jackpot. Progress makes no sense here",
            "Angela Davis:",
            "one question I wonder about: suppose it made lots of progress--suppose we hit the jackpot--how would we know it?",
            "Angela Davis:",
            "That’s the reason I say it might not hold.",
            "But I still think a radically new and simultaneously compelling view of the world could  be found - to be followed by a kind of generalized acceptance",
            "We have that in the realm of practical knowledge. The wheel, language, the city, etc. I am thinking the same could happen in the realm of theory.",
            "Obviously has not happened yet, but we have only been trying for 3000 years and often it’s been the wrong kind of people trying",
            "Angela Davis:",
            "Wheel, language, city have paved the way for further inventions/discoveries, do you think that is how it would work for theorizing, or we would just be 'done'?",
            "Adrienne Rich:",
            "I think a framework would have to come all at once.",
            "Could then be filled in.",
            "But yes as opposed to science philosophy is a view of the whole, can’t see adding pieces to make a whole",
            "Angela Davis:",
            "Do you think that, after this discovery has been made, human beings will have no cause to think in a universal way about the meaning of human life, the metaphysical structure of the universe, the problems of knowledge, etc.?",
            "Adrienne Rich:",
            "Possibly no",
            };

        private static string[] feed0 { get; } = {
            "Bruno Macaes:",
            "Philosophy has made no progress whatsoever",
            "I still believe - and maybe this view cannot hold - that philosophy is like a slot machine.",
            "You try and try and one day one lucky bastard will hit a jackpot. Progress makes no sense here",
            "Agnes Callard:",
            "one question I wonder about: suppose it made lots of progress--suppose we hit the jackpot--how would we know it?", };

        private static string[] feed1 { get; } = {
            "Bruno Macaes:",
            "I am not surprised that virtue signalling has come to dominate our conversations. I am surprised people respond to virtue signalling as anything other than virtue signalling",
            "Agnes Callard:",
            "a lot of us cannot tell when it is happening",
            "don’t all of us want to believe that we are virtuous?"
        };

        private static string[] feed2 { get; } = {
            "Albert Camus:",
            "Mate.",
            "I still believe - and maybe this view cannot hold - that philosophy is like a slot machine.",
            "You try and try and one day one lucky bastard will hit a jackpot. Progress makes no sense here",
            "Jean-Paul Sartre:",
            "one question I wonder about: suppose it made lots of progress--suppose we hit the jackpot--how would we know it?", };

        private static string[] feed3 { get; } = {
            "Michel Foucault:",
            "I want to continue",
            "I still believe - and maybe this view cannot hold - that philosophy is like a slot machine.",
            "You try and try and one day one lucky bastard will hit a jackpot. Progress makes no sense here",
            "Martin Heidegger:",
            "There is no being or time", };

        private static string[] feed4 { get; } = {
            "Camille Paglia:",
            "Philosophy has made no progress whatsoever",
            "I still believe - and maybe this view cannot hold - that philosophy is like a slot machine.",
            "You try and try and one day one lucky bastard will hit a jackpot. Progress makes no sense here",
            "Andy Warhol:",
            "one question I wonder about: suppose it made lots of progress--suppose we hit the jackpot--how would we know it?", };

        private static string[] feed5 { get; } = {
            "Adrienne Rich:",
            "Philosophy has made no progress whatsoever",
            "I still believe - and maybe this view cannot hold - that philosophy is like a slot machine.",
            "You try and try and one day one lucky bastard will hit a jackpot. Progress makes no sense here",
            "Angela Davis:",
            "one question I wonder about: suppose it made lots of progress--suppose we hit the jackpot--how would we know it?", };

        private static string title0 { get; } =
            "What is progress in philosophy?";

        private static string title1 { get; } =
            "Defining virtue signalling";

        private static string title2 { get; } =
            "a different coffehouse vibe";

        private static string title3 { get; } =
            "Language mate. Chomsky debate. ";

        private static string title4 { get; } =
            "Why has architecture become so shit?";

        private static string title5 { get; } =
            "What is black radicalism?";

        private static string poster0{ get; } =
            "Bruno Macaes";

        private static string poster1 { get; } =
            "Bruno Macaes";

        private static string poster2 { get; } =
            "Albert Camus";

        private static string poster3 { get; } =
            "Michel Foucault";

        private static string poster4 { get; } =
            "Camille Paglia";

        private static string poster5 { get; } =
            "Adrienne Rich";

        private static string tags0 { get; } =
            "philosophy";

        private static string tags1 { get; } =
            "philosophy";

        private static string tags2 { get; } =
            "existensialism";

        private static string tags3 { get; } =
            "postmodernism";

        private static string tags4 { get; } =
            "aesthetics";

        private static string tags5 { get; } =
            "revolution";

        private static int[] replies0 { get; } = {
            
        };

        private static int[] replies1 { get; } = {
            
        };

        private static int[] replies2 { get; } = {

        };

        private static int[] replies3 { get; } = {
        };

        private static int[] replies4 { get; } = {
        };

        private static int[] replies5 { get; } = {

        };

            //string[] lines, string title, string poster, string[] preview

        static LoadGenericTagConvos()
        {
            ConvoList.Add(new PublicConvo(lines0, title0, poster0, tags0, feed0, LoadComments.CommentsList[0], replies0));
            ConvoList.Add(new PublicConvo(lines1, title1, poster1, tags1, feed1, LoadComments.CommentsList[1], replies1));
            ConvoList.Add(new PublicConvo(lines2, title2, poster2, tags2, feed2, LoadComments.CommentsList[2], replies2));
            ConvoList.Add(new PublicConvo(lines3, title3, poster3, tags3, feed3, LoadComments.CommentsList[3], replies3));
            ConvoList.Add(new PublicConvo(lines4, title4, poster4, tags4, feed4, LoadComments.CommentsList[4], replies4));
            ConvoList.Add(new PublicConvo(lines5, title5, poster5, tags5, feed5, LoadComments.CommentsList[5], replies5));
        }

        public static PublicConvo GetOm(List<User> users)
        {
            foreach (var convo in ConvoList)
            {
                if (convo.HasSameUsers(users))
                {
                    return convo;
                    Console.WriteLine("found matching conversation ");
                }
            }
            return null;
        }

        public static PublicConvo GetTagConvo(List<Hashtag> tags)
        {
            foreach (var convo in ConvoList)
            {
                if (convo.HasSameTags(tags))
                {
                    return convo;
                    Console.WriteLine("found matching hashtag");
                }
            }
            return null;
        }

    }
}
