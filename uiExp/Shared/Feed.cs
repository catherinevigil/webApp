//this class is no longer used. keeping it around to 1. have the text of the feed in string format and 2. to suggest maybe in the future to edit then use this class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace uiExp.Shared
{

    public class Feed
    {        

        private List<PublicConvo> ConvoList = new List<PublicConvo>();
        public String name = "i am a feed";

        public Feed(List<int> replyConvoNumbers)
        {
            MakeList(replyConvoNumbers);
        }
        private void MakeList (List<int> replyConvoNumbers)
        {
            foreach (var convoNum in replyConvoNumbers)
            {
                this.ConvoList.Add(LoadFeedConvos.ConvoList[convoNum]);
            }
        }

        public List<PublicConvo>  GetConvoList()
        {
            return this.ConvoList;
        }

    }
}
