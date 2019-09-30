using MetroFramework.Forms;
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
    public partial class UIYetkiliForm : MetroForm
    {
        public UIYetkiliForm()
        {
            InitializeComponent();
        }

        private void YetkiliForm_Load(object sender, EventArgs e)
        { 

        }

        private void tl_OtelIslemleri_Click(object sender, EventArgs e)
        {
            UISistemYetkiliOtelIslemleri uISistemYetkiliOtelIslemleri = new UISistemYetkiliOtelIslemleri();
            uISistemYetkiliOtelIslemleri.ShowDialog();
        }

        private void tl_PersonelBilgiIslemleri_Click(object sender, EventArgs e)
        {
            UISistemYetkilileriPersonelBilgiIslemleri uISistemYetkilileriPersonelBilgiIslemleri = new UISistemYetkilileriPersonelBilgiIslemleri();
            uISistemYetkilileriPersonelBilgiIslemleri.ShowDialog();
        }

        private void tl_PersonelListeIslemleri_Click(object sender, EventArgs e)
        {
            UISistemYetkilileriPersonelListelemeIslemleri uISistemYetkilileriPersonelListelemeIslemleri = new UISistemYetkilileriPersonelListelemeIslemleri();
            uISistemYetkilileriPersonelListelemeIslemleri.ShowDialog();
        }
    }
}
