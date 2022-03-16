using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form1 : Form
    {

        List<Kullanici> Kullanici = new List<Kullanici>();
        Islem kullaniciIslem = new Islem();
        public Form1()
        {
            InitializeComponent();
        }

        Context context = new Context();
        int btnGirisKayitDurum = 1;
        int bakiye = 0;
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (btnGirisKayitDurum == 1)
            {
                context=new Context();
                var bilgi = (from i in context.Kullanicilar
                             where txtTC.Text == i.TC.ToString() && txtSifre.Text == i.SIFRE.ToString()
                             select i).ToList();
                if (bilgi.Count != 0)
                {
                    if (bilgi[0].isOnline)
                    {
                        MessageBox.Show("Hesap Zaten Aktif!", "Giriş Durum");
                    }
                    else
                    {
                        Kullanici = bilgi;
                        timerParaKontrol.Start();
                        pnlAnaSayfa.Visible = false;
                        pnlGiris.Visible = true;
                        lblTC.Text += bilgi[0].TC;
                        lblBakiye.Text += bilgi[0].BAKIYE + " TL ";
                        bakiye = bilgi[0].BAKIYE;
                        Kullanici[0].isOnline = true;
                        context.SaveChanges();
                        if (bilgi[0].SonHataTarihi.Length != 0)
                        {
                            MessageBox.Show(bilgi[0].SonHataTarihi.ToString(), "Son Hatalı Giriş Tarihi");
                            bilgi[0].SonHataTarihi = "";
                            context.SaveChanges();
                        }
                    }


                }
                else
                {
                    var bilgi2 = (from i in context.Kullanicilar
                                  where txtTC.Text == i.TC.ToString()
                                  select i).ToList();
                    if (bilgi2.Count != 0)
                    {
                        bilgi2[0].SonHataTarihi = DateTime.Now.ToString();
                        context.SaveChanges();
                    }
                    MessageBox.Show("Hatalı Bilgi");
                }
            }
            else if (btnGirisKayitDurum == 2)
            {
                if (txtTC.Text.Length == 11 && txtSifre.Text.Length == 6 && txtGuvenlikKelimesi.Text.Length > 0)
                {
                    Random rnd = new Random();
                    var tcKontrol = (from i in context.Kullanicilar
                                     where i.TC.ToString() == txtTC.Text
                                     select i).ToList();
                    if (tcKontrol.Count == 0)
                    {
                        Kullanici kullanici = new Kullanici();
                        kullanici.TC = long.Parse(txtTC.Text);
                        kullanici.SIFRE = int.Parse(txtSifre.Text);
                        kullanici.GUVENLIK_KELIMESI = txtGuvenlikKelimesi.Text;
                        kullanici.BAKIYE = rnd.Next(3000, 120000);
                        kullanici.SonHataTarihi = "";
                        kullanici.ElektrikFaturasi = rnd.Next(200, 1500);
                        kullanici.SuFaturasi = rnd.Next(100, 800);
                        kullanici.DogalgazFaturasi = rnd.Next(200, 1000);
                        kullanici.InternetFaturasi = rnd.Next(80, 300);
                        kullanici.KiraFaturasi = rnd.Next(1000, 4000);

                        context.Kullanicilar.Add(kullanici);
                        context.SaveChanges();
                        MessageBox.Show("Kaydınız Gerçekleşmiştir.");
                        DonAnaSayfa();
                    }
                    else
                    {
                        errorProvider1.Clear();
                        MessageBox.Show("Bu T.C. Kimlik Numarasına Ait Hesap Bulunmaktadır.");
                        txtTC.Clear();
                        txtSifre.Clear();
                        txtGuvenlikKelimesi.Clear();
                    }
                }
                else
                {
                    if (txtGuvenlikKelimesi.Text.Length == 0)
                    {
                        errorProvider1.SetError(txtGuvenlikKelimesi, "Güvenlik Kelimesi Boş Geçilemez.");
                    }
                    else
                    {
                        errorProvider1.Clear();
                        MessageBox.Show("Kayıt Kurallarına Uygun Değildir.");
                        txtTC.Clear();
                        txtSifre.Clear();
                        txtGuvenlikKelimesi.Clear();
                    }

                }
            }
            else if (btnGirisKayitDurum == 3)
            {
                
                var bilgi = (from i in context.Kullanicilar
                             where i.TC.ToString() == txtTC.Text && i.GUVENLIK_KELIMESI.ToString() == txtGuvenlikKelimesi.Text
                             select i).ToList();
                if (bilgi.Count == 0)
                {
                    MessageBox.Show("Bu Bilgilere Ait Kullanıcı Bulunmamaktadır.");
                    txtTC.Clear();
                    txtSifre.Clear();
                    txtGuvenlikKelimesi.Clear();
                }
                else if (txtSifre.Text.Length == 6 && bilgi.Count > 0)
                {
                    bilgi[0].SIFRE = int.Parse(txtSifre.Text);
                    context.SaveChanges();
                    errorProvider1.Clear();
                    MessageBox.Show("Şifreniz Başarıyla Değiştirildi.");
                    DonAnaSayfa();
                }
                else
                {
                    errorProvider1.SetError(txtSifre, "Yeni Şifreniz 6 Haneli Olmalıdır.");
                }
            }
        }

        private void lnklabelHesapOlustur_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnGirisKayitDurum = 2;
            btnGirisYap.Text = "Hesap Oluştur";
            lnklabelSifremiUnuttum.Visible = false;
            lnklabelHesapOlustur.Visible = false;
            lblKurallar.Visible = true;
            lblGuvenlikKelimesi.Visible = true;
            txtGuvenlikKelimesi.Visible = true;
            btnGeriDon.Visible = true;
            txtTC.Clear();
            txtSifre.Clear();
            txtGuvenlikKelimesi.Clear();
            errorProvider1.Clear();
        }

        ErrorProvider errorProvider1 = new ErrorProvider();
        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Back)
            {
                errorProvider1.Clear();
            }
            else if (e.Handled = !char.IsDigit(e.KeyChar))
            {
                errorProvider1.SetError(txtTC, "Sadece Rakam İçermelidir.");
            }
            else if (txtTC.Text.Length == 11)
            {
                if (e.Handled = char.IsDigit(e.KeyChar))
                {
                    errorProvider1.SetError(txtTC, "T.C. Kimlik Numaranız 11 Haneden Oluşmalıdır.");
                }
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                errorProvider1.Clear();
            }
            else if (e.Handled = !char.IsDigit(e.KeyChar))
            {
                errorProvider1.SetError(txtSifre, "Sadece Rakam İçermelidir.");
            }
            else if (txtSifre.Text.Length == 6)
            {
                if (e.Handled = char.IsDigit(e.KeyChar))
                {
                    errorProvider1.SetError(txtSifre, "Şifreniz 6 Haneden Oluşmalıdır.");
                }
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void lnklabelSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            lnklabelSifremiUnuttum.Visible = false;
            lnklabelHesapOlustur.Visible = false;
            txtGuvenlikKelimesi.Visible = true;
            lblGuvenlikKelimesi.Visible = true;
            txtGuvenlikKelimesi.Focus();
            btnGeriDon.Visible = true;
            lblSifre.Text = "YENİ ŞİFRE";
            btnGirisYap.Text = "ONAYLA";
            txtTC.Text = "";
            txtSifre.Text = "";
            btnGirisKayitDurum = 3;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var bilgi = (from i in context.Kullanicilar where i.id == 1 select i).ToList();
            bilgi.Clear();
        }

        private void DonAnaSayfa()
        {
            txtTC.Clear();
            txtSifre.Clear();
            txtGuvenlikKelimesi.Clear();
            lblGuvenlikKelimesi.Visible = false;
            txtGuvenlikKelimesi.Visible = false;
            lnklabelSifremiUnuttum.Visible = true;
            lnklabelHesapOlustur.Visible = true;
            lblKurallar.Visible = false;
            btnGeriDon.Visible = false;
            lblSifre.Text = "ŞİFRE";
            btnGirisYap.Text = "GİRİŞ YAP";
            btnGirisKayitDurum = 1;
        }
        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            DonAnaSayfa();
        }


        private void comboOdemeler_TextChanged(object sender, EventArgs e)
        {
            if (comboOdemeler.Text == "Para Transferi")
            {
                txtAliciTCNO.Text = "";
                txtGonderilecekMiktar.Text = "0";
                lblTransferTC.Text = lblTC.Text;
                lblTransferBakiye.Text = "Bakiye : " + Kullanici[0].BAKIYE + " TL ";
                pnlGiris.Visible = false;
                pnlParaTransferi.Visible = true;
            }
            else if (comboOdemeler.Text == "Fatura Ödeme")
            {
                lblFaturaBedeli.Text = "Fatura Bedeli : 0 TL";
                lblFaturaBakiye.Text = "Bakiye : " + Kullanici[0].BAKIYE + " TL ";
                foreach (RadioButton item in grpFaturalar.Controls)
                {
                    item.Checked = false;
                }
                lblFaturaTC.Text = lblTC.Text;
                pnlGiris.Visible = false;
                pnlFaturaOdeme.Visible = true;
            }
            else if (comboOdemeler.Text == "Kira Ödeme")
            {
                lblKiraBedeli.Text = "Kira Bedeli : " + Kullanici[0].KiraFaturasi + " TL ";
                lblKiraBakiye.Text = "Bakiye : " + Kullanici[0].BAKIYE + " TL ";
                lblKiraTC.Text = lblTC.Text;
                pnlGiris.Visible = false;
                pnlKiraOdeme.Visible = true;

            }
        }


        private void btnGonder_Click(object sender, EventArgs e)
        {
            var alici = (from i in context.Kullanicilar
                         where i.TC.ToString() == txtAliciTCNO.Text
                         select i).ToList();
            if (alici.Count != 0)
            {
                if (alici[0].TC == Kullanici[0].TC)
                {
                    MessageBox.Show("Kendinize Para Gönderemezsiniz.", "Transfer Durum");
                }
                else if (txtGonderilecekMiktar.Text == "" || int.Parse(txtGonderilecekMiktar.Text) == 0)
                {
                    MessageBox.Show("Gönderilecek Miktarı Giriniz.", "Transfer Durum");
                }
                else if (Kullanici[0].BAKIYE < int.Parse(txtGonderilecekMiktar.Text))
                {
                    MessageBox.Show("Bakiyenizden Yüksek Miktarda Para Transferi Yapamazsınız.", "Transfer Durum");
                }
                else if (Kullanici[0].BAKIYE >= int.Parse(txtGonderilecekMiktar.Text))
                {

                    //VeriTabanindaki Değişiklikler
                    Kullanici[0].BAKIYE -= Convert.ToInt32(txtGonderilecekMiktar.Text);
                    alici[0].BAKIYE += Convert.ToInt32(txtGonderilecekMiktar.Text);
                    bakiye = Kullanici[0].BAKIYE;

                    //Islem kullaniciIslem = new Islem();
                    kullaniciIslem.ISLEM = alici[0].TC + " NO'lu Hesaba " + Convert.ToInt32(txtGonderilecekMiktar.Text) + " TL Gönderildi.";
                    kullaniciIslem.ISLEM_TARIHI = DateTime.Now.ToString();
                    kullaniciIslem.TC = Kullanici[0].TC;

                    context.Islemler.Add(kullaniciIslem);

                    Islem aliciIslem = new Islem();
                    aliciIslem.ISLEM = Kullanici[0].TC + " NO'lu Hesaptan " + Convert.ToInt32(txtGonderilecekMiktar.Text) + " TL Hesabınıza Yatırıldı.";
                    aliciIslem.ISLEM_TARIHI = DateTime.Now.ToString();
                    aliciIslem.TC = alici[0].TC;
                    aliciIslem.GonderenTC = kullaniciIslem.TC;
                    aliciIslem.GonderimTuru = true;

                    context.Islemler.Add(aliciIslem);

                    context.SaveChanges();

                    //Paneldeki Değişiklikler
                    lblBakiye.Text = "Bakiye : ";
                    lblBakiye.Text += (Kullanici[0].BAKIYE + " TL");
                    txtAliciTCNO.Text = "";
                    txtGonderilecekMiktar.Text = "";
                    lblTransferBakiye.Text = lblBakiye.Text;

                    MessageBox.Show("Para Transferi Başarıyla Gerçekleşti.", "Transfer Durum");
                }



            }
            else if (txtAliciTCNO.Text == "")
            {
                MessageBox.Show("Alici T.C. No'su Boş Bırakılamaz.", "Transfer Durum");
            }
            else
            {
                MessageBox.Show("Bu T.C. No'suna Ait Hesap Bulunmamaktadır.", "Transfer Durum");
            }
        }

        private void txtAliciTCNO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                errorProvider1.Clear();
            }
            else if (e.Handled = !char.IsDigit(e.KeyChar))
            {
                errorProvider1.SetError(txtAliciTCNO, "Sadece Rakam İçermelidir.");
            }
            else if (txtAliciTCNO.Text.Length == 11)
            {
                if (e.Handled = char.IsDigit(e.KeyChar))
                {
                    errorProvider1.SetError(txtAliciTCNO, "T.C. Kimlik Numaranız 11 Haneden Oluşmalıdır.");
                }
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtGonderilecekMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Back)
            {
                errorProvider1.Clear();
            }
            else if (e.Handled = !char.IsDigit(e.KeyChar))
            {
                errorProvider1.SetError(txtGonderilecekMiktar, "Sadece Rakam İçermelidir.");
            }
            else if (txtGonderilecekMiktar.Text.Length > 6)
            {
                if (e.Handled = char.IsDigit(e.KeyChar))
                {
                    errorProvider1.SetError(txtGonderilecekMiktar, "Gönderilecek Miktar En Fazla 6 Haneden Oluşmalıdır.");
                }
            }

            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnTransferGeriDon_Click(object sender, EventArgs e)
        {
            pnlParaTransferi.Visible = false;
            pnlGiris.Visible = true;
            comboOdemeler.SelectedItem = null;
        }

        private void btnFaturaGeriDon_Click(object sender, EventArgs e)
        {
            rbtnElektrik.Checked = false;
            rbtnSu.Checked = false;
            rbtnDogalgaz.Checked = false;
            rbtnInternet.Checked = false;
            pnlFaturaOdeme.Visible = false;
            pnlGiris.Visible = true;
            comboOdemeler.SelectedItem = null;
            faturaSecim = false;
            faturaBedeli = 0;
            lblFaturaBedeli.Text = "Fatura Bedeli : 0 TL";
        }

        bool faturaSecim = false;
        int faturaBedeli = 0;
        private void rbtnElektrik_CheckedChanged(object sender, EventArgs e)
        {
            lblFaturaBedeli.Text = "Fatura Bedeli : " + Kullanici[0].ElektrikFaturasi + " TL";
            faturaBedeli = Kullanici[0].ElektrikFaturasi;
            faturaSecim = true;
        }

        private void rbtnSu_CheckedChanged(object sender, EventArgs e)
        {
            lblFaturaBedeli.Text = "Fatura Bedeli : " + Kullanici[0].SuFaturasi + " TL";
            faturaBedeli = Kullanici[0].SuFaturasi;
            faturaSecim = true;
        }

        private void rbtnDogalgaz_CheckedChanged(object sender, EventArgs e)
        {
            lblFaturaBedeli.Text = "Fatura Bedeli : " + Kullanici[0].DogalgazFaturasi + " TL";
            faturaBedeli = Kullanici[0].DogalgazFaturasi;
            faturaSecim = true;
        }

        private void rbtnInternet_CheckedChanged(object sender, EventArgs e)
        {
            lblFaturaBedeli.Text = "Fatura Bedeli : " + Kullanici[0].InternetFaturasi + " TL";
            faturaBedeli = Kullanici[0].InternetFaturasi;
            faturaSecim = true;
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            if (faturaSecim == false)
            {
                MessageBox.Show("Ödenecek Faturayı Seçiniz.", "Fatura Durum");
            }
            else if (faturaBedeli == 0)
            {
                MessageBox.Show("Faturanız Zaten Ödenmiştir.", "Fatura Durum");
            }
            else if (Kullanici[0].BAKIYE < faturaBedeli)
            {
                MessageBox.Show("Faturayı Ödemek İçin Yeterli Bakiyeniz Bulunmamaktadır.", "Fatura Durum");
            }
            else
            {
                //Islem kullaniciIslem = new Islem();

                //VeriTabanindaki Değişiklikler
                Kullanici[0].BAKIYE -= faturaBedeli;
                bakiye = Kullanici[0].BAKIYE;
                if (rbtnElektrik.Checked)
                {
                    kullaniciIslem.ISLEM = faturaBedeli + " TL'lik Elektrik Faturası Ödendi.";
                    Kullanici[0].ElektrikFaturasi = 0;
                }
                else if (rbtnSu.Checked)
                {
                    kullaniciIslem.ISLEM = faturaBedeli + " TL'lik Su Faturası Ödendi.";
                    Kullanici[0].SuFaturasi = 0;
                }
                else if (rbtnDogalgaz.Checked)
                {
                    kullaniciIslem.ISLEM = faturaBedeli + " TL'lik Doğalgaz Faturası Ödendi.";
                    Kullanici[0].DogalgazFaturasi = 0;
                }
                else if (rbtnInternet.Checked)
                {
                    kullaniciIslem.ISLEM = faturaBedeli + " TL'lik İnternet Faturası Ödendi.";
                    Kullanici[0].InternetFaturasi = 0;
                }
                kullaniciIslem.ISLEM_TARIHI = DateTime.Now.ToString();
                kullaniciIslem.TC = Kullanici[0].TC;
                context.Islemler.Add(kullaniciIslem);
                context.SaveChanges();

                //Paneldeki Değişiklikler
                lblFaturaBedeli.Text = "Fatura Bedeli : 0 TL";
                lblBakiye.Text = "Bakiye : " + Kullanici[0].BAKIYE + " TL";
                lblFaturaBakiye.Text = lblBakiye.Text;
                comboOdemeler.SelectedItem = null;
                faturaSecim = false;
                MessageBox.Show("Faturanız Başarıyla Ödenmiştir.", "Fatura Durum");
            }
        }

        private void btnKiraOde_Click(object sender, EventArgs e)
        {
            if (Kullanici[0].BAKIYE < Kullanici[0].KiraFaturasi)
            {
                MessageBox.Show("Kira Faturasını Ödemek İçin Yeterli Bakiyeniz Bulunmamaktadır.", "Kira Durum");
            }
            else if (Kullanici[0].KiraFaturasi == 0)
            {
                MessageBox.Show("Kira Faturanız Zaten Ödenmiştir.", "Kira Durum");
            }
            else if (Kullanici[0].BAKIYE >= Kullanici[0].KiraFaturasi)
            {
                //VeriTabanindaki Değişiklikler
                Kullanici[0].BAKIYE -= Kullanici[0].KiraFaturasi;
                bakiye = Kullanici[0].BAKIYE;
                kullaniciIslem.ISLEM = Kullanici[0].KiraFaturasi + " TL Tutarındaki Kira Faturası Ödendi.";
                kullaniciIslem.ISLEM_TARIHI = DateTime.Now.ToString();
                kullaniciIslem.TC = Kullanici[0].TC;
                Kullanici[0].KiraFaturasi = 0;
                context.Islemler.Add(kullaniciIslem);
                context.SaveChanges();

                //Paneldeki Değişiklikler
                lblKiraBedeli.Text = "Kira Bedeli : 0 TL";
                lblBakiye.Text = "Bakiye : " + Kullanici[0].BAKIYE + " TL ";
                lblKiraBakiye.Text = lblBakiye.Text;

                MessageBox.Show("Kira Faturanız Başarıyla Ödenmiştir.", "Kira Durum");
            }
        }

        private void btnKiraGeriDon_Click(object sender, EventArgs e)
        {
            pnlKiraOdeme.Visible = false;
            pnlGiris.Visible = true;
            comboOdemeler.SelectedItem = null;
        }

        private void timerParaKontrol_Tick(object sender, EventArgs e)
        {
            long tc = Kullanici[0].TC;
            Context context2 = new Context();
            var kullanıcı = (from i in context2.Kullanicilar where i.TC == tc select i).ToList();
            if (kullanıcı[0].BAKIYE != bakiye)
            {

                var sonIslem = (from i in context2.Islemler
                                where i.TC == tc && i.GonderimTuru
                                select i).Take(1).ToList();
                lblBakiye.Text = "Bakiye : " + kullanıcı[0].BAKIYE + " TL ";
                lblTransferBakiye.Text = lblBakiye.Text;
                lblFaturaBakiye.Text = lblBakiye.Text;
                lblKiraBakiye.Text = lblBakiye.Text;
                int fark = (kullanıcı[0].BAKIYE - bakiye);
                bakiye = kullanıcı[0].BAKIYE;
                MessageBox.Show(sonIslem[0].GonderenTC + " NO'lu Hesaptan Hesabınıza " + fark + " TL Yatırıldı.", "Transfer Durum");


            }
        }
        Button[] islemler = new Button[4];

        double sayfaSayisi;
        private void btnSonIslemler_Click(object sender, EventArgs e)
        {
            btnIleri.Enabled = false;
            btnGeri.Enabled = false;

            islemler[0] = btnSonIslem1;
            islemler[1] = btnSonIslem2;
            islemler[2] = btnSonIslem3;
            islemler[3] = btnSonIslem4;
            for (int i = 0; i < 4; i++)
            {
                islemler[i].Text = "";
            }
            pnlGiris.Visible = false;
            pnlSonIslemler.Visible = true;
            lblSonIslemlerTC.Text = lblTC.Text;
            long tc = Kullanici[0].TC;
            int max;
            var sonIslemler = (from i in context.Islemler where i.TC == tc select i).ToList();
            sonIslemler.Reverse();
            sayfaSayisi = Math.Ceiling(sonIslemler.Count / 4.0f);

            if (sonIslemler.Count == 4)
            {
                max = 4;
                btnIleri.Enabled = false;
                btnGeri.Enabled = false;
            }
            else if (sonIslemler.Count > 4)
            {
                max = 4;
                btnIleri.Enabled = true;

            }
            else
            {
                max = sonIslemler.Count;
                btnIleri.Enabled = false;
                btnGeri.Enabled = false;
            }
            for (int i = 0; i < max; i++)
            {
                islemler[i].Text = sonIslemler[i].ISLEM_TARIHI + "\n" + sonIslemler[i].ISLEM;
            }

        }

        private void scrollSonIslemler_Scroll(object sender, ScrollEventArgs e)
        {

        }
        double bulundugumuzSayfa = 1;
        private void btnIleri_Click(object sender, EventArgs e)
        {
            int max;
            btnGeri.Enabled = true;

            long tc = Kullanici[0].TC;
            if (sayfaSayisi > bulundugumuzSayfa)
            {

                bulundugumuzSayfa++;
                int bakilanIslemler = ((int)bulundugumuzSayfa - 1) * 4;
                var sonIslemler = (from i in context.Islemler orderby i.ISLEM_TARIHI descending where i.TC == tc select i).Skip(bakilanIslemler).ToList();


                if (sonIslemler.Count == 4)
                {
                    max = 4;
                }
                else if (sonIslemler.Count > 4)
                {
                    max = 4;
                }
                else
                {
                    max = sonIslemler.Count;
                }
                for (int i = 0; i < 4; i++)
                {
                    islemler[i].Text = "";
                }
                for (int i = 0; i < max; i++)
                {
                    islemler[i].Text = sonIslemler[i].ISLEM_TARIHI + "\n" + sonIslemler[i].ISLEM;
                }
                lblSayfa.Text = bulundugumuzSayfa.ToString();
                if (bulundugumuzSayfa == sayfaSayisi)
                {
                    btnIleri.Enabled = false;
                }
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            int max;
            btnIleri.Enabled = true;
            long tc = Kullanici[0].TC;
            if (1 < bulundugumuzSayfa)
            {

                bulundugumuzSayfa--;
                int bakilanIslemler = ((int)bulundugumuzSayfa - 1) * 4;
                var sonIslemler = (from i in context.Islemler orderby i.ISLEM_TARIHI descending where i.TC == tc select i).Skip(bakilanIslemler).ToList();


                if (sonIslemler.Count == 4)
                {
                    max = 4;
                }
                else if (sonIslemler.Count > 4)
                {
                    max = 4;
                }
                else
                {
                    max = sonIslemler.Count;
                }
                for (int i = 0; i < 4; i++)
                {
                    islemler[i].Text = "";
                }
                for (int i = 0; i < max; i++)
                {
                    islemler[i].Text = sonIslemler[i].ISLEM_TARIHI + "\n" + sonIslemler[i].ISLEM;
                }
                lblSayfa.Text = bulundugumuzSayfa.ToString();
                if (bulundugumuzSayfa == 1)
                {
                    btnGeri.Enabled = false;
                }
            }
        }

        private void btnSonIslemlerGeriDon_Click(object sender, EventArgs e)
        {
            pnlSonIslemler.Visible = false;
            pnlGiris.Visible = true;
            lblSayfa.Text = "1";
            bulundugumuzSayfa = 1;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Kullanici[0].isOnline = false;
            context.SaveChanges();
        }

        private void btnHesapCikis_Click(object sender, EventArgs e)
        {
            Kullanici[0].isOnline = false;
            context.SaveChanges();
            pnlGiris.Visible = false;
            pnlAnaSayfa.Visible = true;

            txtTC.Text = "";
            txtSifre.Text = "";
            lblTC.Text = "TC : ";
            lblBakiye.Text = "Bakiye : ";

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Kullanici.Count!=0)
            {
                Kullanici[0].isOnline = false;
                context.SaveChanges();
            }
            
            
        }
    }
}
