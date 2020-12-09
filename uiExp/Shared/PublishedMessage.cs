using System;
using System.Collections.Generic;
using System.Linq;
namespace uiExp.Shared
{
    public class PublishedMessage
    { 
        private String name;
        private Conversation conversation;
        private User MyLinesOwner;//this is the person who is looking at the convo from their profile
        private List<User> partners = new List<User>();
        private String image;

        public PublishedMessage(string[] lines, string user)
        {
            this.MyLinesOwner = Users.GetUserByName(user);
            conversation = new Conversation(lines);
            MakePartners(user);
            if (this.partners.Count > 1)
            {
                this.name = "Cambridge Apostles";
            }
            else if (this.partners.Count == 1)
            {
                this.image = this.partners[0].GetImg();
                this.name = partners[0].GetName();
            }
        }

        public void MakePartners(string user)
        {
            foreach (var person in this.conversation.Conversants)
            {
                if (!(person.GetName() == user))
                {
                    this.partners.Add(person);
                }
            }
        }
        public List<User> GetPartners()
        {
            return this.partners;
        }
        public User GetMyLinesOwner()
        {
            return this.MyLinesOwner;
        }
        public String GetLastMessage()
        {
            return conversation.Groups.Last().Messages.Last().Text;
        }

        public String GetLastTexter()
        {
            return conversation.Groups.Last().Texter.GetName();
        }

        public String GetConvoName()
        {
            return this.name;
        }

        public String GetImg()
        {
            return this.image;
        }
        public Conversation GetConvo()
        {
            return this.conversation;
        }

    }
}


