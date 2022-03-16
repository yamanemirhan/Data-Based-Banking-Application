
namespace ATM
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.pnlAnaSayfa = new System.Windows.Forms.Panel();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.txtGuvenlikKelimesi = new System.Windows.Forms.TextBox();
            this.lblGuvenlikKelimesi = new System.Windows.Forms.Label();
            this.lblKurallar = new System.Windows.Forms.Label();
            this.lnklabelHesapOlustur = new System.Windows.Forms.LinkLabel();
            this.lnklabelSifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.pnlGiris = new System.Windows.Forms.Panel();
            this.btnHesapCikis = new System.Windows.Forms.Button();
            this.btnSonIslemler = new System.Windows.Forms.Button();
            this.comboOdemeler = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlParaTransferi = new System.Windows.Forms.Panel();
            this.btnTransferGeriDon = new System.Windows.Forms.Button();
            this.btnGonder = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGonderilecekMiktar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTransferBakiye = new System.Windows.Forms.Label();
            this.txtAliciTCNO = new System.Windows.Forms.TextBox();
            this.lblTransferTC = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlFaturaOdeme = new System.Windows.Forms.Panel();
            this.btnOde = new System.Windows.Forms.Button();
            this.lblFaturaBedeli = new System.Windows.Forms.Label();
            this.grpFaturalar = new System.Windows.Forms.GroupBox();
            this.rbtnInternet = new System.Windows.Forms.RadioButton();
            this.rbtnDogalgaz = new System.Windows.Forms.RadioButton();
            this.rbtnSu = new System.Windows.Forms.RadioButton();
            this.rbtnElektrik = new System.Windows.Forms.RadioButton();
            this.btnFaturaGeriDon = new System.Windows.Forms.Button();
            this.lblFaturaTC = new System.Windows.Forms.Label();
            this.lblFaturaBakiye = new System.Windows.Forms.Label();
            this.pnlKiraOdeme = new System.Windows.Forms.Panel();
            this.btnKiraOde = new System.Windows.Forms.Button();
            this.lblKiraBedeli = new System.Windows.Forms.Label();
            this.btnKiraGeriDon = new System.Windows.Forms.Button();
            this.lblKiraTC = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblKiraBakiye = new System.Windows.Forms.Label();
            this.timerParaKontrol = new System.Windows.Forms.Timer(this.components);
            this.pnlSonIslemler = new System.Windows.Forms.Panel();
            this.btnSonIslemlerGeriDon = new System.Windows.Forms.Button();
            this.btnIleri = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.lblSayfa = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSonIslem4 = new System.Windows.Forms.Button();
            this.btnSonIslem3 = new System.Windows.Forms.Button();
            this.btnSonIslem2 = new System.Windows.Forms.Button();
            this.btnSonIslem1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSonIslemlerTC = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlAnaSayfa.SuspendLayout();
            this.pnlGiris.SuspendLayout();
            this.pnlParaTransferi.SuspendLayout();
            this.pnlFaturaOdeme.SuspendLayout();
            this.grpFaturalar.SuspendLayout();
            this.pnlKiraOdeme.SuspendLayout();
            this.pnlSonIslemler.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ZİRAAT BANKASI";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(51, 177);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "T.C. KİMLİK";
            // 
            // lblSifre
            // 
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSifre.Location = new System.Drawing.Point(32, 203);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSifre.Size = new System.Drawing.Size(112, 20);
            this.lblSifre.TabIndex = 1;
            this.lblSifre.Text = "ŞİFRE";
            this.lblSifre.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(149, 177);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(171, 20);
            this.txtTC.TabIndex = 1;
            this.txtTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTC_KeyPress);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(149, 203);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(171, 20);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSifre_KeyPress);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGirisYap.Location = new System.Drawing.Point(149, 229);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(171, 47);
            this.btnGirisYap.TabIndex = 3;
            this.btnGirisYap.TabStop = false;
            this.btnGirisYap.Text = "GİRİŞ YAP";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // pnlAnaSayfa
            // 
            this.pnlAnaSayfa.Controls.Add(this.btnGeriDon);
            this.pnlAnaSayfa.Controls.Add(this.txtGuvenlikKelimesi);
            this.pnlAnaSayfa.Controls.Add(this.lblGuvenlikKelimesi);
            this.pnlAnaSayfa.Controls.Add(this.lblKurallar);
            this.pnlAnaSayfa.Controls.Add(this.lnklabelHesapOlustur);
            this.pnlAnaSayfa.Controls.Add(this.lnklabelSifremiUnuttum);
            this.pnlAnaSayfa.Controls.Add(this.label1);
            this.pnlAnaSayfa.Controls.Add(this.txtSifre);
            this.pnlAnaSayfa.Controls.Add(this.lblSifre);
            this.pnlAnaSayfa.Controls.Add(this.label2);
            this.pnlAnaSayfa.Controls.Add(this.btnGirisYap);
            this.pnlAnaSayfa.Controls.Add(this.txtTC);
            this.pnlAnaSayfa.Location = new System.Drawing.Point(9, 5);
            this.pnlAnaSayfa.Name = "pnlAnaSayfa";
            this.pnlAnaSayfa.Size = new System.Drawing.Size(395, 491);
            this.pnlAnaSayfa.TabIndex = 4;
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.Color.DarkRed;
            this.btnGeriDon.BackgroundImage = global::ATM.Properties.Resources.backspace2_removebg_preview;
            this.btnGeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeriDon.FlatAppearance.BorderSize = 0;
            this.btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriDon.ForeColor = System.Drawing.Color.Black;
            this.btnGeriDon.Location = new System.Drawing.Point(318, 21);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(52, 30);
            this.btnGeriDon.TabIndex = 9;
            this.btnGeriDon.TabStop = false;
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Visible = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // txtGuvenlikKelimesi
            // 
            this.txtGuvenlikKelimesi.Location = new System.Drawing.Point(149, 149);
            this.txtGuvenlikKelimesi.Name = "txtGuvenlikKelimesi";
            this.txtGuvenlikKelimesi.Size = new System.Drawing.Size(171, 20);
            this.txtGuvenlikKelimesi.TabIndex = 0;
            this.txtGuvenlikKelimesi.Visible = false;
            // 
            // lblGuvenlikKelimesi
            // 
            this.lblGuvenlikKelimesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGuvenlikKelimesi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblGuvenlikKelimesi.Location = new System.Drawing.Point(2, 149);
            this.lblGuvenlikKelimesi.Name = "lblGuvenlikKelimesi";
            this.lblGuvenlikKelimesi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblGuvenlikKelimesi.Size = new System.Drawing.Size(142, 17);
            this.lblGuvenlikKelimesi.TabIndex = 7;
            this.lblGuvenlikKelimesi.Text = "GÜVENLİK KELİMESİ";
            this.lblGuvenlikKelimesi.Visible = false;
            // 
            // lblKurallar
            // 
            this.lblKurallar.AutoSize = true;
            this.lblKurallar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKurallar.Location = new System.Drawing.Point(4, 364);
            this.lblKurallar.Name = "lblKurallar";
            this.lblKurallar.Size = new System.Drawing.Size(373, 51);
            this.lblKurallar.TabIndex = 6;
            this.lblKurallar.Text = "*T.C. Kimlik Numarası 11 Haneli Rakamdan Oluşmalıdır.\r\n*Şifre 6 Haneli Rakamlarda" +
    "n Oluşmalıdır.\r\n*Güvenlik Kelimesini Şifrenizi Unuttuğunuzda Kullanırsınız.";
            this.lblKurallar.Visible = false;
            // 
            // lnklabelHesapOlustur
            // 
            this.lnklabelHesapOlustur.AutoSize = true;
            this.lnklabelHesapOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnklabelHesapOlustur.LinkColor = System.Drawing.Color.Black;
            this.lnklabelHesapOlustur.Location = new System.Drawing.Point(209, 344);
            this.lnklabelHesapOlustur.Name = "lnklabelHesapOlustur";
            this.lnklabelHesapOlustur.Size = new System.Drawing.Size(111, 20);
            this.lnklabelHesapOlustur.TabIndex = 5;
            this.lnklabelHesapOlustur.TabStop = true;
            this.lnklabelHesapOlustur.Text = "Hesap Oluştur";
            this.lnklabelHesapOlustur.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklabelHesapOlustur_LinkClicked);
            // 
            // lnklabelSifremiUnuttum
            // 
            this.lnklabelSifremiUnuttum.AutoSize = true;
            this.lnklabelSifremiUnuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnklabelSifremiUnuttum.LinkColor = System.Drawing.Color.Black;
            this.lnklabelSifremiUnuttum.Location = new System.Drawing.Point(196, 308);
            this.lnklabelSifremiUnuttum.Name = "lnklabelSifremiUnuttum";
            this.lnklabelSifremiUnuttum.Size = new System.Drawing.Size(124, 20);
            this.lnklabelSifremiUnuttum.TabIndex = 4;
            this.lnklabelSifremiUnuttum.TabStop = true;
            this.lnklabelSifremiUnuttum.Text = "Şifremi Unuttum";
            this.lnklabelSifremiUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklabelSifremiUnuttum_LinkClicked);
            // 
            // pnlGiris
            // 
            this.pnlGiris.Controls.Add(this.btnHesapCikis);
            this.pnlGiris.Controls.Add(this.btnSonIslemler);
            this.pnlGiris.Controls.Add(this.comboOdemeler);
            this.pnlGiris.Controls.Add(this.label5);
            this.pnlGiris.Controls.Add(this.lblBakiye);
            this.pnlGiris.Controls.Add(this.lblTC);
            this.pnlGiris.Controls.Add(this.label3);
            this.pnlGiris.Location = new System.Drawing.Point(9, 6);
            this.pnlGiris.Name = "pnlGiris";
            this.pnlGiris.Size = new System.Drawing.Size(395, 491);
            this.pnlGiris.TabIndex = 0;
            this.pnlGiris.Visible = false;
            // 
            // btnHesapCikis
            // 
            this.btnHesapCikis.BackColor = System.Drawing.Color.DarkRed;
            this.btnHesapCikis.BackgroundImage = global::ATM.Properties.Resources.img_527483_removebg_preview;
            this.btnHesapCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHesapCikis.FlatAppearance.BorderSize = 0;
            this.btnHesapCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapCikis.ForeColor = System.Drawing.Color.Black;
            this.btnHesapCikis.Location = new System.Drawing.Point(342, 21);
            this.btnHesapCikis.Name = "btnHesapCikis";
            this.btnHesapCikis.Size = new System.Drawing.Size(27, 23);
            this.btnHesapCikis.TabIndex = 21;
            this.btnHesapCikis.TabStop = false;
            this.btnHesapCikis.UseVisualStyleBackColor = false;
            this.btnHesapCikis.Click += new System.EventHandler(this.btnHesapCikis_Click);
            // 
            // btnSonIslemler
            // 
            this.btnSonIslemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSonIslemler.Location = new System.Drawing.Point(43, 275);
            this.btnSonIslemler.Name = "btnSonIslemler";
            this.btnSonIslemler.Size = new System.Drawing.Size(109, 37);
            this.btnSonIslemler.TabIndex = 3;
            this.btnSonIslemler.Text = "Son İşlemler";
            this.btnSonIslemler.UseVisualStyleBackColor = true;
            this.btnSonIslemler.Click += new System.EventHandler(this.btnSonIslemler_Click);
            // 
            // comboOdemeler
            // 
            this.comboOdemeler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOdemeler.FormattingEnabled = true;
            this.comboOdemeler.Items.AddRange(new object[] {
            "Para Transferi",
            "Fatura Ödeme",
            "Kira Ödeme"});
            this.comboOdemeler.Location = new System.Drawing.Point(128, 222);
            this.comboOdemeler.Name = "comboOdemeler";
            this.comboOdemeler.Size = new System.Drawing.Size(153, 21);
            this.comboOdemeler.TabIndex = 2;
            this.comboOdemeler.TextChanged += new System.EventHandler(this.comboOdemeler_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(39, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ödemeler";
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBakiye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblBakiye.Location = new System.Drawing.Point(39, 166);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(78, 22);
            this.lblBakiye.TabIndex = 1;
            this.lblBakiye.Text = "Bakiye : ";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTC.Location = new System.Drawing.Point(17, 29);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(31, 16);
            this.lblTC.TabIndex = 0;
            this.lblTC.Text = "TC : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(75, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "ZİRAAT BANKASI";
            // 
            // pnlParaTransferi
            // 
            this.pnlParaTransferi.Controls.Add(this.btnTransferGeriDon);
            this.pnlParaTransferi.Controls.Add(this.btnGonder);
            this.pnlParaTransferi.Controls.Add(this.label9);
            this.pnlParaTransferi.Controls.Add(this.txtGonderilecekMiktar);
            this.pnlParaTransferi.Controls.Add(this.label6);
            this.pnlParaTransferi.Controls.Add(this.lblTransferBakiye);
            this.pnlParaTransferi.Controls.Add(this.txtAliciTCNO);
            this.pnlParaTransferi.Controls.Add(this.lblTransferTC);
            this.pnlParaTransferi.Controls.Add(this.label4);
            this.pnlParaTransferi.Location = new System.Drawing.Point(9, 7);
            this.pnlParaTransferi.Name = "pnlParaTransferi";
            this.pnlParaTransferi.Size = new System.Drawing.Size(395, 491);
            this.pnlParaTransferi.TabIndex = 1;
            this.pnlParaTransferi.Visible = false;
            // 
            // btnTransferGeriDon
            // 
            this.btnTransferGeriDon.BackColor = System.Drawing.Color.DarkRed;
            this.btnTransferGeriDon.BackgroundImage = global::ATM.Properties.Resources.backspace2_removebg_preview;
            this.btnTransferGeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTransferGeriDon.FlatAppearance.BorderSize = 0;
            this.btnTransferGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransferGeriDon.ForeColor = System.Drawing.Color.Black;
            this.btnTransferGeriDon.Location = new System.Drawing.Point(329, 21);
            this.btnTransferGeriDon.Name = "btnTransferGeriDon";
            this.btnTransferGeriDon.Size = new System.Drawing.Size(52, 30);
            this.btnTransferGeriDon.TabIndex = 9;
            this.btnTransferGeriDon.TabStop = false;
            this.btnTransferGeriDon.UseVisualStyleBackColor = false;
            this.btnTransferGeriDon.Click += new System.EventHandler(this.btnTransferGeriDon_Click);
            // 
            // btnGonder
            // 
            this.btnGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonder.ForeColor = System.Drawing.Color.Black;
            this.btnGonder.Location = new System.Drawing.Point(230, 236);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(85, 32);
            this.btnGonder.TabIndex = 4;
            this.btnGonder.TabStop = false;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(72, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(251, 36);
            this.label9.TabIndex = 0;
            this.label9.Text = "ZİRAAT BANKASI";
            // 
            // txtGonderilecekMiktar
            // 
            this.txtGonderilecekMiktar.Location = new System.Drawing.Point(159, 201);
            this.txtGonderilecekMiktar.Name = "txtGonderilecekMiktar";
            this.txtGonderilecekMiktar.Size = new System.Drawing.Size(156, 20);
            this.txtGonderilecekMiktar.TabIndex = 1;
            this.txtGonderilecekMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGonderilecekMiktar_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(3, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Gönderilecek Miktar";
            // 
            // lblTransferBakiye
            // 
            this.lblTransferBakiye.AutoSize = true;
            this.lblTransferBakiye.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferBakiye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTransferBakiye.Location = new System.Drawing.Point(27, 330);
            this.lblTransferBakiye.Name = "lblTransferBakiye";
            this.lblTransferBakiye.Size = new System.Drawing.Size(78, 22);
            this.lblTransferBakiye.TabIndex = 1;
            this.lblTransferBakiye.Text = "Bakiye : ";
            // 
            // txtAliciTCNO
            // 
            this.txtAliciTCNO.Location = new System.Drawing.Point(159, 164);
            this.txtAliciTCNO.Name = "txtAliciTCNO";
            this.txtAliciTCNO.Size = new System.Drawing.Size(156, 20);
            this.txtAliciTCNO.TabIndex = 0;
            this.txtAliciTCNO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAliciTCNO_KeyPress);
            // 
            // lblTransferTC
            // 
            this.lblTransferTC.AutoSize = true;
            this.lblTransferTC.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferTC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTransferTC.Location = new System.Drawing.Point(28, 29);
            this.lblTransferTC.Name = "lblTransferTC";
            this.lblTransferTC.Size = new System.Drawing.Size(31, 16);
            this.lblTransferTC.TabIndex = 0;
            this.lblTransferTC.Text = "TC : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(43, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "ALICI T.C. NO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(56, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 36);
            this.label7.TabIndex = 0;
            this.label7.Text = "ZİRAAT BANKASI";
            // 
            // pnlFaturaOdeme
            // 
            this.pnlFaturaOdeme.Controls.Add(this.btnOde);
            this.pnlFaturaOdeme.Controls.Add(this.lblFaturaBedeli);
            this.pnlFaturaOdeme.Controls.Add(this.grpFaturalar);
            this.pnlFaturaOdeme.Controls.Add(this.btnFaturaGeriDon);
            this.pnlFaturaOdeme.Controls.Add(this.lblFaturaTC);
            this.pnlFaturaOdeme.Controls.Add(this.label7);
            this.pnlFaturaOdeme.Controls.Add(this.lblFaturaBakiye);
            this.pnlFaturaOdeme.Location = new System.Drawing.Point(9, 13);
            this.pnlFaturaOdeme.Name = "pnlFaturaOdeme";
            this.pnlFaturaOdeme.Size = new System.Drawing.Size(395, 491);
            this.pnlFaturaOdeme.TabIndex = 3;
            this.pnlFaturaOdeme.Visible = false;
            // 
            // btnOde
            // 
            this.btnOde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOde.Location = new System.Drawing.Point(237, 185);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(92, 36);
            this.btnOde.TabIndex = 12;
            this.btnOde.TabStop = false;
            this.btnOde.Text = "Fatura Öde";
            this.btnOde.UseVisualStyleBackColor = true;
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // lblFaturaBedeli
            // 
            this.lblFaturaBedeli.AutoSize = true;
            this.lblFaturaBedeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFaturaBedeli.Location = new System.Drawing.Point(182, 150);
            this.lblFaturaBedeli.Name = "lblFaturaBedeli";
            this.lblFaturaBedeli.Size = new System.Drawing.Size(147, 20);
            this.lblFaturaBedeli.TabIndex = 11;
            this.lblFaturaBedeli.Text = "Fatura Bedeli : 0 TL";
            // 
            // grpFaturalar
            // 
            this.grpFaturalar.Controls.Add(this.rbtnInternet);
            this.grpFaturalar.Controls.Add(this.rbtnDogalgaz);
            this.grpFaturalar.Controls.Add(this.rbtnSu);
            this.grpFaturalar.Controls.Add(this.rbtnElektrik);
            this.grpFaturalar.Location = new System.Drawing.Point(15, 123);
            this.grpFaturalar.Name = "grpFaturalar";
            this.grpFaturalar.Size = new System.Drawing.Size(147, 145);
            this.grpFaturalar.TabIndex = 10;
            this.grpFaturalar.TabStop = false;
            this.grpFaturalar.Text = "Faturalar";
            // 
            // rbtnInternet
            // 
            this.rbtnInternet.AutoSize = true;
            this.rbtnInternet.Location = new System.Drawing.Point(19, 113);
            this.rbtnInternet.Name = "rbtnInternet";
            this.rbtnInternet.Size = new System.Drawing.Size(101, 17);
            this.rbtnInternet.TabIndex = 0;
            this.rbtnInternet.TabStop = true;
            this.rbtnInternet.Text = "İnternet Faturası";
            this.rbtnInternet.UseVisualStyleBackColor = true;
            this.rbtnInternet.CheckedChanged += new System.EventHandler(this.rbtnInternet_CheckedChanged);
            // 
            // rbtnDogalgaz
            // 
            this.rbtnDogalgaz.AutoSize = true;
            this.rbtnDogalgaz.Location = new System.Drawing.Point(19, 83);
            this.rbtnDogalgaz.Name = "rbtnDogalgaz";
            this.rbtnDogalgaz.Size = new System.Drawing.Size(110, 17);
            this.rbtnDogalgaz.TabIndex = 0;
            this.rbtnDogalgaz.TabStop = true;
            this.rbtnDogalgaz.Text = "Doğalgaz Faturası";
            this.rbtnDogalgaz.UseVisualStyleBackColor = true;
            this.rbtnDogalgaz.CheckedChanged += new System.EventHandler(this.rbtnDogalgaz_CheckedChanged);
            // 
            // rbtnSu
            // 
            this.rbtnSu.AutoSize = true;
            this.rbtnSu.Location = new System.Drawing.Point(19, 57);
            this.rbtnSu.Name = "rbtnSu";
            this.rbtnSu.Size = new System.Drawing.Size(78, 17);
            this.rbtnSu.TabIndex = 0;
            this.rbtnSu.TabStop = true;
            this.rbtnSu.Text = "Su Faturası";
            this.rbtnSu.UseVisualStyleBackColor = true;
            this.rbtnSu.CheckedChanged += new System.EventHandler(this.rbtnSu_CheckedChanged);
            // 
            // rbtnElektrik
            // 
            this.rbtnElektrik.AutoSize = true;
            this.rbtnElektrik.Location = new System.Drawing.Point(19, 27);
            this.rbtnElektrik.Name = "rbtnElektrik";
            this.rbtnElektrik.Size = new System.Drawing.Size(100, 17);
            this.rbtnElektrik.TabIndex = 0;
            this.rbtnElektrik.TabStop = true;
            this.rbtnElektrik.Text = "Elektrik Faturası";
            this.rbtnElektrik.UseVisualStyleBackColor = true;
            this.rbtnElektrik.CheckedChanged += new System.EventHandler(this.rbtnElektrik_CheckedChanged);
            // 
            // btnFaturaGeriDon
            // 
            this.btnFaturaGeriDon.BackColor = System.Drawing.Color.DarkRed;
            this.btnFaturaGeriDon.BackgroundImage = global::ATM.Properties.Resources.backspace2_removebg_preview;
            this.btnFaturaGeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFaturaGeriDon.FlatAppearance.BorderSize = 0;
            this.btnFaturaGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaturaGeriDon.ForeColor = System.Drawing.Color.Black;
            this.btnFaturaGeriDon.Location = new System.Drawing.Point(301, 21);
            this.btnFaturaGeriDon.Name = "btnFaturaGeriDon";
            this.btnFaturaGeriDon.Size = new System.Drawing.Size(52, 30);
            this.btnFaturaGeriDon.TabIndex = 9;
            this.btnFaturaGeriDon.TabStop = false;
            this.btnFaturaGeriDon.UseVisualStyleBackColor = false;
            this.btnFaturaGeriDon.Click += new System.EventHandler(this.btnFaturaGeriDon_Click);
            // 
            // lblFaturaTC
            // 
            this.lblFaturaTC.AutoSize = true;
            this.lblFaturaTC.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaturaTC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblFaturaTC.Location = new System.Drawing.Point(12, 29);
            this.lblFaturaTC.Name = "lblFaturaTC";
            this.lblFaturaTC.Size = new System.Drawing.Size(31, 16);
            this.lblFaturaTC.TabIndex = 0;
            this.lblFaturaTC.Text = "TC : ";
            // 
            // lblFaturaBakiye
            // 
            this.lblFaturaBakiye.AutoSize = true;
            this.lblFaturaBakiye.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaturaBakiye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblFaturaBakiye.Location = new System.Drawing.Point(11, 330);
            this.lblFaturaBakiye.Name = "lblFaturaBakiye";
            this.lblFaturaBakiye.Size = new System.Drawing.Size(78, 22);
            this.lblFaturaBakiye.TabIndex = 1;
            this.lblFaturaBakiye.Text = "Bakiye : ";
            // 
            // pnlKiraOdeme
            // 
            this.pnlKiraOdeme.Controls.Add(this.btnKiraOde);
            this.pnlKiraOdeme.Controls.Add(this.lblKiraBedeli);
            this.pnlKiraOdeme.Controls.Add(this.btnKiraGeriDon);
            this.pnlKiraOdeme.Controls.Add(this.lblKiraTC);
            this.pnlKiraOdeme.Controls.Add(this.label11);
            this.pnlKiraOdeme.Controls.Add(this.lblKiraBakiye);
            this.pnlKiraOdeme.Location = new System.Drawing.Point(7, 7);
            this.pnlKiraOdeme.Name = "pnlKiraOdeme";
            this.pnlKiraOdeme.Size = new System.Drawing.Size(395, 491);
            this.pnlKiraOdeme.TabIndex = 0;
            this.pnlKiraOdeme.Visible = false;
            // 
            // btnKiraOde
            // 
            this.btnKiraOde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKiraOde.Location = new System.Drawing.Point(135, 214);
            this.btnKiraOde.Name = "btnKiraOde";
            this.btnKiraOde.Size = new System.Drawing.Size(92, 36);
            this.btnKiraOde.TabIndex = 19;
            this.btnKiraOde.TabStop = false;
            this.btnKiraOde.Text = "Kira Öde";
            this.btnKiraOde.UseVisualStyleBackColor = true;
            this.btnKiraOde.Click += new System.EventHandler(this.btnKiraOde_Click);
            // 
            // lblKiraBedeli
            // 
            this.lblKiraBedeli.AutoSize = true;
            this.lblKiraBedeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKiraBedeli.Location = new System.Drawing.Point(118, 174);
            this.lblKiraBedeli.Name = "lblKiraBedeli";
            this.lblKiraBedeli.Size = new System.Drawing.Size(127, 20);
            this.lblKiraBedeli.TabIndex = 18;
            this.lblKiraBedeli.Text = "Kira Bedeli : 0 TL";
            // 
            // btnKiraGeriDon
            // 
            this.btnKiraGeriDon.BackColor = System.Drawing.Color.DarkRed;
            this.btnKiraGeriDon.BackgroundImage = global::ATM.Properties.Resources.backspace2_removebg_preview;
            this.btnKiraGeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKiraGeriDon.FlatAppearance.BorderSize = 0;
            this.btnKiraGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKiraGeriDon.ForeColor = System.Drawing.Color.Black;
            this.btnKiraGeriDon.Location = new System.Drawing.Point(320, 24);
            this.btnKiraGeriDon.Name = "btnKiraGeriDon";
            this.btnKiraGeriDon.Size = new System.Drawing.Size(52, 30);
            this.btnKiraGeriDon.TabIndex = 16;
            this.btnKiraGeriDon.TabStop = false;
            this.btnKiraGeriDon.UseVisualStyleBackColor = false;
            this.btnKiraGeriDon.Click += new System.EventHandler(this.btnKiraGeriDon_Click);
            // 
            // lblKiraTC
            // 
            this.lblKiraTC.AutoSize = true;
            this.lblKiraTC.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKiraTC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblKiraTC.Location = new System.Drawing.Point(31, 32);
            this.lblKiraTC.Name = "lblKiraTC";
            this.lblKiraTC.Size = new System.Drawing.Size(31, 16);
            this.lblKiraTC.TabIndex = 13;
            this.lblKiraTC.Text = "TC : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(75, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(251, 36);
            this.label11.TabIndex = 14;
            this.label11.Text = "ZİRAAT BANKASI";
            // 
            // lblKiraBakiye
            // 
            this.lblKiraBakiye.AutoSize = true;
            this.lblKiraBakiye.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKiraBakiye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblKiraBakiye.Location = new System.Drawing.Point(30, 330);
            this.lblKiraBakiye.Name = "lblKiraBakiye";
            this.lblKiraBakiye.Size = new System.Drawing.Size(78, 22);
            this.lblKiraBakiye.TabIndex = 15;
            this.lblKiraBakiye.Text = "Bakiye : ";
            // 
            // timerParaKontrol
            // 
            this.timerParaKontrol.Tick += new System.EventHandler(this.timerParaKontrol_Tick);
            // 
            // pnlSonIslemler
            // 
            this.pnlSonIslemler.Controls.Add(this.btnSonIslemlerGeriDon);
            this.pnlSonIslemler.Controls.Add(this.btnIleri);
            this.pnlSonIslemler.Controls.Add(this.btnGeri);
            this.pnlSonIslemler.Controls.Add(this.lblSayfa);
            this.pnlSonIslemler.Controls.Add(this.panel2);
            this.pnlSonIslemler.Controls.Add(this.label8);
            this.pnlSonIslemler.Controls.Add(this.lblSonIslemlerTC);
            this.pnlSonIslemler.Controls.Add(this.label10);
            this.pnlSonIslemler.Location = new System.Drawing.Point(7, 7);
            this.pnlSonIslemler.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSonIslemler.Name = "pnlSonIslemler";
            this.pnlSonIslemler.Size = new System.Drawing.Size(395, 491);
            this.pnlSonIslemler.TabIndex = 13;
            this.pnlSonIslemler.Visible = false;
            // 
            // btnSonIslemlerGeriDon
            // 
            this.btnSonIslemlerGeriDon.BackColor = System.Drawing.Color.DarkRed;
            this.btnSonIslemlerGeriDon.BackgroundImage = global::ATM.Properties.Resources.backspace2_removebg_preview;
            this.btnSonIslemlerGeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSonIslemlerGeriDon.FlatAppearance.BorderSize = 0;
            this.btnSonIslemlerGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSonIslemlerGeriDon.ForeColor = System.Drawing.Color.Black;
            this.btnSonIslemlerGeriDon.Location = new System.Drawing.Point(320, 20);
            this.btnSonIslemlerGeriDon.Name = "btnSonIslemlerGeriDon";
            this.btnSonIslemlerGeriDon.Size = new System.Drawing.Size(52, 30);
            this.btnSonIslemlerGeriDon.TabIndex = 20;
            this.btnSonIslemlerGeriDon.TabStop = false;
            this.btnSonIslemlerGeriDon.UseVisualStyleBackColor = false;
            this.btnSonIslemlerGeriDon.Click += new System.EventHandler(this.btnSonIslemlerGeriDon_Click);
            // 
            // btnIleri
            // 
            this.btnIleri.BackColor = System.Drawing.Color.White;
            this.btnIleri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIleri.Location = new System.Drawing.Point(198, 453);
            this.btnIleri.Margin = new System.Windows.Forms.Padding(2);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(56, 19);
            this.btnIleri.TabIndex = 11;
            this.btnIleri.TabStop = false;
            this.btnIleri.Text = "İleri";
            this.btnIleri.UseVisualStyleBackColor = false;
            this.btnIleri.Click += new System.EventHandler(this.btnIleri_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.White;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(96, 453);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(2);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(56, 19);
            this.btnGeri.TabIndex = 10;
            this.btnGeri.TabStop = false;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lblSayfa
            // 
            this.lblSayfa.AutoSize = true;
            this.lblSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayfa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSayfa.Location = new System.Drawing.Point(172, 453);
            this.lblSayfa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSayfa.Name = "lblSayfa";
            this.lblSayfa.Size = new System.Drawing.Size(16, 17);
            this.lblSayfa.TabIndex = 9;
            this.lblSayfa.Text = "1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnSonIslem4);
            this.panel2.Controls.Add(this.btnSonIslem3);
            this.panel2.Controls.Add(this.btnSonIslem2);
            this.panel2.Controls.Add(this.btnSonIslem1);
            this.panel2.Location = new System.Drawing.Point(20, 185);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 262);
            this.panel2.TabIndex = 8;
            // 
            // btnSonIslem4
            // 
            this.btnSonIslem4.Enabled = false;
            this.btnSonIslem4.Location = new System.Drawing.Point(2, 197);
            this.btnSonIslem4.Margin = new System.Windows.Forms.Padding(2);
            this.btnSonIslem4.Name = "btnSonIslem4";
            this.btnSonIslem4.Size = new System.Drawing.Size(338, 61);
            this.btnSonIslem4.TabIndex = 3;
            this.btnSonIslem4.UseVisualStyleBackColor = true;
            // 
            // btnSonIslem3
            // 
            this.btnSonIslem3.Enabled = false;
            this.btnSonIslem3.Location = new System.Drawing.Point(2, 132);
            this.btnSonIslem3.Margin = new System.Windows.Forms.Padding(2);
            this.btnSonIslem3.Name = "btnSonIslem3";
            this.btnSonIslem3.Size = new System.Drawing.Size(338, 61);
            this.btnSonIslem3.TabIndex = 2;
            this.btnSonIslem3.UseVisualStyleBackColor = true;
            // 
            // btnSonIslem2
            // 
            this.btnSonIslem2.Enabled = false;
            this.btnSonIslem2.Location = new System.Drawing.Point(2, 66);
            this.btnSonIslem2.Margin = new System.Windows.Forms.Padding(2);
            this.btnSonIslem2.Name = "btnSonIslem2";
            this.btnSonIslem2.Size = new System.Drawing.Size(338, 61);
            this.btnSonIslem2.TabIndex = 1;
            this.btnSonIslem2.UseVisualStyleBackColor = true;
            // 
            // btnSonIslem1
            // 
            this.btnSonIslem1.Enabled = false;
            this.btnSonIslem1.Location = new System.Drawing.Point(2, 0);
            this.btnSonIslem1.Margin = new System.Windows.Forms.Padding(2);
            this.btnSonIslem1.Name = "btnSonIslem1";
            this.btnSonIslem1.Size = new System.Drawing.Size(338, 61);
            this.btnSonIslem1.TabIndex = 0;
            this.btnSonIslem1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(17, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "Son İşlemler";
            // 
            // lblSonIslemlerTC
            // 
            this.lblSonIslemlerTC.AutoSize = true;
            this.lblSonIslemlerTC.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonIslemlerTC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblSonIslemlerTC.Location = new System.Drawing.Point(13, 41);
            this.lblSonIslemlerTC.Name = "lblSonIslemlerTC";
            this.lblSonIslemlerTC.Size = new System.Drawing.Size(31, 16);
            this.lblSonIslemlerTC.TabIndex = 4;
            this.lblSonIslemlerTC.Text = "TC : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(70, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(251, 36);
            this.label10.TabIndex = 5;
            this.label10.Text = "ZİRAAT BANKASI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(406, 508);
            this.Controls.Add(this.pnlSonIslemler);
            this.Controls.Add(this.pnlKiraOdeme);
            this.Controls.Add(this.pnlFaturaOdeme);
            this.Controls.Add(this.pnlGiris);
            this.Controls.Add(this.pnlParaTransferi);
            this.Controls.Add(this.pnlAnaSayfa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ziraat Bankası";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlAnaSayfa.ResumeLayout(false);
            this.pnlAnaSayfa.PerformLayout();
            this.pnlGiris.ResumeLayout(false);
            this.pnlGiris.PerformLayout();
            this.pnlParaTransferi.ResumeLayout(false);
            this.pnlParaTransferi.PerformLayout();
            this.pnlFaturaOdeme.ResumeLayout(false);
            this.pnlFaturaOdeme.PerformLayout();
            this.grpFaturalar.ResumeLayout(false);
            this.grpFaturalar.PerformLayout();
            this.pnlKiraOdeme.ResumeLayout(false);
            this.pnlKiraOdeme.PerformLayout();
            this.pnlSonIslemler.ResumeLayout(false);
            this.pnlSonIslemler.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Panel pnlAnaSayfa;
        private System.Windows.Forms.LinkLabel lnklabelSifremiUnuttum;
        private System.Windows.Forms.LinkLabel lnklabelHesapOlustur;
        private System.Windows.Forms.Label lblKurallar;
        private System.Windows.Forms.TextBox txtGuvenlikKelimesi;
        private System.Windows.Forms.Label lblGuvenlikKelimesi;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Panel pnlGiris;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.ComboBox comboOdemeler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSonIslemler;
        private System.Windows.Forms.Panel pnlParaTransferi;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.TextBox txtGonderilecekMiktar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAliciTCNO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTransferBakiye;
        private System.Windows.Forms.Label lblTransferTC;
        private System.Windows.Forms.Button btnTransferGeriDon;
        private System.Windows.Forms.Panel pnlFaturaOdeme;
        private System.Windows.Forms.Button btnFaturaGeriDon;
        private System.Windows.Forms.Label lblFaturaTC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpFaturalar;
        private System.Windows.Forms.RadioButton rbtnInternet;
        private System.Windows.Forms.RadioButton rbtnDogalgaz;
        private System.Windows.Forms.RadioButton rbtnSu;
        private System.Windows.Forms.RadioButton rbtnElektrik;
        private System.Windows.Forms.Label lblFaturaBedeli;
        private System.Windows.Forms.Button btnOde;
        private System.Windows.Forms.Label lblFaturaBakiye;
        private System.Windows.Forms.Panel pnlKiraOdeme;
        private System.Windows.Forms.Button btnKiraOde;
        private System.Windows.Forms.Label lblKiraBedeli;
        private System.Windows.Forms.Button btnKiraGeriDon;
        private System.Windows.Forms.Label lblKiraTC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblKiraBakiye;
        private System.Windows.Forms.Timer timerParaKontrol;
        private System.Windows.Forms.Panel pnlSonIslemler;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSonIslemlerTC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSonIslem4;
        private System.Windows.Forms.Button btnSonIslem3;
        private System.Windows.Forms.Button btnSonIslem2;
        private System.Windows.Forms.Button btnSonIslem1;
        private System.Windows.Forms.Button btnIleri;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label lblSayfa;
        private System.Windows.Forms.Button btnSonIslemlerGeriDon;
        private System.Windows.Forms.Button btnHesapCikis;
    }
}

