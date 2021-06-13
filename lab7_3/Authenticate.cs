using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_3
{
    class Authenticate
    {
        public Student[] Std { get; set; }
        public bool login(string userName,string password,string email)
        {
            int ctr = 0;
            for (int i = 0; i < Std.Length; i++)
            {
                if (Std[i].UserName == userName && Std[i].Email == email && Std[i].Password == password)
                {
                    ctr++;
                }
            }
            if (ctr != 0) return true;
            else return false;
            
        }
        public bool login(string userName, string password)
        {
            int ctr = 0;
            for (int i = 0; i < Std.Length; i++)
            {
                
                if (Std[i].UserName == userName && Std[i].Password == password)
                {
                    ctr++;
                }


            }
            if (ctr != 0) return true;
            else return false;
        }
        public bool login(int id, string password)
        {
            int ctr = 0;
            for (int i = 0; i < Std.Length; i++)
            {
                
                if (Std[i].ID == id && Std[i].Password == password)
                {
                    ctr++;
                }
            }
            if (ctr != 0) return true;
            else return false;


        }
        public bool login(string email, int id)
        {
            int ctr = 0;
            for (int i = 0; i < Std.Length; i++)
            {
                if (Std[i].ID == id && Std[i].Email == email)
                {
                    ctr++;
                }
            }
            if (ctr != 0) return true;
            else return false;

        }
        public void ForgetPassword(string userName)
        { int ctr=0;
            for (int i = 0; i < Std.Length; i++)
            {
                if (Std[i].UserName == userName)
                    Console.WriteLine("Student is exist");
                ctr++;
            }
            if (ctr==0)Console.WriteLine("student not found"); 
        }
        public void ForgetPassword(string userMail, int id)
        { int ctr = 0;
            for (int i = 0; i < Std.Length; i++)
            {
                if (Std[i].Email == userMail && Std[i].ID == id)
                    Console.WriteLine("Student is exist");
                ctr++;
            }
            if (ctr == 0) Console.WriteLine("student not found");
        }
        public void ForgetPassword( int id)
        { int ctr = 0;
            for (int i = 0; i < Std.Length; i++)
            {
                if (Std[i].ID == id)
                    Console.WriteLine("Student is exist");
                ctr++;
            }
            if (ctr==0) Console.WriteLine("stuent doesnot exist");
                
            
        }

        public bool ResetPassword(int id,string oldPassword,string newPasswprd)
        { int ctr = 0;
            for (int i = 0; i < Std.Length; i++)
            {
                if (Std[i].ID == id && Std[i].Password == oldPassword)
                {
                    Std[i].Password = newPasswprd;
                    ctr++;
                }
            }
            if (ctr != 0) return true;
            else return false;

        }
        public bool ResetPassword(string userMail, string oldPassword, string newPasswprd)
        { int ctr = 0;
            for (int i = 0; i < Std.Length; i++)
            {
                if (Std[i].Email == userMail && Std[i].Password == oldPassword)
                Std[i].Password = newPasswprd;
                ctr++;
            }
            if (ctr != 0) return true;
            else return false;

        }
        public bool ResetPassword(int id, string userName,string oldPassword, string newPasswprd)
        {int ctr= 0;
            for (int i = 0; i < Std.Length; i++)
            {
                if (Std[i].ID == id && Std[i].Password == oldPassword && Std[i].UserName == userName)
                 Std[i].Password = newPasswprd;
                ctr++;
            }
            if (ctr != 0) return true;
            else return false;

        }
    }
}
