namespace Curs7_legare
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
            this.button_next = new System.Windows.Forms.Button();
            this.button_previous = new System.Windows.Forms.Button();
            this.tb_nume = new System.Windows.Forms.TextBox();
            this.tb_marca = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(232, 165);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(75, 23);
            this.button_next.TabIndex = 7;
            this.button_next.Text = ">>>";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_anuleaza_Click);
            // 
            // button_previous
            // 
            this.button_previous.Location = new System.Drawing.Point(91, 165);
            this.button_previous.Name = "button_previous";
            this.button_previous.Size = new System.Drawing.Size(75, 23);
            this.button_previous.TabIndex = 6;
            this.button_previous.Tag = "";
            this.button_previous.Text = "<<<";
            this.button_previous.UseVisualStyleBackColor = true;
            this.button_previous.Click += new System.EventHandler(this.button_confirma_Click);
            // 
            // tb_nume
            // 
            this.tb_nume.Location = new System.Drawing.Point(113, 106);
            this.tb_nume.Name = "tb_nume";
            this.tb_nume.Size = new System.Drawing.Size(172, 20);
            this.tb_nume.TabIndex = 5;
            this.tb_nume.Text = "Nume si prenume";
            // 
            // tb_marca
            // 
            this.tb_marca.Location = new System.Drawing.Point(113, 55);
            this.tb_marca.Name = "tb_marca";
            this.tb_marca.Size = new System.Drawing.Size(100, 20);
            this.tb_marca.TabIndex = 4;
            this.tb_marca.Text = "0";
            this.tb_marca.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 242);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_previous);
            this.Controls.Add(this.tb_nume);
            this.Controls.Add(this.tb_marca);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button_next;
        public System.Windows.Forms.Button button_previous;
        public System.Windows.Forms.TextBox tb_nume;
        public System.Windows.Forms.TextBox tb_marca;
    }
}