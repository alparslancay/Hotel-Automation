using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Otomasyon
{
    public class LinkedPersonel
    {
        public PersonelDugumu head;
        public int size = 0;


        public void PersonelEkle(Personel eklePersonel)
        {
            //Eski sonuncu node, Head'den başlanarak set ediliyor
            PersonelDugumu oldLast = head;


            if (head == null)
            {
                PersonelDugumu tmpHead = new PersonelDugumu
                {
                    personelBilgisi = eklePersonel
                };

                head = tmpHead;
            }
            else
            {
                //Yeni sonuncu node yaratılıyor
                PersonelDugumu newLast = new PersonelDugumu
                {
                    personelBilgisi = eklePersonel
                };

                //Eski sonuncu node bulunuyor
                //Tail olsaydı sonuncuyu bulmaya gerek yoktu.
                while (oldLast != null)
                {
                    if (oldLast.sonraki != null)
                        oldLast = oldLast.sonraki;
                    else
                        break;
                }

                //Eski sonuncu node referansı artık yeni sonuncu node'u gösteriyor
                oldLast.sonraki = newLast;

                //Bağlı listedeki eleman sayısı bir arttı
                size++;
            }

        }


        public void PersonelSil(Personel silPersonel)
        {
            PersonelDugumu tmphead = head;
            PersonelDugumu oncekiDugum=null;


            if (PersonelBul(silPersonel)!=null)
            {
                if (tmphead.personelBilgisi == silPersonel)
                {

                    head = tmphead.sonraki;

                    size--;
                }

                else
                {
                    while (tmphead.personelBilgisi.tamAdi != silPersonel.tamAdi)
                    {
                        oncekiDugum = tmphead;
                        tmphead = tmphead.sonraki;

                    }

                    oncekiDugum.sonraki = tmphead.sonraki;
                    size--;
                }
            }

            else { System.Windows.Forms.MessageBox.Show("Böyle bir personel bulunmamaktadır.");}

        }

        public void PersonelPuanlandir(decimal puan,Personel Personel )
        {
            if (PersonelBul(Personel)!=null)
            {
                PersonelDugumu tmpHead = head;

                while (tmpHead.personelBilgisi != Personel)
                {
                    tmpHead = tmpHead.sonraki;
                }
                tmpHead.personelBilgisi.personelPuani = puan;
            }

            else { System.Windows.Forms.MessageBox.Show("Böyle bir personel bulunmamaktadır."); }

        }

        public Personel PersonelBul(Personel araPersonel)
        {
            PersonelDugumu tmpHead = head;

            while (tmpHead.personelBilgisi.tcKimlikNo != araPersonel.tcKimlikNo)
            {
                tmpHead = tmpHead.sonraki;

                if(tmpHead == null) { break; }
            }

            if(tmpHead == null) { return null; }

            else
            {
                return tmpHead.personelBilgisi;
            }

        }

        public Personel PersonelBul(int indeks)
        {
            PersonelDugumu tmpHead = head;

            for(int i = 0; i < indeks; i++)
            {
                tmpHead = tmpHead.sonraki;
            }

            if (tmpHead == null) { return null; }

            else
            {
                return tmpHead.personelBilgisi;
            }

        }

        public Personel EnIyiPersonelBul()
        {
            try
            {
                PersonelDugumu tmpHead = head;
                Personel enIyiPersonel = tmpHead.personelBilgisi;
            
                while (tmpHead.sonraki != null)
                {


                    if (enIyiPersonel.personelPuani < tmpHead.sonraki.personelBilgisi.personelPuani)
                    {
                        enIyiPersonel = tmpHead.sonraki.personelBilgisi;
                    }

                    tmpHead = tmpHead.sonraki;
                }

                return enIyiPersonel;
            }

            catch { System.Windows.Forms.MessageBox.Show("Personel Bulunmamaktadır.");  return null; }
        }

        public List<Personel> DepartmanPersonelListele(string departmanAdi)
        {
            List<Personel> departmanlist = new List<Personel>();

            try
            {
                PersonelDugumu tmpHead = head;
               
                while (tmpHead != null)
                {


                    if (departmanAdi == tmpHead.personelBilgisi.departman)
                    {
                        departmanlist.Add(tmpHead.personelBilgisi);
                    }

                    tmpHead = tmpHead.sonraki;
                }

                return departmanlist;
            }

            catch { System.Windows.Forms.MessageBox.Show("Bu departmanda çalışan bulunmamaktadır."); return null; }
        }

        public List<Personel> TumPersonelListesi()
        {
            List<Personel> tumPersonelList = new List<Personel>();

            try
            {
                PersonelDugumu tmpHead = head;

                while (tmpHead != null)
                {
                        tumPersonelList.Add(tmpHead.personelBilgisi);
                    
                    tmpHead = tmpHead.sonraki;
                }

                return tumPersonelList;
            }

            catch { System.Windows.Forms.MessageBox.Show("Bu departmanda çalışan bulunmamaktadır."); return null; }
        }

    }
}
