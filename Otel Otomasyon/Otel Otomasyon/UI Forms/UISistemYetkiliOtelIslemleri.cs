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
    public partial class UISistemYetkiliOtelIslemleri : MetroForm
    {
        OtelIslemleri otelIslemleri = new OtelIslemleri();
        

        public UISistemYetkiliOtelIslemleri()
        {
            InitializeComponent();
            
        }

        private void UISistemYetkiliOtelIslemleri_Load(object sender, EventArgs e)
        {

            ComboBoxaDegerAta();
            grp_OtelBilgi.Visible = false;
            cmb_Oteller.Visible = false;
            btn_OtelIslemleri.Visible = false;
            
        }

        private void rdo_OtelEkle_CheckedChanged(object sender, EventArgs e)
        {
            grp_OtelBilgi.Visible = true;
            cmb_Oteller.Visible = false;
            btn_OtelIslemleri.Visible = true;
            btn_OtelIslemleri.Text = "Ekle!";

            TextBoxDegerSil();
        }

        private void rdo_OtelGuncelle_CheckedChanged(object sender, EventArgs e)
        {
            grp_OtelBilgi.Visible = true;
            cmb_Oteller.Visible = true;
            btn_OtelIslemleri.Visible = true;
            btn_OtelIslemleri.Text = "Güncelle!";
            ComboBoxaDegerAta();

        }

        private void rdo_OtelSil_CheckedChanged(object sender, EventArgs e)
        {
            grp_OtelBilgi.Visible = false;
            cmb_Oteller.Visible = true;
            btn_OtelIslemleri.Visible = true;
            btn_OtelIslemleri.Text = "Sil!";
            ComboBoxaDegerAta();
        }

        private void btn_OtelIslemleri_Click(object sender, EventArgs e)
        {
            if (btn_OtelIslemleri.Text == "Ekle!")
            {
                Otel otel = new Otel();

                otel.adi = txt_OtelAdi.Text;
                otel.adres = txt_OtelAdres.Text;
                otel.ePosta = txt_OtelEPosta.Text;
                otel.il = txt_Il.Text;
                otel.ilce = txt_Ilce.Text;
                otel.odaSayisi = int.Parse(txt_OdaSayisi.Text);
                otel.odaTipi = txt_OdaTipi.Text;
                otel.telefon = txt_OdaTipi.Text;
                otel.yildizSayisi = int.Parse(txt_YildizSayisi.Text);


                otelIslemleri.OtelKaydet(otel);

                TextBoxDegerSil();
            }

            else if (btn_OtelIslemleri.Text == "Güncelle!")
            {
                
                Otel otel = new Otel();

                otel = otelIslemleri.OtelBul(cmb_Oteller.Text);


                otel.adi = txt_OtelAdi.Text;
                otel.adres = txt_OtelAdres.Text;
                otel.ePosta = txt_OtelEPosta.Text;
                otel.il = txt_Il.Text;
                otel.ilce = txt_Ilce.Text;
                otel.odaSayisi = int.Parse(txt_OdaSayisi.Text);
                otel.odaTipi = txt_OdaTipi.Text;
                otel.telefon = txt_OdaTipi.Text;
                otel.yildizSayisi = int.Parse(txt_YildizSayisi.Text);

                otelIslemleri.OtelBilgiGuncelle(otel);
                ComboBoxaDegerAta();

            }


            else
            {
                Otel otel = new Otel();

                string OtelAdi = cmb_Oteller.Text;

                otel = otelIslemleri.OtelBul(OtelAdi);

                otelIslemleri.OtelSil(otel);

                ComboBoxaDegerAta();

            }
        }

        private void cmb_Oteller_SelectedIndexChanged(object sender, EventArgs e)
        {
            Otel otel = new Otel();

            otel = otelIslemleri.OtelBul(cmb_Oteller.Text);

            txt_OtelAdi.Text = otel.adi;
            txt_OtelAdres.Text = otel.adres;
            txt_OdaTipi.Text = otel.odaTipi;
            txt_OtelEPosta.Text = otel.ePosta;
            txt_OtelTelefon.Text = otel.telefon;
            txt_YildizSayisi.Text = otel.yildizSayisi.ToString();
            txt_Il.Text = otel.il;
            txt_Ilce.Text = otel.ilce;
            txt_OdaSayisi.Text = otel.odaSayisi.ToString();
            

        }

        private void ComboBoxaDegerAta()
        {
            cmb_Oteller.Items.Clear();

            OtelRepository otelRepository = new OtelRepository();

            List<Otel> tempOteller = new List<Otel>();

            tempOteller = otelRepository.OtelleriAl();

            for (int i = 0; i < tempOteller.Count; i++)
                cmb_Oteller.Items.Add(tempOteller[i].adi);

        }

        private void TextBoxDegerSil()
        {

            txt_OtelAdi.Text = "";
            txt_OtelAdres.Text = "";
            txt_OtelEPosta.Text = "";
            txt_OtelTelefon.Text = "";
            txt_YildizSayisi.Text = "";
            txt_Il.Text = "";
            txt_Ilce.Text = "";
            txt_OdaSayisi.Text = "";
            txt_OdaTipi.Text = "";

        }

    }
}
