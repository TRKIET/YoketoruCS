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
            labelClear.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelClear.Location = new Point(297, 338);
            labelClear.Name = "labelClear";
            labelClear.Size = new Size(60, 30);
            labelClear.TabIndex = 4;
            labelClear.Text = "Clear";
            labelClear.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 501);
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
    }
}