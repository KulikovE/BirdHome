using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdHome
{
    public partial class Bird : UserControl
    {
        Thread threadBird;
        Home kormushka;
        bool running = true;
        int downDelay = 20, upDelay = 30;
        public Bird(Home home)
        {
            InitializeComponent();
            Left = 0;
            Top = 200;
            DoubleBuffered = true;
            kormushka = home;
            threadBird = new Thread(ServiceBird);
            threadBird.Start();
        }
        //public void Stop() 
        //{ 
        //    running = false; 
        //    threadBird.Join(); 
        //} для завершения

        void ServiceBird()
        {
           
                for (int i = 0; i < 20; i++)
                {
                    Thread.Sleep(500);
                    Invoke(new Action(() => Left += 10));
                }
                if (kormushka.SemaphoreHome.WaitOne(0))
                {
                    Eat();
                }
                else
                {
                    for (int i = 0; i < 20; i++)
                    {
                        Thread.Sleep(500);
                        Invoke(new Action(() => { Left += 10; Top += 10; }));
                    }
                    //Invoke(new Action(() => Visible = false));
                    kormushka.SemaphoreHome.WaitOne();
                    //Invoke(new Action(() => Visible = true));
                    Invoke(new Action(() => Left += 25)); 
                    for (int i = 0; i < 20; i++)
                    {
                        Thread.Sleep(500);
                        Invoke(new Action(() => { Left -= 10; Top -= 10; }));
                    }
                    Eat();
                }
            
        }

        void Eat()
        {
            Invoke(new Action(() => Visible = false));
            Random random = new Random();
            Thread.Sleep(random.Next(downDelay*1000, upDelay*1000));
            int a = kormushka.SemaphoreHome.Release();
            Invoke(new Action(() => textBox1.Text = a.ToString()));
            Invoke(new Action(() => { Visible = true; Left += kormushka.Size.Width; }));
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(500);
                Invoke(new Action(() => { Left += 5; Top -= 5; }));
            }
            //Dispose();
        }
    }
}
