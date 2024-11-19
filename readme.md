```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp60
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int a = 0; // páros számok db
            int b = 0; // 3-mal oszthato db
            int c = 0; // páros de nem osztható 4-gyel
            int d = 0; // páratélan, de nem osztható 5-el
            for (int i = 0; i < 5; i++)
            {
                int szam= r.Next(25)+64; //[64,89]
                if (szam%2==0)
                {
                    a++;
                }
                if (szam%3==0)
                {
                    b++;
                }
                if (szam%2==0 && szam%4!=0)
                {
                    c++;
                }
                if (szam % 2 != 0 && szam % 5 != 0)
                {
                    //d-=-1; // d++ d=d-(-1); // d=d+1
                    d++;
                }
            }
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);

            //-----------------------------------------------------------

            Random r2 = new Random();
            int karakter = r2.Next(3); //[0,2]
            switch (karakter)
            {
                case 0: Console.Write("Az űrhajós és a "); break;
                case 1: Console.Write("A tengerész és a "); break;
                case 2: Console.Write("A félszemű fogtündér és a "); break;
            }
            int allat= r2.Next(3); //[0,2]
            switch (allat)
            {
                case 0: Console.Write("delfin "); break;
                case 1: Console.Write("sas "); break;
                case 2: Console.Write("medve "); break;
            }
            int esemeny = r2.Next(3); //[0,2]
            switch (esemeny)
            {
                case 0: Console.WriteLine("holdbázist épít."); break;
                case 1: Console.WriteLine("kincset talál."); break;
                case 2: Console.WriteLine("megszökik a börtönből."); break;
            }

            //----------------------------------------
            bool bentmaradasiFeltetel = true;
            int osszeg = 0;
            int db = 0;
            while (bentmaradasiFeltetel)
            {
                int szam = Convert.ToInt32(Console.ReadLine());
                osszeg += szam;
                db++;
                double atlag = osszeg / (double)db;
                if (atlag>50)
                {
                    bentmaradasiFeltetel = false;
                }
            }
            double atlag2 = osszeg / (double)db;
            Console.WriteLine(atlag2);

            Console.ReadKey();
        }
    }
}

```