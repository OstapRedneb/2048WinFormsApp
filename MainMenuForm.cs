namespace _2048WinFormsApp
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }
        public void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        public void startButton_Click(object sender, EventArgs e)
        {
            new GameForm().Show();
            this.Close();
        }
        public void resultsButton_Click(object sender, EventArgs e)
        {
            new ResultsForm().Show();
            this.Close();
        }
        public void settingsButton_Click(object sender, EventArgs e)
        {
            new SettingsForm().Show();
            this.Close();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
