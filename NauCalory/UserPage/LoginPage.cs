using Nau.Dal;
using Nau.Data.Entities;
using Nau.Data.Enums;
using Nau.Model;
using NauCalory.UserPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NauCalory
{
    public partial class LoginPage : Form
    {
        
        User user;
        public LoginPage()
        {
            InitializeComponent();
            foreach (var item in Enum.GetValues(typeof(Gender)))
            {
                cmbGender.Items.Add(item);
            }
            btnRegister.Text = "Kayıt Ol";
        }
        public LoginPage(User _user)
        {
            InitializeComponent();
            this.user = _user;
            user.UserName = txtMail.Text;
            user.Name = txtName.Text;
            user.LastName = txtLastName.Text;
            user.Password = txtPassword.Text;
            user.Gender = (Gender)cmbGender.SelectedItem;
            user.BirthDate = dtBirthDate.Value;
            user.Height = (int)nmHeight.Value;
            user.Weight = (int)nmWeight.Value;
            btnRegister.Text = "Güncelle";
            this.Text = "Bilgi Güncelle";
        }
      
        private void btnGirişYap_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }


        NauDbContext db = new NauDbContext();
        UserMethod userMethod;
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                userMethod = new UserMethod();
                user = new User();
                user.UserName = txtMail.Text;
                user.Name = txtName.Text;
                user.LastName = txtLastName.Text;
                user.Password = txtPasword.Text;
                user.Gender = (Gender)cmbGender.SelectedItem;
                user.BirthDate = dtBirthDate.Value;
                user.Height = (int)nmHeight.Value;
                user.Weight = (int)nmWeight.Value;
                user.KiloGoal = (int)nmTargetWeight.Value;
                user.UserType = UserType.Kullanici;
                user.ActivityTypeID = (int)cmbActivite.SelectedValue;
                if (CheckPassword(txtPasword.Text))
                {                   
                    bool updateUser = userMethod.Insert(user);
                    MessageBox.Show("Kaydınız başarıyla oluşturulmuştur.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool CheckPassword(string password)
        {
            bool isCharUpper = false;
            bool isCharLower = false;
            bool isNumber = false;
            bool isPasswordLength = false;
            if (password.Length >= 8)
            {
                isPasswordLength = true;
            }
            foreach (char item in password)
            {
                if (char.IsUpper(item))
                {
                    isCharUpper = true;
                }
                else if (char.IsLower(item))
                {
                    isCharLower = true;
                }
                else if (char.IsDigit(item))
                {
                    isNumber = true;
                }
            }

            if (!isCharUpper || !isCharLower || !isNumber || !isPasswordLength)
            {
                MessageBox.Show("Şifreniz En Az 8 Karakter İçermeli İçerisinde Büyük-Küçük Harf Ve Sayı Olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        void FillActivities()
        {
            ActivityType act = new ActivityType();
            cmbActivite.DataSource = db.ActivityTypes.ToList();
            cmbActivite.DisplayMember = "ActivityName";
            cmbActivite.ValueMember = "ActivityTypeID";
            cmbActivite.SelectedIndex = 0;
        }

        private void chbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPassword.Checked)
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '*';
        }

        private void btnInformation_Click_1(object sender, EventArgs e)
        {
            string aciklama = "Aktivite Yok : Gün içinde fiziksel aktivitesi minimum düzeyde olan kişiler. Örneğin; masabaşı iş, araba sürmek vb.\n\n" +
               "Az Aktif : Gün içinde zaman zaman ayakta durmayı gerektiren bir işte çalışan ya da çok az derecede hafif egzersiz yapan kişiler.\n\n" +
               "Aktif : Gün içerisinde işi gereği sürekli ayakta çalışan, fiziksel olarak emek harcayan ya da düzenli egzersiz yapan kişiler.\n\n" +
               "Çok Aktif : Düzenli olarak ağır egzersizler yapan ya da tamamen fiziki güce dayalı bir işte çalışan kişiler. Örneğin; inşaat işçisi, profesyonel sporcu vb.\n\n\n";
            MessageBox.Show(aciklama, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            FillActivities();
            dtBirthDate.MinDate = new DateTime(1962, 12, 31);
            dtBirthDate.MaxDate = new DateTime(2004, 01, 01);
        }

        UserMethod userMethodd;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Lütfen bütün alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string userName = txtUser.Text;
            string password = txtPassword.Text;

            userMethodd = new UserMethod();
            User user = userMethodd.CheckLogin(userName, password);

            try
            {
                if (user != null)
                {

                    switch (user.UserType)
                    {
                        case UserType.Admin:
                            AdminPage ad = new AdminPage(user.UserID);
                            this.Hide();
                            ad.ShowDialog();
                            break;
                        case UserType.Kullanici:
                            UserMainPagee usm = new UserMainPagee(user);
                            this.Hide();
                            usm.ShowDialog();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen doğru bilgileri giriniz. Eğer üye değilseniz kayıt olunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
