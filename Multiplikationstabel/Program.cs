namespace Multiplikationstabel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                int tredoblResult = Tredobl(i);
                int kvadraResult = kvadrat(i);

                if (kvadraResult > tredoblResult)
                {
                    break;
                }

                Console.WriteLine($"Tal: {i}, Tredobl: {tredoblResult}, Kvadrat: {kvadraResult}");
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