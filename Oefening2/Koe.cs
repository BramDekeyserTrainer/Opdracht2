﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Ik maak de publieke klasse Koe aan.
 Deze erft de informatie over van de supperklasse 'Dier'.*/
public class Koe : Dier
{
    /*De subklasse Koe heeft op haar beurt ook weer een constructor.
 * Ik heb deze constructor automatisch laten genereren.*/
    public Koe(int gewicht, string geluid) : base(gewicht, geluid)
    {
    }


    /*In het geval van de subklasse Koe, wordt de uitspraak,
 die wordt verkregen via getUitspraak(), weergegeven in de console als een string.
Deze string heeft de inhoud 'Boe'.*/
    public override String Zegt()
    {
        return "Moe " + this.getUitspraak();
    }
}

