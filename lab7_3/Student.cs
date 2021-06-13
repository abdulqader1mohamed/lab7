using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_3
{
    class Student
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Student(int _id,string _username,string _password,string _email)
        {
            ID = _id;
            UserName = _username;
            Password = _password;
            Email = _email;
        }
        public Student() { }
        public Student(string _username,string _password) : this(1, _username, _password,( _username+"@yahoo.com")) { }
        public void print()
        {
            Console.WriteLine($"ID : {ID}\n Name : {UserName}\n password : {Password}\n email : {Email}");
        }
    }
}
