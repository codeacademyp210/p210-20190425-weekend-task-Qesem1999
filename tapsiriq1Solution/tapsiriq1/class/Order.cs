using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriq1
{
    class Order : Person
{
        protected static int id = 0;
        protected int count;
        Product product1 = new Product();

        public int getId()
        {
            return ++id;
        }

        public int getCount()
        {
            return count;
        }
        public void setCount(int Count)
        {
            count = Count;
        }

        public int TotalPrice(int quantity, int price)
        {
           
            return quantity * price;
        }
    }
}
