using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriq1
{
    class Employee : Person
{
        protected static int id = 0;
        protected string position;
        protected int salary;

        public int getId()
        {
            return ++id;
        }

        public string getPosition()
        {
            return position;
        }
        public void setPosition(string Position)
        {
            position = Position;
        }
       
        public int getSalary()
        {
            return salary;
        }
        public void setSalary(int Salary)
        {
            salary = Salary;
        }

    }
}
