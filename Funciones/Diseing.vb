Imports System.Drawing.Drawing2D
Imports System.Windows.Forms.DataVisualization.Charting
Module Diseing
    Public Sub RedondearBordes(control As Control, radio As Integer)
        Dim path As New GraphicsPath()


        Dim rect As Rectangle = control.ClientRectangle


        path.AddArc(rect.X, rect.Y, radio, radio, 180, 90)
        path.AddArc(rect.Width - radio, rect.Y, radio, radio, 270, 90)
        path.AddArc(rect.Width - radio, rect.Height - radio, radio, radio, 0, 90)
        path.AddArc(rect.X, rect.Height - radio, radio, radio, 90, 90)
        path.CloseFigure()


        control.Region = New Region(path)
    End Sub

    Public Sub AplicarEstiloTabla(dgv As DataGridView)
        'Encabezado
        dgv.EnableHeadersVisualStyles = False
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(223, 240, 255)
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 11, FontStyle.Regular)
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None

        'Cuerpo
        dgv.BackgroundColor = Color.White
        dgv.DefaultCellStyle.BackColor = Color.White
        dgv.DefaultCellStyle.ForeColor = Color.Black
        dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 230, 230)
        dgv.DefaultCellStyle.SelectionForeColor = Color.Black
        dgv.DefaultCellStyle.Font = New Font("Segoe UI", 10)

        'Bordes y filas
        dgv.BorderStyle = BorderStyle.None
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgv.RowHeadersVisible = False
        dgv.GridColor = Color.LightGray

        'Ajuste automático
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgv.RowTemplate.Height = 32
    End Sub

    Public Sub CrearGraficaCircular(chartControl As Chart)
        chartControl.Series.Clear()
        chartControl.Titles.Clear()
        chartControl.ChartAreas.Clear()
        chartControl.Legends.Clear()

        Dim area As New ChartArea("Area1")
        chartControl.ChartAreas.Add(area)

        Dim serie As New Series("Productos")
        serie.ChartType = SeriesChartType.Pie

        ' 🔹 Obtener datos desde la consulta
        Dim dt As DataTable = Consultas.ObtenerProductosMasVendidos()
        For Each row As DataRow In dt.Rows
            serie.Points.AddXY(row("nombre").ToString(), Convert.ToInt32(row("total_vendido")))
        Next

        ' 🔹 Personalización
        serie.Label = "#PERCENT{P0}"
        serie.LegendText = "#VALX"
        chartControl.Series.Add(serie)
        chartControl.Legends.Add(New Legend("Leyenda"))
        chartControl.Legends(0).Docking = Docking.Right
        chartControl.Titles.Add("Productos más Vendidos")
        chartControl.Titles(0).Font = New Font("Segoe UI", 14, FontStyle.Bold)
        chartControl.BackColor = Color.White
    End Sub

End Module
