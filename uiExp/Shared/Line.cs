using System;
using System.Collections.Generic;
using System.Linq;

namespace uiExp.Shared
{
    public class Line
    {
        private User Requester;
        private Conversation Request = new Conversation();

        public Line(string[] lines)
        {
            InputLines(lines);
        }

        private void InputLines (string[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].EndsWith(":"))
                {
                    var name = lines[i].Remove(lines[i].Length - 1);
                    this.Requester = Users.GetUserByName(name);
                    this.Request.Groups.Add(new MessageGroup());
                }
                else
                {
                    this.Request.Groups.Last().Messages.Add(new Message(lines[i]));
                }

            }
        }

    }
}
