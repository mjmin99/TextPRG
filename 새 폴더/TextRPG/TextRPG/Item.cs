using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Item
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        //생성자
        public Item(string name, string description) 
        {
            Name = name;
            Description = description;
        }
    }
}
