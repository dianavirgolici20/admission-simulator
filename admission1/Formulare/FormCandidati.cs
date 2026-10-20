using Proiect_Final_Paw.Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect_Final_Paw.Formulare;

namespace Proiect_Final_Paw.Formulare
{

    public partial class FormCandidati : Form
    {
        BindingList<Candidat> candidati = new BindingList<Candidat>();
        Specializare info = new Specializare();
        public BindingList<Candidat> ListaCandidati
        {
            get { return candidati; }
        }
        public DataGridView DataGrid
        {
            get { return dgvCandidati; }
        }
        int indexSelectat = -1;
        public FormCandidati()
        {
            InitializeComponent();

            BindingSource bs = new BindingSource();
            bs.DataSource = candidati;

            dgvCandidati.SelectionChanged += (s, e) =>
            {
                if (dgvCandidati.CurrentRow != null && dgvCandidati.CurrentRow.Index >= 0)
                    bs.Position = dgvCandidati.CurrentRow.Index;
            };
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbNume.Text))
                    throw new Exception("Introdu numele!");

                if (string.IsNullOrWhiteSpace(tbPrenume.Text))
                    throw new Exception("Introdu prenumele!");

                if (tbCNP.Text.Length != 13)
                    throw new Exception("CNP-ul trebuie sa aiba 13 cifre!");

                if (!double.TryParse(tbMedieBac.Text, out double bac) || bac < 6 || bac > 10)
                    throw new Exception("Media de bac trebuie sa fie intre 6 si 10!");

                if (!double.TryParse(tbNotaExamen.Text, out double examen) || examen < 5 || examen > 10)
                    throw new Exception("Nota examen trebuie sa fie peste 5!");

                if (cbOptiune1.SelectedIndex == -1)
                    throw new Exception("Selecteaza prima optiune!");

                if (cbOptiune2.SelectedIndex == -1)
                    throw new Exception("Selecteaza a doua optiune!");

                if (cbOptiune3.SelectedIndex == -1)
                    throw new Exception("Selecteaza a treia optiune!");

                if (cbOptiune1.Text == cbOptiune2.Text || cbOptiune1.Text == cbOptiune3.Text || cbOptiune2.Text == cbOptiune3.Text)
                {
                    throw new Exception("Optiunile trebuie sa fie diferite!");
                }

                Candidat c = new Candidat(
                    tbNume.Text,
                    tbPrenume.Text,
                    tbCNP.Text,
                    bac,
                    examen
                );

                foreach (Candidat candidatExistent in candidati)
                {
                    if (candidatExistent.CNP == tbCNP.Text)
                    {
                        MessageBox.Show(
                            "Exista deja un candidat cu acest CNP!",
                            "Eroare",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );

                        return;
                    }
                }

                candidati.Add(c);

                Dosar dosar = new Dosar(c);
                Specializare s1 = new Specializare(cbOptiune1.Text, 0);
                Specializare s2 = new Specializare(cbOptiune2.Text, 0);
                Specializare s3 = new Specializare(cbOptiune3.Text, 0);

                dosar = dosar + s1; 
                dosar = dosar + s2;
                dosar = dosar + s3;
                dosar++;           

                Dosar copie = (Dosar)dosar.Clone();

                dgvCandidati.Rows.Add(
                    c.Nume,
                    c.Prenume,
                    c.CNP,
                    c.MedieBac,
                    c.NotaExamen,
                    c.CalculeazaMedie().ToString("F2"),
                    cbOptiune1.Text,
                    cbOptiune2.Text,
                    cbOptiune3.Text,
                    "Nerepartizat"
                );

                MessageBox.Show("Candidatul"+ c.ToString()+ "adaugat!");

