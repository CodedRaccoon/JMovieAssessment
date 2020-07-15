namespace JMovieAssessment
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
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.btnUpdateCust = new System.Windows.Forms.Button();
            this.btnDeleteCust = new System.Windows.Forms.Button();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.tbxMID = new System.Windows.Forms.TextBox();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.tbxCost = new System.Windows.Forms.TextBox();
            this.tbxRating = new System.Windows.Forms.TextBox();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.MoviesTB = new System.Windows.Forms.TabPage();
            this.CustomerTB = new System.Windows.Forms.TabPage();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.RentalsTB = new System.Windows.Forms.TabPage();
            this.dgvRentals = new System.Windows.Forms.DataGridView();
            this.tbxGenre = new System.Windows.Forms.TextBox();
            this.tbxCopies = new System.Windows.Forms.TextBox();
            this.tbxCID = new System.Windows.Forms.TextBox();
            this.tbxYear = new System.Windows.Forms.TextBox();
            this.tbxPlot = new System.Windows.Forms.TextBox();
            this.tbxLast = new System.Windows.Forms.TextBox();
            this.tbxFirst = new System.Windows.Forms.TextBox();
            this.btnAddCust = new System.Windows.Forms.Button();
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
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.tbxRID = new System.Windows.Forms.TextBox();
            this.lblRID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            this.TabControl.SuspendLayout();
            this.MoviesTB.SuspendLayout();
            this.CustomerTB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.RentalsTB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMovies
            // 
            this.dgvMovies.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovies.Location = new System.Drawing.Point(0, 0);
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.Size = new System.Drawing.Size(914, 318);
            this.dgvMovies.TabIndex = 0;
            this.dgvMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovies_CellClick);
            // 
            // btnUpdateCust
            // 
            this.btnUpdateCust.Location = new System.Drawing.Point(160, 446);
            this.btnUpdateCust.Name = "btnUpdateCust";
            this.btnUpdateCust.Size = new System.Drawing.Size(90, 36);
            this.btnUpdateCust.TabIndex = 2;
            this.btnUpdateCust.Text = "Update Customer";
            this.btnUpdateCust.UseVisualStyleBackColor = true;
            this.btnUpdateCust.Click += new System.EventHandler(this.btnUpdateCust_Click);
            // 
            // btnDeleteCust
            // 
            this.btnDeleteCust.Location = new System.Drawing.Point(260, 446);
            this.btnDeleteCust.Name = "btnDeleteCust";
            this.btnDeleteCust.Size = new System.Drawing.Size(90, 36);
            this.btnDeleteCust.TabIndex = 3;
            this.btnDeleteCust.Text = "Delete Customer";
            this.btnDeleteCust.UseVisualStyleBackColor = true;
            this.btnDeleteCust.Click += new System.EventHandler(this.btnDeleteCust_Click);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(64, 603);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(90, 37);
            this.btnAddMovie.TabIndex = 4;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Location = new System.Drawing.Point(256, 604);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(90, 36);
            this.btnDeleteMovie.TabIndex = 5;
            this.btnDeleteMovie.Text = "Delete Movie";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // tbxMID
            // 
            this.tbxMID.Location = new System.Drawing.Point(265, 577);
            this.tbxMID.Name = "tbxMID";
            this.tbxMID.Size = new System.Drawing.Size(47, 20);
            this.tbxMID.TabIndex = 7;
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(366, 411);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(266, 20);
            this.tbxAddress.TabIndex = 8;
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(65, 523);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(151, 20);
            this.tbxTitle.TabIndex = 9;
            // 
            // tbxCost
            // 
            this.tbxCost.Location = new System.Drawing.Point(160, 577);
            this.tbxCost.Name = "tbxCost";
            this.tbxCost.Size = new System.Drawing.Size(99, 20);
            this.tbxCost.TabIndex = 10;
            // 
            // tbxRating
            // 
            this.tbxRating.Location = new System.Drawing.Point(726, 523);
            this.tbxRating.Name = "tbxRating";
            this.tbxRating.Size = new System.Drawing.Size(86, 20);
            this.tbxRating.TabIndex = 11;
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(638, 411);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(170, 20);
            this.tbxPhone.TabIndex = 12;
            // 
            // TabControl
            // 
            this.TabControl.AccessibleName = "";
            this.TabControl.Controls.Add(this.MoviesTB);
            this.TabControl.Controls.Add(this.CustomerTB);
            this.TabControl.Controls.Add(this.RentalsTB);
            this.TabControl.Location = new System.Drawing.Point(65, 48);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(922, 344);
            this.TabControl.TabIndex = 13;
            // 
            // MoviesTB
            // 
            this.MoviesTB.Controls.Add(this.dgvMovies);
            this.MoviesTB.Location = new System.Drawing.Point(4, 22);
            this.MoviesTB.Name = "MoviesTB";
            this.MoviesTB.Padding = new System.Windows.Forms.Padding(3);
            this.MoviesTB.Size = new System.Drawing.Size(914, 318);
            this.MoviesTB.TabIndex = 0;
            this.MoviesTB.Text = "Movies";
            this.MoviesTB.UseVisualStyleBackColor = true;
            // 
            // CustomerTB
            // 
            this.CustomerTB.Controls.Add(this.dgvCustomer);
            this.CustomerTB.Location = new System.Drawing.Point(4, 22);
            this.CustomerTB.Name = "CustomerTB";
            this.CustomerTB.Padding = new System.Windows.Forms.Padding(3);
            this.CustomerTB.Size = new System.Drawing.Size(914, 318);
            this.CustomerTB.TabIndex = 1;
            this.CustomerTB.Text = "Customers";
            this.CustomerTB.UseVisualStyleBackColor = true;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.Size = new System.Drawing.Size(914, 318);
            this.dgvCustomer.TabIndex = 0;
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick);
            // 
            // RentalsTB
            // 
            this.RentalsTB.Controls.Add(this.dgvRentals);
            this.RentalsTB.Location = new System.Drawing.Point(4, 22);
            this.RentalsTB.Name = "RentalsTB";
            this.RentalsTB.Padding = new System.Windows.Forms.Padding(3);
            this.RentalsTB.Size = new System.Drawing.Size(914, 318);
            this.RentalsTB.TabIndex = 2;
            this.RentalsTB.Text = "Rentals";
            this.RentalsTB.UseVisualStyleBackColor = true;
            // 
            // dgvRentals
            // 
            this.dgvRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentals.Location = new System.Drawing.Point(0, 0);
            this.dgvRentals.Name = "dgvRentals";
            this.dgvRentals.Size = new System.Drawing.Size(914, 318);
            this.dgvRentals.TabIndex = 0;
            this.dgvRentals.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRentals_CellClick);
            // 
            // tbxGenre
            // 
            this.tbxGenre.Location = new System.Drawing.Point(222, 523);
            this.tbxGenre.Name = "tbxGenre";
            this.tbxGenre.Size = new System.Drawing.Size(139, 20);
            this.tbxGenre.TabIndex = 14;
            // 
            // tbxCopies
            // 
            this.tbxCopies.Location = new System.Drawing.Point(64, 577);
            this.tbxCopies.Name = "tbxCopies";
            this.tbxCopies.Size = new System.Drawing.Size(90, 20);
            this.tbxCopies.TabIndex = 15;
            // 
            // tbxCID
            // 
            this.tbxCID.Location = new System.Drawing.Point(814, 411);
            this.tbxCID.Name = "tbxCID";
            this.tbxCID.Size = new System.Drawing.Size(65, 20);
            this.tbxCID.TabIndex = 16;
            // 
            // tbxYear
            // 
            this.tbxYear.Location = new System.Drawing.Point(638, 523);
            this.tbxYear.Name = "tbxYear";
            this.tbxYear.Size = new System.Drawing.Size(82, 20);
            this.tbxYear.TabIndex = 17;
            // 
            // tbxPlot
            // 
            this.tbxPlot.Location = new System.Drawing.Point(366, 523);
            this.tbxPlot.Name = "tbxPlot";
            this.tbxPlot.Size = new System.Drawing.Size(262, 20);
            this.tbxPlot.TabIndex = 18;
            // 
            // tbxLast
            // 
            this.tbxLast.Location = new System.Drawing.Point(221, 411);
            this.tbxLast.Name = "tbxLast";
            this.tbxLast.Size = new System.Drawing.Size(139, 20);
            this.tbxLast.TabIndex = 19;
            // 
            // tbxFirst
            // 
            this.tbxFirst.Location = new System.Drawing.Point(64, 411);
            this.tbxFirst.Name = "tbxFirst";
            this.tbxFirst.Size = new System.Drawing.Size(151, 20);
            this.tbxFirst.TabIndex = 20;
            // 
            // btnAddCust
            // 
            this.btnAddCust.Location = new System.Drawing.Point(64, 446);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(90, 36);
            this.btnAddCust.TabIndex = 21;
            this.btnAddCust.Text = "Add Customer";
            this.btnAddCust.UseVisualStyleBackColor = true;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(635, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Customer Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 507);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Movie Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 507);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Movie Genre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(363, 507);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Movie Plot";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(635, 507);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Year";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(723, 507);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Rating";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(62, 561);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Copies issued";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(157, 561);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Rental Cost";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(262, 561);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Movie ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(811, 395);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Customer ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label14.Location = new System.Drawing.Point(369, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(234, 39);
            this.label14.TabIndex = 35;
            this.label14.Text = "Blockbusters 2.0";
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.Location = new System.Drawing.Point(160, 604);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(90, 36);
            this.btnUpdateMovie.TabIndex = 36;
            this.btnUpdateMovie.Text = "Update Movie";
            this.btnUpdateMovie.UseVisualStyleBackColor = true;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // btnRent
            // 
            this.btnRent.BackColor = System.Drawing.Color.Red;
            this.btnRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRent.Location = new System.Drawing.Point(427, 604);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(90, 36);
            this.btnRent.TabIndex = 37;
            this.btnRent.Text = "Rent Movie";
            this.btnRent.UseVisualStyleBackColor = false;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Lime;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Location = new System.Drawing.Point(523, 604);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(90, 36);
            this.btnReturn.TabIndex = 38;
            this.btnReturn.Text = "Return Movie";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // tbxRID
            // 
            this.tbxRID.Location = new System.Drawing.Point(619, 620);
            this.tbxRID.Name = "tbxRID";
            this.tbxRID.Size = new System.Drawing.Size(56, 20);
            this.tbxRID.TabIndex = 39;
            // 
            // lblRID
            // 
            this.lblRID.AutoSize = true;
            this.lblRID.Location = new System.Drawing.Point(619, 604);
            this.lblRID.Name = "lblRID";
            this.lblRID.Size = new System.Drawing.Size(56, 13);
            this.lblRID.TabIndex = 40;
            this.lblRID.Text = "Rented ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 668);
            this.Controls.Add(this.lblRID);
            this.Controls.Add(this.tbxRID);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.btnUpdateMovie);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
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
            this.Controls.Add(this.btnAddCust);
            this.Controls.Add(this.tbxFirst);
            this.Controls.Add(this.tbxLast);
            this.Controls.Add(this.tbxPlot);
            this.Controls.Add(this.tbxYear);
            this.Controls.Add(this.tbxCID);
            this.Controls.Add(this.tbxCopies);
            this.Controls.Add(this.tbxGenre);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.tbxPhone);
            this.Controls.Add(this.tbxRating);
            this.Controls.Add(this.tbxCost);
            this.Controls.Add(this.tbxTitle);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.tbxMID);
            this.Controls.Add(this.btnDeleteMovie);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.btnDeleteCust);
            this.Controls.Add(this.btnUpdateCust);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.MoviesTB.ResumeLayout(false);
            this.CustomerTB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.RentalsTB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.Button btnUpdateCust;
        private System.Windows.Forms.Button btnDeleteCust;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.TextBox tbxMID;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.TextBox tbxCost;
        private System.Windows.Forms.TextBox tbxRating;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage MoviesTB;
        private System.Windows.Forms.TabPage CustomerTB;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.TabPage RentalsTB;
        private System.Windows.Forms.DataGridView dgvRentals;
        private System.Windows.Forms.TextBox tbxGenre;
        private System.Windows.Forms.TextBox tbxCopies;
        private System.Windows.Forms.TextBox tbxCID;
        private System.Windows.Forms.TextBox tbxYear;
        private System.Windows.Forms.TextBox tbxPlot;
        private System.Windows.Forms.TextBox tbxLast;
        private System.Windows.Forms.TextBox tbxFirst;
        private System.Windows.Forms.Button btnAddCust;
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox tbxRID;
        private System.Windows.Forms.Label lblRID;
    }
}

