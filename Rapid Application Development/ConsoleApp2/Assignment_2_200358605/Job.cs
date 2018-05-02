using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_200358605
{
    class Job
    {
        
        private int employees;
        private bool available = false;
        protected uint money;
        public string Availability;

        public bool YetAvailable()
        {
            return available;
        }

        public void AvailableOrNot(bool YesorNo)
        {
            available = YesorNo;
        }
        public int Employees
        {
            set { employees = value; }

            get { return employees; }
        }
        public uint Money {

        private set { money = value; }

            get { return money; }
        }

        
        public Job() { }

        public Job(int employees)
        {
            this.employees = employees;
        }

        public Job(int employees, uint money) : this(employees)
        {
           
            this.money = money;
        }
        public Job(int employees, uint money, string availability) : this(employees, money)
        {
        
            Availability = availability;
        }
        public override string ToString()
        {
            return"The Job has "+employees+" employees, "+money+" dollars for each employee and is available in "+Availability+" Brampton";
        }
    }
}
