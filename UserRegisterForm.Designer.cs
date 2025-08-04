namespace _2048WinFormsApp
{
    partial class UserRegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRegisterForm));
            userLabel = new Label();
            nameTextBox = new TextBox();
            nextButton = new Button();
            SuspendLayout();
            // 
            // userLabel
            // 
            userLabel.BackColor = Color.Black;
            userLabel.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            userLabel.ForeColor = Color.MediumSlateBlue;
            userLabel.Image = (Image)resources.GetObject("userLabel.Image");
            userLabel.ImageAlign = ContentAlignment.MiddleRight;
            userLabel.Location = new Point(247, 28);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(378, 98);
            userLabel.TabIndex = 0;
            userLabel.Text = "Введите своё имя для фиксации результатов";
            userLabel.Click += userLabel_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = Color.SaddleBrown;
            nameTextBox.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameTextBox.ForeColor = Color.DarkSeaGreen;
            nameTextBox.Location = new Point(247, 283);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(378, 59);
            nameTextBox.TabIndex = 1;
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.DarkCyan;
            nextButton.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nextButton.ForeColor = Color.Purple;
            nextButton.Location = new Point(305, 404);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(272, 86);
            nextButton.TabIndex = 2;
            nextButton.Text = "Зафиксировать";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // UserRegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(855, 563);
            Controls.Add(nextButton);
            Controls.Add(nameTextBox);
            Controls.Add(userLabel);
            Name = "UserRegisterForm";
            Text = "2048 Игра";
            Load += UserRegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userLabel;
        private TextBox nameTextBox;
        private Button nextButton;
    }
}