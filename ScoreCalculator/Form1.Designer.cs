namespace ScoreCalculator
{
    partial class scoreCalc
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
            scoretxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            scoreTotalTxt = new TextBox();
            scoreCountTxt = new TextBox();
            averageTxt = new TextBox();
            btnAdd = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // scoretxt
            // 
            scoretxt.Location = new Point(108, 52);
            scoretxt.Name = "scoretxt";
            scoretxt.Size = new Size(125, 27);
            scoretxt.TabIndex = 0;
            scoretxt.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Score:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 105);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 2;
            label2.Text = "Score total:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 145);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 3;
            label3.Text = "Score count:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 185);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 4;
            label4.Text = "Average:";
            label4.Click += label4_Click;
            // 
            // scoreTotalTxt
            // 
            scoreTotalTxt.Location = new Point(108, 102);
            scoreTotalTxt.Name = "scoreTotalTxt";
            scoreTotalTxt.Size = new Size(125, 27);
            scoreTotalTxt.TabIndex = 5;
            // 
            // scoreCountTxt
            // 
            scoreCountTxt.Location = new Point(108, 145);
            scoreCountTxt.Name = "scoreCountTxt";
            scoreCountTxt.Size = new Size(125, 27);
            scoreCountTxt.TabIndex = 6;
            scoreCountTxt.TextChanged += textBox3_TextChanged;
            // 
            // averageTxt
            // 
            averageTxt.Location = new Point(108, 185);
            averageTxt.Name = "averageTxt";
            averageTxt.Size = new Size(125, 27);
            averageTxt.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(251, 52);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(97, 228);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(232, 228);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // scoreCalc
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(355, 300);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(averageTxt);
            Controls.Add(scoreCountTxt);
            Controls.Add(scoreTotalTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(scoretxt);
            Name = "scoreCalc";
            Text = "Score Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox scoretxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox scoreTotalTxt;
        private TextBox scoreCountTxt;
        private TextBox averageTxt;
        private Button btnAdd;
        private Button btnClear;
        private Button btnExit;
    }
}
