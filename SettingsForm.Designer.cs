namespace _2048WinFormsApp
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            showLabel = new Label();
            showLabel2 = new Label();
            showLabel3 = new Label();
            changeButton = new Button();
            backButton = new Button();
            clearButton = new Button();
            textBox = new TextBox();
            SuspendLayout();
            // 
            // showLabel
            // 
            showLabel.BackColor = SystemColors.ControlDarkDark;
            showLabel.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            showLabel.ForeColor = Color.Lime;
            showLabel.Image = (Image)resources.GetObject("showLabel.Image");
            showLabel.ImageAlign = ContentAlignment.TopCenter;
            showLabel.Location = new Point(308, 25);
            showLabel.Name = "showLabel";
            showLabel.Size = new Size(218, 79);
            showLabel.TabIndex = 0;
            showLabel.Text = "Настройки";
            // 
            // showLabel2
            // 
            showLabel2.BackColor = SystemColors.ControlDarkDark;
            showLabel2.Font = new Font("Comic Sans MS", 15.75F);
            showLabel2.ForeColor = Color.Lime;
            showLabel2.Image = (Image)resources.GetObject("showLabel2.Image");
            showLabel2.ImageAlign = ContentAlignment.MiddleLeft;
            showLabel2.Location = new Point(109, 178);
            showLabel2.Name = "showLabel2";
            showLabel2.Size = new Size(345, 34);
            showLabel2.TabIndex = 1;
            showLabel2.Text = "Размер поля (4 по умолчанию):";
            // 
            // showLabel3
            // 
            showLabel3.BackColor = SystemColors.ControlDarkDark;
            showLabel3.Font = new Font("Comic Sans MS", 15.75F);
            showLabel3.ForeColor = Color.Lime;
            showLabel3.Image = (Image)resources.GetObject("showLabel3.Image");
            showLabel3.ImageAlign = ContentAlignment.MiddleLeft;
            showLabel3.Location = new Point(109, 312);
            showLabel3.Name = "showLabel3";
            showLabel3.Size = new Size(345, 34);
            showLabel3.TabIndex = 2;
            showLabel3.Text = "Даные пользователей:";
            // 
            // changeButton
            // 
            changeButton.BackColor = Color.DimGray;
            changeButton.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            changeButton.ForeColor = Color.Lime;
            changeButton.Location = new Point(532, 180);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(149, 34);
            changeButton.TabIndex = 3;
            changeButton.Text = "Изменить";
            changeButton.UseVisualStyleBackColor = false;
            changeButton.Click += changeButton_Click;
            // 
            // backButton
            // 
            backButton.BackColor = Color.DimGray;
            backButton.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            backButton.ForeColor = Color.Lime;
            backButton.Location = new Point(308, 454);
            backButton.Name = "backButton";
            backButton.Size = new Size(218, 80);
            backButton.TabIndex = 4;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Red;
            clearButton.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            clearButton.ForeColor = SystemColors.ButtonHighlight;
            clearButton.Location = new Point(468, 312);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(213, 34);
            clearButton.TabIndex = 5;
            clearButton.Text = "Удалить результаты";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // textBox
            // 
            textBox.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox.Location = new Point(468, 178);
            textBox.Name = "textBox";
            textBox.Size = new Size(58, 34);
            textBox.TabIndex = 6;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(813, 588);
            Controls.Add(textBox);
            Controls.Add(clearButton);
            Controls.Add(backButton);
            Controls.Add(changeButton);
            Controls.Add(showLabel3);
            Controls.Add(showLabel2);
            Controls.Add(showLabel);
            Name = "SettingsForm";
            Text = "SettingsForm";
            Load += SettingsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label showLabel;
        private Label showLabel2;
        private Label showLabel3;
        private Button changeButton;
        private Button backButton;
        private Button clearButton;
        private TextBox textBox;
    }
}