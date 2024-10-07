using System;

namespace NonPremitives
{
    class Strings
    {
        public static void init()
        {
            var firstName = "Prateek";
            var lastName = "Magarde";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My Name is {0} {1}", firstName, lastName);

            var names = new string[3] { "Prateek", "Magarde", "John" };
            System.Console.WriteLine(myFullName);
            System.Console.WriteLine(string.Join("\n", names));

            var text =
                @"This is my name
            by saying my name loud";
            System.Console.WriteLine(text);
        }
    }
}
