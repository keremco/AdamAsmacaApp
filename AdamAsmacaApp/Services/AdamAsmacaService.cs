using AdamAsmacaApp.Models;

namespace AdamAsmacaApp.Services
{
    class AdamAsmacaService
    {
        string[] _kelimeler;
        Random random = new Random();
        string _gizliKelime;

        const string _gizliKarakter = "*";

        public string RastgeleKelime { get; set; }

        public void KelimeleriOlustur()
        {
            _kelimeler = new string[]
            {
                "ARABA", "CAM", "TREN", "UÇAK", "KEDİ", "KÖPEK", "AT", "KALORİFER"
            };

        }

        public string RastgeleKelimeGetir()
        {
            int index = random.Next(0, _kelimeler.Length);
            RastgeleKelime = _kelimeler[index];

            _gizliKelime = "";
            //foreach (char harf in RastgeleKelime)
            //{
            //    _sonucKelime += _gizliKarakter;
            //}
            int i = 0;
            while (i < RastgeleKelime.Length)
            {
                _gizliKelime += _gizliKarakter;
                i++;
            }
            return _gizliKelime;
        }

        public string TahminEt(string harf)
        {
            char[] _gizliKelimeKarakterler = _gizliKelime.ToCharArray();
            
            for (int i = 0; i < RastgeleKelime.Length; i++)
            {
                if (RastgeleKelime[i].ToString() == harf)
                {
                    _gizliKelimeKarakterler[i] = Convert.ToChar(harf);
                }
            }

            _gizliKelime = new string(_gizliKelimeKarakterler);
            return _gizliKelime;
        }
        
        public OyunSonucu KelimeleriKontrolEt()
        {
            OyunSonucu sonuc = RastgeleKelime == _gizliKelime ? OyunSonucu.KelimeBulundu : OyunSonucu.DevamEdiyor;
            return sonuc;
        }
    }

    
}
