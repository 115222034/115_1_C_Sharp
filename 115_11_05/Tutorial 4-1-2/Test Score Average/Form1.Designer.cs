namespace Test_Score_Average
{
    partial class Form1
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
            this.testScoreGroupBox = new System.Windows.Forms.GroupBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.test3promptLabel = new System.Windows.Forms.Label();
            this.test2promptLabel = new System.Windows.Forms.Label();
            this.test1promptLabel = new System.Windows.Forms.Label();
            this.test3TextBox = new System.Windows.Forms.TextBox();
            this.test2TextBox = new System.Windows.Forms.TextBox();
            this.test1TextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.testScoreGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // testScoreGroupBox
            // 
            this.testScoreGroupBox.Controls.Add(this.clearButton);
            this.testScoreGroupBox.Controls.Add(this.exitButton);
            this.testScoreGroupBox.Controls.Add(this.outputDescriptionLabel);
            this.testScoreGroupBox.Controls.Add(this.averageLabel);
            this.testScoreGroupBox.Controls.Add(this.calculateButton);
            this.testScoreGroupBox.Controls.Add(this.test3promptLabel);
            this.testScoreGroupBox.Controls.Add(this.test2promptLabel);
            this.testScoreGroupBox.Controls.Add(this.test1promptLabel);
            this.testScoreGroupBox.Controls.Add(this.test3TextBox);
            this.testScoreGroupBox.Controls.Add(this.test2TextBox);
            this.testScoreGroupBox.Controls.Add(this.test1TextBox);
            this.testScoreGroupBox.Location = new System.Drawing.Point(12, 12);
            this.testScoreGroupBox.Name = "testScoreGroupBox";
            this.testScoreGroupBox.Size = new System.Drawing.Size(699, 544);
            this.testScoreGroupBox.TabIndex = 0;
            this.testScoreGroupBox.TabStop = false;
            this.testScoreGroupBox.Text = "輸入三次考試成績";
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.Location = new System.Drawing.Point(30, 356);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(257, 35);
            this.outputDescriptionLabel.TabIndex = 7;
            this.outputDescriptionLabel.Text = "平均成績";
            this.outputDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // averageLabel
            // 
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLabel.Location = new System.Drawing.Point(318, 344);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(347, 59);
            this.averageLabel.TabIndex = 6;
            this.averageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // test3promptLabel
            // 
            this.test3promptLabel.Location = new System.Drawing.Point(19, 256);
            this.test3promptLabel.Name = "test3promptLabel";
            this.test3promptLabel.Size = new System.Drawing.Size(257, 35);
            this.test3promptLabel.TabIndex = 5;
            this.test3promptLabel.Text = "第三次考試成績";
            this.test3promptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // test2promptLabel
            // 
            this.test2promptLabel.Location = new System.Drawing.Point(19, 147);
            this.test2promptLabel.Name = "test2promptLabel";
            this.test2promptLabel.Size = new System.Drawing.Size(257, 35);
            this.test2promptLabel.TabIndex = 4;
            this.test2promptLabel.Text = "第二次考試成績";
            this.test2promptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // test1promptLabel
            // 
            this.test1promptLabel.Location = new System.Drawing.Point(19, 47);
            this.test1promptLabel.Name = "test1promptLabel";
            this.test1promptLabel.Size = new System.Drawing.Size(268, 35);
            this.test1promptLabel.TabIndex = 3;
            this.test1promptLabel.Text = "第一次考試成績";
            this.test1promptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // test3TextBox
            // 
            this.test3TextBox.Location = new System.Drawing.Point(318, 254);
            this.test3TextBox.Name = "test3TextBox";
            this.test3TextBox.Size = new System.Drawing.Size(347, 46);
            this.test3TextBox.TabIndex = 2;
            // 
            // test2TextBox
            // 
            this.test2TextBox.Location = new System.Drawing.Point(318, 145);
            this.test2TextBox.Name = "test2TextBox";
            this.test2TextBox.Size = new System.Drawing.Size(347, 46);
            this.test2TextBox.TabIndex = 1;
            // 
            // test1TextBox
            // 
            this.test1TextBox.Location = new System.Drawing.Point(318, 45);
            this.test1TextBox.Name = "test1TextBox";
            this.test1TextBox.Size = new System.Drawing.Size(347, 46);
            this.test1TextBox.TabIndex = 0;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(36, 426);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(360, 101);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "計算平均成績";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(428, 426);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(237, 45);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "清除";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(428, 482);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(237, 45);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 568);
            this.Controls.Add(this.testScoreGroupBox);
            this.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.Text = "考試成績平均值";
            this.testScoreGroupBox.ResumeLayout(false);
            this.testScoreGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox testScoreGroupBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label test3promptLabel;
        private System.Windows.Forms.Label test2promptLabel;
        private System.Windows.Forms.Label test1promptLabel;
        private System.Windows.Forms.TextBox test3TextBox;
        private System.Windows.Forms.TextBox test2TextBox;
        private System.Windows.Forms.TextBox test1TextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

