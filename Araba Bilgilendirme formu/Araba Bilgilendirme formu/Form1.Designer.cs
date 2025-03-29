namespace Araba_Bilgilendirme_formu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMarka = new Label();
            cmbMarka = new ComboBox();
            btnBilgileriGoster = new Button();
            lblBilgiler = new Label();
            lblModel = new Label();
            cmbModel = new ComboBox();
            lblName = new Label();
            txtRenk = new TextBox();
            lblKapiSayisi = new Label();
            cmbKapiSayisi = new ComboBox();
            lblPencereSayisi = new Label();
            cmbPencereSayisi = new ComboBox();
            lblYakitTuketimi = new Label();
            txtYakitTuketimi = new TextBox();
            SuspendLayout();
            // 
            // lblMarka
            // 
            lblMarka.AutoSize = true;
            lblMarka.Location = new Point(173, 51);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(57, 20);
            lblMarka.TabIndex = 0;
            lblMarka.Text = "Marka :";
            // 
            // cmbMarka
            // 
            cmbMarka.FormattingEnabled = true;
            cmbMarka.Items.AddRange(new object[] { "BMW", "Mercedes", "Toyota" });
            cmbMarka.Location = new Point(358, 43);
            cmbMarka.Name = "cmbMarka";
            cmbMarka.Size = new Size(185, 28);
            cmbMarka.TabIndex = 1;
            cmbMarka.Text = "Seçiniz";
            cmbMarka.SelectedIndexChanged += cmbMarka_SelectedIndexChanged;
            // 
            // btnBilgileriGoster
            // 
            btnBilgileriGoster.Location = new Point(628, 337);
            btnBilgileriGoster.Name = "btnBilgileriGoster";
            btnBilgileriGoster.Size = new Size(128, 54);
            btnBilgileriGoster.TabIndex = 2;
            btnBilgileriGoster.Text = "Bilgileri Göster";
            btnBilgileriGoster.UseVisualStyleBackColor = true;
            btnBilgileriGoster.Click += btnBilgileriGoster_Click;
            // 
            // lblBilgiler
            // 
            lblBilgiler.AutoSize = true;
            lblBilgiler.Location = new Point(173, 403);
            lblBilgiler.Name = "lblBilgiler";
            lblBilgiler.Size = new Size(67, 20);
            lblBilgiler.TabIndex = 3;
            lblBilgiler.Text = "Bilgileri :";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(173, 104);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(59, 20);
            lblModel.TabIndex = 4;
            lblModel.Text = "Model :";
            // 
            // cmbModel
            // 
            cmbModel.FormattingEnabled = true;
            cmbModel.Items.AddRange(new object[] { "X5", "Yaris", "C180" });
            cmbModel.Location = new Point(358, 96);
            cmbModel.Name = "cmbModel";
            cmbModel.Size = new Size(185, 28);
            cmbModel.TabIndex = 5;
            cmbModel.Text = "Seçiniz";
            cmbModel.SelectedIndexChanged += cmbModel_SelectedIndexChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(173, 156);
            lblName.Name = "lblName";
            lblName.Size = new Size(48, 20);
            lblName.TabIndex = 6;
            lblName.Text = "Renk :";
            // 
            // txtRenk
            // 
            txtRenk.Location = new Point(358, 149);
            txtRenk.Name = "txtRenk";
            txtRenk.Size = new Size(185, 27);
            txtRenk.TabIndex = 7;
            // 
            // lblKapiSayisi
            // 
            lblKapiSayisi.AutoSize = true;
            lblKapiSayisi.Location = new Point(173, 197);
            lblKapiSayisi.Name = "lblKapiSayisi";
            lblKapiSayisi.Size = new Size(85, 20);
            lblKapiSayisi.TabIndex = 8;
            lblKapiSayisi.Text = "Kapı sayısı :";
            // 
            // cmbKapiSayisi
            // 
            cmbKapiSayisi.FormattingEnabled = true;
            cmbKapiSayisi.Items.AddRange(new object[] { "2 Kapılı", "4 Kapılı" });
            cmbKapiSayisi.Location = new Point(358, 194);
            cmbKapiSayisi.Name = "cmbKapiSayisi";
            cmbKapiSayisi.Size = new Size(185, 28);
            cmbKapiSayisi.TabIndex = 9;
            cmbKapiSayisi.Text = "Seçiniz";
            cmbKapiSayisi.SelectedIndexChanged += cmbKapiSayisi_SelectedIndexChanged;
            // 
            // lblPencereSayisi
            // 
            lblPencereSayisi.AutoSize = true;
            lblPencereSayisi.Location = new Point(173, 244);
            lblPencereSayisi.Name = "lblPencereSayisi";
            lblPencereSayisi.Size = new Size(108, 20);
            lblPencereSayisi.TabIndex = 10;
            lblPencereSayisi.Text = "Pencere Sayısı :";
            // 
            // cmbPencereSayisi
            // 
            cmbPencereSayisi.FormattingEnabled = true;
            cmbPencereSayisi.Items.AddRange(new object[] { "4 pencereli", "6 Pencereli" });
            cmbPencereSayisi.Location = new Point(358, 241);
            cmbPencereSayisi.Name = "cmbPencereSayisi";
            cmbPencereSayisi.Size = new Size(185, 28);
            cmbPencereSayisi.TabIndex = 11;
            cmbPencereSayisi.Text = "Seçiniz";
            cmbPencereSayisi.SelectedIndexChanged += cmbPencereSayisi_SelectedIndexChanged;
            // 
            // lblYakitTuketimi
            // 
            lblYakitTuketimi.AutoSize = true;
            lblYakitTuketimi.Location = new Point(173, 292);
            lblYakitTuketimi.Name = "lblYakitTuketimi";
            lblYakitTuketimi.Size = new Size(108, 20);
            lblYakitTuketimi.TabIndex = 12;
            lblYakitTuketimi.Text = "Yakıt Tüketimi :";
            // 
            // txtYakitTuketimi
            // 
            txtYakitTuketimi.Location = new Point(358, 289);
            txtYakitTuketimi.Name = "txtYakitTuketimi";
            txtYakitTuketimi.Size = new Size(185, 27);
            txtYakitTuketimi.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 589);
            Controls.Add(txtYakitTuketimi);
            Controls.Add(lblYakitTuketimi);
            Controls.Add(cmbPencereSayisi);
            Controls.Add(lblPencereSayisi);
            Controls.Add(cmbKapiSayisi);
            Controls.Add(lblKapiSayisi);
            Controls.Add(txtRenk);
            Controls.Add(lblName);
            Controls.Add(cmbModel);
            Controls.Add(lblModel);
            Controls.Add(lblBilgiler);
            Controls.Add(btnBilgileriGoster);
            Controls.Add(cmbMarka);
            Controls.Add(lblMarka);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMarka;
        private ComboBox cmbMarka;
        private Button btnBilgileriGoster;
        private Label lblBilgiler;
        private Label lblModel;
        private ComboBox cmbModel;
        private Label lblName;
        private TextBox txtRenk;
        private Label lblKapiSayisi;
        private ComboBox cmbKapiSayisi;
        private Label lblPencereSayisi;
        private ComboBox cmbPencereSayisi;
        private Label lblYakitTuketimi;
        private TextBox txtYakitTuketimi;
    }
}
