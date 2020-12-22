using System;
using System.Collections.Generic;
using System.Linq;

namespace uiExp.Shared
{
    public class Hashtag
    {
        public String Tag;
        private List<int> Conversations;

        public Hashtag(string tag)
        {
            this.Tag = tag;
        }
    }
}
