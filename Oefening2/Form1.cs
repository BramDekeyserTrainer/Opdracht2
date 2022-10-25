using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLaatHoren_Click(object sender, EventArgs e)
        {
            Koe voorbeeldKoe = new Koe(150);
            Varken voorbeeldVarken = new Varken(88);
            Slang voorbeeldSlang = new Slang(6);

            if (cbKoeUitspraak.Checked)
            {
                tbKoe.Text = voorbeeldKoe.Zegt();
            }
            else
            { }

            if (cbVarkenUitspraak.Checked)
            {
                tbVarken.Text = voorbeeldVarken.Zegt();
            }
            else
            { }

            if (cbSlangUitspraak.Checked)
            {
                tbSlang.Text = voorbeeldSlang.Zegt();
            }
            else
            { }

            if (cbKoeGeluid.Checked)
            {
                voorbeeldKoe.Geluid();
            }
            else { }

            if (cbVarkenGeluid.Checked)
            {
                voorbeeldVarken.Geluid();
            }
            else { }

            if (cbSlangGeluid.Checked)
            {
                voorbeeldSlang.Geluid();
            }
            else { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
