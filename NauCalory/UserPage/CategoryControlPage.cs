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
    public partial class CategoryControlPage : Form
    {
        CategoryMethod categoryMethod;
        Category duzenlenenCat;
        NauDbContext db = new NauDbContext();
        int _userId;
        public CategoryControlPage(int userId)
        {
            categoryMethod = new CategoryMethod();
            InitializeComponent();
            FillCategories();
            _userId = userId;
        }

        void FillCategories()
        {
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.DisplayMember = "Name";
            cmbCategory.DataSource = categoryMethod.GetAll();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (duzenlenenCat != null)
            {
                try
                {
                    duzenlenenCat.Name = txtCategoryName.Text;
                    bool updateCat = categoryMethod.Update(duzenlenenCat);

                    if (updateCat) MessageBox.Show("Kategori bilgisi güncellendi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillCategories();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var category = db.Categories.Where(x => x.Name.Equals(txtNewCategory.Text)).FirstOrDefault();
                if (category == null)
                {
                    Category cat = new Category()
                    {
                        Name = txtNewCategory.Text,
                    };
                    bool newCat = categoryMethod.Insert(cat);
                    if (newCat) MessageBox.Show("Yeni kategori başarı ile eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillCategories();
                }
                else
                {
                    MessageBox.Show("Kategori Zaten Var", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCategoryName.Text = cmbCategory.Text;
            if (cmbCategory.SelectedIndex > -1)
                duzenlenenCat = categoryMethod.GetCategoryById((int)cmbCategory.SelectedValue);

        }

        private void btnBackMeal_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminPage adminPage = new AdminPage(_userId);
            adminPage.Show();
        }
    }
}
