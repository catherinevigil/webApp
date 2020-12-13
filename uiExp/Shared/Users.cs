using System;
using System.Collections.Generic;

namespace uiExp.Shared
{
    public class Users
    {
        public static List<User> List = new List<User>();

        static Users()
        {
            List.Add(new User("Ian Liefer", "ian","IL", "finance bro. tesla fanboy", "https://scontent-bos3-1.xx.fbcdn.net/v/t1.0-9/20841778_1956308087915622_1547838768844489367_n.jpg?_nc_cat=101&ccb=2&_nc_sid=09cbfe&_nc_ohc=yZhhPMCTK5kAX8Datit&_nc_ht=scontent-bos3-1.xx&oh=04089f843be668b546943495867a73be&oe=5FE74D1F"));
            List.Add(new User("Caleb Rhodes", "caleb","CR", "i like biology and 20th century history. and soccer.", "https://scontent-bos3-1.cdninstagram.com/v/t51.2885-19/s150x150/126024490_410239013327865_6531251105120212480_n.jpg?_nc_ht=scontent-bos3-1.cdninstagram.com&_nc_ohc=LlaeRDg3f6IAX-_OQxi&tp=1&oh=cce3c4cde63db679776c15af7617f91b&oe=5FEB6301"));
            List.Add(new User("Ethan Fields", "ethan", "EF", " musuem fanatic, chaser of artifacts. from upstate Ny", "https://static.thenounproject.com/png/882679-200.png"));
            List.Add(new User("Saffron Huang", "saffron","SH", "how shall we live together? • kiwi, deepmind • thinking about hypermagical ultraomnipotence", "https://pbs.twimg.com/profile_images/1316334259972390912/uIqM_yio_400x400.jpg"));
            List.Add(new User("Jasmine Wang", "jasmine", "JW", "writer, builder, aspiring ninja. just trying to outrun GPT-3. be excellent, be magical. research fellow at PartnershipAI, formerly at OpenAI.", "https://media-exp1.licdn.com/dms/image/C5103AQFBUjc90QLYeQ/profile-displayphoto-shrink_800_800/0?e=1611792000&v=beta&t=E9Paz009aIUs3CADHvjHJ_NmquBWVqZNwTC8HG_LG84"));
            List.Add(new User("Tunc Otzemir", "tunc", "TO", "leftist harvard 21/22", "https://pbs.twimg.com/profile_images/1323650686874275840/rN1b-3IF_400x400.jpg"));
            List.Add(new User("Sahil Handa", "sahil","SH", "I enjoy listening to jazz, dancing to techno, wearing weird shirts, going on walks, eating fruit, and putting words on paper. Also grammar. Liberalism is the new counterculture.", "https://pbs.twimg.com/profile_images/1278702779666624512/etYprSkh_400x400.jpg"));
            List.Add(new User("Eli Burnes", "eli","EB", "salubrious sailor. phlegmatic friend. loves novels, neurons, and some niche philosophical deebates.",  "https://pbs.twimg.com/profile_images/955259459449884672/cxYFJUJX_400x400.jpg"));
            List.Add(new User("Emily Markowitz", "emily","EM", "https://scontent-bos3-1.cdninstagram.com/v/t51.2885-19/s150x150/58745485_429207334326379_3268500443315044352_n.jpg?_nc_ht=scontent-bos3-1.cdninstagram.com&_nc_ohc=6Eaz3kSgnk0AX8O3Jkh&tp=1&oh=4fd2ad7fbd5967d4587c2a9488908814&oe=5FE70501"));
            List.Add(new User("Regan Brady", "regan", "RB", "@Harvard ‘22, @EuropeAtHarvard | @StrideFunding","https://pbs.twimg.com/profile_images/1278565520200151040/oqt3H8mV_400x400.jpg"));
            List.Add(new User("Kush Sharma", "kush","KS", "Harvard '?? - neurotech, psychology, systems. spending some time on COVID vaccines at curative.", "https://pbs.twimg.com/profile_images/1140844401620447232/Au3Rq27v_400x400.png"));
            List.Add(new User("Marshall Sloane", "marshall","MS", "https://pbs.twimg.com/profile_images/1219094554302959617/Z_kxkzep_400x400.jpg"));
            List.Add(new User("Henry Burnes", "henry","HB", "Harvard ‘22, runner, sailor, outdoors fanatic, studying chemistry", "https://scontent-bos3-1.cdninstagram.com/v/t51.2885-19/s150x150/116309149_1228799094139352_5633672728796461794_n.jpg?_nc_ht=scontent-bos3-1.cdninstagram.com&_nc_ohc=bYP4TvSWxLQAX91fK9_&tp=1&oh=ff9e88b60a4bcdbd0b9b9b66be350399&oe=5FE62907"));
            List.Add(new User("Jonah Berger", "jonah","JB", "wanna be supreme court justice. Marathoner. i like biographes.","https://pbs.twimg.com/profile_images/945496350149500928/oSwRCrOR_400x400.jpg"));
            List.Add(new User("Campbell Erickson", "campbell","CE", "turning rural america blue. fighting corrution at home and abroad.", "https://pbs.twimg.com/profile_images/1268391920117612544/HgMzJ8yN_400x400.jpg"));
            List.Add(new User("Noah Redlich", "noah", "NR", "Populist, Socialist, Democrat, in that order", "https://pbs.twimg.com/profile_images/1185259612938702849/PpL8KbsI_400x400.jpg"));
            List.Add(new User("Garrett Walker", "garrett","GW", "Effective Altruism. Development economics.", "https://scontent-bos3-1.xx.fbcdn.net/v/t1.0-9/28783100_177715086186379_6047144902855229440_o.jpg?_nc_cat=100&ccb=2&_nc_sid=09cbfe&_nc_ohc=s5y7vtmn9DcAX9xMxj6&_nc_ht=scontent-bos3-1.xx&oh=0dba68c02d4e5278758719ea3e96167e&oe=5FF0CD60"));
            List.Add(new User("Jake Sylvestre", "jake","JS", "Building bitcoin things (entropy.rocks). Recovering cybersecurity founder", "https://pbs.twimg.com/profile_images/1309602788545003520/MjbE4Zau_400x400.jpg"));
            List.Add(new User("David Grant", "david","DG", "Not a VC. I like film and code and thinking and feeling.", "https://pbs.twimg.com/profile_images/1291339762217947136/KtGhjbzc_400x400.jpg"));
            List.Add(new User("Rahul Vohra", "rahul", "RV", "Founder & CEO of Superhuman. Founded Rapportive.Computer Scientist, Gamer, Entrepreneur, Designer.", "https://miro.medium.com/max/3150/2*jkkBkl_Sblqqm0IuF-k-6Q.jpeg"));
            List.Add(new User("Soroush Ghodsi", "soroush","SG", "Founder of Slik (YC S17)", "https://pbs.twimg.com/profile_images/1278374433242087424/se2hFgDB_400x400.jpg"));
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
