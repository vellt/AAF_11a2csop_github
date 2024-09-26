```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a, b;
            Console.Write("Add meg az A értékét: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Add meg az B értékét: ");
            b = Convert.ToInt32(Console.ReadLine());

            int osszeg = a + b;
            int kulonbseg = a - b;
            
            Console.WriteLine($"{a} - {b} = {kulonbseg}");
            Console.WriteLine($"{a} + {b} = {osszeg}");
            
            // -----------------------------------------------------
            
            int a, b;
            Console.Write("Add meg az a értékét: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Add meg az b értékét: ");
            b = Convert.ToInt32(Console.ReadLine());

            int szorzas = a * b;
            double hanyados = (double)a / b;

            Console.WriteLine($"{a} * {b} = {szorzas}");
            Console.WriteLine($"{a} / {b} = {hanyados:0.00}");

            // -----------------------------------------------------
            
            int F, C;
            Console.Write("Add meg az C értékét: ");
            C = Convert.ToInt32(Console.ReadLine());

            F = (int)(C * (9.0 / 5) + 32);

            Console.WriteLine($"A {C} értéke átváltva Fahreheitra: {F}");
            
            // -----------------------------------------------------

            int C, F;
            Console.Write("Adj meg egy számot: ");
            F = Convert.ToInt32(Console.ReadLine());

            C = (int)((F - 32) * 5 / 9.0);

            Console.WriteLine($"C: {C}");
        
            // -----------------------------------------------------
        
            double a, b, K, T;
            Console.Write("Add meg az 'a' értékét: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Add meg a 'b' értékét: ");
            b = Convert.ToDouble(Console.ReadLine());

            K = 2 * (a + b);
            T = a * b;

            Console.WriteLine($"A téglalap kerülete {K:0.0000}");
            Console.WriteLine($"A téglalap területe {Math.Round(T,4)}");

            // -----------------------------------------------------

            double A, V, a;
            Console.Write("Add meg az a értékét: ");
            a = Convert.ToDouble(Console.ReadLine());

            A = 6 * Math.Pow(a, 2);
            V = Math.Pow(a, 3);

            Console.WriteLine($"a = {a}, A= {Math.Round(A, 3)}, V = {Math.Round(V,3)}");
            
            // -----------------------------------------------------

            double A, V, a, b, c;
            Console.Write("Add meg az a értékét: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Add meg az b értékét: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Add meg az c értékét: ");
            c = Convert.ToDouble(Console.ReadLine());

            A = 2 * (a * b) + 2 * (a * c) + 2 * (b * c);
            V = a * b * c;

            Console.WriteLine($"A téglatest kerülete: {Math.Round(A, 2)}");
            Console.WriteLine($"A téglatest térfogata: {Math.Round(V, 2)}");

            // -----------------------------------------------------
            
            // ilyen jellegű feladatra NEM kell számítani az első dogában, 
            // érdekességnek szántam a modulusz felhasználási köre miatt, 
            // ilyeneket használnak a pénztárak (pl tankoláskor a mol-nál..)
            // mikor a kasszánál vagyunk és mondjuk, hogy készpénzzel fizetnénk:
            Console.Write("Add meg az összeget: ");
            string osszeg = Console.ReadLine();
            char utolsoKarakter = osszeg[osszeg.Length - 1];
            int mod = Convert.ToInt32(utolsoKarakter.ToString()) % 5;
            if (mod <= 2)
            {
                Console.WriteLine(Convert.ToInt32(osszeg) - mod);
            }
            else
            {
                Console.WriteLine(Convert.ToInt32(osszeg) - mod + 5);
            }

            // -----------------------------------------------------

            int a;
            Console.Write("Írj be egy számot: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Ez a szám 0");
            }
            else if (a % 2 == 0)
            {
                Console.WriteLine("Ez a szám pozitív");
            }
            else if (a % 2 != 0)
            {
                Console.WriteLine("Ez a szám negatív");
            }

            // -----------------------------------------------------

            int a;
            Console.WriteLine("adj meg egy számot: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 3 == 0)
            {
                Console.WriteLine("Ez a szám osztólya 3-nak ");
            }
            else
            {
                Console.WriteLine("Ez a szám nem osztólay 3-nak");
            }
            
            // -----------------------------------------------------

            int x, y;
            Console.WriteLine("Add meg a koordináta x értékét: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add meg a koordináta y értékét: ");
            y = Convert.ToInt32(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("A koordináta az első síkban van");
            }
            else if(x < 0 && y < 0)
            {
                Console.WriteLine("A harmadik síkban van");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("A negyedik síkban van");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("A második síkban van");
            }
            else 
            { 
                Console.WriteLine("Az origon van :/ "); 
            }

            Console.ReadKey();

        }
    
    }
}

```
