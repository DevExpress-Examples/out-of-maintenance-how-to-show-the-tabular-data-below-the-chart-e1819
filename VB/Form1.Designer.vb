Namespace ChartAndGridSample
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
            sideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True
            Me.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel1
            Me.chartControl1.Size = New System.Drawing.Size(427, 293)
            Me.chartControl1.TabIndex = 0
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.pivotGridControl1.Appearance.FieldValue.Options.UseTextOptions = True
            Me.pivotGridControl1.Appearance.FieldValue.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 205)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsView.ShowColumnGrandTotals = False
            Me.pivotGridControl1.OptionsView.ShowColumnHeaders = False
            Me.pivotGridControl1.OptionsView.ShowDataHeaders = False
            Me.pivotGridControl1.OptionsView.ShowFilterHeaders = False
            Me.pivotGridControl1.OptionsView.ShowRowGrandTotals = False
            Me.pivotGridControl1.OptionsView.ShowRowHeaders = False
            Me.pivotGridControl1.Size = New System.Drawing.Size(427, 87)
            Me.pivotGridControl1.TabIndex = 2
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(427, 293)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Controls.Add(Me.chartControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private chartControl1 As DevExpress.XtraCharts.ChartControl
        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl

    End Class
End Namespace

