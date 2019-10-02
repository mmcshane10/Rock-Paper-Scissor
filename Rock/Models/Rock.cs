using System;

namespace RPS.Models
{
    public class Item
    {
        public string Type { get; set;}
        public int Number { get; set;}
        public Item(string type)
        {
            Type = type;
            if (type == "rock")
            {
                Number = 1;
            }
            else if (type == "paper")
            {
                Number = 2;
            }
            else 
            {
                Number = 4;
            }
        }
    }
}