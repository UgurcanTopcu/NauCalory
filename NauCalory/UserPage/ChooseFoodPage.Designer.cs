
namespace NauCalory.UserPage
{
    partial class ChooseFoodPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseFoodPage));
            this.lvMeals = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvMeals
            // 
            this.lvMeals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvMeals.FullRowSelect = true;
            this.lvMeals.GridLines = true;
            this.lvMeals.HideSelection = false;
            this.lvMeals.Location = new System.Drawing.Point(241, 82);
            this.lvMeals.Name = "lvMeals";
            this.lvMeals.Size = new System.Drawing.Size(636, 603);
            this.lvMeals.TabIndex = 12;
            this.lvMeals.UseCompatibleStateImageBehavior = false;
            this.lvMeals.View = System.Windows.Forms.View.Details;
            this.lvMeals.DoubleClick += new System.EventHandler(this.lvMeals_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "İsim";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "100 Gr/Ml Kalori";
            this.columnHeader2.Width = 118;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Porsiyon Gr/Ml";
            this.columnHeader3.Width = 108;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kategori";
            this.columnHeader4.Width = 385;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFoodName.Location = new System.Drawing.Point(37, 159);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(161, 22);
            this.txtFoodName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(35, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Yemek Adı";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(37, 82);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(161, 24);
            this.cmbCategory.TabIndex = 8;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kategori";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "ara.PNG");
            this.ımageList1.Images.SetKeyName(1, "geri2.png");
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.ImageIndex = 1;
            this.btnBack.ImageList = this.ımageList1;
            this.btnBack.Location = new System.Drawing.Point(740, 23);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 46);
            this.btnBack.TabIndex = 77;
            this.btnBack.Text = "GERİ";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.ImageIndex = 0;
            this.btnSearch.ImageList = this.ımageList1;
            this.btnSearch.Location = new System.Drawing.Point(71, 210);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(127, 43);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Ara";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ChooseFoodPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(899, 697);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lvMeals);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChooseFoodPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseFoodPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.ListView lvMeals;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        public System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnBack;
    }
}