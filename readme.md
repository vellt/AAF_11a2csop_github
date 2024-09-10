```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // egysoros kommentet lehet írni
            /*
             több
             soros
             komment
             */

            //---------------------------------------------

            // primitív, értéktípusok
            // stack-->gyors
            // nem tartalmazhat null értéket
            int egeszSzam = 5;
            char karakter = 'a';
            double valosSzam = 6.7;
            bool logikaiTipus = false; //true

            // referencia típus
            // heap --> lassabb
            // tartalmazhat null értéket
            string szoveges = "alma";
            char elsoElem= szoveges[0]; // string első eleme
            char utolsoElem = szoveges[szoveges.Length - 1]; // string utolsó eleme
            szoveges = null; // kaphat null értéket, mert referencia típus!
            char[] karakterTomb = { 'a', 'l', 'm', 'a' }; // karakzertömb
            int[] intTomb = { 1, 2, 3, 4 }; // int tömb

            //---------------------------------------------


            // definiálás
            int g = 6; // deklaráció + értékadás

            // deklaráció
            int u;
            // értékadás
            u = 7;

            //---------------------------------------------

            // konzolművelet 
            // adat kiíratás, adat bekérés, if
            Console.WriteLine("Add meg a korod");
            string szovegesAdat= Console.ReadLine();
            int kor = Convert.ToInt32(szovegesAdat);
            if (kor >= 18) 
            {
                Console.WriteLine("beléphetsz a trafikba");
            }
            else
            {
                Console.WriteLine("Nem léphetsz be");
            }

            //---------------------------------------------

            // konvertálás (pl string-->int)
            int szam = Convert.ToInt32("6");

            // implicit konv (kicsi-->nagy)(pl int-->double)
            double valosSzam2 = 12;

            // explicit konv / Kasztolás (nagy-->kicsi) (pl double-->int)
            int egeszSzam2 = (int)12.6;

            //---------------------------------------------

            // spec karakterek
            /*
             \n - sortörés
             \t - tab
             \" - "
             \\ - 
             */


            Console.WriteLine("Ez egy \"kicsi\" .."); // Ez egy "kicsi" ..
            Console.WriteLine("Ez egy \\kicsi\\ .."); //Ez egy \kicsi\ ..

            Console.ReadKey();
        }
    }
}

```