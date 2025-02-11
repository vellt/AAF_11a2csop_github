using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp136
{
    class Program
    {
        static void Main(string[] args)
        {
            // Adott a következő szöveges tömb, amikbe nevek vannak
            string[] tomb = new string[] { "Kis Béla", "Alma Fa", "Teszt Elek" };

            // 1. feladat: írasd ki a keresztnevek
            for (int i = 0; i < tomb.Length; i++)
            {
                string nev = tomb[i];
                bool szokoz = false;
                for (int j = 0; j < nev.Length; j++)
                {
                    if (nev[j]==' ')
                    {
                        j++;
                        szokoz = true;
                    }
                    if (szokoz==true)
                    {
                        Console.Write(nev[j]);
                    }
                }
                Console.WriteLine();
            }

            // kevesebb kóddal ugyanez:
            for (int i = 0; i < tomb.Length; i++)
            {
                // minden nevet feltördelek szóközök mentén
                // így létrejön egy 2 elemű string tömb
                // ahol a 0. elem a vezetéknék
                // az 1. elem a keresztnév
                string keresztnev = tomb[i].Split(' ')[1];
                Console.WriteLine(keresztnev);
            }


            // 2. feladat: írasd ki a keresztneveknek a hosszát
            for (int i = 0; i < tomb.Length; i++)
            {
                string keresztnev = tomb[i].Split(' ')[1];
                Console.WriteLine(keresztnev.Length);
            }

            // 3. feladat: KINEK a leghosszabb keresztneve
            int max = tomb[0].Split(' ')[1].Length; // kezdetben mondhatjuk, hogy az elsőnek a leghosszabb
            int pozicio=0;
            for (int i = 1; i < tomb.Length; i++)
            {
                int keresztnevHossz = tomb[i].Split(' ')[1].Length;
                if (keresztnevHossz>max)
                {
                    max = keresztnevHossz;
                    pozicio = i;
                }
            }
            Console.WriteLine($"{tomb[pozicio]} a leghosszabb a keresztneve.");


            // 4. feladat: melyik névben van a legtöbb 'e' betű
            int pozicio2 = 0;
            int maxEbetu = 0;
            for (int i = 0; i < tomb.Length; i++) // itt a for ciklust nem 1-ről kezdjük, mert a 0. elemnek is meg kell számolni, hogy mennyi e betű van benne
            {
                string nev = tomb[i].ToLower();
                int szamlalo = 0;
                for (int j = 0; j < nev.Length; j++)
                {
                    if (nev[j]=='e')
                    {
                        szamlalo++;
                    }
                }
                if (maxEbetu<szamlalo)
                {
                    maxEbetu = szamlalo;
                    pozicio2 = i;
                }
            }
            Console.WriteLine($"{tomb[pozicio2]} tartalmazza a legtöbb e betűt.");
            Console.ReadKey();
        }
    }
}
