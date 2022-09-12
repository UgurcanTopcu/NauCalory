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
    public partial class StaticstPage : Form
    {
        int userid;
        MealMethod mealMethod;
        CategoryMethod categoryMethod;
        MealTypeMethod mealTypeMethod;
        NauDbContext db = new NauDbContext();
        public StaticstPage(int _userId)
        {
            InitializeComponent();
            userid = _userId;
            mealMethod = new MealMethod();
            categoryMethod = new CategoryMethod();
            mealTypeMethod = new MealTypeMethod();
            Get7DayAverageCalories();
            Get1MonthAverageCalories();
            GetByCategoriesCal();
        }
        private void Get7DayAverageCalories()
        {
            DateTime bitis = DateTime.Now;
            DateTime baslangic = bitis.AddDays(-7);

            List<Meal> allMeals = mealMethod.GetUserMeals(userid, baslangic, bitis);

            double kahvalti = allMeals.Where(x => x.MealTypeID == 1).ToList().Sum(y => y.MealDetails.Sum(z => z.Calory));
            double ogleYemegi = allMeals.Where(x => x.MealTypeID == 2).ToList().Sum(y => y.MealDetails.Sum(z => z.Calory));
            double aksamYemegi = allMeals.Where(x => x.MealTypeID == 3).ToList().Sum(y => y.MealDetails.Sum(z => z.Calory));
            double araOgun = allMeals.Where(x => x.MealTypeID == 4).ToList().Sum(y => y.MealDetails.Sum(z => z.Calory));

            lblBreakfast.Text = kahvalti.ToString() + " kcal";
            lblLunch.Text = ogleYemegi.ToString() + " kcal";
            lblDinner.Text = aksamYemegi.ToString() + " kcal";
            lblSnack.Text = araOgun.ToString() + " kcal";
        }

        private void Get1MonthAverageCalories()
        {
            DateTime bitis = DateTime.Now;
            DateTime baslangic = bitis.AddMonths(-1);

            List<Meal> allMeals = mealMethod.GetUserMeals(userid, baslangic, bitis);

            double kahvalti = allMeals.Where(x => x.MealTypeID == 1).ToList().Sum(y => y.MealDetails.Sum(z => z.Calory));
            double ogleYemegi = allMeals.Where(x => x.MealTypeID == 2).ToList().Sum(y => y.MealDetails.Sum(z => z.Calory));
            double aksamYemegi = allMeals.Where(x => x.MealTypeID == 3).ToList().Sum(y => y.MealDetails.Sum(z => z.Calory));
            double araOgun = allMeals.Where(x => x.MealTypeID == 4).ToList().Sum(y => y.MealDetails.Sum(z => z.Calory));

            lblBreakFastMonth.Text = kahvalti.ToString() + " kcal";
            lblLunchMonth.Text = ogleYemegi.ToString() + " kcal";
            lblDinnerMonth.Text = aksamYemegi.ToString() + " kcal";
            lblSnack.Text = araOgun.ToString() + " kcal";
        }
        private void GetByCategoriesCal()
        {
            List<Category> categories = categoryMethod.GetAll();
            List<Meal> allMeals = mealMethod.GetUserMeals(userid);

            foreach (Category item in categories)
            {
                ListViewItem lvi = new ListViewItem(item.Name);
                lvi.SubItems.Add(allMeals.Where(a => a.MealTypeID == 1 && a.MealDetails.All(b => b.Food.CategoryID == item.CategoryID)).ToList().Sum(c => c.MealDetails.Sum(f => f.Calory)).ToString());
                lvi.SubItems.Add(allMeals.Where(a => a.MealTypeID == 4 && a.MealDetails.All(b => b.Food.CategoryID == item.CategoryID)).ToList().Sum(c => c.MealDetails.Sum(f => f.Calory)).ToString());
                lvi.SubItems.Add(allMeals.Where(a => a.MealTypeID == 2 && a.MealDetails.All(b => b.Food.CategoryID == item.CategoryID)).ToList().Sum(c => c.MealDetails.Sum(f => f.Calory)).ToString());
                lvi.SubItems.Add(allMeals.Where(a => a.MealTypeID == 3 && a.MealDetails.All(b => b.Food.CategoryID == item.CategoryID)).ToList().Sum(c => c.MealDetails.Sum(f => f.Calory)).ToString());

                lvCategory.Items.Add(lvi);
            }
        }
        Food secilenFood;
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ChooseFoodPage cfp = new ChooseFoodPage(userid);
            cfp.ShowDialog();
            secilenFood = cfp.selectedFood;

            if (secilenFood != null)
            {
                txtFoodName.Text = secilenFood.Name;

                List<Meal> allMeals = mealMethod.GetUserMeals(userid);
                List<MealType> mealTypes = mealTypeMethod.GetAllTypes();


                int kahvaltiAdet = allMeals.Where(a => a.MealTypeID == 1 && a.MealDetails.All(b => b.FoodID == secilenFood.FoodID)).ToList().Count;
                int kahvaltiKalori = allMeals.Where(a => a.MealTypeID == 1 && a.MealDetails.All(b => b.FoodID == secilenFood.FoodID)).ToList().Sum(g => g.MealDetails.Sum(h => h.Calory));
                lblBreakFastPiece.Text = kahvaltiAdet.ToString();
                lblBreakFastCalory.Text = kahvaltiKalori.ToString();

                int oglenAdet = allMeals.Where(a => a.MealTypeID == 2 && a.MealDetails.All(b => b.FoodID == secilenFood.FoodID)).ToList().Count;
                int oglenKalori = allMeals.Where(a => a.MealTypeID == 2 && a.MealDetails.All(b => b.FoodID == secilenFood.FoodID)).ToList().Sum(g => g.MealDetails.Sum(h => h.Calory));
                lblLunchPiece.Text = oglenAdet.ToString();
                lblLunchCalory.Text = oglenKalori.ToString();

                int aksamAdet = allMeals.Where(a => a.MealTypeID == 3 && a.MealDetails.All(b => b.FoodID == secilenFood.FoodID)).ToList().Count;
                int aksamKalori = allMeals.Where(a => a.MealTypeID == 3 && a.MealDetails.All(b => b.FoodID == secilenFood.FoodID)).ToList().Sum(g => g.MealDetails.Sum(h => h.Calory));
                lblDinnerPiece.Text = aksamAdet.ToString();
                lblDinnerCalory.Text = aksamKalori.ToString();

                int araAdet = allMeals.Where(a => a.MealTypeID == 4 && a.MealDetails.All(b => b.FoodID == secilenFood.FoodID)).ToList().Count;
                int araKalori = allMeals.Where(a => a.MealTypeID == 4 && a.MealDetails.All(b => b.FoodID == secilenFood.FoodID)).ToList().Sum(g => g.MealDetails.Sum(h => h.Calory));
                lblSnackPiece.Text = araAdet.ToString();
                lblSnackCalory.Text = araKalori.ToString();
            }
        }

        private void btnBackMeal_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserMainPagee user = new UserMainPagee();
            user.user = db.Users.Where(x => x.UserID == userid).FirstOrDefault();
            user.Show();
        }
    }
}
