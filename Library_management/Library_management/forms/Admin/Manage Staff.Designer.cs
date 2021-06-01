
namespace Library_management
{
    partial class ManageStaff
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
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions7 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStaff));
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions8 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions9 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.FindBtn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDown = new System.Windows.Forms.Button();
            this.gvListStaff = new System.Windows.Forms.DataGridView();
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.genderBox = new System.Windows.Forms.GroupBox();
            this.femaleRaBtn = new System.Windows.Forms.RadioButton();
            this.maleRaBtn = new System.Windows.Forms.RadioButton();
            this.birthPicker = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.upImgBtn = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.lbPicture = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbBirthdate = new System.Windows.Forms.Label();
            this.lbLname = new System.Windows.Forms.Label();
            this.lbFname = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rdBtnDelivery = new System.Windows.Forms.RadioButton();
            this.rdBtnArrange = new System.Windows.Forms.RadioButton();
            this.rdBtnManage = new System.Windows.Forms.RadioButton();
            this.RoleBox = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvListStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.genderBox.SuspendLayout();
            this.RoleBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.FindBtn);
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.lblStaffID);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 115);
            this.panel1.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(658, 76);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(152, 29);
            this.txtSearch.TabIndex = 92;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Navy;
            this.searchBtn.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.Magenta;
            this.searchBtn.Location = new System.Drawing.Point(813, 74);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(82, 32);
            this.searchBtn.TabIndex = 93;
            this.searchBtn.Text = "Find";
            this.searchBtn.UseVisualStyleBackColor = false;
            // 
            // FindBtn
            // 
            this.FindBtn.BackColor = System.Drawing.Color.LimeGreen;
            this.FindBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindBtn.ForeColor = System.Drawing.Color.AliceBlue;
            this.FindBtn.Location = new System.Drawing.Point(268, 72);
            this.FindBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FindBtn.Name = "FindBtn";
            this.FindBtn.Size = new System.Drawing.Size(92, 36);
            this.FindBtn.TabIndex = 90;
            this.FindBtn.Text = "Find";
            this.FindBtn.UseVisualStyleBackColor = false;
            this.FindBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(263, 24);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(296, 30);
            this.title.TabIndex = 3;
            this.title.Text = "MANAGE STAFF LIBRARY";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtId.Location = new System.Drawing.Point(116, 80);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(149, 27);
            this.txtId.TabIndex = 89;
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblStaffID.ForeColor = System.Drawing.Color.Transparent;
            this.lblStaffID.Location = new System.Drawing.Point(51, 82);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(67, 21);
            this.lblStaffID.TabIndex = 88;
            this.lblStaffID.Text = "Staff ID";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Black;
            this.closeBtn.ForeColor = System.Drawing.Color.Red;
            this.closeBtn.Location = new System.Drawing.Point(899, 24);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 24);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "❌";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Purple;
            this.panel4.Location = new System.Drawing.Point(105, 352);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(206, 2);
            this.panel4.TabIndex = 146;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Purple;
            this.panel3.Location = new System.Drawing.Point(105, 320);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(172, 2);
            this.panel3.TabIndex = 145;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Purple;
            this.panel2.Location = new System.Drawing.Point(105, 186);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 2);
            this.panel2.TabIndex = 144;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Purple;
            this.panel5.Location = new System.Drawing.Point(105, 149);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(150, 2);
            this.panel5.TabIndex = 143;
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.Aqua;
            this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDown.Location = new System.Drawing.Point(197, 550);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(81, 23);
            this.btnDown.TabIndex = 142;
            this.btnDown.Text = "DOWNLOAD";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // gvListStaff
            // 
            this.gvListStaff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvListStaff.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gvListStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListStaff.Location = new System.Drawing.Point(453, 126);
            this.gvListStaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gvListStaff.Name = "gvListStaff";
            this.gvListStaff.RowHeadersWidth = 102;
            this.gvListStaff.RowTemplate.Height = 80;
            this.gvListStaff.Size = new System.Drawing.Size(500, 447);
            this.gvListStaff.TabIndex = 141;
            this.gvListStaff.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvListStaff_CellDoubleClick);
            // 
            // Avatar
            // 
            this.Avatar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Avatar.Location = new System.Drawing.Point(104, 358);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(174, 186);
            this.Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Avatar.TabIndex = 138;
            this.Avatar.TabStop = false;
            // 
            // genderBox
            // 
            this.genderBox.Controls.Add(this.femaleRaBtn);
            this.genderBox.Controls.Add(this.maleRaBtn);
            this.genderBox.Location = new System.Drawing.Point(105, 239);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(206, 44);
            this.genderBox.TabIndex = 137;
            this.genderBox.TabStop = false;
            this.genderBox.Text = "gender";
            // 
            // femaleRaBtn
            // 
            this.femaleRaBtn.AutoSize = true;
            this.femaleRaBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.femaleRaBtn.Location = new System.Drawing.Point(121, 11);
            this.femaleRaBtn.Name = "femaleRaBtn";
            this.femaleRaBtn.Size = new System.Drawing.Size(82, 25);
            this.femaleRaBtn.TabIndex = 1;
            this.femaleRaBtn.TabStop = true;
            this.femaleRaBtn.Text = "female";
            this.femaleRaBtn.UseVisualStyleBackColor = true;
            // 
            // maleRaBtn
            // 
            this.maleRaBtn.AutoSize = true;
            this.maleRaBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.maleRaBtn.Location = new System.Drawing.Point(44, 12);
            this.maleRaBtn.Name = "maleRaBtn";
            this.maleRaBtn.Size = new System.Drawing.Size(67, 25);
            this.maleRaBtn.TabIndex = 0;
            this.maleRaBtn.TabStop = true;
            this.maleRaBtn.Text = "male";
            this.maleRaBtn.UseVisualStyleBackColor = true;
            // 
            // birthPicker
            // 
            this.birthPicker.CalendarForeColor = System.Drawing.SystemColors.ButtonFace;
            this.birthPicker.CalendarMonthBackground = System.Drawing.Color.DarkMagenta;
            this.birthPicker.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonFace;
            this.birthPicker.Location = new System.Drawing.Point(105, 214);
            this.birthPicker.Name = "birthPicker";
            this.birthPicker.Size = new System.Drawing.Size(184, 22);
            this.birthPicker.TabIndex = 136;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAddress.Location = new System.Drawing.Point(105, 327);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(209, 20);
            this.txtAddress.TabIndex = 135;
            // 
            // upImgBtn
            // 
            this.upImgBtn.BackColor = System.Drawing.Color.Yellow;
            this.upImgBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upImgBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.upImgBtn.Location = new System.Drawing.Point(104, 550);
            this.upImgBtn.Name = "upImgBtn";
            this.upImgBtn.Size = new System.Drawing.Size(87, 23);
            this.upImgBtn.TabIndex = 139;
            this.upImgBtn.Text = "UPLOAD";
            this.upImgBtn.UseVisualStyleBackColor = false;
            this.upImgBtn.Click += new System.EventHandler(this.upImgBtn_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtPhone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPhone.Location = new System.Drawing.Point(105, 297);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(173, 20);
            this.txtPhone.TabIndex = 134;
            // 
            // txtLname
            // 
            this.txtLname.BackColor = System.Drawing.Color.White;
            this.txtLname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLname.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtLname.ForeColor = System.Drawing.Color.Black;
            this.txtLname.Location = new System.Drawing.Point(105, 162);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(183, 20);
            this.txtLname.TabIndex = 133;
            // 
            // txtFname
            // 
            this.txtFname.BackColor = System.Drawing.Color.White;
            this.txtFname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFname.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtFname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtFname.Location = new System.Drawing.Point(105, 124);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(150, 20);
            this.txtFname.TabIndex = 132;
            // 
            // lbPicture
            // 
            this.lbPicture.AutoSize = true;
            this.lbPicture.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbPicture.Location = new System.Drawing.Point(31, 376);
            this.lbPicture.Name = "lbPicture";
            this.lbPicture.Size = new System.Drawing.Size(64, 21);
            this.lbPicture.TabIndex = 131;
            this.lbPicture.Text = "Picture";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbGender.Location = new System.Drawing.Point(16, 249);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(70, 21);
            this.lbGender.TabIndex = 128;
            this.lbGender.Text = "Gender";
            // 
            // lbBirthdate
            // 
            this.lbBirthdate.AutoSize = true;
            this.lbBirthdate.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbBirthdate.Location = new System.Drawing.Point(16, 214);
            this.lbBirthdate.Name = "lbBirthdate";
            this.lbBirthdate.Size = new System.Drawing.Size(74, 21);
            this.lbBirthdate.TabIndex = 127;
            this.lbBirthdate.Text = "Birthday";
            // 
            // lbLname
            // 
            this.lbLname.AutoSize = true;
            this.lbLname.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbLname.Location = new System.Drawing.Point(3, 162);
            this.lbLname.Name = "lbLname";
            this.lbLname.Size = new System.Drawing.Size(93, 21);
            this.lbLname.TabIndex = 126;
            this.lbLname.Text = "Last Name";
            // 
            // lbFname
            // 
            this.lbFname.AutoSize = true;
            this.lbFname.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbFname.Location = new System.Drawing.Point(6, 126);
            this.lbFname.Name = "lbFname";
            this.lbFname.Size = new System.Drawing.Size(91, 21);
            this.lbFname.TabIndex = 125;
            this.lbFname.Text = "First Name";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbAddress.Location = new System.Drawing.Point(22, 331);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(72, 21);
            this.lbAddress.TabIndex = 130;
            this.lbAddress.Text = "Address";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lbPhone.Location = new System.Drawing.Point(34, 297);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(59, 21);
            this.lbPhone.TabIndex = 129;
            this.lbPhone.Text = "Phone";
            // 
            // windowsUIButtonPanel1
            // 
            this.windowsUIButtonPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            windowsUIButtonImageOptions7.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("windowsUIButtonImageOptions7.SvgImage")));
            windowsUIButtonImageOptions8.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("windowsUIButtonImageOptions8.SvgImage")));
            windowsUIButtonImageOptions9.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("windowsUIButtonImageOptions9.SvgImage")));
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("ADD", true, windowsUIButtonImageOptions7, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("UPDATE", true, windowsUIButtonImageOptions8, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("REMOVE", true, windowsUIButtonImageOptions9, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.windowsUIButtonPanel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.windowsUIButtonPanel1.Location = new System.Drawing.Point(-44, 577);
            this.windowsUIButtonPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.Size = new System.Drawing.Size(468, 76);
            this.windowsUIButtonPanel1.TabIndex = 147;
            this.windowsUIButtonPanel1.Text = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanel1_ButtonClick);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel6.Location = new System.Drawing.Point(316, 577);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(646, 76);
            this.panel6.TabIndex = 148;
            // 
            // rdBtnDelivery
            // 
            this.rdBtnDelivery.AutoSize = true;
            this.rdBtnDelivery.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnDelivery.Location = new System.Drawing.Point(69, 9);
            this.rdBtnDelivery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdBtnDelivery.Name = "rdBtnDelivery";
            this.rdBtnDelivery.Size = new System.Drawing.Size(88, 24);
            this.rdBtnDelivery.TabIndex = 149;
            this.rdBtnDelivery.TabStop = true;
            this.rdBtnDelivery.Text = "Manager";
            this.rdBtnDelivery.UseVisualStyleBackColor = true;
            // 
            // rdBtnArrange
            // 
            this.rdBtnArrange.AutoSize = true;
            this.rdBtnArrange.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnArrange.Location = new System.Drawing.Point(69, 28);
            this.rdBtnArrange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdBtnArrange.Name = "rdBtnArrange";
            this.rdBtnArrange.Size = new System.Drawing.Size(81, 24);
            this.rdBtnArrange.TabIndex = 150;
            this.rdBtnArrange.TabStop = true;
            this.rdBtnArrange.Text = "Delivery";
            this.rdBtnArrange.UseVisualStyleBackColor = true;
            // 
            // rdBtnManage
            // 
            this.rdBtnManage.AutoSize = true;
            this.rdBtnManage.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnManage.Location = new System.Drawing.Point(69, 50);
            this.rdBtnManage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdBtnManage.Name = "rdBtnManage";
            this.rdBtnManage.Size = new System.Drawing.Size(86, 24);
            this.rdBtnManage.TabIndex = 151;
            this.rdBtnManage.TabStop = true;
            this.rdBtnManage.Text = "Arranger";
            this.rdBtnManage.UseVisualStyleBackColor = true;
            // 
            // RoleBox
            // 
            this.RoleBox.Controls.Add(this.rdBtnArrange);
            this.RoleBox.Controls.Add(this.rdBtnManage);
            this.RoleBox.Controls.Add(this.rdBtnDelivery);
            this.RoleBox.Location = new System.Drawing.Point(296, 376);
            this.RoleBox.Name = "RoleBox";
            this.RoleBox.Size = new System.Drawing.Size(152, 78);
            this.RoleBox.TabIndex = 152;
            this.RoleBox.TabStop = false;
            this.RoleBox.Text = "Working as";
            // 
            // ManageStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(960, 653);
            this.Controls.Add(this.gvListStaff);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.Avatar);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.birthPicker);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.upImgBtn);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.lbPicture);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbBirthdate);
            this.Controls.Add(this.lbLname);
            this.Controls.Add(this.lbFname);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.windowsUIButtonPanel1);
            this.Controls.Add(this.RoleBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManageStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Staff";
            this.Load += new System.EventHandler(this.ManageStaff_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvListStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.genderBox.ResumeLayout(false);
            this.genderBox.PerformLayout();
            this.RoleBox.ResumeLayout(false);
            this.RoleBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button FindBtn;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.DataGridView gvListStaff;
        private System.Windows.Forms.PictureBox Avatar;
        private System.Windows.Forms.GroupBox genderBox;
        private System.Windows.Forms.RadioButton femaleRaBtn;
        private System.Windows.Forms.RadioButton maleRaBtn;
        private System.Windows.Forms.DateTimePicker birthPicker;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button upImgBtn;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label lbPicture;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbBirthdate;
        private System.Windows.Forms.Label lbLname;
        private System.Windows.Forms.Label lbFname;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbPhone;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.RadioButton rdBtnDelivery;
        private System.Windows.Forms.RadioButton rdBtnArrange;
        private System.Windows.Forms.RadioButton rdBtnManage;
        private System.Windows.Forms.GroupBox RoleBox;
    }
}