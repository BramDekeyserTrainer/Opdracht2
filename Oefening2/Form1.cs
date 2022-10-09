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
            Koe voorbeeldKoe = new Koe(150, "https://www.fesliyanstudios.com/play-mp3/6518");
            Varken voorbeeldVarken = new Varken(88, "https://www.fesliyanstudios.com/play-mp3/6599");
            Slang voorbeeldSlang = new Slang(6, "https://www.fesliyanstudios.com/play-mp3/6921");

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
                tbVarken.Text = voorbeeldSlang.Zegt();
            }
            else
            { }

            if (cbKoeGeluid.Checked)
            {
                System.Media.SoundPlayer player = new SoundPlayer(@"C:\Users\Sam\Documents\dierengeluiden\koe.mp3");
                player.Play();
            }
            else { }

            if (cbVarkenGeluid.Checked)
            {
                System.Media.SoundPlayer player = new SoundPlayer(@"C:\Users\Sam\Documents\dierengeluiden\varken.mp3");
                player.Play();
            }
            else { }

            if (cbVarkenGeluid.Checked)
            {
                System.Media.SoundPlayer player = new SoundPlayer(@"C:\Users\Sam\Documents\dierengeluiden\slang.mp3");
                player.Play();
            }
            else { }
        }
    }
}
