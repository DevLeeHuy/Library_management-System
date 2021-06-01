
namespace Library_management.forms.Chart
{
    partial class ChartReturnBooks
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
            this.pieChartBooksReturn = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.BarChartBooksReturn = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.photos2 = new System.Windows.Forms.Label();
            this.photos1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pieChartBooksReturn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarChartBooksReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // pieChartBooksReturn
            // 
            chartArea1.Name = "ChartArea1";
            this.pieChartBooksReturn.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.pieChartBooksReturn.Legends.Add(legend1);
            this.pieChartBooksReturn.Location = new System.Drawing.Point(538, 229);
            this.pieChartBooksReturn.Name = "pieChartBooksReturn";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.pieChartBooksReturn.Series.Add(series1);
            this.pieChartBooksReturn.Size = new System.Drawing.Size(300, 300);
            this.pieChartBooksReturn.TabIndex = 154;
            this.pieChartBooksReturn.Text = "Pie chart Books Return";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(865, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 30);
            this.button1.TabIndex = 152;
            this.button1.Text = "❌";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.title);
            this.panel1.Location = new System.Drawing.Point(12, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 113);
            this.panel1.TabIndex = 149;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(209, 52);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(466, 37);
            this.title.TabIndex = 0;
            this.title.Text = "CHART ABOUT BOOKS RETURN";
            // 
            // BarChartBooksReturn
            // 
            chartArea2.Name = "ChartArea1";
            this.BarChartBooksReturn.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.BarChartBooksReturn.Legends.Add(legend2);
            this.BarChartBooksReturn.Location = new System.Drawing.Point(50, 239);
            this.BarChartBooksReturn.Name = "BarChartBooksReturn";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Books";
            this.BarChartBooksReturn.Series.Add(series2);
            this.BarChartBooksReturn.Size = new System.Drawing.Size(418, 300);
            this.BarChartBooksReturn.TabIndex = 153;
            this.BarChartBooksReturn.Text = "Return Book Chart";
            // 
            // photos2
            // 
            this.photos2.AutoSize = true;
            this.photos2.Location = new System.Drawing.Point(546, 571);
            this.photos2.Name = "photos2";
            this.photos2.Size = new System.Drawing.Size(337, 17);
            this.photos2.TabIndex = 151;
            this.photos2.Text = "H6.2 Pie chart illustrates type of books had returned";
            // 
            // photos1
            // 
            this.photos1.AutoSize = true;
            this.photos1.Location = new System.Drawing.Point(47, 571);
            this.photos1.Name = "photos1";
            this.photos1.Size = new System.Drawing.Size(355, 17);
            this.photos1.TabIndex = 150;
            this.photos1.Text = "H6.1Bar chart illustrates the books library had returned";
            // 
            // ChartReturnBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(916, 736);
            this.Controls.Add(this.pieChartBooksReturn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BarChartBooksReturn);
            this.Controls.Add(this.photos2);
            this.Controls.Add(this.photos1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChartReturnBooks";
            this.Text = "ChartReturnBooks";
            ((System.ComponentModel.ISupportInitialize)(this.pieChartBooksReturn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarChartBooksReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart pieChartBooksReturn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataVisualization.Charting.Chart BarChartBooksReturn;
        private System.Windows.Forms.Label photos2;
        private System.Windows.Forms.Label photos1;
    }
}