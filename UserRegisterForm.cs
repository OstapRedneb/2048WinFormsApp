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
    public partial class UserRegisterForm : Form
    {
        public UserRegisterForm()
        {
            InitializeComponent();
        }

        private void userLabel_Click(object sender, EventArgs e)
        {

        } // Не трожь!

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Неверный ввод. Пожалуйста введите имя", "Неверный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                User user = new User(nameTextBox.Text);
                GameForm.user = user;
                new GameForm().Show();
                this.Hide();
            }
        }

        private void UserRegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
