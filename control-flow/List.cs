namespace List
{
    class Program
    {
        static void Init()
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            numbers.Add(1);

            numbers.AddRange(new int[2] { 1, 2 });
        }
    }
}
