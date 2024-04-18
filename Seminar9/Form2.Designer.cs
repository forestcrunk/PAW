namespace Seminar9
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
            this.tbox_nume = new System.Windows.Forms.TextBox();
            this.label_nume = new System.Windows.Forms.Label();
            this.label_no = new System.Windows.Forms.Label();
            this.tbox_no = new System.Windows.Forms.TextBox();
            this.label_so = new System.Windows.Forms.Label();
            this.tbox_so = new System.Windows.Forms.TextBox();
            this.button_confirma = new System.Windows.Forms.Button();
            this.button_anuleaza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbox_nume
            // 
            this.tbox_nume.Location = new System.Drawing.Point(107, 35);
            this.tbox_nume.Name = "tbox_nume";
            this.tbox_nume.Size = new System.Drawing.Size(187, 20);
            this.tbox_nume.TabIndex = 0;
            // 
            // label_nume
            // 
            this.label_nume.AutoSize = true;
            this.label_nume.Location = new System.Drawing.Point(12, 38);
            this.label_nume.Name = "label_nume";
            this.label_nume.Size = new System.Drawing.Size(89, 13);
            this.label_nume.TabIndex = 3;
            this.label_nume.Text = "Nume si prenume";
            // 
            // label_no
            // 
            this.label_no.AutoSize = true;
            this.label_no.Location = new System.Drawing.Point(12, 103);
            this.label_no.Name = "label_no";
            this.label_no.Size = new System.Drawing.Size(71, 13);
            this.label_no.TabIndex = 5;
            this.label_no.Text = "Numar de ore";
            // 
            // tbox_no
            // 
            this.tbox_no.Location = new System.Drawing.Point(107, 100);
            this.tbox_no.Name = "tbox_no";
            this.tbox_no.Size = new System.Drawing.Size(100, 20);
            this.tbox_no.TabIndex = 4;
            this.tbox_no.Text = "0";
            this.tbox_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_so
            // 
            this.label_so.AutoSize = true;
            this.label_so.Location = new System.Drawing.Point(12, 167);
            this.label_so.Name = "label_so";
            this.label_so.Size = new System.Drawing.Size(60, 13);
            this.label_so.TabIndex = 7;
            this.label_so.Text = "Salariu orar";
            // 
            // tbox_so
            // 
            this.tbox_so.Location = new System.Drawing.Point(107, 164);
            this.tbox_so.Name = "tbox_so";
            this.tbox_so.Size = new System.Drawing.Size(100, 20);
            this.tbox_so.TabIndex = 6;
            this.tbox_so.Text = "0.00";
            this.tbox_so.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_confirma
            // 
            this.button_confirma.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_confirma.Location = new System.Drawing.Point(40, 243);
            this.button_confirma.Name = "button_confirma";
            this.button_confirma.Size = new System.Drawing.Size(128, 53);
            this.button_confirma.TabIndex = 8;
            this.button_confirma.Text = "Adauga";
            this.button_confirma.UseVisualStyleBackColor = true;
            // 
            // button_anuleaza
            // 
            this.button_anuleaza.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_anuleaza.Location = new System.Drawing.Point(201, 243);
            this.button_anuleaza.Name = "button_anuleaza";
            this.button_anuleaza.Size = new System.Drawing.Size(116, 53);
            this.button_anuleaza.TabIndex = 9;
            this.button_anuleaza.Text = "Anuleaza";
            this.button_anuleaza.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 326);
            this.Controls.Add(this.button_anuleaza);
            this.Controls.Add(this.button_confirma);
            this.Controls.Add(this.label_so);
            this.Controls.Add(this.tbox_so);
            this.Controls.Add(this.label_no);
            this.Controls.Add(this.tbox_no);
            this.Controls.Add(this.label_nume);
            this.Controls.Add(this.tbox_nume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_nume;
        private System.Windows.Forms.Label label_no;
        private System.Windows.Forms.Label label_so;
        public System.Windows.Forms.TextBox tbox_nume;
        public System.Windows.Forms.TextBox tbox_no;
        public System.Windows.Forms.TextBox tbox_so;
        public System.Windows.Forms.Button button_confirma;
        public System.Windows.Forms.Button button_anuleaza;
    }
}