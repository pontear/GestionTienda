Imports System.Windows.Forms.DataVisualization.Charting
Public Class FrmMenu

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Diseing.AplicarEstiloTabla(DgvAgotados)
        DgvAgotados.DataSource = Consultas.ObtenerProductosAgotados()
        LblVentasHoy.Text = Consultas.ObtenerVentasHoy().ToString()
        LblVentasMes.Text = Consultas.ObtenerVentasMes().ToString()
        LblProductos.Text = Consultas.ObtenerTotalProductos().ToString()
        LblClientes.Text = Consultas.ObtenerTotalClientes().ToString()
        CrearGraficaCircular(Chart1)
    End Sub

    Private Sub DgvAgotados_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DgvAgotados.DataBindingComplete
        'centrar columnas
        If DgvAgotados.Columns.Contains("cantidad_actual") Then
            DgvAgotados.Columns("cantidad_actual").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DgvAgotados.Columns("cantidad_actual").HeaderText = "Cantidad Actual"
        End If
        If DgvAgotados.Columns.Contains("estado") Then
            DgvAgotados.Columns("estado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DgvAgotados.Columns("estado").HeaderText = "Estado"
        End If
    End Sub
End Class