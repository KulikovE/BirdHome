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
    public partial class Home : UserControl
    {
        Semaphore semaphore = new Semaphore(3,3);
        public Home()
        {
            InitializeComponent();
        }

        public Semaphore SemaphoreHome { get {  //textBox1.Text = semaphore.Release(0).ToString(); 
                return semaphore; } }
    }
}
