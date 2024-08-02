    internal class Program
    {
        static void PrintSeries(int numberOfTerms)
        {
            int start = 10;
            
            for (int i = 0; i < numberOfTerms; i++)
            {
                Console.WriteLine($"{start}");
                start += 2;
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
