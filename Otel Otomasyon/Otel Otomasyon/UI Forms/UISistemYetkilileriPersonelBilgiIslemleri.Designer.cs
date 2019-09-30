namespace Otel_Otomasyon
{
    partial class UISistemYetkilileriPersonelBilgiIslemleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdo_PersonelPuanlandir = new MetroFramework.Controls.MetroRadioButton();
            this.rdo_PersonelGuncelle = new MetroFramework.Controls.MetroRadioButton();
            this.rdo_PersonelSil = new MetroFramework.Controls.MetroRadioButton();
            this.rdo_PersonelEkle = new MetroFramework.Controls.MetroRadioButton();
            this.cmb_PersonelOtel = new MetroFramework.Controls.MetroComboBox();
            this.grp_PersonelBilgi = new System.Windows.Forms.GroupBox();
            this.lbl_Pozisyon = new MetroFramework.Controls.MetroLabel();
            this.txt_Departman = new MetroFramework.Controls.MetroTextBox();
            this.txt_Pozisyon = new MetroFramework.Controls.MetroTextBox();
            this.txt_TamAdi = new MetroFramework.Controls.MetroTextBox();
            this.lbl_TamAdi = new MetroFramework.Controls.MetroLabel();
            this.txt_TCKN = new MetroFramework.Controls.MetroTextBox();
            this.lbl_TCKN = new MetroFramework.Controls.MetroLabel();
            this.txt_PersonelTelefon = new MetroFramework.Controls.MetroTextBox();
            this.lbl_PersonelTelefon = new MetroFramework.Controls.MetroLabel();
            this.lbl_Departman = new MetroFramework.Controls.MetroLabel();
            this.txt_PersonelEPosta = new MetroFramework.Controls.MetroTextBox();
            this.lbl_PersonelEposta = new MetroFramework.Controls.MetroLabel();
            this.lbl_PersonelAdres = new MetroFramework.Controls.MetroLabel();
            this.txt_PersonelAdres = new MetroFramework.Controls.MetroTextBox();
            this.lbl_PersonelPuan = new MetroFramework.Controls.MetroLabel();
            this.txt_PersonelPuan = new MetroFramework.Controls.MetroTextBox();
            this.btn_PersonelIslemleri = new MetroFramework.Controls.MetroButton();
            this.cmb_Personeller = new MetroFramework.Controls.MetroComboBox();
            this.txt_LockedPersonelPuani = new MetroFramework.Controls.MetroTextBox();
            this.lbl_LockedPersonelPuani = new MetroFramework.Controls.MetroLabel();
            this.grp_PersonelBilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdo_PersonelPuanlandir
            // 
            this.rdo_PersonelPuanlandir.AutoSize = true;
            this.rdo_PersonelPuanlandir.Location = new System.Drawing.Point(325, 78);
            this.rdo_PersonelPuanlandir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdo_PersonelPuanlandir.Name = "rdo_PersonelPuanlandir";
            this.rdo_PersonelPuanlandir.Size = new System.Drawing.Size(139, 17);
            this.rdo_PersonelPuanlandir.TabIndex = 8;
            this.rdo_PersonelPuanlandir.Text = "Personel Puanlandır";
            this.rdo_PersonelPuanlandir.UseSelectable = true;
            this.rdo_PersonelPuanlandir.CheckedChanged += new System.EventHandler(this.rdo_PersonelPuanlandir_CheckedChanged);
            // 
            // rdo_PersonelGuncelle
            // 
            this.rdo_PersonelGuncelle.AutoSize = true;
            this.rdo_PersonelGuncelle.Location = new System.Drawing.Point(30, 113);
            this.rdo_PersonelGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdo_PersonelGuncelle.Name = "rdo_PersonelGuncelle";
            this.rdo_PersonelGuncelle.Size = new System.Drawing.Size(127, 17);
            this.rdo_PersonelGuncelle.TabIndex = 7;
            this.rdo_PersonelGuncelle.Text = "Personel Güncelle";
            this.rdo_PersonelGuncelle.UseSelectable = true;
            this.rdo_PersonelGuncelle.CheckedChanged += new System.EventHandler(this.rdo_PersonelGuncelle_CheckedChanged);
            // 
            // rdo_PersonelSil
            // 
            this.rdo_PersonelSil.AutoSize = true;
            this.rdo_PersonelSil.Location = new System.Drawing.Point(325, 102);
            this.rdo_PersonelSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdo_PersonelSil.Name = "rdo_PersonelSil";
            this.rdo_PersonelSil.Size = new System.Drawing.Size(91, 17);
            this.rdo_PersonelSil.TabIndex = 6;
            this.rdo_PersonelSil.Text = "Personel Sil";
            this.rdo_PersonelSil.UseSelectable = true;
            this.rdo_PersonelSil.CheckedChanged += new System.EventHandler(this.rdo_PersonelSil_CheckedChanged);
            // 
            // rdo_PersonelEkle
            // 
            this.rdo_PersonelEkle.AutoSize = true;
            this.rdo_PersonelEkle.Location = new System.Drawing.Point(29, 79);
            this.rdo_PersonelEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdo_PersonelEkle.Name = "rdo_PersonelEkle";
            this.rdo_PersonelEkle.Size = new System.Drawing.Size(101, 17);
            this.rdo_PersonelEkle.TabIndex = 5;
            this.rdo_PersonelEkle.Text = "Personel Ekle";
            this.rdo_PersonelEkle.UseSelectable = true;
            this.rdo_PersonelEkle.CheckedChanged += new System.EventHandler(this.rdo_PersonelEkle_CheckedChanged);
            // 
            // cmb_PersonelOtel
            // 
            this.cmb_PersonelOtel.FormattingEnabled = true;
            this.cmb_PersonelOtel.ItemHeight = 24;
            this.cmb_PersonelOtel.Location = new System.Drawing.Point(377, 213);
            this.cmb_PersonelOtel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_PersonelOtel.Name = "cmb_PersonelOtel";
            this.cmb_PersonelOtel.Size = new System.Drawing.Size(268, 30);
            this.cmb_PersonelOtel.TabIndex = 35;
            this.cmb_PersonelOtel.UseSelectable = true;
            this.cmb_PersonelOtel.Visible = false;
            this.cmb_PersonelOtel.SelectedIndexChanged += new System.EventHandler(this.cmb_PersonelOtel_SelectedIndexChanged);
            // 
            // grp_PersonelBilgi
            // 
            this.grp_PersonelBilgi.Controls.Add(this.txt_LockedPersonelPuani);
            this.grp_PersonelBilgi.Controls.Add(this.lbl_LockedPersonelPuani);
            this.grp_PersonelBilgi.Controls.Add(this.lbl_Pozisyon);
            this.grp_PersonelBilgi.Controls.Add(this.txt_Departman);
            this.grp_PersonelBilgi.Controls.Add(this.txt_Pozisyon);
            this.grp_PersonelBilgi.Controls.Add(this.txt_TamAdi);
            this.grp_PersonelBilgi.Controls.Add(this.lbl_TamAdi);
            this.grp_PersonelBilgi.Controls.Add(this.txt_TCKN);
            this.grp_PersonelBilgi.Controls.Add(this.lbl_TCKN);
            this.grp_PersonelBilgi.Controls.Add(this.txt_PersonelTelefon);
            this.grp_PersonelBilgi.Controls.Add(this.lbl_PersonelTelefon);
            this.grp_PersonelBilgi.Controls.Add(this.lbl_Departman);
            this.grp_PersonelBilgi.Controls.Add(this.txt_PersonelEPosta);
            this.grp_PersonelBilgi.Controls.Add(this.lbl_PersonelEposta);
            this.grp_PersonelBilgi.Controls.Add(this.lbl_PersonelAdres);
            this.grp_PersonelBilgi.Controls.Add(this.txt_PersonelAdres);
            this.grp_PersonelBilgi.Location = new System.Drawing.Point(29, 206);
            this.grp_PersonelBilgi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_PersonelBilgi.Name = "grp_PersonelBilgi";
            this.grp_PersonelBilgi.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_PersonelBilgi.Size = new System.Drawing.Size(311, 379);
            this.grp_PersonelBilgi.TabIndex = 30;
            this.grp_PersonelBilgi.TabStop = false;
            this.grp_PersonelBilgi.Visible = false;
            // 
            // lbl_Pozisyon
            // 
            this.lbl_Pozisyon.AutoSize = true;
            this.lbl_Pozisyon.Location = new System.Drawing.Point(11, 231);
            this.lbl_Pozisyon.Name = "lbl_Pozisyon";
            this.lbl_Pozisyon.Size = new System.Drawing.Size(70, 20);
            this.lbl_Pozisyon.TabIndex = 30;
            this.lbl_Pozisyon.Text = "Pozisyon :";
            // 
            // txt_Departman
            // 
            // 
            // 
            // 
            this.txt_Departman.CustomButton.Image = null;
            this.txt_Departman.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.txt_Departman.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Departman.CustomButton.Name = "";
            this.txt_Departman.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Departman.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Departman.CustomButton.TabIndex = 1;
            this.txt_Departman.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Departman.CustomButton.UseSelectable = true;
            this.txt_Departman.CustomButton.Visible = false;
            this.txt_Departman.Lines = new string[0];
            this.txt_Departman.Location = new System.Drawing.Point(127, 270);
            this.txt_Departman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Departman.MaxLength = 32767;
            this.txt_Departman.Name = "txt_Departman";
            this.txt_Departman.PasswordChar = '\0';
            this.txt_Departman.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Departman.SelectedText = "";
            this.txt_Departman.SelectionLength = 0;
            this.txt_Departman.SelectionStart = 0;
            this.txt_Departman.ShortcutsEnabled = true;
            this.txt_Departman.Size = new System.Drawing.Size(173, 23);
            this.txt_Departman.TabIndex = 22;
            this.txt_Departman.UseSelectable = true;
            this.txt_Departman.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Departman.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_Pozisyon
            // 
            // 
            // 
            // 
            this.txt_Pozisyon.CustomButton.Image = null;
            this.txt_Pozisyon.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.txt_Pozisyon.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Pozisyon.CustomButton.Name = "";
            this.txt_Pozisyon.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Pozisyon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Pozisyon.CustomButton.TabIndex = 1;
            this.txt_Pozisyon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Pozisyon.CustomButton.UseSelectable = true;
            this.txt_Pozisyon.CustomButton.Visible = false;
            this.txt_Pozisyon.Lines = new string[0];
            this.txt_Pozisyon.Location = new System.Drawing.Point(127, 231);
            this.txt_Pozisyon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Pozisyon.MaxLength = 32767;
            this.txt_Pozisyon.Name = "txt_Pozisyon";
            this.txt_Pozisyon.PasswordChar = '\0';
            this.txt_Pozisyon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Pozisyon.SelectedText = "";
            this.txt_Pozisyon.SelectionLength = 0;
            this.txt_Pozisyon.SelectionStart = 0;
            this.txt_Pozisyon.ShortcutsEnabled = true;
            this.txt_Pozisyon.Size = new System.Drawing.Size(173, 23);
            this.txt_Pozisyon.TabIndex = 29;
            this.txt_Pozisyon.UseSelectable = true;
            this.txt_Pozisyon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Pozisyon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_TamAdi
            // 
            // 
            // 
            // 
            this.txt_TamAdi.CustomButton.Image = null;
            this.txt_TamAdi.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.txt_TamAdi.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TamAdi.CustomButton.Name = "";
            this.txt_TamAdi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_TamAdi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_TamAdi.CustomButton.TabIndex = 1;
            this.txt_TamAdi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_TamAdi.CustomButton.UseSelectable = true;
            this.txt_TamAdi.CustomButton.Visible = false;
            this.txt_TamAdi.Lines = new string[0];
            this.txt_TamAdi.Location = new System.Drawing.Point(127, 20);
            this.txt_TamAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TamAdi.MaxLength = 32767;
            this.txt_TamAdi.Name = "txt_TamAdi";
            this.txt_TamAdi.PasswordChar = '\0';
            this.txt_TamAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_TamAdi.SelectedText = "";
            this.txt_TamAdi.SelectionLength = 0;
            this.txt_TamAdi.SelectionStart = 0;
            this.txt_TamAdi.ShortcutsEnabled = true;
            this.txt_TamAdi.Size = new System.Drawing.Size(173, 23);
            this.txt_TamAdi.TabIndex = 12;
            this.txt_TamAdi.UseSelectable = true;
            this.txt_TamAdi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_TamAdi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_TamAdi
            // 
            this.lbl_TamAdi.AutoSize = true;
            this.lbl_TamAdi.Location = new System.Drawing.Point(11, 20);
            this.lbl_TamAdi.Name = "lbl_TamAdi";
            this.lbl_TamAdi.Size = new System.Drawing.Size(65, 20);
            this.lbl_TamAdi.TabIndex = 13;
            this.lbl_TamAdi.Text = "Tam Adı :";
            // 
            // txt_TCKN
            // 
            // 
            // 
            // 
            this.txt_TCKN.CustomButton.Image = null;
            this.txt_TCKN.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.txt_TCKN.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TCKN.CustomButton.Name = "";
            this.txt_TCKN.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_TCKN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_TCKN.CustomButton.TabIndex = 1;
            this.txt_TCKN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_TCKN.CustomButton.UseSelectable = true;
            this.txt_TCKN.CustomButton.Visible = false;
            this.txt_TCKN.Lines = new string[0];
            this.txt_TCKN.Location = new System.Drawing.Point(127, 64);
            this.txt_TCKN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TCKN.MaxLength = 32767;
            this.txt_TCKN.Name = "txt_TCKN";
            this.txt_TCKN.PasswordChar = '\0';
            this.txt_TCKN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_TCKN.SelectedText = "";
            this.txt_TCKN.SelectionLength = 0;
            this.txt_TCKN.SelectionStart = 0;
            this.txt_TCKN.ShortcutsEnabled = true;
            this.txt_TCKN.Size = new System.Drawing.Size(173, 23);
            this.txt_TCKN.TabIndex = 14;
            this.txt_TCKN.UseSelectable = true;
            this.txt_TCKN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_TCKN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_TCKN
            // 
            this.lbl_TCKN.AutoSize = true;
            this.lbl_TCKN.Location = new System.Drawing.Point(11, 64);
            this.lbl_TCKN.Name = "lbl_TCKN";
            this.lbl_TCKN.Size = new System.Drawing.Size(51, 20);
            this.lbl_TCKN.TabIndex = 15;
            this.lbl_TCKN.Text = "TCKN :";
            // 
            // txt_PersonelTelefon
            // 
            // 
            // 
            // 
            this.txt_PersonelTelefon.CustomButton.Image = null;
            this.txt_PersonelTelefon.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.txt_PersonelTelefon.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_PersonelTelefon.CustomButton.Name = "";
            this.txt_PersonelTelefon.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_PersonelTelefon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_PersonelTelefon.CustomButton.TabIndex = 1;
            this.txt_PersonelTelefon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_PersonelTelefon.CustomButton.UseSelectable = true;
            this.txt_PersonelTelefon.CustomButton.Visible = false;
            this.txt_PersonelTelefon.Lines = new string[0];
            this.txt_PersonelTelefon.Location = new System.Drawing.Point(127, 110);
            this.txt_PersonelTelefon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_PersonelTelefon.MaxLength = 32767;
            this.txt_PersonelTelefon.Name = "txt_PersonelTelefon";
            this.txt_PersonelTelefon.PasswordChar = '\0';
            this.txt_PersonelTelefon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_PersonelTelefon.SelectedText = "";
            this.txt_PersonelTelefon.SelectionLength = 0;
            this.txt_PersonelTelefon.SelectionStart = 0;
            this.txt_PersonelTelefon.ShortcutsEnabled = true;
            this.txt_PersonelTelefon.Size = new System.Drawing.Size(173, 23);
            this.txt_PersonelTelefon.TabIndex = 16;
            this.txt_PersonelTelefon.UseSelectable = true;
            this.txt_PersonelTelefon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_PersonelTelefon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_PersonelTelefon
            // 
            this.lbl_PersonelTelefon.AutoSize = true;
            this.lbl_PersonelTelefon.Location = new System.Drawing.Point(11, 110);
            this.lbl_PersonelTelefon.Name = "lbl_PersonelTelefon";
            this.lbl_PersonelTelefon.Size = new System.Drawing.Size(61, 20);
            this.lbl_PersonelTelefon.TabIndex = 17;
            this.lbl_PersonelTelefon.Text = "Telefon :";
            // 
            // lbl_Departman
            // 
            this.lbl_Departman.AutoSize = true;
            this.lbl_Departman.Location = new System.Drawing.Point(11, 270);
            this.lbl_Departman.Name = "lbl_Departman";
            this.lbl_Departman.Size = new System.Drawing.Size(86, 20);
            this.lbl_Departman.TabIndex = 23;
            this.lbl_Departman.Text = "Departman :";
            // 
            // txt_PersonelEPosta
            // 
            // 
            // 
            // 
            this.txt_PersonelEPosta.CustomButton.Image = null;
            this.txt_PersonelEPosta.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.txt_PersonelEPosta.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_PersonelEPosta.CustomButton.Name = "";
            this.txt_PersonelEPosta.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_PersonelEPosta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_PersonelEPosta.CustomButton.TabIndex = 1;
            this.txt_PersonelEPosta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_PersonelEPosta.CustomButton.UseSelectable = true;
            this.txt_PersonelEPosta.CustomButton.Visible = false;
            this.txt_PersonelEPosta.Lines = new string[0];
            this.txt_PersonelEPosta.Location = new System.Drawing.Point(127, 154);
            this.txt_PersonelEPosta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_PersonelEPosta.MaxLength = 32767;
            this.txt_PersonelEPosta.Name = "txt_PersonelEPosta";
            this.txt_PersonelEPosta.PasswordChar = '\0';
            this.txt_PersonelEPosta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_PersonelEPosta.SelectedText = "";
            this.txt_PersonelEPosta.SelectionLength = 0;
            this.txt_PersonelEPosta.SelectionStart = 0;
            this.txt_PersonelEPosta.ShortcutsEnabled = true;
            this.txt_PersonelEPosta.Size = new System.Drawing.Size(173, 23);
            this.txt_PersonelEPosta.TabIndex = 18;
            this.txt_PersonelEPosta.UseSelectable = true;
            this.txt_PersonelEPosta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_PersonelEPosta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_PersonelEposta
            // 
            this.lbl_PersonelEposta.AutoSize = true;
            this.lbl_PersonelEposta.Location = new System.Drawing.Point(11, 154);
            this.lbl_PersonelEposta.Name = "lbl_PersonelEposta";
            this.lbl_PersonelEposta.Size = new System.Drawing.Size(60, 20);
            this.lbl_PersonelEposta.TabIndex = 19;
            this.lbl_PersonelEposta.Text = "E Posta :";
            // 
            // lbl_PersonelAdres
            // 
            this.lbl_PersonelAdres.AutoSize = true;
            this.lbl_PersonelAdres.Location = new System.Drawing.Point(12, 192);
            this.lbl_PersonelAdres.Name = "lbl_PersonelAdres";
            this.lbl_PersonelAdres.Size = new System.Drawing.Size(52, 20);
            this.lbl_PersonelAdres.TabIndex = 21;
            this.lbl_PersonelAdres.Text = "Adres :";
            // 
            // txt_PersonelAdres
            // 
            // 
            // 
            // 
            this.txt_PersonelAdres.CustomButton.Image = null;
            this.txt_PersonelAdres.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.txt_PersonelAdres.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_PersonelAdres.CustomButton.Name = "";
            this.txt_PersonelAdres.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_PersonelAdres.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_PersonelAdres.CustomButton.TabIndex = 1;
            this.txt_PersonelAdres.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_PersonelAdres.CustomButton.UseSelectable = true;
            this.txt_PersonelAdres.CustomButton.Visible = false;
            this.txt_PersonelAdres.Lines = new string[0];
            this.txt_PersonelAdres.Location = new System.Drawing.Point(127, 192);
            this.txt_PersonelAdres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_PersonelAdres.MaxLength = 32767;
            this.txt_PersonelAdres.Name = "txt_PersonelAdres";
            this.txt_PersonelAdres.PasswordChar = '\0';
            this.txt_PersonelAdres.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_PersonelAdres.SelectedText = "";
            this.txt_PersonelAdres.SelectionLength = 0;
            this.txt_PersonelAdres.SelectionStart = 0;
            this.txt_PersonelAdres.ShortcutsEnabled = true;
            this.txt_PersonelAdres.Size = new System.Drawing.Size(173, 23);
            this.txt_PersonelAdres.TabIndex = 20;
            this.txt_PersonelAdres.UseSelectable = true;
            this.txt_PersonelAdres.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_PersonelAdres.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_PersonelPuan
            // 
            this.lbl_PersonelPuan.AutoSize = true;
            this.lbl_PersonelPuan.Location = new System.Drawing.Point(376, 315);
            this.lbl_PersonelPuan.Name = "lbl_PersonelPuan";
            this.lbl_PersonelPuan.Size = new System.Drawing.Size(47, 20);
            this.lbl_PersonelPuan.TabIndex = 34;
            this.lbl_PersonelPuan.Text = "Puan :";
            this.lbl_PersonelPuan.Visible = false;
            // 
            // txt_PersonelPuan
            // 
            // 
            // 
            // 
            this.txt_PersonelPuan.CustomButton.Image = null;
            this.txt_PersonelPuan.CustomButton.Location = new System.Drawing.Point(175, 1);
            this.txt_PersonelPuan.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_PersonelPuan.CustomButton.Name = "";
            this.txt_PersonelPuan.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_PersonelPuan.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_PersonelPuan.CustomButton.TabIndex = 1;
            this.txt_PersonelPuan.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_PersonelPuan.CustomButton.UseSelectable = true;
            this.txt_PersonelPuan.CustomButton.Visible = false;
            this.txt_PersonelPuan.Lines = new string[0];
            this.txt_PersonelPuan.Location = new System.Drawing.Point(449, 315);
            this.txt_PersonelPuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_PersonelPuan.MaxLength = 32767;
            this.txt_PersonelPuan.Name = "txt_PersonelPuan";
            this.txt_PersonelPuan.PasswordChar = '\0';
            this.txt_PersonelPuan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_PersonelPuan.SelectedText = "";
            this.txt_PersonelPuan.SelectionLength = 0;
            this.txt_PersonelPuan.SelectionStart = 0;
            this.txt_PersonelPuan.ShortcutsEnabled = true;
            this.txt_PersonelPuan.Size = new System.Drawing.Size(197, 23);
            this.txt_PersonelPuan.TabIndex = 33;
            this.txt_PersonelPuan.UseSelectable = true;
            this.txt_PersonelPuan.Visible = false;
            this.txt_PersonelPuan.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_PersonelPuan.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_PersonelIslemleri
            // 
            this.btn_PersonelIslemleri.Location = new System.Drawing.Point(377, 356);
            this.btn_PersonelIslemleri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_PersonelIslemleri.Name = "btn_PersonelIslemleri";
            this.btn_PersonelIslemleri.Size = new System.Drawing.Size(269, 27);
            this.btn_PersonelIslemleri.TabIndex = 32;
            this.btn_PersonelIslemleri.UseSelectable = true;
            this.btn_PersonelIslemleri.Visible = false;
            this.btn_PersonelIslemleri.Click += new System.EventHandler(this.btn_PersonelIslemleri_Click);
            // 
            // cmb_Personeller
            // 
            this.cmb_Personeller.FormattingEnabled = true;
            this.cmb_Personeller.ItemHeight = 24;
            this.cmb_Personeller.Location = new System.Drawing.Point(377, 257);
            this.cmb_Personeller.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Personeller.Name = "cmb_Personeller";
            this.cmb_Personeller.Size = new System.Drawing.Size(268, 30);
            this.cmb_Personeller.TabIndex = 31;
            this.cmb_Personeller.UseSelectable = true;
            this.cmb_Personeller.Visible = false;
            this.cmb_Personeller.SelectedIndexChanged += new System.EventHandler(this.cmb_Personeller_SelectedIndexChanged);
            // 
            // txt_LockedPersonelPuani
            // 
            // 
            // 
            // 
            this.txt_LockedPersonelPuani.CustomButton.Image = null;
            this.txt_LockedPersonelPuani.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.txt_LockedPersonelPuani.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_LockedPersonelPuani.CustomButton.Name = "";
            this.txt_LockedPersonelPuani.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_LockedPersonelPuani.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_LockedPersonelPuani.CustomButton.TabIndex = 1;
            this.txt_LockedPersonelPuani.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_LockedPersonelPuani.CustomButton.UseSelectable = true;
            this.txt_LockedPersonelPuani.CustomButton.Visible = false;
            this.txt_LockedPersonelPuani.Lines = new string[0];
            this.txt_LockedPersonelPuani.Location = new System.Drawing.Point(127, 311);
            this.txt_LockedPersonelPuani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_LockedPersonelPuani.MaxLength = 32767;
            this.txt_LockedPersonelPuani.Name = "txt_LockedPersonelPuani";
            this.txt_LockedPersonelPuani.PasswordChar = '\0';
            this.txt_LockedPersonelPuani.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_LockedPersonelPuani.SelectedText = "";
            this.txt_LockedPersonelPuani.SelectionLength = 0;
            this.txt_LockedPersonelPuani.SelectionStart = 0;
            this.txt_LockedPersonelPuani.ShortcutsEnabled = true;
            this.txt_LockedPersonelPuani.Size = new System.Drawing.Size(173, 23);
            this.txt_LockedPersonelPuani.TabIndex = 31;
            this.txt_LockedPersonelPuani.UseSelectable = true;
            this.txt_LockedPersonelPuani.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_LockedPersonelPuani.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_LockedPersonelPuani
            // 
            this.lbl_LockedPersonelPuani.AutoSize = true;
            this.lbl_LockedPersonelPuani.Location = new System.Drawing.Point(11, 311);
            this.lbl_LockedPersonelPuani.Name = "lbl_LockedPersonelPuani";
            this.lbl_LockedPersonelPuani.Size = new System.Drawing.Size(107, 20);
            this.lbl_LockedPersonelPuani.TabIndex = 32;
            this.lbl_LockedPersonelPuani.Text = "Personel Puanı :";
            // 
            // UISistemYetkilileriPersonelBilgiIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.cmb_PersonelOtel);
            this.Controls.Add(this.grp_PersonelBilgi);
            this.Controls.Add(this.lbl_PersonelPuan);
            this.Controls.Add(this.txt_PersonelPuan);
            this.Controls.Add(this.btn_PersonelIslemleri);
            this.Controls.Add(this.cmb_Personeller);
            this.Controls.Add(this.rdo_PersonelPuanlandir);
            this.Controls.Add(this.rdo_PersonelGuncelle);
            this.Controls.Add(this.rdo_PersonelSil);
            this.Controls.Add(this.rdo_PersonelEkle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UISistemYetkilileriPersonelBilgiIslemleri";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Sistem Yetkilileri Personel Bilgi İşlemleri";
            this.Load += new System.EventHandler(this.UISistemYetkilileriPersonelBilgiIslemleri_Load);
            this.grp_PersonelBilgi.ResumeLayout(false);
            this.grp_PersonelBilgi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton rdo_PersonelPuanlandir;
        private MetroFramework.Controls.MetroRadioButton rdo_PersonelGuncelle;
        private MetroFramework.Controls.MetroRadioButton rdo_PersonelSil;
        private MetroFramework.Controls.MetroRadioButton rdo_PersonelEkle;
        private MetroFramework.Controls.MetroComboBox cmb_PersonelOtel;
        private System.Windows.Forms.GroupBox grp_PersonelBilgi;
        private MetroFramework.Controls.MetroLabel lbl_Pozisyon;
        private MetroFramework.Controls.MetroTextBox txt_Departman;
        private MetroFramework.Controls.MetroTextBox txt_Pozisyon;
        private MetroFramework.Controls.MetroTextBox txt_TamAdi;
        private MetroFramework.Controls.MetroLabel lbl_TamAdi;
        private MetroFramework.Controls.MetroTextBox txt_TCKN;
        private MetroFramework.Controls.MetroLabel lbl_TCKN;
        private MetroFramework.Controls.MetroTextBox txt_PersonelTelefon;
        private MetroFramework.Controls.MetroLabel lbl_PersonelTelefon;
        private MetroFramework.Controls.MetroLabel lbl_Departman;
        private MetroFramework.Controls.MetroTextBox txt_PersonelEPosta;
        private MetroFramework.Controls.MetroLabel lbl_PersonelEposta;
        private MetroFramework.Controls.MetroLabel lbl_PersonelAdres;
        private MetroFramework.Controls.MetroTextBox txt_PersonelAdres;
        private MetroFramework.Controls.MetroLabel lbl_PersonelPuan;
        private MetroFramework.Controls.MetroTextBox txt_PersonelPuan;
        private MetroFramework.Controls.MetroButton btn_PersonelIslemleri;
        private MetroFramework.Controls.MetroComboBox cmb_Personeller;
        private MetroFramework.Controls.MetroTextBox txt_LockedPersonelPuani;
        private MetroFramework.Controls.MetroLabel lbl_LockedPersonelPuani;
    }
}