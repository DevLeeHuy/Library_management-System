
namespace Library_management.forms.Chart
{
    partial class ChartStudent
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
            DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D1 = new DevExpress.XtraCharts.SimpleDiagram3D();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView1 = new DevExpress.XtraCharts.Pie3DSeriesView();
            DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D2 = new DevExpress.XtraCharts.SimpleDiagram3D();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView2 = new DevExpress.XtraCharts.Pie3DSeriesView();
            DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D3 = new DevExpress.XtraCharts.SimpleDiagram3D();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView3 = new DevExpress.XtraCharts.Pie3DSeriesView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbTotalStd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pieChartStd = new DevExpress.XtraCharts.ChartControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbTotalStaff = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pieChartStaff = new DevExpress.XtraCharts.ChartControl();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbTotalTc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pieChartTeacher = new DevExpress.XtraCharts.ChartControl();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieChartStd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieChartStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieChartTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.title);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 92);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(767, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 24);
            this.button1.TabIndex = 140;
            this.button1.Text = "❌";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(192, 42);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(307, 30);
            this.title.TabIndex = 0;
            this.title.Text = "CHART ABOUT STUDENTS";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 97);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(808, 590);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 1050);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.lbTotalStd);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pieChartStd);
            this.panel3.Location = new System.Drawing.Point(9, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(361, 295);
            this.panel3.TabIndex = 149;
            // 
            // lbTotalStd
            // 
            this.lbTotalStd.AutoSize = true;
            this.lbTotalStd.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalStd.Location = new System.Drawing.Point(20, 49);
            this.lbTotalStd.Name = "lbTotalStd";
            this.lbTotalStd.Size = new System.Drawing.Size(75, 25);
            this.lbTotalStd.TabIndex = 142;
            this.lbTotalStd.Text = "label4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(107, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 30);
            this.label1.TabIndex = 141;
            this.label1.Text = "STUDENT";
            // 
            // pieChartStd
            // 
            simpleDiagram3D1.RotationMatrixSerializable = "-0.680789309134956;-0.0363746904247726;0.73157555895758;0;-0.446478227172945;0.81" +
    "2381601283329;-0.3750910910124;0;-0.580674701729031;-0.581990563319433;-0.569301" +
    "216386433;0;0;0;0;1";
            this.pieChartStd.Diagram = simpleDiagram3D1;
            this.pieChartStd.Legend.Name = "Default Legend";
            this.pieChartStd.Location = new System.Drawing.Point(15, 89);
            this.pieChartStd.Name = "pieChartStd";
            series1.Name = "Series 1";
            series1.View = pie3DSeriesView1;
            this.pieChartStd.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.pieChartStd.Size = new System.Drawing.Size(335, 191);
            this.pieChartStd.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.lbTotalStaff);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.pieChartStaff);
            this.panel4.Location = new System.Drawing.Point(161, 304);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(455, 324);
            this.panel4.TabIndex = 150;
            // 
            // lbTotalStaff
            // 
            this.lbTotalStaff.AutoSize = true;
            this.lbTotalStaff.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalStaff.Location = new System.Drawing.Point(20, 48);
            this.lbTotalStaff.Name = "lbTotalStaff";
            this.lbTotalStaff.Size = new System.Drawing.Size(75, 25);
            this.lbTotalStaff.TabIndex = 146;
            this.lbTotalStaff.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(180, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 30);
            this.label3.TabIndex = 144;
            this.label3.Text = "STAFF";
            // 
            // pieChartStaff
            // 
            simpleDiagram3D2.RotationMatrixSerializable = "0.287878672098299;-0.74358814469298;0.603491956220657;0;0.67866576120824;0.603017" +
    "163284633;0.419264934555525;0;-0.675676442326222;0.288871895234306;0.67824359446" +
    "2331;0;0;0;0;1";
            this.pieChartStaff.Diagram = simpleDiagram3D2;
            this.pieChartStaff.Legend.Name = "Default Legend";
            this.pieChartStaff.Location = new System.Drawing.Point(17, 76);
            this.pieChartStaff.Name = "pieChartStaff";
            series2.Name = "Series 1";
            series2.View = pie3DSeriesView2;
            this.pieChartStaff.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.pieChartStaff.Size = new System.Drawing.Size(424, 228);
            this.pieChartStaff.TabIndex = 145;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.Controls.Add(this.lbTotalTc);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.pieChartTeacher);
            this.panel5.Location = new System.Drawing.Point(397, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(361, 295);
            this.panel5.TabIndex = 151;
            // 
            // lbTotalTc
            // 
            this.lbTotalTc.AutoSize = true;
            this.lbTotalTc.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalTc.Location = new System.Drawing.Point(20, 52);
            this.lbTotalTc.Name = "lbTotalTc";
            this.lbTotalTc.Size = new System.Drawing.Size(75, 25);
            this.lbTotalTc.TabIndex = 144;
            this.lbTotalTc.Text = "label4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(133, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 30);
            this.label2.TabIndex = 142;
            this.label2.Text = "TEACHER";
            // 
            // pieChartTeacher
            // 
            simpleDiagram3D3.RotationMatrixSerializable = "0.804004120178956;-0.0528595216905805;-0.592269571818408;0;-0.17196772554438;0.93" +
    "2807355224814;-0.316697867706155;0;0.569213910675425;0.356477641662386;0.7408908" +
    "25215474;0;0;0;0;1";
            this.pieChartTeacher.Diagram = simpleDiagram3D3;
            this.pieChartTeacher.Legend.Name = "Default Legend";
            this.pieChartTeacher.Location = new System.Drawing.Point(15, 92);
            this.pieChartTeacher.Name = "pieChartTeacher";
            series3.Name = "Series 1";
            series3.View = pie3DSeriesView3;
            this.pieChartTeacher.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3};
            this.pieChartTeacher.Size = new System.Drawing.Size(335, 188);
            this.pieChartTeacher.TabIndex = 143;
            // 
            // ChartStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(805, 689);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChartStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChartStudent";
            this.Load += new System.EventHandler(this.ChartStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChartStd)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChartStaff)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChartTeacher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbTotalStd;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraCharts.ChartControl pieChartStd;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbTotalStaff;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraCharts.ChartControl pieChartStaff;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbTotalTc;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraCharts.ChartControl pieChartTeacher;
    }
}