
namespace NauCalory.UserPage
{
    partial class MealPagee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MealPagee));
            this.btnBackMeal = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lvMealDetail = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvFoods = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtFinish = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMealAdd = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btnBackMeal
            // 
            this.btnBackMeal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBackMeal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackMeal.ImageIndex = 1;
            this.btnBackMeal.ImageList = this.ımageList1;
            this.btnBackMeal.Location = new System.Drawing.Point(636, 39);
            this.btnBackMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackMeal.Name = "btnBackMeal";
            this.btnBackMeal.Size = new System.Drawing.Size(108, 52);
            this.btnBackMeal.TabIndex = 61;
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
            this.ımageList1.Images.SetKeyName(1, "geri2.png");
            this.ımageList1.Images.SetKeyName(2, "sss.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(106, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 60;
            this.label1.Text = "Öğün Detayları";
            // 
            // lvMealDetail
            // 
            this.lvMealDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvMealDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvMealDetail.FullRowSelect = true;
            this.lvMealDetail.GridLines = true;
            this.lvMealDetail.HideSelection = false;
            this.lvMealDetail.Location = new System.Drawing.Point(103, 372);
            this.lvMealDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvMealDetail.Name = "lvMealDetail";
            this.lvMealDetail.Size = new System.Drawing.Size(591, 152);
            this.lvMealDetail.TabIndex = 59;
            this.lvMealDetail.UseCompatibleStateImageBehavior = false;
            this.lvMealDetail.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Öğün Türü";
            this.columnHeader5.Width = 115;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Yemek Adı";
            this.columnHeader6.Width = 123;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Miktar";
            this.columnHeader7.Width = 115;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Kalori";
            this.columnHeader8.Width = 135;
            // 
            // lvFoods
            // 
            this.lvFoods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvFoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvFoods.FullRowSelect = true;
            this.lvFoods.GridLines = true;
            this.lvFoods.HideSelection = false;
            this.lvFoods.Location = new System.Drawing.Point(108, 182);
            this.lvFoods.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvFoods.Name = "lvFoods";
            this.lvFoods.Size = new System.Drawing.Size(591, 152);
            this.lvFoods.TabIndex = 58;
            this.lvFoods.UseCompatibleStateImageBehavior = false;
            this.lvFoods.View = System.Windows.Forms.View.Details;
            this.lvFoods.SelectedIndexChanged += new System.EventHandler(this.lvFoods_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tarih";
            this.columnHeader1.Width = 88;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Öğün Türü";
            this.columnHeader2.Width = 107;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kalori";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Yemek Adedi";
            this.columnHeader4.Width = 286;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.ImageIndex = 0;
            this.btnSearch.ImageList = this.ımageList1;
            this.btnSearch.Location = new System.Drawing.Point(655, 124);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(39, 38);
            this.btnSearch.TabIndex = 57;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtFinish
            // 
            this.dtFinish.Location = new System.Drawing.Point(510, 139);
            this.dtFinish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFinish.Name = "dtFinish";
            this.dtFinish.Size = new System.Drawing.Size(136, 22);
            this.dtFinish.TabIndex = 56;
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(359, 139);
            this.dtStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(136, 22);
            this.dtStart.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(360, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 54;
            this.label3.Text = "Başlangıç";
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.ImageIndex = 2;
            this.btnDelete.ImageList = this.ımageList1;
            this.btnDelete.Location = new System.Drawing.Point(256, 120);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 47);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "Sil";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(516, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "Bitiş";
            // 
            // btnMealAdd
            // 
            this.btnMealAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMealAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMealAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMealAdd.ImageIndex = 0;
            this.btnMealAdd.ImageList = this.ımageList1;
            this.btnMealAdd.Location = new System.Drawing.Point(114, 120);
            this.btnMealAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMealAdd.Name = "btnMealAdd";
            this.btnMealAdd.Size = new System.Drawing.Size(132, 47);
            this.btnMealAdd.TabIndex = 51;
            this.btnMealAdd.Text = "Öğün Ekle";
            this.btnMealAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMealAdd.UseVisualStyleBackColor = true;
            this.btnMealAdd.Click += new System.EventHandler(this.btnMealAdd_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MealPagee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 581);
            this.Controls.Add(this.btnBackMeal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvMealDetail);
            this.Controls.Add(this.lvFoods);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtFinish);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMealAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MealPagee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MealPagee";
            this.Load += new System.EventHandler(this.MealPagee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackMeal;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListView lvMealDetail;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        public System.Windows.Forms.ListView lvFoods;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtFinish;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMealAdd;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList2;
    }
}