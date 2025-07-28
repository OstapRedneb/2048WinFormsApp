namespace _2048WinFormsApp
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }
        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            new UserRegisterForm().Show();
            this.Hide();
        }
        private void resultsButton_Click(object sender, EventArgs e)
        {
            new ResultsForm().Show();
            this.Hide();
        }
        private void settingsButton_Click(object sender, EventArgs e)
        {
            new SettingsForm().Show();
            this.Hide();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
