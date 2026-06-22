Imports System.Data.OleDb

Namespace Conexion
    Public Class ConexionDB
        Private Shared rutaBaseDatos As String = Application.StartupPath & "\DB_Gestion_Tienda.mdb"
        Private Shared cadenaconexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & rutaBaseDatos

        Public Shared Function AbrirConexion() As OleDbConnection
            ' Simplemente crea el objeto, no lo abras aquí
            Return New OleDbConnection(cadenaconexion)
        End Function
    End Class
End Namespace