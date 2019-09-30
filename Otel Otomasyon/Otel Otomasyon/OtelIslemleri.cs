using Otel_Otomasyon.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Otomasyon
{
    public class OtelIslemleri
    {
        private OtelAgaci otelAgaci = new OtelAgaci();
        private OtelRepository otelRepository = new OtelRepository();




        public OtelIslemleri()
        {
            List<Otel> oteller = new List<Otel>();

            oteller = otelRepository.OtelleriAl();

            OtelAgaciOlustur(oteller);

        }

        public void OtelKaydet(Otel otel)
        {
            otelRepository.OtelEkle(otel);
            OtelAgaciOlustur(otelRepository.OtelleriAl());

        }

        public void OtelBilgiGuncelle(Otel otel)
        {
            otelAgaci.Guncelle(otel);
            otelRepository.OtelGuncelle(otel);
        }

        public void OtelSil(Otel otel)
        {
            otelAgaci.Sil(otel);
            otelRepository.OtelSil(otel);
        }



        public void OtelAgaciOlustur(List<Otel> oteller)
        {

            for (int i = 0; i < oteller.Count; i++)
            {
                otelAgaci.Ekle(oteller[i]);
            }
        }

        public Otel OtelBul(string otelAdi)
        {
            return otelAgaci.OtelAra(otelAdi).otel;
        }

    }
}
