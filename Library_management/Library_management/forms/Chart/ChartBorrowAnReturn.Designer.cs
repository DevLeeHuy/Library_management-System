
namespace Library_management.forms.Chart
{
    partial class ChartBorrowAnReturn
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pieChartBooksBorrow = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.BarChartBooksBorrow = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.photos2 = new System.Windows.Forms.Label();
            this.photos1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pieChartBooksBorrow)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarChartBooksBorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // pieChartBooksBorrow
            // 
            chartArea1.Name = "ChartArea1";
            this.pieChartBooksBorrow.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.pieChartBooksBorrow.Legends.Add(legend1);
            this.pieChartBooksBorrow.Location = new System.Drawing.Point(551, 236);
            this.pieChartBooksBorrow.Name = "pieChartBooksBorrow";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.pieChartBooksBorrow.Series.Add(series1);
            this.pieChartBooksBorrow.Size = new System.Drawing.Size(300, 300);
            this.pieChartBooksBorrow.TabIndex = 148;
            this.pieChartBooksBorrow.Text = "Pie chart Books Borrows";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(878, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 30);
            this.button1.TabIndex = 146;
            this.button1.Text = "❌";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.title);
            this.panel1.Location = new System.Drawing.Point(25, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 113);
            this.panel1.TabIndex = 143;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(256, 52);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(481, 37);
            this.title.TabIndex = 0;
            this.title.Text = "CHART ABOUT BOOKS BORROW";
            // 
            // BarChartBooksBorrow
            // 
            chartArea2.Name = "ChartArea1";
            this.BarChartBooksBorrow.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.BarChartBooksBorrow.Legends.Add(legend2);
            this.BarChartBooksBorrow.Location = new System.Drawing.Point(63, 246);
            this.BarChartBooksBorrow.Name = "BarChartBooksBorrow";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Books";
            this.BarChartBooksBorrow.Series.Add(series2);
            this.BarChartBooksBorrow.Size = new System.Drawing.Size(418, 300);
            this.BarChartBooksBorrow.TabIndex = 147;
            this.BarChartBooksBorrow.Text = "Borrow Book Chart";
            // 
            // photos2
            // 
            this.photos2.AutoSize = true;
            this.photos2.Location = new System.Drawing.Point(559, 578);
            this.photos2.Name = "photos2";
            this.photos2.Size = new System.Drawing.Size(342, 17);
            this.photos2.TabIndex = 145;
            this.photos2.Text = "H5.2 Pie chart illustrates type of books had borrowed";
            // 
            // photos1
            // 
            this.photos1.AutoSize = true;
            this.photos1.Location = new System.Drawing.Point(60, 578);
            this.photos1.Name = "photos1";
            this.photos1.Size = new System.Drawing.Size(360, 17);
            this.photos1.TabIndex = 144;
            this.photos1.Text = "H5.1Bar chart illustrates the books library had borrowed";
            // 
            // ChartBorrowAnReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(940, 685);
            this.Controls.Add(this.pieChartBooksBorrow);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BarChartBooksBorrow);
            this.Controls.Add(this.photos2);
            this.Controls.Add(this.photos1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChartBorrowAnReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChartBorrowAnReturn";
            ((System.ComponentModel.ISupportInitialize)(this.pieChartBooksBorrow)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarChartBooksBorrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart pieChartBooksBorrow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataVisualization.Charting.Chart BarChartBooksBorrow;
        private System.Windows.Forms.Label photos2;
        private System.Windows.Forms.Label photos1;
    }
}