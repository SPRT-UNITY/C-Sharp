using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Item
    {
        public string name { get; private set; }
        public string desc { get; private set; }

        public int value { get; private set; }

        public Item() 
        {
            name = "Item";
            desc = "ItemDescription";
            value = 0;
        }

        public virtual string effectScript { get; protected set; }
    }
}
