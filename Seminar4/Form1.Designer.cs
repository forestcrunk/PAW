namespace Seminar4
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
            this.button1 = new System.Windows.Forms.Button();
            this.tb_in_x2 = new System.Windows.Forms.TextBox();
            this.tb_in_x1 = new System.Windows.Forms.TextBox();
            this.tb_in_tl = new System.Windows.Forms.TextBox();
            this.tb_out_rad1 = new System.Windows.Forms.TextBox();
            this.tb_out_rad2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(173, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calculare radacini";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_in_x2
            // 
            this.tb_in_x2.Location = new System.Drawing.Point(43, 54);
            this.tb_in_x2.Name = "tb_in_x2";
            this.tb_in_x2.Size = new System.Drawing.Size(100, 20);
            this.tb_in_x2.TabIndex = 0;
            this.tb_in_x2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_in_x1
            // 
            this.tb_in_x1.Location = new System.Drawing.Point(213, 54);
            this.tb_in_x1.Name = "tb_in_x1";
            this.tb_in_x1.Size = new System.Drawing.Size(100, 20);
            this.tb_in_x1.TabIndex = 1;
            this.tb_in_x1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_in_tl
            // 
            this.tb_in_tl.Location = new System.Drawing.Point(383, 54);
            this.tb_in_tl.Name = "tb_in_tl";
            this.tb_in_tl.Size = new System.Drawing.Size(100, 20);
            this.tb_in_tl.TabIndex = 2;
            this.tb_in_tl.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_out_rad1
            // 
            this.tb_out_rad1.Location = new System.Drawing.Point(99, 222);
            this.tb_out_rad1.Name = "tb_out_rad1";
            this.tb_out_rad1.ReadOnly = true;
            this.tb_out_rad1.Size = new System.Drawing.Size(100, 20);
            this.tb_out_rad1.TabIndex = 4;
            this.tb_out_rad1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_out_rad2
            // 
            this.tb_out_rad2.Location = new System.Drawing.Point(328, 221);
            this.tb_out_rad2.Name = "tb_out_rad2";
            this.tb_out_rad2.ReadOnly = true;
            this.tb_out_rad2.Size = new System.Drawing.Size(100, 20);
            this.tb_out_rad2.TabIndex = 5;
            this.tb_out_rad2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "x^2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "termen liber";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "radacina 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "radacina 2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Inchide";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 369);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_out_rad2);
            this.Controls.Add(this.tb_out_rad1);
            this.Controls.Add(this.tb_in_tl);
            this.Controls.Add(this.tb_in_x1);
            this.Controls.Add(this.tb_in_x2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Rezolvare ec. grad 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_in_x2;
        private System.Windows.Forms.TextBox tb_in_x1;
        private System.Windows.Forms.TextBox tb_in_tl;
        private System.Windows.Forms.TextBox tb_out_rad1;
        private System.Windows.Forms.TextBox tb_out_rad2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}

