using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Otomasyon
{
    public class Otel
    {
        public int otelID { get; set; }
        public string adi { get; set; }
        public string il { get; set; }
        public string ilce { get; set; }
        public string adres { get; set; }
        public string telefon { get; set; }
        public string ePosta { get; set; }
        public int yildizSayisi { get; set; }
        public int odaSayisi { get; set; }
        public string odaTipi { get; set; }
        public decimal otelPuani { get; set; }
        public int oySayisi { get; set; }

        public LinkedPersonel personel = new LinkedPersonel();
        public LinkedYorumcu yorumcu = new LinkedYorumcu();


        public List<string> YorumlariAl()
        {
            YorumcuDugumu tmphead = yorumcu.head;
            List<string> yorumlar = new List<string>();
            string tamYorum;
            while (tmphead != null)
            {
                tamYorum = "Tam Adı: " + tmphead.yorumcuBilgisi.tamAdi +"\n"+ "E-Postası: " + tmphead.yorumcuBilgisi.ePosta + "\n" + "Yorumu: " +tmphead.yorumcuBilgisi.yorum;
                yorumlar.Add(tamYorum);
                tmphead = tmphead.sonraki;

            }

            return yorumlar;
        }
    }



}
