using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.XtraPivotGrid;

namespace ChartAndGridSample {

    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        int numberOfYears = 0;

        private void Form1_Load(object sender, EventArgs e) {
            DataTable myTable = CreateTable();

            // Bind a chart.
            chartControl1.DataSource = myTable;
            chartControl1.SeriesDataMember = "SeriesName";
            chartControl1.SeriesTemplate.ArgumentDataMember = "Date";
            chartControl1.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "Value" });
            numberOfYears = chartControl1.Series[0].Points.Count;

            // Adjust chart appearance.
            ((XYDiagram)chartControl1.Diagram).AxisX.Visibility = DevExpress.Utils.DefaultBoolean.False;
            ((XYDiagram)chartControl1.Diagram).Margins.Bottom = 90;
            ((XYDiagram)chartControl1.Diagram).Margins.Left = 92;

            // Bind a pivot grid.
            pivotGridControl1.DataSource = myTable;
            pivotGridControl1.Fields.Add("SeriesName", PivotArea.RowArea);
            pivotGridControl1.Fields.Add("Date", PivotArea.ColumnArea);
            pivotGridControl1.Fields.Add("Value", PivotArea.DataArea);
            
            // Adjust a pivot grid's size.
            pivotGridControl1.SizeChanged += new EventHandler(pivotGridControl1_SizeChanged);
        }

        private DataTable CreateTable() {
            DataTable table = new DataTable();

            table.Columns.Add("SeriesName", typeof(string));
            table.Columns.Add("Date", typeof(string));
            table.Columns.Add("Value", typeof(double));

            table.Rows.Add(new object[] { "Series1", "2007", 120 });
            table.Rows.Add(new object[] { "Series1", "2008", 113 });
            table.Rows.Add(new object[] { "Series1", "2009", 97 });
            table.Rows.Add(new object[] { "Series2", "2007", 130 });
            table.Rows.Add(new object[] { "Series2", "2008", 155 });
            table.Rows.Add(new object[] { "Series2", "2009", 168 });
            table.Rows.Add(new object[] { "Series3", "2007", 110 });
            table.Rows.Add(new object[] { "Series3", "2008", 125 });
            table.Rows.Add(new object[] { "Series3", "2009", 147 });

            return table;
        }

        private void pivotGridControl1_SizeChanged(object sender, EventArgs e) {
            AdjustPivotSize((PivotGridControl)sender);
        }

        private void AdjustPivotSize(PivotGridControl pivot) {
            PivotGridField columnField = pivot.GetFieldByArea(PivotArea.ColumnArea, 0);
            PivotGridField rowField = pivot.GetFieldByArea(PivotArea.RowArea, 0);
            columnField.Width = (pivot.ClientSize.Width - rowField.Width - 5) / numberOfYears;
        }
       
    }
}