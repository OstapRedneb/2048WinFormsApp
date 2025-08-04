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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (!int.TryParse(textBox.Text, out count))
                MessageBox.Show("Нужно ввести число", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (count < 4 || count > 8)
                MessageBox.Show("Нужно ввести число больше 3 и меньше 9", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                GameForm.size = count;
                MessageBox.Show("Размер поля изменён", "Удачно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы точно хотите стереть результаты предыдущих игроков?", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK) FileWorker.Clear();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new MainMenuForm().Show();
            this.Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
