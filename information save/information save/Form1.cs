namespace information_save
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerifyData_Click(object sender, EventArgs e)
        {
            Bilgiler bilgiler = new Bilgiler();
            bilgiler.Name = txtName.Text;
            bilgiler.Surname = txtSurname.Text;
            bilgiler.Depertman = txtDepertman.Text;


            if (ZorunluAlanKontrol.IsTrue(bilgiler))
            {

                lblResult.Text = "Result : Your verify data is saved. " + bilgiler.Name + " " + bilgiler.Surname + " " + bilgiler.Depertman;
            }
            else
            {
                lblResult.Text = "Result : Your verify data is missing";

            }
        }
    }
}
