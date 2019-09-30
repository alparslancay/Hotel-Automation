using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Otomasyon
{
    public class OtelAgaci
    {
        public BTDugumu kok;
        private List<BTDugumu> dugumler = new List<BTDugumu>();

        public OtelAgaci() { }
        public OtelAgaci(BTDugumu kokDugum)
        {
            this.kok = kokDugum;
        }

        public BTDugumu OtelAra(string otelAdi)
        {

            return OtelAraInt(kok, otelAdi);
            
        }

        private BTDugumu OtelAraInt(BTDugumu dugum, string OtelAdi)
        {
            if (dugum == null)
                return null;
            else if (dugum.otel.adi == OtelAdi)
                return dugum;
            else if (string.Compare(dugum.otel.adi, OtelAdi) == 1)
                return (OtelAraInt(dugum.sol, OtelAdi));
            else
                return (OtelAraInt(dugum.sag, OtelAdi));

        }

        public int DerinlikBul()
        {
            return DerinlikBulInt(kok);
        }

        private int DerinlikBulInt(BTDugumu dugum)
        {
            if (dugum == null)
                return 0;
            else
            {
                /* compute the depth of each subtree */
                int lDepth = DerinlikBulInt(dugum.sol);
                int rDepth = DerinlikBulInt(dugum.sag);

                /* use the larger one */
                if (lDepth > rDepth)
                    return (lDepth + 1);
                else
                    return (rDepth + 1);
            }

        }

        public List<BTDugumu> DugumleriYazdir()
        {

            return dugumler;
        }

        public int OtelSayisiGoster()
        {
            InOrder();
            return dugumler.Count;
        }

        public void Ekle(Otel eklenecekOtel)
        {
    
            BTDugumu tempParent = new BTDugumu();

            BTDugumu tempSearch = kok;

            while (tempSearch != null)
            {
                tempParent = tempSearch;

                if (eklenecekOtel.adi == tempSearch.otel.adi)
                    return;
                else if (string.Compare(eklenecekOtel.adi,tempSearch.otel.adi) == -1)
                    tempSearch = tempSearch.sol;
                else
                    tempSearch = tempSearch.sag;
            }
            BTDugumu eklenecek = new BTDugumu(eklenecekOtel);

            if (kok == null)
                kok = eklenecek;
            else if (string.Compare(eklenecekOtel.adi,tempParent.otel.adi)==-1)
                tempParent.sol = eklenecek;
            else
                tempParent.sag = eklenecek;
        }

        public void Guncelle(Otel guncelOtel)
        {
            
            BTDugumu eskiDugum;

            eskiDugum = OtelAra(guncelOtel.adi);

            Sil(eskiDugum.otel);

            Ekle(guncelOtel);


        }

        public void InOrder()
        {
            dugumler.Clear();
            InOrderInt(kok);

        }

        void InOrderInt(BTDugumu dugum)
        {
            if (dugum == null)
                return;
            InOrderInt(dugum.sol);
            Ziyaret(dugum);
            InOrderInt(dugum.sag);
        }

        public void PostOrder()
        {
            dugumler.Clear();
            PostOrderInt(kok);

        }

        void PostOrderInt(BTDugumu dugum)
        {
            if (dugum == null)
                return;
            PostOrderInt(dugum.sol);
            PostOrderInt(dugum.sag);
            Ziyaret(dugum);
        }

        public void PreOrder()
        {
            dugumler.Clear();
            PreOrderInt(kok);

        }

        void PreOrderInt(BTDugumu dugum)
        {
            if (dugum == null)
                return;
            Ziyaret(dugum);
            PreOrderInt(dugum.sol);
            PreOrderInt(dugum.sag);
        }

        BTDugumu Successor(BTDugumu silinecekDugum)
        {
            BTDugumu successorParent = silinecekDugum;
            BTDugumu successor = silinecekDugum;
            BTDugumu current = silinecekDugum.sag;
            while (current != null)
            {
                successorParent = successor;
                successor = current;
                current = current.sol;
            }
            if (successor != silinecekDugum.sag)
            {
                successorParent.sol = successor.sag;
                successor.sag = silinecekDugum.sag;
            }
            return successor;
        }

        public bool Sil(Otel otel)
        {
            BTDugumu current = kok;
            BTDugumu parent = kok;
            bool kucukMu = true;

            while (current.otel.adi != otel.adi)
            {
                parent = current;
                if (string.Compare(otel.adi,current.otel.adi) == -1)
                {
                    kucukMu = true;
                    current = current.sol;
                }
                else
                {
                    kucukMu = false;
                    current = current.sag;
                }
                if (current == null)
                    return false;
            }

            if (current.sol == null && current.sag == null)
            {
                if (current == kok)
                    kok = null;
                else if (kucukMu)
                    parent.sol = null;
                else
                    parent.sag = null;
            }

            else if (current.sag == null)
            {
                if (current == kok)
                    kok = current.sol;
                else if (kucukMu)
                    parent.sol = current.sol;
                else
                    parent.sag = current.sol;
            }
            else if (current.sol == null)
            {
                if (current == kok)
                    kok = current.sag;
                else if (kucukMu)
                    parent.sol = current.sag;
                else
                    parent.sag = current.sag;
            }

            else
            {
                BTDugumu successor = Successor(current);
                if (current == kok)
                    kok = successor;
                else if (kucukMu)
                    parent.sol = successor;
                else
                    parent.sag = successor;
                successor.sol = current.sol;
            }
            return true;

        }


        
        void Ziyaret(BTDugumu dugum)
        {
            dugumler.Add(dugum);
        }

    }
}
