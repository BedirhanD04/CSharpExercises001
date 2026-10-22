namespace Multiplikationstabel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
             
                Console.WriteLine($"tal: {i}, Tredobl: {Tredobl(i)}, Kvadrat: {kvadrat(i)}");
            }
            Console.ReadKey();
        }

        static int Tredobl(int x)
        {
            return x * 3;
        }

        static int kvadrat(int x)
        {
            return x * x;
        }
    }
}