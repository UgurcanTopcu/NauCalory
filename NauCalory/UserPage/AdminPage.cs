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
    public partial class AdminPage : Form
    {
        CategoryMethod categoryMethod;
        FoodMethod foodMethod;
        int userid;
        Food duzenlenenFood;
        public AdminPage(int _userid)
        {
            InitializeComponent();
            userid = _userid;
            categoryMethod = new CategoryMethod();
            foodMethod = new FoodMethod();
            FillCategories();
        }
           
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                Food food = new Food()
                {
                    UserID = userid,
                    CategoryID = (int)cbmCategory.SelectedValue,
                    Name = txtProducts.Text,
                    Per100Cal = (int)nm100Calory.Value,
                    Grams = (int)nmPortion.Value
                };

                foodMethod.Insert(food);
                MessageBox.Show("Yiyecek/içecek eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (duzenlenenFood != null)
            {
                try
                {
                    Food food = foodMethod.FindFoodByID(duzenlenenFood.FoodID);
                    food.Name = txtProducts.Text;
                    food.Per100Cal = Convert.ToInt32(nm100Calory.Value);
                    food.Grams = Convert.ToInt32(nmPortion.Value);
                    food.CategoryID = (int)cbmCategory.SelectedValue;

                    foodMethod.Update(food);
                    MessageBox.Show("Yemek güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnUpdate.Enabled = false;
                    btnAdd.Enabled = true;
                    btnDelete.Enabled = false;

                    ClearForm();
                    duzenlenenFood = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (duzenlenenFood != null)
            {
                Food food = foodMethod.FindFoodByID(duzenlenenFood.FoodID);
                foodMethod.DelistFood(food.FoodID);                
                MessageBox.Show("Yemek listeden kaldırıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnUpdate.Enabled = false;
                btnAdd.Enabled = true;
                btnDelete.Enabled = false;
                ClearForm();
            }
        }
        void FillCategories()
        {
            cbmCategory.ValueMember = "CategoryID";
            cbmCategory.DisplayMember = "Name";
            cbmCategory.DataSource = categoryMethod.GetAll();
        }


        private void ClearForm()
        {
            cbmCategory.SelectedIndex = 0;
            txtProducts.Clear();
            nm100Calory.Value = 0;
            nmPortion.Value = 0;
        }


        private void SecilenDoldur()
        {
            if (duzenlenenFood != null)
            {
                txtProducts.Text = duzenlenenFood.Name;
                nm100Calory.Value = duzenlenenFood.Per100Cal;
                nmPortion.Value = duzenlenenFood.Grams;
                cbmCategory.Text = duzenlenenFood.Category.Name;
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            ChooseFoodPage cp = new ChooseFoodPage(userid, true);
            cp.ShowDialog();
            if (cp.DialogResult == DialogResult.OK)
            {
                duzenlenenFood = cp.selectedFood;
                SecilenDoldur();
                btnUpdate.Enabled = true;
                btnAdd.Enabled = false;
                btnDelete.Enabled = true;
            }
        }

        private void btnCategoryManagement_Click(object sender, EventArgs e)
        {
            CategoryControlPage categoryControlPage = new CategoryControlPage(userid);
            this.Hide();
            categoryControlPage.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Sidepanel2.Height = btnCikis.Height;
            Sidepanel2.Top = btnCikis.Top;
            Environment.Exit(0);
        }
    }
}
