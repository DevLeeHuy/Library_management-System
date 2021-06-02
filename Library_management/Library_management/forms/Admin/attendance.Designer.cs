namespace Library_management.forms.Admin
{
    partial class attendance
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
            this.gvAttend = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvAttend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gvAttend
            // 
            this.gvAttend.Location = new System.Drawing.Point(3, 5);
            this.gvAttend.MainView = this.gridView1;
            this.gvAttend.Name = "gvAttend";
            this.gvAttend.Size = new System.Drawing.Size(794, 444);
            this.gvAttend.TabIndex = 0;
            this.gvAttend.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gvAttend;
            this.gridView1.Name = "gridView1";
            // 
            // attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gvAttend);
            this.Name = "attendance";
            this.Text = "attendance";
            this.Load += new System.EventHandler(this.attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvAttend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gvAttend;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}