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
    public partial class GameForm : Form
    {
        public static int score = 0;
        public static User user;
        public static int size = 4;
        public static Label[,] map;

        public GameForm()
        {
            InitializeComponent();
            CreateLabelMap();

            this.KeyPreview = true;
            this.Focus();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            CreateRandomNumber();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            user.Result = score;
            score = 0;

            FileWorker.AddUser(user);

            new MainMenuForm().Show();
            this.Close();
        }

        public List<int> CreateNumberList() 
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (string.IsNullOrEmpty(map[i, j].Text)) numbers.Add(size * i + j);
                }
            }

            return numbers;
        }

        public void CreateRandomNumber()
        {
            if (HasEmptyLabel())
            {
                List<int> numbers = CreateNumberList();
                int randomPlaceIndex = new Random().Next(0, numbers.Count - 1);

                map[numbers[randomPlaceIndex] / size, numbers[randomPlaceIndex] % size].Text = CreateTwoOrFour().ToString();
                Update();
            }
            else exitButton_Click(this, new EventArgs());
        }

        public int CreateTwoOrFour()
        {
            if (new Random().Next(1, 4) < 3) return 2;
            return 4;
        }

        public bool HasEmptyLabel()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (string.IsNullOrEmpty(map[i, j].Text)) return true;
                }
            }
            return false;
        }

        public void CreateLabelMap()
        {
            map = new Label[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    int number = size * i + j;

                    map[i, j] = CreateLabel(number, i, j);
                    Controls.Add(map[i, j]);
                }
            }
            CreateForegroung();
        }

        public void CreateForegroung()
        {
            Label foregroundLabel = new Label();
            foregroundLabel.BackColor = Color.FromArgb(0, 0, 64);
            foregroundLabel.ForeColor = SystemColors.ControlText;
            foregroundLabel.Location = new Point(110, 150);
            foregroundLabel.Name = "foregroundLabel";
            foregroundLabel.Size = new Size(471, 471);
            foregroundLabel.TabIndex = 0;

            Controls.Add(foregroundLabel);
        }
        public Label CreateLabel(int number, int i, int j)
        {
            Label label = new Label();
            label.BackColor = Color.White;
            label.Font = new Font("Comic Sans MS", 26.75F * 4 / size, FontStyle.Bold, GraphicsUnit.Point, 204);


            label.Location = new Point(130 + j * (440 / size), 170 + i * (440 / size));


            label.Name = number.ToString();
            label.Size = new Size(360 / size, 360 / size);
            label.TabIndex = 1;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = "";

            return label;
        }

        private void GameForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        public void Update() 
        {
            for (int i = 0; i < size; i++) 
            {
                for (int j = 0; j < size; j++) 
                {
                    if (string.IsNullOrEmpty(map[i, j].Text)) map[i, j].BackColor = Color.White;
                    else 
                    {
                        map[i, j].BackColor = Color.FromArgb(255 / int.Parse(map[i, j].Text) / 10, 255, 255 / int.Parse(map[i, j].Text));
                        if (int.Parse(map[i, j].Text) > 999) map[i, j].Font = new Font("Comic Sans MS", 26.75F * 4 / size - 10 * 4 / size, FontStyle.Bold, GraphicsUnit.Point, 204);
                        if (int.Parse(map[i, j].Text) > 9999) map[i, j].Font = new Font("Comic Sans MS", 26.75F * 4 / size - 13 * 4 / size, FontStyle.Bold, GraphicsUnit.Point, 204);
                        if (int.Parse(map[i, j].Text) > 99999) map[i, j].Font = new Font("Comic Sans MS", 26.75F * 4 / size - 15 * 4 / size, FontStyle.Bold, GraphicsUnit.Point, 204);
                        if (int.Parse(map[i, j].Text) > 999999) map[i, j].Font = new Font("Comic Sans MS", 26.75F * 4 / size - 20 * 4 / size, FontStyle.Bold, GraphicsUnit.Point, 204);
                        if (int.Parse(map[i, j].Text) > 9999999) map[i, j].Font = new Font("Comic Sans MS", 26.75F * 4 / size - 25 * 4 / size, FontStyle.Bold, GraphicsUnit.Point, 204);
                    }
                }
            }
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                for (int i = 0; i < size; i++) 
                {
                    for (int j = size - 2; j >= 0; j--) 
                    {
                        if (string.IsNullOrEmpty(map[i, j].Text)) continue;

                        for (int k = size - 1; k > j; k--) 
                        {
                            if (string.IsNullOrEmpty(map[i, k].Text))
                            {
                                map[i, k].Text = map[i, j].Text;
                                map[i, j].Text = "";
                            }
                            else 
                            {
                                if (map[i, j].Text == map[i, k].Text) 
                                {
                                    map[i, k].Text = (int.Parse(map[i, k].Text) * 2).ToString();
                                    map[i, j].Text = "";
                                    score += int.Parse(map[i, k].Text);
                                    scoreLabel.Text = score.ToString();
                                }
                            }
                        }
                    }
                }

                for (int i = 0; i < size; i++)
                {
                    for (int j = size - 2; j >= 0; j--)
                    {
                        if (string.IsNullOrEmpty(map[i, j].Text)) continue;

                        for (int k = size - 1; k < j; k--)
                        {
                            if (string.IsNullOrEmpty(map[i, k].Text))
                            {
                                map[i, k].Text = map[i, j].Text;
                                map[i, j].Text = "";
                            }
                        }
                    }
                }

                Update();
                CreateRandomNumber();
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 1; j < size; j++)
                    {
                        if (string.IsNullOrEmpty(map[i, j].Text)) continue;

                        for (int k = 0; k < j; k++)
                        {
                            if (string.IsNullOrEmpty(map[i, k].Text))
                            {
                                map[i, k].Text = map[i, j].Text;
                                map[i, j].Text = "";
                            }
                            else
                            {
                                if (map[i, j].Text == map[i, k].Text)
                                {
                                    map[i, k].Text = (int.Parse(map[i, k].Text) * 2).ToString();
                                    map[i, j].Text = "";
                                    score += int.Parse(map[i, k].Text);
                                    scoreLabel.Text = score.ToString();
                                }
                            }
                        }
                    }
                }

                for (int i = 0; i < size; i++)
                {
                    for (int j = 1; j < size; j++)
                    {
                        if (string.IsNullOrEmpty(map[i, j].Text)) continue;

                        for (int k = 0; k < j; k++)
                        {
                            if (string.IsNullOrEmpty(map[i, k].Text))
                            {
                                map[i, k].Text = map[i, j].Text;
                                map[i, j].Text = "";
                            }
                        }
                    }
                }

                Update();
                CreateRandomNumber();
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                for (int j = 0; j < size; j++)
                {
                    for (int i = 1; i < size; i++)
                    {
                        if (string.IsNullOrEmpty(map[i, j].Text)) continue;

                        for (int k = 0; k < i; k++)
                        {
                            if (string.IsNullOrEmpty(map[k, j].Text))
                            {
                                map[k, j].Text = map[i, j].Text;
                                map[i, j].Text = "";
                            }
                            else
                            {
                                if (map[i, j].Text == map[k, j].Text)
                                {
                                    map[k, j].Text = (int.Parse(map[k, j].Text) * 2).ToString();
                                    map[i, j].Text = "";
                                    score += int.Parse(map[k, j].Text);
                                    scoreLabel.Text = score.ToString();
                                }
                            }
                        }
                    }
                }

                for (int i = 0; i < size; i++)
                {
                    for (int j = 1; j < size; j++)
                    {
                        if (string.IsNullOrEmpty(map[i, j].Text)) continue;

                        for (int k = 0; k < i; k++)
                        {
                            if (string.IsNullOrEmpty(map[k, j].Text))
                            {
                                map[k, j].Text = map[i, j].Text;
                                map[i, j].Text = "";
                            }
                        }
                    }
                }

                Update();
                CreateRandomNumber();
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                for (int j = 0; j < size; j++)
                {
                    for (int i = size - 2; i >= 0; i--)
                    {
                        if (string.IsNullOrEmpty(map[i, j].Text)) continue;

                        for (int k = size - 1; k > i; k--)
                        {
                            if (string.IsNullOrEmpty(map[k, j].Text))
                            {
                                map[k, j].Text = map[i, j].Text;
                                map[i, j].Text = "";
                            }
                            else
                            {
                                if (map[i, j].Text == map[k, j].Text)
                                {
                                    map[k, j].Text = (int.Parse(map[k, j].Text) * 2).ToString();
                                    map[i, j].Text = "";
                                    score += int.Parse(map[k, j].Text);
                                    scoreLabel.Text = score.ToString();
                                }
                            }
                        }
                    }
                }

                for (int j = 0; j < size; j++)
                {
                    for (int i = size - 2; i >= 0; i--)
                    {
                        if (string.IsNullOrEmpty(map[i, j].Text)) continue;

                        for (int k = size - 1; k < i; k--)
                        {
                            if (string.IsNullOrEmpty(map[k, j].Text))
                            {
                                map[k, j].Text = map[i, j].Text;
                                map[i, j].Text = "";
                            }
                        }
                    }
                }

                Update();
                CreateRandomNumber();
            }
        }
    }
}
