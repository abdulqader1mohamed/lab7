using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] std = {
             new Student(1, "ahmed", "123ahmed", "ahmed@yahoo.com"),
             new Student(2, "aly", "123aly", "aly@yahoo.com"),
             new Student(3, "mhmd", "123mhmd", "mhmd@yahoo.com"),
              new Student(4, "ayman", "123ayman", "ayman@yahoo.com")
        };
            Authenticate aus = new Authenticate() { Std = std };
            #region login overload
            // if ( aus.login(1, "123ahmed"))
            //      Console.WriteLine("student is exist");
            //  else Console.WriteLine("not exist");
            //  if (aus.login("mhmd", "123mhmd", "mhmd@yahoo.com"))
            //      Console.WriteLine("student is exist");
            //  else Console.WriteLine("not exist");
            //  if (aus.login("1233ahmed", "123mhmd"))
            //Console.WriteLine("student is exist");
            //  else Console.WriteLine("not exist");
            //  if (aus.login("ayman", "123mhmd"))
            //Console.WriteLine("student is exist");
            //  else Console.WriteLine("not exist");
            #endregion
            #region forget password
            //aus.ForgetPassword(1);
            //aus.ForgetPassword(10);
            //aus.ForgetPassword("ayman");
            //aus.ForgetPassword("mhmd@yahoo.com",3);
            //aus.ForgetPassword("mhmdgd@yahoo.com", 3);
            
            #endregion
            #region reset password
            Console.WriteLine("enter new password : ");
            string newPaaword = Console.ReadLine();
            //if (aus.ResetPassword("ahmed@yahoo.com", "123ahmed",newPaaword))
            //Console.WriteLine("password changed succefully");
            //else Console.WriteLine("student doesnot found");
            if (aus.ResetPassword(1,"123ahmed",newPaaword))
                Console.WriteLine("password changed succefully");
            else Console.WriteLine("student doesnot found");
            //if (aus.ResetPassword("ahmed@yahoo","dsdsds",newPaaword))
            //    Console.WriteLine("password changed succefully");
            //else Console.WriteLine("student doesnot found");
            Console.ReadKey();
            #endregion
        }
    }
}
