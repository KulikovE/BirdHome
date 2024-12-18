namespace BirdHome
{
    public partial class Form1 : Form
    {
        bool addingBird = true;
        int chastotaPodl, downDelay, upDelay;
        public static List<Bird> birds = new List<Bird>();
        bool close = false;
        public Form1(int valueNum, int downDelay, int upDelay, int chastotaPodl)
        {
            InitializeComponent();
            this.downDelay = downDelay;
            this.upDelay = upDelay;
            this.chastotaPodl = chastotaPodl;
            home1.SemaphoreHome = new Semaphore(valueNum, valueNum);
        }
        private void StartAddingBirds()
        {
            while (addingBird && this.IsHandleCreated)
            {
                Bird bird = new Bird(home1, downDelay, upDelay, vetka1);
                Invoke(new Action(() => { Controls.Add(bird); bird.BringToFront(); birds.Add(bird); }));
                Thread.Sleep(chastotaPodl * 1000);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!close)
            {
                DialogResult dl = MessageBox.Show("Вы действительно хотите закрыть форму?", "Подтверждение закрытия", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dl == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    addingBird = false;
                    e.Cancel = true;
                    Thread Close = new Thread(CloseBird);
                    Close.Start();

                }
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void CloseBird()
        {
            while (birds.Count > 0)
            {
                List<Bird> birdDeleted = new List<Bird>();
                lock (birds)
                {
                    foreach (Bird bird in birds)
                    {
                        if (!bird.feedingNow)
                        {
                            bird.Stop(); // Остановка потока птицы
                            birdDeleted.Add(bird);
                        }
                    }
                    foreach (Bird bird in birdDeleted)
                    {
                        Invoke(() =>
                        {
                            Controls.Remove(bird);
                            birds.Remove(bird);
                            bird.Dispose();
                        });
                    }
                }
            }
            Invoke(new Action(() => { close = true; this.Close();  }));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread addBirdsThread = new Thread(StartAddingBirds);
            addBirdsThread.Start();
        }
    }
}
