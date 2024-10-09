```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            // random számok generálása
            Random r = new Random();
            int szam= r.Next(100);
            int szam2 = r.Next(101) - 50; //[-50,50]
            int szam3 = r.Next(6) + 2; // [2,7]
            int szam4 = r.Next(3) + 8; //[8,10]
            int szam5 = r.Next(81); //[0,80]
            int szam6 = r.Next(21)-20; // [-20, 0]
            int szam7 = r.Next(11) -20; //[-20, -10]
            int szam8 = r.Next(71) -50; //[-50, 20]
            // van két paraméteres next is, de azt mi nem fogjuk használni!
            // csak jövőre!
            int szam9 = r.Next(-30, 81); //[-30, 80]

            // --------------------------------------------------------
            // alap, kitevő bekérése, majd hatványozás elvégzése

            Console.Write("Alap: ");
            int alap = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kitevő: ");
            int kitevo = Convert.ToInt32(Console.ReadLine());
            double eredmeny = Math.Round(Math.Pow(alap, kitevo),2);
            
            //----------------------------------------------
            // ciklusok

            // 10x írja ki, hogy alma
            int lepes = 0;
            while (lepes!=10)
            {
                Console.WriteLine("alma");
                lepes++;
            }
            
            // 10-20ig írja ki a számokat
            int szam = 10;
            while (szam != 21)
            {
                Console.WriteLine($"{szam++}"); // postfixes értéknövelés
            }

            // ha postfixesen növelek egy számot kiíratáskor, előbb a régi értéket írja ki, majd
            // megnöveli, pl Console.WriteLine($"{szam++}");

            // ha prefixesen növelek egy számot kiíratáskor, előbb a megnövelt értéket írja már ki
            // pl Console.WriteLine($"{++szam}");

            // egyszerre kettő nem lehet (elől-hátul nem égetjük a gyertyát: ++szam++)

            //-------------------------------------------------------------------
            // a két szélső érték (a,b) között írjuk ki a páros számokat
            int a,b;
            Console.WriteLine("adj meg egy számot");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("adj meg egy b értéket");
            b = Convert.ToInt32(Console.ReadLine());

            while (a!=b)
            {
                a++;
                if (a % 2 == 0) 
                {
                    Console.WriteLine(a);
                }
            }

            //--------------------------------------------------------
            // egy szám számjegyeinek lekérdezése-->kérjük be szövegesen
            // mert akkor rendelkezésre áll nekünk a string tipusoknál egy olyan
            // hogy length
            Console.WriteLine("Adj egy számot");
            string szam = Console.ReadLine();
            Console.WriteLine(szam.Length); // 3 számjegyből áll pl a 107

            // írjuk ki a számjegyeit egymás alá
            Console.WriteLine(szam[0]);
            Console.WriteLine(szam[1]);
            Console.WriteLine(szam[2]);

            // ööö de dinamikusan...
            int i = 0;
            while (i < szam.Length)
            {
                Console.WriteLine(szam[i]);
                i++;
            }

            // számítsuk ki az éves középhőmérsékletet, de előtte kérjük be minden hónap átlag hőmérsékletét
            int honap = 0;
            double osszHomerseklet = 0;
            while (honap<12)
            {
                Console.Write($"{honap+1}. hónap átlaga: ");
                double homerseklet = Convert.ToDouble(Console.ReadLine());
                osszHomerseklet += homerseklet;
                honap++;
            }
            double atlag = osszHomerseklet / 12;
            Console.WriteLine($"Éves középhőmérséklet: {atlag:0.00}");
            
            // -----------------------------------------------------------------------
            // validáljunk telefonszámokat, addig kérjük be a felhasználótól telefonszámot, amíg az hibás
            // ha már valid telefonszámot adott meg a felhasználó, akkor írjuk ki milyen szolgáltatóhoz tartozik
            // a dupla függőleges vonal '|' a logikai vagy.
            // a '!=' az a nem egyenlő
            // a telószám változó string, annak egy elemének a lehivatkozása pl teloszam[0] az karakter típust ad
            // ezért vetem azokat össze Aposztrófok közötti szám karakterekkel pl teloszam[0]!='0'
            Console.Write("telószám: ");
            string teloszam = Console.ReadLine();
            while (teloszam[0]!='0' || teloszam[1]!='6' || teloszam[3]!='0' || teloszam.Length!=11)
            {
                Console.Write("telószám: ");
                teloszam = Console.ReadLine();
            }
            // egyszerű összehasonlító elágazás
            // ha if-el lenne megírva ez pl teloszam[2]=='2' -vel lenne megírva 
            switch (teloszam[2])
            {
                case '2':
                    Console.WriteLine("Yettel");
                    break;
                case '3':
                    Console.WriteLine("Telekom");
                    break;
                case '7':
                    Console.WriteLine("Vodafon");
                    break;
            }

            Console.ReadKey();
            
        }
    }
}

```
