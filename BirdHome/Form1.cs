namespace BirdHome
{
    public partial class Form1 : Form
    {

        bool addingBird = true;
        List<Bird> birdList = new List<Bird>();
        public Form1()
        {
            InitializeComponent();
            Thread addBirdsThread = new Thread(StartAddingBirds);
            addBirdsThread.Start();
        }
        private void StartAddingBirds()
        {
            while (addingBird)
            {
                Bird bird = new Bird(home1);
                Invoke(new Action(() => Controls.Add(bird)));
                birdList.Add(bird);
                Random random = new Random();
                Thread.Sleep(random.Next(5000, 10000)); // Задержка между подлетами птиц, чтобы предотвратить высокую нагрузку
            }
        }


    }
}
