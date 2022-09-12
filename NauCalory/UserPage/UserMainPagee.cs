using Nau.Dal;
using Nau.Data.Entities;
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
    public partial class UserMainPagee : Form
    {
        public User user;
        UserMethod userMethod;
        MealMethod mealMethod;
        NauDbContext db = new NauDbContext();
        public UserMainPagee()
        {
            InitializeComponent();
            Sidepanel1.Height = btnAnaSayfa.Height;
            Sidepanel1.Top = btnAnaSayfa.Top;
        }
        public UserMainPagee(User _user)
        {
            InitializeComponent();
            user = _user;
        }

        private void UserMainPagee_Load(object sender, EventArgs e)
        {
            var kullanıcı = db.Users.Where(x => x.Name.Equals(lblName.Text)).FirstOrDefault();
            GetInfo();
        }
        public void GetInfo()
        {
            userMethod = new UserMethod();
            mealMethod = new MealMethod();
            if(user != null)
            {
                user = userMethod.GetUserById(user.UserID);

                lblName.Text = $"{user.Name} {user.LastName}";

                txtWeight.Text = user.Weight.ToString() + "kg";
                txtHeight.Text = user.Height.ToString() + "cm";
                lblBmi.Text = VkiHesapla(user).ToString();
                lblDurum.Text = EndeksDurumVer(VkiHesapla(user));

                if (user.Weight < user.KiloGoal)
                {
                    pbTargetTracking.Value = Convert.ToInt32(user.Weight);
                    pbTargetTracking.Maximum = Convert.ToInt32(user.KiloGoal);
                }
                else
                {
                    pbTargetTracking.Maximum = Convert.ToInt32(user.Weight);
                    pbTargetTracking.Value = Convert.ToInt32(user.KiloGoal);
                }

                DateTime today = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                List<Meal> bugununOgunleri = mealMethod.GetUserMeals(user.UserID, today, today.AddDays(1));
                int gunlukTuketilenKalori = bugununOgunleri.Sum(a => a.MealDetails.Sum(b => b.Calory));
                int gunlukStandartKalori = Convert.ToInt32(GunlukKaloriHesapla(user));
                lblAlinan.Text = gunlukTuketilenKalori.ToString() + " kcal";
                lblGunlukKalori.Text = GunlukKaloriHesapla(user).ToString();

                if (gunlukTuketilenKalori > gunlukStandartKalori)
                {
                    pbTargetCalory.Value = 100;
                    //lblHarcanan.Text = gunlukTuketilenKalori.ToString();
                }
                else
                {
                    pbTargetTracking.Maximum = gunlukStandartKalori;
                    pbTargetCalory.Value = gunlukTuketilenKalori;
                    //lblHarcanan.Text = (gunlukStandartKalori - gunlukTuketilenKalori).ToString();
                }
            }
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            Sidepanel1.Height = btnAnaSayfa.Height;
            Sidepanel1.Top = btnAnaSayfa.Top;
           
        }
        public double VkiHesapla(User user)
        {
           return Math.Round( (double)user.Weight / (user.Height / 100.0 * user.Height / 100.0),3);
        }

        private string EndeksDurumVer(double vki)
        {
            
            if (vki < 18.5) return "İdeal kilonun altında";
            else if (vki >= 18.5 && vki < 24.9) return "İdeal kiloda";
            else if (vki >= 25 && vki < 29.9) return "İdeal kilonun üstünde";
            else if (vki >= 30 && vki < 39.9) return "İdeal kilonun çok üstünde (Obez)";
            else return "İdeal kilonun çok üstünde (Morbid Obez)";
        }

        private int GunlukKaloriHesapla(User user)
        {
            double cal = 0;
            switch (user.Gender)
            {
                case Nau.Data.Enums.Gender.Erkek:
                    cal = (10 * user.Weight) + (6.25 * user.Height) - (5 * user.Age) + 5;
                    break;
                case Nau.Data.Enums.Gender.Kadın:
                    cal = (10 * user.Weight) + (6.25 * user.Height) - (5 * user.Age) - 161;
                    break;
            }

            switch (user.ActivityTypeID)
            {
                case 1:
                    cal = cal * 1.2;
                    break;
                case 2:
                    cal = cal * 1.375;
                    break;
                case 3:
                    cal = cal * 1.55;
                    break;
                case 4:
                    cal = cal * 1.725;
                    break;
            }

            return (int)Math.Round(cal);
        }

        public User GetUserById(int id)
        {
            return db.Users.SingleOrDefault(c => c.UserID == id);
        }

        private void btnUpdateInformation_Click(object sender, EventArgs e)
        {
            UpdateInfoPage updateInfoPage = new UpdateInfoPage(user);
            this.Hide();
            updateInfoPage.Show();
        }

        private void btnMyMeals_Click(object sender, EventArgs e)
        {
            MealPagee mp = new MealPagee(user.UserID);
            this.Hide();
            mp.Show();

        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            StaticstPage staticst = new StaticstPage(user.UserID);
            this.Show();
            staticst.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
