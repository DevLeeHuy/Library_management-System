
namespace Library_management.forms.Book
{
    partial class processReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(processReturnBook));
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.txtIDBook = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNameBook = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.chuY = new System.Windows.Forms.Label();
            this.ckDamage = new System.Windows.Forms.CheckBox();
            this.ckLost = new System.Windows.Forms.CheckBox();
            this.gvReturn = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtRid = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 117);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(122, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "MANAGE PROCESS RETURN BOOK";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Black;
            this.closeBtn.ForeColor = System.Drawing.Color.Red;
            this.closeBtn.Location = new System.Drawing.Point(550, 20);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 24);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "❌";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // txtIDBook
            // 
            this.txtIDBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDBook.Enabled = false;
            this.txtIDBook.ForeColor = System.Drawing.Color.Silver;
            this.txtIDBook.Location = new System.Drawing.Point(406, 246);
            this.txtIDBook.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDBook.Name = "txtIDBook";
            this.txtIDBook.Size = new System.Drawing.Size(122, 13);
            this.txtIDBook.TabIndex = 2;
            this.txtIDBook.Text = "ID Book";
            this.txtIDBook.TextChanged += new System.EventHandler(this.txtIDBook_TextChanged);
            this.txtIDBook.Enter += new System.EventHandler(this.txtIDBook_Enter);
            this.txtIDBook.Leave += new System.EventHandler(this.txtIDBook_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(399, 265);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(139, 2);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(399, 289);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(139, 2);
            this.panel3.TabIndex = 5;
            // 
            // txtNameBook
            // 
            this.txtNameBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameBook.Enabled = false;
            this.txtNameBook.ForeColor = System.Drawing.Color.Silver;
            this.txtNameBook.Location = new System.Drawing.Point(406, 271);
            this.txtNameBook.Margin = new System.Windows.Forms.Padding(2);
            this.txtNameBook.Name = "txtNameBook";
            this.txtNameBook.Size = new System.Drawing.Size(122, 13);
            this.txtNameBook.TabIndex = 4;
            this.txtNameBook.Text = "Name of Book";
            this.txtNameBook.Enter += new System.EventHandler(this.txtNameBook_Enter);
            this.txtNameBook.Leave += new System.EventHandler(this.txtNameBook_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(433, 175);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // windowsUIButtonPanel1
            // 
            this.windowsUIButtonPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            windowsUIButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("windowsUIButtonImageOptions1.SvgImage")));
            windowsUIButtonImageOptions2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("windowsUIButtonImageOptions2.SvgImage")));
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("CONFIRM", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("CANCEL", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.windowsUIButtonPanel1.ForeColor = System.Drawing.Color.SeaShell;
            this.windowsUIButtonPanel1.Location = new System.Drawing.Point(324, 440);
            this.windowsUIButtonPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.Size = new System.Drawing.Size(299, 62);
            this.windowsUIButtonPanel1.TabIndex = 10;
            this.windowsUIButtonPanel1.Text = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanel1_ButtonClick);
            // 
            // chuY
            // 
            this.chuY.AutoSize = true;
            this.chuY.Location = new System.Drawing.Point(382, 416);
            this.chuY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chuY.Name = "chuY";
            this.chuY.Size = new System.Drawing.Size(178, 13);
            this.chuY.TabIndex = 11;
            this.chuY.Text = "📌User return books late always fine";
            // 
            // ckDamage
            // 
            this.ckDamage.AutoSize = true;
            this.ckDamage.Location = new System.Drawing.Point(413, 308);
            this.ckDamage.Margin = new System.Windows.Forms.Padding(2);
            this.ckDamage.Name = "ckDamage";
            this.ckDamage.Size = new System.Drawing.Size(94, 17);
            this.ckDamage.TabIndex = 12;
            this.ckDamage.Text = "Damage Book";
            this.ckDamage.UseVisualStyleBackColor = true;
            // 
            // ckLost
            // 
            this.ckLost.AutoSize = true;
            this.ckLost.Location = new System.Drawing.Point(413, 331);
            this.ckLost.Margin = new System.Windows.Forms.Padding(2);
            this.ckLost.Name = "ckLost";
            this.ckLost.Size = new System.Drawing.Size(74, 17);
            this.ckLost.TabIndex = 13;
            this.ckLost.Text = "Lost Book";
            this.ckLost.UseVisualStyleBackColor = true;
            // 
            // gvReturn
            // 
            this.gvReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvReturn.Location = new System.Drawing.Point(13, 133);
            this.gvReturn.MainView = this.gridView1;
            this.gvReturn.Name = "gvReturn";
            this.gvReturn.Size = new System.Drawing.Size(315, 369);
            this.gvReturn.TabIndex = 14;
            this.gvReturn.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gvReturn;
            this.gridView1.Name = "gridView1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(406, 413);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(139, 2);
            this.panel4.TabIndex = 9;
            // 
            // txtRid
            // 
            this.txtRid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRid.Enabled = false;
            this.txtRid.ForeColor = System.Drawing.Color.Silver;
            this.txtRid.Location = new System.Drawing.Point(413, 395);
            this.txtRid.Margin = new System.Windows.Forms.Padding(2);
            this.txtRid.Name = "txtRid";
            this.txtRid.Size = new System.Drawing.Size(122, 13);
            this.txtRid.TabIndex = 8;
            this.txtRid.Text = "Name of Book";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(406, 389);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(139, 2);
            this.panel5.TabIndex = 7;
            // 
            // txtUid
            // 
            this.txtUid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUid.Enabled = false;
            this.txtUid.ForeColor = System.Drawing.Color.Silver;
            this.txtUid.Location = new System.Drawing.Point(413, 370);
            this.txtUid.Margin = new System.Windows.Forms.Padding(2);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(122, 13);
            this.txtUid.TabIndex = 6;
            this.txtUid.Text = "ID Book";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "User ID: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Return ID: ";
            // 
            // processReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 524);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.gvReturn);
            this.Controls.Add(this.txtRid);
            this.Controls.Add(this.ckLost);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtUid);
            this.Controls.Add(this.ckDamage);
            this.Controls.Add(this.chuY);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtNameBook);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtIDBook);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.windowsUIButtonPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "processReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "processReturnBook";
            this.Load += new System.EventHandler(this.processReturnBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TextBox txtIDBook;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNameBook;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel1;
        private System.Windows.Forms.Label chuY;
        private System.Windows.Forms.CheckBox ckDamage;
        private System.Windows.Forms.CheckBox ckLost;
        private DevExpress.XtraGrid.GridControl gvReturn;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtRid;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtUid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}