                tbNume.Clear();
                tbPrenume.Clear();
                tbCNP.Clear();
                tbMedieBac.Clear();
                tbNotaExamen.Clear();
                cbOptiune1.SelectedIndex = -1;
                cbOptiune2.SelectedIndex = -1;
                cbOptiune3.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message);
            }
        }

        private void dgvCandidati_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCandidati.Rows[e.RowIndex].Cells[0].Value != null)
            {
                indexSelectat = e.RowIndex;

                tbNume.Text = dgvCandidati.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbPrenume.Text = dgvCandidati.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbCNP.Text = dgvCandidati.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbMedieBac.Text = dgvCandidati.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbNotaExamen.Text = dgvCandidati.Rows[e.RowIndex].Cells[4].Value.ToString();

                cbOptiune1.Text = dgvCandidati.Rows[e.RowIndex].Cells[6].Value.ToString();
                cbOptiune2.Text = dgvCandidati.Rows[e.RowIndex].Cells[7].Value.ToString();
                cbOptiune3.Text = dgvCandidati.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (indexSelectat >= 0)
            {
                if (!double.TryParse(tbMedieBac.Text, out double bac) || bac < 1 || bac > 10)
                {
                    MessageBox.Show("Media de bac trebuie sa fie intre 1 si 10!");
                    return;
                }

                if (!double.TryParse(tbNotaExamen.Text, out double examen) || examen < 1 || examen > 10)
                {
                    MessageBox.Show("Nota examen trebuie sa fie intre 1 si 10!");
                    return;
                }

                if (cbOptiune1.Text == cbOptiune2.Text ||
                cbOptiune1.Text == cbOptiune3.Text ||
                cbOptiune2.Text == cbOptiune3.Text)
                {
                    throw new Exception("Optiunile trebuie sa fie diferite!");
                }

                double medie = bac * 0.6 + examen * 0.4;

                dgvCandidati.Rows[indexSelectat].Cells[0].Value = tbNume.Text;
                dgvCandidati.Rows[indexSelectat].Cells[1].Value = tbPrenume.Text;
                dgvCandidati.Rows[indexSelectat].Cells[2].Value = tbCNP.Text;
                dgvCandidati.Rows[indexSelectat].Cells[3].Value = bac;
                dgvCandidati.Rows[indexSelectat].Cells[4].Value = examen;
                dgvCandidati.Rows[indexSelectat].Cells[5].Value = medie.ToString("F2");
                dgvCandidati.Rows[indexSelectat].Cells[6].Value = cbOptiune1.Text;
                dgvCandidati.Rows[indexSelectat].Cells[7].Value = cbOptiune2.Text;
                dgvCandidati.Rows[indexSelectat].Cells[8].Value = cbOptiune3.Text;
                dgvCandidati.Rows[indexSelectat].Cells[9].Value = "Nerepartizat";

                MessageBox.Show("Candidat modificat!");

                tbNume.Clear();
                tbPrenume.Clear();
                tbCNP.Clear();
                tbMedieBac.Clear();
                tbNotaExamen.Clear();
                cbOptiune1.SelectedIndex = -1;
                cbOptiune2.SelectedIndex = -1;
                cbOptiune3.SelectedIndex = -1;

                indexSelectat = -1;
                dgvCandidati.ClearSelection();
            }
            else
            {
                MessageBox.Show("Selecteaza un candidat!");
            }
        }

        private void Sterge_Click(object sender, EventArgs e)
        {
            if (indexSelectat >= 0)
            {

                DialogResult result = MessageBox.Show(
                    "Sigur doresti sa stergi candidatul selectat?",
                    "Confirmare stergere",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    candidati.RemoveAt(indexSelectat);
                    dgvCandidati.Rows.RemoveAt(indexSelectat);
                    

                    tbNume.Clear();
                    tbPrenume.Clear();
                    tbCNP.Clear();
                    tbMedieBac.Clear();
                    tbNotaExamen.Clear();
                    cbOptiune1.SelectedIndex = -1;
                    cbOptiune2.SelectedIndex = -1;
                    cbOptiune3.SelectedIndex = -1;

                    indexSelectat = -1;

                    MessageBox.Show("Candidat sters!");
                }
            }
            else
            {
                MessageBox.Show("Selecteaza un candidat!");
            }
        }

        private void vizualizeazaDosarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvCandidati.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecteaza un candidat!");
                return;
            }

            DataGridViewRow row = dgvCandidati.SelectedRows[0];

            string nume = row.Cells[0].Value.ToString();
            string prenume = row.Cells[1].Value.ToString();
            string cnp = row.Cells[2].Value.ToString();

            double medieBac =
                Convert.ToDouble(row.Cells[3].Value);

            double notaExamen =
                Convert.ToDouble(row.Cells[4].Value);

            string rezultat =
                row.Cells[9].Value != null
                ? row.Cells[9].Value.ToString()
                : "Nerepartizat";



            Candidat c = new Candidat(
                nume,
                prenume,
                cnp,
                medieBac,
                notaExamen
            );

            c.Rezultat = rezultat;
            Dosar d = new Dosar(c);

            if (c.CalculeazaMedie() >= 9)
                d++;

            else if (c.CalculeazaMedie() < 7)
                d--;

            MessageBox.Show(
                d.ToString(),
                "Dosar candidat",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void FormCandidati_Load(object sender, EventArgs e)
        {

        }
    }
}
