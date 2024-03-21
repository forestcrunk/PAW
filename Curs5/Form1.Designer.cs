namespace Curs5
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
            this.tbox_history = new System.Windows.Forms.TextBox();
            this.lbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lview = new System.Windows.Forms.ListView();
            this.lview_column_nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lview_column_patrat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dgv_numar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_patrat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(49, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbox_in
            // 
            this.tbox_in.Location = new System.Drawing.Point(49, 79);
            this.tbox_in.Name = "tbox_in";
            this.tbox_in.Size = new System.Drawing.Size(110, 20);
            this.tbox_in.TabIndex = 0;
            this.tbox_in.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbox_in.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_in_KeyPress);
            this.tbox_in.Validating += new System.ComponentModel.CancelEventHandler(this.tbox_in_Validating);
            // 
            // tbox_out
            // 
            this.tbox_out.Location = new System.Drawing.Point(49, 232);
            this.tbox_out.Name = "tbox_out";
            this.tbox_out.ReadOnly = true;
            this.tbox_out.Size = new System.Drawing.Size(110, 20);
            this.tbox_out.TabIndex = 2;
            this.tbox_out.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbox_history
            // 
            this.tbox_history.Location = new System.Drawing.Point(257, 34);
            this.tbox_history.Multiline = true;
            this.tbox_history.Name = "tbox_history";
            this.tbox_history.ReadOnly = true;
            this.tbox_history.Size = new System.Drawing.Size(134, 121);
            this.tbox_history.TabIndex = 3;
            // 
            // lbox
            // 
            this.lbox.FormattingEnabled = true;
            this.lbox.Location = new System.Drawing.Point(397, 34);
            this.lbox.Name = "lbox";
            this.lbox.Size = new System.Drawing.Size(144, 121);
            this.lbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "text box";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "list box";
            // 
            // lview
            // 
            this.lview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lview_column_nume,
            this.lview_column_patrat});
            this.lview.HideSelection = false;
            this.lview.Location = new System.Drawing.Point(547, 34);
            this.lview.Name = "lview";
            this.lview.Size = new System.Drawing.Size(146, 121);
            this.lview.TabIndex = 7;
            this.lview.UseCompatibleStateImageBehavior = false;
            this.lview.View = System.Windows.Forms.View.Details;
            // 
            // lview_column_nume
            // 
            this.lview_column_nume.Text = "Numar";
            this.lview_column_nume.Width = 65;
            // 
            // lview_column_patrat
            // 
            this.lview_column_patrat.Text = "Patrat";
            this.lview_column_patrat.Width = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(595, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "list view";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_numar,
            this.dgv_patrat});
            this.dgv.Location = new System.Drawing.Point(350, 161);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(240, 150);
            this.dgv.TabIndex = 9;
            // 
            // dgv_numar
            // 
            this.dgv_numar.HeaderText = "Numar";
            this.dgv_numar.Name = "dgv_numar";
            this.dgv_numar.ReadOnly = true;
            // 
            // dgv_patrat
            // 
            this.dgv_patrat.HeaderText = "Patrat";
            this.dgv_patrat.Name = "dgv_patrat";
            this.dgv_patrat.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 361);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbox);
            this.Controls.Add(this.tbox_history);
            this.Controls.Add(this.tbox_out);
            this.Controls.Add(this.tbox_in);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Aplicatie WF";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbox_in;
        private System.Windows.Forms.TextBox tbox_out;
        private System.Windows.Forms.TextBox tbox_history;
        private System.Windows.Forms.ListBox lbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader lview_column_nume;
        private System.Windows.Forms.ColumnHeader lview_column_patrat;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_numar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_patrat;
    }
}

