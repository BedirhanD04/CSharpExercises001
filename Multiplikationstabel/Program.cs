namespace Multiplikationstabel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i1 = 1; i1 <= 6; i1++)
            {
                for (int i2 = 1; i2 <= 6; i2++)
                {
                    if (i1 + i2 == 5)
                    {
                        Console.WriteLine($"({i1},{i2})");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}