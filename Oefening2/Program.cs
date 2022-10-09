using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Oefening2;

namespace Oefening2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ik maak een nieuwe form aan.
             Mijn eerdere form wou niet opstarten,
            maar gaf ook geen foutmeldingen.
            Door een nieuwe form te maken, is dit opgelost.*/
            Form1 form = new Form1();
            form.ShowDialog();

            /*Ik maak een koe aan.
             Vervolgens voer ik de Zegt() functie uit op deze specifieke koe.*/
            Koe koe1 = new Koe(14, @"C:\Users\Sam\Documentscdierengeluiden\koe.mp3");
            koe1.Zegt();

            /*Ik maak een varken aan.
             Vervolgens voer ik de Zegt() functie uit op deze specifieke varken.*/
            Varken varken1 = new Varken(28, "C:\\Users\\Sam\\Documentscdierengeluiden\\koe.mp3");
            varken1.Zegt();

            /*Ik maak een slang aan.
             Vervolgens voer ik de Zegt() functie uit op deze specifieke slang.*/
            Slang slang1 = new Slang(5, "C:\\Users\\Sam\\Documentscdierengeluiden\\koe.mp3");
            slang1.Zegt();

            /*Door Console.ReadLine() te gebruiken vermeid ik dat de console meteen sluit,
             na het printen van de informatie.
            Door dit lijntje moet de gebruiker één toets indrukken alvorens de console
            wordt afgesloten.*/
            Console.ReadLine();

        }
    }
}
