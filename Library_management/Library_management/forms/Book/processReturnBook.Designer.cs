
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtIDBook = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNameBook = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.chuY = new System.Windows.Forms.Label();
            this.ckDamage = new System.Windows.Forms.CheckBox();
            this.ckLost = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 144);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(162, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "MANAGE PROCESS RETURN BOOK";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Black;
            this.closeBtn.ForeColor = System.Drawing.Color.Red;
            this.closeBtn.Location = new System.Drawing.Point(733, 24);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(37, 30);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "❌";
            this.closeBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(440, 403);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtIDBook
            // 
            this.txtIDBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDBook.ForeColor = System.Drawing.Color.Silver;
            this.txtIDBook.Location = new System.Drawing.Point(541, 289);
            this.txtIDBook.Name = "txtIDBook";
            this.txtIDBook.Size = new System.Drawing.Size(163, 15);
            this.txtIDBook.TabIndex = 2;
            this.txtIDBook.Text = "ID Book";
            this.txtIDBook.Enter += new System.EventHandler(this.txtIDBook_Enter);
            this.txtIDBook.Leave += new System.EventHandler(this.txtIDBook_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(532, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 2);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(532, 356);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 2);
            this.panel3.TabIndex = 5;
            // 
            // txtNameBook
            // 
            this.txtNameBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameBook.ForeColor = System.Drawing.Color.Silver;
            this.txtNameBook.Location = new System.Drawing.Point(541, 333);
            this.txtNameBook.Name = "txtNameBook";
            this.txtNameBook.Size = new System.Drawing.Size(163, 15);
            this.txtNameBook.TabIndex = 4;
            this.txtNameBook.Text = "Name of Book";
            this.txtNameBook.Enter += new System.EventHandler(this.txtNameBook_Enter);
            this.txtNameBook.Leave += new System.EventHandler(this.txtNameBook_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(577, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 55);
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
            this.windowsUIButtonPanel1.ForeColor = System.Drawing.Color.SandyBrown;
            this.windowsUIButtonPanel1.Location = new System.Drawing.Point(432, 542);
            this.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.Size = new System.Drawing.Size(399, 76);
            this.windowsUIButtonPanel1.TabIndex = 10;
            this.windowsUIButtonPanel1.Text = "windowsUIButtonPanel1";
            // 
            // chuY
            // 
            this.chuY.AutoSize = true;
            this.chuY.Location = new System.Drawing.Point(510, 512);
            this.chuY.Name = "chuY";
            this.chuY.Size = new System.Drawing.Size(238, 17);
            this.chuY.TabIndex = 11;
            this.chuY.Text = "📌User return books late always fine";
            // 
            // ckDamage
            // 
            this.ckDamage.AutoSize = true;
            this.ckDamage.Location = new System.Drawing.Point(577, 404);
            this.ckDamage.Name = "ckDamage";
            this.ckDamage.Size = new System.Drawing.Size(119, 21);
            this.ckDamage.TabIndex = 12;
            this.ckDamage.Text = "Damage Book";
            this.ckDamage.UseVisualStyleBackColor = true;
            // 
            // ckLost
            // 
            this.ckLost.AutoSize = true;
            this.ckLost.Location = new System.Drawing.Point(577, 432);
            this.ckLost.Name = "ckLost";
            this.ckLost.Size = new System.Drawing.Size(93, 21);
            this.ckLost.TabIndex = 13;
            this.ckLost.Text = "Lost Book";
            this.ckLost.UseVisualStyleBackColor = true;
            // 
            // processReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 645);
            this.Controls.Add(this.ckLost);
            this.Controls.Add(this.ckDamage);
            this.Controls.Add(this.chuY);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtNameBook);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtIDBook);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.windowsUIButtonPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "processReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "processReturnBook";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtIDBook;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNameBook;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel1;
        private System.Windows.Forms.Label chuY;
        private System.Windows.Forms.CheckBox ckDamage;
        private System.Windows.Forms.CheckBox ckLost;
    }
}