using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening3
{
    /*De partial class formCurrencyConertor erft over van Form.*/
    public partial class formCurrencyConvertor : Form
    {
        public formCurrencyConvertor()
        {
            /*Dit is automatische genereerd.
             Het definieert alles wat in de form wordt weergegeven.*/
            InitializeComponent();
        }

        /*De volgende zaken gebeuren wanneer de converteerknop wordt aangeklikt.*/
        private void btnConverteer_Click(object sender, EventArgs e)
        {
            /*Ik declareer de variabelen die ik ga gebruiken om de conerties te berekenen.
             Ik zet deze op double zodat deze als kommagetallen kunnen dienen.*/
            double pondWaarde;
            double euroWaarde;
            double rupeesWaarde;
            double yenWaarde;
            double frankWaarde;
            double dollarWaarde;

            /*Ik maak gebruik van de volgende constanten.*/
            const double maalPond = 1.3103;
            const double maalEuro = 1.1608;
            const double maalRupees = 74.140;
            const double maalYen = 0.0090098;
            const double maalFrank = 1.0755;
            const double maalUSD = 1;

            const double maal1 = 0.86147;
            const double maal2 = 74.140;
            const double maal3 = 110.99;
            const double maal4 = 0.9298;
            const double maal5 = 0.7369;

            /*In de volgende if statements ga ik na welke velden al dan niet leeg zijn.
             Ik lees in wat ingevuld staat zodat ik vervolgens kan omrekenen.
             Ik laat alles naar alles converteren via de juiste formule met behulp van
            de eerder gedeclareerde variabelen.
            Ik gebruik telkens de ToString() function om de doubles om te zetten naar platte tekst.
            Om de ingegeven getallen te kunnen gebruiken in de berekeningen,
            gebruik ik eerst Double.Parse om ze als doubles te kunnen gebruiken.
            Het is pas nadien dat de brekende versies gebruik maken van die eerder genoemde
            ToString() function.*/
            if (!String.IsNullOrEmpty(tbPound.Text) || //Wanneer het tekstveld van de Pond leeg is.
                !String.IsNullOrEmpty(tbEuro.Text) || //Wanneer het tekstveld van de Euro leeg is.
                !String.IsNullOrEmpty(tbRupees.Text) || //Wanneer het tekstveld van de Rupees leeg is.
                !String.IsNullOrEmpty(tbYen.Text) || //Wanneer het tekstveld van de Yen leeg is.
                !String.IsNullOrEmpty(tbUSD.Text)) { //Wanneer het tekstveld van de Dollar leeg is.

                /*Zoals u ziet maak ik gebruik van heel wat if-statements.
                 Destijds heb ik als richtlijn meegekregen om switch-cases te gebruiken,
                in geval van zeven statements of meer.
                Ik weet niet wat uw idee daar omtrent is.
                Ik ben ook niet zeker of dit de manier is waarop u wou dat we het oplosten,
                Maar het lijkt wel te werken.
                In de code hieronder is niet al te veel commentaar vereist aangezien elk if-statement
                heel erg op elkaar lijkt.*/

                /*Voor de omzetting naar de pond.*/
                if (!String.IsNullOrEmpty(tbPound.Text))
                {
                    pondWaarde = Double.Parse(tbPound.Text) * maalPond;
                    tbUSD.Text = pondWaarde.ToString();
                    tbEuro.Text = (Double.Parse(tbUSD.Text) * maal1).ToString();
                    tbRupees.Text = (Double.Parse(tbUSD.Text) * maal2).ToString();
                    tbYen.Text = (Double.Parse(tbUSD.Text) * maal3).ToString();
                    tbFrank.Text = (Double.Parse(tbUSD.Text) * maal4).ToString();
                }

                /*Voor de omzetting naar de euro.*/
                else if (!String.IsNullOrEmpty(tbEuro.Text))
                {
                    euroWaarde = Double.Parse(tbPound.Text) * maalEuro;
                    tbUSD.Text = euroWaarde.ToString();
                    tbPound.Text = (Double.Parse(tbUSD.Text) * maal5).ToString();
                    tbRupees.Text = (Double.Parse(tbUSD.Text) * maal2).ToString();
                    tbYen.Text = (Double.Parse(tbUSD.Text) * maal3).ToString();
                    tbFrank.Text = (Double.Parse(tbUSD.Text) * maal4).ToString();
                }
                else if (!String.IsNullOrEmpty(tbRupees.Text))
                {
                    rupeesWaarde = Double.Parse(tbRupees.Text) * maalRupees;
                    tbUSD.Text = rupeesWaarde.ToString();
                    tbPound.Text = (Double.Parse(tbUSD.Text) * maal5).ToString();
                    tbEuro.Text = (Double.Parse(tbUSD.Text) * maal1).ToString();
                    tbYen.Text = (Double.Parse(tbUSD.Text) * maal3).ToString();
                    tbFrank.Text = (Double.Parse(tbUSD.Text) * maal4).ToString();
                }
                /*Voor de omzetting naar de Yen.*/
                else if (!String.IsNullOrEmpty(tbYen.Text))
                {
                    yenWaarde = Double.Parse(tbYen.Text) * maalYen;
                    tbUSD.Text = yenWaarde.ToString();
                    tbPound.Text = (Double.Parse(tbUSD.Text) * maal5).ToString();
                    tbEuro.Text = (Double.Parse(tbUSD.Text) * maal1).ToString();
                    tbRupees.Text = (Double.Parse(tbUSD.Text) * maal2).ToString();
                    tbFrank.Text = (Double.Parse(tbUSD.Text) * maal4).ToString();
                }

                /*Voor de omzetting naar de Frank.*/
                else if (!String.IsNullOrEmpty(tbFrank.Text))
                {
                    frankWaarde = Double.Parse(tbFrank.Text) * maalFrank;
                    tbUSD.Text = frankWaarde.ToString();
                    tbPound.Text = (Double.Parse(tbUSD.Text) * maal5).ToString();
                    tbEuro.Text = (Double.Parse(tbUSD.Text) * maal1).ToString();
                    tbRupees.Text = (Double.Parse(tbUSD.Text) * maal2).ToString();
                    tbYen.Text = (Double.Parse(tbUSD.Text) * maal3).ToString();
                }

                /*Voor de omzetting naar de Euro.*/
                else if (!String.IsNullOrEmpty(tbUSD.Text))
                {
                    dollarWaarde = Double.Parse(tbUSD.Text) * maalUSD;
                    tbUSD.Text = dollarWaarde.ToString();
                    tbPound.Text = (Double.Parse(tbUSD.Text) * maal5).ToString();
                    tbRupees.Text = (Double.Parse(tbUSD.Text) * maal2).ToString();
                    tbEuro.Text = (Double.Parse(tbUSD.Text) * maal1).ToString();
                    tbYen.Text = (Double.Parse(tbUSD.Text) * maal3).ToString();
                    tbFrank.Text = (Double.Parse(tbUSD.Text) * maal4).ToString();
                }



            }
        }
    }
}
