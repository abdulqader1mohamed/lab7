using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_2
{
    class Program
    {
        public static void printEmp(Employee[] emp)
        {
            for (int i = 0; i < emp.Length; i++)
            {
                emp[i].showEmpDetails();
            }
        }
        static void Main(string[] args)
        {
            Clients[] client = new Clients[3]
            {
                new Clients() {ID=11,Name="ahmed",City="mansoura" },
                new Clients() {ID=22,Name="ayman",City="mansoura" },
                new Clients() {ID=33,Name="aly",City="mansoura" }
            };
            Clients[] client2 = new Clients[3]
            {
                new Clients() {ID=11,Name="ahmed",City="mansoura" },
                new Clients() {ID=12,Name="mahmoud",City="mansoura" },
                new Clients() {ID=13,Name="mhmd",City="mansoura" }
            };
            Clients[] client3 = new Clients[3]
            {
                new Clients() {ID=1,Name="mhmd",City="mansoura" },
                new Clients() {ID=1,Name="tawfik",City="mansoura" },
                new Clients() {ID=1,Name="ebraheem",City="mansoura" }
            };
            Employee[] emp =
                {
                  new HREmployee() {ID=1,Name="ahmed",Salary=3000 ,Client=client },
                  new HREmployee() {ID=2,Name="ALY",Salary=4000 ,Client=client2 },
                  new HREmployee() {ID=3,Name="mhmd",Salary=5000 ,Client=client3  },
                  new PREmployee() {ID=4,Name="ayman",Salary=6000 ,Client=client },
                  new PREmployee() {ID=5,Name="abbas",Salary=7000 ,Client=client2 },
                  new PREmployee() {ID=6,Name="mosaad",Salary=8000 ,Client=client3 }
            };
            printEmp(emp);




            HREmployee hrone = new HREmployee() { ID = 1, Name = "ahmed", Salary = 3000, Client = client };
            HREmployee hrtwo = new HREmployee() { ID = 2, Name = "aly", Salary = 4000, Client = client2 };
            HREmployee hrthree = hrone + hrtwo;
            Console.ReadKey();
        }
    }
}
