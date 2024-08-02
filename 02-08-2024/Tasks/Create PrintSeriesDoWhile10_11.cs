    internal class Program
    {
        static void PrintSeries(int numberOfTerms)
{
    int start = 10;
    int i = 0;
    do
    {
        Console.WriteLine($"{start += i}");
        i++;
    }
    while (i <= numberOfTerms);
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
