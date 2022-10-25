using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ik maak een koe aan.
             Vervolgens voer ik de Zegt() functie uit op deze specifieke koe.*/
            Koe koe1 = new Koe(14);
            Varken varken1 = new Varken(200);
            Slang slang1 = new Slang(8);

            Console.WriteLine(koe1);
            Console.WriteLine(varken1);
            Console.WriteLine(slang1);

            Console.WriteLine(koe1.Zegt());
            Console.WriteLine(varken1.Zegt());
            Console.WriteLine(slang1.Zegt());
            koe1.Zegt();

            /*Door Console.ReadLine() te gebruiken vermeid ik dat de console meteen sluit,
             na het printen van de informatie.
            Door dit lijntje moet de gebruiker één toets indrukken alvorens de console
            wordt afgesloten.*/
            Console.ReadLine();

        }
    }
}
