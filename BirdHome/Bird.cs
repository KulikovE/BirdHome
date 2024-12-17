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
using System.Windows.Forms.VisualStyles;

namespace BirdHome
{
    public partial class Bird : UserControl
    {
        Thread threadBird;
        Home kormushka;
        Vetka vetka;
        public int DownDelay { get; set; }
        public int UpDelay { get; set; }
        bool fly = true;
        bool feedingNow = false;
        public Bird(Home home, int downDelay, int upDelay, Vetka vetka)
        {
            InitializeComponent();
            DoubleBuffered = true;
            DownDelay = downDelay;
            UpDelay = upDelay;
            kormushka = home;
            this.vetka = vetka;
            Left = 0;
            Top = kormushka.Top+this.Height;
            threadBird = new Thread(ServiceBird);
            threadBird.Start();
        }
        public void Stop()
        {
            if (feedingNow)
            {
                threadBird.Join();
            }            
        }
       

        void ServiceBird()
        {
            Thread.Sleep(500);
                while(this.Location.X + this.Width < kormushka.Location.X)
                {
                    Invoke(new Action(() => Left += 10));
                    ChangeImage();
                    Thread.Sleep(250);
                }
                if (kormushka.SemaphoreHome.WaitOne(0))
                {
                    Invoke(new Action(() => kormushka.CountBird++));
                    Eat();
                }
                else
                {
                    while(this.Location.X < vetka.Location.X + vetka.Width/4 && this.Location.Y < vetka.Location.Y + vetka.Height / 4) {
                        Invoke(new Action(() => { Left += 10; Top += 10; }));
                        ChangeImage();
                        Thread.Sleep(250);
                    }
                    Invoke(new Action(() => { vetka.CountBird++; Visible = false; }));
                    kormushka.SemaphoreHome.WaitOne();
                    Invoke(new Action(() => { vetka.CountBird--; Visible = true; Left += 25; }));
                while (this.Location.X > kormushka.Location.X )
                {
                    Invoke(new Action(() => { Left -= 10; Top -= 10; }));
                        ChangeImage();
                        Thread.Sleep(250);
                }
                    Invoke(new Action(() => kormushka.CountBird++)); 
                    Eat();
                }
            
        }

        void Eat()
        {
            Invoke(new Action(() => Visible = false));
            Random random = new Random();
            feedingNow = true;
            Thread.Sleep(random.Next(DownDelay*1000, UpDelay*1000));
            feedingNow = false;
            int a = kormushka.SemaphoreHome.Release();
            Invoke(new Action(() => { Visible = true; Left += kormushka.Size.Width; kormushka.CountBird--; }));
            for (int i = 0; i < 40; i++)
            {
                Invoke(new Action(() => { Left += 5; Top -= 5; }));
                ChangeImage();
                Thread.Sleep(250);
            }
            Dispose();
        }

        void ChangeImage()
        {
            Invoke(new Action(() =>
            {
                if (fly)
                {
                    BackgroundImage = Image.FromFile("rb_8.png");
                }
                else
                {
                    BackgroundImage = Image.FromFile("rb_7.png");
                }
                fly = !fly;
            }));
        }
    }
}
