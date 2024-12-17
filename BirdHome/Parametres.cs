using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdHome
{
    public partial class Parametres : UserControl
    {
        Home home;
        public Parametres(Home home)
        {
            InitializeComponent();
            this.home = home;
        }

        public int Chastota { get; set; } = 3;

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            Chastota = (int)numericUpDown4.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = numericUpDown2.Value - 1;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
