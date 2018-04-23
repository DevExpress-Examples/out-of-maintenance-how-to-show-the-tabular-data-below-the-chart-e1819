Imports System
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
Imports DevExpress.XtraPivotGrid

Namespace ChartAndGridSample

    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private numberOfYears As Integer = 0

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim myTable As DataTable = CreateTable()

            ' Bind a chart.
            chartControl1.DataSource = myTable
            chartControl1.SeriesDataMember = "SeriesName"
            chartControl1.SeriesTemplate.ArgumentDataMember = "Date"
            chartControl1.SeriesTemplate.ValueDataMembers.AddRange(New String() { "Value" })
            numberOfYears = chartControl1.Series(0).Points.Count

            ' Adjust chart appearance.
            CType(chartControl1.Diagram, XYDiagram).AxisX.Visibility = DevExpress.Utils.DefaultBoolean.False
            CType(chartControl1.Diagram, XYDiagram).Margins.Bottom = 90
            CType(chartControl1.Diagram, XYDiagram).Margins.Left = 92

            ' Bind a pivot grid.
            pivotGridControl1.DataSource = myTable
            pivotGridControl1.Fields.Add("SeriesName", PivotArea.RowArea)
            pivotGridControl1.Fields.Add("Date", PivotArea.ColumnArea)
            pivotGridControl1.Fields.Add("Value", PivotArea.DataArea)

            ' Adjust a pivot grid's size.
            AddHandler pivotGridControl1.SizeChanged, AddressOf pivotGridControl1_SizeChanged
        End Sub

        Private Function CreateTable() As DataTable
            Dim table As New DataTable()

            table.Columns.Add("SeriesName", GetType(String))
            table.Columns.Add("Date", GetType(String))
            table.Columns.Add("Value", GetType(Double))

            table.Rows.Add(New Object() { "Series1", "2007", 120 })
            table.Rows.Add(New Object() { "Series1", "2008", 113 })
            table.Rows.Add(New Object() { "Series1", "2009", 97 })
            table.Rows.Add(New Object() { "Series2", "2007", 130 })
            table.Rows.Add(New Object() { "Series2", "2008", 155 })
            table.Rows.Add(New Object() { "Series2", "2009", 168 })
            table.Rows.Add(New Object() { "Series3", "2007", 110 })
            table.Rows.Add(New Object() { "Series3", "2008", 125 })
            table.Rows.Add(New Object() { "Series3", "2009", 147 })

            Return table
        End Function

        Private Sub pivotGridControl1_SizeChanged(ByVal sender As Object, ByVal e As EventArgs)
            AdjustPivotSize(DirectCast(sender, PivotGridControl))
        End Sub

        Private Sub AdjustPivotSize(ByVal pivot As PivotGridControl)
            Dim columnField As PivotGridField = pivot.GetFieldByArea(PivotArea.ColumnArea, 0)
            Dim rowField As PivotGridField = pivot.GetFieldByArea(PivotArea.RowArea, 0)
            columnField.Width = (pivot.ClientSize.Width - rowField.Width - 5) \ numberOfYears
        End Sub

    End Class
End Namespace