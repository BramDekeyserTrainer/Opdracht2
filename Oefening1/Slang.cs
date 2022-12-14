using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Ik maak de publieke klasse Slang aan.
 Deze erft de informatie over van de supperklasse 'Dier'.*/
public class Slang : Dier
{
    /*De subklasse Slang heeft op haar beurt ook weer een constructor.
 * Ik heb deze constructor automatisch laten genereren.*/
    public Slang(int gewicht) : base()
    {
        this.Gewicht = gewicht;
        Uitspraak = "Sjj";
        Geluid = @"C:\Users\Sam\Documents\waf\slang.wav";
    }

    /*In het geval van de subklasse Slang, wordt de uitspraak,
 die wordt verkregen via getUitspraak(), weergegeven in de console als een string.
Deze string heeft de inhoud 'Sjj'.*/
    public override string Zegt()
    {
        return "Geluid: " + Uitspraak;
    }
}

