namespace Otel_Otomasyon
{
    partial class UISistemYetkilileriPersonelListelemeIslemleri
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
            this.lstvw_PersonelListe = new MetroFramework.Controls.MetroListView();
            this.clmn_TamAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmn_TCKNO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmn_Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmn_Adres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmn_EPosta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmn_Departman = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmn_Pozisyon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmn_PersonelPuani = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rdo_DepartmanListele = new MetroFramework.Controls.MetroRadioButton();
            this.rdo_PersonelListele = new MetroFramework.Controls.MetroRadioButton();
            this.btn_PersonelIslemleri = new MetroFramework.Controls.MetroButton();
            this.cmb_Oteller = new System.Windows.Forms.ComboBox();
            this.txt_Departman = new MetroFramework.Controls.MetroTextBox();
            this.lbl_Departman = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstvw_PersonelListe
            // 
            this.lstvw_PersonelListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmn_TamAdi,
            this.clmn_TCKNO,
            this.clmn_Telefon,
            this.clmn_Adres,
            this.clmn_EPosta,
            this.clmn_Departman,
            this.clmn_Pozisyon,
            this.clmn_PersonelPuani});
            this.lstvw_PersonelListe.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lstvw_PersonelListe.FullRowSelect = true;
            this.lstvw_PersonelListe.Location = new System.Drawing.Point(29, 186);
            this.lstvw_PersonelListe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstvw_PersonelListe.Name = "lstvw_PersonelListe";
            this.lstvw_PersonelListe.OwnerDraw = true;
            this.lstvw_PersonelListe.Size = new System.Drawing.Size(1007, 525);
            this.lstvw_PersonelListe.TabIndex = 29;
            this.lstvw_PersonelListe.UseCompatibleStateImageBehavior = false;
            this.lstvw_PersonelListe.UseSelectable = true;
            this.lstvw_PersonelListe.View = System.Windows.Forms.View.Details;
            // 
            // clmn_TamAdi
            // 
            this.clmn_TamAdi.Text = "Tam Adı";
            this.clmn_TamAdi.Width = 128;
            // 
            // clmn_TCKNO
            // 
            this.clmn_TCKNO.Text = "TCKNO";
            this.clmn_TCKNO.Width = 102;
            // 
            // clmn_Telefon
            // 
            this.clmn_Telefon.Text = "Telefon";
            this.clmn_Telefon.Width = 121;
            // 
            // clmn_Adres
            // 
            this.clmn_Adres.Text = "Adres";
            this.clmn_Adres.Width = 139;
            // 
            // clmn_EPosta
            // 
            this.clmn_EPosta.Text = "E-Posta";
            this.clmn_EPosta.Width = 121;
            // 
            // clmn_Departman
            // 
            this.clmn_Departman.Text = "Departman";
            this.clmn_Departman.Width = 110;
            // 
            // clmn_Pozisyon
            // 
            this.clmn_Pozisyon.Text = "Pozisyon";
            this.clmn_Pozisyon.Width = 99;
            // 
            // clmn_PersonelPuani
            // 
            this.clmn_PersonelPuani.Text = "Puan";
            // 
            // rdo_DepartmanListele
            // 
            this.rdo_DepartmanListele.AutoSize = true;
            this.rdo_DepartmanListele.Location = new System.Drawing.Point(321, 96);
            this.rdo_DepartmanListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdo_DepartmanListele.Name = "rdo_DepartmanListele";
            this.rdo_DepartmanListele.Size = new System.Drawing.Size(223, 17);
            this.rdo_DepartmanListele.TabIndex = 28;
            this.rdo_DepartmanListele.Text = "Departmana Göre Personel Listele";
            this.rdo_DepartmanListele.UseSelectable = true;
            this.rdo_DepartmanListele.CheckedChanged += new System.EventHandler(this.rdo_DepartmanListele_CheckedChanged);
            // 
            // rdo_PersonelListele
            // 
            this.rdo_PersonelListele.AutoSize = true;
            this.rdo_PersonelListele.Location = new System.Drawing.Point(29, 96);
            this.rdo_PersonelListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdo_PersonelListele.Name = "rdo_PersonelListele";
            this.rdo_PersonelListele.Size = new System.Drawing.Size(213, 17);
            this.rdo_PersonelListele.TabIndex = 27;
            this.rdo_PersonelListele.Text = "En Yüksek Puanlı Personel Listele";
            this.rdo_PersonelListele.UseSelectable = true;
            this.rdo_PersonelListele.CheckedChanged += new System.EventHandler(this.rdo_PersonelListele_CheckedChanged);
            // 
            // btn_PersonelIslemleri
            // 
            this.btn_PersonelIslemleri.Location = new System.Drawing.Point(772, 122);
            this.btn_PersonelIslemleri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_PersonelIslemleri.Name = "btn_PersonelIslemleri";
            this.btn_PersonelIslemleri.Size = new System.Drawing.Size(174, 35);
            this.btn_PersonelIslemleri.TabIndex = 33;
            this.btn_PersonelIslemleri.UseSelectable = true;
            this.btn_PersonelIslemleri.Click += new System.EventHandler(this.btn_PersonelIslemleri_Click);
            // 
            // cmb_Oteller
            // 
            this.cmb_Oteller.FormattingEnabled = true;
            this.cmb_Oteller.Location = new System.Drawing.Point(735, 43);
            this.cmb_Oteller.Name = "cmb_Oteller";
            this.cmb_Oteller.Size = new System.Drawing.Size(248, 24);
            this.cmb_Oteller.TabIndex = 34;
            // 
            // txt_Departman
            // 
            // 
            // 
            // 
            this.txt_Departman.CustomButton.Image = null;
            this.txt_Departman.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.txt_Departman.CustomButton.Name = "";
            this.txt_Departman.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_Departman.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Departman.CustomButton.TabIndex = 1;
            this.txt_Departman.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Departman.CustomButton.UseSelectable = true;
            this.txt_Departman.CustomButton.Visible = false;
            this.txt_Departman.Lines = new string[0];
            this.txt_Departman.Location = new System.Drawing.Point(528, 146);
            this.txt_Departman.MaxLength = 32767;
            this.txt_Departman.Name = "txt_Departman";
            this.txt_Departman.PasswordChar = '\0';
            this.txt_Departman.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Departman.SelectedText = "";
            this.txt_Departman.SelectionLength = 0;
            this.txt_Departman.SelectionStart = 0;
            this.txt_Departman.ShortcutsEnabled = true;
            this.txt_Departman.Size = new System.Drawing.Size(167, 23);
            this.txt_Departman.TabIndex = 35;
            this.txt_Departman.UseSelectable = true;
            this.txt_Departman.Visible = false;
            this.txt_Departman.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Departman.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_Departman
            // 
            this.lbl_Departman.AutoSize = true;
            this.lbl_Departman.Location = new System.Drawing.Point(436, 146);
            this.lbl_Departman.Name = "lbl_Departman";
            this.lbl_Departman.Size = new System.Drawing.Size(86, 17);
            this.lbl_Departman.TabIndex = 36;
            this.lbl_Departman.Text = "Departman :";
            this.lbl_Departman.Visible = false;
            // 
            // UISistemYetkilileriPersonelListelemeIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 738);
            this.Controls.Add(this.lbl_Departman);
            this.Controls.Add(this.txt_Departman);
            this.Controls.Add(this.cmb_Oteller);
            this.Controls.Add(this.btn_PersonelIslemleri);
            this.Controls.Add(this.lstvw_PersonelListe);
            this.Controls.Add(this.rdo_DepartmanListele);
            this.Controls.Add(this.rdo_PersonelListele);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UISistemYetkilileriPersonelListelemeIslemleri";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Sistem Yetkilileri Personel Listeleme İşlemleri";
            this.Load += new System.EventHandler(this.UISistemYetkilileriPersonelListelemeIslemleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroListView lstvw_PersonelListe;
        private System.Windows.Forms.ColumnHeader clmn_TamAdi;
        private System.Windows.Forms.ColumnHeader clmn_TCKNO;
        private System.Windows.Forms.ColumnHeader clmn_Telefon;
        private System.Windows.Forms.ColumnHeader clmn_Adres;
        private System.Windows.Forms.ColumnHeader clmn_EPosta;
        private System.Windows.Forms.ColumnHeader clmn_Departman;
        private System.Windows.Forms.ColumnHeader clmn_Pozisyon;
        private System.Windows.Forms.ColumnHeader clmn_PersonelPuani;
        private MetroFramework.Controls.MetroRadioButton rdo_DepartmanListele;
        private MetroFramework.Controls.MetroRadioButton rdo_PersonelListele;
        private MetroFramework.Controls.MetroButton btn_PersonelIslemleri;
        private System.Windows.Forms.ComboBox cmb_Oteller;
        private MetroFramework.Controls.MetroTextBox txt_Departman;
        private System.Windows.Forms.Label lbl_Departman;
    }
}