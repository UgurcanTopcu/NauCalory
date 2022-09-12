
namespace NauCalory.UserPage
{
    partial class MealEntryPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MealEntryPage));
            this.label5 = new System.Windows.Forms.Label();
            this.cmbOgunler = new System.Windows.Forms.ComboBox();
            this.btnBackMeal = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvMeals = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtCalory = new System.Windows.Forms.TextBox();
            this.nmGram = new System.Windows.Forms.NumericUpDown();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.btnMealsSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmGram)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(74, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 28);
            this.label5.TabIndex = 51;
            this.label5.Text = "Öğün Türü Seçiniz";
            // 
            // cmbOgunler
            // 
            this.cmbOgunler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOgunler.FormattingEnabled = true;
            this.cmbOgunler.Location = new System.Drawing.Point(78, 82);
            this.cmbOgunler.Margin = new System.Windows.Forms.Padding(4);
            this.cmbOgunler.Name = "cmbOgunler";
            this.cmbOgunler.Size = new System.Drawing.Size(179, 24);
            this.cmbOgunler.TabIndex = 50;
            this.cmbOgunler.SelectedIndexChanged += new System.EventHandler(this.cmbOgunler_SelectedIndexChanged);
            // 
            // btnBackMeal
            // 
            this.btnBackMeal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBackMeal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackMeal.ImageIndex = 2;
            this.btnBackMeal.ImageList = this.ımageList1;
            this.btnBackMeal.Location = new System.Drawing.Point(678, 54);
            this.btnBackMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackMeal.Name = "btnBackMeal";
            this.btnBackMeal.Size = new System.Drawing.Size(108, 52);
            this.btnBackMeal.TabIndex = 49;
            this.btnBackMeal.Text = "GERİ\r\n";
            this.btnBackMeal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackMeal.UseVisualStyleBackColor = true;
            this.btnBackMeal.Click += new System.EventHandler(this.btnBackMeal_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "ara.PNG");
            this.ımageList1.Images.SetKeyName(1, "giriş-kaydet.png");
            this.ımageList1.Images.SetKeyName(2, "geri2.png");
            this.ımageList1.Images.SetKeyName(3, "sss.png");
            this.ımageList1.Images.SetKeyName(4, "ek.png");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(671, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "Kalori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(519, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "Gram";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(367, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Birim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(143, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Yemek Adı";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImageIndex = 1;
            this.btnSave.ImageList = this.ımageList1;
            this.btnSave.Location = new System.Drawing.Point(599, 468);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 58);
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "Kaydet";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.ImageIndex = 3;
            this.btnDelete.ImageList = this.ımageList1;
            this.btnDelete.Location = new System.Drawing.Point(359, 468);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 58);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "Sil";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.ImageIndex = 4;
            this.btnAdd.ImageList = this.ımageList1;
            this.btnAdd.Location = new System.Drawing.Point(132, 468);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 58);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvMeals
            // 
            this.lvMeals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvMeals.GridLines = true;
            this.lvMeals.HideSelection = false;
            this.lvMeals.Location = new System.Drawing.Point(64, 244);
            this.lvMeals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvMeals.Name = "lvMeals";
            this.lvMeals.Size = new System.Drawing.Size(711, 200);
            this.lvMeals.TabIndex = 41;
            this.lvMeals.UseCompatibleStateImageBehavior = false;
            this.lvMeals.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Öğün Türü";
            this.columnHeader1.Width = 122;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Yemek Adı";
            this.columnHeader2.Width = 203;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Miktar";
            this.columnHeader3.Width = 104;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kalori";
            this.columnHeader4.Width = 82;
            // 
            // txtCalory
            // 
            this.txtCalory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCalory.Location = new System.Drawing.Point(673, 189);
            this.txtCalory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCalory.Name = "txtCalory";
            this.txtCalory.Size = new System.Drawing.Size(100, 22);
            this.txtCalory.TabIndex = 40;
            // 
            // nmGram
            // 
            this.nmGram.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmGram.Location = new System.Drawing.Point(521, 189);
            this.nmGram.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmGram.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmGram.Name = "nmGram";
            this.nmGram.Size = new System.Drawing.Size(120, 22);
            this.nmGram.TabIndex = 39;
            this.nmGram.ValueChanged += new System.EventHandler(this.nmGram_ValueChanged);
            // 
            // cmbUnit
            // 
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(369, 189);
            this.cmbUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(121, 24);
            this.cmbUnit.TabIndex = 38;
            this.cmbUnit.SelectedIndexChanged += new System.EventHandler(this.cmbUnit_SelectedIndexChanged);
            // 
            // txtFoodName
            // 
            this.txtFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFoodName.Location = new System.Drawing.Point(143, 189);
            this.txtFoodName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(197, 22);
            this.txtFoodName.TabIndex = 37;
            // 
            // btnMealsSearch
            // 
            this.btnMealsSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMealsSearch.ImageIndex = 0;
            this.btnMealsSearch.ImageList = this.ımageList1;
            this.btnMealsSearch.Location = new System.Drawing.Point(64, 176);
            this.btnMealsSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMealsSearch.Name = "btnMealsSearch";
            this.btnMealsSearch.Size = new System.Drawing.Size(61, 50);
            this.btnMealsSearch.TabIndex = 36;
            this.btnMealsSearch.UseVisualStyleBackColor = true;
            this.btnMealsSearch.Click += new System.EventHandler(this.btnMealsSearch_Click);
            // 
            // MealEntryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 601);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbOgunler);
            this.Controls.Add(this.btnBackMeal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvMeals);
            this.Controls.Add(this.txtCalory);
            this.Controls.Add(this.nmGram);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.btnMealsSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MealEntryPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MealEntryPage";
            this.Load += new System.EventHandler(this.MealEntryPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmGram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbOgunler;
        private System.Windows.Forms.Button btnBackMeal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.ListView lvMeals;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtCalory;
        private System.Windows.Forms.NumericUpDown nmGram;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Button btnMealsSearch;
        private System.Windows.Forms.ImageList ımageList1;
    }
}