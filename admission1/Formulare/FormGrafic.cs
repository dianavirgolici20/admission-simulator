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
using System.Windows.Forms.DataVisualization.Charting;

namespace Proiect_Final_Paw.Formulare
{
    public partial class FormGrafic : Form
    {
        private DatabaseHelper _db;
        public FormGrafic()
        {
            InitializeComponent();
            _db = new DatabaseHelper();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void FormGrafic_Load(object sender, EventArgs e)
        {
            DataTable rezultate = _db.GetToateRezultatele();
            int nrAdmisi = 0;
            int nrRespinsi = 0;

            foreach (DataRow row in rezultate.Rows)
            {
                if (row["Status"].ToString() == "Admis")
                    nrAdmisi++;

                else if (row["Status"].ToString() == "Respins")
                    nrRespinsi++;
            }

            chart1.Series.Clear();
            chart1.Titles.Clear();

            chart1.Titles.Add("Situatie Admitere");

            Series serie = chart1.Series.Add("Admitere");

            serie.ChartType = SeriesChartType.Pie;

            serie.IsValueShownAsLabel = true;

            serie.Points.AddXY("Admisi", nrAdmisi);

            serie.Points.AddXY("Respinsi", nrRespinsi);

            DataTable rezultateSpecializari = _db.GetToateRezultatele();

            Dictionary<string, int> statistica = new Dictionary<string, int>();

            foreach (DataRow row in rezultateSpecializari.Rows)
            {
                if (row["Status"].ToString() == "Admis" && row["Repartizat"] != DBNull.Value)
                {
                    string specializare = row["Repartizat"].ToString();

                    if (!statistica.ContainsKey(specializare))
                        statistica[specializare] = 0;

                    statistica[specializare]++;
                }
            }

            List<Specializare> specializari = new List<Specializare>();

            foreach (var item in statistica)
            {
                specializari.Add(new Specializare(item.Key, item.Value));
            }

            specializari.Sort((s1, s2) => s1.CompareTo(s2));

            chartSpecializari.Series.Clear();
            chartSpecializari.Titles.Clear();

            chartSpecializari.Titles.Add("Specializări după numărul de candidați admiși");

            Series serieSpec = chartSpecializari.Series.Add("Candidați admiși");
            serieSpec.ChartType = SeriesChartType.Column;
            serieSpec.IsValueShownAsLabel = true;

            foreach (Specializare s in specializari)
            {
                serieSpec.Points.AddXY(s.Denumire, s.NrLocuri);
            }

           
        }
    }
}
