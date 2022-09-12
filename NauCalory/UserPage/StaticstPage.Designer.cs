
namespace NauCalory.UserPage
{
    partial class StaticstPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaticstPage));
            this.btnBackMeal = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.lvCategory = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDinnerCalory = new System.Windows.Forms.Label();
            this.lblDinnerPiece = new System.Windows.Forms.Label();
            this.lblSnackCalory = new System.Windows.Forms.Label();
            this.lblSnackPiece = new System.Windows.Forms.Label();
            this.lblLunchCalory = new System.Windows.Forms.Label();
            this.lblLunchPiece = new System.Windows.Forms.Label();
            this.lblBreakFastCalory = new System.Windows.Forms.Label();
            this.lblBreakFastPiece = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.lblDinnerMonth = new System.Windows.Forms.Label();
            this.lblLunchMonth = new System.Windows.Forms.Label();
            this.lblSnackMonth = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblBreakFastMonth = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblDinner = new System.Windows.Forms.Label();
            this.lblLunch = new System.Windows.Forms.Label();
            this.lblSnack = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBreakfast = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBackMeal
            // 
            this.btnBackMeal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBackMeal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackMeal.ImageIndex = 1;
            this.btnBackMeal.ImageList = this.ımageList1;
            this.btnBackMeal.Location = new System.Drawing.Point(767, 45);
            this.btnBackMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackMeal.Name = "btnBackMeal";
            this.btnBackMeal.Size = new System.Drawing.Size(108, 52);
            this.btnBackMeal.TabIndex = 220;
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
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(84, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(800, 2);
            this.label6.TabIndex = 219;
            // 
            // lvCategory
            // 
            this.lvCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvCategory.GridLines = true;
            this.lvCategory.HideSelection = false;
            this.lvCategory.Location = new System.Drawing.Point(445, 335);
            this.lvCategory.Name = "lvCategory";
            this.lvCategory.Size = new System.Drawing.Size(452, 288);
            this.lvCategory.TabIndex = 218;
            this.lvCategory.UseCompatibleStateImageBehavior = false;
            this.lvCategory.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kategori Adı";
            this.columnHeader1.Width = 87;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kahvaltı";
            this.columnHeader2.Width = 69;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ara Öğün";
            this.columnHeader3.Width = 76;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Öğlen Yemeği";
            this.columnHeader4.Width = 112;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Akşam Yemeği";
            this.columnHeader5.Width = 126;
            // 
            // lblDinnerCalory
            // 
            this.lblDinnerCalory.AutoSize = true;
            this.lblDinnerCalory.BackColor = System.Drawing.Color.Transparent;
            this.lblDinnerCalory.ForeColor = System.Drawing.Color.Black;
            this.lblDinnerCalory.Location = new System.Drawing.Point(339, 457);
            this.lblDinnerCalory.Name = "lblDinnerCalory";
            this.lblDinnerCalory.Size = new System.Drawing.Size(28, 17);
            this.lblDinnerCalory.TabIndex = 217;
            this.lblDinnerCalory.Text = "----";
            // 
            // lblDinnerPiece
            // 
            this.lblDinnerPiece.AutoSize = true;
            this.lblDinnerPiece.BackColor = System.Drawing.Color.Transparent;
            this.lblDinnerPiece.ForeColor = System.Drawing.Color.Black;
            this.lblDinnerPiece.Location = new System.Drawing.Point(252, 457);
            this.lblDinnerPiece.Name = "lblDinnerPiece";
            this.lblDinnerPiece.Size = new System.Drawing.Size(28, 17);
            this.lblDinnerPiece.TabIndex = 216;
            this.lblDinnerPiece.Text = "----";
            // 
            // lblSnackCalory
            // 
            this.lblSnackCalory.AutoSize = true;
            this.lblSnackCalory.BackColor = System.Drawing.Color.Transparent;
            this.lblSnackCalory.ForeColor = System.Drawing.Color.Black;
            this.lblSnackCalory.Location = new System.Drawing.Point(339, 430);
            this.lblSnackCalory.Name = "lblSnackCalory";
            this.lblSnackCalory.Size = new System.Drawing.Size(28, 17);
            this.lblSnackCalory.TabIndex = 215;
            this.lblSnackCalory.Text = "----";
            // 
            // lblSnackPiece
            // 
            this.lblSnackPiece.AutoSize = true;
            this.lblSnackPiece.BackColor = System.Drawing.Color.Transparent;
            this.lblSnackPiece.ForeColor = System.Drawing.Color.Black;
            this.lblSnackPiece.Location = new System.Drawing.Point(252, 430);
            this.lblSnackPiece.Name = "lblSnackPiece";
            this.lblSnackPiece.Size = new System.Drawing.Size(28, 17);
            this.lblSnackPiece.TabIndex = 214;
            this.lblSnackPiece.Text = "----";
            // 
            // lblLunchCalory
            // 
            this.lblLunchCalory.AutoSize = true;
            this.lblLunchCalory.BackColor = System.Drawing.Color.Transparent;
            this.lblLunchCalory.ForeColor = System.Drawing.Color.Black;
            this.lblLunchCalory.Location = new System.Drawing.Point(339, 403);
            this.lblLunchCalory.Name = "lblLunchCalory";
            this.lblLunchCalory.Size = new System.Drawing.Size(28, 17);
            this.lblLunchCalory.TabIndex = 213;
            this.lblLunchCalory.Text = "----";
            // 
            // lblLunchPiece
            // 
            this.lblLunchPiece.AutoSize = true;
            this.lblLunchPiece.BackColor = System.Drawing.Color.Transparent;
            this.lblLunchPiece.ForeColor = System.Drawing.Color.Black;
            this.lblLunchPiece.Location = new System.Drawing.Point(252, 403);
            this.lblLunchPiece.Name = "lblLunchPiece";
            this.lblLunchPiece.Size = new System.Drawing.Size(28, 17);
            this.lblLunchPiece.TabIndex = 212;
            this.lblLunchPiece.Text = "----";
            // 
            // lblBreakFastCalory
            // 
            this.lblBreakFastCalory.AutoSize = true;
            this.lblBreakFastCalory.BackColor = System.Drawing.Color.Transparent;
            this.lblBreakFastCalory.ForeColor = System.Drawing.Color.Black;
            this.lblBreakFastCalory.Location = new System.Drawing.Point(339, 376);
            this.lblBreakFastCalory.Name = "lblBreakFastCalory";
            this.lblBreakFastCalory.Size = new System.Drawing.Size(28, 17);
            this.lblBreakFastCalory.TabIndex = 211;
            this.lblBreakFastCalory.Text = "----";
            // 
            // lblBreakFastPiece
            // 
            this.lblBreakFastPiece.AutoSize = true;
            this.lblBreakFastPiece.BackColor = System.Drawing.Color.Transparent;
            this.lblBreakFastPiece.ForeColor = System.Drawing.Color.Black;
            this.lblBreakFastPiece.Location = new System.Drawing.Point(252, 376);
            this.lblBreakFastPiece.Name = "lblBreakFastPiece";
            this.lblBreakFastPiece.Size = new System.Drawing.Size(28, 17);
            this.lblBreakFastPiece.TabIndex = 210;
            this.lblBreakFastPiece.Text = "----";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFoodName.ForeColor = System.Drawing.Color.Black;
            this.txtFoodName.Location = new System.Drawing.Point(246, 563);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(167, 22);
            this.txtFoodName.TabIndex = 209;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.ImageIndex = 0;
            this.btnSearch.ImageList = this.ımageList1;
            this.btnSearch.Location = new System.Drawing.Point(126, 554);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 41);
            this.btnSearch.TabIndex = 208;
            this.btnSearch.Text = "Ara";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(125, 519);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(111, 20);
            this.label22.TabIndex = 207;
            this.label22.Text = "Yemek Seçin:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(327, 353);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(44, 17);
            this.label21.TabIndex = 206;
            this.label21.Text = "Kalori";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(252, 353);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 17);
            this.label20.TabIndex = 205;
            this.label20.Text = "Adet";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(135, 403);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(101, 17);
            this.label23.TabIndex = 204;
            this.label23.Text = "Öğlen Yemeği:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(163, 430);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(73, 17);
            this.label24.TabIndex = 203;
            this.label24.Text = "Ara Öğün:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(131, 457);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(105, 17);
            this.label25.TabIndex = 202;
            this.label25.Text = "Akşam Yemeği:";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.BackColor = System.Drawing.Color.Transparent;
            this.label80.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label80.ForeColor = System.Drawing.Color.Black;
            this.label80.Location = new System.Drawing.Point(174, 376);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(62, 17);
            this.label80.TabIndex = 201;
            this.label80.Text = "Kahvaltı:";
            // 
            // lblDinnerMonth
            // 
            this.lblDinnerMonth.AutoSize = true;
            this.lblDinnerMonth.BackColor = System.Drawing.Color.Transparent;
            this.lblDinnerMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDinnerMonth.ForeColor = System.Drawing.Color.Black;
            this.lblDinnerMonth.Location = new System.Drawing.Point(768, 189);
            this.lblDinnerMonth.Name = "lblDinnerMonth";
            this.lblDinnerMonth.Size = new System.Drawing.Size(45, 17);
            this.lblDinnerMonth.TabIndex = 200;
            this.lblDinnerMonth.Text = "0 kcal";
            // 
            // lblLunchMonth
            // 
            this.lblLunchMonth.AutoSize = true;
            this.lblLunchMonth.BackColor = System.Drawing.Color.Transparent;
            this.lblLunchMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLunchMonth.ForeColor = System.Drawing.Color.Black;
            this.lblLunchMonth.Location = new System.Drawing.Point(768, 141);
            this.lblLunchMonth.Name = "lblLunchMonth";
            this.lblLunchMonth.Size = new System.Drawing.Size(45, 17);
            this.lblLunchMonth.TabIndex = 199;
            this.lblLunchMonth.Text = "0 kcal";
            // 
            // lblSnackMonth
            // 
            this.lblSnackMonth.AutoSize = true;
            this.lblSnackMonth.BackColor = System.Drawing.Color.Transparent;
            this.lblSnackMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSnackMonth.ForeColor = System.Drawing.Color.Black;
            this.lblSnackMonth.Location = new System.Drawing.Point(581, 189);
            this.lblSnackMonth.Name = "lblSnackMonth";
            this.lblSnackMonth.Size = new System.Drawing.Size(45, 17);
            this.lblSnackMonth.TabIndex = 198;
            this.lblSnackMonth.Text = "0 kcal";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(661, 141);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 17);
            this.label15.TabIndex = 197;
            this.label15.Text = "Öğlen Yemeği:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(507, 189);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 17);
            this.label16.TabIndex = 196;
            this.label16.Text = "Ara Öğün:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(661, 189);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 17);
            this.label17.TabIndex = 195;
            this.label17.Text = "Akşam Yemeği:";
            // 
            // lblBreakFastMonth
            // 
            this.lblBreakFastMonth.AutoSize = true;
            this.lblBreakFastMonth.BackColor = System.Drawing.Color.Transparent;
            this.lblBreakFastMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBreakFastMonth.ForeColor = System.Drawing.Color.Black;
            this.lblBreakFastMonth.Location = new System.Drawing.Point(581, 141);
            this.lblBreakFastMonth.Name = "lblBreakFastMonth";
            this.lblBreakFastMonth.Size = new System.Drawing.Size(45, 17);
            this.lblBreakFastMonth.TabIndex = 194;
            this.lblBreakFastMonth.Text = "0 kcal";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(507, 141);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 17);
            this.label19.TabIndex = 193;
            this.label19.Text = "Kahvaltı:";
            // 
            // lblDinner
            // 
            this.lblDinner.AutoSize = true;
            this.lblDinner.BackColor = System.Drawing.Color.Transparent;
            this.lblDinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDinner.ForeColor = System.Drawing.Color.Black;
            this.lblDinner.Location = new System.Drawing.Point(395, 189);
            this.lblDinner.Name = "lblDinner";
            this.lblDinner.Size = new System.Drawing.Size(45, 17);
            this.lblDinner.TabIndex = 192;
            this.lblDinner.Text = "0 kcal";
            // 
            // lblLunch
            // 
            this.lblLunch.AutoSize = true;
            this.lblLunch.BackColor = System.Drawing.Color.Transparent;
            this.lblLunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLunch.ForeColor = System.Drawing.Color.Black;
            this.lblLunch.Location = new System.Drawing.Point(395, 141);
            this.lblLunch.Name = "lblLunch";
            this.lblLunch.Size = new System.Drawing.Size(45, 17);
            this.lblLunch.TabIndex = 191;
            this.lblLunch.Text = "0 kcal";
            // 
            // lblSnack
            // 
            this.lblSnack.AutoSize = true;
            this.lblSnack.BackColor = System.Drawing.Color.Transparent;
            this.lblSnack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSnack.ForeColor = System.Drawing.Color.Black;
            this.lblSnack.Location = new System.Drawing.Point(198, 189);
            this.lblSnack.Name = "lblSnack";
            this.lblSnack.Size = new System.Drawing.Size(45, 17);
            this.lblSnack.TabIndex = 190;
            this.lblSnack.Text = "0 kcal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(288, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 17);
            this.label9.TabIndex = 189;
            this.label9.Text = "Öğlen Yemeği:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(124, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 188;
            this.label8.Text = "Ara Öğün:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(288, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 187;
            this.label7.Text = "Akşam Yemeği:";
            // 
            // lblBreakfast
            // 
            this.lblBreakfast.AutoSize = true;
            this.lblBreakfast.BackColor = System.Drawing.Color.Transparent;
            this.lblBreakfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBreakfast.ForeColor = System.Drawing.Color.Black;
            this.lblBreakfast.Location = new System.Drawing.Point(198, 141);
            this.lblBreakfast.Name = "lblBreakfast";
            this.lblBreakfast.Size = new System.Drawing.Size(45, 17);
            this.lblBreakfast.TabIndex = 186;
            this.lblBreakfast.Text = "0 kcal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(124, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 185;
            this.label5.Text = "Kahvaltı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(556, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 23);
            this.label4.TabIndex = 184;
            this.label4.Text = "Kategori Bazlı Kalori Raporu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(156, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 23);
            this.label3.TabIndex = 183;
            this.label3.Text = "Yemek Bazlı Kalori Rapou";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(568, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 23);
            this.label2.TabIndex = 182;
            this.label2.Text = "Aylık Kalori Takibi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(176, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 23);
            this.label1.TabIndex = 181;
            this.label1.Text = "Haftalık Kalori Takibi";
            // 
            // StaticstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 674);
            this.Controls.Add(this.btnBackMeal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lvCategory);
            this.Controls.Add(this.lblDinnerCalory);
            this.Controls.Add(this.lblDinnerPiece);
            this.Controls.Add(this.lblSnackCalory);
            this.Controls.Add(this.lblSnackPiece);
            this.Controls.Add(this.lblLunchCalory);
            this.Controls.Add(this.lblLunchPiece);
            this.Controls.Add(this.lblBreakFastCalory);
            this.Controls.Add(this.lblBreakFastPiece);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label80);
            this.Controls.Add(this.lblDinnerMonth);
            this.Controls.Add(this.lblLunchMonth);
            this.Controls.Add(this.lblSnackMonth);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblBreakFastMonth);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblDinner);
            this.Controls.Add(this.lblLunch);
            this.Controls.Add(this.lblSnack);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblBreakfast);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaticstPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaticstPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackMeal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lvCategory;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lblDinnerCalory;
        private System.Windows.Forms.Label lblDinnerPiece;
        private System.Windows.Forms.Label lblSnackCalory;
        private System.Windows.Forms.Label lblSnackPiece;
        private System.Windows.Forms.Label lblLunchCalory;
        private System.Windows.Forms.Label lblLunchPiece;
        private System.Windows.Forms.Label lblBreakFastCalory;
        private System.Windows.Forms.Label lblBreakFastPiece;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label lblDinnerMonth;
        private System.Windows.Forms.Label lblLunchMonth;
        private System.Windows.Forms.Label lblSnackMonth;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblBreakFastMonth;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblDinner;
        private System.Windows.Forms.Label lblLunch;
        private System.Windows.Forms.Label lblSnack;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBreakfast;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}