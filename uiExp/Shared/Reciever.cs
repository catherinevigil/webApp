using System;

namespace uiExp.Shared
{
    public class Reciever
    {
        public Hashtag Tag;
        public User Person;
        public int Type;//1 for person, 2 for tag

        public Reciever(User person)
        {
            this.Person = person;
            this.Type = 1;
        }

        public Reciever(Hashtag tag)
        {
            this.Tag = tag;
            this.Type = 2;
        }
       
        public String GetText()
        {
            if (this.Type == 1)
            {
                return this.Person.GetText();
            }
            else if (this.Type == 2)
            {
                return this.Tag.GetText();
            }
            else
                return "";
        }

    }
}
