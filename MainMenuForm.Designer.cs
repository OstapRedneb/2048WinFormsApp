namespace _2048WinFormsApp
{
    partial class MainMenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            startButton = new Button();
            resultsButton = new Button();
            settingsButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.BackColor = Color.FromArgb(64, 0, 64);
            startButton.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            startButton.ForeColor = Color.RoyalBlue;
            startButton.Location = new Point(258, 12);
            startButton.Name = "startButton";
            startButton.Size = new Size(175, 85);
            startButton.TabIndex = 0;
            startButton.Text = "Начать";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // resultsButton
            // 
            resultsButton.BackColor = Color.FromArgb(64, 0, 64);
            resultsButton.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            resultsButton.ForeColor = Color.RoyalBlue;
            resultsButton.Location = new Point(80, 12);
            resultsButton.Name = "resultsButton";
            resultsButton.Size = new Size(175, 85);
            resultsButton.TabIndex = 1;
            resultsButton.Text = "Результаты";
            resultsButton.UseVisualStyleBackColor = false;
            resultsButton.Click += resultsButton_Click;
            // 
            // settingsButton
            // 
            settingsButton.BackColor = Color.FromArgb(64, 0, 64);
            settingsButton.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            settingsButton.ForeColor = Color.RoyalBlue;
            settingsButton.Location = new Point(436, 12);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(175, 85);
            settingsButton.TabIndex = 2;
            settingsButton.Text = "Настройки";
            settingsButton.UseVisualStyleBackColor = false;
            settingsButton.Click += settingsButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(64, 0, 64);
            exitButton.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            exitButton.ForeColor = Color.Red;
            exitButton.Location = new Point(262, 475);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(171, 85);
            exitButton.TabIndex = 3;
            exitButton.Text = "Выход";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(681, 563);
            Controls.Add(exitButton);
            Controls.Add(settingsButton);
            Controls.Add(resultsButton);
            Controls.Add(startButton);
            DoubleBuffered = true;
            Name = "MainMenuForm";
            Text = "Игра 2048";
            Load += MainMenuForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button startButton;
        private Button resultsButton;
        private Button settingsButton;
        private Button exitButton;
    }
}
