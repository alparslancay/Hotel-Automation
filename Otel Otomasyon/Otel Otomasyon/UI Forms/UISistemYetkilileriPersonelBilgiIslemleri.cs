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
    public partial class UISistemYetkilileriPersonelBilgiIslemleri : MetroForm
    {
        OtelIslemleri otelIslemleri = new OtelIslemleri();
        PersonelIslemleri personelIslemleri = new PersonelIslemleri();
        public UISistemYetkilileriPersonelBilgiIslemleri()
        {
            InitializeComponent();
        }

        private void UISistemYetkilileriPersonelBilgiIslemleri_Load(object sender, EventArgs e)
        {
            ComboBoxaDegerAtaOtel();
           
        }

        private void rdo_PersonelEkle_CheckedChanged(object sender, EventArgs e)
        {

            txt_TCKN.Enabled = true;
            btn_PersonelIslemleri.Visible = true;
            grp_PersonelBilgi.Visible = true;
            cmb_PersonelOtel.Visible = true;
            cmb_Personeller.Visible = false;
            btn_PersonelIslemleri.Text = "Ekle!";
        }

        private void rdo_PersonelGuncelle_CheckedChanged(object sender, EventArgs e)
        {
            txt_TCKN.Enabled = false;
            btn_PersonelIslemleri.Visible = true;
            grp_PersonelBilgi.Visible = true;
            cmb_PersonelOtel.Visible = true;
            cmb_Personeller.Visible = true;
            btn_PersonelIslemleri.Text = "Güncelle!";
        }

        private void rdo_PersonelPuanlandir_CheckedChanged(object sender, EventArgs e)
        {
            txt_PersonelPuan.Visible = true;
            lbl_PersonelPuan.Visible = true;
            btn_PersonelIslemleri.Visible = true;
            grp_PersonelBilgi.Visible = false;
            cmb_PersonelOtel.Visible = true;
            cmb_Personeller.Visible = true;
            btn_PersonelIslemleri.Text = "Puanlandır!";
        }

        private void rdo_PersonelSil_CheckedChanged(object sender, EventArgs e)
        {
            lbl_PersonelPuan.Visible = false;
            txt_PersonelPuan.Visible = false;
            btn_PersonelIslemleri.Visible = true;
            grp_PersonelBilgi.Visible = false;
            cmb_PersonelOtel.Visible = true;
            cmb_Personeller.Visible = true;


            btn_PersonelIslemleri.Text = "Sil!";
        }

        private void btn_PersonelIslemleri_Click(object sender, EventArgs e)
        {
            if (btn_PersonelIslemleri.Text == "Ekle!")
            {
                Personel personel = new Personel();
                Otel otel = new Otel();
                otel = otelIslemleri.OtelBul(cmb_PersonelOtel.Text);
                personel.tamAdi = txt_TamAdi.Text;
                personel.telefon = txt_PersonelTelefon.Text;
                personel.ePosta = txt_PersonelEPosta.Text;
                personel.pozisyon = txt_Pozisyon.Text;
                personel.adres = txt_PersonelAdres.Text;
                personel.tcKimlikNo = txt_TCKN.Text;
                personel.departman = txt_Departman.Text;

                personelIslemleri.PersonelEkle(personel,otel);
            }

            else if(btn_PersonelIslemleri.Text == "Güncelle!")
            {
                Otel otel = new Otel();
                otel = otelIslemleri.OtelBul(cmb_PersonelOtel.Text);
                Personel personel = new Personel();
                personel.tamAdi = txt_TamAdi.Text;
                personel.telefon = txt_PersonelTelefon.Text;
                personel.ePosta = txt_PersonelEPosta.Text;
                personel.pozisyon = txt_Pozisyon.Text;
                personel.adres = txt_PersonelAdres.Text;
                personel.tcKimlikNo = txt_TCKN.Text;
                personel.departman = txt_Departman.Text;
                personelIslemleri.PersonelGuncelle(personel, otel);
                ComboBoxaDegerAtaPersonel();
                TextBoxDegerSil();
            }

            else if (btn_PersonelIslemleri.Text == "Puanlandır!")
            {
                Otel otel = new Otel();
                otel = otelIslemleri.OtelBul(cmb_PersonelOtel.Text);
                personelIslemleri.PersonelPuanlandir(otel, cmb_Personeller.SelectedIndex, decimal.Parse(txt_PersonelPuan.Text));
                
            }

            else
            {
                Otel otel = new Otel();

                string OtelAdi = cmb_PersonelOtel.Text;

                otel = otelIslemleri.OtelBul(OtelAdi);

                Personel personel = new Personel();

                personel = otel.personel.PersonelBul(cmb_Personeller.SelectedIndex);

                personelIslemleri.PersonelSil(personel,otel);

                ComboBoxaDegerAtaOtel();
                ComboBoxaDegerAtaPersonel();
            }
        }
        private void ComboBoxaDegerAtaOtel()
        {
            cmb_PersonelOtel.Items.Clear();

            OtelRepository otelRepository = new OtelRepository();

            List<Otel> tempOteller = new List<Otel>();

            tempOteller = otelRepository.OtelleriAl();

            for (int i = 0; i < tempOteller.Count; i++)
                cmb_PersonelOtel.Items.Add(tempOteller[i].adi);

        }

        private void ComboBoxaDegerAtaPersonel()
        {
            Otel otel = new Otel();
            cmb_Personeller.Items.Clear();
            List<Personel> personeller = new List<Personel>();

            otel = otelIslemleri.OtelBul(cmb_PersonelOtel.Text);

            personelIslemleri.OteleTumPersonelBilgisiAktar(otel);

            personeller = otel.personel.TumPersonelListesi();

            for (int i = 0; i < personeller.Count; i++)
            {
                cmb_Personeller.Items.Add(personeller[i].tamAdi);
            }

        }


        private void TextBoxDegerSil()
        {

            txt_TamAdi.Text = "";
            txt_TCKN.Text = "";
            txt_Pozisyon.Text = "";
            txt_PersonelTelefon.Text = "";
            txt_PersonelPuan.Text = "";
            txt_PersonelEPosta.Text = "";
            txt_PersonelAdres.Text = "";
            txt_Departman.Text = "";
          

        }

        private void cmb_PersonelOtel_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxaDegerAtaPersonel();
            TextBoxDegerSil();
        }

        private void cmb_Personeller_SelectedIndexChanged(object sender, EventArgs e)
        {
            Otel otel = new Otel();
            otel = otelIslemleri.OtelBul(cmb_PersonelOtel.Text);
            Personel personel = new Personel();
            personel = otel.personel.PersonelBul(cmb_Personeller.SelectedIndex);
            txt_TamAdi.Text = personel.tamAdi;
            txt_TCKN.Text = personel.tcKimlikNo;
            txt_Pozisyon.Text = personel.pozisyon;
            txt_PersonelTelefon.Text = personel.telefon;
            txt_PersonelPuan.Text = personel.personelPuani.ToString();
            txt_PersonelEPosta.Text = personel.ePosta;
            txt_PersonelAdres.Text = personel.adres;
            txt_Departman.Text = personel.departman;
            txt_LockedPersonelPuani.Text = personel.personelPuani.ToString();
            txt_PersonelPuan.Text = personel.personelPuani.ToString();


        }
    }
}
