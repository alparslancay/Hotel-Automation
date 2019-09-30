using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Otomasyon
{
    public class Personel : Kisi
    {
        public string telefon { get; set; }
        public string adres { get; set; }
        public string departman { get; set; }
        public string pozisyon { get; set; }
        public decimal personelPuani { get; set; }
        public int calistigiOtelID { get; set; }
    }
}
