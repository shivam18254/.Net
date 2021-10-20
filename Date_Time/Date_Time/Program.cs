using System;

namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2000, 05, 22);
            Console.WriteLine("my birthday is {0}", dateTime);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.Now);

            DateTime tomorrow = GetTomorrow();
            Console.WriteLine("Tomorrow will be the {0}", tomorrow);
            Console.WriteLine("today is {0}", DateTime.Today.DayOfWeek);
            Console.WriteLine(GetFirstDayOfYear(2000));

            int day = DateTime.DaysInMonth(2000, 2);
            Console.WriteLine("days in feb 2000: {0} ", day);
            day = DateTime.DaysInMonth(2000, 2);
            Console.WriteLine("days in feb 1999: {0} ", day);
            day = DateTime.DaysInMonth(2007, 2);
            Console.WriteLine("days in feb 2004: {0} ", day);



            DateTime now = DateTime.Now;
            Console.WriteLine("minute {0}: ", now.Minute);

            Console.WriteLine("{0} o'clock {1} minutes and {2} seconds", now.Hour, now.Minute, now.Second);


        }
        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }
        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }

}