using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp126
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] adatok = File.ReadAllLines("hegycsucsok.txt");
                Console.WriteLine("\n1. feladat: A fájl sikeresen beolvasva.");

                Console.WriteLine($"\n2. feladat: sorok száma: {adatok.Length}");

                Console.WriteLine("\n3. feladat:");
                for (int i = 0; i < adatok.Length; i++)
                {
                    Console.Write($"{(i+1).ToString("00")}. {adatok[i],-20} ");
                    if ((i+1)%4==0)
                    {
                        Console.WriteLine();
                    }
                }

                Console.Write("\n4. feladat: ");
                string elsoElem = adatok[0];
                string utolsoElem = adatok[adatok.Length - 1];

                bool feltetel = elsoElem == utolsoElem;
                Console.ForegroundColor = (feltetel) ? ConsoleColor.Green : ConsoleColor.Red;
                Console.WriteLine((feltetel) ? "igen" : "nem");
                Console.ResetColor();

                Console.WriteLine("\n5. feladat: ");
                for (int i = 0; i < adatok.Length; i++)
                {
                    if (adatok[i].Length<8)
                    {
                        Console.WriteLine(adatok[i]);
                    }
                }

                Console.Write("\n6. feladat: Add meg a hegycsúcs nevét: ");
                string hegycsucs = Console.ReadLine();

                bool talalat = false;
                for (int i = 0; i < adatok.Length && talalat==false; i++)
                {
                    string adat = adatok[i].ToLower();
                    if (adat==hegycsucs.ToLower())
                    {
                        talalat = true;
                    }
                }

                Console.ForegroundColor = (talalat) ? ConsoleColor.Green : ConsoleColor.Red;
                Console.WriteLine((talalat)?"Szerepel a fájlban":"Nem szerepel a fájlban");
                Console.ResetColor();

                Console.Write("\n7. feladat: ");
                bool mindegyik = true;
                for (int i = 0; i < adatok.Length && mindegyik==true; i++)
                {
                    if (adatok[i].Length>=10)
                    {
                        mindegyik = false;
                    }
                }
                Console.ForegroundColor = (mindegyik) ? ConsoleColor.Green : ConsoleColor.Red;
                Console.WriteLine((mindegyik) ? "Mindegyik 10 alatti" : "Nem mindegyik 10 alatti");
                Console.ResetColor();

                Console.Write("\n8. feladat: ");
                int kotojelesSzavak = 0;
                for (int i = 0; i < adatok.Length; i++)
                {
                    string adat = adatok[i];
                    bool van = false;
                    for (int j = 0; j < adat.Length && van==false; j++)
                    {
                        char karakter = adat[j];
                        if (karakter=='-')
                        {
                            van = true;
                        }
                    }
                    if (van==true)
                    {
                        kotojelesSzavak++;
                    }
                }
                Console.WriteLine(kotojelesSzavak);

                Console.Write("9. feladat: Keresendő szó: ");
                string szoreszlet = Console.ReadLine();
                int szamlalo = 0;
                for (int i = 0; i < adatok.Length; i++)
                {
                    string adat = adatok[i];
                    bool tartalmazza = false;
                    for (int j = 0; j < adat.Length-szoreszlet.Length+1 && tartalmazza==false; j++)
                    {
                        string variacio = "";
                        for (int k = 0; k < szoreszlet.Length; k++)
                        {
                            variacio += adat[j + k];
                        }
                        if (variacio.ToLower() == szoreszlet.ToLower())
                        {
                            tartalmazza = true;
                        }
                    }
                    if (tartalmazza)
                    {
                        szamlalo++;
                    }
                }
                Console.WriteLine($"Találatok száma: {szamlalo} db");


                Console.Write("\n10. feladat: ");
                int maxIndex = 0;
                for (int i = 0; i < adatok.Length; i++)
                {
                    if (adatok[maxIndex].Length<adatok[i].Length)
                    {
                        maxIndex = i;
                    }
                }
                Console.WriteLine(adatok[maxIndex]);

                Console.Write("\n11. feladat: ");
                int ossz = 0;
                for (int i = 0; i < adatok.Length; i++)
                {
                    ossz += adatok[i].Length;
                }
                double atlag = ossz / (double)adatok.Length;
                Console.WriteLine(Math.Round(atlag,2));
            }
            catch (Exception)
            {
                Console.WriteLine("\n1. feladat: hiba történt a fájl beolvasása során");
            }
            finally
            {
                Console.ReadKey();
            }

        }
    }
}
