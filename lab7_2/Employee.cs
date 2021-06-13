using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_2
{
    abstract class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public Clients[] Client { get; set; }
        public abstract void showEmpDetails();
    }
}
