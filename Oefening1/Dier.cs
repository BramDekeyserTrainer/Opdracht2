using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

/*Ik maak de abstracte klasse 'Dier' aan.
 Deze klasse is de superklasse van deze console-applicatie.*/
public abstract class Dier
{
    /*De variabele Gewicht is een publieke integer.*/
    public int Gewicht { get; set; }

    /*Hier worden de private strings gedeclareerd.*/
    public string Uitspraak { get; set; } //Uitspraak bevindt zich niet binnen de constructor.
    public string Geluid { get; set; }


    /*Ik maak de constructor voor de supperklasse Dier.
     Deze draagt logischerwijs dezelfde naam als de klasse zelf.*/
    public Dier()
    {
        Gewicht = 0;
        Uitspraak = "";
        Geluid = "";
    }

    /*Ik maak de methode 'Zegt' aan.
     Deze print de inhoud van 'Uitspraak' in de console.
    Ik kreeg een foutmelding in de hoofdklasse wanneer mijn method niet abstract was.
    Eens ik deze op abstract zette, kreeg ik echter opnieuw een foutmelding,
    maar deze keer in de subklassen.
    Wanneer ik er virtual van maakte, was de foutmelding weg.
    Ik weet echter zelf nog niet echt waarom.*/
    public virtual string Zegt()
    {
        return this.Uitspraak;
    }

   

}
