    internal class Program
    {
        static void PrintSeries(int numberOfTerms)
        {
            int start = 10;
            int i = 0;
            while (i <= numberOfTerms)
            {
                Console.WriteLine($"{start += i}");
                i++;
            }
        }

        static void TestSeries()
        {
            int numberOfTerms = int.Parse(Console.ReadLine());
            PrintSeries(numberOfTerms);

        }

        static void Main(string[] args)
        {
            TestSeries();
        }
    }
}
