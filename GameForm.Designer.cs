namespace _2048WinFormsApp
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            showLabel = new Label();
            scoreLabel = new Label();
            exitButton = new Button();
            SuspendLayout();
            // 
            // showLabel
            // 
            showLabel.BackColor = Color.FromArgb(192, 255, 192);
            showLabel.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            showLabel.ForeColor = Color.FromArgb(0, 0, 64);
            showLabel.Location = new Point(75, 49);
            showLabel.Name = "showLabel";
            showLabel.Size = new Size(118, 46);
            showLabel.TabIndex = 5;
            showLabel.Text = "Очки:";
            // 
            // scoreLabel
            // 
            scoreLabel.BackColor = Color.FromArgb(192, 255, 192);
            scoreLabel.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            scoreLabel.ForeColor = Color.FromArgb(0, 0, 64);
            scoreLabel.Location = new Point(199, 49);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(250, 52);
            scoreLabel.TabIndex = 6;
            scoreLabel.Text = "0";
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Red;
            exitButton.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            exitButton.ForeColor = Color.White;
            exitButton.Location = new Point(498, 49);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(174, 52);
            exitButton.TabIndex = 7;
            exitButton.Text = "Закончить";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(684, 661);
            Controls.Add(exitButton);
            Controls.Add(scoreLabel);
            Controls.Add(showLabel);
            Name = "GameForm";
            Text = "GameForm";
            Load += GameForm_Load;
            KeyDown += GameForm_KeyDown;
            KeyPress += GameForm_KeyPress;
            ResumeLayout(false);
        }

        #endregion
        private Label showLabel;
        private Label scoreLabel;
        private Button exitButton;
    }
}