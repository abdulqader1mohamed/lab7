using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_2
{
    class PREmployee :Employee
    {
        public override void showEmpDetails()
        {
            Console.Write($"pr employee : \n\t name :{Name}\t id : {ID}\t salary : {Salary}\n\t\t\t ");

            for (int i = 0; i < Client.Length; i++)
            {
                Client[i].showClientDetail();
            }
        }
    }
}
