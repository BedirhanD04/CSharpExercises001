using System;

namespace Multiplikationstabel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nHvilken figur vil du beregne arealet af? (Trekant, Rektangel, Cirkel):");
                string svar = Console.ReadLine();

                if (string.IsNullOrEmpty(svar))
                {
                    break;
                }

                if (svar == "Trekant")
                {
                    Console.Write("Indtast grundlinje: ");
                    double grund = double.Parse(Console.ReadLine());

                    Console.Write("Indtast højde: ");
                    double højde = double.Parse(Console.ReadLine());

                    double areal = (grund * højde) / 2;
                    Console.WriteLine($"Areal: {areal:F6}");
                }
                else if (svar == "Rektangel")
                {
                    Console.Write("Indtast bredde: ");
                    double bredde = double.Parse(Console.ReadLine());

                    Console.Write("Indtast højde: ");
                    double højde = double.Parse(Console.ReadLine());

                    double areal = bredde * højde;
                    Console.WriteLine($"Areal: {areal:F6}");
                }
                else if (svar == "Cirkel")
                {
                    Console.Write("Indtast radius: ");
                    double radius = double.Parse(Console.ReadLine());

                    double areal = Math.PI * radius * radius;
                    Console.WriteLine($"Areal: {areal:F6}");
                }
                else
                {
                    Console.WriteLine("Ukendt figur!");
                }
            }
        }
    }
}