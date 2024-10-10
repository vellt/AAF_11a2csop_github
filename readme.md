```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y: ");
            y = Convert.ToInt32(Console.ReadLine());

            double a1 = 0.7 * Math.Pow(x, 4) + Math.PI * y;
            double a2 = Math.PI * Math.Pow(y, -4) - Math.Pow(x, 4);

            double b1 = Math.Sqrt(x) + (-2) * (4 * y);
            double b2 = 0.8 * Math.Pow(Math.Pow(y, 6), 1 / 7.0);

            double c1 = (Math.Pow(x, 6) + Math.Pow(y, 4)) / (y + 1);
            double c2 = Math.Pow(x, 5) / (0.4 * y * Math.Sqrt(3 + Math.Pow(x, 2)));

            // osztásnál figyelünk! mit mivel osztunk (zárójelezés), illetve az osztás egyik 
            // tagja double legyen, hogy legyenek tizedeseink, pl 2/6-->0 ami rossz, 
            // helyette azt érjük el hogy az egyik tag double legyen hogy a 2/6-al 0.333333.. legyen
            // pl 
            // 2.0 / 6 vagy 
            // 2 / 6.0 vagy 
            // 2.0 / 6.0 vagy 
            // (double)2 / 6 vagy 
            // 2 / (double)6 vagy 
            // Convert.ToDouble(2) / 6 vagy
            // 2 / Convert.ToDouble(6) vagy
            // Convert.ToDouble(2) / Convert.ToDouble(6) vagy
            // (double)2 / Convert.ToDouble(6) vagy
            // ezek kombinácója!
            double d1 =(3*x-y)/(double)(x-1);
            double d2 =Math.Pow(Math.PI, 1.0/y);

            if (a1>a2)
            {
                // kerekítés két tizedes jegyre: {valtozo:0.00} vagy {Math.Round(valtozo, 2)}
                Console.WriteLine($"{a1:0.00} nagyobb, mint {a2:0.00}");
                Console.WriteLine($"\tEnnyivel: {Math.Round(a1-a2,2)}");
            }
            else if (a1<a2)
            {
                Console.WriteLine($"{Math.Round(a2,2)} nagyobb, mint {a1:0.00}");
                Console.WriteLine($"\tEnnyivel: {(a2 - a1):0.00)}");
            }
            else
            {
                Console.WriteLine("Egyforma");
            }

            // innen csak az if, else-if, else csak ctrl+c és ctrl+v.. csak más változókkal

            Console.ReadKey();
        }
    }
}

```