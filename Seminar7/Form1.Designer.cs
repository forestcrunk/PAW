namespace Seminar7
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opSalariatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dgv_nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_so = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_salariu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sb = new System.Windows.Forms.StatusStrip();
            this.sb_label1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sb_label2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adaugareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.sb.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateToolStripMenuItem,
            this.opSalariatiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(567, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deschideToolStripMenuItem,
            this.salveazaToolStripMenuItem,
            this.toolStripSeparator1,
            this.iesireToolStripMenuItem});
            this.dateToolStripMenuItem.Name = "dateToolStripMenuItem";
            this.dateToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dateToolStripMenuItem.Text = "Date";
            // 
            // deschideToolStripMenuItem
            // 
            this.deschideToolStripMenuItem.Name = "deschideToolStripMenuItem";
            this.deschideToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deschideToolStripMenuItem.Text = "Deschide";
            this.deschideToolStripMenuItem.Click += new System.EventHandler(this.deschideToolStripMenuItem_Click);
            // 
            // salveazaToolStripMenuItem
            // 
            this.salveazaToolStripMenuItem.Name = "salveazaToolStripMenuItem";
            this.salveazaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salveazaToolStripMenuItem.Text = "Salveaza";
            this.salveazaToolStripMenuItem.Click += new System.EventHandler(this.salveazaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // opSalariatiToolStripMenuItem
            // 
            this.opSalariatiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem,
            this.modificaToolStripMenuItem,
            this.stergeToolStripMenuItem});
            this.opSalariatiToolStripMenuItem.Name = "opSalariatiToolStripMenuItem";
            this.opSalariatiToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.opSalariatiToolStripMenuItem.Text = "Op_Salariati";
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.adaugaToolStripMenuItem.Tag = "A";
            this.adaugaToolStripMenuItem.Text = "Adauga";
            this.adaugaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Enabled = false;
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.modificaToolStripMenuItem.Tag = "M";
            this.modificaToolStripMenuItem.Text = "Modifica";
            this.modificaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Enabled = false;
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.stergeToolStripMenuItem.Tag = "S";
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_nume,
            this.dgv_no,
            this.dgv_so,
            this.dgv_salariu});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 24);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(567, 289);
            this.dgv.TabIndex = 1;
            // 
            // dgv_nume
            // 
            this.dgv_nume.HeaderText = "Nume si prenume";
            this.dgv_nume.Name = "dgv_nume";
            this.dgv_nume.ReadOnly = true;
            this.dgv_nume.Width = 150;
            // 
            // dgv_no
            // 
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgv_no.DefaultCellStyle = dataGridViewCellStyle22;
            this.dgv_no.HeaderText = "Numar de ore";
            this.dgv_no.Name = "dgv_no";
            this.dgv_no.ReadOnly = true;
            // 
            // dgv_so
            // 
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgv_so.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgv_so.HeaderText = "Salariu orar";
            this.dgv_so.Name = "dgv_so";
            this.dgv_so.ReadOnly = true;
            // 
            // dgv_salariu
            // 
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgv_salariu.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgv_salariu.HeaderText = "Salariu";
            this.dgv_salariu.Name = "dgv_salariu";
            this.dgv_salariu.ReadOnly = true;
            // 
            // sb
            // 
            this.sb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sb_label1,
            this.sb_label2});
            this.sb.Location = new System.Drawing.Point(0, 291);
            this.sb.Name = "sb";
            this.sb.Size = new System.Drawing.Size(567, 22);
            this.sb.TabIndex = 2;
            this.sb.Text = "statusStrip1";
            // 
            // sb_label1
            // 
            this.sb_label1.Name = "sb_label1";
            this.sb_label1.Size = new System.Drawing.Size(74, 17);
            this.sb_label1.Text = "Fond Salarii: ";
            // 
            // sb_label2
            // 
            this.sb_label2.Name = "sb_label2";
            this.sb_label2.Size = new System.Drawing.Size(13, 17);
            this.sb_label2.Text = "0";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareToolStripMenuItem,
            this.modificareToolStripMenuItem,
            this.stergereToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(132, 70);
            // 
            // adaugareToolStripMenuItem
            // 
            this.adaugareToolStripMenuItem.Name = "adaugareToolStripMenuItem";
            this.adaugareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adaugareToolStripMenuItem.Tag = "A";
            this.adaugareToolStripMenuItem.Text = "Adaugare";
            this.adaugareToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // modificareToolStripMenuItem
            // 
            this.modificareToolStripMenuItem.Name = "modificareToolStripMenuItem";
            this.modificareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificareToolStripMenuItem.Tag = "M";
            this.modificareToolStripMenuItem.Text = "Modificare";
            this.modificareToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // stergereToolStripMenuItem
            // 
            this.stergereToolStripMenuItem.Name = "stergereToolStripMenuItem";
            this.stergereToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stergereToolStripMenuItem.Tag = "S";
            this.stergereToolStripMenuItem.Text = "Stergere";
            this.stergereToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 313);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.sb);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Gestiune Salariati";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.sb.ResumeLayout(false);
            this.sb.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opSalariatiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.StatusStrip sb;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_so;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_salariu;
        public System.Windows.Forms.ToolStripStatusLabel sb_label1;
        public System.Windows.Forms.ToolStripStatusLabel sb_label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adaugareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereToolStripMenuItem;
    }
}

