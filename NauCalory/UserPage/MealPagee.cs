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
    public partial class MealPagee : Form
    {
        MealMethod mealMethod;
        int userid;
        NauDbContext db = new NauDbContext();

        public MealPagee(int _userid)
        {
            InitializeComponent();
            userid = _userid;
        }

        private void btnMealAdd_Click(object sender, EventArgs e)
        {
            MealEntryPage me = new MealEntryPage(userid);
            me.ShowDialog();
            UpdateMeals();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvFoods.SelectedItems.Count > 0 && lvFoods.SelectedItems[0].Index > -1)
            {
                Meal meal = (Meal)lvFoods.SelectedItems[0].Tag;
                mealMethod.Delete(meal.MealID);
                FillMeals(mealMethod.GetUserMeals(userid));
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            mealMethod = new MealMethod();
            try
            {
                List<Meal> meals = mealMethod.GetUserMeals(userid, dtStart.Value, dtFinish.Value.AddDays(1));
                FillMeals(meals);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void FillMeals(List<Meal> meals)
        {
            lvFoods.Items.Clear();
            if (meals.Count > 0)
            {
                foreach (Meal item in meals)
                {
                    ListViewItem lvi = new ListViewItem(item.RegisterationDate.ToShortDateString());
                    lvi.SubItems.Add(item.MealType.MealTypeName);
                    lvi.SubItems.Add(item.MealDetails.Sum(x => x.Calory).ToString());
                    lvi.SubItems.Add(item.MealDetails.Count.ToString());
                    lvi.Tag = item;
                    lvFoods.Items.Add(lvi);
                }
            }
        }
        void UpdateMeals()
        {
            mealMethod = new MealMethod();
            List<Meal> meals = mealMethod.GetUserMeals(userid);
            FillMeals(meals);
        }

        private void lvFoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvFoods.SelectedItems.Count > 0 && lvFoods.SelectedItems[0].Index > -1)
            {
                lvMealDetail.Items.Clear();
                Meal selectedMeal = (Meal)lvFoods.SelectedItems[0].Tag;
                foreach (MealDetail item in selectedMeal.MealDetails)
                {
                    ListViewItem lvi = new ListViewItem(selectedMeal.MealType.MealTypeName);
                    lvi.SubItems.Add(item.Food.Name);
                    lvi.SubItems.Add(item.Grams.ToString());
                    lvi.SubItems.Add(item.Calory.ToString());
                    lvi.Tag = item;
                    lvMealDetail.Items.Add(lvi);
                }
            }
        }

        private void MealPagee_Load(object sender, EventArgs e)
        {
            mealMethod = new MealMethod();
            List<Meal> meals = mealMethod.GetUserMeals(userid);
            FillMeals(meals);
            dtStart.Value = DateTime.Today;
            dtFinish.Value = DateTime.Today;
        }

        private void btnBackMeal_Click(object sender, EventArgs e)
        {
            this.Close();

            UserMainPagee user = new UserMainPagee();
            user.user = db.Users.Where(x => x.UserID == userid).FirstOrDefault();
            user.Show();
        }
    }
}
