﻿namespace Curs7
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operatiiSalariatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sb = new System.Windows.Forms.StatusStrip();
            this.sb_label1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sb_label2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adaugareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.sb.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operatiiSalariatiToolStripMenuItem,
            this.dateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(594, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operatiiSalariatiToolStripMenuItem
            // 
            this.operatiiSalariatiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem,
            this.modificaToolStripMenuItem});
            this.operatiiSalariatiToolStripMenuItem.Name = "operatiiSalariatiToolStripMenuItem";
            this.operatiiSalariatiToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.operatiiSalariatiToolStripMenuItem.Text = "Operatii salariati";
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adaugaToolStripMenuItem.Tag = "A";
            this.adaugaToolStripMenuItem.Text = "Adauga";
            this.adaugaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificaToolStripMenuItem.Tag = "M";
            this.modificaToolStripMenuItem.Text = "Modifica";
            this.modificaToolStripMenuItem.Click += new System.EventHandler(this.adaugaToolStripMenuItem_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 24);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(594, 317);
            this.dgv.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Marca";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nume si prenume";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // sb
            // 
            this.sb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sb_label1,
            this.sb_label2});
            this.sb.Location = new System.Drawing.Point(0, 319);
            this.sb.Name = "sb";
            this.sb.Size = new System.Drawing.Size(594, 22);
            this.sb.TabIndex = 2;
            this.sb.Text = "statusStrip1";
            // 
            // sb_label1
            // 
            this.sb_label1.Name = "sb_label1";
            this.sb_label1.Size = new System.Drawing.Size(90, 17);
            this.sb_label1.Text = "Numar salariati:";
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
            this.modificareToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(132, 48);
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
            // dateToolStripMenuItem
            // 
            this.dateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deschideToolStripMenuItem,
            this.salveazaToolStripMenuItem});
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 341);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.sb);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.ToolStripMenuItem operatiiSalariatiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.StatusStrip sb;
        private System.Windows.Forms.ToolStripStatusLabel sb_label1;
        private System.Windows.Forms.ToolStripStatusLabel sb_label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adaugareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaToolStripMenuItem;
    }
}

