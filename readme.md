```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp64
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            // hozzunk létre egy 3 rekeszes tömböt
            // ebben 3 elemet tudok elhelyezni, a tömbnek mindig meg kell adni a hosszát
            // a hossza, azaz a tároló kapacitása fix! Attól nem lehet kisebb de nagyobb sem
            // arra majd ott lesz a lista, annak a tárolókapacitása, azaz a hossza dinamikusan tud nőni, meg csökkenni
            // mivel int tömböt hoztam létre, kezdetben [0,0,0]-val töltődik fel
            int[] tomb = new int[3];

            // egy tömbnek lekérdezhető a hossza
            Console.WriteLine(tomb.Length); // 3

            // egy 3 elemű tömbnek a tárolórekeszeit a 
            // tömb[0], tomb[1], tomb[2]-vel tudjuk lehivatkozni
            // tomb[-1] nem létezik, de tomb[3] sem, 3 elemű tömb esetében
            // ha olyan rekeszt hivatkoznk le, mely túl mutat a tömbhöz tartozó rekeszeken
            // akkor out of the range errort kapok, pl a 3 elemű tömb esetében ezekkel: tomb[-1], tomb[3] 

            // tömb első elemének lehivatkozása
            Console.WriteLine(tomb[0]); // első elemet a 0. indexel tudom lehivatkozni
            // tömb utolsó elemének a lehivatkozása, ha tudom, hogy 3 elmű, akkor index szerint a 2. az utolsó rekesz
            Console.WriteLine(tomb[2]);
            // de az is lehet, hogy nem tudom előre hogy hány elemű a tömb, 
            //ezért ismerünk kell egy technikát, annak a megállapítására, hogy hogyan tudom a tömb utolsó elemét leheivatkozni
            // tömbnek a hossza -1, azaz, tomb.length-1, azaz miivel a tömb length az 3, akkor
            // a tomb.length-1 valójában 3-1, azaz 2, mint a fentebbi rekesz lehivatkozásnál tettük
            // viszont bármilyen hosszú legyen a tömb, ezzel a technikával le tudom hivatkozni, garantáltan mindig annak az utolsó elemét
            Console.WriteLine(tomb[tomb.Length-1]);
            
           
            // töltsük fel a tömb elemeit [60, 82]-es intervallumbéli számokkal
            tomb[0] = r.Next(23) + 60; // tömb első rekeszébe rakok értéket
            tomb[1] = r.Next(23) + 60; // tömb második rekeszébe rakok értéket
            tomb[2] = r.Next(23) + 60; // tömb harmadik rekeszébe rakok értéket


            // EZ MIND SZÉP ÉS JÓ... de nekün valszeg nem mindig 3 elemű tömbbel kell dolgoznunk
            // hanem akár 1000, 10000 eleművel, én nem állnék neki ciklus nélkül feltöltögetni az összes rekeszt

            // használjunk ciklust, amely dinamikusan generálja a tomb[0], tomb[1], tomb[2]-nél használt index értékeket, azaz 0,1,2-t

            // pl ilyesmi ciklus tök jó lenne:
            // ez majd segít lehivatkozni a tömb egy-egy elemét, DINAMIKUSAN
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i); // 0->1->2
            }

            // na most, hogy tudunk ciklust készíteni, tudunk tömbbe értéket tenni, rakjuk össze a kettőt

            // tömb feltöltése
            // a fentebbi 3-as le lett a for ciklusban cserélve a tomb.lenght-re
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(23) + 60;
            }

            //---------------------------------------------
            // dolgozzunk a feltöltött tömbbel!

            // adjuk össze a tömbben lévő értékeket
            int osszeg = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                osszeg += tomb[i];
            }

            // a tömb elemeinek átlaga
            double atlag = osszeg / (double)tomb.Length;

            // melyik a legnagyobb eleme a tömbnek?
            int max = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i]>max)
                {
                    max = tomb[i];
                }
            }
            Console.WriteLine(max);
           


            Console.ReadKey();
        }
    }
}


```