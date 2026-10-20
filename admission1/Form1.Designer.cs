namespace Proiect_Final_Paw
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citireTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citireBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candidatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repartizareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosarCandidatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afiseazaDosarCandidatXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locuriDisponibileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem,
            this.gestionareToolStripMenuItem,
            this.dosarCandidatToolStripMenuItem,
            this.statisticiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareTextToolStripMenuItem,
            this.citireTextToolStripMenuItem,
            this.salvareBinarToolStripMenuItem,
            this.citireBinarToolStripMenuItem});
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(68, 29);
            this.fisierToolStripMenuItem.Text = "Fisier";
            // 
            // salvareTextToolStripMenuItem
            // 
            this.salvareTextToolStripMenuItem.Name = "salvareTextToolStripMenuItem";
            this.salvareTextToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.salvareTextToolStripMenuItem.Text = "Salvare Text";
            this.salvareTextToolStripMenuItem.Click += new System.EventHandler(this.salvareTextToolStripMenuItem_Click);
            // 
            // citireTextToolStripMenuItem
            // 
            this.citireTextToolStripMenuItem.Name = "citireTextToolStripMenuItem";
            this.citireTextToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.citireTextToolStripMenuItem.Text = "Citire Text";
            this.citireTextToolStripMenuItem.Click += new System.EventHandler(this.citireTextToolStripMenuItem_Click);
            // 
            // salvareBinarToolStripMenuItem
            // 
            this.salvareBinarToolStripMenuItem.Name = "salvareBinarToolStripMenuItem";
            this.salvareBinarToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.salvareBinarToolStripMenuItem.Text = "Salvare Binar";
            this.salvareBinarToolStripMenuItem.Click += new System.EventHandler(this.salvareBinarToolStripMenuItem_Click);
            // 
            // citireBinarToolStripMenuItem
            // 
            this.citireBinarToolStripMenuItem.Name = "citireBinarToolStripMenuItem";
            this.citireBinarToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.citireBinarToolStripMenuItem.Text = "Citire Binar";
            this.citireBinarToolStripMenuItem.Click += new System.EventHandler(this.citireBinarToolStripMenuItem_Click);
            // 
            // gestionareToolStripMenuItem
            // 
            this.gestionareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.candidatiToolStripMenuItem,
            this.repartizareToolStripMenuItem});
            this.gestionareToolStripMenuItem.Name = "gestionareToolStripMenuItem";
            this.gestionareToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.gestionareToolStripMenuItem.Text = "Gestionare";
            // 
            // candidatiToolStripMenuItem
            // 
            this.candidatiToolStripMenuItem.Name = "candidatiToolStripMenuItem";
            this.candidatiToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.candidatiToolStripMenuItem.Text = "Candidati";
            this.candidatiToolStripMenuItem.Click += new System.EventHandler(this.candidatiToolStripMenuItem_Click);
            // 
            // repartizareToolStripMenuItem
            // 
            this.repartizareToolStripMenuItem.Name = "repartizareToolStripMenuItem";
            this.repartizareToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.repartizareToolStripMenuItem.Text = "Repartizare";
            this.repartizareToolStripMenuItem.Click += new System.EventHandler(this.repartizareToolStripMenuItem_Click);
            // 
            // dosarCandidatToolStripMenuItem
            // 
            this.dosarCandidatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gToolStripMenuItem,
            this.afiseazaDosarCandidatXMLToolStripMenuItem});
            this.dosarCandidatToolStripMenuItem.Name = "dosarCandidatToolStripMenuItem";
            this.dosarCandidatToolStripMenuItem.Size = new System.Drawing.Size(151, 29);
            this.dosarCandidatToolStripMenuItem.Text = "Dosar Candidat";
            // 
            // gToolStripMenuItem
            // 
            this.gToolStripMenuItem.Name = "gToolStripMenuItem";
            this.gToolStripMenuItem.Size = new System.Drawing.Size(363, 34);
            this.gToolStripMenuItem.Text = "Genereaza Dosar Candidat XML";
            this.gToolStripMenuItem.Click += new System.EventHandler(this.gToolStripMenuItem_Click);
            // 
            // afiseazaDosarCandidatXMLToolStripMenuItem
            // 
            this.afiseazaDosarCandidatXMLToolStripMenuItem.Name = "afiseazaDosarCandidatXMLToolStripMenuItem";
            this.afiseazaDosarCandidatXMLToolStripMenuItem.Size = new System.Drawing.Size(363, 34);
            this.afiseazaDosarCandidatXMLToolStripMenuItem.Text = "Afiseaza Dosar Candidat XML";
            this.afiseazaDosarCandidatXMLToolStripMenuItem.Click += new System.EventHandler(this.afiseazaDosarCandidatXMLToolStripMenuItem_Click);
            // 
            // statisticiToolStripMenuItem
            // 
            this.statisticiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graficToolStripMenuItem,
            this.locuriDisponibileToolStripMenuItem});
            this.statisticiToolStripMenuItem.Name = "statisticiToolStripMenuItem";
            this.statisticiToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.statisticiToolStripMenuItem.Text = "Statistici";
            // 
            // graficToolStripMenuItem
            // 
            this.graficToolStripMenuItem.Name = "graficToolStripMenuItem";
            this.graficToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.graficToolStripMenuItem.Text = "Grafic Admitere";
            this.graficToolStripMenuItem.Click += new System.EventHandler(this.graficToolStripMenuItem_Click);
            // 
            // locuriDisponibileToolStripMenuItem
            // 
            this.locuriDisponibileToolStripMenuItem.Name = "locuriDisponibileToolStripMenuItem";
            this.locuriDisponibileToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.locuriDisponibileToolStripMenuItem.Text = "Locuri Disponibile";
            this.locuriDisponibileToolStripMenuItem.Click += new System.EventHandler(this.locuriDisponibileToolStripMenuItem_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Admitere Facultate";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citireTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citireBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem candidatiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repartizareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosarCandidatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afiseazaDosarCandidatXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locuriDisponibileToolStripMenuItem;
    }
}

