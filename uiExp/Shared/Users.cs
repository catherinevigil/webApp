using System;
using System.Collections.Generic;

namespace uiExp.Shared
{
    public class Users
    {
        public static List<User> List = new List<User>();

        static Users()
        {
            List.Add(new User("Ian Liefer", "ian","IL", "finance bro. tesla fanboy", "https://media-exp1.licdn.com/dms/image/C4D03AQFmwF_Hc4uFSw/profile-displayphoto-shrink_200_200/0/1607308397979?e=1614211200&v=beta&t=k62XnsTDXsVIrr63sl19wb_9hmVXc8cvdat3w5Mdcpo"));
            List.Add(new User("Caleb Rhodes", "caleb","CR", "i like biology and 20th century history. and soccer.", "https://scontent-bos3-1.cdninstagram.com/v/t51.2885-19/s150x150/126024490_410239013327865_6531251105120212480_n.jpg?_nc_ht=scontent-bos3-1.cdninstagram.com&_nc_ohc=LlaeRDg3f6IAX-_OQxi&tp=1&oh=cce3c4cde63db679776c15af7617f91b&oe=5FEB6301"));
            List.Add(new User("Ethan Fogarty", "ethan", "EF", " musuem fanatic, chaser of artifacts. from upstate Ny", "https://media-exp1.licdn.com/dms/image/C4E03AQHM1yPJvzemBw/profile-displayphoto-shrink_800_800/0/1603733783473?e=1614211200&v=beta&t=HMNC2CQbviwj1IbVeASUPyQ5gw0mE55ulvIVAHQ6Ubo"));
            List.Add(new User("Saffron Huang", "saffron","SH", "how shall we live together? • kiwi, deepmind • thinking about hypermagical ultraomnipotence", "https://pbs.twimg.com/profile_images/1316334259972390912/uIqM_yio_400x400.jpg"));
            List.Add(new User("Jasmine Wang", "jasmine", "JW", "writer, builder, aspiring ninja. just trying to outrun GPT-3. be excellent, be magical. research fellow at PartnershipAI, formerly at OpenAI.", "https://media-exp1.licdn.com/dms/image/C5103AQFBUjc90QLYeQ/profile-displayphoto-shrink_800_800/0?e=1611792000&v=beta&t=E9Paz009aIUs3CADHvjHJ_NmquBWVqZNwTC8HG_LG84"));
            List.Add(new User("Tunc Otzemir", "tunc", "TO", "leftist harvard 21/22", "https://pbs.twimg.com/profile_images/1323650686874275840/rN1b-3IF_400x400.jpg"));
            List.Add(new User("Sahil Handa", "sahil","SH", "I enjoy listening to jazz, dancing to techno, wearing weird shirts, going on walks, eating fruit, and putting words on paper. Also grammar. Liberalism is the new counterculture.", "https://pbs.twimg.com/profile_images/1278702779666624512/etYprSkh_400x400.jpg"));
            List.Add(new User("Eli Burnes", "eli","EB", "salubrious sailor. phlegmatic friend. loves novels, neurons, and some niche philosophical deebates.",  "https://pbs.twimg.com/profile_images/955259459449884672/cxYFJUJX_400x400.jpg"));
            List.Add(new User("Emily Markowitz", "emily","EM", "https://pbs.twimg.com/profile_images/819168369773580289/PKTTeMWa_400x400.jpg"));
            List.Add(new User("Regan Brady", "regan", "RB", "@Harvard ‘22, @EuropeAtHarvard | @StrideFunding","https://pbs.twimg.com/profile_images/1278565520200151040/oqt3H8mV_400x400.jpg"));
            List.Add(new User("Kush Sharma", "kush","KS", "Harvard '?? - neurotech, psychology, systems. spending some time on COVID vaccines at curative.", "https://pbs.twimg.com/profile_images/1140844401620447232/Au3Rq27v_400x400.png"));
            List.Add(new User("Marshall Sloane", "marshall","MS", "https://pbs.twimg.com/profile_images/1219094554302959617/Z_kxkzep_400x400.jpg"));
            List.Add(new User("Henry Burnes", "henry","HB", "Harvard ‘22, runner, sailor, outdoors fanatic, studying chemistry", "https://instagram.flhr4-2.fna.fbcdn.net/v/t51.2885-19/s320x320/116309149_1228799094139352_5633672728796461794_n.jpg?_nc_ht=instagram.flhr4-2.fna.fbcdn.net&_nc_ohc=CtvxqdQodvkAX8m7MI6&tp=1&oh=1ba052a04b515fca774da0c2823f1f26&oe=60121012"));
            List.Add(new User("Jonah Berger", "jonah","JB", "wanna be supreme court justice. Marathoner. i like biographes.","https://pbs.twimg.com/profile_images/945496350149500928/oSwRCrOR_400x400.jpg"));
            List.Add(new User("Campbell Erickson", "campbell","CE", "turning rural america blue. fighting corrution at home and abroad.", "https://pbs.twimg.com/profile_images/1268391920117612544/HgMzJ8yN_400x400.jpg"));
            List.Add(new User("Noah Redlich", "noah", "NR", "Populist, Socialist, Democrat, in that order", "https://pbs.twimg.com/profile_images/1185259612938702849/PpL8KbsI_400x400.jpg"));
            List.Add(new User("Garrett Walker", "garrett","GW", "Effective Altruism. Development economics.", "https://scontent-bos3-1.xx.fbcdn.net/v/t1.0-9/28783100_177715086186379_6047144902855229440_o.jpg?_nc_cat=100&ccb=2&_nc_sid=09cbfe&_nc_ohc=s5y7vtmn9DcAX9xMxj6&_nc_ht=scontent-bos3-1.xx&oh=0dba68c02d4e5278758719ea3e96167e&oe=5FF0CD60"));
            List.Add(new User("Jake Sylvestre", "jake","JS", "Building bitcoin things (entropy.rocks). Recovering cybersecurity founder", "https://pbs.twimg.com/profile_images/1309602788545003520/MjbE4Zau_400x400.jpg"));
            List.Add(new User("David Grant", "david","DG", "Not a VC. I like film and code and thinking and feeling.", "https://pbs.twimg.com/profile_images/1291339762217947136/KtGhjbzc_400x400.jpg"));
            List.Add(new User("Rahul Vohra", "rahul", "RV", "Founder & CEO of Superhuman. Founded Rapportive.Computer Scientist, Gamer, Entrepreneur, Designer.", "https://miro.medium.com/max/3150/2*jkkBkl_Sblqqm0IuF-k-6Q.jpeg"));
            List.Add(new User("Soroush Ghodsi", "soroush","SG", "Founder of Slik (YC S17)", "https://pbs.twimg.com/profile_images/1278374433242087424/se2hFgDB_400x400.jpg"));
            List.Add(new User("Shadi Hamid", "shadi", "SH", "Contributing Writer at The Atlantic, Senior Fellow at the Brookings Institute", "https://pbs.twimg.com/profile_images/1237207586983809025/sKq3Ls_B_400x400.jpg"));
            List.Add(new User("Mohammad Fadel", "mohammad", "MF", "Mask-Wearing Job Killer", "https://pbs.twimg.com/profile_images/1266455220705517575/r7J1kqu3_400x400.jpg"));
            List.Add(new User("Jeffrey Sachs", "jeffrey", "JS", "Lecturer at Acadia University. Judicial politics, authoritarianism, Islamic law. Specializing in Sudan/Egypt. Occasionally free speech on campus issues as well.", "https://i.imgur.com/2vodzwt.jpg"));
            List.Add(new User("Damir Marusic", "damir", "DM", "Senior Fellow at the Atlantic Council. Co-host of Wisdom of Crowds with Shadi Hamid.", "https://pbs.twimg.com/profile_images/1336246073569013760/9mx9b-b__400x400.jpg"));
            List.Add(new User("Bruno Macaes", "bruno", "BM", "I write books. “Dawn of Eurasia” (2018), “Belt and Road” (2019), “History Has Begun” (2020), “Geopolitics for the End Time” (2021), “The Search for Greater India” (2022)", "https://pbs.twimg.com/profile_images/1293369494568685575/Bg2A_HZq_400x400.jpg"));
            List.Add(new User("Agnes Callard", "agnes", "AC", "Philosopher, UChicago. Socrates fan account.", "https://humanities-web.s3.us-east-2.amazonaws.com/philosophy/prod/styles/square_image_large/s3/2018-07/Callard.jpg?itok=4SpduN0b"));
            List.Add(new User("James Baldwin", "baldwin", "JBB", "The one thing that all Americans have in common is that they have no other identity apart from the identity which is being achieved on this continent.", "https://pbs.twimg.com/profile_images/1287997972991508482/JDAAkRLF_400x400.jpg"));
            List.Add(new User("WJ Weatherby", "weatherby", "WJ", "W. J. Weatherby, journalist, died Poughkeepsie NY 5 August, aged 62. A correspondent for the Guardian since 1952, he also wrote for Newsweek, the New York Times and the Washington Post.", "https://pbs.twimg.com/profile_images/1175141826870861825/K2qKoGla_400x400.png"));
        }
   

        public static User GetUserByName(string name)
        {
            foreach (var person in List)
            {
                //Console.WriteLine("name being checked:\""+name+"\" name of this person in list:\""+person.GetName());
                if (person.GetName() == name)
                {
                 //   Console.WriteLine("will return a person, data given to a convo object");
                    return person;
                }
            }
            Console.WriteLine("will return null. no user by that name: "+name);
            return null;
        }
        public static User loginUser(String username, String password)
        {
            foreach (var user in List)
            {
                //Console.WriteLine("in users method, username: " + username);
                //Console.WriteLine(user.LogIn(username, password));
                if (user.LogIn(username,password))
                {
                    return user;
                }
            }
            return null;
        }
    }
}
