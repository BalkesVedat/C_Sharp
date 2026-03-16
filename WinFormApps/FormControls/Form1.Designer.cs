namespace FormControls
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblBookDate = new System.Windows.Forms.Label();
            this.dtpBookDate = new System.Windows.Forms.DateTimePicker();
            this.lbClasses = new System.Windows.Forms.ListBox();
            this.cmbDivision = new System.Windows.Forms.ComboBox();
            this.lblDivision = new System.Windows.Forms.Label();
            this.lblClasses = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.gbScholarship = new System.Windows.Forms.GroupBox();
            this.numAvgScore = new System.Windows.Forms.NumericUpDown();
            this.lblAverageScore = new System.Windows.Forms.Label();
            this.gbHobbies = new System.Windows.Forms.GroupBox();
            this.chkGaming = new System.Windows.Forms.CheckBox();
            this.chkCinema = new System.Windows.Forms.CheckBox();
            this.chkTravel = new System.Windows.Forms.CheckBox();
            this.chkArts = new System.Windows.Forms.CheckBox();
            this.chkMusic = new System.Windows.Forms.CheckBox();
            this.chkSports = new System.Windows.Forms.CheckBox();
            this.chkChess = new System.Windows.Forms.CheckBox();
            this.chkBook = new System.Windows.Forms.CheckBox();
            this.picPhoto = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnClearPicture = new System.Windows.Forms.Button();
            this.pictureSelectionDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rrrrToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentScoresReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentClassesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.honorListReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbGender.SuspendLayout();
            this.gbScholarship.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAvgScore)).BeginInit();
            this.gbHobbies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(99, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(228, 20);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(21, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(21, 52);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 3;
            this.lblSurname.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(99, 49);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(228, 20);
            this.txtSurname.TabIndex = 2;
            // 
            // lblBookDate
            // 
            this.lblBookDate.AutoSize = true;
            this.lblBookDate.Location = new System.Drawing.Point(21, 75);
            this.lblBookDate.Name = "lblBookDate";
            this.lblBookDate.Size = new System.Drawing.Size(58, 13);
            this.lblBookDate.TabIndex = 4;
            this.lblBookDate.Text = "Book Date";
            // 
            // dtpBookDate
            // 
            this.dtpBookDate.CalendarTitleBackColor = System.Drawing.Color.IndianRed;
            this.dtpBookDate.Location = new System.Drawing.Point(99, 75);
            this.dtpBookDate.Name = "dtpBookDate";
            this.dtpBookDate.Size = new System.Drawing.Size(228, 20);
            this.dtpBookDate.TabIndex = 5;
            // 
            // lbClasses
            // 
            this.lbClasses.FormattingEnabled = true;
            this.lbClasses.Items.AddRange(new object[] {
            "Matematik",
            "Edebiyat",
            "İnk. Tarihi",
            "Yabancı Dil",
            "Yazılıma Giriş",
            "Algoritma"});
            this.lbClasses.Location = new System.Drawing.Point(99, 130);
            this.lbClasses.Name = "lbClasses";
            this.lbClasses.Size = new System.Drawing.Size(227, 95);
            this.lbClasses.TabIndex = 6;
            // 
            // cmbDivision
            // 
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Items.AddRange(new object[] {
            "Yazılım Müh.",
            "Makina Müh.",
            "Mimarlık",
            "Tıp",
            "Fen Edebiyat Matematik",
            "İşletme"});
            this.cmbDivision.Location = new System.Drawing.Point(100, 102);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.Size = new System.Drawing.Size(226, 21);
            this.cmbDivision.TabIndex = 7;
            this.cmbDivision.SelectedIndexChanged += new System.EventHandler(this.cmbDivision_SelectedIndexChanged);
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(21, 102);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(44, 13);
            this.lblDivision.TabIndex = 8;
            this.lblDivision.Text = "Division";
            // 
            // lblClasses
            // 
            this.lblClasses.AutoSize = true;
            this.lblClasses.Location = new System.Drawing.Point(22, 130);
            this.lblClasses.Name = "lblClasses";
            this.lblClasses.Size = new System.Drawing.Size(43, 13);
            this.lblClasses.TabIndex = 9;
            this.lblClasses.Text = "Classes";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Checked = true;
            this.rbFemale.Location = new System.Drawing.Point(19, 14);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 10;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            this.rbFemale.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(110, 14);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 11;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            this.rbMale.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(16, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(39, 17);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "%0";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(77, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(45, 17);
            this.radioButton4.TabIndex = 13;
            this.radioButton4.Text = "%50";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(141, 19);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(51, 17);
            this.radioButton5.TabIndex = 14;
            this.radioButton5.Text = "%100";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // gbGender
            // 
            this.gbGender.BackColor = System.Drawing.Color.Transparent;
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.ForeColor = System.Drawing.Color.Black;
            this.gbGender.Location = new System.Drawing.Point(96, 231);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(231, 37);
            this.gbGender.TabIndex = 15;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            this.gbGender.Enter += new System.EventHandler(this.gbGender_Enter);
            // 
            // gbScholarship
            // 
            this.gbScholarship.Controls.Add(this.radioButton4);
            this.gbScholarship.Controls.Add(this.radioButton3);
            this.gbScholarship.Controls.Add(this.radioButton5);
            this.gbScholarship.Location = new System.Drawing.Point(99, 274);
            this.gbScholarship.Name = "gbScholarship";
            this.gbScholarship.Size = new System.Drawing.Size(228, 43);
            this.gbScholarship.TabIndex = 16;
            this.gbScholarship.TabStop = false;
            this.gbScholarship.Text = "Scholarship";
            // 
            // numAvgScore
            // 
            this.numAvgScore.Location = new System.Drawing.Point(100, 324);
            this.numAvgScore.Name = "numAvgScore";
            this.numAvgScore.Size = new System.Drawing.Size(227, 20);
            this.numAvgScore.TabIndex = 17;
            this.numAvgScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAverageScore
            // 
            this.lblAverageScore.AutoSize = true;
            this.lblAverageScore.Location = new System.Drawing.Point(21, 326);
            this.lblAverageScore.Name = "lblAverageScore";
            this.lblAverageScore.Size = new System.Drawing.Size(78, 13);
            this.lblAverageScore.TabIndex = 18;
            this.lblAverageScore.Text = "Average Score";
            // 
            // gbHobbies
            // 
            this.gbHobbies.Controls.Add(this.chkGaming);
            this.gbHobbies.Controls.Add(this.chkCinema);
            this.gbHobbies.Controls.Add(this.chkTravel);
            this.gbHobbies.Controls.Add(this.chkArts);
            this.gbHobbies.Controls.Add(this.chkMusic);
            this.gbHobbies.Controls.Add(this.chkSports);
            this.gbHobbies.Controls.Add(this.chkChess);
            this.gbHobbies.Controls.Add(this.chkBook);
            this.gbHobbies.Location = new System.Drawing.Point(100, 352);
            this.gbHobbies.Name = "gbHobbies";
            this.gbHobbies.Size = new System.Drawing.Size(150, 126);
            this.gbHobbies.TabIndex = 19;
            this.gbHobbies.TabStop = false;
            this.gbHobbies.Text = "Hobbies";
            this.gbHobbies.Enter += new System.EventHandler(this.gbHobbies_Enter);
            // 
            // chkGaming
            // 
            this.chkGaming.AutoSize = true;
            this.chkGaming.Location = new System.Drawing.Point(81, 94);
            this.chkGaming.Name = "chkGaming";
            this.chkGaming.Size = new System.Drawing.Size(62, 17);
            this.chkGaming.TabIndex = 13;
            this.chkGaming.Text = "Gaming";
            this.chkGaming.UseVisualStyleBackColor = true;
            // 
            // chkCinema
            // 
            this.chkCinema.AutoSize = true;
            this.chkCinema.Location = new System.Drawing.Point(6, 94);
            this.chkCinema.Name = "chkCinema";
            this.chkCinema.Size = new System.Drawing.Size(61, 17);
            this.chkCinema.TabIndex = 12;
            this.chkCinema.Text = "Cinema";
            this.chkCinema.UseVisualStyleBackColor = true;
            // 
            // chkTravel
            // 
            this.chkTravel.AutoSize = true;
            this.chkTravel.Location = new System.Drawing.Point(81, 71);
            this.chkTravel.Name = "chkTravel";
            this.chkTravel.Size = new System.Drawing.Size(56, 17);
            this.chkTravel.TabIndex = 8;
            this.chkTravel.Text = "Travel";
            this.chkTravel.UseVisualStyleBackColor = true;
            // 
            // chkArts
            // 
            this.chkArts.AutoSize = true;
            this.chkArts.Location = new System.Drawing.Point(81, 48);
            this.chkArts.Name = "chkArts";
            this.chkArts.Size = new System.Drawing.Size(44, 17);
            this.chkArts.TabIndex = 7;
            this.chkArts.Text = "Arts";
            this.chkArts.UseVisualStyleBackColor = true;
            // 
            // chkMusic
            // 
            this.chkMusic.AutoSize = true;
            this.chkMusic.Location = new System.Drawing.Point(81, 26);
            this.chkMusic.Name = "chkMusic";
            this.chkMusic.Size = new System.Drawing.Size(54, 17);
            this.chkMusic.TabIndex = 6;
            this.chkMusic.Text = "Music";
            this.chkMusic.UseVisualStyleBackColor = true;
            // 
            // chkSports
            // 
            this.chkSports.AutoSize = true;
            this.chkSports.Location = new System.Drawing.Point(6, 71);
            this.chkSports.Name = "chkSports";
            this.chkSports.Size = new System.Drawing.Size(56, 17);
            this.chkSports.TabIndex = 2;
            this.chkSports.Text = "Sports";
            this.chkSports.UseVisualStyleBackColor = true;
            this.chkSports.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chkChess
            // 
            this.chkChess.AutoSize = true;
            this.chkChess.Location = new System.Drawing.Point(6, 48);
            this.chkChess.Name = "chkChess";
            this.chkChess.Size = new System.Drawing.Size(55, 17);
            this.chkChess.TabIndex = 1;
            this.chkChess.Text = "Chess";
            this.chkChess.UseVisualStyleBackColor = true;
            // 
            // chkBook
            // 
            this.chkBook.AutoSize = true;
            this.chkBook.Location = new System.Drawing.Point(6, 26);
            this.chkBook.Name = "chkBook";
            this.chkBook.Size = new System.Drawing.Size(51, 17);
            this.chkBook.TabIndex = 0;
            this.chkBook.Text = "Book";
            this.chkBook.UseVisualStyleBackColor = true;
            this.chkBook.CheckedChanged += new System.EventHandler(this.chkBook_CheckedChanged);
            // 
            // picPhoto
            // 
            this.picPhoto.Image = ((System.Drawing.Image)(resources.GetObject("picPhoto.Image")));
            this.picPhoto.Location = new System.Drawing.Point(503, 19);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(240, 180);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhoto.TabIndex = 20;
            this.picPhoto.TabStop = false;
            this.picPhoto.Click += new System.EventHandler(this.picPhoto_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(544, 205);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(72, 29);
            this.btnBrowse.TabIndex = 21;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnClearPicture
            // 
            this.btnClearPicture.Location = new System.Drawing.Point(622, 205);
            this.btnClearPicture.Name = "btnClearPicture";
            this.btnClearPicture.Size = new System.Drawing.Size(82, 29);
            this.btnClearPicture.TabIndex = 22;
            this.btnClearPicture.Text = "Clear Picture";
            this.btnClearPicture.UseVisualStyleBackColor = true;
            this.btnClearPicture.Click += new System.EventHandler(this.btnClearPicture_Click);
            // 
            // pictureSelectionDialog
            // 
            this.pictureSelectionDialog.FileName = "openFileDialog1";
            this.pictureSelectionDialog.Filter = "JPG Image (*.jpg)|*.jpg|*.JPEG|*.jpeg|*.GIF|*.gif|*.BMP|*.bmp|PNG Image|*.png";
            this.pictureSelectionDialog.Title = "Select Picture";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(425, 262);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 24;
            this.lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(503, 259);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.Size = new System.Drawing.Size(240, 37);
            this.txtAddress.TabIndex = 23;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.operationsToolStripMenuItem,
            this.reportingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(826, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.printToolStripMenuItem,
            this.rrrrToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // rrrrToolStripMenuItem
            // 
            this.rrrrToolStripMenuItem.Name = "rrrrToolStripMenuItem";
            this.rrrrToolStripMenuItem.Size = new System.Drawing.Size(177, 6);
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.editStudentToolStripMenuItem,
            this.deleteStudentToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.operationsToolStripMenuItem.Text = "O&perations";
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addStudentToolStripMenuItem.Text = "&Add Student";
            // 
            // editStudentToolStripMenuItem
            // 
            this.editStudentToolStripMenuItem.Name = "editStudentToolStripMenuItem";
            this.editStudentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editStudentToolStripMenuItem.Text = "&Edit Student";
            // 
            // deleteStudentToolStripMenuItem
            // 
            this.deleteStudentToolStripMenuItem.Name = "deleteStudentToolStripMenuItem";
            this.deleteStudentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteStudentToolStripMenuItem.Text = "&Delete Student";
            // 
            // reportingToolStripMenuItem
            // 
            this.reportingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentScoresReportToolStripMenuItem,
            this.studentClassesReportToolStripMenuItem,
            this.honorListReportToolStripMenuItem});
            this.reportingToolStripMenuItem.Name = "reportingToolStripMenuItem";
            this.reportingToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.reportingToolStripMenuItem.Text = "Reporting";
            // 
            // studentScoresReportToolStripMenuItem
            // 
            this.studentScoresReportToolStripMenuItem.Name = "studentScoresReportToolStripMenuItem";
            this.studentScoresReportToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.studentScoresReportToolStripMenuItem.Text = "Student Scores Report";
            // 
            // studentClassesReportToolStripMenuItem
            // 
            this.studentClassesReportToolStripMenuItem.Name = "studentClassesReportToolStripMenuItem";
            this.studentClassesReportToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.studentClassesReportToolStripMenuItem.Text = "Student Classes Report";
            // 
            // honorListReportToolStripMenuItem
            // 
            this.honorListReportToolStripMenuItem.Name = "honorListReportToolStripMenuItem";
            this.honorListReportToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.honorListReportToolStripMenuItem.Text = "Honor List Report";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(564, 324);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 55);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 490);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnClearPicture);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.picPhoto);
            this.Controls.Add(this.gbHobbies);
            this.Controls.Add(this.lblAverageScore);
            this.Controls.Add(this.numAvgScore);
            this.Controls.Add(this.gbScholarship);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.lblClasses);
            this.Controls.Add(this.lblDivision);
            this.Controls.Add(this.cmbDivision);
            this.Controls.Add(this.lbClasses);
            this.Controls.Add(this.dtpBookDate);
            this.Controls.Add(this.lblBookDate);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Form Controls";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.gbScholarship.ResumeLayout(false);
            this.gbScholarship.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAvgScore)).EndInit();
            this.gbHobbies.ResumeLayout(false);
            this.gbHobbies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblBookDate;
        private System.Windows.Forms.DateTimePicker dtpBookDate;
        private System.Windows.Forms.ListBox lbClasses;
        private System.Windows.Forms.ComboBox cmbDivision;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Label lblClasses;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.GroupBox gbScholarship;
        private System.Windows.Forms.NumericUpDown numAvgScore;
        private System.Windows.Forms.Label lblAverageScore;
        private System.Windows.Forms.GroupBox gbHobbies;
        private System.Windows.Forms.CheckBox chkBook;
        private System.Windows.Forms.CheckBox chkGaming;
        private System.Windows.Forms.CheckBox chkCinema;
        private System.Windows.Forms.CheckBox chkTravel;
        private System.Windows.Forms.CheckBox chkArts;
        private System.Windows.Forms.CheckBox chkMusic;
        private System.Windows.Forms.CheckBox chkSports;
        private System.Windows.Forms.CheckBox chkChess;
        private System.Windows.Forms.PictureBox picPhoto;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnClearPicture;
        private System.Windows.Forms.OpenFileDialog pictureSelectionDialog;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator rrrrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentScoresReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentClassesReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem honorListReportToolStripMenuItem;
        private System.Windows.Forms.Button btnSave;
    }
}

