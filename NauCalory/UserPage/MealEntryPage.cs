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
    public partial class MealEntryPage : Form
    {
        int userid;
        Meal myMeal;
        UserMethod userMethod;
        FoodMethod foodMethod;
        MealMethod mealMethod;
        MealTypeMethod mealTypeMethod;
        Food secilenFood;
        NauDbContext db = new NauDbContext();
        public MealEntryPage(int _userid)
        {
            InitializeComponent();
            myMeal = new Meal();
            userid = _userid;
            mealTypeMethod = new MealTypeMethod();
            mealMethod = new MealMethod();
            userMethod = new UserMethod();
            foodMethod = new FoodMethod();
            EditMealTypes();
        }
        public MealEntryPage(Meal _meal)
        {
            InitializeComponent();
            mealTypeMethod = new MealTypeMethod();
            mealMethod = new MealMethod();
            userMethod = new UserMethod();
            foodMethod = new FoodMethod();
            myMeal = mealMethod.GetMealByID(_meal.MealID);
            userid = myMeal.UserID;

            UrunluAcilis(myMeal);
            EditMealTypes();
        }
        void EditMealTypes()
        {
            List<MealType> list = mealTypeMethod.GetAllTypes();
            cmbOgunler.ValueMember = "MealTypeID";
            cmbOgunler.DisplayMember = "MealTypeName";
            cmbOgunler.DataSource = list;
            //cmbOgunler.SelectedIndex = 0;
            //cmbUnit.SelectedIndex = 0;

            if (myMeal.MealType != null)
                cmbOgunler.Text = myMeal.MealType.MealTypeName;
        }

        void UrunluAcilis(Meal meal)
        {
            FillList();
        }

        private void btnMealsSearch_Click(object sender, EventArgs e)
        {
            ChooseFoodPage cfp = new ChooseFoodPage(userid);
            cfp.ShowDialog();
            secilenFood = cfp.selectedFood;
            SecilenFoodDoldur();
        }
        void SecilenFoodDoldur()
        {
            if (secilenFood != null)
            {
                txtFoodName.Text = secilenFood.Name;

                if (cmbUnit.SelectedIndex == 0)
                {
                    nmGram.Value = 100;
                    txtCalory.Text = secilenFood.Per100Cal.ToString();
                }
                else
                {
                    nmGram.Value = secilenFood.Grams;
                    decimal kalori = (decimal)(secilenFood.Per100Cal / 100.0) * nmGram.Value;
                    txtCalory.Text = Convert.ToInt32(kalori).ToString();
                }
            }
        }

        private void cmbOgunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            myMeal.MealTypeID = (int)cmbOgunler.SelectedValue;
        }

        private void cmbUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            SecilenFoodDoldur();
        }

        private void nmGram_ValueChanged(object sender, EventArgs e)
        {
            if (secilenFood != null)
            {
                decimal kalori = (decimal)(secilenFood.Per100Cal / 100.0) * nmGram.Value;
                txtCalory.Text = Convert.ToInt32(kalori).ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (secilenFood != null)
            {
                Food food = foodMethod.FindFoodByID(secilenFood.FoodID);
                MealDetail mealDetail = new MealDetail() { FoodID = food.FoodID, Grams = Convert.ToInt32(nmGram.Value), Calory = Convert.ToInt32(txtCalory.Text) };

                secilenFood = null;
                myMeal.MealDetails.Add(mealDetail);
                FillList();
                TextBoxesClear();
            }
        }
        void FillList()
        {
            lvMeals.Items.Clear();
            foreach (MealDetail item in myMeal.MealDetails)
            {
                Food food;
                if (secilenFood == null)
                    food = foodMethod.FindFoodByID(item.FoodID);
                else
                    food = foodMethod.FindFoodByID(secilenFood.FoodID);

                string baslik = myMeal.MealType == null ? cmbOgunler.Text : myMeal.MealType.MealTypeName;

                ListViewItem lvi = new ListViewItem(baslik);
                lvi.SubItems.Add(food.Name);
                lvi.SubItems.Add(item.Grams.ToString());
                lvi.SubItems.Add(item.Calory.ToString());
                lvi.Tag = item;
                lvMeals.Items.Add(lvi);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvMeals.SelectedItems.Count > 0)
            {
                int index = lvMeals.SelectedItems[0].Index;
                myMeal.MealDetails.Remove((MealDetail)lvMeals.SelectedItems[0].Tag);
            }

            FillList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (myMeal.MealID > 0)
                {
                    mealMethod.Update(myMeal);
                }
                else
                {
                    User user = userMethod.GetUserById(userid);
                    MealType mealType = mealTypeMethod.GetAllTypes().Where(x => x.MealTypeID == (int)cmbOgunler.SelectedValue).FirstOrDefault();

                    myMeal.UserID = user.UserID;
                    myMeal.RegisterationDate = DateTime.Now;
                    myMeal.MealTypeID = mealType.MealTypeID;
                    myMeal.State = true;

                    mealMethod.Insert(myMeal);
                }

                MessageBox.Show("Öğün eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void ClearForm()
        {
            myMeal = new Meal();
            secilenFood = null;
            lvMeals.Items.Clear();
            TextBoxesClear();
        }

        void TextBoxesClear()
        {
            txtFoodName.Clear();
            txtCalory.Clear();
            nmGram.Value = nmGram.Minimum;
        }

        private void MealEntryPage_Load(object sender, EventArgs e)
        {
            cmbUnit.DisplayMember = "Text";
            cmbUnit.ValueMember = "Value";

            cmbUnit.Items.Add(new { Text = "Porsiyon", Value = "1" });
            cmbUnit.Items.Add(new { Text = "Bardak", Value = "2" });
            cmbUnit.Items.Add(new { Text = "Adet", Value = "3" });
        }

        private void btnBackMeal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
