Imports System.Data.OleDb

Module Consultas

    'Productos agotados
    Public Function ObtenerProductosAgotados() As DataTable
        Dim tabla As New DataTable()
        Using conn As OleDbConnection = Conexion.ConexionDB.AbrirConexion()
            Dim sql As String = "SELECT p.nombre, s.cantidad_actual, " &
                                "IIF(s.cantidad_actual <= 0, 'Agotado', 'Pronto a agotarse') AS estado " &
                                "FROM Producto AS p " &
                                "INNER JOIN Stock AS s ON p.id_producto = s.id_producto " &
                                "WHERE s.cantidad_actual <= s.stock_minimo"
            Using cmd As New OleDbCommand(sql, conn)
                Try
                    Dim adapter As New OleDbDataAdapter(cmd)
                    adapter.Fill(tabla)
                Catch ex As Exception
                    MessageBox.Show("Error en la consulta SQL: " & ex.Message)
                End Try
            End Using
        End Using
        Return tabla
    End Function

    'Ventas de hoy
    Public Function ObtenerVentasHoy() As Integer
        Using conn As OleDbConnection = Conexion.ConexionDB.AbrirConexion()
            Dim sql As String = "SELECT COUNT(*) FROM Venta WHERE [fecha] = Date()"
            Using cmd As New OleDbCommand(sql, conn)
                conn.Open()
                Return Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        End Using
    End Function

    'Ventas del mes
    Public Function ObtenerVentasMes() As Integer
        Using conn As OleDbConnection = Conexion.ConexionDB.AbrirConexion()
            Dim sql As String = "SELECT COUNT(*) FROM Venta " &
                                "WHERE Month([fecha]) = Month(Date()) " &
                                "AND Year([fecha]) = Year(Date())"
            Using cmd As New OleDbCommand(sql, conn)
                conn.Open()
                Return Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        End Using
    End Function

    'Total de productos
    Public Function ObtenerTotalProductos() As Integer
        Using conn As OleDbConnection = Conexion.ConexionDB.AbrirConexion()
            Dim sql As String = "SELECT COUNT(*) FROM Producto"
            Using cmd As New OleDbCommand(sql, conn)
                conn.Open()
                Return Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        End Using
    End Function

    'Total de clientes
    Public Function ObtenerTotalClientes() As Integer
        Using conn As OleDbConnection = Conexion.ConexionDB.AbrirConexion()
            Dim sql As String = "SELECT COUNT(*) FROM Cliente"
            Using cmd As New OleDbCommand(sql, conn)
                conn.Open()
                Return Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        End Using
    End Function

    'Productos mas vendidos
    Public Function ObtenerProductosMasVendidos() As DataTable
        Dim dt As New DataTable()
        Using conn As OleDbConnection = Conexion.ConexionDB.AbrirConexion()
            Dim sql As String =
                "SELECT TOP 5 Producto.nombre, SUM(Detalle_Venta.cantidad) AS total_vendido " &
                "FROM Detalle_Venta " &
                "INNER JOIN Producto ON Detalle_Venta.id_producto = Producto.id_producto " &
                "GROUP BY Producto.nombre " &
                "ORDER BY SUM(Detalle_Venta.cantidad) DESC"

            Using cmd As New OleDbCommand(sql, conn)
                conn.Open()
                Using adapter As New OleDbDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function


End Module