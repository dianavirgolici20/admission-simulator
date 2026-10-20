using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Final_Paw.Clase
{
    [Serializable]
    public class Comisie : IEnumerable<Specializare>
    {
        private List<Specializare> specializari;

        public List<Specializare> Specializari
        {
            get { return specializari; }
            set { specializari = value; }
        }

        public Comisie()
        {
            specializari = new List<Specializare>();
        }

        public void AdaugaSpecializare(Specializare s)
        {
            specializari.Add(s);
        }

        public Specializare this[int index]
        {
            get
            {
                if (index >= 0 && index < specializari.Count)
                    return specializari[index];

                throw new IndexOutOfRangeException();
            }

            set
            {
                if (index >= 0 && index < specializari.Count)
                    specializari[index] = value;

                else
                    throw new IndexOutOfRangeException();
            }
        }
        public IEnumerator<Specializare> GetEnumerator()
        {
            return specializari.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Specializare GetSpecializareaMaxLocuri()
        {
            Specializare max = null;
            foreach (var s in specializari)
            {
                if (max == null || s.NrLocuri > max.NrLocuri)
                    max = s;
            }
            return max;
        }
        public void SorteazaDupaLocuri()
        {
            specializari.Sort();
        }
    }
}
