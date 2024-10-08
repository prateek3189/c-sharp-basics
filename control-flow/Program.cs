using System;

namespace DateTimeNameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2000, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            var tomorrow = now.AddDays(1); // Tomorrow
            var yesterday = now.AddDays(-1); // Yesterday

            // System.Console.WriteLine(now.ToLongDateString());
            // System.Console.WriteLine(now.ToShortDateString());
            // System.Console.WriteLine(now.ToLongTimeString());
            // System.Console.WriteLine(now.ToShortTimeString());
            // System.Console.WriteLine(now.ToString("yyyy-mm-dd"));

            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan2 = new TimeSpan(1, 0, 0);
            var timeSpan3 = TimeSpan.FromHours(1);
        }
    }
}
