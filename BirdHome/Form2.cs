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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1((int)numericUpDown1.Value, (int)numericUpDown3.Value, (int)numericUpDown2.Value, (int)numericUpDown4.Value);
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown3.Maximum = numericUpDown2.Value - 1;
        }
    }
}
