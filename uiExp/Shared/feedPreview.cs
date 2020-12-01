using System;
using System.Linq;
using System.Collections.Generic;

namespace uiExp.Shared
{
    public class FeedPreview
    {
        private List<MessageGroup> Groups = new List<MessageGroup>();

        public  List<MessageGroup> GetGroups()
        {
            return Groups;
        }
        public FeedPreview()
        {

        }
        public FeedPreview(string[] lines)
        {
            SeperatePreview(lines);
        }


        public void SeperatePreview(string[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].EndsWith(":"))
                {
                    this.Groups.Add(new MessageGroup());
                }
                else
                {
                    this.Groups.Last().Messages.Add(new Message(lines[i]));
                }
            }
        }
    }
}
