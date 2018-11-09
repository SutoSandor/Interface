using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Ujsag:I_kolcsonozheto
    {
        string cim;
        int kiadasEve;
        int KiadasHonap;

        public Ujsag(string cim, int kiadasEve, int kiadasHonap)
        {
            this.cim = cim;
            this.kiadasEve = kiadasEve;
            KiadasHonap = kiadasHonap;
        }

        public string MegjelenitendoNev()
        {
            return string.Format("{0} {1} / {2}", cim, kiadasEve, KiadasHonap);
        }
        public int MeddigKolcsonozheto()
        {
            return 0;
        }
    }
}
