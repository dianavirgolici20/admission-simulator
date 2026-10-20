using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proiect_Final_Paw.Clase
{
    [Serializable]
    public class Specializare : ICloneable, IComparable<Specializare>
    {
        private string denumire;
        private int nrLocuri;

        public string Denumire
        {
            get { return denumire; }
            set { denumire = value; }
        }

        public int NrLocuri
        {
            get { return nrLocuri; }
            set { nrLocuri = value; }
        }

        public Specializare()
        {
        }

        public Specializare(string denumire, int nrLocuri)
        {
            this.denumire = denumire;
            this.nrLocuri = nrLocuri;
        }

        public object Clone()
        {
            return new Specializare(denumire, nrLocuri);
        }

        public int CompareTo(Specializare other)
        {
            if (other == null)
                return 1;

            return other.nrLocuri.CompareTo(this.nrLocuri);
        }

        public override string ToString()
        {
            return $"{denumire} - {nrLocuri} locuri";
        }
    }
}