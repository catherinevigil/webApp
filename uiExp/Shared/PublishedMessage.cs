using System;
using System.Collections.Generic;
using System.Linq;
namespace uiExp.Shared
{
    public class PublishedMessage
    { 
        private String name;
        private PublicConvo Conversation;
        private User MyLinesOwner; //this is the person who is looking at the convo from their profile
        private List<User> partners = new List<User>();
        
        public PublishedMessage(string[] lines, string user, string poster, string title)
        {
            this.MyLinesOwner = Users.GetUserByName(user);
            Conversation = new PublicConvo(lines, title, poster);
            MakePartners(user);
            if (this.partners.Count > 1)
            {
                this.name = "Cambridge Apostles";
            }
            else if (this.partners.Count == 1)
            {
                this.Conversation.SetImg(this.partners[0].GetImg());
                this.Conversation.SetTitle(partners[0].GetName());
            }
        }
        public PublishedMessage (PublicConvo conversation,User user)
        {
            this.MyLinesOwner = user;
            this.Conversation = conversation;
        }

        public void MakePartners(string user)
        {
            foreach (var person in this.Conversation.GetConversants())
            {
                if (!(person.GetName() == user))
                {
                    this.partners.Add(person);
                }
            }
        }
        public string GetTitle()
        {
            return this.Conversation.GetTitle();
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
            return Conversation.GetConversation().Groups.Last().Messages.Last().Text;
        }

        public String GetLastTexter()
        {
            return Conversation.GetConversation().Groups.Last().Texter.GetName();
        }

        public String GetConvoName()
        {
            return this.name;
        }

        public String GetImg()
        {
            return this.Conversation.GetImg();
        }
        public Conversation GetConvo()
        {
            return this.Conversation.GetConversation();
        }

    }
}


