using Otel_Otomasyon.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Otomasyon
{
    public class PersonelIslemleri
    {
        private PersonelRepository personelRepository = new PersonelRepository();
        private List<Personel> tumPersoneller = new List<Personel>();

        public PersonelIslemleri()
        {
            tumPersoneller = personelRepository.TumPersonelleriAl();
        }


        public void PersonelEkle(Personel personel, Otel istenenOtel)
        {

            personel.calistigiOtelID = istenenOtel.otelID;
            personel.personelPuani = 0;
            istenenOtel.personel.PersonelEkle(personel);


            personelRepository.PersonelEkle(personel);

        }

        public void OteleTumPersonelBilgisiAktar(Otel istenenOtel)
        {
            istenenOtel.personel = new LinkedPersonel();

            for (int personelSayaci = 0; personelSayaci < tumPersoneller.Count; personelSayaci++)
            {
                if(istenenOtel.otelID == tumPersoneller[personelSayaci].calistigiOtelID)
                istenenOtel.personel.PersonelEkle(tumPersoneller[personelSayaci]);
            }
        }

        public Personel EnIyiPersonelBul(Otel istenenOtel)
        {
            OteleTumPersonelBilgisiAktar(istenenOtel);
            return istenenOtel.personel.EnIyiPersonelBul();
        }

        public void PersonelSil(Personel silPersonel, Otel istenenOtel)
        {
            OteleTumPersonelBilgisiAktar(istenenOtel);

            istenenOtel.personel.PersonelSil(silPersonel);

            personelRepository.PersonelSil(silPersonel);

        }

        public List<Personel> DepartmanPersonelListele(Otel istenenOtel, string departmanAdi)
        {
            OteleTumPersonelBilgisiAktar(istenenOtel);
            return istenenOtel.personel.DepartmanPersonelListele(departmanAdi);
        }

        public void PersonelGuncelle(Personel guncelPersonel, Otel istenenOtel)
        {
            OteleTumPersonelBilgisiAktar(istenenOtel);

            Personel tmpPersonel;

            tmpPersonel = istenenOtel.personel.PersonelBul(guncelPersonel);

            tmpPersonel.tamAdi = guncelPersonel.tamAdi;
            tmpPersonel.telefon = guncelPersonel.telefon;
            tmpPersonel.ePosta = guncelPersonel.ePosta;
            tmpPersonel.pozisyon = guncelPersonel.pozisyon;
            tmpPersonel.adres = guncelPersonel.adres;

            tmpPersonel.departman = guncelPersonel.departman;
            personelRepository.PersonelGuncelle(tmpPersonel);


        }

        public void PersonelPuanlandir(Otel istenenOtel, int indeks, decimal puan)
        {
            OteleTumPersonelBilgisiAktar(istenenOtel);

            Personel personel = new Personel();
            personel = istenenOtel.personel.PersonelBul(indeks);
            istenenOtel.personel.PersonelPuanlandir(puan, personel);
            personelRepository.PersonelGuncelle(personel);
        }

    }
}
