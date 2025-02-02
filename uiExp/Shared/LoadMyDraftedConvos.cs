﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace uiExp.Shared
{
    public class LoadMyDraftedConvos
    {
      public static List<DraftedMessage> InboxList = new List<DraftedMessage>();

        private static string[] lines0 { get; } =
            {
                "Sahil Handa:",
                "Fukuyama: “There are many people in contemporary democratic societies, particularly among the young, who are not content to merely congratulate themselves on their broadmindedness, but who would like to ‘live within a horizon.’” For these people, the search for meaning and the struggle for recognition are ultimate goods, and if these goods can no longer be provided by religion—at least for Christians because Christianity has lost its resonance—then something else must fill the vacuum.",
                "Jake Sylvestre:",
                "Doesn’t a world without meritocratic pressure imply an end to progress?",
                "Does the meritocratic system exist only in a world of growth where g>r? In my mind the reason for a meritocracy is a world where capital from labor is greater than that from accrual in capital (knowledge economies)",
                "Ah - the argument for secular humanism",
                "But capitalism is a kind of religion",
                "And an effective one at that",
                "Soroush Ghodsi:",
                "I think I see the issue as much more fundemental",
                "We have no new ideas, modernism is failing",
                "Sahil Handa:",
                "Surely a cultural change (less preference falsification, more genuine exchange,) coupled by a reduced need to go into finance/consulting/law would result in enhanced innovation",
                "Soroush Ghodsi:",
                "The west keeps winning the turf war and the war of economics but not the war of ideas",
                "Sahil Handa:",
                "China knows it can take advantage of the fact that most American elites are caught up in a game of pretense and twitter reality",
                "Soroush Ghodsi:",
                "Japan modernised because it saw a future in modern western alliance",
                "the middle east with trillions of dollars isn’t scared of modernisation",
                "it’s scared of westernization",
                "Jake Sylvestre:",
                "Japan modernized because Matthew Perry showed up with a steel dragon",
                "Soroush Ghodsi:",
                "That only works when you also win the war of ideas",
                "Lemme know how all the US coups worked in LATAM and MENA where the west was hated",
                "something machiavelli something fickle rulers somthing",
                "Sahil Handa:",
                "I think I see more potential for the idea of democracy if only we could get out from under our asses",
                "Jake Sylvestre:",
                "It’s funny - china’s almost not threatening enough",
                "Sahil Handa:",
                "Because nobody wants to go and live there yet?",
                "Jake Sylvestre:",
                "Peoples always fight with each other until there’s a common enemy, if china was more antagonistic you’d probably have a lot better cooperation among western nations",
                "Sahil Handa:",
                "Agreed",
                "Soroush Ghodsi:",
                "No, because before they can nuke us they are culturally resigned into turning into us",
                "they are already becoming obese, jean wearing nihilists",
                "I see no chinese reformation that is authentically chinese",
                "Until that exsists the reformers will have no support",
                "I think the same is true with Iran, Saudi Arabia, Turkey, etc",
                "Jake Sylvestre:",
                "yeah, but in that case you’d expect much strong advocacy in the direction of liberal democracy",
                "Soroush Ghodsi:",
                "Their totalitarian govt’s are bad but they’d take that over what they see American culture to be.",
                "Jake Sylvestre:",
                "weak?",
                "Indecisive?",
                "Soroush Ghodsi:",
                "weak and decedant",
                "culture-less",
            };

        private static string[] lines1 { get; } =
            {
               "Sahil Handa:",
                "Thoughts on the Obama book?",
                "Jake Sylvestre:",
                "It’s fantastic - he’s incredibly pragmatic about where he thought he could actually move the needle and where he was passing things for political optics.",
                "One thing I’m surprised about is his disdain for Palin. I’m almost done and he hasn’t spoken as badly about anyone else (including Putin, Trump, etc). He attributes the rise of Trumpism to her which I think is a bit of an exaggeration",
                "Maybe I’m unaware of how heavy the tea party’s influence was. But to me it doesn’t seem like that’s attributable to her. Like yeah- McCain could’ve picked a better running mate and Palin never had a clue what she was talking about but it’s amazing how much of the path dependence he puts on her",
                "What’d you think of Lepore’s book?",
                "Sahil Handa:",
                "Super interesting re. Palin. I’ve heard those grumbles from a few quarters, and if anything it tells me that the Republicans knew about the ‘trumpist’ strain in their party way back when. A figure like that can be a catalyst, but the structural factors made people ripe for personalities like hers and Trump’s",
                "Lepore’ book was gripping - I absolutely loved it. She’s a wonderful storyteller, and also happens to make a great narrator! Only reason I didn’t give it 5 stars was that she left out all the positive social science research in the sixties, and kept referring to ‘models’ without explaining any of them (felt a bit like a black box at times.) But the stories and interweaving is a model for any work of modern history. I also loved the epilogue, despite its simplifications and slants",
                "Jake Sylvestre:",
                "totally get it. She really didn’t explain what a “simulation” was- it almost felt like she substituted in the fact that every American’s seen the social dilemma for an explanation 😂.  That being said, your completely right she’s a fantastic story teller",
                "That style - interweaving anecdotes just makes for much better stories imo. I was trying to articulate this to someone about Cullen’s book on Columbine and said on clubhouse “it’s written like all the presidents men”. Horrible phrasing on my part, but you get the idea 😂",
                "Caro-esque, maybe?",
                "Sahil Handa:",
                "Exactly, you could see the same assumptions being made in the prologue - ‘let’s make clear this is super relevant without actually doing the work of drawing out the connections between the algorithms being used.’",
                "But absolutely, there’s something about the style. It’s what I’m going to strive for in every chapter of the book. Different characters weaved in, and a few leading the way. The other book I thought did this fantastically was Packer’s Our Man -- loved that so much",
                "Caro does it too, but Caro is also his own style",
                "Jake Sylvestre:",
                "Oh - that’s on my list. Heard great things about Packer’s book",
                "There’s probably an interesting history of the rand corporation yet to be written. I’ve read crazy stuff about their influence in the random game theory/realpolitik/political philosophies I’ve read. Probably a fantastic story there",
                "Hell, they might even pay you not to publish the book 😂",
                "Sahil Handa:",
                "I mean, Fukuyama was hanging around there when he wrote the original article: you know something was up",
                "I’d love to dig into it.",
                "Jake Sylvestre:",
                "Yeah - I did a tiny bit of reading after Lepore’s book. They’ve definitely moved more toward domestic issues after Vietnam but as far as thinktanks go they’re relatively impressive. ~200k in revenue per employee from various government contracts",
                "Sahil Handa:",
                "History of thinktanks as a concept is interesting, too. It was just crazy to see how involved the state were with research during the fifties and sixties — you see the stats, but the stories are just incredible. The Manhattan project — for good or ill — is just not happening today, nor anything like it",
                "And that sets up where’s my flying car perfectly...",
                "Also I just reread your message — 200k is high from the state!",
                "Jake Sylvestre:",
                "the other thing that’s interesting is the staying power. It's incredible how relevant they've been for so long",
                "Sahil Handa:",
                "What’s their origin story I wonder?",
                "Jake Sylvestre:",
                "it was a one-off project granted to an aircraft corporation to research operations. Expanded into a permanent nonprofit after there was a conflict of interest",
                "Lol yeah- this should totally be a book",
                "Sahil Handa:",
                "Jeeeeeez",
                "Jake Sylvestre:",
                "you couldn’t ask for a better character list. You’ve got a bunch of presidents, Fukuyama, McNamara",
                "Sahil Handa:",
                "That is just",
                "Wow",
                "I could always write my thesis on Rand and start there ",
                "That communications technology paper I sent you ages ago was the backdrop for my thesis but I was still drilling down on topic",
                "Jake Sylvestre:",
                "Holy shit",
                "John Neumann and John Nash",
                "Sahil Handa:",
                "Oh my word",
                "Fucking Dreyfus",
                "Bloody hell",
                "Kenneth Arrow",
                "Jake Sylvestre:",
                "Literally right next to each other ",
                "Sahil Handa:",
                "Insane",
                "Jake Sylvestre:",
                "This looks like the original Mckinsey",
                "Sahil Handa:",
                "True",
                "It’s just taken on a counter cultural aesthetic",
                "Because being that kind of og liberal is now the counterculture",
                "I also don’t think I’ve ever seen McKinsey’s list",
                "Jake Sylvestre:",
                "some French Revolution guy (Rousseau?) said it best. To be born a liberal, live to become a moderate and die a conservative without ever changing your views",
                "Mckinsey has a bunch of senators, but what stands out the most is the number of CEO’s",
                "Mckinsey feeds executive search firms the way Goldman Sachs feeds treasury appointments",
                "Sahil Handa:",
                "'If we do not find a way to take the narrow and moderate path, then we may find out that stagnation and decadence were all that kept immoderate men from stumbling into the apocalypse.'",
                "'their desire to provide a philosophical basis for that moderate liberalism, which is the usual ideological weapon used by oligarchies to combat personal power.'",
                "'In despotic countries one is so unhappy that one fears death more than one cherishes life; therefore, punishments should be more severe there. In moderate states one fears the loss of life more than one dreads death as such; punishments that simply suppress life are sufficient there.'",
                "One is Montisqueue, one is Thiel, one is Levi-Strauss ",
                "Jake Sylvestre:",
                "If I had to guess top is thiel (decadent society reference is too contemporary), second is Strauss (political philosiphy is a newer concept, maybe), last is montesquieu",
                "I really have no idea, I’m just going based off language 😂",
                "Sahil Handa:",
                "So you were right, but the second is Levi-Strauss, not Strauss 😂",
                "Did you see the Blinken appt?",
                "I just found out and I’m impressed",
                "Jake Sylvestre:",
                "Oh v interesting",
                "Sahil Handa:",
                "https://open.spotify.com/artist/5ZWgy4Riyzr0QtvcIKiZmF?si=iEUOB4SWR6KMdhGd3aQEUQ",
                "Jake Sylvestre:",
                "Lol",
                "this is not a case of it, but this is definitely going to become a thing. Counter-signaling as signaling (since we now have dj d-sol at Goldman and Blinken)",
                "There’ll be investment banking associates and junior staffers taking doing classes and voice lessons as a means of career advancement 😂",
                "It kind of reminds me of the Jungle when Sinclair is talking about how the people that are actually homeless can’t get donations because the people faking it make the homeless look like the fakers. It’ll be a professionalization of authenticity",
                "Sahil Handa:",
                "O God yes it is 100% already a thing - and people are going to be doing it twenty years in advance, too....",
                "Cue all the Harvard kids with presidential campaign websites for 2034",
                "*that might not be an election year...",
                "Professionalization of authenticity is a fantastic phrase. You know who it makes me think of?",
                "....Mr Barack Hussein Obama...",
                "(And I emphasize Hussein as a compliment)",
                "https://youtu.be/jpWQC3nSsSo?t=560",
                "(This timestamp will make the point...)",
                "Along with this fantastic article-",
                "https://www.nysun.com/arts/obama-bests-clinton-at-craft-of-writing/72169/",
                "I tried my hand at a piece along these lines - it’s a little chaotic and not my best, but you might find worthwhile nuggets inside",
                "Jake Sylvestre:",
                "Interesting point, re: Obama on authenticity. He’s conscious of his need to appear authentic and very transparent about it in his memoirs",
                "Really reminds me of the first chapter of your book",
                "Sahil Handa:",
                "Reading it back -- it’s been four months or so -- the paragraph actually sounds surprisingly good",
                "(I never published this piece as I thought it was a shitshow)",
                "I knew what I was trying to say, but couldn’t quite get there",
                "Jake Sylvestre:",
                "I love the meta commentary of this ",
                "Right after the Arendt quote-",
                "I think the other reason liberals might seem disingenuous is that they don’t believe some of what they’re saying",
                "(And to be fair they can’t. If you take a lot of woke ideology to it’s logical end its pretty horrible.) But the disingenuousness is an emergent property of Clinton doing a photo-op with AOC and then calling Kissinger to talk realpolitik",
                "Have you seen the politician on Netflix? I actually think they do a pretty good job at depicting a candidate struggling with trying to appear authentic and simultaneously questioning his own motives for doing so",
                "Sahil Handa:",
                "Haven’t seen it but now intrigued to do so",
                "Speaking of which, did you see Kamala Harris fist bump Lindsey Graham on the floor the other night?",
                "Jake Sylvestre:",
                "Lol that’s awesome",
            };
        private static string[] lines2 { get; } =
            {
                "Sahil Handa:",
                "https://medium.com/palantir/code-review-best-practices-19e02780015f",
                "Not to plug Palantir but this is actually p interesting",
                "David Grant:",
                "skimming, seems about right",
                "we’re not to review-before-commit reviews quite yet but we will be",
                "we’ll also inevitably develop our own culture around reviews",
                "Sahil Handa:",
                "Yep 100%",
                "David Grant:",
                "but the only place we can start is referencing other people anyway haha",
                "Sahil Handa:",
                "Develop our own culture around everything tbh",
                "David Grant:",
                "and Palantir does ship quality software",
                "Ofc",
                "Sahil Handa:",
                "Yeah hahahaha",
                "Can’t argue w that",
                "I’m consistently amazed at how impressive their employees are",
                "Technically, ofc",
                "I think Thiel really has a magnetic power for a lot of people who want flashy jobs but don’t wanna be ‘boring’ or ‘corporate’",
                "Even though he’s barely there now",
                "So many people in Romania have asked me about Palantir stock",
                "It’s insane",
                "David Grant:",
                "in our current stage where we’re literally just building the thing I think code reviews on a timed basis (weekly, twice weekly whatever) are gonna serve us well but in the future I think the ability to just”commit and move on” for somewhat trivial changes is fine",
                "really? lol",
                "re: romania",
                "Sahil Handa:",
                "Yeah haha",
                "They were asking me to find insider info",
                "About the co.’s prospects",
                "David Grant:",
                "I think Thiel is basically the only flashy thing for that company to wave at people who would otherwise be interviewing for what is effective an enterprise software developement gig lol",
                "Sahil Handa:",
                "10000%",
                "David Grant:",
                "nothing wrong with those (imo) but it is not Snapchat lmao",
                "Sahil Handa:",
                "Yeah hahaha",
                "You ain’t working w nudes or funky glasses",
                "David Grant:",
                "but frankly Snapchat is the other side of the spectrum I would probably have a hard time clocking into every day",
                "https://news.ycombinator.com/item?id=14674987",
                "this thread epitomizes...so many things",
                "first and second top comment are just",
                "perfect lmao",
                "shit really doesn’t change",
                "Sahil Handa:",
                "This doesn't sound like the makings of a great respectable tech giant, though. This sounds more like one of those companies built specifically to exploit inefficiencies in government spending.",
                "David Grant:",
                "I loled",
                "The whole premise of Java and Swing being “outdated” in 2017 or even 2020 is absolutely hilarious",
                "Sahil Handa:",
                "“I moved from a sexy NodeJS stack at my last job to a staid Java 7 stack at my current job (we can't move to Java 8 until App Engine supports it).",
                "The code at my current job is much better written, is more thoroughly tested, and is more pleasant to continue development on.",
                "David Grant:",
                "lmfao exactly",
                "silicon valley esque programmers and their flavors of the month...",
                "proudly on team Boring Software Stack",
                "Sahil Handa:",
                "Maybe it’s bc I’m new to code but this is strange to me because it’s like people saying fuck you latin learners come get on the mandarin train",
                "But like",
                "Latin",
                "Is the key to understanding",
                "And also",
                "David Grant:",
                "I think one of the top reviews on Rust’s website is something like “Rust is the most boring language I’ve ever used, and I use that as an extremely high compliment”",
                "Sahil Handa:",
                "If you go to China",
                "Tryna speak Mandarin",
                "Good luck",
                "Same with Arabic in the Middle East",
                "DIALECTS",
                "David Grant:",
                "I think the “language” analogy falls apart a bit when you think about “trendy” programming languages / frameworks",
                "Sahil Handa:",
                "It’s more like (Internet slang?)",
                "Or",
                "Emojis",
                "David Grant:",
                "Because really you’re talking about frameworks, which usually are only written in one language",
                "Like unity is written in C#, but nobody associates Unity with boring enterprise applications",
                "Sahil Handa:",
                "Ah yes",
                "David Grant:",
                "It’s really .NET",
                "same with React and whatever flavor of the month",
                "Sahil Handa:",
                "So why is it trendy?",
                "David Grant:",
                "it just ~ happens ~ that they’re all using JS",
                "Which makes sense, because it’s what’s available",
                "Sahil Handa:",
                "Is it just...branding?",
                "David Grant:",
                "eh yeah to a degree",
                "and also because many programmers are Programmers^TM",
                "or at least think in that way",
                "(even if they’re not that good)",
                "It’s like how there are a lot of musicians whose audience is basically only other musicians",
                "Sahil Handa:",
                "Ahhh yes",
                "The writer’s writer",
                "David Grant:",
                "Yep",
                "exists in every “industry” I think",
                "“craft” maybe",
                "but you know what I mean",
                "Sahil Handa:",
                "yep",
                "In Norman Podhorentz’s “Making It,” he writes about how they took pride in how few readers they had if the readers were the right readers",
                "High readership was a bad metric",
                "Whereas at Persuasion you check the numbers",
                "David Grant:",
                "There’s give and take with programming, I think",
                "Like I actually think the new hotness phenomenon is ultimately a good thing for development",
                "I’m not convinced Blazor would exist if React et. al. hadn’t gotten everybody obsessed with single page apps etc.",
                "Maybe it would, idk",
                "But the obsession with “new new new” does reap some benefits, eventually",
                "The elitism is just a bit obnoxious lol",
                "https://www.joelonsoftware.com/2006/08/01/can-your-programming-language-do-this/",
                "This was written in like 2006",
                "now both Java and C# support lambdas",
                "Actually, just looked it up -- they introduced anonymous functions literally the same year lol",
                "(Microsoft did, in C# 2.0)",
                "point is that I *think* historically the bigger tech companies have lagged behind the new hotness ~ slightly ~ but when they finally have their implementation out, it’s super robust, stable, and you don’t have to worry about someone deciding not to maintain it anymore",
            };

        private static string[] lines3 { get; } =
            {
                "Sahil Handa:",
                "Sahil Lav just deprecated location-based pay",
                "Gumroad will pay the same salary for workers in San Fran, Bangalore, Lagos, or anywhere else.",
                "Good lad",
                "David Grant:",
                "There’s a lot of implicits in there that could make it a very good or a very bad idea for other companies",
                "I think I’m generally pro-this move",
                "I think...",
                "I also didn’t realize they were fully remote",
                "or “fully distributed” as Automattic has put it historically",
                "Eli Burnes:",
                "That’s fascinating",
                "Tbh I don’t know if that’s the proper thing to do",
                "One price theory is false",
                "Cost of living is highly variable between locations",
                "So this might incentivize people to move to Lagos",
                "David Grant:",
                "That was my thought @Eli but I feel like if they’re aligning to the most expensive region(s) it could be ok ~for now~",
                "Eli Burnes:",
                "I guess that’s kind of the point haha",
                "David Grant:",
                "Frankly it doesn’t make a lot of sense to me from a pure economic, balance sheet POV but I’m fully OK with that",
                "Sahil Handa:",
                "Yeah but is incentivizing people to move to Lagos a bad thing?",
                "David Grant:",
                "I guess you turn salary into closer of a purely fixed cost rather than a highly variable one?",
                "Sahil Handa:",
                "I think it’s a very good thing",
                "Eli Burnes:",
                "Yeah me too",
                "Spread the wealth!",
                "Sahil Handa:",
                "Create more clusters of talent",
                "David Grant:",
                "I’m on board so long as anyone in NYC or the valley can still afford their rent if they’re tied there for other reasons",
                "Eli Burnes:",
                "(In general) locales need to have jobs that involve manipulating information if they want to be prosperous",
                "David Grant:",
                "which seems to be the case",
                "Sahil Handa:",
                "Incentivize people to stay, too (rather than leave for NYC/SF)",
                "Eli Burnes:",
                "Yeah I mean hopefully rents go down in those areas",
                "Sahil Handa:",
                "Yep 1000% it can’t be an excuse to cut",
                "But Sahil Lav has been so outspoken on SF housing I’d be surprised if he did that",
                "David Grant:",
                "yeah no I think in this case it’s a really good move",
                "Sahil Handa:",
                "I mean, the dude wanted to run in Oregon on a direct democracy ticket",
                "He still might",
                "Proper populist",
                "David Grant:",
                "dude in India should get the same raw compensation as the dude in SF",
                "if they’re doing the same work",
                "Sahil Handa:",
                "Yep. Only thing is how this plays in with India regional economics",
                "David Grant:",
                "lmao was gonna say",
                "Sahil Handa:",
                "Govt often steps in to prevent companies from increasing pay",
                "Sometimes for good reason, sometimes for corrupt reasons",
                "David Grant:",
                "That I totally believe",
                "you’re gonna have pockets of uber wealthy tech dudes in the midst of low income areas",
                "although I think a bit of that already exists",
                "Sahil Handa:",
                "Oh yeah I mean, I lived in Bangalore",
                "It’s the SF of India",
                "David Grant:",
                "thats what I hear",
                "I wanna visit so bad lol",
                "Sahil Handa:",
                "We’ll go next year",
                "Eli Burnes:",
                "Speaking of India...",
                "https://peoplesdispatch.org/2020/11/27/250-million-people-participate-in-nationwide-strike-in-india/",
                "nuts!",
                "David Grant:",
                "Man this whole thing reminds me that I need to reconnect with the SA / Austin tech people",
                "Sahil Handa:",
                "India news is so crazy that I completely missed this strike",
                "Fuck this is fascinating",
                "David Grant:",
                "I think they need to focus a lot more on training people who are already here in tech so they can work remotely for other companies instead of trying the really difficult task of attracting people to relocate",
                "Sahil Handa:",
                "Modi’s voter demographics are insane",
                "David Grant:",
                "Although I guess you could do both since SA’s cost of living is so low",
                "also holy shit re: India",
                "oh wow literally the largest in history??",
                "I feel like history has shown that you really don’t want to piss of your nation’s farmers....",
                "Sahil Handa:",
                "Idk man, look at France",
                "Farmers have been pissed for a while...",
                "But history is indeed a better guide than Macron’s delusions of grandeur...",
                "David Grant:",
                "I mean they did have two revolutions so I’m not convinced they’re afraid of a third",
                "Actually jokes bc I’ve realized Europeans take “revolution” actually seriously unlike Americans",
                "Eli Burnes:",
                "Im remembering Seratonin rn haha. Heinous book.",
                "Hm interesting. Revolution for us is a good thing. Civil war though...",
                "David Grant:",
                "Maybe just violence in general ",
                "Eli Burnes:",
                "We are way, way more violent as a society",
                "Perhaps we are used to it",
                "David Grant:",
                "I feel like it may be the opposite — because we’ve not really had to live with it domestically on a mass scale since like, our civil war",
                "The closest thing being police violence",
                "Which shouldn’t be understated I suppose",
                "Eli Burnes:",
                "Well just the rates of any crime - homicide, sucide, mass shooting are way way higher in america",
                "Not sure",
                "https://ourworldindata.org/terrorism",
                "Wrt to terrorism, we have 1.5-3x as many deaths as European countries",
                "I buy the theory that america is inherently very violent bc of its history of westward expansion, lawlessness",
                "https://ourworldindata.org/grapher/fatalities-from-terrorism",
                "David Grant:",
                "I think because frankly most times we’ve invoked violence, it’s been to our advantage and we rarely have to deal with the consequences domestically. Not so for most other countries, I think.",
                "Although Mexico is rather violent and Canada is pretty chill so idk",
                "I guess our meddling in LATAM could account for MX",
                "Sahil Handa:",
                "'It was, therefore, very French of Tocqueville to say that the Americans’ method of thought was Cartesian without their ever having read Descartes, and to wonder whether they could understand a Pascal or produce one. America was not for him a people with a book. A Frenchman was a creature of sentiments informed by a literary tradition, while an American was a man of rational principles.'",
                "'In America, Tocqueville said, everyone is a Cartesian although no one has read Descartes. We were almost entirely importers of philosophy, with the exception of Pragmatism. One need not have read a line of philosophy to be considered educated in this country. '",
                "It’s why Menand wrote the book on pragmatism. The dominant line in American thought -- the country’s philosophical contribution -- is based on being pragmatic",
                "Eli Burnes:",
                "Are you using roam?",
                "Sahil Handa:",
                "Yeppppp",
                "haha",
                "facts",
                "Eli Burnes:",
                "I absolutely love pragmatism",
                "Sahil Handa:",
                "It’s so sick",
                "Eli Burnes:",
                "Dewey is the GOAT",
                "I love how the europeans read + responded his treatise on art",
                "Sahil Handa:",
                "They take him seriously in a way that Americans don’t, hahaha",
                "Interestingly I think pragmatism could be a response to the shitshow of a history that you both described",
                "Like, Oliver Wendell Holmes became a ‘pragmatist’ because he fought in the war and realized how fucked it was",
                "For the sake of ANY ideology",
                "Eli Burnes:",
                "wow",
                "I need to read Menands book",
                "To learn the story",
                "Sahil Handa:",
                "It’s brilliant",
                "Eli Burnes:",
                "I feel like most of the Americans interested in Dewey have a European influence. Brandom, Rorty for instance",
                "Sahil Handa:",
                "I have been waiting for his Cold War culture book for so long",
                "He’s been working on it for like seven years",
                "Eli Burnes:",
                "Tried to get it from widener all freshman year but it was taken",
                "Sahil Handa:",
                "Finally out next April",
            };
        private static string[] lines4 { get; } =
            {
                "Eli Burnes:",
                "man hearing people defend china with accusations of racism is fucking surreal",
                "Sahil Handa:",
                "https://www.theatlantic.com/ideas/archive/2020/03/china-trolling-world-and-avoiding-blame/608332/",
                "China Is Avoiding Blame by Trolling the World",
                "Abso-fucking-lutely",
                "weaponized wokeness",
                "Eli Burnes:",
                "It’s a threat",
                "Also kinda ironically some Chinese citizens see wokeness as just as authoritarian as their gov, like Chinese cinema is no more censored than American cinema",
                "Sahil Handa:",
                "Wow that’s incredible",
                "Where did you read/ hear about that",
                "Eli Burnes:",
                "Heard it from a friend I think",
                "But generally the Chinese people I know have been keen to argue that Chinese and us institutions are similarly authoritarian",
                "Sahil Handa:",
                "Intriguing",
                "The China/US impacts may be the greatest effect of this whole crisis",
                "Eli Burnes:",
                "found this at the end of a philosophy essay: ‘so yet again i submit myself to the akwardness of educating myself in public’",
                "-cavell",
                "sounds so good",
                "Sahil Handa:",
                "Oh fuck yes",
                "That's savage",
                "Thinking out loud",
                "Eli Burnes:",
                "dude I just returned to Joshua Landy",
                "read some of his essays",
                "they are so fricken on point",
                "https://arcade.stanford.edu/rofl/deceit-desire-and-literature-professor-why-girardians-exist",
                "and  destroys 'death of the author'",
                "https://muse.jhu.edu/article/685449/pdf",
                "there so much bullshit in literary theory man its honestly sad",
                "Sahil Handa:",
                "Fuck bro",
                "I need to read these",
                "there so much bullshit in literary theory man its honestly sad",
                "Could not agree more",
                "The title of the one on Girard has me so hyped",
                "and I see Shakespeare",
                "Just found Daniel Schmachtenberger",
                "There's this dude I met who's in the startup world (two or three years younger than us but is a millionare who invests etc.)",
                "and he is insanely smart",
                "Just insane",
                "Read more than all of us put together",
                "So I've been hitting him up for a lot of recommendations",
                "Getting back into some Taleb and Thiel too LOL",
                "Reading their books",
                "Eli Burnes:",
                "that dude sounds insane haha",
                "what is he recommending",
                "And if you wonder why there is a current riot against a certain class of self-congratulatory 'experts', skin the game will provide a clear answer: the public has viscerally detected that some 'educated' but cosmetic experts have no skin in the game and will never learn from their mistakes, whether individually or, more dangerously, collectively.",
                "FIRE",
                "From taleb",
                "Sahil Handa:",
                "Fucking fire.",
                "Two more from his Twitter:",
                "’The Lesson of 2016 is that it took social media (not a 'free' press) to take universal suffrage to its natural conclusion.’",
                "’This illusion that one can work with abstract ideas WITHOUT embedding them is the reason 'intellectuals' don't get skin in the game.’",
                "’Populism: democratic participation by the uneducated population when conflicts w/that of the miseducated one.’",
                "He's all about localism and mixed systems",
                "Taleb reveres the ancients - the fact that everyone in the society knows the smell of dead bodies means no one is shell shocked when a catastrophic event hits and aren't paralyzed with fear and causing a burden on society.",
                "Egalitarianism is inherently unstable. He wants a variety of systems to make the whole system antifragile",
                "Eli Burnes:",
                "Hmm that’s quite interesting",
                "Populism take is so facts haha",
                "Sahil Handa:",
                "I disagree with at least half of what he says",
                "But he stretches the mind in fun ways",
                "Eli Burnes:",
                "For sure",
                "I’m partly repulsed by the anti intellectualism, business style thinking, very technological",
                "But it’s quite refreshing"
            };

        private static string user = "Sahil Handa";

        static LoadMyDraftedConvos()
        {
            InboxList.Add(new DraftedMessage(lines0, user));
            InboxList.Add(new DraftedMessage(lines1, user));
            InboxList.Add(new DraftedMessage(lines2, user));
            InboxList.Add(new DraftedMessage(lines3, user));
            InboxList.Add(new DraftedMessage(lines4, user));
        }
    }
}

