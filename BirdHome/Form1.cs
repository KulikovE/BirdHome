namespace BirdHome
{
    public partial class Form1 : Form
    {
        bool addingBird = true;
        int chastotaPodl, downDelay, upDelay;
        List<Bird> birds = new List<Bird>();
        public Form1(int valueNum, int downDelay, int upDelay, int chastotaPodl)
        {
            InitializeComponent();
            this.downDelay = downDelay;
            this.upDelay = upDelay;
            this.chastotaPodl = chastotaPodl;
            home1.SemaphoreHome = new Semaphore(valueNum, valueNum);
            Thread addBirdsThread = new Thread(StartAddingBirds);
            addBirdsThread.Start();
        }
        private void StartAddingBirds()
        {
            Thread.Sleep(100);
            while (addingBird)
            {
                Bird bird = new Bird(home1, downDelay, upDelay, vetka1);
                Invoke(new Action(() => { Controls.Add(bird); bird.BringToFront(); birds.Add(bird); }));
                Thread.Sleep(chastotaPodl * 1000);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Вы действительно хотите закрыть форму?", "Подтверждение закрытия", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.No) 
            { 
                e.Cancel = true;
            }
            else
            {
                addingBird = false;
                foreach (Bird bird in birds)
                {
                    bird.Stop();
                }
            }
        }
    }
}
