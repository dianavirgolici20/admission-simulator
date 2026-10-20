using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Final_Paw.Clase
{
    [Serializable]
    public class Dosar : ICloneable, IComparable<Dosar>
    {
        private Candidat candidat;
        private List<Specializare> optiuni;
        private int prioritate;

        public Candidat Candidat
        {
            get { return candidat; }
            set { candidat = value; }
        }

        public List<Specializare> Optiuni
        {
            get { return optiuni; }
            set { optiuni = value; }
        }

        public int Prioritate
        {
            get { return prioritate; }
            set { prioritate = value; }
        }

        public Dosar()
        {
            optiuni = new List<Specializare>();
            prioritate = 1;
        }

        public Dosar(Candidat candidat)
        {
            this.candidat = candidat;
            optiuni = new List<Specializare>();
            prioritate = 1;
        }

        public static Dosar operator +(Dosar d, Specializare s)
        {
            d.optiuni.Add(s);
            return d;
        }

        public static Dosar operator -(Dosar d, Specializare s)
        {
            d.optiuni.Remove(s);
            return d;
        }

        public static Dosar operator ++(Dosar d)
        {
            d.prioritate++;
            return d;
        }

        public static Dosar operator --(Dosar d)
        {
            if (d.prioritate > 1)
                d.prioritate--;

            return d;
        }

        public override string ToString()
        {
            
            return "Nume: " + candidat.Nume + "\n" +
                   "Prenume: " + candidat.Prenume + "\n" +
                   "CNP: " + candidat.CNP + "\n" +
                   "Medie Bac: " + candidat.MedieBac + "\n" +
                   "Nota Examen: " + candidat.NotaExamen + "\n" +
                   "Medie Admitere: " + candidat.CalculeazaMedie() + "\n"+
                   "Prioritate Dosar: " + prioritate + "\n" +
                   "Rezultat: " + candidat.Rezultat;
        
        }

        public object Clone()
        {
            Dosar copie = new Dosar((Candidat)candidat.Clone());
            copie.Optiuni = new List<Specializare>(this.optiuni);
            copie.Prioritate = this.prioritate;
            return copie;
        }

        public int CompareTo(Dosar other)
        {
            if (other == null) return 1;
            return this.prioritate.CompareTo(other.prioritate);
        }
    }
}
