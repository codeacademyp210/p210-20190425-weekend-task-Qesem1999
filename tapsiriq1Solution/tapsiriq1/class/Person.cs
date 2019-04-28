using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace tapsiriq1
{
    class Person
{
        
       
        protected string name;
        protected string surname;
        protected int cardId;
        int now = 2019;
        int year;

        public string Birthday
        {
            get
            {

                return (now - year).ToString();
            }
            set
            {
                string regexPattern = @"\d{4}";
                Regex r = new Regex(regexPattern);
                year = Convert.ToInt32(r.Match(value).Value);
            }
        }

        protected string Surname { get => surname; set => surname = value; }

        



        public string getName()
        {
            return name;
        }
        public void setName( string Name)
        {
            name = Name;
        }

        

        public string getSurname()
        {
            return Surname;
        }
        public void setSurname(string Surname)
        {
            surname = Surname;
        }



        public int getCardId()
        {
            return cardId;
        }
        public void setCardId(int CardId)
        {
            cardId = CardId;
        }
    }
}
