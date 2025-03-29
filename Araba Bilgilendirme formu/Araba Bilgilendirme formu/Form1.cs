namespace Araba_Bilgilendirme_formu
{
    public partial class Form1 : Form
    {
        string Marka = " ";
        string Model = " ";
        string Renk = " ";
        string KapiSayisi = " ";
        string PencereSayisi = " ";
        string YakitTuketimi = " ";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBilgileriGoster_Click(object sender, EventArgs e)
        {
            // BÝlgileri Göster butonuna bastýðýmýzda alacaðýmýz çýktýyý burdan oluþturduk
            Renk = txtRenk.Text;
            YakitTuketimi = txtYakitTuketimi.Text;
            lblBilgiler.Text = "Bilgiler ; " + "arabanýn markasý : " + Marka +
                                " arabanýn modeli : " + Model +
                                " Arabanýn rengi : " + Renk +
                                " Kapý sayýsý : " + KapiSayisi +
                                " Pencere sayýsý : " + PencereSayisi +
                                "100 Km'de yakýlan Litre : " + YakitTuketimi;
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Marka kutucuðunun içinde seçtiðimiz seçeneði burda yakalýyoruz
            Marka = cmbMarka.SelectedItem.ToString();
        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Model kutucuðunun içinde seçtiðimiz seçeneði burada yakalýyoruz
            Model = cmbModel.SelectedItem.ToString();
        }

        private void cmbKapiSayisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kapý sayýsýnýn kutucuðun içinde seçtiðimiz seçeneði burada yakalýyoruz
            KapiSayisi = cmbKapiSayisi.SelectedItem.ToString();
        }

        private void cmbPencereSayisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Pencere sayýsý kutucuðun içinde seçtiðimiz seçeneði burada yakalýyoruz
            PencereSayisi = cmbPencereSayisi.SelectedItem.ToString();
        }
    }
}
