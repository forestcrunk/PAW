namespace Seminar9
{
    partial class Form3
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
            this.SuspendLayout();
            // 
            // histo1
            // 
            this.histo1.BackColor = System.Drawing.Color.White;
            this.histo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.histo1.Location = new System.Drawing.Point(0, 0);
            this.histo1.Name = "histo1";
            this.histo1.Salarii = null;
            this.histo1.Size = new System.Drawing.Size(600, 366);
            this.histo1.TabIndex = 0;
            this.histo1.Text = "histo1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.histo1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        private Histo histo1;

        #endregion

        //private Histo histo1;
    }
}