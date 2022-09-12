
namespace NauCalory.UserPage
{
    partial class CategoryControlPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryControlPage));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtNewCategory = new System.Windows.Forms.TextBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBackMeal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.ImageIndex = 1;
            this.btnUpdate.ImageList = this.ımageList1;
            this.btnUpdate.Location = new System.Drawing.Point(355, 187);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 58);
            this.btnUpdate.TabIndex = 38;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "ek.png");
            this.ımageList1.Images.SetKeyName(1, "ug.png");
            this.ımageList1.Images.SetKeyName(2, "geri2.png");
            // 
            // txtNewCategory
            // 
            this.txtNewCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNewCategory.Location = new System.Drawing.Point(290, 308);
            this.txtNewCategory.Name = "txtNewCategory";
            this.txtNewCategory.Size = new System.Drawing.Size(200, 22);
            this.txtNewCategory.TabIndex = 37;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCategoryName.Location = new System.Drawing.Point(290, 143);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(200, 22);
            this.txtCategoryName.TabIndex = 36;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(290, 104);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(200, 24);
            this.cmbCategory.TabIndex = 35;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(158, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Yeni Kategori Ekle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(174, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Kategori İsmi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(186, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "Kategoriler:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(174, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Kategori İsmi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(170, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Kategori Bilgisi Güncelle";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.ImageIndex = 0;
            this.btnAdd.ImageList = this.ımageList1;
            this.btnAdd.Location = new System.Drawing.Point(355, 355);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 58);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBackMeal
            // 
            this.btnBackMeal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBackMeal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackMeal.ImageIndex = 2;
            this.btnBackMeal.ImageList = this.ımageList1;
            this.btnBackMeal.Location = new System.Drawing.Point(540, 11);
            this.btnBackMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackMeal.Name = "btnBackMeal";
            this.btnBackMeal.Size = new System.Drawing.Size(108, 52);
            this.btnBackMeal.TabIndex = 221;
            this.btnBackMeal.Text = "GERİ\r\n";
            this.btnBackMeal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackMeal.UseVisualStyleBackColor = true;
            this.btnBackMeal.Click += new System.EventHandler(this.btnBackMeal_Click);
            // 
            // CategoryControlPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 479);
            this.Controls.Add(this.btnBackMeal);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtNewCategory);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryControlPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryControlPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtNewCategory;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBackMeal;
    }
}