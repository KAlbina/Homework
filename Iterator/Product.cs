using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class Product
    {
        public string Name { get; }      
        public int DaysLeft { get; }     

        public Product(string name, int daysLeft)
        {
            Name = name;
            DaysLeft = daysLeft;
        }

        public bool IsFresh => DaysLeft > 0;
    }
}
