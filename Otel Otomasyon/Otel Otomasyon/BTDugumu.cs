using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Otomasyon
{
    public class BTDugumu
    {
        public Otel otel;
        public BTDugumu sol;
        public BTDugumu sag;

        public BTDugumu()
        {

        }
        public BTDugumu(Otel otel)
        {
            this.otel = otel;
            sol = null;
            sag = null;
        }
    }
}
