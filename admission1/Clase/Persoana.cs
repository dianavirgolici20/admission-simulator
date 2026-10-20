using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Final_Paw.Clase
{
    public class Persoana
    {
        private string nume;
        private string prenume;
        private string cnp;

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public string Prenume
        {
            get { return prenume; }
            set { prenume = value; }
        }

        public string CNP
        {
            get { return cnp; }
            set { cnp = value; }
        }

        public Persoana() { }

        public Persoana(string nume, string prenume, string cnp)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.cnp = cnp;
        }
    }
}
