```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp79
{
    class Program
    {
        static void Main(string[] args)
        {
            int hossz = Convert.ToInt32(Console.ReadLine());
            if (hossz>=10)
            {
                //tömb létrehozása
                int[] tomb = new int[hossz];

                // feltöltés
                Random r = new Random();
                for (int i = 0; i < tomb.Length; i++)
                {
                    tomb[i] = r.Next(101) - 50;
                }

                // összérték
                int ossz = 0;
                for (int i = 0; i < tomb.Length; i++)
                {
                    ossz += tomb[i];
                }
                Console.WriteLine(ossz);

                // átlag
                double atlag = ossz / (double)tomb.Length;
                Console.WriteLine(Math.Round(atlag,2));

                //mennyi átlag alatti
                int atlagAlatt = 0;
                for (int i = 0; i < tomb.Length; i++)
                {
                    if (tomb[i]<atlag)
                    {
                        atlagAlatt++;
                    }
                }
                Console.WriteLine(atlagAlatt);

                //páros és negatív
                int parosNegativ = 0;
                for (int i = 0; i < tomb.Length; i++)
                {
                    if (tomb[i] % 2 == 0 && tomb[i] < 0) 
                    {
                        parosNegativ++;
                    }
                }
                Console.WriteLine(parosNegativ);

                //számold meg mennyi nulla van benne.
                int nulla = 0;
                for (int i = 0; i < tomb.Length; i++)
                {
                    if (tomb[i]==0)
                    {
                        nulla++;
                    }
                }
                Console.WriteLine(nulla);

                // mi a legnagyobb száma a tömbnek?
                int legnagyobb = tomb[0];
                int index = 0;
                for (int i = 1; i < tomb.Length; i++)
                {
                    if (tomb[i]>legnagyobb)
                    {
                        legnagyobb = tomb[i];
                        index = i;
                    }
                }
                Console.WriteLine(legnagyobb);
                Console.WriteLine(index);

                //összes
                for (int i = 0; i < tomb.Length; i++)
                {
                    Console.Write($"{tomb[i]} ");
                }

                //forditott
                for (int i = tomb.Length - 1; i >= 0; i--)
                {
                    Console.Write($"{tomb[i]} ");
                }

                //abs
                for (int i = 0; i < tomb.Length; i++)
                {
                    Console.Write($"{Math.Abs(tomb[i])} ");
                }

                // négyzet
                for (int i = 0; i < tomb.Length; i++)
                {
                    Console.Write($"{Math.Pow(tomb[i],2)} ");
                }

                // negatív
                for (int i = 0; i < tomb.Length; i++)
                {
                    if (tomb[i] < 0) 
                    {
                        Console.Write($"{tomb[i]} ");
                    }
                }

                // pozitív
                for (int i = 0; i < tomb.Length; i++)
                {
                    if (tomb[i] > 0)
                    {
                        Console.Write($"{tomb[i]} ");
                    }
                }

                // pozitív és páros
                for (int i = 0; i < tomb.Length; i++)
                {
                    if (tomb[i] > 0 && tomb[i] % 2 == 0) 
                    {
                        Console.Write($"{tomb[i]} ");
                    }
                }

                // minden 3.
                for (int i = 0; i < tomb.Length; i++)
                {
                    if ((i+1) %3== 0)
                    {
                        Console.Write($"{tomb[i]} ");
                    }
                }


                // egyedi értékeket
                // szorgalmi


                // Szűrd ki az összes páros számot, és jelenítsd meg a tömb többi értékét
                // egymás mellett szóközzel elválasztva.
                for (int i = 0; i < tomb.Length; i++)
                {
                    if (tomb[i] % 2 != 0) Console.Write($"{tomb[i]} ");
                }

                //Szűrd ki az összes negatív és 7-el nem osztható számokat, és jelenítsd meg a
                // tömb többi értékét egymás mellett szóközzel elválasztva.
                for (int i = 0; i < tomb.Length; i++)
                {
                    if (tomb[i] >= 0 && tomb[i] % 7 == 0) 
                    {
                        Console.Write($"{tomb[i]}, ");
                    }
                }

                //Állapítsd meg, hogy vajon van-e a tömbben 2 és 10 közötti érték.
                Console.WriteLine();
                bool vane = false;
                for (int i = 0; i < tomb.Length && !vane; i++)
                {
                    if (tomb[i] >= 2 && tomb[i] <= 10)
                    {
                        vane = true;
                    }
                }
                Console.WriteLine($"Van 2 és 10 között: {vane}");

                // Állapítsd meg, hogy vajon a tömb minden eleme pozitív-e.
                bool negativ = false;
                for (int i = 0; i < tomb.Length && negativ==false; i++)
                {
                    if (tomb[i] < 0)
                    {
                        negativ = true;
                    }

                   
                }
                Console.WriteLine(negativ?"nem mind pozitív":"mind pozitív");
            }
            else
            {
                Console.WriteLine("a hossznak 10 felettinek kell lennie");
            }

            Console.ReadKey();
        }
    }
}

```