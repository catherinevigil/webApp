﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace uiExp.Shared
{
    public class PrivateMessage
    {
        private String name;
        private Conversation conversation;
        private User InboxOwner;//this is the person who is looking at the convo from their inbox
        private List<User> partners = new List<User>();
        private String image;

        public PrivateMessage()
        {
        }
        public PrivateMessage(string message, List<User> recipients)
        {
            this.InboxOwner = CurrentUser.cUser;
            conversation = new Conversation(message, recipients);
            this.conversation.Groups = SetMessageSides(this.conversation.Groups);

            if (this.partners.Count > 1)
            {
                this.name = "languid leftists";
                this.image = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/02/Bernie_Sanders_in_March_2020.jpg/433px-Bernie_Sanders_in_March_2020.jpg";
            }
            else if (this.partners.Count == 1)
            {
                this.image = this.partners[0].GetImg();
                this.name = partners[0].GetName();
            }
        }

        public PrivateMessage(string[] lines, string user)
        {
            this.InboxOwner = Users.GetUserByName(user);
            conversation = new Conversation(lines);
            this.conversation.Groups = SetMessageSides(this.conversation.Groups); 
            MakePartners(user);
            if (this.partners.Count > 1)
            {
                this.name = "languid leftists";
                this.image = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/02/Bernie_Sanders_in_March_2020.jpg/433px-Bernie_Sanders_in_March_2020.jpg";
            }
            else if (this.partners.Count == 1)
            {
                this.image = this.partners[0].GetImg();
                this.name = partners[0].GetName();
            }
        }


        public List<MessageGroup> SetMessageSides(List<MessageGroup> groups)
        {
            {
                foreach (var messageGroup in groups)
                {
                    if (messageGroup.GetTexter() == this.InboxOwner)
                    {
                        messageGroup.SetRight();
                    }
                    else
                    {
                        messageGroup.SetLeft();
                    }
                }

            }
            return groups;

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
        public List<User> GetConversants()
        {
            return this.conversation.GetConversants();
        }

        public List<User> GetPartners()
        {
            return this.partners;
        }
        public User GetInboxOwner()
        {
            return this.InboxOwner;
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
        public bool HasSameUsers(List<User> users)// this code is fucked. 
        {
            var conversants = this.GetConversants();
            foreach (var user in users)
            {
                if (!(conversants.Contains(user)))
                    return false;
            }
            foreach (var conversant in conversants)
            {
                if (!(users.Contains(conversant)))
                    return false;
            }
            return true;
        }
    
    }
}

