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
    public int Gewicht;

    protected System.IO.Stream geluid;

    /*Hier worden de private strings gedeclareerd.*/
    protected string Uitspraak; //Uitspraak bevindt zich niet binnen de constructor.
    public string Geluid()
    {
        System.Media.SoundPlayer geluidAfspeler = new System.Media.SoundPlayer(this.geluid);
        geluidAfspeler.Play();
        return Uitspraak;
    }


    /*Ik maak de constructor voor de supperklasse Dier.
     Deze draagt logischerwijs dezelfde naam als de klasse zelf.*/
    public Dier()
    {
        Gewicht = 0;
        Uitspraak = "";
        geluid = this.geluid;
    }

    /*Ik maak de methode 'Zegt' aan.
     Deze print de inhoud van 'Uitspraak' in de console.
    Ik kreeg een foutmelding in de hoofdklasse wanneer mijn method niet abstract was.
    Eens ik deze op abstract zette, kreeg ik echter opnieuw een foutmelding,
    maar deze keer in de subklassen.
    Wanneer ik er virtual van maakte, was de foutmelding weg.
    Ik weet echter zelf nog niet echt waarom.*/
    public virtual String Zegt()
    {
        return this.Uitspraak;
    }

   

}
