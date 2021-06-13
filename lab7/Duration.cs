using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Duration
    {
        int minuites;
        int seconds;
        int hours;
        public int Min
        {
            set { minuites = value; }
            get { return minuites; }
        }
        public int Seconds
        {
            set { seconds = value; }
            get { return seconds; }
        }
        public int Hours
        {
            set { hours = value; }
            get { return hours; }
        }
        public Duration() { }
        public Duration(int _hours,int _minuites,int _seconds)
        {
            hours = _hours;
            minuites = _minuites;
            seconds = _seconds;

        }
        public Duration(int d)
        {
            Hours = d / 3600;
            minuites = (d-(Hours*3600))/60;
            seconds = d-(Hours*3600)-(Min*60);
        }
        public void print()
        {
            Console.WriteLine($" Hours: {Hours}, Minutes : {Min} , Seconds : {Seconds}");

            //if (Hours/3600>1&&Min/60>1)
            //{
            //    Console.WriteLine($" Hours: {Hours}, Minutes : {Min} , Seconds : {Seconds}");
            //}
            //else if(Hours / 3600< 1 && Min / 60 > 1)
            //{
            //    Console.WriteLine($" Hours: {0}, Minutes : {Min} , Seconds : {Seconds}");

            //}
            //else if(Hours / 3600 < 1 && Min / 60< 1)
            //{
            //    Console.WriteLine($" Hours: {Hours}, Minutes : {0} , Seconds : {Seconds}");

            //}
        }
        public static Duration operator +(Duration _d1, Duration _d2)
        {
            return new Duration()
            {
                Hours = _d1.Hours + _d2.Hours,
                Min = _d1.Min + _d2.Min,
                Seconds = _d1.Seconds + _d2.Seconds
            };

        }
        public static Duration operator +(Duration _d1, int d)
        { 
            int h = d / 3600;
            int m = (d - (h * 3600)) / 60;
            int s = d - ((h * 3600) - (m * 60));
            return new Duration()
            {
                Hours = _d1.Hours + h,
                Min = _d1.Min + m,
                Seconds = _d1.Seconds + s
            };
            

        }

        public static bool operator >(Duration d1, Duration d2)
        {
            //if (_stdone.Salary > _stdtwo.Salary) return true;
            //else return false;
            if (d1.Hours > d2.Hours)
                return true;
            else if (d1.Hours == d2.Hours && d1.Min > d2.Min)
                return true;
            else if (d1.Hours == d2.Hours && d1.Min == d2.Min && d1.Seconds > d2.Seconds)
                return true;
            else return false;
        }
        public static bool operator <(Duration d1, Duration d2)
        {
            if (d1.Hours < d2.Hours)
                return true;
            else if (d1.Hours == d2.Hours && d1.Min < d2.Min)
                return true;
            else if (d1.Hours == d2.Hours && d1.Min == d2.Min && d1.Seconds < d2.Seconds)
                return true;
            else return false;

        }
        public static bool operator >=(Duration d1, Duration d2)
        {
            if (d1.Hours > d2.Hours|| d1.Hours == d2.Hours)
                return true;
            else if (d1.Hours == d2.Hours && (d1.Min > d2.Min|| d1.Min == d2.Min))
                return true;
            else if (d1.Hours == d2.Hours && d1.Min == d2.Min && (d1.Seconds > d2.Seconds||d1.Seconds==d2.Seconds))
                return true;
            else return false;
        }
        public static bool operator <=(Duration d1, Duration d2)
        {
            if (d1.Hours < d2.Hours|| d1.Hours == d2.Hours)
                return true;
            else if (d1.Hours == d2.Hours && (d1.Min < d2.Min||d1.Min == d2.Min))
                return true;
            else if (d1.Hours == d2.Hours && d1.Min == d2.Min &&( d1.Seconds < d2.Seconds|| d1.Seconds==d2.Seconds))
                return true;
            else return false;

        }
    }
}
