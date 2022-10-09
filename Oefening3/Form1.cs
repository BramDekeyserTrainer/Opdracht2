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
    public partial class formCurrencyConvertor : Form
    {
        public formCurrencyConvertor()
        {
            InitializeComponent();
        }

        private void btnConverteer_Click(object sender, EventArgs e)
        {
            //Ik declareer de varia
            double pondWaarde;
            double euroWaarde;
            double rupeesWaarde;
            double yenWaarde;
            double frankWaarde;
            double dollarWaarde;

            /*In de volgende if statements ga ik na welke velden al dan niet leeg zijn.
             Ik laat alles naar alles converteren via de juiste formule.*/
            if (!String.IsNullOrEmpty(tbPound.Text) ||
                !String.IsNullOrEmpty(tbEuro.Text) ||
                !String.IsNullOrEmpty(tbRupees.Text) ||
                !String.IsNullOrEmpty(tbYen.Text) ||
                !String.IsNullOrEmpty(tbUSD.Text)) {
                if (!String.IsNullOrEmpty(tbPound.Text))
                {
                    pondWaarde = Double.Parse(tbPound.Text) * 1.3103;
                    tbUSD.Text = pondWaarde.ToString();
                    tbEuro.Text = (Double.Parse(tbUSD.Text) * 0.86147).ToString();
                    tbRupees.Text = (Double.Parse(tbUSD.Text) * 74.140).ToString();
                    tbYen.Text = (Double.Parse(tbUSD.Text) * 110.99).ToString();
                    tbFrank.Text = (Double.Parse(tbUSD.Text) * 0.9298).ToString();
                }
                else if (!String.IsNullOrEmpty(tbEuro.Text))
                {
                    euroWaarde = Double.Parse(tbPound.Text) * 1.1608;
                    tbUSD.Text = euroWaarde.ToString();
                    tbPound.Text = (Double.Parse(tbUSD.Text) * 0.7369).ToString();
                    tbRupees.Text = (Double.Parse(tbUSD.Text) * 74.140).ToString();
                    tbYen.Text = (Double.Parse(tbUSD.Text) * 110.99).ToString();
                    tbFrank.Text = (Double.Parse(tbUSD.Text) * 0.9298).ToString();
                }
                else if (!String.IsNullOrEmpty(tbRupees.Text))
                {
                    rupeesWaarde = Double.Parse(tbRupees.Text) * 0.013488;
                    tbUSD.Text = rupeesWaarde.ToString();
                    tbPound.Text = (Double.Parse(tbUSD.Text) * 0.7369).ToString();
                    tbEuro.Text = (Double.Parse(tbUSD.Text) * 0.86147).ToString();
                    tbYen.Text = (Double.Parse(tbUSD.Text) * 110.99).ToString();
                    tbFrank.Text = (Double.Parse(tbUSD.Text) * 0.9298).ToString();
                }
                else if (!String.IsNullOrEmpty(tbYen.Text))
                {
                    yenWaarde = Double.Parse(tbYen.Text) * 0.0090098;
                    tbUSD.Text = yenWaarde.ToString();
                    tbPound.Text = (Double.Parse(tbUSD.Text) * 0.7369).ToString();
                    tbEuro.Text = (Double.Parse(tbUSD.Text) * 0.86147).ToString();
                    tbRupees.Text = (Double.Parse(tbUSD.Text) * 74.140).ToString();
                    tbFrank.Text = (Double.Parse(tbUSD.Text) * 0.9298).ToString();
                }
                else if (!String.IsNullOrEmpty(tbFrank.Text))
                {
                    frankWaarde = Double.Parse(tbFrank.Text) * 1.0755;
                    tbUSD.Text = frankWaarde.ToString();
                    tbPound.Text = (Double.Parse(tbUSD.Text) * 0.7369).ToString();
                    tbEuro.Text = (Double.Parse(tbUSD.Text) * 0.86147).ToString();
                    tbRupees.Text = (Double.Parse(tbUSD.Text) * 74.140).ToString();
                    tbYen.Text = (Double.Parse(tbUSD.Text) * 110.99).ToString();
                }



            }
        }
    }
}
