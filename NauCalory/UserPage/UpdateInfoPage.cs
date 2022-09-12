using Nau.Data.Entities;
using Nau.Data.Enums;
using Nau.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NauCalory.UserPage
{
    public partial class UpdateInfoPage : Form
    {
        User user;
        UserMethod userMethod;
        ActivityTypeMethod activityTypeMethod;
        public UpdateInfoPage(User _user)
        {
            InitializeComponent();
            user = _user;
        }
     
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                userMethod = new UserMethod();

                user = userMethod.GetUserById(user.UserID);
                user.UserName = txtMail.Text;
                user.Name = txtName.Text;
                user.LastName = txtLastName.Text;
                user.Gender = (Gender)cmbGender.SelectedItem;
                user.BirthDate = dtBirthDate.Value;
                user.Height = (int)nmSize.Value;
                user.Weight = (int)nmWeight.Value;
                user.KiloGoal = (int)nmTargetWeight.Value;
                user.UserType = UserType.Kullanici;
                user.ActivityTypeID = (int)cmbActivite.SelectedValue;

                bool updateUser = userMethod.Update(user);
                if (updateUser) MessageBox.Show("Kullanıcı bilgileri güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPasswordUpdate_Click(object sender, EventArgs e)
        {
            if (user.Password != txtPassword.Text)
            {
                MessageBox.Show("Eski parolanız doğru değil", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!CheckPasswords())
            {
                MessageBox.Show("Girdiğiniz parolalar uyuşmuyor.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                user = userMethod.GetUserById(user.UserID);
                user.Password = txtNewPassword.Text;

                bool updateUser = userMethod.Update(user);
                if (updateUser) MessageBox.Show("Şifre güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void FillActivities()
        {
            activityTypeMethod = new ActivityTypeMethod();
            cmbActivite.DataSource = activityTypeMethod.GetActivities();
            cmbActivite.DisplayMember = "ActivityName";
            cmbActivite.ValueMember = "ActivityTypeID";

            cmbActivite.SelectedIndex = 0;
        }

        void FillGender()
        {
            foreach (var item in Enum.GetValues(typeof(Gender)))
            {
                cmbGender.Items.Add(item);
            }
        }

        void FillUserInfo()
        {
            if(user != null)
            {
                user = userMethod.GetUserById(user.UserID);
                txtName.Text = user.Name;
                txtLastName.Text = user.LastName;
                txtMail.Text = user.UserName;
                cmbGender.Text = user.Gender.ToString();
                cmbActivite.SelectedValue = user.ActivityTypeID;
                dtBirthDate.Value = user.BirthDate;
                nmSize.Value = user.Height;
                nmWeight.Value = user.Weight;
                nmTargetWeight.Value = (int)user.KiloGoal;
            }
            
        }
        bool CheckPasswords()
        {
            if (txtNewPassword.Text != txtNewPasswordRp.Text) return false;
            else return true;
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            string aciklama = "Aktivite Yok : Gün içinde fiziksel aktivitesi minimum düzeyde olan kişiler. Örneğin; Masabaşı iş, Araba sürmek vb.\n\n" +
               "Az Aktif : Gün içinde zaman zaman ayakta durmayı gerektiren bir işte çalışan ya da çok az derecede hafif egzersiz yapan kişiler.\n\n" +
               "Aktif : Gün içerisinde işi gereği sürekli ayakta çalışan, fiziksel olarak emek harcayan ya da düzenli egzersiz yapan kişiler.\n\n" +
               "Çok Aktif : Düzenli olarak ağır egzersizler yapan ya da tamamen fiziki güce dayalı bir işte çalışan kişiler. Örneğin; inşaat işçisi, profesyonel sporcu vb.\n\n\n";
            MessageBox.Show(aciklama, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateInfoPage_Load(object sender, EventArgs e)
        {
            activityTypeMethod = new ActivityTypeMethod();
            userMethod = new UserMethod();
            FillActivities();
            FillGender();
            FillUserInfo();
        }

        private void btnBackMeal_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserMainPagee userMainPagee = new UserMainPagee();
            userMainPagee.user = user;
            userMainPagee.Show();
        }
    }
}
