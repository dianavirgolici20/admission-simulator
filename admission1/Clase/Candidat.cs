using System;
using System.Collections.Generic;

namespace Proiect_Final_Paw.Clase
{
    [Serializable]
    public class Candidat : Persoana, ICloneable, IComparable<Candidat>, IEvaluabil
    {
        
        private const double PondereBac = 0.6;
        private const double PondereExamen = 0.4;

        public double MedieBac { get; set; }
        public double NotaExamen { get; set; }
        public List<string> Optiuni { get; set; }
        public string Rezultat { get; set; }

        public Candidat() : base()
        {
            Optiuni = new List<string>();
            Rezultat = "Nerepartizat";
        }

        public Candidat(string nume, string prenume, string cnp, double medieBac, double notaExamen)
            : base(nume, prenume, cnp)
        {
            MedieBac = medieBac;
            NotaExamen = notaExamen;
            Optiuni = new List<string>();
            Rezultat = "Nerepartizat";
        }

        public double CalculeazaMedie()
        {
            return MedieBac * PondereBac + NotaExamen * PondereExamen;
        }

        public object Clone()
        {
            Candidat copie = new Candidat(Nume, Prenume, CNP, MedieBac, NotaExamen);
            copie.Optiuni = new List<string>(Optiuni);
            copie.Rezultat = Rezultat;
            return copie;
        }

        public int CompareTo(Candidat other)
        {
            if (other == null) return 1;
            return CalculeazaMedie().CompareTo(other.CalculeazaMedie());
        }

        public override string ToString()
        {
            return $"{Nume} {Prenume}";
        }
    }
}