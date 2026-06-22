Public Class FrmSplash
    Private progreso As Integer = 0

    Private Sub FrmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 50
        Timer1.Start()
        PnlCarga.Width = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        progreso += 2

        Dim anchoActual As Integer = (progreso * PnlPrecarga.Width) / 100
        PnlCarga.Width = anchoActual

        LblPorcentaje.Text = progreso.ToString() & "%"

        Select Case progreso
            Case 10
                LblCarga.Text = "Cargando base de datos..."
            Case 40
                LblCarga.Text = "Cargando configuraciones..."
            Case 70
                LblCarga.Text = "Preparando interfaz..."
            Case 100
                Timer1.Stop()
                FrmLogin.Show()
                Me.Hide()
        End Select
    End Sub
End Class