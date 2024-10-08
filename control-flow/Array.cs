namespace Arrays
{
    class Program
    {
        static void Init()
        {
            var numbers = new[] { 1, 2, 3, 4 };
            System.Console.WriteLine("Length: " + numbers.Length);

            var index = Array.IndexOf(numbers, 3);
            System.Console.WriteLine(index);

            Array.Clear(numbers, 0, 2);
            System.Console.WriteLine(numbers);

            var newNumbers = new int[3];
            Array.Copy(numbers, newNumbers, 3);

            Array.Sort(newNumbers);

            Array.Reverse(numbers);
        }
    }
}
