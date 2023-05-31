using AdamAsmacaApp.Models;
using AdamAsmacaApp.Services;
using System.Windows.Forms;

namespace AdamAsmacaApp
{
    public partial class Form1 : Form
    {

        AdamAsmacaService _servis = new AdamAsmacaService();    
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GizliKelimeyiDoldur();
        }

        void GizliKelimeyiDoldur()
        {
            _servis.KelimeleriOlustur();
            tbKelime.Text = _servis.RastgeleKelimeGetir();
        }

        private void tbHarf_TextChanged(object sender, EventArgs e)
        {
            TahminEt();
            OyunSonucu sonuc = _servis.KelimeleriKontrolEt();
            if (sonuc == OyunSonucu.KelimeBulundu)
            {
                lBilgi.Text += " Tebrikler, kelimeyi buldunuz.";
                tbHarf.Enabled = false;
            }
        }

        private void TahminEt()
        {
            lBilgi.Visible = false;
            string harf = tbHarf.Text;
            if (string.IsNullOrWhiteSpace(harf))
            {
                lBilgi.Visible = true;
                lBilgi.Text = "Harf Giriniz";
                lBilgi.ForeColor = Color.Red;
                return;

            }

            lBilgi.Text = _servis.TahminEt(harf);
            lBilgi.Visible = true;
        }
    }
}