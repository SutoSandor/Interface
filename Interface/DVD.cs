using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class DVD:I_kolcsonozheto, IComparable<DVD>
    {

        string cim;
        int hossz; //perc

        public string Cim { get => cim; set => cim = value; }

        public DVD(string cim, int hossz)
        {
            this.cim = cim;
            this.hossz = hossz;
        }

        public int MeddigKolcsonozheto()
        {
            return 7;
        }

        public string MegjelenitendoNev()
        {
            return this.cim;
        }

        public double FutasIdo()
        {
            return hossz / 60.0;
        }

        public int CompareTo(DVD other)
        {
            /*
            if (this.hossz<other.hossz)
            {
                return -1;
            }
            else if (this.hossz > other.hossz)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            */
            return this.hossz.CompareTo(other.hossz);
        }
    }
}
