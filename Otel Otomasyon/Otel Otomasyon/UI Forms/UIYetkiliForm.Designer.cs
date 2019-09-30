namespace Otel_Otomasyon
{
    partial class UIYetkiliForm
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
            this.tl_OtelIslemleri = new MetroFramework.Controls.MetroTile();
            this.tl_PersonelBilgiIslemleri = new MetroFramework.Controls.MetroTile();
            this.tl_PersonelListeIslemleri = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // tl_OtelIslemleri
            // 
            this.tl_OtelIslemleri.ActiveControl = null;
            this.tl_OtelIslemleri.Location = new System.Drawing.Point(103, 132);
            this.tl_OtelIslemleri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tl_OtelIslemleri.Name = "tl_OtelIslemleri";
            this.tl_OtelIslemleri.Size = new System.Drawing.Size(408, 229);
            this.tl_OtelIslemleri.TabIndex = 0;
            this.tl_OtelIslemleri.Text = "Otel Bilgi Düzenleme İşlemleri";
            this.tl_OtelIslemleri.UseSelectable = true;
            this.tl_OtelIslemleri.Click += new System.EventHandler(this.tl_OtelIslemleri_Click);
            // 
            // tl_PersonelBilgiIslemleri
            // 
            this.tl_PersonelBilgiIslemleri.ActiveControl = null;
            this.tl_PersonelBilgiIslemleri.Location = new System.Drawing.Point(764, 132);
            this.tl_PersonelBilgiIslemleri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tl_PersonelBilgiIslemleri.Name = "tl_PersonelBilgiIslemleri";
            this.tl_PersonelBilgiIslemleri.Size = new System.Drawing.Size(380, 239);
            this.tl_PersonelBilgiIslemleri.TabIndex = 1;
            this.tl_PersonelBilgiIslemleri.Text = "Personel Bilgi Düzenleme İşlemleri";
            this.tl_PersonelBilgiIslemleri.UseSelectable = true;
            this.tl_PersonelBilgiIslemleri.Click += new System.EventHandler(this.tl_PersonelBilgiIslemleri_Click);
            // 
            // tl_PersonelListeIslemleri
            // 
            this.tl_PersonelListeIslemleri.ActiveControl = null;
            this.tl_PersonelListeIslemleri.Location = new System.Drawing.Point(444, 458);
            this.tl_PersonelListeIslemleri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tl_PersonelListeIslemleri.Name = "tl_PersonelListeIslemleri";
            this.tl_PersonelListeIslemleri.Size = new System.Drawing.Size(380, 229);
            this.tl_PersonelListeIslemleri.TabIndex = 2;
            this.tl_PersonelListeIslemleri.Text = "Personel Listeleme İşlemleri";
            this.tl_PersonelListeIslemleri.UseSelectable = true;
            this.tl_PersonelListeIslemleri.Click += new System.EventHandler(this.tl_PersonelListeIslemleri_Click);
            // 
            // UIYetkiliForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.tl_PersonelListeIslemleri);
            this.Controls.Add(this.tl_PersonelBilgiIslemleri);
            this.Controls.Add(this.tl_OtelIslemleri);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UIYetkiliForm";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Text = "Sistem Yetkilisi Formu";
            this.Load += new System.EventHandler(this.YetkiliForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tl_OtelIslemleri;
        private MetroFramework.Controls.MetroTile tl_PersonelBilgiIslemleri;
        private MetroFramework.Controls.MetroTile tl_PersonelListeIslemleri;
    }
}