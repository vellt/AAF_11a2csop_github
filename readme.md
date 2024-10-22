```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    class Program
    {
        static void Main(string[] args)
        {
            Bevezeto();
            GyakFeladat();

            Console.ReadKey();
        }

        private static void GyakFeladat()
        {
            // 1-10ig egymás mellé szóközzel elválasztva
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i+1} ");
            }
            Console.WriteLine();

            // u.e. while ciklussal
            int i2 = 1;
            while (i2 <= 10)
            {
                Console.Write($"{i2} ");
                i2++;
            }
            Console.WriteLine();

            //--------------------------------------------

            // 10-1ig egymás mellé szóközökkel elválasztva
            for (int i = 10; i > 0; i--)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            // u.e. while ciklussal
            int szamok = 10;
            while (szamok != 0)
            {
                Console.Write($"{szamok--} ");
            }
            Console.WriteLine();

            //--------------------------------------------

            // 50-től 20ig minden 5-el osztható számot!
            szamok = 50;
            while (szamok != 19)
            {
                if(szamok % 5 == 0)
                {
                    Console.Write($"{szamok} ");
                }
                szamok--;
            }
            Console.WriteLine();

            // u.e. for ciklussal
            for (int i = 50; i >= 20; i--)
            {
                if (i%5==0)
                {
                    Console.Write($" {i}");
                }
            }
            Console.WriteLine();

            //--------------------------------------------

            // minden páros szám [40,60]
            for (int i = 40; i < 61; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }
            }

            //--------------------------------------------

            // minden páratlan 10-50ig
            int szam = 10;
            while (szam <= 50)
            {
                if (szam % 2 != 0)
                {
                    Console.Write($"{szam} ");
                }
                szam++;
            }
            Console.WriteLine();

            // u.e. for ciklussal
            for (int i = 10; i < 51; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write($"{i} ");
                }
                
            }
 

        }

        private static void Bevezeto()
        {
            // for ciklus-->Előírt lépésszámú ciklus 
            // do-while-->Hátultesztelős ciklus 
            // while-->Elöltesztelős ciklus 


            // írd ki 10x a nevet amit bekértél

            Console.Write("Add meg a neved: ");
            string nev = Console.ReadLine();

            // for ciklus
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(nev);
            }

            // while - amíg
            int index = 10;
            while (index < 10)
            {
                Console.WriteLine(nev);
                index++;
            }

            // do-while
            int index2 = 10;
            do
            {
                Console.WriteLine(nev);
                index2++;
            } while (index2 < 10);
        }
    }
}

```