using System;
using System.Collections.Generic;
namespace EmptyGroup
{
    public class StringGroup : List<string>
    {
        public string Title
        {
            get;
            set;
        }


        public StringGroup(string title)
        {
            Title = title;
        }
    }
}
