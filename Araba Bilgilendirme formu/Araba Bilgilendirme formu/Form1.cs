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
            // B�lgileri G�ster butonuna bast���m�zda alaca��m�z ��kt�y� burdan olu�turduk
            Renk = txtRenk.Text;
            YakitTuketimi = txtYakitTuketimi.Text;
            lblBilgiler.Text = "Bilgiler ; " + "araban�n markas� : " + Marka +
                                " araban�n modeli : " + Model +
                                " Araban�n rengi : " + Renk +
                                " Kap� say�s� : " + KapiSayisi +
                                " Pencere say�s� : " + PencereSayisi +
                                "100 Km'de yak�lan Litre : " + YakitTuketimi;
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Marka kutucu�unun i�inde se�ti�imiz se�ene�i burda yakal�yoruz
            Marka = cmbMarka.SelectedItem.ToString();
        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Model kutucu�unun i�inde se�ti�imiz se�ene�i burada yakal�yoruz
            Model = cmbModel.SelectedItem.ToString();
        }

        private void cmbKapiSayisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kap� say�s�n�n kutucu�un i�inde se�ti�imiz se�ene�i burada yakal�yoruz
            KapiSayisi = cmbKapiSayisi.SelectedItem.ToString();
        }

        private void cmbPencereSayisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Pencere say�s� kutucu�un i�inde se�ti�imiz se�ene�i burada yakal�yoruz
            PencereSayisi = cmbPencereSayisi.SelectedItem.ToString();
        }
    }
}
