using Microsoft.VisualBasic;
using Proiect_Final_Paw.Clase;
using Proiect_Final_Paw.Formulare;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Proiect_Final_Paw
{
    public partial class Form1 : Form
    {
        private Comisie _comisie = new Comisie();
        private DatabaseHelper _db = new DatabaseHelper();
        FormCandidati formCandidati = new FormCandidati();
        public Form1()
        {
            InitializeComponent();
            DataTable dt = _db.GetSpecializari();
            foreach (DataRow row in dt.Rows)
                _comisie.AdaugaSpecializare(new Specializare(
                    row["Nume"].ToString(),
                    Convert.ToInt32(row["NrLocuri"])
                ));
        }

        private void locuriDisponibileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mesaj = "Locuri disponibile per specializare:\n\n";

            foreach (Specializare s in _comisie)
                mesaj += $"{s.Denumire}: {s.NrLocuri} locuri\n";

            MessageBox.Show(mesaj, "Locuri disponibile",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void candidatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCandidati.ShowDialog();
        }

        private void repartizareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRepartizare formRepartizare = new FormRepartizare(formCandidati);
            formRepartizare.ShowDialog();
        }

        private void salvareTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("candidati.txt"))
            {
                foreach (DataGridViewRow row in formCandidati.DataGrid.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        sw.WriteLine(
                            row.Cells[0].Value + ";" +
                            row.Cells[1].Value + ";" +
                            row.Cells[2].Value + ";" +
                            row.Cells[3].Value + ";" +
                            row.Cells[4].Value + ";" +
                            row.Cells[5].Value + ";" +
                            row.Cells[6].Value + ";" +
                            row.Cells[7].Value + ";" +
                            row.Cells[8].Value + ";" +
                            row.Cells[9].Value
                        );
                    }
                }
            }
            MessageBox.Show("Date salvate in TXT!");
        }

        private void citireTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cnpCautat = Microsoft.VisualBasic.Interaction.InputBox(
       "Introdu CNP-ul candidatului:",
       "Cautare candidat TXT"
   );

            if (string.IsNullOrWhiteSpace(cnpCautat))
                return;

            bool gasit = false;

            if (!File.Exists("candidati.txt"))
            {
                MessageBox.Show(
                    "Fisierul candidati.txt nu exista! Salveaza intai!",
                    "Eroare",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            using (StreamReader sr = new StreamReader("candidati.txt"))
            {
                string linie;

                while ((linie = sr.ReadLine()) != null)
                {
                    string[] v = linie.Split(';');

                    if (v.Length == 10 && v[2] == cnpCautat)
                    {
                        gasit = true;

                        MessageBox.Show(
                            "Nume: " + v[0] +
                            "\nPrenume: " + v[1] +
                            "\nCNP: " + v[2] +
                            "\nMedie Bac: " + v[3] +
                            "\nNota Examen: " + v[4] +
                            "\nMedie Admitere: " + v[5] +
                            "\nOptiune 1: " + v[6] +
                            "\nOptiune 2: " + v[7] +
                            "\nOptiune 3: " + v[8] +
                            "\nRezultat: " + v[9],
                            "Candidat gasit in TXT"
                        );

                        break;
                    }
                }
            }

            if (!gasit)
                MessageBox.Show("Nu exista candidat cu acest CNP in fisierul TXT!");
        }

        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cnpCautat = Interaction.InputBox(
        "Introdu CNP-ul candidatului:",
        "Generare dosar XML"
    );

            if (string.IsNullOrWhiteSpace(cnpCautat))
                return;

            bool gasit = false;

            foreach (DataGridViewRow row in formCandidati.DataGrid.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[2].Value.ToString() == cnpCautat)
                {
                    gasit = true;

                    XmlDocument doc = new XmlDocument();

                    XmlElement root = doc.CreateElement("DosarCandidat");
                    doc.AppendChild(root);

                    XmlElement nume = doc.CreateElement("Nume");
                    nume.InnerText = row.Cells[0].Value.ToString();
                    root.AppendChild(nume);

                    XmlElement prenume = doc.CreateElement("Prenume");
                    prenume.InnerText = row.Cells[1].Value.ToString();
                    root.AppendChild(prenume);

                    XmlElement cnp = doc.CreateElement("CNP");
                    cnp.InnerText = row.Cells[2].Value.ToString();
                    root.AppendChild(cnp);

                    XmlElement medieBac = doc.CreateElement("MedieBac");
                    medieBac.InnerText = row.Cells[3].Value.ToString();
                    root.AppendChild(medieBac);

                    XmlElement notaExamen = doc.CreateElement("NotaExamen");
                    notaExamen.InnerText = row.Cells[4].Value.ToString();
                    root.AppendChild(notaExamen);

                    XmlElement medieAdmitere = doc.CreateElement("MedieAdmitere");
                    medieAdmitere.InnerText = row.Cells[5].Value.ToString();
                    root.AppendChild(medieAdmitere);

                    XmlElement optiuni = doc.CreateElement("Optiuni");
                    root.AppendChild(optiuni);

                    XmlElement opt1 = doc.CreateElement("Optiune");
                    opt1.InnerText = row.Cells[6].Value.ToString();
                    optiuni.AppendChild(opt1);

                    XmlElement opt2 = doc.CreateElement("Optiune");
                    opt2.InnerText = row.Cells[7].Value.ToString();
                    optiuni.AppendChild(opt2);

                    XmlElement opt3 = doc.CreateElement("Optiune");
                    opt3.InnerText = row.Cells[8].Value.ToString();
                    optiuni.AppendChild(opt3);

                    XmlElement rezultat = doc.CreateElement("Rezultat");
                    rezultat.InnerText = row.Cells[9].Value != null? row.Cells[9].Value.ToString(): "Nerepartizat";
                    root.AppendChild(rezultat);

                    string numeFisier = "dosar_" + cnpCautat + ".xml";
                    doc.Save(numeFisier);

                    MessageBox.Show("Dosarul XML a fost generat: " + numeFisier);
                    break;
                }
            }

            if (!gasit)
                MessageBox.Show("Nu exista candidat cu acest CNP!");
        }

        private void afiseazaDosarCandidatXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cnpCautat = Interaction.InputBox(
       "Introdu CNP-ul candidatului:",
       "Afisare dosar XML"
   );

            if (string.IsNullOrWhiteSpace(cnpCautat))
                return;

            string numeFisier = "dosar_" + cnpCautat + ".xml";

            if (!File.Exists(numeFisier))
            {
                MessageBox.Show("Nu exista dosar XML pentru acest CNP!");
                return;
            }

            XmlDocument doc = new XmlDocument();
            doc.Load(numeFisier);

            XmlNode root = doc.SelectSingleNode("/DosarCandidat");

            string mesaj =
                "Nume: " + root["Nume"].InnerText +
                "\nPrenume: " + root["Prenume"].InnerText +
                "\nCNP: " + root["CNP"].InnerText +
                "\nMedie Bac: " + root["MedieBac"].InnerText +
                "\nNota Examen: " + root["NotaExamen"].InnerText +
                "\nMedie Admitere: " + root["MedieAdmitere"].InnerText +
                "\nOptiune 1: " + root["Optiuni"].ChildNodes[0].InnerText +
                "\nOptiune 2: " + root["Optiuni"].ChildNodes[1].InnerText +
                "\nOptiune 3: " + root["Optiuni"].ChildNodes[2].InnerText +
                "\nRezultat: " + root["Rezultat"].InnerText;

            MessageBox.Show(mesaj, "Dosar candidat XML");
        }

        private void salvareBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (BinaryWriter bw = new BinaryWriter(File.Open("candidati.bin", FileMode.Create)))
            {
                foreach (DataGridViewRow row in formCandidati.DataGrid.Rows)
                {
                    if (row.Cells[0].Value == null) continue;

                    bw.Write(row.Cells[0].Value.ToString()); 
                    bw.Write(row.Cells[1].Value.ToString()); 
                    bw.Write(row.Cells[2].Value.ToString()); 
                    bw.Write(row.Cells[3].Value.ToString()); 
                    bw.Write(row.Cells[4].Value.ToString()); 
                    bw.Write(row.Cells[5].Value.ToString()); 
                    bw.Write(row.Cells[6].Value.ToString()); 
                    bw.Write(row.Cells[7].Value.ToString()); 
                    bw.Write(row.Cells[8].Value.ToString()); 
                    bw.Write(row.Cells[9].Value.ToString()); 
                }
            }
            MessageBox.Show("Date salvate in fisier binar!");
        }

        private void citireBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cnpCautat = Microsoft.VisualBasic.Interaction.InputBox(
        "Introdu CNP-ul candidatului:",
        "Cautare candidat Binar"
    );

    if (string.IsNullOrWhiteSpace(cnpCautat))
        return;

    if (!File.Exists("candidati.bin"))
    {
        MessageBox.Show("Nu exista fisier binar! Salveaza mai intai.");
        return;
    }

    bool gasit = false;

    using (BinaryReader br = new BinaryReader(File.Open("candidati.bin", FileMode.Open)))
    {
        while (br.BaseStream.Position < br.BaseStream.Length)
        {
            string nume     = br.ReadString();
            string prenume  = br.ReadString();
            string cnp      = br.ReadString();
            string medieBac = br.ReadString();
            string notaEx   = br.ReadString();
            string medie    = br.ReadString();
            string opt1     = br.ReadString();
            string opt2     = br.ReadString();
            string opt3     = br.ReadString();
            string status   = br.ReadString();

            if (cnp == cnpCautat)
            {
                gasit = true;
                MessageBox.Show(
                    "Nume: "             + nume     +
                    "\nPrenume: "        + prenume  +
                    "\nCNP: "            + cnp      +
                    "\nMedie Bac: "      + medieBac +
                    "\nNota Examen: "    + notaEx   +
                    "\nMedie Admitere: " + medie    +
                    "\nOptiune 1: "      + opt1     +
                    "\nOptiune 2: "      + opt2     +
                    "\nOptiune 3: "      + opt3     +
                    "\nRezultat: "       + status,
                    "Candidat gasit in fisier binar"
                );
                break;
            }
        }
    }

    if (!gasit)
        MessageBox.Show("Nu exista candidat cu acest CNP in fisierul binar!");
        }

        private void graficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGrafic form = new FormGrafic(); 
            form.ShowDialog();
            form.Dispose();
        }

        private void locuriDisponibileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            try
            {
                _comisie = new Comisie();
                DataTable dt = _db.GetLocuriRamase();

                foreach (DataRow row in dt.Rows)
                    _comisie.AdaugaSpecializare(new Specializare(
                        row["Nume"].ToString(),
                        Convert.ToInt32(row["Ramase"])
                    ));

                

                string mesaj = "Locuri ramase per specializare:\n\n";
                for (int i = 0; i < _comisie.Specializari.Count; i++)
                {
                    mesaj += _comisie[i].ToString() + " ramase\n";
                }



                MessageBox.Show(mesaj, "Locuri ramase",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
           

            foreach (string fisier in Directory.GetFiles(Application.StartupPath, "dosar_*.xml"))
            {
                File.Delete(fisier);
            }

            if (File.Exists("candidati.txt"))
                File.Delete("candidati.txt");

            if (File.Exists("candidati.bin"))
                File.Delete("candidati.bin");
        }
    }
    
}
