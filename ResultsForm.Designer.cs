namespace _2048WinFormsApp
{
    partial class ResultsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsForm));
            showLabel = new Label();
            showLabel2 = new Label();
            resultsLabel = new Label();
            bestResultLabel = new Label();
            backButton = new Button();
            SuspendLayout();
            // 
            // showLabel
            // 
            showLabel.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            showLabel.ForeColor = Color.Navy;
            showLabel.Image = (Image)resources.GetObject("showLabel.Image");
            showLabel.Location = new Point(12, 9);
            showLabel.Name = "showLabel";
            showLabel.Size = new Size(338, 34);
            showLabel.TabIndex = 0;
            showLabel.Text = "Результаты предыдущих игроков:";
            // 
            // showLabel2
            // 
            showLabel2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            showLabel2.ForeColor = Color.GreenYellow;
            showLabel2.Image = (Image)resources.GetObject("showLabel2.Image");
            showLabel2.Location = new Point(529, 9);
            showLabel2.Name = "showLabel2";
            showLabel2.Size = new Size(223, 34);
            showLabel2.TabIndex = 1;
            showLabel2.Text = "Лучшие результаты:";
            // 
            // resultsLabel
            // 
            resultsLabel.BackColor = SystemColors.Control;
            resultsLabel.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            resultsLabel.ForeColor = Color.Lime;
            resultsLabel.Image = (Image)resources.GetObject("resultsLabel.Image");
            resultsLabel.Location = new Point(79, 60);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(188, 311);
            resultsLabel.TabIndex = 2;
            // 
            // bestResultLabel
            // 
            bestResultLabel.BackColor = Color.Indigo;
            bestResultLabel.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            bestResultLabel.ForeColor = Color.Lime;
            bestResultLabel.Image = (Image)resources.GetObject("bestResultLabel.Image");
            bestResultLabel.ImageAlign = ContentAlignment.MiddleLeft;
            bestResultLabel.Location = new Point(547, 60);
            bestResultLabel.Name = "bestResultLabel";
            bestResultLabel.Size = new Size(188, 311);
            bestResultLabel.TabIndex = 3;
            // 
            // backButton
            // 
            backButton.BackColor = Color.Indigo;
            backButton.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            backButton.ForeColor = Color.Red;
            backButton.Location = new Point(331, 373);
            backButton.Name = "backButton";
            backButton.Size = new Size(153, 65);
            backButton.TabIndex = 4;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(backButton);
            Controls.Add(bestResultLabel);
            Controls.Add(resultsLabel);
            Controls.Add(showLabel2);
            Controls.Add(showLabel);
            Name = "ResultsForm";
            Text = "ResultsForm";
            Load += ResultsForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label showLabel;
        private Label showLabel2;
        private Label resultsLabel;
        private Label bestResultLabel;
        private Button backButton;
    }
}