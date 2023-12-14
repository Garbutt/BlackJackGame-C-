namespace BlackJackGame
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(102, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 36);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(530, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dealer";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(19, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 137);
            this.label3.TabIndex = 2;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(142, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 137);
            this.label4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(265, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 137);
            this.label5.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(81, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 137);
            this.label6.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(206, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 137);
            this.label7.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(530, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Hit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(656, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "Stand";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ac.png");
            this.imageList1.Images.SetKeyName(1, "ad.png");
            this.imageList1.Images.SetKeyName(2, "ah.png");
            this.imageList1.Images.SetKeyName(3, "as.png");
            this.imageList1.Images.SetKeyName(4, "2c.png");
            this.imageList1.Images.SetKeyName(5, "2d.png");
            this.imageList1.Images.SetKeyName(6, "2h.png");
            this.imageList1.Images.SetKeyName(7, "2s.png");
            this.imageList1.Images.SetKeyName(8, "3c.png");
            this.imageList1.Images.SetKeyName(9, "3d.png");
            this.imageList1.Images.SetKeyName(10, "3h.png");
            this.imageList1.Images.SetKeyName(11, "3s.png");
            this.imageList1.Images.SetKeyName(12, "4c.png");
            this.imageList1.Images.SetKeyName(13, "4d.png");
            this.imageList1.Images.SetKeyName(14, "4h.png");
            this.imageList1.Images.SetKeyName(15, "4s.png");
            this.imageList1.Images.SetKeyName(16, "5c.png");
            this.imageList1.Images.SetKeyName(17, "5d.png");
            this.imageList1.Images.SetKeyName(18, "5h.png");
            this.imageList1.Images.SetKeyName(19, "5s.png");
            this.imageList1.Images.SetKeyName(20, "6c.png");
            this.imageList1.Images.SetKeyName(21, "6d.png");
            this.imageList1.Images.SetKeyName(22, "6h.png");
            this.imageList1.Images.SetKeyName(23, "6s.png");
            this.imageList1.Images.SetKeyName(24, "7c.png");
            this.imageList1.Images.SetKeyName(25, "7d.png");
            this.imageList1.Images.SetKeyName(26, "7h.png");
            this.imageList1.Images.SetKeyName(27, "7s.png");
            this.imageList1.Images.SetKeyName(28, "8c.png");
            this.imageList1.Images.SetKeyName(29, "8d.png");
            this.imageList1.Images.SetKeyName(30, "8h.png");
            this.imageList1.Images.SetKeyName(31, "8s.png");
            this.imageList1.Images.SetKeyName(32, "9c.png");
            this.imageList1.Images.SetKeyName(33, "9d.png");
            this.imageList1.Images.SetKeyName(34, "9h.png");
            this.imageList1.Images.SetKeyName(35, "9s.png");
            this.imageList1.Images.SetKeyName(36, "10c.png");
            this.imageList1.Images.SetKeyName(37, "10d.png");
            this.imageList1.Images.SetKeyName(38, "10h.png");
            this.imageList1.Images.SetKeyName(39, "10s.png");
            this.imageList1.Images.SetKeyName(40, "jc.png");
            this.imageList1.Images.SetKeyName(41, "jd.png");
            this.imageList1.Images.SetKeyName(42, "jh.png");
            this.imageList1.Images.SetKeyName(43, "js.png");
            this.imageList1.Images.SetKeyName(44, "kc.png");
            this.imageList1.Images.SetKeyName(45, "kd.png");
            this.imageList1.Images.SetKeyName(46, "kh.png");
            this.imageList1.Images.SetKeyName(47, "ks.png");
            this.imageList1.Images.SetKeyName(48, "qc.png");
            this.imageList1.Images.SetKeyName(49, "qd.png");
            this.imageList1.Images.SetKeyName(50, "qh.png");
            this.imageList1.Images.SetKeyName(51, "qs.png");
            this.imageList1.Images.SetKeyName(52, "blue back of cards.png");
            this.imageList1.Images.SetKeyName(53, "red back of cards.png");
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button button2;
        private ImageList imageList1;
    }
}