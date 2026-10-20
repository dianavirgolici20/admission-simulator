using Proiect_Final_Paw.Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proiect_Final_Paw.Formulare
{
    public partial class FormRepartizare : Form
    {
        private List<Specializare> specializari;

        public FormRepartizare(List<Candidat> candidati)
        {
            InitializeComponent();

            specializari = new List<Specializare>();

            specializari.Add(new Specializare("Informatica Economica", 3));
            specializari.Add(new Specializare("Cibernetica Economica", 2));
            specializari.Add(new Specializare("Statistica", 2));
            specializari.Add(new Specializare("Marketing", 2));
            specializari.Add(new Specializare("Management", 1));
        }

        private FormCandidati _formCandidati;

        public FormRepartizare(FormCandidati formCandidati)
        {
            InitializeComponent();
            _formCandidati = formCandidati;
            InitializeListViews();

        }
        public FormRepartizare()
        {
            InitializeComponent();
            
        }

        private DatabaseHelper _db = new DatabaseHelper();
        private DataTable _datePrintare;
        private int _randCurent = 0;

        private void InitializeListViews()
        {
            foreach (var lv in new[] { lvInfo, lvCibe, lvStat, lvMark, lvMan, lvRespinsi })
            {
                lv.View = View.Details;
                lv.FullRowSelect = true;
                lv.GridLines = true;
                lv.Columns.Clear();
                lv.Columns.Add("Nume", 150);
                lv.Columns.Add("Prenume", 150);
                lv.Columns.Add("Medie", 70);
            }
        }

        private void FormRepartizare_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRepartizeaza_Click(object sender, EventArgs e)
        {
            try
            {
                _db.SalveazaCandidatiDinGrid(_formCandidati.DataGrid);

                _db.RuleazaAdmiterea();

                PopuleazaListViews();

                DataTable dt = _db.GetCandidati();

                foreach (DataGridViewRow row in _formCandidati.DataGrid.Rows)
                {
                    if (row.Cells[2].Value != null)
                    {
                        string cnp = row.Cells[2].Value.ToString();

                        foreach (DataRow dr in dt.Rows)
                        {
                            if (dr["CNP"].ToString() == cnp)
                            {
                                string status = dr["Status"].ToString();
                                string spec = dr["SpecializareRepartizata"] == DBNull.Value
                                    ? ""
                                    : dr["SpecializareRepartizata"].ToString();

                                if (status == "Admis")
                                    row.Cells[9].Value = "ADMIS la " + spec;
                                else
                                    row.Cells[9].Value = "RESPINS";

                                break;
                            }
                        }
                    }
                }

                MessageBox.Show(
                    "Repartizarea a fost efectuata cu succes!",
                    "Succes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Eroare",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void PopuleazaListViews()
        {
            UmpleListView(lvInfo, "Informatica Economica");
            UmpleListView(lvCibe, "Cibernetica Economica");
            UmpleListView(lvStat, "Statistica");
            UmpleListView(lvMark, "Marketing");
            UmpleListView(lvMan, "Management");
            UmpleListViewRespinsi();
        }

        private void UmpleListView(ListView lv, string specializare)
        {
            lv.Items.Clear();
            DataTable dt = _db.GetAdmisiPerSpecializare(specializare);

            foreach (DataRow row in dt.Rows)
            {
                var item = new ListViewItem(row["Nume"].ToString());
                item.SubItems.Add(row["Prenume"].ToString());
                item.SubItems.Add(row["Medie"].ToString());
                item.BackColor = Color.LightGreen;
                lv.Items.Add(item);
            }
        }

        private void UmpleListViewRespinsi()
        {
            lvRespinsi.Items.Clear();
            DataTable dt = _db.GetRespinsi();

            foreach (DataRow row in dt.Rows)
            {
                var item = new ListViewItem(row["Nume"].ToString());
                item.SubItems.Add(row["Prenume"].ToString());
                item.SubItems.Add(row["Medie"].ToString());
                item.BackColor = Color.LightCoral;
                lvRespinsi.Items.Add(item);
            }
        }

        private void btnPrinteaza_Click(object sender, EventArgs e)
        {
            try
            {
                _datePrintare = _db.GetToateRezultatele();
                _randCurent = 0;

                PrintDocument pd = new PrintDocument();
                pd.PrintPage += PrintPage_Handler;

                PrintPreviewDialog preview = new PrintPreviewDialog();
                preview.Document = pd;
                preview.Width = 900;
                preview.Height = 700;
                preview.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintPage_Handler(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            float y = 40f;
            float x = 40f;

            Font fontTitlu = new Font("Arial", 14, FontStyle.Bold);
            Font fontHeader = new Font("Arial", 10, FontStyle.Bold);
            Font fontNormal = new Font("Arial", 9, FontStyle.Regular);

            g.DrawString("REZULTATE ADMITERE", fontTitlu, Brushes.Black, x, y);
            y += 24;
            g.DrawString($"Data: {DateTime.Now:dd.MM.yyyy HH:mm}", fontNormal, Brushes.Black, x, y);
            y += 30;
            g.DrawLine(Pens.Black, x, y, 760, y);
            y += 10;

            g.DrawString("Nume", fontHeader, Brushes.Black, x, y);
            g.DrawString("Prenume", fontHeader, Brushes.Black, x + 130, y);
            g.DrawString("Medie", fontHeader, Brushes.Black, x + 260, y);
            g.DrawString("Status", fontHeader, Brushes.Black, x + 330, y);
            g.DrawString("Repartizat", fontHeader, Brushes.Black, x + 410, y);
            y += 20;
            g.DrawLine(Pens.Gray, x, y, 760, y);
            y += 6;

            while (_randCurent < _datePrintare.Rows.Count)
            {
                DataRow row = _datePrintare.Rows[_randCurent];
                string status = row["Status"].ToString();
                Brush bStatus = status == "Admis" ? Brushes.DarkGreen : Brushes.DarkRed;

                g.DrawString(row["Nume"].ToString(), fontNormal, Brushes.Black, x, y);
                g.DrawString(row["Prenume"].ToString(), fontNormal, Brushes.Black, x + 130, y);
                g.DrawString(row["Medie"].ToString(), fontNormal, Brushes.Black, x + 260, y);
                g.DrawString(status, fontNormal, bStatus, x + 330, y);
                g.DrawString(row["Repartizat"]?.ToString() ?? "-", fontNormal, Brushes.Black, x + 410, y);

                y += 18;
                _randCurent++;

                if (y > e.MarginBounds.Bottom - 30)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            y += 10;
            g.DrawLine(Pens.Black, x, y, 760, y);
            y += 8;

            int admisi = 0, respinsi = 0;
            foreach (DataRow row in _datePrintare.Rows)
            {
                if (row["Status"].ToString() == "Admis") admisi++;
                else respinsi++;
            }
            g.DrawString($"Total admisi: {admisi}   |   Total respinsi: {respinsi}",
                fontHeader, Brushes.Black, x, y);

            _randCurent = 0;
            e.HasMorePages = false;
        }
    }
}
