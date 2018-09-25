namespace MoviesRentalSystems
{
    partial class Form1
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteCust = new System.Windows.Forms.Button();
            this.issueMovie = new System.Windows.Forms.Button();
            this.returnMovie = new System.Windows.Forms.Button();
            this.tabRadio = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.OutRented = new System.Windows.Forms.RadioButton();
            this.radioButton_Allrented = new System.Windows.Forms.RadioButton();
            this.button_AddCustomer = new System.Windows.Forms.Button();
            this.button_Addmovie = new System.Windows.Forms.Button();
            this.button_Deletemovie = new System.Windows.Forms.Button();
            this.button_updatemovie = new System.Windows.Forms.Button();
            this.Cust_ID = new System.Windows.Forms.TextBox();
            this.FirstNameCust = new System.Windows.Forms.TextBox();
            this.LastName_Cust = new System.Windows.Forms.TextBox();
            this.AddressCust = new System.Windows.Forms.TextBox();
            this.PhoneCust = new System.Windows.Forms.TextBox();
            this.IssueMovieDate = new System.Windows.Forms.TextBox();
            this.ReleaseDate = new System.Windows.Forms.TextBox();
            this.RentalCostMovie = new System.Windows.Forms.TextBox();
            this.GenreMovie = new System.Windows.Forms.TextBox();
            this.TitleMovie = new System.Windows.Forms.TextBox();
            this.MovieID = new System.Windows.Forms.TextBox();
            this.ReturnedDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.MoviesTab = new System.Windows.Forms.TabPage();
            this.moviesGrid = new System.Windows.Forms.DataGridView();
            this.customersTab = new System.Windows.Forms.TabPage();
            this.CustGrid = new System.Windows.Forms.DataGridView();
            this.tabControl1_movisRenatl = new System.Windows.Forms.TabControl();
            this.RenatlTAb = new System.Windows.Forms.TabPage();
            this.RentalGrid = new System.Windows.Forms.DataGridView();
            this.tabRadio.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.MoviesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviesGrid)).BeginInit();
            this.customersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustGrid)).BeginInit();
            this.tabControl1_movisRenatl.SuspendLayout();
            this.RenatlTAb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentalGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(200, 248);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(130, 31);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Update customer";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteCust
            // 
            this.deleteCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deleteCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCust.Location = new System.Drawing.Point(354, 248);
            this.deleteCust.Name = "deleteCust";
            this.deleteCust.Size = new System.Drawing.Size(125, 31);
            this.deleteCust.TabIndex = 2;
            this.deleteCust.Text = "Delete Customer";
            this.deleteCust.UseVisualStyleBackColor = false;
            this.deleteCust.Click += new System.EventHandler(this.deleteCust_Click);
            // 
            // issueMovie
            // 
            this.issueMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.issueMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueMovie.ForeColor = System.Drawing.Color.Red;
            this.issueMovie.Location = new System.Drawing.Point(599, 235);
            this.issueMovie.Name = "issueMovie";
            this.issueMovie.Size = new System.Drawing.Size(83, 55);
            this.issueMovie.TabIndex = 3;
            this.issueMovie.Text = "Issue Movie";
            this.issueMovie.UseVisualStyleBackColor = false;
            this.issueMovie.Click += new System.EventHandler(this.issueMovie_Click);
            // 
            // returnMovie
            // 
            this.returnMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.returnMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnMovie.ForeColor = System.Drawing.Color.Green;
            this.returnMovie.Location = new System.Drawing.Point(706, 236);
            this.returnMovie.Name = "returnMovie";
            this.returnMovie.Size = new System.Drawing.Size(74, 54);
            this.returnMovie.TabIndex = 4;
            this.returnMovie.Text = "Return Movie";
            this.returnMovie.UseVisualStyleBackColor = false;
            this.returnMovie.Click += new System.EventHandler(this.returnMovie_Click);
            // 
            // tabRadio
            // 
            this.tabRadio.Controls.Add(this.tabPage2);
            this.tabRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRadio.Location = new System.Drawing.Point(581, 428);
            this.tabRadio.Name = "tabRadio";
            this.tabRadio.SelectedIndex = 0;
            this.tabRadio.Size = new System.Drawing.Size(214, 59);
            this.tabRadio.TabIndex = 5;
            this.tabRadio.Tag = "";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.OutRented);
            this.tabPage2.Controls.Add(this.radioButton_Allrented);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(206, 31);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rented Movies";
            // 
            // OutRented
            // 
            this.OutRented.AutoSize = true;
            this.OutRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutRented.Location = new System.Drawing.Point(92, 8);
            this.OutRented.Name = "OutRented";
            this.OutRented.Size = new System.Drawing.Size(97, 19);
            this.OutRented.TabIndex = 1;
            this.OutRented.TabStop = true;
            this.OutRented.Text = "Out Rented";
            this.OutRented.UseVisualStyleBackColor = true;
            // 
            // radioButton_Allrented
            // 
            this.radioButton_Allrented.AutoSize = true;
            this.radioButton_Allrented.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Allrented.Location = new System.Drawing.Point(0, 8);
            this.radioButton_Allrented.Name = "radioButton_Allrented";
            this.radioButton_Allrented.Size = new System.Drawing.Size(91, 19);
            this.radioButton_Allrented.TabIndex = 0;
            this.radioButton_Allrented.TabStop = true;
            this.radioButton_Allrented.Text = "All Rented";
            this.radioButton_Allrented.UseVisualStyleBackColor = true;
            this.radioButton_Allrented.CheckedChanged += new System.EventHandler(this.radioButton_Allrented_CheckedChanged);
            // 
            // button_AddCustomer
            // 
            this.button_AddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_AddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddCustomer.Location = new System.Drawing.Point(12, 283);
            this.button_AddCustomer.Name = "button_AddCustomer";
            this.button_AddCustomer.Size = new System.Drawing.Size(78, 58);
            this.button_AddCustomer.TabIndex = 6;
            this.button_AddCustomer.Text = "Add  Customer";
            this.button_AddCustomer.UseVisualStyleBackColor = false;
            this.button_AddCustomer.Click += new System.EventHandler(this.button_AddCustomer_Click);
            // 
            // button_Addmovie
            // 
            this.button_Addmovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_Addmovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Addmovie.Location = new System.Drawing.Point(12, 362);
            this.button_Addmovie.Name = "button_Addmovie";
            this.button_Addmovie.Size = new System.Drawing.Size(78, 47);
            this.button_Addmovie.TabIndex = 7;
            this.button_Addmovie.Text = "Add Movie";
            this.button_Addmovie.UseVisualStyleBackColor = false;
            this.button_Addmovie.Click += new System.EventHandler(this.button_Addmovie_Click);
            // 
            // button_Deletemovie
            // 
            this.button_Deletemovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_Deletemovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Deletemovie.Location = new System.Drawing.Point(71, 432);
            this.button_Deletemovie.Name = "button_Deletemovie";
            this.button_Deletemovie.Size = new System.Drawing.Size(125, 47);
            this.button_Deletemovie.TabIndex = 8;
            this.button_Deletemovie.Text = "Delete Movie";
            this.button_Deletemovie.UseVisualStyleBackColor = false;
            this.button_Deletemovie.Click += new System.EventHandler(this.button_Deletemovie_Click);
            // 
            // button_updatemovie
            // 
            this.button_updatemovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_updatemovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_updatemovie.Location = new System.Drawing.Point(231, 432);
            this.button_updatemovie.Name = "button_updatemovie";
            this.button_updatemovie.Size = new System.Drawing.Size(121, 47);
            this.button_updatemovie.TabIndex = 9;
            this.button_updatemovie.Text = "Update movie";
            this.button_updatemovie.UseVisualStyleBackColor = false;
            this.button_updatemovie.Click += new System.EventHandler(this.button_updatemovie_Click);
            // 
            // Cust_ID
            // 
            this.Cust_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cust_ID.Location = new System.Drawing.Point(104, 320);
            this.Cust_ID.Name = "Cust_ID";
            this.Cust_ID.Size = new System.Drawing.Size(36, 21);
            this.Cust_ID.TabIndex = 10;
            this.Cust_ID.Tag = "";
            this.Cust_ID.TextChanged += new System.EventHandler(this.Cust_ID_TextChanged);
            // 
            // FirstNameCust
            // 
            this.FirstNameCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameCust.Location = new System.Drawing.Point(146, 320);
            this.FirstNameCust.Name = "FirstNameCust";
            this.FirstNameCust.Size = new System.Drawing.Size(76, 21);
            this.FirstNameCust.TabIndex = 11;
            // 
            // LastName_Cust
            // 
            this.LastName_Cust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName_Cust.Location = new System.Drawing.Point(228, 320);
            this.LastName_Cust.Name = "LastName_Cust";
            this.LastName_Cust.Size = new System.Drawing.Size(68, 21);
            this.LastName_Cust.TabIndex = 12;
            // 
            // AddressCust
            // 
            this.AddressCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressCust.Location = new System.Drawing.Point(302, 320);
            this.AddressCust.Name = "AddressCust";
            this.AddressCust.Size = new System.Drawing.Size(113, 21);
            this.AddressCust.TabIndex = 13;
            this.AddressCust.TextChanged += new System.EventHandler(this.AddressCust_TextChanged);
            // 
            // PhoneCust
            // 
            this.PhoneCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneCust.Location = new System.Drawing.Point(421, 320);
            this.PhoneCust.Name = "PhoneCust";
            this.PhoneCust.Size = new System.Drawing.Size(91, 21);
            this.PhoneCust.TabIndex = 14;
            // 
            // IssueMovieDate
            // 
            this.IssueMovieDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueMovieDate.Location = new System.Drawing.Point(518, 320);
            this.IssueMovieDate.Name = "IssueMovieDate";
            this.IssueMovieDate.Size = new System.Drawing.Size(100, 21);
            this.IssueMovieDate.TabIndex = 15;
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReleaseDate.Location = new System.Drawing.Point(551, 388);
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.Size = new System.Drawing.Size(158, 21);
            this.ReleaseDate.TabIndex = 20;
            // 
            // RentalCostMovie
            // 
            this.RentalCostMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalCostMovie.Location = new System.Drawing.Point(463, 388);
            this.RentalCostMovie.Name = "RentalCostMovie";
            this.RentalCostMovie.Size = new System.Drawing.Size(82, 21);
            this.RentalCostMovie.TabIndex = 19;
            // 
            // GenreMovie
            // 
            this.GenreMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreMovie.Location = new System.Drawing.Point(320, 388);
            this.GenreMovie.Name = "GenreMovie";
            this.GenreMovie.Size = new System.Drawing.Size(136, 21);
            this.GenreMovie.TabIndex = 18;
            // 
            // TitleMovie
            // 
            this.TitleMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleMovie.Location = new System.Drawing.Point(140, 388);
            this.TitleMovie.Name = "TitleMovie";
            this.TitleMovie.Size = new System.Drawing.Size(174, 21);
            this.TitleMovie.TabIndex = 17;
            // 
            // MovieID
            // 
            this.MovieID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieID.Location = new System.Drawing.Point(97, 388);
            this.MovieID.Name = "MovieID";
            this.MovieID.Size = new System.Drawing.Size(36, 21);
            this.MovieID.TabIndex = 16;
            // 
            // ReturnedDate
            // 
            this.ReturnedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnedDate.Location = new System.Drawing.Point(630, 320);
            this.ReturnedDate.Name = "ReturnedDate";
            this.ReturnedDate.Size = new System.Drawing.Size(100, 21);
            this.ReturnedDate.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(112, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(149, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "FirstName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Olive;
            this.label3.Location = new System.Drawing.Point(228, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "LastName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Olive;
            this.label4.Location = new System.Drawing.Point(317, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Olive;
            this.label5.Location = new System.Drawing.Point(440, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Olive;
            this.label6.Location = new System.Drawing.Point(533, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "IssueDate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Olive;
            this.label7.Location = new System.Drawing.Point(650, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "ReturnDate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Olive;
            this.label8.Location = new System.Drawing.Point(112, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Olive;
            this.label9.Location = new System.Drawing.Point(197, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 15);
            this.label9.TabIndex = 30;
            this.label9.Text = "Title";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Olive;
            this.label10.Location = new System.Drawing.Point(362, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 15);
            this.label10.TabIndex = 31;
            this.label10.Text = "Genre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Olive;
            this.label11.Location = new System.Drawing.Point(465, 362);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 15);
            this.label11.TabIndex = 32;
            this.label11.Text = "Rental Cost";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Olive;
            this.label12.Location = new System.Drawing.Point(582, 362);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 15);
            this.label12.TabIndex = 33;
            this.label12.Text = "Release Date";
            // 
            // MoviesTab
            // 
            this.MoviesTab.Controls.Add(this.moviesGrid);
            this.MoviesTab.Location = new System.Drawing.Point(4, 27);
            this.MoviesTab.Name = "MoviesTab";
            this.MoviesTab.Padding = new System.Windows.Forms.Padding(3);
            this.MoviesTab.Size = new System.Drawing.Size(768, 195);
            this.MoviesTab.TabIndex = 1;
            this.MoviesTab.Text = "Movies";
            this.MoviesTab.UseVisualStyleBackColor = true;
            // 
            // moviesGrid
            // 
            this.moviesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.moviesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moviesGrid.Location = new System.Drawing.Point(-4, 6);
            this.moviesGrid.Name = "moviesGrid";
            this.moviesGrid.Size = new System.Drawing.Size(755, 183);
            this.moviesGrid.TabIndex = 1;
            this.moviesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.moviesGrid_CellContentClick);
            // 
            // customersTab
            // 
            this.customersTab.Controls.Add(this.CustGrid);
            this.customersTab.Location = new System.Drawing.Point(4, 27);
            this.customersTab.Name = "customersTab";
            this.customersTab.Padding = new System.Windows.Forms.Padding(3);
            this.customersTab.Size = new System.Drawing.Size(768, 195);
            this.customersTab.TabIndex = 0;
            this.customersTab.Text = "Customers";
            this.customersTab.UseVisualStyleBackColor = true;
            // 
            // CustGrid
            // 
            this.CustGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustGrid.Location = new System.Drawing.Point(6, 3);
            this.CustGrid.Name = "CustGrid";
            this.CustGrid.Size = new System.Drawing.Size(762, 186);
            this.CustGrid.TabIndex = 1;
            this.CustGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustGrid_CellContentClick);
            // 
            // tabControl1_movisRenatl
            // 
            this.tabControl1_movisRenatl.Controls.Add(this.customersTab);
            this.tabControl1_movisRenatl.Controls.Add(this.MoviesTab);
            this.tabControl1_movisRenatl.Controls.Add(this.RenatlTAb);
            this.tabControl1_movisRenatl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1_movisRenatl.Location = new System.Drawing.Point(12, 12);
            this.tabControl1_movisRenatl.Name = "tabControl1_movisRenatl";
            this.tabControl1_movisRenatl.SelectedIndex = 0;
            this.tabControl1_movisRenatl.Size = new System.Drawing.Size(776, 226);
            this.tabControl1_movisRenatl.TabIndex = 0;
            // 
            // RenatlTAb
            // 
            this.RenatlTAb.Controls.Add(this.RentalGrid);
            this.RenatlTAb.Location = new System.Drawing.Point(4, 27);
            this.RenatlTAb.Name = "RenatlTAb";
            this.RenatlTAb.Padding = new System.Windows.Forms.Padding(3);
            this.RenatlTAb.Size = new System.Drawing.Size(768, 195);
            this.RenatlTAb.TabIndex = 2;
            this.RenatlTAb.Text = "Rental";
            this.RenatlTAb.UseVisualStyleBackColor = true;
            // 
            // RentalGrid
            // 
            this.RentalGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RentalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentalGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RentalGrid.Location = new System.Drawing.Point(3, 3);
            this.RentalGrid.Name = "RentalGrid";
            this.RentalGrid.Size = new System.Drawing.Size(762, 189);
            this.RentalGrid.TabIndex = 0;
            this.RentalGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RentalGrid_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(807, 487);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReturnedDate);
            this.Controls.Add(this.ReleaseDate);
            this.Controls.Add(this.RentalCostMovie);
            this.Controls.Add(this.GenreMovie);
            this.Controls.Add(this.TitleMovie);
            this.Controls.Add(this.MovieID);
            this.Controls.Add(this.IssueMovieDate);
            this.Controls.Add(this.PhoneCust);
            this.Controls.Add(this.AddressCust);
            this.Controls.Add(this.LastName_Cust);
            this.Controls.Add(this.FirstNameCust);
            this.Controls.Add(this.Cust_ID);
            this.Controls.Add(this.button_updatemovie);
            this.Controls.Add(this.button_Deletemovie);
            this.Controls.Add(this.button_Addmovie);
            this.Controls.Add(this.button_AddCustomer);
            this.Controls.Add(this.tabRadio);
            this.Controls.Add(this.returnMovie);
            this.Controls.Add(this.issueMovie);
            this.Controls.Add(this.deleteCust);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.tabControl1_movisRenatl);
            this.Name = "Form1";
            this.Text = "Movies Rental System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabRadio.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.MoviesTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.moviesGrid)).EndInit();
            this.customersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustGrid)).EndInit();
            this.tabControl1_movisRenatl.ResumeLayout(false);
            this.RenatlTAb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RentalGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteCust;
        private System.Windows.Forms.Button issueMovie;
        private System.Windows.Forms.Button returnMovie;
        private System.Windows.Forms.TabControl tabRadio;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton OutRented;
        private System.Windows.Forms.RadioButton radioButton_Allrented;
        private System.Windows.Forms.Button button_AddCustomer;
        private System.Windows.Forms.Button button_Addmovie;
        private System.Windows.Forms.Button button_Deletemovie;
        private System.Windows.Forms.Button button_updatemovie;
        private System.Windows.Forms.TextBox Cust_ID;
        private System.Windows.Forms.TextBox FirstNameCust;
        private System.Windows.Forms.TextBox LastName_Cust;
        private System.Windows.Forms.TextBox AddressCust;
        private System.Windows.Forms.TextBox PhoneCust;
        private System.Windows.Forms.TextBox IssueMovieDate;
        private System.Windows.Forms.TextBox ReleaseDate;
        private System.Windows.Forms.TextBox RentalCostMovie;
        private System.Windows.Forms.TextBox GenreMovie;
        private System.Windows.Forms.TextBox TitleMovie;
        private System.Windows.Forms.TextBox MovieID;
        private System.Windows.Forms.TextBox ReturnedDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage MoviesTab;
        private System.Windows.Forms.DataGridView moviesGrid;
        private System.Windows.Forms.TabPage customersTab;
        private System.Windows.Forms.DataGridView CustGrid;
        private System.Windows.Forms.TabControl tabControl1_movisRenatl;
        private System.Windows.Forms.TabPage RenatlTAb;
        private System.Windows.Forms.DataGridView RentalGrid;
    }
}

