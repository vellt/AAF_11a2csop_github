```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp53
{
    class Program
    {
        static void Main(string[] args)
        {
            int kezdoErtek, hossz;

            Console.WriteLine("-------------------------------------------");

            Console.Write("Kezdőérték: ");
            kezdoErtek = Convert.ToInt32(Console.ReadLine());
            Console.Write("hossz: ");
            hossz = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < hossz; i++)
            {
                Console.Write($"{kezdoErtek} ");
                kezdoErtek++;
            }

            Console.WriteLine("-------------------------------------------");

            Console.Write("Kezdőérték: ");
            kezdoErtek = Convert.ToInt32(Console.ReadLine());
            Console.Write("hossz: ");
            hossz = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < hossz * 2; i++)
            {
                if (kezdoErtek % 2 == 0)
                {
                    Console.Write($"{kezdoErtek} ");

                }
                kezdoErtek++;
            }

            Console.WriteLine("-------------------------------------------");

            Console.Write("Kezdőérték: ");
            kezdoErtek = Convert.ToInt32(Console.ReadLine());
            Console.Write("hossz: ");
            hossz = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < hossz *2; i++)
            {
                if (kezdoErtek % 2 != 0)
                {
                    Console.Write($"{kezdoErtek} ");

                }
                kezdoErtek++;
            }

            Console.WriteLine("-------------------------------------------");

            Console.Write("Kezdőérték: ");
            kezdoErtek = Convert.ToInt32(Console.ReadLine());
            Console.Write("hossz: ");
            hossz = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < hossz; i++)
            {
                Console.WriteLine($"{Math.Pow(kezdoErtek, 2)}");
                kezdoErtek++;
            }
            
            Console.WriteLine("-----------");
            Console.Write("Kezdőérték: ");
            kezdoErtek = Convert.ToInt32(Console.ReadLine());
            Console.Write("hossz: ");

            hossz = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < hossz; i++)
            {
                Console.WriteLine($"{Math.Pow(kezdoErtek, 3)}");
                kezdoErtek++;
            }

            Console.WriteLine("-----------");
            Console.Write("Kezdőérték: ");
            kezdoErtek = Convert.ToInt32(Console.ReadLine());
            Console.Write("hossz: ");

            hossz = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < hossz; i++)
            {
                Console.Write($"{kezdoErtek} ");
                kezdoErtek += 4;
            }
            
            Console.WriteLine("-----------");
            Console.Write("Kezdőérték: ");
            kezdoErtek = Convert.ToInt32(Console.ReadLine());
            Console.Write("hossz: ");
            hossz = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < hossz; i++)
            {
                Console.WriteLine($"{kezdoErtek}");
                kezdoErtek *= 2;
            }
            
    
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.Write("Kezdőérték: ");
            kezdoErtek = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hossz: ");
            hossz = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < hossz; i++)
            {
                int negalt = kezdoErtek + i;

                if (i % 2 != 0)
                {
                    negalt = -negalt;
                }
                Console.Write($"{negalt}, ");
            }

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.Write("Kezdőérték: ");
            kezdoErtek = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hossz: ");
            hossz = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < hossz; i++)
            {
                int fakt = 1;
                for (int j = 1; j <= kezdoErtek; j++)
                {
                    fakt *= j;
                }
                Console.Write($"{fakt}, ");
                kezdoErtek++;
            }

            Console.ReadKey();
        }
    }
}

```