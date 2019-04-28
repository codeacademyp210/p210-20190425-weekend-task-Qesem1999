using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriq1
{
    class Product : Person
    {
        protected static int id = 0;
        protected string color;
        protected int price;

        public int getId()
        {
            return ++id;
        }

        public int getPrice()
        {
            return price;
        }
        public void setPrice(int Price)
        {
            price = Price;
        }

        public string getColor()
        {
            return color;
        }
        public void setColor(string Color)
        {
            color = Color;
        }


    }
}
