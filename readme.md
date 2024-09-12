```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            // string interpoláció
            string nev = "Anna";
            string datum = "2000";
            Console.WriteLine($"Szia, {nev}! {datum}");
            Console.WriteLine("Szia, {0}! {1}",nev, datum);
            Console.WriteLine("Szia, " + nev + "!" + " " + datum);

            // -----------------------------------------------------

            // bekérek egy számot és eldöntöm, hogy páros vagy páratlan
            Console.WriteLine("Adj meg egy számot");
            int szam = Convert.ToInt32(Console.ReadLine());
            if (szam % 2 == 0) 
            {
                Console.WriteLine($"Ez a szám ({szam}) páros");
            }
            else
            {
                Console.WriteLine($"Ez a szám ({szam}) paratlan");
            }

            // -----------------------------------------------------

            // egyszerű barkóba
            int gep, tipp;
            gep = 4;
            Console.WriteLine("tipp:");
            tipp = Convert.ToInt32(Console.ReadLine());
            if (gep==tipp)
            {
                Console.WriteLine("Eltaláltad");
            }
            else
            {
                Console.WriteLine("Nem találtad el");
                Console.WriteLine("Mert amire én gondoltam: {}");
            }

            // -----------------------------------------------------

            // matematikai műveletek
            // osztáskor LEGALÁBB az egyik tag legyen double
            int a = 2, b = 6;
            int osszeadas = a + b;
            int kivonas = a - b;
            double osztas = a / (double)b;
            int szorzas = a * b;
            Console.WriteLine($"{a} / {b} = {osztas:0.00}");
            Console.WriteLine($"{a} / {b} = {Math.Round(osztas,2)}");
            Console.WriteLine($"{a} / {b} = {osztas}");
            Console.WriteLine($"{a} * {b} = {szorzas}");
            Console.WriteLine($"{a} - {b} = {kivonas}");
            Console.WriteLine($"{a} + {b} = {osszeadas}");
            
            // -----------------------------------------------------

            // Math osztály
            /*
             Math.Round(mit, mennyire) - kerekítés
             Math.Pow(alap, kitevő) - hatvány
             Math.Sqrt(ertek) - négyzetgyökvonás
             Math.PI - PÍÍÍÍ
             */

            // kör területe kerületének kiszámítása
            // az eredményeket 2 tizedesre kell kerekíteni
            double r, T, K; // deklaráció
            r = Convert.ToDouble(Console.ReadLine());

            // Math.PI helyett lehet azt is, hogy (22 / 7.0) vagy 3.14
            T = r * r * Math.PI; // vagy T = Math.Pow(r,2)*Math.PI
            K = 2 * r * Math.PI;

            Console.WriteLine($"T: {T:0.00}");
            Console.WriteLine($"K: {Math.Round(K)}");

            Console.ReadKey(); // azért kell hogy amikor felut a kód, ne záródjon be
        }
    }
}

```