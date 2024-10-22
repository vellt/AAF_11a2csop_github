```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            //int sz1 = r.Next(1, 7); //[1,6]
            int sz2 = r.Next(6)+1; //[1,6]
            switch (sz2)
            {
                case 1: Console.WriteLine("egy"); break;
                case 2: Console.WriteLine("ketto"); break;
                case 3: Console.WriteLine("harom"); break;
                case 4: Console.WriteLine("negy"); break;
                case 5: Console.WriteLine("ot"); break;
                case 6: Console.WriteLine("hat"); break;
            }

            Console.Write("Adj meg egy honapot: ");
            string honap = Console.ReadLine();
            switch (honap)
            {
                case "december": 
                case "január": 
                case "február":
                    Console.WriteLine("tél");
                    break;
                case "március":
                case "április":
                case "május":
                    Console.WriteLine("tavasz");
                    break;
                case "június":
                case "július": 
                case "augusztus":
                    Console.WriteLine("nyár");
                    break;
                case "szeptember": 
                case "október":
                case "november":
                    Console.WriteLine("ősz");
                    break;
            }

            Console.ReadKey();
        }
    }
}

```