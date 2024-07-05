namespace YoketoruCS
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            labelTitle = new Label();
            buttonStart = new Button();
            labelGameover = new Label();
            buttonToTitle = new Button();
            labelClear = new Label();
            labelScore = new Label();
            labelTimer = new Label();
            tempPlayer = new Label();
            tempItem = new Label();
            tempEnemy = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Yu Gothic UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(194, 88);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(229, 65);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "よけとるVS";
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("Yu Gothic UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStart.Location = new Point(217, 189);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(169, 85);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "スタート!!";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // labelGameover
            // 
            labelGameover.AutoSize = true;
            labelGameover.Font = new Font("Yu Gothic UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            labelGameover.Location = new Point(555, 64);
            labelGameover.Name = "labelGameover";
            labelGameover.Size = new Size(257, 65);
            labelGameover.TabIndex = 2;
            labelGameover.Text = "Game over";
            labelGameover.Click += label1_Click;
            // 
            // buttonToTitle
            // 
            buttonToTitle.Font = new Font("Yu Gothic UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonToTitle.Location = new Point(586, 189);
            buttonToTitle.Name = "buttonToTitle";
            buttonToTitle.Size = new Size(187, 85);
            buttonToTitle.TabIndex = 3;
            buttonToTitle.Text = "タイトルへ";
            buttonToTitle.UseVisualStyleBackColor = true;
            buttonToTitle.Click += buttonToTitle_Click;
            // 
            // labelClear
            // 
            labelClear.AutoSize = true;
            labelClear.Font = new Font("Yu Gothic UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            labelClear.Location = new Point(426, 254);
            labelClear.Name = "labelClear";
            labelClear.Size = new Size(136, 65);
            labelClear.TabIndex = 4;
            labelClear.Text = "Clear";
            labelClear.Click += label1_Click_1;
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Font = new Font("Yu Gothic UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelScore.Location = new Point(431, 9);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(33, 40);
            labelScore.TabIndex = 5;
            labelScore.Text = "0";
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelTimer.ForeColor = Color.Black;
            labelTimer.Location = new Point(656, 438);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(53, 32);
            labelTimer.TabIndex = 6;
            labelTimer.Text = "200";
            // 
            // tempPlayer
            // 
            tempPlayer.AutoSize = true;
            tempPlayer.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            tempPlayer.Location = new Point(334, 441);
            tempPlayer.Name = "tempPlayer";
            tempPlayer.Size = new Size(130, 37);
            tempPlayer.TabIndex = 7;
            tempPlayer.Text = "(´・∀・｀ )";
            // 
            // tempItem
            // 
            tempItem.AutoSize = true;
            tempItem.Font = new Font("Yu Gothic UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            tempItem.Location = new Point(525, 428);
            tempItem.Name = "tempItem";
            tempItem.Size = new Size(52, 45);
            tempItem.TabIndex = 9;
            tempItem.Text = "★";
            // 
            // tempEnemy
            // 
            tempEnemy.AutoSize = true;
            tempEnemy.Font = new Font("Yu Gothic UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            tempEnemy.Location = new Point(525, 351);
            tempEnemy.Name = "tempEnemy";
            tempEnemy.Size = new Size(52, 45);
            tempEnemy.TabIndex = 10;
            tempEnemy.Text = "的";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 501);
            Controls.Add(tempEnemy);
            Controls.Add(tempItem);
            Controls.Add(tempPlayer);
            Controls.Add(labelTimer);
            Controls.Add(labelScore);
            Controls.Add(labelClear);
            Controls.Add(buttonToTitle);
            Controls.Add(labelGameover);
            Controls.Add(buttonStart);
            Controls.Add(labelTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label labelTitle;
        private Button buttonStart;
        private Label labelGameover;
        private Button buttonToTitle;
        private Label labelClear;
        private Label labelScore;
        private Label labelTimer;
        private Label tempPlayer;
        private Label tempItem;
        private Label tempEnemy;
    }
}