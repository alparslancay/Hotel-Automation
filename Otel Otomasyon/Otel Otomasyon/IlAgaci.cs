using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Otomasyon
{
    public class IlAgaci

    {
        public IlDugumu kok;

        private List<IlDugumu> dugumler = new List<IlDugumu>();

        public IlAgaci(List<Otel> oteller)
        {

            for (int i = 0; i < oteller.Count; i++)
            {
                Ekle(oteller[i].il);
            }
        }
        public IlAgaci(IlDugumu kokDugum)
        {
            this.kok = kokDugum;
        }
        public void Ekle(string eklenecekIlAdi)
        {
            //Yeni eklenecek düğümün parent'ı
            IlDugumu tempParent = new IlDugumu();
            //Kökten başla ve ilerle
            IlDugumu tempSearch = kok;

            while (tempSearch != null)
            {
                tempParent = tempSearch;
                //Deger zaten var, çık.
                if (eklenecekIlAdi == tempSearch.ilAdi)
                    return;
                else if (string.Compare(eklenecekIlAdi, tempSearch.ilAdi) == -1)
                    tempSearch = tempSearch.sol;
                else
                    tempSearch = tempSearch.sag;
            }
            IlDugumu eklenecek = new IlDugumu(eklenecekIlAdi);
            //Ağaç boş, köke ekle
            if (kok == null)
                kok = eklenecek;
            else if (string.Compare(eklenecekIlAdi, tempParent.ilAdi) == -1)
                tempParent.sol = eklenecek;
            else
                tempParent.sag = eklenecek;
        }

        public void InOrder()
        {
            dugumler.Clear();
            InOrderInt(kok);

        }

        void InOrderInt(IlDugumu dugum)
        {
            if (dugum == null)
                return;
            InOrderInt(dugum.sol);
            Ziyaret(dugum);
            InOrderInt(dugum.sag);
        }

        void Ziyaret(IlDugumu dugum)
        {
            dugumler.Add(dugum);
        }

        public List<IlDugumu> DugumleriYazdir()
        {

            return dugumler;
        }
        
    }
}
