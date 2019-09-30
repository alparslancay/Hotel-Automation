using MetroFramework.Forms;
using Otel_Otomasyon.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Otomasyon
{
    public partial class UISistemYetkilileriPersonelListelemeIslemleri : MetroForm
    {
        OtelIslemleri otelIslemleri = new OtelIslemleri();
        PersonelIslemleri personelIslemleri = new PersonelIslemleri();

        public UISistemYetkilileriPersonelListelemeIslemleri()
        {
            InitializeComponent();
        }

        private void UISistemYetkilileriPersonelListelemeIslemleri_Load(object sender, EventArgs e)
        {
            cmb_Oteller.Items.Clear();

            OtelRepository otelRepository = new OtelRepository();

            List<Otel> tempOteller = new List<Otel>();

            tempOteller = otelRepository.OtelleriAl();

            for (int i = 0; i < tempOteller.Count; i++)
                cmb_Oteller.Items.Add(tempOteller[i].adi);
        }

        private void rdo_PersonelListele_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Departman.Visible = false;
            txt_Departman.Visible = false;
            btn_PersonelIslemleri.Text = "Personeli Bul!";
        }

        private void rdo_DepartmanListele_CheckedChanged(object sender, EventArgs e)
        {
            btn_PersonelIslemleri.Text = "Personelleri Bul!";
            lbl_Departman.Visible = true;
            txt_Departman.Visible = true;
        }

        private void btn_PersonelIslemleri_Click(object sender, EventArgs e)
        {
            lstvw_PersonelListe.Items.Clear();

            if (btn_PersonelIslemleri.Text == "Personelleri Bul!")
            {
                Otel otel = new Otel();
                List<Personel> personelListesi = new List<Personel>();
                otel = otelIslemleri.OtelBul(cmb_Oteller.Text);

                
                string departmanAdi = txt_Departman.Text;
                departmanAdi = departmanAdi.ToLower();

                departmanAdi = char.ToUpper(departmanAdi[0]) + departmanAdi.Substring(1);

                personelListesi = personelIslemleri.DepartmanPersonelListele(otel,departmanAdi);
                for (int i = 0; i < personelListesi.Count; i++)
                {
                    ListviewDegerAta(personelListesi[i]);
                }
            }

            else
            {
                Otel otel = new Otel();
                Personel personel = new Personel();
                otel = otelIslemleri.OtelBul(cmb_Oteller.Text);
                personel = personelIslemleri.EnIyiPersonelBul(otel);
                ListviewDegerAta(personel);
                
            }

            
        }
        
        private void ListviewDegerAta(Personel personel)
        {

            if (personel != null)
            {
                string[] personelBilgi = new string[8];
                personelBilgi[0] = personel.tamAdi;
                personelBilgi[1] = personel.tcKimlikNo.ToString();
                personelBilgi[2] = personel.telefon.ToString();
                personelBilgi[3] = personel.adres;
                personelBilgi[4] = personel.ePosta;
                personelBilgi[5] = personel.departman;
                personelBilgi[6] = personel.pozisyon;
                personelBilgi[7] = personel.personelPuani.ToString();
                var item = new ListViewItem(personelBilgi);
                lstvw_PersonelListe.Items.Add(item);
            }

        }


    }
}
