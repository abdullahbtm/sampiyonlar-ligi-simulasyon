using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Şampiyonlar_Ligi_Simülasyon
{
    class Takim
    {
        private string takimismi;
        private string takimulke;
        

        public Takim(string isim, string ülke)
        {
            takimismi = isim;
            takimulke = ülke;
           

        }

        public string TeamName
        {
            get
            {
                return takimismi;
            }
            set
            {
                takimismi = value;
            }
        }
        public string TeamCountry
        {
            get
            {
                return takimulke;
            }
            set
            {
                takimulke = value;
            }
        }
        
        
        public override string ToString()
        {
            return takimismi + "-" + takimulke;
        }
        

    }
}
