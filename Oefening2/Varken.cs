using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Ik maak de publieke klasse Varken aan.
 Deze erft de informatie over van de supperklasse 'Dier'.*/
public class Varken : Dier
{
    /*De subklasse Varken heeft op haar beurt ook weer een constructor.
     * Ik heb deze constructor automatisch laten genereren.*/
    public Varken(int gewicht, string geluid) : base(gewicht, geluid)
    {
    }

    /*In het geval van de subklasse Varken, wordt de uitspraak,
     die wordt verkregen via getUitspraak(), weergegeven in de console als een string.
    Deze string heeft de inhoud 'Groink'.*/
    public override String Zegt()
    {
        return "Groink" + this.getUitspraak();
    }

}

