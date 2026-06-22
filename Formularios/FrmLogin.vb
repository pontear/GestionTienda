Imports System.Data.OleDb
Imports GestionTienda.Conexion

Public Class FrmLogin

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        If String.IsNullOrWhiteSpace(TextUser.Text) OrElse String.IsNullOrWhiteSpace(TextPassword.Text) Then
            MsgBox("Por favor, rellene todos los campos.", MsgBoxStyle.Exclamation, "Atención")
            Return
        End If

        Dim consulta As String = "SELECT Nombre, Id_Rol FROM Usuario WHERE [User] = ? AND [Password] = ?"

        Try
            Using conn As OleDbConnection = ConexionDB.AbrirConexion()
                conn.Open()

                Using cmd As New OleDbCommand(consulta, conn)
                    cmd.Parameters.AddWithValue("?", TextUser.Text.Trim())
                    cmd.Parameters.AddWithValue("?", TextPassword.Text.Trim())

                    Using reader As OleDbDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim nombreUsuario As String = reader("Nombre").ToString()
                            MsgBox("Bienvenido al sistema, " & nombreUsuario, MsgBoxStyle.Information, "Acceso concedido")

                            FrmMenu.Show()
                            Me.Hide()
                        Else
                            MsgBox("Usuario o contraseña incorrectos.", MsgBoxStyle.Critical, "Error de inicio")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error al conectar con la base de datos: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim Respuesta As MsgBoxResult

        Respuesta = (MsgBox("¿desea salir del aplicativo?", vbCritical + vbYesNo, "Salir"))

        If Respuesta = vbYes Then
            End
        End If
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Diseing.RedondearBordes(BtnLogin, 30)
        Diseing.RedondearBordes(BtnCancelar, 30)
    End Sub
End Class