namespace mandelbrot
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
            this.label_midden_x = new System.Windows.Forms.Label();
            this.textBox_midden_x = new System.Windows.Forms.TextBox();
            this.label_midden_y = new System.Windows.Forms.Label();
            this.textBox_midden_y = new System.Windows.Forms.TextBox();
            this.label_schaal = new System.Windows.Forms.Label();
            this.textBox_schaal = new System.Windows.Forms.TextBox();
            this.label_max = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.textBox_Max = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox_forBM = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_forBM)).BeginInit();
            this.SuspendLayout();
            // 
            // label_midden_x
            // 
            this.label_midden_x.AutoSize = true;
            this.label_midden_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_midden_x.Location = new System.Drawing.Point(50, 44);
            this.label_midden_x.Name = "label_midden_x";
            this.label_midden_x.Size = new System.Drawing.Size(147, 32);
            this.label_midden_x.TabIndex = 1;
            this.label_midden_x.Text = "midden x:";
            // 
            // textBox_midden_x
            // 
            this.textBox_midden_x.Location = new System.Drawing.Point(253, 50);
            this.textBox_midden_x.Name = "textBox_midden_x";
            this.textBox_midden_x.Size = new System.Drawing.Size(100, 26);
            this.textBox_midden_x.TabIndex = 2;
            this.textBox_midden_x.Text = "0";
            this.textBox_midden_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_midden_y
            // 
            this.label_midden_y.AutoSize = true;
            this.label_midden_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_midden_y.Location = new System.Drawing.Point(50, 128);
            this.label_midden_y.Name = "label_midden_y";
            this.label_midden_y.Size = new System.Drawing.Size(147, 32);
            this.label_midden_y.TabIndex = 4;
            this.label_midden_y.Text = "midden y:";
            // 
            // textBox_midden_y
            // 
            this.textBox_midden_y.Location = new System.Drawing.Point(253, 128);
            this.textBox_midden_y.Name = "textBox_midden_y";
            this.textBox_midden_y.Size = new System.Drawing.Size(100, 26);
            this.textBox_midden_y.TabIndex = 5;
            this.textBox_midden_y.Text = "0";
            this.textBox_midden_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_schaal
            // 
            this.label_schaal.AutoSize = true;
            this.label_schaal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_schaal.Location = new System.Drawing.Point(529, 50);
            this.label_schaal.Name = "label_schaal";
            this.label_schaal.Size = new System.Drawing.Size(113, 32);
            this.label_schaal.TabIndex = 6;
            this.label_schaal.Text = "schaal:";
            // 
            // textBox_schaal
            // 
            this.textBox_schaal.Location = new System.Drawing.Point(699, 56);
            this.textBox_schaal.Name = "textBox_schaal";
            this.textBox_schaal.Size = new System.Drawing.Size(100, 26);
            this.textBox_schaal.TabIndex = 7;
            this.textBox_schaal.Text = "0";
            this.textBox_schaal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_max
            // 
            this.label_max.AutoSize = true;
            this.label_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_max.Location = new System.Drawing.Point(562, 121);
            this.label_max.Name = "label_max";
            this.label_max.Size = new System.Drawing.Size(80, 32);
            this.label_max.TabIndex = 8;
            this.label_max.Text = "max:";
            // 
            // button_OK
            // 
            this.button_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OK.Location = new System.Drawing.Point(873, 97);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(141, 50);
            this.button_OK.TabIndex = 9;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // textBox_Max
            // 
            this.textBox_Max.Location = new System.Drawing.Point(699, 121);
            this.textBox_Max.Name = "textBox_Max";
            this.textBox_Max.Size = new System.Drawing.Size(100, 26);
            this.textBox_Max.TabIndex = 10;
            this.textBox_Max.Text = "100";
            this.textBox_Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "test1",
            "test2",
            "test3",
            "test4"});
            this.listBox1.Location = new System.Drawing.Point(1118, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 12;
            // 
            // pictureBox_forBM
            // 
            this.pictureBox_forBM.Location = new System.Drawing.Point(48, 195);
            this.pictureBox_forBM.Name = "pictureBox_forBM";
            this.pictureBox_forBM.Size = new System.Drawing.Size(800, 800);
            this.pictureBox_forBM.TabIndex = 13;
            this.pictureBox_forBM.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 878);
            this.Controls.Add(this.pictureBox_forBM);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox_Max);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label_max);
            this.Controls.Add(this.textBox_schaal);
            this.Controls.Add(this.label_schaal);
            this.Controls.Add(this.textBox_midden_y);
            this.Controls.Add(this.label_midden_y);
            this.Controls.Add(this.textBox_midden_x);
            this.Controls.Add(this.label_midden_x);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_forBM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_midden_x;
        private System.Windows.Forms.TextBox textBox_midden_x;
        private System.Windows.Forms.Label label_midden_y;
        private System.Windows.Forms.TextBox textBox_midden_y;
        private System.Windows.Forms.Label label_schaal;
        private System.Windows.Forms.TextBox textBox_schaal;
        private System.Windows.Forms.Label label_max;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.TextBox textBox_Max;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox_forBM;
    }
}

