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
            Random r = new Random(); // ezt az r randomot használom fel az összes feladatban

            //1
            for (int i = 0; i < 20; i++)
            {
                int randomSzam = r.Next(71)-50;
                Console.Write($"{randomSzam} ");
                if (i == 9)
                {
                    Console.WriteLine();
                }
            }

            //2.
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
            {
                int randomSzam = r.Next(71) - 50;
                Console.Write($"{randomSzam} ");
                if (i == 4 || i==9 || i==14)
                {
                    Console.WriteLine();
                }
            }

            //3.
            Console.WriteLine();
            bool bentamaradasiFeltetel = true;
            while (bentamaradasiFeltetel)
            {
                int randomSzam = r.Next(201) - 100; //[-100,100]
                Console.Write($"{randomSzam} ");

                if (randomSzam%3==0)
                {
                    bentamaradasiFeltetel = false;
                }
            }

            //4.
            Console.WriteLine();
            Console.Write("Szam: ");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <=szam1; i++)
            {
                Console.Write($"{i} ");
            }

            //5.
            Console.WriteLine();
            int a=0, b=0, c=0, d=0, e=0;
            for (int i = 0; i < 20; i++)
            {
                int randomSzam = r.Next(61) +10; //[10,70]
                if (randomSzam%3==0 && randomSzam%5==0)
                {
                    a++;
                }
                if (randomSzam%2==0 || randomSzam % 5 == 0)
                {
                    b++;
                }
                if (randomSzam>10 && randomSzam<30 && randomSzam % 2 !=0)
                {
                    c++;
                }
                if (randomSzam>6 && randomSzam<10)
                {
                    d++;
                }
                if (!(randomSzam>5 && randomSzam%2==0))
                {
                    e++;
                }
            }
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);

            // 6
            bool igaz = true;
            int osszeg = 0;
            int db = 0;
            while (igaz)
            {
                int random = r.Next(117) - 50; //[-50, 66]
                if (random==0) // kilépéshez
                {
                    igaz = false;
                }
                osszeg += random; //összeadom a számokat
                db++;
            }
            double atlag = osszeg / Convert.ToDouble(db);
            Console.WriteLine(Math.Round(atlag,2));
            
            Console.ReadKey();
        }
    }
}


```