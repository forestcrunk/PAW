namespace Curs4_WindowsForms
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
            this.tbox_in = new System.Windows.Forms.TextBox();
            this.tbox_out = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(212, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbox_in
            // 
            this.tbox_in.Location = new System.Drawing.Point(212, 65);
            this.tbox_in.Name = "tbox_in";
            this.tbox_in.Size = new System.Drawing.Size(110, 20);
            this.tbox_in.TabIndex = 0;
            this.tbox_in.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbox_out
            // 
            this.tbox_out.Location = new System.Drawing.Point(212, 211);
            this.tbox_out.Name = "tbox_out";
            this.tbox_out.ReadOnly = true;
            this.tbox_out.Size = new System.Drawing.Size(110, 20);
            this.tbox_out.TabIndex = 2;
            this.tbox_out.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 325);
            this.Controls.Add(this.tbox_out);
            this.Controls.Add(this.tbox_in);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Aplicatie WF";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbox_in;
        private System.Windows.Forms.TextBox tbox_out;
    }
}

