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
        public bool FeedingNow { get; set; } = false;
        public Bird(Home home, int downDelay, int upDelay, Vetka vetka)
        {
            InitializeComponent();
            DoubleBuffered = true;
            DownDelay = downDelay;
            UpDelay = upDelay;
            kormushka = home;
            this.vetka = vetka;
            Left = 0;
            Top = kormushka.Top + this.Height;
        }




        public void Stop()
        {
            if (threadBird != null && threadBird.IsAlive)
            {
                threadBird.Interrupt();
            }
        }



        void ServiceBird()
        {
            try
            {
                while (this.Location.X + this.Width < kormushka.Location.X)
                {
                    Invoke(new Action(() => Left += 10));
                    ChangeImage();
                    Thread.Sleep(20);
                }
                if (kormushka.SemaphoreHome.WaitOne(0))
                {
                    Invoke(new Action(() => kormushka.CountBird++));
                    Eat();
                }
                else
                {
                    while (this.Location.X < vetka.Location.X + vetka.Width / 4 && this.Location.Y < vetka.Location.Y + vetka.Height / 4)
                    {
                        Invoke(new Action(() => { Left += 10; Top += 10; }));
                        ChangeImage();
                        Thread.Sleep(20);
                    }
                    Invoke(new Action(() => { vetka.CountBird++; Visible = false; }));
                    kormushka.SemaphoreHome.WaitOne();
                    Invoke(new Action(() => { vetka.CountBird--; Visible = true; Left += 25; }));
                    while (this.Location.X > kormushka.Location.X)
                    {
                        Invoke(new Action(() => { Left -= 10; Top -= 10; }));
                        ChangeImage();
                        Thread.Sleep(20);
                    }
                    Invoke(new Action(() => kormushka.CountBird++));
                    Eat();
                }

            }
            catch (ThreadInterruptedException)
            {

            }
            finally
            {
                Form1.birds.Remove(this);
                Controls.Remove(this);
                Dispose();
            }

        }

        void Eat()
        {
            FeedingNow = true;
            Invoke(new Action(() => Visible = false));
            Random random = new Random();
            Thread.Sleep(random.Next(DownDelay * 1000, UpDelay * 1000));
            int a = kormushka.SemaphoreHome.Release();
            Invoke(new Action(() => {
                Visible = true;
                Left = kormushka.Location.X + kormushka.Size.Width;
                Top = kormushka.Location.Y + kormushka.Size.Height/2;
                kormushka.CountBird--; }));
            for (int i = 0; i < 40; i++)
            {
                Invoke(new Action(() => { Left += 5; Top -= 5; }));
                ChangeImage();
                Thread.Sleep(250);
            }
            FeedingNow = false;
        }

        void ChangeImage()
        {
            Invoke(new Action(() =>
            {
                if (fly)
                {
                    BackgroundImage = Image.FromFile("img/rb_8.png");
                }
                else
                {
                    BackgroundImage = Image.FromFile("img/rb_7.png");
                }
                fly = !fly;
            }));
        }

        private void Bird_Load(object sender, EventArgs e)
        {
            threadBird = new Thread(ServiceBird);
            threadBird.Start();
        }
    }
}
