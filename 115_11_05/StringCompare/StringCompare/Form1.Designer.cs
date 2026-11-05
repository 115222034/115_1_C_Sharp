namespace StringCompare
{
    partial class Form1
    {
        private Label lblString1;
        private Label lblString2;
        private TextBox txtString1;
        private TextBox txtString2;
        private Button btnCompare;
        private Button btnExit;

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
            this.components = new System.ComponentModel.Container();
            this.lblString1 = new System.Windows.Forms.Label();
            this.lblString2 = new System.Windows.Forms.Label();
            this.txtString1 = new System.Windows.Forms.TextBox();
            this.txtString2 = new System.Windows.Forms.TextBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblString1
            // 
            this.lblString1.AutoSize = true;
            this.lblString1.Location = new System.Drawing.Point(45, 45);
            this.lblString1.Name = "lblString1";
            this.lblString1.Size = new System.Drawing.Size(57, 19);
            this.lblString1.TabIndex = 0;
            this.lblString1.Text = "字串1：";
            // 
            // lblString2
            // 
            this.lblString2.AutoSize = true;
            this.lblString2.Location = new System.Drawing.Point(45, 95);
            this.lblString2.Name = "lblString2";
            this.lblString2.Size = new System.Drawing.Size(57, 19);
            this.lblString2.TabIndex = 1;
            this.lblString2.Text = "字串2：";
            // 
            // txtString1
            // 
            this.txtString1.Location = new System.Drawing.Point(125, 40);
            this.txtString1.Name = "txtString1";
            this.txtString1.Size = new System.Drawing.Size(280, 27);
            this.txtString1.TabIndex = 2;
            // 
            // txtString2
            // 
            this.txtString2.Location = new System.Drawing.Point(125, 90);
            this.txtString2.Name = "txtString2";
            this.txtString2.Size = new System.Drawing.Size(280, 27);
            this.txtString2.TabIndex = 3;
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(125, 145);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(100, 35);
            this.btnCompare.TabIndex = 4;
            this.btnCompare.Text = "比較";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(250, 145);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 35);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "離開";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 230);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.txtString2);
            this.Controls.Add(this.txtString1);
            this.Controls.Add(this.lblString2);
            this.Controls.Add(this.lblString1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "字串比較";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
