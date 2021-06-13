using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Program
    {
        
        static void Main(string[] args)
        {
            #region 1
            Duration d1 = new Duration() { Hours = 1, Min = 55, Seconds = 10 };
            Duration d2 = new Duration(3600);
            Duration D3 = new Duration(7800);
            Duration D4 = new Duration(666);
            d1.print();
            d2.print();
            D3.print();
            D4.print();
            D3 = d1 + d2;
            D3.print();

            D3 = D3 + 7800;
            D3.print();

            if (d1>d2)
            {
                Console.WriteLine("d1 gt d2");
            }else
                Console.WriteLine("d2 ls d1");
            if (D3>=D4)
            {
                Console.WriteLine("d3 gt d4");
            }
            else
                Console.WriteLine("d3 ls d4");
            Console.ReadKey();
            #endregion

        }
    }
}
