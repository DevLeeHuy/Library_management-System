
namespace Library_management.forms.Chart
{
    partial class ChartStaff
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.BarChartGenderStaffs = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pieChartStaffs = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.photos2 = new System.Windows.Forms.Label();
            this.photos1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarChartGenderStaffs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChartStaffs)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.title);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 113);
            this.panel1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(797, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 30);
            this.button1.TabIndex = 140;
            this.button1.Text = "❌";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(219, 52);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(455, 37);
            this.title.TabIndex = 0;
            this.title.Text = "CHART ABOUT STAFF LIBRARY";
            // 
            // BarChartGenderStaffs
            // 
            chartArea1.Name = "ChartArea1";
            this.BarChartGenderStaffs.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.BarChartGenderStaffs.Legends.Add(legend1);
            this.BarChartGenderStaffs.Location = new System.Drawing.Point(-13, 159);
            this.BarChartGenderStaffs.Name = "BarChartGenderStaffs";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Male";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Female";
            this.BarChartGenderStaffs.Series.Add(series1);
            this.BarChartGenderStaffs.Series.Add(series2);
            this.BarChartGenderStaffs.Size = new System.Drawing.Size(469, 346);
            this.BarChartGenderStaffs.TabIndex = 5;
            this.BarChartGenderStaffs.Text = "Bar char Staffs";
            // 
            // pieChartStaffs
            // 
            chartArea2.Name = "ChartArea1";
            this.pieChartStaffs.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.pieChartStaffs.Legends.Add(legend2);
            this.pieChartStaffs.Location = new System.Drawing.Point(462, 180);
            this.pieChartStaffs.Name = "pieChartStaffs";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.pieChartStaffs.Series.Add(series3);
            this.pieChartStaffs.Size = new System.Drawing.Size(326, 300);
            this.pieChartStaffs.TabIndex = 6;
            this.pieChartStaffs.Text = "Pie chart Staffs";
            // 
            // photos2
            // 
            this.photos2.AutoSize = true;
            this.photos2.Location = new System.Drawing.Point(480, 512);
            this.photos2.Name = "photos2";
            this.photos2.Size = new System.Drawing.Size(228, 17);
            this.photos2.TabIndex = 9;
            this.photos2.Text = "H 3.2 Pie chart illustrates the staffs";
            // 
            // photos1
            // 
            this.photos1.AutoSize = true;
            this.photos1.Location = new System.Drawing.Point(10, 512);
            this.photos1.Name = "photos1";
            this.photos1.Size = new System.Drawing.Size(350, 17);
            this.photos1.TabIndex = 8;
            this.photos1.Text = "H 3.1 Bar chart illustrates the gender staff distrubution";
            // 
            // ChartStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 598);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BarChartGenderStaffs);
            this.Controls.Add(this.pieChartStaffs);
            this.Controls.Add(this.photos2);
            this.Controls.Add(this.photos1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChartStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChartStaff";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarChartGenderStaffs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChartStaffs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataVisualization.Charting.Chart BarChartGenderStaffs;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChartStaffs;
        private System.Windows.Forms.Label photos2;
        private System.Windows.Forms.Label photos1;
    }
}