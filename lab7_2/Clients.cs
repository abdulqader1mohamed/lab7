using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_2
{
    class Clients
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public void showClientDetail()
        {
            Console.Write($"client id : {ID}\tclient name : {Name}\tclient city : {City}");
        }
    }
}
