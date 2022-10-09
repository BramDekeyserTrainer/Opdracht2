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
            Koe koe1 = new Koe(14, "https://www.fesliyanstudios.com/play-mp3/6518");
            koe1.Zegt();

            /*Ik maak een varken aan.
             Vervolgens voer ik de Zegt() functie uit op deze specifieke varken.*/
            Varken varken1 = new Varken(28, "https://www.fesliyanstudios.com/play-mp3/6599");
            varken1.Zegt();

            /*Ik maak een slang aan.
             Vervolgens voer ik de Zegt() functie uit op deze specifieke slang.*/
            Slang slang1 = new Slang(5, "https://www.fesliyanstudios.com/play-mp3/6921");
            slang1.Zegt();

            /*Door Console.ReadLine() te gebruiken vermeid ik dat de console meteen sluit,
             na het printen van de informatie.
            Door dit lijntje moet de gebruiker één toets indrukken alvorens de console
            wordt afgesloten.*/
            Console.ReadLine();

        }
    }
}
