
namespace Library_management.forms.Chart
{
    partial class ChartTeacher
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
            this.BarChartGenderTeachers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pieChartTeachers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.photos2 = new System.Windows.Forms.Label();
            this.photos1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarChartGenderTeachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChartTeachers)).BeginInit();
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
            this.button1.Location = new System.Drawing.Point(826, 11);
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
            this.title.Location = new System.Drawing.Point(255, 36);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(387, 37);
            this.title.TabIndex = 0;
            this.title.Text = "CHART ABOUT TEACHERS";
            // 
            // BarChartGenderTeachers
            // 
            chartArea1.Name = "ChartArea1";
            this.BarChartGenderTeachers.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.BarChartGenderTeachers.Legends.Add(legend1);
            this.BarChartGenderTeachers.Location = new System.Drawing.Point(-15, 186);
            this.BarChartGenderTeachers.Name = "BarChartGenderTeachers";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Male";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Female";
            this.BarChartGenderTeachers.Series.Add(series1);
            this.BarChartGenderTeachers.Series.Add(series2);
            this.BarChartGenderTeachers.Size = new System.Drawing.Size(469, 346);
            this.BarChartGenderTeachers.TabIndex = 5;
            this.BarChartGenderTeachers.Text = "Bar char Teachers";
            // 
            // pieChartTeachers
            // 
            chartArea2.Name = "ChartArea1";
            this.pieChartTeachers.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.pieChartTeachers.Legends.Add(legend2);
            this.pieChartTeachers.Location = new System.Drawing.Point(460, 207);
            this.pieChartTeachers.Name = "pieChartTeachers";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.pieChartTeachers.Series.Add(series3);
            this.pieChartTeachers.Size = new System.Drawing.Size(326, 300);
            this.pieChartTeachers.TabIndex = 6;
            this.pieChartTeachers.Text = "Pie chart teachers";
            // 
            // photos2
            // 
            this.photos2.AutoSize = true;
            this.photos2.Location = new System.Drawing.Point(478, 539);
            this.photos2.Name = "photos2";
            this.photos2.Size = new System.Drawing.Size(249, 17);
            this.photos2.TabIndex = 9;
            this.photos2.Text = "H 2.2 Pie chart illustrates the teachers";
            // 
            // photos1
            // 
            this.photos1.AutoSize = true;
            this.photos1.Location = new System.Drawing.Point(8, 539);
            this.photos1.Name = "photos1";
            this.photos1.Size = new System.Drawing.Size(371, 17);
            this.photos1.TabIndex = 8;
            this.photos1.Text = "H 2.1 Bar chart illustrates the gender teacher distrubution";
            // 
            // ChartTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(877, 605);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BarChartGenderTeachers);
            this.Controls.Add(this.pieChartTeachers);
            this.Controls.Add(this.photos2);
            this.Controls.Add(this.photos1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChartTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChartTeacher";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarChartGenderTeachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieChartTeachers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataVisualization.Charting.Chart BarChartGenderTeachers;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChartTeachers;
        private System.Windows.Forms.Label photos2;
        private System.Windows.Forms.Label photos1;
    }
}