using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BirdHome
{
    public partial class Home : UserControl
    {
        Semaphore semaphore = new Semaphore(3,3);

        uint countBird;
        public uint CountBird { get { return countBird; } set {countBird = value; textBox1.Text = value.ToString(); } }
        public Home()
        {
            InitializeComponent();
        }

        public Semaphore SemaphoreHome { get {  //textBox1.Text = semaphore.Release(0).ToString(); 
                return semaphore; } set { semaphore = value; } }
    }
}
