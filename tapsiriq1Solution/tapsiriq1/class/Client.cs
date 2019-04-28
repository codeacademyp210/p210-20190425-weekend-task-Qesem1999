using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriq1
{
    class Client : Person
{
        protected static int id = 0;
        protected int clientId;
        protected string address;
        protected int phone;

        public int getId()
        {
            return ++id;
        }

        public int getClientId()
        {
            return clientId;
        }
        public void setClientId(int ClientId)
        {
            clientId = ClientId;
        }


        public int getPhone()
        {
            return phone;
        }
        public void setPhone(int Phone)
        {
            phone = Phone;
        }


        public string getAddress()
        {
            return address;
        }
        public void setAddress(string Address)
        {
            address = Address;
        }


    }
}
