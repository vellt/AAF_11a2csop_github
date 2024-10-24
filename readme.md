```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    class Program
    {
        static void Main(string[] args)
        {
            Bemelegito();
            OnalloFeladatok();
            
            // Kovács Szabolcs Itt járt És Azt mondja hogy Kachao O.o
            Console.ReadKey();
        }

        private static void OnalloFeladatok()
        {
            // Készítsünk egy programot, amely 15db *-ot ír ki a képernyőre egy sorba!
            string star = "*";
            for (int i = 0; i < 15; i++)
            {
                Console.Write($"{star} ");
            }
            Console.WriteLine();


            // Írassa ki a számokat 1-től 20ig és mellé a négyzetüket is.
            for (int i = 1; i <= 20; i++)
            {
                Console.Write($"{i}-->{i * i} ");
            }
            Console.WriteLine();


            // Éves középhőmérséklet kiszámítása ciklussal
            Random r = new Random();
            double szam = 0;
            for (int i = 0; i < 12; i++)
            {
                // ezt elegendő csak egy random egész számmal is, pl 0-20 között
                // viszont itt tiezdesre is gondolt Dominik:
                szam += r.Next(0, 21); // az egész szám pl 6
                szam += r.Next(0, 101) / 100.0; // a tizedes pl 0.23
                
            }
            szam = szam / 12.0; // átlag számítás
            Console.WriteLine(Math.Round(szam, 2));
            Console.WriteLine();


            //Bekér egy számot és kiírja az összes osztóját!
            Console.Write("Adj meg egy számot: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int db = 1;
            while (db != x + 1)
            {
                if (x % db == 0)
                {
                    Console.WriteLine($"{db} osztója az {x}-nak");
                }
                db++;
            }
            Console.WriteLine();


            // Állítsunk elő véletlenszerűen 40 egész számot [-100,100]-ból, és írjuk ki a képernyőre egymás mellé 6 karakternyi helyet lefoglalva, de egy sorban csak 8 szám legyen! A kiíratás végén adjuk meg hány db pozitív szám van!
            int aktSzam;
            for (int i = 0; i < 40; i++)
            {
                if (i % 8 == 0) Console.Write("\n");
                aktSzam = r.Next(201) - 100;
                Console.Write($"{aktSzam,-6}");
            }
            Console.Clear();


            // Írjunk egy hatvány számoló programot. Kérjünk be két egész számot (a,n) a billentyűzetről és írjuk ki az a n. hatványát.
            int a, n;
            Console.WriteLine("Add meg az n-t majd annak a hatványát az a-t értékét");
            a = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            int pow = 1;
            for (int i = 0; i < n; i++)
            {
                pow *= a;
            }
            Console.WriteLine(pow);

        }

        private static void Bemelegito()
        {
            // írj ki 10 random számot [-100, 50] között
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                int randomSzam = r.Next(151) - 100;
                Console.WriteLine(randomSzam);
            }

            int index = 0;
            while (index < 10)
            {
                int randomSzam = r.Next(151) - 100;
                Console.WriteLine(randomSzam);
                index++;
            }

            Console.WriteLine();

            // írj ki 10 [-100, 100] közötti véletlen szám absz értékét
            for (int i = 0; i < 10; i++)
            {
                int randomSzam = r.Next(201) - 100;
                Console.WriteLine(Math.Abs(randomSzam));
            }

            // 10 szám [-10, 50] 
            // számold meg mennyi poz. szám van
            // --//-- mennyi negatív szám
            // --//-- mennyi nulla
            // --//-- mennyi páros
            // --//-- mennyi páratlan
            // --//-- mennyi 6-nál nagyobb
            // --//-- mennyi az átlaguk, 2 tizedesen kiírva
            int pozSzam = 0;
            int negSzam = 0;
            int nulla = 0;
            int paros = 0;
            int paratlan = 0;
            int hattolNagyobb = 0;
            int osszes = 0;
            for (int i = 0; i < 10; i++)
            {
                int randomSzam = r.Next(61) - 10; //[-10, 50] 
                if (randomSzam > 0) pozSzam++;
                if (randomSzam < 0) negSzam++;
                if (randomSzam == 0) nulla++;
                if (randomSzam % 2 == 0) paros++;
                if (randomSzam % 2 != 0) paratlan++;
                if (randomSzam > 6) hattolNagyobb++;
                osszes += randomSzam;
            }
            double atlag = osszes / 10.0;
            Console.WriteLine(pozSzam);
            Console.WriteLine(negSzam);
            Console.WriteLine(nulla);
            Console.WriteLine(paros);
            Console.WriteLine(paratlan);
            Console.WriteLine(hattolNagyobb);
            Console.WriteLine(Math.Round(atlag, 2));
        }
    }
}

```