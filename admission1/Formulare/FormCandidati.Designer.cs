namespace Proiect_Final_Paw.Formulare
{
    partial class FormCandidati
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
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.tbCNP = new System.Windows.Forms.TextBox();
            this.tbMedieBac = new System.Windows.Forms.TextBox();
            this.tbNotaExamen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.Sterge = new System.Windows.Forms.Button();
            this.dgvCandidati = new System.Windows.Forms.DataGridView();
            this.colNume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrenume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCNP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExamen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdmitere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOptiune1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOptiune2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOptiune3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRezultat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vizualizeazaDosarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbOptiune2 = new System.Windows.Forms.ComboBox();
            this.cbOptiune1 = new System.Windows.Forms.ComboBox();
            this.cbOptiune3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidati)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(203, 32);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(199, 26);
            this.tbNume.TabIndex = 0;
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(203, 89);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(199, 26);
            this.tbPrenume.TabIndex = 1;
            // 
            // tbCNP
            // 
            this.tbCNP.Location = new System.Drawing.Point(203, 142);
            this.tbCNP.Name = "tbCNP";
            this.tbCNP.Size = new System.Drawing.Size(199, 26);
            this.tbCNP.TabIndex = 2;
            // 
            // tbMedieBac
            // 
            this.tbMedieBac.Location = new System.Drawing.Point(203, 205);
            this.tbMedieBac.Name = "tbMedieBac";
            this.tbMedieBac.Size = new System.Drawing.Size(199, 26);
            this.tbMedieBac.TabIndex = 3;
            // 
            // tbNotaExamen
            // 
            this.tbNotaExamen.Location = new System.Drawing.Point(203, 263);
            this.tbNotaExamen.Name = "tbNotaExamen";
            this.tbNotaExamen.Size = new System.Drawing.Size(199, 26);
            this.tbNotaExamen.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nume:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Prenume:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "CNP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Medie Bac:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nota Examen:";
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(38, 406);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(143, 34);
            this.btnAdauga.TabIndex = 12;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(221, 406);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(143, 34);
            this.btnModifica.TabIndex = 13;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // Sterge
            // 
            this.Sterge.Location = new System.Drawing.Point(401, 406);
            this.Sterge.Name = "Sterge";
            this.Sterge.Size = new System.Drawing.Size(143, 34);
            this.Sterge.TabIndex = 14;
            this.Sterge.Text = "Sterge";
            this.Sterge.UseVisualStyleBackColor = true;
            this.Sterge.Click += new System.EventHandler(this.Sterge_Click);
            // 
            // dgvCandidati
            // 
            this.dgvCandidati.AllowUserToAddRows = false;
            this.dgvCandidati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidati.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNume,
            this.colPrenume,
            this.colCNP,
            this.colBac,
            this.colExamen,
            this.colAdmitere,
            this.colOptiune1,
            this.colOptiune2,
            this.colOptiune3,
            this.colRezultat});
            this.dgvCandidati.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvCandidati.Location = new System.Drawing.Point(38, 465);
            this.dgvCandidati.MultiSelect = false;
            this.dgvCandidati.Name = "dgvCandidati";
            this.dgvCandidati.RowHeadersWidth = 62;
            this.dgvCandidati.RowTemplate.Height = 28;
            this.dgvCandidati.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCandidati.Size = new System.Drawing.Size(1083, 364);
            this.dgvCandidati.TabIndex = 15;
            this.dgvCandidati.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCandidati_CellClick);
            // 
            // colNume
            // 
            this.colNume.HeaderText = "Nume";
            this.colNume.MinimumWidth = 8;
            this.colNume.Name = "colNume";
            this.colNume.Width = 150;
            // 
            // colPrenume
            // 
            this.colPrenume.HeaderText = "Prenume";
            this.colPrenume.MinimumWidth = 8;
            this.colPrenume.Name = "colPrenume";
            this.colPrenume.Width = 150;
            // 
            // colCNP
            // 
            this.colCNP.HeaderText = "CNP";
            this.colCNP.MinimumWidth = 8;
            this.colCNP.Name = "colCNP";
            this.colCNP.Width = 150;
            // 
            // colBac
            // 
            this.colBac.HeaderText = "Medie Bac";
            this.colBac.MinimumWidth = 8;
            this.colBac.Name = "colBac";
            this.colBac.Width = 150;
            // 
            // colExamen
            // 
            this.colExamen.HeaderText = "Nota Examen";
            this.colExamen.MinimumWidth = 8;
            this.colExamen.Name = "colExamen";
            this.colExamen.Width = 150;
            // 
            // colAdmitere
            // 
            this.colAdmitere.HeaderText = "Medie Admitere";
            this.colAdmitere.MinimumWidth = 8;
            this.colAdmitere.Name = "colAdmitere";
            this.colAdmitere.Width = 150;
            // 
            // colOptiune1
            // 
            this.colOptiune1.HeaderText = "Optiune 1";
            this.colOptiune1.MinimumWidth = 8;
            this.colOptiune1.Name = "colOptiune1";
            this.colOptiune1.Width = 150;
            // 
            // colOptiune2
            // 
            this.colOptiune2.HeaderText = "Optiune 2";
            this.colOptiune2.MinimumWidth = 8;
            this.colOptiune2.Name = "colOptiune2";
            this.colOptiune2.Width = 150;
            // 
            // colOptiune3
            // 
            this.colOptiune3.HeaderText = "Optiune 3";
            this.colOptiune3.MinimumWidth = 8;
            this.colOptiune3.Name = "colOptiune3";
            this.colOptiune3.Width = 150;
            // 
            // colRezultat
            // 
            this.colRezultat.HeaderText = "Rezultat";
            this.colRezultat.MinimumWidth = 8;
            this.colRezultat.Name = "colRezultat";
            this.colRezultat.Width = 150;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vizualizeazaDosarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(230, 36);
            // 
            // vizualizeazaDosarToolStripMenuItem
            // 
            this.vizualizeazaDosarToolStripMenuItem.Name = "vizualizeazaDosarToolStripMenuItem";
            this.vizualizeazaDosarToolStripMenuItem.Size = new System.Drawing.Size(229, 32);
            this.vizualizeazaDosarToolStripMenuItem.Text = "Vizualizeaza Dosar";
            this.vizualizeazaDosarToolStripMenuItem.Click += new System.EventHandler(this.vizualizeazaDosarToolStripMenuItem_Click);
            // 
            // cbOptiune2
            // 
            this.cbOptiune2.FormattingEnabled = true;
            this.cbOptiune2.Items.AddRange(new object[] {
            "Informatica Economica",
            "Cibernetica Economica",
            "Statistica",
            "Marketing",
            "Management"});
            this.cbOptiune2.Location = new System.Drawing.Point(285, 342);
            this.cbOptiune2.Name = "cbOptiune2";
            this.cbOptiune2.Size = new System.Drawing.Size(199, 28);
            this.cbOptiune2.TabIndex = 17;
            // 
            // cbOptiune1
            // 
            this.cbOptiune1.FormattingEnabled = true;
            this.cbOptiune1.Items.AddRange(new object[] {
            "Informatica Economica",
            "Cibernetica Economica",
            "Statistica",
            "Marketing",
            "Management"});
            this.cbOptiune1.Location = new System.Drawing.Point(29, 342);
            this.cbOptiune1.Name = "cbOptiune1";
            this.cbOptiune1.Size = new System.Drawing.Size(199, 28);
            this.cbOptiune1.TabIndex = 18;
            // 
            // cbOptiune3
            // 
            this.cbOptiune3.FormattingEnabled = true;
            this.cbOptiune3.Items.AddRange(new object[] {
            "Informatica Economica",
            "Cibernetica Economica",
            "Statistica",
            "Marketing",
            "Management"});
            this.cbOptiune3.Location = new System.Drawing.Point(549, 342);
            this.cbOptiune3.Name = "cbOptiune3";
            this.cbOptiune3.Size = new System.Drawing.Size(199, 28);
            this.cbOptiune3.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Optiune 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(281, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Optiune 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(545, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Optiune 3";
            // 
            // FormCandidati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 892);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbOptiune3);
            this.Controls.Add(this.cbOptiune1);
            this.Controls.Add(this.cbOptiune2);
            this.Controls.Add(this.dgvCandidati);
            this.Controls.Add(this.Sterge);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNotaExamen);
            this.Controls.Add(this.tbMedieBac);
            this.Controls.Add(this.tbCNP);
            this.Controls.Add(this.tbPrenume);
            this.Controls.Add(this.tbNume);
            this.Name = "FormCandidati";
            this.Text = "Gestionare Candidati";
            this.Load += new System.EventHandler(this.FormCandidati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidati)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbPrenume;
        private System.Windows.Forms.TextBox tbCNP;
        private System.Windows.Forms.TextBox tbMedieBac;
        private System.Windows.Forms.TextBox tbNotaExamen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button Sterge;
        private System.Windows.Forms.DataGridView dgvCandidati;
        private System.Windows.Forms.ComboBox cbOptiune2;
        private System.Windows.Forms.ComboBox cbOptiune1;
        private System.Windows.Forms.ComboBox cbOptiune3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNume;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrenume;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCNP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBac;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExamen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdmitere;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOptiune1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOptiune2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOptiune3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRezultat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vizualizeazaDosarToolStripMenuItem;
    }
}