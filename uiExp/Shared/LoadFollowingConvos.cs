using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace uiExp.Shared
{
    public class LoadFollowingConvos
    {
        public static List<PublicConvo> ConvoList = new List<PublicConvo>();

        private static string[] lines0 { get; } =
            {
                "Shadi Hamid:",
                "It is difficult to imagine liberalism without liberals.",
                "democracy is different.",
                "democracy, in its minimalist form, is concerned with process rather than outcomes, few people are naturally democrats.",
                "Mohammad Fadel:",
                "Even the thinnest conception of democracy cannot be purely procedural because the definition of the people who is to be 'represented' and who is to have a 'voice' is a moral decision that will be controversial.",
                "Shadi Hamid:",
                "I don't think it's that big of an issue, at least not now (it was in the 19th and early 20th centuries)",
                "For example, in no  democracy, however illiberal, is there any serious move to take the vote away from entire ethnic groups, etc. Universal suffrage is uncontested",
                "By definition, if you're a citizen in an illiberal democracy (say Israel or India), they can treat you as a second class citizen, but it's impossible (or at least unprecedented until now) to deny your right to vote",
                "Mohammad Fadel:",
                "Felons?",
                "If the moral case for democracy is that human equality requires that human consent to the laws that govern them, there is no moral case for limiting voting in the US to its citizens, given the impact US laws and policies have on the rest of the world.",
                "Shadi Hamid:",
                "No, the moral case for democracy is that equality between citizens requires that citizens consent to the laws that govern them. ",
                "No political scientist, to my knowledge, argues that the vote must be extended to non-citizens abroad for a polity to be considered a democracy",
                "With power",
                "Mohammad Fadel:",
                "You're just restating the problem.",
                "And that's okay! It's the problem of democratic founding, one of the most fundamental paradoxes of democracy we know about. ",
                "But there's this huge gaping hole in your logic",
                "Shadi Hamid:",
                "Well, I don't think it's a problem.",
                "The paradox isn't much of one today, and like I said political scientists don't generally consider non-citizens abroad not being able to vote a relevant problem. ",
                "And none of the empirical measures do: Polity, VDem, Freedom House",
                "Mohammad Fadel:",
                "How can agreement made 200 years ago possibly bind people who didn’t participate in negotiating it, much less consent to it?",
                "An agreement only binds the parties UNLESS it reflects some deeper principle or principles that we cannot deny.",
                "Shadi Hamid:",
                "Well, I didn't say anything about an agreement made 200 years ago (although that's an interesting debate). ",
                "I'm talking about the law and constitution as it currently stands. And, yes, I do consider them to be binding since they do reflect deeper principles that we can't deny",
            };

        private static string[] lines1 { get; } =
        {
                "Damir Marusic:",
                "The democratic founding is only a paradox if you take “the people” seriously. Machiavelli resolved these paradoxes a long time ago.",
                "Jeffrey Sachs:",
                "I'm not sure what you mean by the paradox being solved by Machiavelli.",
                "Democratic theorists, from Schmitt to Sunstein to Habermas, have been grappling with it since Rousseau.",
                "Maybe we can solve it by jettisoning the concept of a demos, but then I'm not sure how you get democracy.",
                "Damir Marusic:",
                "Machiavelli (and Schmitt thereafter) were pretty clear that an individual (or set of individuals) founds the state, and the people then participate in its rituals.",
                "Schmitt’s most dangerous work is pointing out the holes in taking democracy and the “demos” literally.",
                "Jeffrey Sachs:",
                "It's true we can solve the paradox of democratic legitimacy by relaxing the legitimacy principle and then, (to borrow from John Ford) 'print the legend'.",
                "But it's not that simple. As Mohammad points out, this sort of myth-making isn't a one-off thing we only do during foundings.",
                "We do it when we strip felons of their right to vote, or bar resident aliens from running for office.",
                "We do it when we raise or lower the age of democratic participation.",
                "We do it when courts rule on whether Guantanamo is inside or outside the law. It's always a founding moment.",
                "Damir Marusic:",
                "It’s true that the myth is constantly being pushed to be made more “real”. One can tell a history of anglo-flavored democracy on that narrative (Morgan).",
                "But that’s what’s interesting to me about Shadi’s recent writing is the suggestion that maybe it needn’t go that way.",
                "Jeffrey Sachs:",
                "I think we’re just engaging in very different projects. You’re not especially interested in what makes a government legitimate. ",
                "Damir Marusic:",
                "I’m personally very interested in legitimacy! I just don’t immediately buy claims that stick the adjective “democratic” in front of “legitimacy” and call it a day. I think you guys are looking through the telescope the wrong way.",
        };

        private static string[] lines2 { get; } =
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

        private static string[] lines3 { get; } =
        {
                "James Baldwin:",
                "In France, I was a very tight, tense, lean, abnormally ambitious, abnormally intelligent, and hungry black cat",
                "WJ Weatherby:",
                "what made you decide to come back?",
                "James Baldwin:",
                "I haven’t come back for good.",
                "I’ll probably spend six months a year here and six months in Europe. After a time in New York, I just have to get away.",
                "I feel it sitting on me”",
                "WJ Weatherby:",
                "But you came back to it?",
                "James Baldwin:",
                "At first I didn’t intend to. In New York the colour of my skin stood between myself and me, but in Europe that barrier was down.",
                "But I found I had been both released from an affliction and divested of a crutch.",
                "discovered the question of who I was was not answered because I had removed myself from the social forces which threatened me because these forces had become interior and I took them with me",
                "the question of who I was was at just a personal one, and I could only find the answer in me.",
                "WJ Weatherby:",
                "But you thought Europe a more sympathetic place in which to look for it?",
                "James Baldwin:",
                "Without my crutch, I think I felt frightened and that was one reason why I dawdled in my European haven for so long.",
                "Yet I knew also that I should have matured beyond the need for havens, the need for illusions.",
                "I believe that the unexamined life is not worth living, and the writer certainly cannot afford any self-delusion for his subject is himself and the world he is in. ",
                "So in quitting America, I began to see it as an attempt at self-delusion, a fear of looking any deeper into myself.",
                "I had told myself I was going to be free – free even of colour – and I was going to be as good a writer as I could be. God and Satan and Mississippi notwithstanding.",
                "WJ Weatherby",
                "Is colour prejudice another form of self-delusion, to save asking oneself these questions?",
                "James Baldwin:",
                "That's it",
                "The question of colour hides the graver questions of the self and that’s why the whole thing is so hard to overcome and why It’s so dangerous for our society.",
                "I left America because I thought that if I survived at all I would drown as a writer in bitterness.",
                "I wanted to be a writer, not a Negro writer.",
                "I wanted to discover how my experience connected me with other people and not how it divided me from them.",
                "And I discovered in Europe that I was as American as a Texan or even more if that’s possible.",
                "All the Americans I met in Paris had this in common. It did not matter that the origins of white Americans were European and mine were African.",
                "They were no more at home in Europe than I was.",
                "Once I could accept that we had this in common – and it took me a long time – I was released from the self-delusion that I hated America, and it was time to go back.",
                "I had made my first breakthrough and won my first battle with myself.",
                "WJ Weatherby:",
                "That’s what I told you – it’s love that has brought you back",
                "James Baldwin:",
                "No, there is a lot of hate left, too.",
                "One writes out of one thing only – one’s own experience.",
                "Everything depends on how relentlessly one forces from this experience the last drop of blood.",
                "The only concern of the artist is to create out of the disorder of life the order of art.",
                "My problem as a Negro was that I was prevented from examining my own experience too closely by the killing demands and dangers of my social situation.",
                "The first discovery is that you are a bastard of the West, that your past takes you not to Europe but to Africa.",
                "This is not my heritage and yet there is no other I can hope to use. I have to appropriate these white centuries and my discovery that after all I am an American – my European discovery – has helped.",
            };

        private static string[] lines4 { get; } =
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
     
        private static string[] feed0 { get; } = {
            "Shadi Hamid:",
            "It is difficult to imagine liberalism without liberals.",
            "democracy is different.",
            "democracy, in its minimalist form, is concerned with process rather than outcomes, few people are naturally democrats.",
            "Mohammad Fadel:",
            "Even the thinnest conception of democracy cannot be purely procedural because the definition of the people who is to be 'represented' and who is to have a 'voice' is a moral decision that will be controversial.", };
        private static string[] feed1 { get; } = {
            "Damir Marusic:",
            "The democratic founding is only a paradox if you take “the people” seriously. Machiavelli resolved these paradoxes a long time ago.",
            "Jeffrey Sachs:",
            "I'm not sure what you mean by the paradox being solved by Machiavelli.",
        };
        private static string[] feed2 { get; } = {
            "Bruno Macaes:",
            "Philosophy has made no progress whatsoever",
            "I still believe - and maybe this view cannot hold - that philosophy is like a slot machine.",
            "You try and try and one day one lucky bastard will hit a jackpot. Progress makes no sense here",
            "Agnes Callard:",
            "one question I wonder about: suppose it made lots of progress--suppose we hit the jackpot--how would we know it?", };
        private static string[] feed3 { get; } = {
            "James Baldwin:",
            "In France, I was a very tight, tense, lean, abnormally ambitious, abnormally intelligent, and hungry black cat",
            "WJ Weatherby:",
            "what made you decide to come back?", };
        private static string[] feed4 { get; } = {
            "Bruno Macaes:",
            "I am not surprised that virtue signalling has come to dominate our conversations. I am surprised people respond to virtue signalling as anything other than virtue signalling",
            "Agnes Callard:",
            "a lot of us cannot tell when it is happening",
            "don’t all of us want to believe that we are virtuous?", };


        private static string title0 { get; } =
            "Is minimalist democracy a thing?";

        private static string title1 { get; } =
            "Re. minimalist democracy";

        private static string title2 { get; } =
            "What is progress in philosophy?";

        private static string title3 { get; } =
            "Americans in Paris";
        
        private static string title4 { get; } =
            "Defining virtue signalling";

        private static string poster0 { get; } =
            "Shadi Hamid";

        private static string poster1 { get; } =
            "Damir Marusic";

        private static string poster2 { get; } =
            "Bruno Macaes";

        private static string poster3 { get; } =
            "James Baldwin";

        private static string poster4 { get; } =
            "Bruno Macaes";

        private static int[] replies0 { get; } = {
            2,5
        };

        private static int[] replies1 { get; } = {
            3,4,6
        };

        private static int[] replies2 { get; } = {
            1
        };

        private static int[] replies3 { get; } = {
        };

        private static int[] replies4 { get; } = {

        };
      
        //string[] lines, string title, string poster, string[] preview

        static LoadFollowingConvos()
        {
            ConvoList.Add(new PublicConvo(lines0, title0, poster0, feed0, LoadComments.CommentsList[0], replies0));
            ConvoList.Add(new PublicConvo(lines1, title1, poster1, feed1, LoadComments.CommentsList[1], replies1));
            ConvoList.Add(new PublicConvo(lines2, title2, poster2, feed2, LoadComments.CommentsList[2], replies2));
            ConvoList.Add(new PublicConvo(lines3, title3, poster3, feed3, LoadComments.CommentsList[3], replies3));
            ConvoList.Add(new PublicConvo(lines4, title4, poster4, feed4, LoadComments.CommentsList[4], replies3));
        }
    }
}
