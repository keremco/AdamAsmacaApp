using System.Windows.Forms;

namespace AdamAsmacaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbHarf_TextChanged(object sender, EventArgs e)
        {
            string harf = tbHarf.Text;
            if (string.IsNullOrWhiteSpace(harf))
            {
                lBilgi.Visible = true;
                lBilgi.Text = "Harf Giriniz";
            }
        
    }
}