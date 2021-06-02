namespace Library_management.forms.Admin
{
    partial class CheckIn
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
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckIn));
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.label1 = new System.Windows.Forms.Label();
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE TIME STAFF CHECKING ";
            // 
            // windowsUIButtonPanel1
            // 
            this.windowsUIButtonPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            windowsUIButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("windowsUIButtonImageOptions1.SvgImage")));
            windowsUIButtonImageOptions2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("windowsUIButtonImageOptions2.SvgImage")));
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("CHECK IN", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("ATTENDANCE", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.windowsUIButtonPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.windowsUIButtonPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.windowsUIButtonPanel1.Location = new System.Drawing.Point(0, 366);
            this.windowsUIButtonPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.Size = new System.Drawing.Size(419, 84);
            this.windowsUIButtonPanel1.TabIndex = 11;
            this.windowsUIButtonPanel1.Text = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanel1_ButtonClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(149, 253);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 2);
            this.panel3.TabIndex = 10;
            // 
            // txtStaffName
            // 
            this.txtStaffName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStaffName.ForeColor = System.Drawing.Color.Silver;
            this.txtStaffName.Location = new System.Drawing.Point(149, 237);
            this.txtStaffName.Margin = new System.Windows.Forms.Padding(2);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.PasswordChar = '*';
            this.txtStaffName.Size = new System.Drawing.Size(149, 13);
            this.txtStaffName.TabIndex = 9;
            this.txtStaffName.Text = "Staff Code";
            this.txtStaffName.Enter += new System.EventHandler(this.txtStaffName_Enter);
            this.txtStaffName.Leave += new System.EventHandler(this.txtStaffName_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(150, 216);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 2);
            this.panel2.TabIndex = 8;
            // 
            // txtStaffID
            // 
            this.txtStaffID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStaffID.ForeColor = System.Drawing.Color.Silver;
            this.txtStaffID.Location = new System.Drawing.Point(150, 199);
            this.txtStaffID.Margin = new System.Windows.Forms.Padding(2);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(149, 13);
            this.txtStaffID.TabIndex = 7;
            this.txtStaffID.Text = "Staff ID";
            this.txtStaffID.Enter += new System.EventHandler(this.txtStaffID_Enter);
            this.txtStaffID.Leave += new System.EventHandler(this.txtStaffID_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 92);
            this.panel1.TabIndex = 6;
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 450);
            this.Controls.Add(this.windowsUIButtonPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtStaffName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.panel1);
            this.Name = "CheckIn";
            this.Text = "CheckIn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Panel panel1;
    }
}