using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Otomasyon
{
    public class IlDugumu
    {
        public string ilAdi;
        public IlDugumu sol;
        public IlDugumu sag;

        public IlDugumu()
        {

        }
        public IlDugumu(string ilAdi)
        {
            this.ilAdi = ilAdi;
            sol = null;
            sag = null;
        }
    }
}
