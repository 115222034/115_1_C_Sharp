namespace Tutorial2_4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1361, 219);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(397, 236);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(731, 219);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(408, 236);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.None;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(109, 219);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(402, 236);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label1
            // 
            label1.Font = new Font("華康超圓體", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 136);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(195, 24);
            label1.Name = "label1";
            label1.Size = new Size(1495, 96);
            label1.TabIndex = 3;
            label1.Text = "點一個國旗，我告訴你是哪個國家";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("華康超黑體", 72F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(731, 514);
            label2.Name = "label2";
            label2.Size = new Size(417, 144);
            label2.TabIndex = 4;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1888, 725);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label1;
        private Label label2;
    }
}
