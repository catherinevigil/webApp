using System;
using System.Collections.Generic;
using System.Linq;

namespace uiExp.Shared
{
    public class PublicConvo
    {
        private Conversation conversation;
        private Comments comments;
        private List<PublicConvo> ResponseThreads;
        private User Poster;
        private String Title;
        private FeedPreview feedPreview;
        private List<int> ResponseConvoNumbers;

        public PublicConvo(string[] lines, string title, string poster, string[] preview, Comments com, int[] replies)
        {
            this.Poster = Users.GetUserByName(poster);
            this.Title = title;
            this.conversation = new Conversation(lines);
            this.feedPreview = new FeedPreview(preview);
            this.comments = com;
            this.ResponseConvoNumbers = replies.ToList();
        }
        public List<int> GetReplyThreadNums()
        {
            return this.ResponseConvoNumbers;
        }
        public Conversation GetConversation()
        {
            return this.conversation;
        }
        public Comments GetComments()
        {
            return this.comments;
        }
        public List<User> GetConversants()
        {
            return this.conversation.Conversants;
        }
        public String GetTitle()
        {
            return this.Title;
        }
        public String GetNames()
        {
            return this.conversation.GetNames();
        }
        public FeedPreview GetFeedPreview()
        {
            return this.feedPreview;
        }
        public List<int> GetReplyConvoNumbers()
        {
            return this.ResponseConvoNumbers;
        }
    }
}
