using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2048ClassLibrary;

namespace _2048WinFormsApp
{
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            List<User> users = FileWorker.GetUsersList();
            List<User> bestUsers = GetBestUsers(users);
            bestUsers.Sort();
            bestUsers.Reverse();
            bestResultLabel.Text = string.Join("\n", bestUsers);
            resultsLabel.Text = string.Join ("\n", users);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new MainMenuForm().Show();
            this.Close();
        }
        public List<User> GetBestUsers(List<User> users) 
        {
            if (users.Count <= 3) 
                return users;
            users.Sort();
            return users.Slice(users.Count - 3, 3);
        }
    }
}
