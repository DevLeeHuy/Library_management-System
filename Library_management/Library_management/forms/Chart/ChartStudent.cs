using DevExpress.XtraCharts;
using Library_management.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_management.forms.Chart
{
    public partial class ChartStudent : Form
    {
        public ChartStudent()
        {
            InitializeComponent();
       
        }

        private void pieChartStudent_Click(object sender, EventArgs e)
        {

        }

        private void ChartStudent_Load(object sender, EventArgs e)
        {
            showPieChartStd();
            showPieChartTeacher();
            showPieChartStaff();
            showTotal();

        }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }

        void showPieChartStd()
        {
            int males = userDB.getGender(3, "male");
            int females = userDB.getGender(3, "female");
            ChartTitle chartTitle = new ChartTitle();
            chartTitle.Text = "Gender ratio";
            pieChartStd.Titles.Add(chartTitle);
            // Create a pie series.
            Series series1 = new Series("Pie Chart", ViewType.Pie3D);

            // Populate the series with points.
            series1.Points.Add(new SeriesPoint("Male", males));
            series1.Points.Add(new SeriesPoint("Female", females));
            series1.Label.TextPattern = "{VP:p0} ({V:.##} person)";

            series1.LegendTextPattern = "{A}";

            // Add the series to the chart.
            pieChartStd.Series.Add(series1);
        }
        void showPieChartTeacher()
        {
            int males = userDB.getGender(2, "male");
            int females = userDB.getGender(2, "female");
            ChartTitle chartTitle = new ChartTitle();
            chartTitle.Text = "Gender ratio";
            pieChartTeacher.Titles.Add(chartTitle);
            // Create a pie series.
            Series series1 = new Series("Pie Chart", ViewType.Pie3D);

            // Populate the series with points.
            series1.Points.Add(new SeriesPoint("Male", males));
            series1.Points.Add(new SeriesPoint("Female", females));
            series1.Label.TextPattern = "{VP:p0} ({V:.##} person)";

            series1.LegendTextPattern = "{A}";

            // Add the series to the chart.
            pieChartTeacher.Series.Add(series1);
        }
        void showPieChartStaff()
        {
            int males = userDB.getGender(4, "male");
            int females = userDB.getGender(4, "female");
            ChartTitle chartTitle = new ChartTitle();
            chartTitle.Text = "Gender ratio";
            pieChartStaff.Titles.Add(chartTitle);
            // Create a pie series.
            Series series1 = new Series("Pie Chart", ViewType.Pie3D);

            // Populate the series with points.
            series1.Points.Add(new SeriesPoint("Male", males));
            series1.Points.Add(new SeriesPoint("Female", females));
            series1.Label.TextPattern = "{VP:p0} ({V:.##} person)";

            series1.LegendTextPattern = "{A}";

            // Add the series to the chart.
            pieChartStaff.Series.Add(series1);
        }
        void showTotal()
        {
            lbTotalStaff.Text = "TỔNG SỐ NHÂN VIÊN THƯ VIỆN: " + userDB.getTotal(4).ToString();
            lbTotalStd.Text = "TỔNG SỐ SINH VIÊN: " + userDB.getTotal(3).ToString();
            lbTotalTc.Text = "TỔNG SỐ GIÁO VIÊN: " + userDB.getTotal(2).ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
