namespace Proiect_Final_Paw.Formulare
{
    partial class FormRepartizare
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
            this.btnRepartizeaza = new System.Windows.Forms.Button();
            this.lvInfo = new System.Windows.Forms.ListView();
            this.colNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMedie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCibe = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvMark = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvMan = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrinteaza = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lvRespinsi = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvStat = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnRepartizeaza
            // 
            this.btnRepartizeaza.Location = new System.Drawing.Point(499, 12);
            this.btnRepartizeaza.Name = "btnRepartizeaza";
            this.btnRepartizeaza.Size = new System.Drawing.Size(179, 82);
            this.btnRepartizeaza.TabIndex = 0;
            this.btnRepartizeaza.Text = "Repartizeaza Candidati";
            this.btnRepartizeaza.UseVisualStyleBackColor = true;
            this.btnRepartizeaza.Click += new System.EventHandler(this.btnRepartizeaza_Click);
            // 
            // lvInfo
            // 
            this.lvInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNume,
            this.colPrenume,
            this.colMedie});
            this.lvInfo.GridLines = true;
            this.lvInfo.HideSelection = false;
            this.lvInfo.Location = new System.Drawing.Point(72, 177);
            this.lvInfo.Name = "lvInfo";
            this.lvInfo.Size = new System.Drawing.Size(446, 202);
            this.lvInfo.TabIndex = 1;
            this.lvInfo.UseCompatibleStateImageBehavior = false;
            this.lvInfo.View = System.Windows.Forms.View.Details;
            // 
            // colNume
            // 
            this.colNume.Text = "Nume";
            this.colNume.Width = 148;
            // 
            // colPrenume
            // 
            this.colPrenume.Text = "Prenume";
            this.colPrenume.Width = 145;
            // 
            // colMedie
            // 
            this.colMedie.Text = "Medie";
            this.colMedie.Width = 164;
            // 
            // lvCibe
            // 
            this.lvCibe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvCibe.GridLines = true;
            this.lvCibe.HideSelection = false;
            this.lvCibe.Location = new System.Drawing.Point(640, 177);
            this.lvCibe.Name = "lvCibe";
            this.lvCibe.Size = new System.Drawing.Size(446, 202);
            this.lvCibe.TabIndex = 2;
            this.lvCibe.UseCompatibleStateImageBehavior = false;
            this.lvCibe.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nume";
            this.columnHeader1.Width = 148;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Prenume";
            this.columnHeader2.Width = 145;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Medie";
            this.columnHeader3.Width = 164;
            // 
            // lvMark
            // 
            this.lvMark.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvMark.GridLines = true;
            this.lvMark.HideSelection = false;
            this.lvMark.Location = new System.Drawing.Point(72, 498);
            this.lvMark.Name = "lvMark";
            this.lvMark.Size = new System.Drawing.Size(446, 202);
            this.lvMark.TabIndex = 3;
            this.lvMark.UseCompatibleStateImageBehavior = false;
            this.lvMark.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nume";
            this.columnHeader4.Width = 148;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Prenume";
            this.columnHeader5.Width = 145;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Medie";
            this.columnHeader6.Width = 164;
            // 
            // lvMan
            // 
            this.lvMan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvMan.GridLines = true;
            this.lvMan.HideSelection = false;
            this.lvMan.Location = new System.Drawing.Point(640, 498);
            this.lvMan.Name = "lvMan";
            this.lvMan.Size = new System.Drawing.Size(446, 202);
            this.lvMan.TabIndex = 4;
            this.lvMan.UseCompatibleStateImageBehavior = false;
            this.lvMan.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Nume";
            this.columnHeader7.Width = 148;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Prenume";
            this.columnHeader8.Width = 145;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Medie";
            this.columnHeader9.Width = 164;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Repartizare Specializare Informatica Economica";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(683, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Repartizare Specializare Cibernetica Economica";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Repartizare Specializare Marketing";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(733, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Repartizare Specializare Management";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1421, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Respinsi";
            // 
            // btnPrinteaza
            // 
            this.btnPrinteaza.Location = new System.Drawing.Point(963, 12);
            this.btnPrinteaza.Name = "btnPrinteaza";
            this.btnPrinteaza.Size = new System.Drawing.Size(179, 82);
            this.btnPrinteaza.TabIndex = 13;
            this.btnPrinteaza.Text = "Printeaza Raport";
            this.btnPrinteaza.UseVisualStyleBackColor = true;
            this.btnPrinteaza.Click += new System.EventHandler(this.btnPrinteaza_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1253, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Repartizare Specializare Statistica";
            // 
            // lvRespinsi
            // 
            this.lvRespinsi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.lvRespinsi.GridLines = true;
            this.lvRespinsi.HideSelection = false;
            this.lvRespinsi.Location = new System.Drawing.Point(1216, 498);
            this.lvRespinsi.Name = "lvRespinsi";
            this.lvRespinsi.Size = new System.Drawing.Size(446, 202);
            this.lvRespinsi.TabIndex = 15;
            this.lvRespinsi.UseCompatibleStateImageBehavior = false;
            this.lvRespinsi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Nume";
            this.columnHeader13.Width = 148;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Prenume";
            this.columnHeader14.Width = 145;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Medie";
            this.columnHeader15.Width = 164;
            // 
            // lvStat
            // 
            this.lvStat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lvStat.GridLines = true;
            this.lvStat.HideSelection = false;
            this.lvStat.Location = new System.Drawing.Point(1216, 177);
            this.lvStat.Name = "lvStat";
            this.lvStat.Size = new System.Drawing.Size(446, 202);
            this.lvStat.TabIndex = 14;
            this.lvStat.UseCompatibleStateImageBehavior = false;
            this.lvStat.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Nume";
            this.columnHeader10.Width = 148;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Prenume";
            this.columnHeader11.Width = 145;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Medie";
            this.columnHeader12.Width = 164;
            // 
            // FormRepartizare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1865, 789);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvRespinsi);
            this.Controls.Add(this.lvStat);
            this.Controls.Add(this.btnPrinteaza);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvMan);
            this.Controls.Add(this.lvMark);
            this.Controls.Add(this.lvCibe);
            this.Controls.Add(this.lvInfo);
            this.Controls.Add(this.btnRepartizeaza);
            this.Name = "FormRepartizare";
            this.Text = "Repartizare Candidati";
            this.Load += new System.EventHandler(this.FormRepartizare_Load);
            this.Click += new System.EventHandler(this.FormRepartizare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRepartizeaza;
        private System.Windows.Forms.ListView lvInfo;
        private System.Windows.Forms.ColumnHeader colNume;
        private System.Windows.Forms.ColumnHeader colPrenume;
        private System.Windows.Forms.ColumnHeader colMedie;
        private System.Windows.Forms.ListView lvCibe;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lvMark;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView lvMan;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPrinteaza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvRespinsi;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ListView lvStat;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}