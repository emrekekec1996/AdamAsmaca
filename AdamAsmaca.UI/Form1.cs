namespace AdamAsmaca.UI
{
    public partial class Form1 : Form
    {
        private string secilenKelime;
        private int hataSayisi = 0;
        private List<Button> adamParcalari = new List<Button>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KelimeSec();
            AdamParcalariListele();
            HarfButonlariOlustur();
        }

        private void KelimeSec()
        {
            List<string> kelimeler = new List<string>
            {
                // Basitleþtirilmiþ Kelimeler
                "KAPI", "MASA", "KALP", "BILGI", "YAZILIM",
                "EKRAN", "KUMANDA", "KUTU", "PENCERE", "SANDALYE",
                
                // Bilimsel ve Genel Kavramlar
                "ATLAS", "FOTO", "TEKNIK", "ELEKTRONIK", "RADYO",
                "TARAYICI", "UCUZ", "DOKTOR", "GOKYUZU", "BASLANGIC",
                
                // Kolay Yabancý Kelimeler
                "MOTOR", "HIPOTEZ", "FONETIK", "PSIKOZ", "ANALIZ",
                "TAMIR", "FIRIN", "TURIST", "KAMERA", "FUTBOL"
            };

            Random rnd = new Random();
            secilenKelime = kelimeler[rnd.Next(kelimeler.Count)].ToUpper();

            string gizliKelime = "";
            for (int i = 0; i < secilenKelime.Length; i++)
            {
                gizliKelime += "_ ";
            }
            lblKelime.Text = gizliKelime.Trim();
        }

        private void AdamParcalariListele()
        {
            adamParcalari.Add(btnBas);
            adamParcalari.Add(btnGovde);
            adamParcalari.Add(btnSagKol);
            adamParcalari.Add(btnSolKol);
            adamParcalari.Add(btnSolBacak);
            adamParcalari.Add(btnSagBacak);

            foreach (var btn in adamParcalari)
            {
                btn.Visible = false;
            }
        }

        private void HarfButonlariOlustur()
        {
            int x = 10, y = 20;
            int butonBoyut = 40;
            int aralik = 10;
            int butonSayisi = 0;
            int butonSatirSayisi = 13;
            int toplamHarf = 26;

            for (int i = 65; i <= 90; i++) // ASCII 'A' = 65 ,'Z' = 90
            {
                Button btn1 = new Button();
                btn1.Text = ((char)i).ToString();
                btn1.Height = butonBoyut;
                btn1.Width = butonBoyut;
                btn1.Location = new Point(x, y);
                btn1.Font = new Font("Arial", 12, FontStyle.Bold);
                grpBoxHarfler.Controls.Add(btn1);
                btn1.Click += Btn1_Click;
                x += butonBoyut + aralik;
                butonSayisi++;

                if (butonSayisi % butonSatirSayisi == 0)
                {
                    x = 10;
                    y += butonBoyut + aralik;
                }
            }
        }

        private void Btn1_Click(object? sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            char secilenHarf = btn.Text[0];
            btn.Enabled = false; // seçilen harfi pasif yapýyorum

            if (secilenKelime.Contains(secilenHarf))
            {
                char[] karakterler = lblKelime.Text.Replace(" ", "").ToCharArray();
                for (int i = 0; i < secilenKelime.Length; i++)
                {
                    if (secilenKelime[i] == secilenHarf)
                    {
                        karakterler[i] = secilenHarf;
                    }
                }
                lblKelime.Text = string.Join(" ", karakterler);

                if (!lblKelime.Text.Contains("_"))
                {
                    MessageBox.Show("Kazandýnýz");
                }
            }
            else
            {
                if (hataSayisi < 6)
                {
                    adamParcalari[hataSayisi].Visible = true;
                    hataSayisi++;
                    if (hataSayisi == 6)
                    {
                        MessageBox.Show("Kaybettiniz " + secilenKelime);
                    }
                }
            }
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            hataSayisi = 0; // Hata sayýsýný sýfýrla
            KelimeSec(); // Yeni kelime seç
            AdamParcalariListele(); // Adamýn parçalarýný sýfýrla

            // Harf butonlarýný aktif hale getir
            foreach (Control ctrl in grpBoxHarfler.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.Enabled = true;
                }
            }
        }
    }
}
