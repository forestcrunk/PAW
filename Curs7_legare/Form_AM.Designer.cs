namespace Curs7_legare
{
    partial class Form_AM
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
            this.tb_marca = new System.Windows.Forms.TextBox();
            this.tb_nume = new System.Windows.Forms.TextBox();
            this.button_confirma = new System.Windows.Forms.Button();
            this.button_anuleaza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_marca
            // 
            this.tb_marca.Location = new System.Drawing.Point(53, 57);
            this.tb_marca.Name = "tb_marca";
            this.tb_marca.Size = new System.Drawing.Size(100, 20);
            this.tb_marca.TabIndex = 0;
            this.tb_marca.Text = "0";
            this.tb_marca.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_nume
            // 
            this.tb_nume.Location = new System.Drawing.Point(53, 108);
            this.tb_nume.Name = "tb_nume";
            this.tb_nume.Size = new System.Drawing.Size(172, 20);
            this.tb_nume.TabIndex = 1;
            this.tb_nume.Text = "Nume si prenume";
            // 
            // button_confirma
            // 
            this.button_confirma.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_confirma.Location = new System.Drawing.Point(31, 167);
            this.button_confirma.Name = "button_confirma";
            this.button_confirma.Size = new System.Drawing.Size(75, 23);
            this.button_confirma.TabIndex = 2;
            this.button_confirma.Tag = "";
            this.button_confirma.Text = "Adauga";
            this.button_confirma.UseVisualStyleBackColor = true;
            // 
            // button_anuleaza
            // 
            this.button_anuleaza.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_anuleaza.Location = new System.Drawing.Point(172, 167);
            this.button_anuleaza.Name = "button_anuleaza";
            this.button_anuleaza.Size = new System.Drawing.Size(75, 23);
            this.button_anuleaza.TabIndex = 3;
            this.button_anuleaza.Text = "Anuleaza";
            this.button_anuleaza.UseVisualStyleBackColor = true;
            // 
            // Form_AM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 209);
            this.Controls.Add(this.button_anuleaza);
            this.Controls.Add(this.button_confirma);
            this.Controls.Add(this.tb_nume);
            this.Controls.Add(this.tb_marca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_AM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_AM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button button_confirma;
        public System.Windows.Forms.Button button_anuleaza;
        public System.Windows.Forms.TextBox tb_marca;
        public System.Windows.Forms.TextBox tb_nume;
    }
}