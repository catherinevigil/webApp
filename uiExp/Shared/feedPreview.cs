using System;
using System.Linq;
using System.Collections.Generic;

namespace uiExp.Shared
{
    public class FeedPreview
    {
        private List<MessageGroup> Groups = new List<MessageGroup>();
        private int MessageCount;

        public  List<MessageGroup> GetGroups()
        {
            return Groups;
        }
        public void SetGroups(List<MessageGroup> groups)
        {
            this.Groups=groups;
        }
        public FeedPreview()
        {

        }
        public FeedPreview(string[] lines)
        {
            SeperatePreview(lines);
        }
        public int GetMessageCount()
        {
            return MessageCount;
        }

        public void SeperatePreview(string[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].EndsWith(":"))
                {
                    var name = lines[i].Remove(lines[i].Length - 1);
                    this.Groups.Add(new MessageGroup(Users.GetUserByName(name)));
                }
                else
                {
                    this.Groups.Last().Messages.Add(new Message(lines[i]));
                    MessageCount++;
                }
            }
        }
    }
}
