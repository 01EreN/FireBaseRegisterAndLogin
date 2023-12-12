using System;
using System.Windows.Forms;
using FirebaseAdmin.Auth;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using FireSharp;
using FirebaseAdmin;

namespace OyunDeneme1
{
    public partial class Kayit_Form1 : Form
    {

        

        IFirebaseConfig config = new FirebaseConfig
        {
            // Firebase projesinin url adresi
            BasePath = "",
            // Firebase setting sayfasindan aldigimiz secret key
            AuthSecret = ""
        };
        // Firebase client
        IFirebaseClient client;


        public Kayit_Form1()
        {
            InitializeComponent();
            

        }

        private async void Kayit_button1_Click(object sender, EventArgs e)
        {
            //bağlantı client değişkenine atıyoruz 
           //We assign it to the connection client variable
            client = new FireSharp.FirebaseClient(config);
            try
            {
                User user = new User()
                {
                    // class tanımlaması yapıyoruz 
                    // class  defining 
                    Ad = Ad_textBox1.Text,
                    Soyad = Soyad_textBox2.Text,
                    Kullanici_Adi = Kullanici_adi_textBox3.Text,
                    Sifre = Sifre_textBox4.Text
                };

                if (!string.IsNullOrEmpty(user.Ad) && !string.IsNullOrEmpty(user.Soyad) &&
                    !string.IsNullOrEmpty(user.Kullanici_Adi) && !string.IsNullOrEmpty(user.Sifre))
                {
                    // Tablo adı ve kullanıcı için belirleyeceğiniz id veya key (primary key) atıyoruz
                    string firebasePath = "Users/" + user.Kullanici_Adi; // This assumes using the username as the key

                    FirebaseResponse getResponse = await client.GetAsync(firebasePath);
                    if (getResponse == null || getResponse.Body == "null")
                    {
                        // user classı ve firebasepath değişkenlerini gönderiyoruz 
                        // We send the user class and firebasepath variables
                        SetResponse setResponse = await client.SetAsync(firebasePath, user);
                        MessageBox.Show("Kayıt başarılı!");
                    }
                    else
                    {
                        MessageBox.Show("Bu kullanıcı adı zaten var.");
                    }
                }
                else
                {
                    MessageBox.Show("Tüm alanlar doldurulmalıdır.");
                }
            }
            catch (FirebaseException ex)
            {
                MessageBox.Show("Kayıt sırasında hata oluştu: " + ex.Message);
            }
        }

        private void Giris_button2_Click(object sender, EventArgs e)
        {
            Giris_From2 Giris_From2 = new Giris_From2();
            Giris_From2.Show();
            this.Hide();
        }
    }
}