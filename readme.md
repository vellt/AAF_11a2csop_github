```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            // logikai kapuk
            // és-->&&
            // vagy-->||
            Random r = new Random();
            int a = r.Next(71)+10; //[10,80]
            int b = r.Next(71)+10; //[10,80]
            int c = r.Next(71)+10; //[10,80]
            if (a+b>c && b+c>a && c+a>b)
            {
                Console.WriteLine("szerkeszthető");
            }
            else
            {
                Console.WriteLine("nem szerkeszthető");
            }

            //---------------------------------------------------
            // generáljunk egy számot [1,110] és döntsük el, hogy 
            // vásárolhat az emberünk legót

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");

            Random r2 = new Random();
            int kor= r2.Next(110) + 1; //[1,110]

            if(kor>=6 && kor <= 99)
            {
                Console.WriteLine("megveheted a legot");
            }
            else if (kor>99)
            {
                Console.WriteLine("túl öreg vagy hozzá");
            }
            else
            {
                Console.WriteLine("te túl fiatal vagy!");
            }

            // ----------------------------------------------------------

            // hármas operátor
            // a hármas operátorral rövidíthető a kód
            // abszolút érték, [-100, 100]

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");

            Random r3 = new Random();
            int x= r3.Next(201) - 100;
            // eredeti szám pl -4
            Console.WriteLine(x);

            // 1.0
            if (x<0)
            {
                Console.WriteLine(x*-1); // a -4ből 4-es lesz
            }
            else
            {
                Console.WriteLine(x); // a 4ből 4 lesz
            }
            
            // 2.0
            // ha az if vagy az else egy  valamit csinál a blokkon belül
            // akkor az a blokk {} elhagyható!
            if (x < 0) Console.WriteLine(x*-1);
            else Console.WriteLine(x);

            // 3.0 <-- hármas operátor
            Console.WriteLine((x < 0) ? x * -1 : x);

            //------------------------------------------------------------

            // switch
            // a switch csak összehasonlításra használható amikor if-ben ==-et használnánk

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            // kő-papír
            Random r4 = new Random();
            int gep = r4.Next(3); // [0,2]
            // 0 == kő, 1 == papír, 2 == olló
            Console.WriteLine("Válaszd ki a fegyvered!");
            Console.WriteLine("0 == kő, 1 == papír, 2 == olló");
            Console.Write("Szám: ");
            int felhasznalo = Convert.ToInt32(Console.ReadLine());
            // kiírjuk ki mit választott
            switch (gep)
            {
                case 0: Console.WriteLine("gép: kő"); break;
                case 1: Console.WriteLine("gép: papír"); break;
                default: Console.WriteLine("gép: olló"); break;
            }
            switch (felhasznalo)
            {
                case 0: Console.WriteLine("felhasznalo: kő"); break;
                case 1: Console.WriteLine("felhasznalo: papír"); break;
                default: Console.WriteLine("felhasznalo: olló"); break;
            }
            //játéklogika
            if (gep == 0 && felhasznalo == 2 || 
                gep == 2 && felhasznalo == 1 || 
                gep == 1 && felhasznalo == 0)
            {
                Console.WriteLine("A gép győzött!");
            }
            else if(gep == felhasznalo)
            {
                Console.WriteLine("Döntetlen!");
            }
            else
            {
                Console.WriteLine("A felhasználó nyert!");
            }
            Console.ReadKey();
        }
    }
}

```