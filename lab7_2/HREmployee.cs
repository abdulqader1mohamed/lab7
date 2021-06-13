using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_2
{
    class HREmployee:Employee
    {
        public override void showEmpDetails()
        {
            Console.Write($"hr employee : \n\t name :{Name}\t id : {ID}\t salary : {Salary}\n\t\t\t ");

            for (int i = 0; i < Client.Length; i++)
            {
                Client[i].showClientDetail();
            }
        }
        public static HREmployee operator +(HREmployee hremp1, HREmployee hremp2)
        {
            return new HREmployee()
            {
                ID = hremp1.ID + hremp2.ID,
                Name = hremp1.Name + " " + hremp2.Name,
                Salary = hremp1.Salary + hremp2.Salary
            };

        }
    }
}
