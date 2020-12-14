using System;
using System.Collections.Generic;
using System.Linq;

namespace uiExp.Shared
{
    //public class Line
    //{
    //    private User Requester;
    //    private Conversation Request = new Conversation();
    //    private int MessageCount = 0;

    //    public Line(string[] lines)
    //    {
    //        InputLines(lines);
    //    }

    //    private void InputLines (string[] lines)
    //    {
    //        for (int i = 0; i < lines.Length; i++)
    //        {
    //            if (lines[i].EndsWith(":"))
    //            {
    //                var requester = Users.GetUserByName(lines[i].Remove(lines[i].Length - 1));
    //                this.Requester = requester;
    //                this.Request.Groups.Add(new MessageGroup(requester));
    //            }
    //            else
    //            {
    //                this.Request.Groups.LastOrDefault().Messages.Add(new Message(lines[i]));
    //                MessageCount++;
    //            }

    //        }
    //    }
    //    public User GetRequester()
    //    {
    //        return this.Requester;
    //    }
    //    public Conversation GetRequest()
    //    {
    //        return this.Request;
    //    }


    //}
}
