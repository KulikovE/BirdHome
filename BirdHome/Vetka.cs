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
    public partial class Vetka : UserControl
    {
        int countBird = 0;
        public int CountBird { get { return countBird; } set { countBird = value; textBox1.Text = countBird.ToString(); } }
        public Vetka()
        {
            InitializeComponent();
        }
    }
}
