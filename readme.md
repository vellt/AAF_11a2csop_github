```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, V, a;

            Console.WriteLine("Add meg az a értékét");
            a = Convert.ToDouble(Console.ReadLine());

            A = 6 * Math.Pow(a,2);
            V = Math.Pow(a,3);

            Console.WriteLine($"A: {Math.Round(A,4)}");
            Console.WriteLine($"V: {V:0.0000}");

            // ------------------------------------

            double A, V, r, m;

            Console.WriteLine("Add meg az r értékét");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Add meg az m értékét");
            m = Convert.ToDouble(Console.ReadLine());

            A = 2 * Math.Pow(r, 2) * Math.PI + 2 * r * Math.PI;
            V = Math.Pow(r, 2) * Math.PI * m;

            Console.WriteLine($"A: {Math.Round(A,2)}");
            Console.WriteLine($"V: {V:0.00}");
            
            // ------------------------------------

            int x;
            double kGy;

            Console.WriteLine("Add meg az x értékét");
            x = Convert.ToInt32(Console.ReadLine());

            kGy = Math.Pow(x,1/3.0);

            Console.WriteLine($"kGy={Math.Round(kGy,3)}");
           
            // ------------------------------------

            int db_20000, db_10000, db_5000, db_2000, db_1000, db_500;
            Console.Write("20000: ");
            db_20000 = Convert.ToInt32(Console.ReadLine());

            Console.Write("10000: ");
            db_10000 = Convert.ToInt32(Console.ReadLine());

            Console.Write("5000: ");
            db_5000 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2000: ");
            db_2000 = Convert.ToInt32(Console.ReadLine());

            Console.Write("1000: ");
            db_1000 = Convert.ToInt32(Console.ReadLine());

            Console.Write("500: ");
            db_500 = Convert.ToInt32(Console.ReadLine());

            int osszesen = 20_000 * db_20000 + 10_000 * db_10000 + 5_000 * db_5000 + 2_000 * db_2000 + 1_000 * db_1000 + 500 * db_500;
            Console.WriteLine($"Összesen: {osszesen} ft");
            Console.WriteLine($"Bónusz: {osszesen*0.03} ft"); // a bevétel 3%-a
           
            // ------------------------------------
           
            double a, b, c;
            Console.Write("add meg az a értékét");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("add meg a b értékét");
            b = Convert.ToDouble(Console.ReadLine());

            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            //c = Math.Pow(Math.Pow(a, 2) + Math.Pow(b, 2),1/2.0); // hatványazonossággal

            Console.WriteLine($"atfogo:{Math.Round(c, 2)} ");
            
            // ------------------------------------

            Console.Write("Adj egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            if (szam >= 0)
            {
                Console.WriteLine("pozitív");
            }
            else if (szam < 0)
            {
                Console.WriteLine("negatív");
            }
            else if (szam % 2 == 0)
            {
                Console.WriteLine("páros");
            }
            else if (szam % 2 != 0) 
            {
                Console.WriteLine("páratlan");
            }else if(szam % 3 == 0)
            {
                // osztója a 3 a számnak
                Console.WriteLine($"{szam}-ot osztja a 3 maradék nélkül");
            }
            else if(szam % 5 !=0)
            {
                Console.WriteLine($"az 5 nem osztója a {szam}-nak");
            }


            Console.ReadKey(); // azért kell, hogy ne záródjon be a program, ha lefut

        }
    }
}

```