<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenu))
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        SplitContainer1 = New SplitContainer()
        Panel4 = New Panel()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        BtnReportes = New Button()
        BtnAbono = New Button()
        BtnVenta = New Button()
        BtnUsuario = New Button()
        BtnProveedor = New Button()
        BtnProducto = New Button()
        BtnCliente = New Button()
        BtnCategoria = New Button()
        Panel1 = New Panel()
        Chart1 = New DataVisualization.Charting.Chart()
        Label9 = New Label()
        DgvAgotados = New DataGridView()
        GroupBox5 = New GroupBox()
        Label10 = New Label()
        Label13 = New Label()
        GroupBox4 = New GroupBox()
        LblClientes = New Label()
        PictureBox5 = New PictureBox()
        Label8 = New Label()
        GroupBox3 = New GroupBox()
        LblProductos = New Label()
        PictureBox4 = New PictureBox()
        Label7 = New Label()
        GroupBox2 = New GroupBox()
        LblVentasMes = New Label()
        PictureBox3 = New PictureBox()
        Label6 = New Label()
        GroupBox1 = New GroupBox()
        LblVentasHoy = New Label()
        PictureBox2 = New PictureBox()
        Label5 = New Label()
        Label4 = New Label()
        BtnCerrarSesion = New Button()
        Label3 = New Label()
        Panel3 = New Panel()
        Panel2 = New Panel()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Chart1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DgvAgotados, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox5.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.BackColor = Color.White
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.BackColor = Color.WhiteSmoke
        SplitContainer1.Panel1.Controls.Add(Panel4)
        SplitContainer1.Panel1.Controls.Add(PictureBox1)
        SplitContainer1.Panel1.Controls.Add(Label2)
        SplitContainer1.Panel1.Controls.Add(Label1)
        SplitContainer1.Panel1.Controls.Add(BtnReportes)
        SplitContainer1.Panel1.Controls.Add(BtnAbono)
        SplitContainer1.Panel1.Controls.Add(BtnVenta)
        SplitContainer1.Panel1.Controls.Add(BtnUsuario)
        SplitContainer1.Panel1.Controls.Add(BtnProveedor)
        SplitContainer1.Panel1.Controls.Add(BtnProducto)
        SplitContainer1.Panel1.Controls.Add(BtnCliente)
        SplitContainer1.Panel1.Controls.Add(BtnCategoria)
        SplitContainer1.Panel1.Controls.Add(Panel1)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.BackColor = Color.WhiteSmoke
        SplitContainer1.Panel2.Controls.Add(Chart1)
        SplitContainer1.Panel2.Controls.Add(Label9)
        SplitContainer1.Panel2.Controls.Add(DgvAgotados)
        SplitContainer1.Panel2.Controls.Add(GroupBox5)
        SplitContainer1.Panel2.Controls.Add(Label13)
        SplitContainer1.Panel2.Controls.Add(GroupBox4)
        SplitContainer1.Panel2.Controls.Add(GroupBox3)
        SplitContainer1.Panel2.Controls.Add(GroupBox2)
        SplitContainer1.Panel2.Controls.Add(GroupBox1)
        SplitContainer1.Panel2.Controls.Add(Label4)
        SplitContainer1.Panel2.Controls.Add(BtnCerrarSesion)
        SplitContainer1.Panel2.Controls.Add(Label3)
        SplitContainer1.Panel2.Controls.Add(Panel3)
        SplitContainer1.Panel2.Controls.Add(Panel2)
        SplitContainer1.Size = New Size(1164, 681)
        SplitContainer1.SplitterDistance = 222
        SplitContainer1.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ActiveCaptionText
        Panel4.Location = New Point(219, 3)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1, 680)
        Panel4.TabIndex = 3
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(3, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(80, 62)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(79, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 21)
        Label2.TabIndex = 12
        Label2.Text = "Gestion de Barrio"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F)
        Label1.Location = New Point(79, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(135, 37)
        Label1.TabIndex = 11
        Label1.Text = "Mi Tienda"
        ' 
        ' BtnReportes
        ' 
        BtnReportes.BackColor = Color.FromArgb(CByte(124), CByte(146), CByte(244))
        BtnReportes.FlatStyle = FlatStyle.Flat
        BtnReportes.Font = New Font("Segoe UI", 12F)
        BtnReportes.Location = New Point(12, 117)
        BtnReportes.Name = "BtnReportes"
        BtnReportes.Size = New Size(197, 37)
        BtnReportes.TabIndex = 0
        BtnReportes.Text = "Reportes"
        BtnReportes.UseVisualStyleBackColor = False
        ' 
        ' BtnAbono
        ' 
        BtnAbono.BackColor = Color.White
        BtnAbono.FlatStyle = FlatStyle.Flat
        BtnAbono.Font = New Font("Segoe UI", 12F)
        BtnAbono.Location = New Point(12, 418)
        BtnAbono.Name = "BtnAbono"
        BtnAbono.Size = New Size(197, 37)
        BtnAbono.TabIndex = 10
        BtnAbono.Text = "Abonos"
        BtnAbono.UseVisualStyleBackColor = False
        ' 
        ' BtnVenta
        ' 
        BtnVenta.BackColor = Color.White
        BtnVenta.FlatStyle = FlatStyle.Flat
        BtnVenta.Font = New Font("Segoe UI", 12F)
        BtnVenta.Location = New Point(12, 375)
        BtnVenta.Name = "BtnVenta"
        BtnVenta.Size = New Size(197, 37)
        BtnVenta.TabIndex = 9
        BtnVenta.Text = "Ventas"
        BtnVenta.UseVisualStyleBackColor = False
        ' 
        ' BtnUsuario
        ' 
        BtnUsuario.BackColor = Color.White
        BtnUsuario.FlatStyle = FlatStyle.Flat
        BtnUsuario.Font = New Font("Segoe UI", 12F)
        BtnUsuario.Location = New Point(12, 332)
        BtnUsuario.Name = "BtnUsuario"
        BtnUsuario.Size = New Size(197, 37)
        BtnUsuario.TabIndex = 8
        BtnUsuario.Text = "Usuarios"
        BtnUsuario.UseVisualStyleBackColor = False
        ' 
        ' BtnProveedor
        ' 
        BtnProveedor.BackColor = Color.White
        BtnProveedor.FlatStyle = FlatStyle.Flat
        BtnProveedor.Font = New Font("Segoe UI", 12F)
        BtnProveedor.Location = New Point(12, 289)
        BtnProveedor.Name = "BtnProveedor"
        BtnProveedor.Size = New Size(197, 37)
        BtnProveedor.TabIndex = 7
        BtnProveedor.Text = "Proveedores"
        BtnProveedor.UseVisualStyleBackColor = False
        ' 
        ' BtnProducto
        ' 
        BtnProducto.BackColor = Color.White
        BtnProducto.FlatStyle = FlatStyle.Flat
        BtnProducto.Font = New Font("Segoe UI", 12F)
        BtnProducto.Location = New Point(12, 246)
        BtnProducto.Name = "BtnProducto"
        BtnProducto.Size = New Size(197, 37)
        BtnProducto.TabIndex = 6
        BtnProducto.Text = "Productos"
        BtnProducto.UseVisualStyleBackColor = False
        ' 
        ' BtnCliente
        ' 
        BtnCliente.BackColor = Color.White
        BtnCliente.FlatStyle = FlatStyle.Flat
        BtnCliente.Font = New Font("Segoe UI", 12F)
        BtnCliente.Location = New Point(12, 203)
        BtnCliente.Name = "BtnCliente"
        BtnCliente.Size = New Size(197, 37)
        BtnCliente.TabIndex = 5
        BtnCliente.Text = "Clientes"
        BtnCliente.UseVisualStyleBackColor = False
        ' 
        ' BtnCategoria
        ' 
        BtnCategoria.BackColor = Color.White
        BtnCategoria.FlatStyle = FlatStyle.Flat
        BtnCategoria.Font = New Font("Segoe UI", 12F)
        BtnCategoria.Location = New Point(12, 160)
        BtnCategoria.Name = "BtnCategoria"
        BtnCategoria.Size = New Size(197, 37)
        BtnCategoria.TabIndex = 4
        BtnCategoria.Text = "Categorias"
        BtnCategoria.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaptionText
        Panel1.Location = New Point(3, 98)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(217, 1)
        Panel1.TabIndex = 0
        ' 
        ' Chart1
        ' 
        ChartArea2.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Chart1.Legends.Add(Legend2)
        Chart1.Location = New Point(555, 305)
        Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Chart1.Series.Add(Series2)
        Chart1.Size = New Size(300, 300)
        Chart1.TabIndex = 19
        Chart1.Text = "Chart2"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 14F)
        Label9.Location = New Point(595, 254)
        Label9.Name = "Label9"
        Label9.Size = New Size(217, 25)
        Label9.TabIndex = 14
        Label9.Text = "Productos más vendidos"
        ' 
        ' DgvAgotados
        ' 
        DgvAgotados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvAgotados.Location = New Point(16, 289)
        DgvAgotados.Name = "DgvAgotados"
        DgvAgotados.Size = New Size(435, 342)
        DgvAgotados.TabIndex = 18
        ' 
        ' GroupBox5
        ' 
        GroupBox5.BackColor = Color.FromArgb(CByte(223), CByte(240), CByte(255))
        GroupBox5.Controls.Add(Label10)
        GroupBox5.FlatStyle = FlatStyle.Flat
        GroupBox5.Location = New Point(16, 239)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(435, 44)
        GroupBox5.TabIndex = 15
        GroupBox5.TabStop = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F)
        Label10.Location = New Point(6, 18)
        Label10.Name = "Label10"
        Label10.Size = New Size(176, 21)
        Label10.TabIndex = 13
        Label10.Text = "Productos Para Ordenar"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 20F)
        Label13.Location = New Point(6, 18)
        Label13.Name = "Label13"
        Label13.Size = New Size(121, 37)
        Label13.TabIndex = 13
        Label13.Text = "Reportes"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(LblClientes)
        GroupBox4.Controls.Add(PictureBox5)
        GroupBox4.Controls.Add(Label8)
        GroupBox4.Location = New Point(703, 140)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(200, 74)
        GroupBox4.TabIndex = 17
        GroupBox4.TabStop = False
        ' 
        ' LblClientes
        ' 
        LblClientes.AutoSize = True
        LblClientes.BackColor = Color.WhiteSmoke
        LblClientes.Font = New Font("Segoe UI", 14F)
        LblClientes.ForeColor = Color.DarkViolet
        LblClientes.Location = New Point(76, 40)
        LblClientes.Name = "LblClientes"
        LblClientes.Size = New Size(22, 25)
        LblClientes.TabIndex = 17
        LblClientes.Text = "0"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), Image)
        PictureBox5.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox5.ErrorImage = CType(resources.GetObject("PictureBox5.ErrorImage"), Image)
        PictureBox5.Location = New Point(6, 12)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(64, 56)
        PictureBox5.TabIndex = 16
        PictureBox5.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F)
        Label8.Location = New Point(76, 19)
        Label8.Name = "Label8"
        Label8.Size = New Size(65, 21)
        Label8.TabIndex = 16
        Label8.Text = "Clientes"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(LblProductos)
        GroupBox3.Controls.Add(PictureBox4)
        GroupBox3.Controls.Add(Label7)
        GroupBox3.Location = New Point(479, 140)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(200, 74)
        GroupBox3.TabIndex = 16
        GroupBox3.TabStop = False
        ' 
        ' LblProductos
        ' 
        LblProductos.AutoSize = True
        LblProductos.BackColor = Color.WhiteSmoke
        LblProductos.Font = New Font("Segoe UI", 14F)
        LblProductos.ForeColor = Color.Orange
        LblProductos.Location = New Point(76, 40)
        LblProductos.Name = "LblProductos"
        LblProductos.Size = New Size(22, 25)
        LblProductos.TabIndex = 16
        LblProductos.Text = "0"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox4.Location = New Point(6, 12)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(64, 56)
        PictureBox4.TabIndex = 15
        PictureBox4.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F)
        Label7.Location = New Point(76, 19)
        Label7.Name = "Label7"
        Label7.Size = New Size(80, 21)
        Label7.TabIndex = 15
        Label7.Text = "Productos"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(LblVentasMes)
        GroupBox2.Controls.Add(PictureBox3)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Location = New Point(251, 140)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(200, 74)
        GroupBox2.TabIndex = 15
        GroupBox2.TabStop = False
        ' 
        ' LblVentasMes
        ' 
        LblVentasMes.AutoSize = True
        LblVentasMes.BackColor = Color.WhiteSmoke
        LblVentasMes.Font = New Font("Segoe UI", 14F)
        LblVentasMes.ForeColor = Color.DeepSkyBlue
        LblVentasMes.Location = New Point(76, 40)
        LblVentasMes.Name = "LblVentasMes"
        LblVentasMes.Size = New Size(22, 25)
        LblVentasMes.TabIndex = 15
        LblVentasMes.Text = "0"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(6, 12)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(64, 56)
        PictureBox3.TabIndex = 14
        PictureBox3.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F)
        Label6.Location = New Point(76, 19)
        Label6.Name = "Label6"
        Label6.Size = New Size(114, 21)
        Label6.TabIndex = 14
        Label6.Text = "Ventas del mes"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(LblVentasHoy)
        GroupBox1.Controls.Add(PictureBox2)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Location = New Point(16, 140)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(200, 74)
        GroupBox1.TabIndex = 14
        GroupBox1.TabStop = False
        ' 
        ' LblVentasHoy
        ' 
        LblVentasHoy.AutoSize = True
        LblVentasHoy.BackColor = Color.WhiteSmoke
        LblVentasHoy.Font = New Font("Segoe UI", 14F)
        LblVentasHoy.ForeColor = Color.LimeGreen
        LblVentasHoy.Location = New Point(76, 40)
        LblVentasHoy.Name = "LblVentasHoy"
        LblVentasHoy.Size = New Size(22, 25)
        LblVentasHoy.TabIndex = 14
        LblVentasHoy.Text = "0"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(6, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(64, 56)
        PictureBox2.TabIndex = 13
        PictureBox2.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(76, 19)
        Label5.Name = "Label5"
        Label5.Size = New Size(86, 21)
        Label5.TabIndex = 13
        Label5.Text = "Ventas hoy"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(10, 117)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 21)
        Label4.TabIndex = 13
        ' 
        ' BtnCerrarSesion
        ' 
        BtnCerrarSesion.BackColor = Color.FromArgb(CByte(255), CByte(148), CByte(148))
        BtnCerrarSesion.FlatStyle = FlatStyle.Flat
        BtnCerrarSesion.Font = New Font("Segoe UI", 12F)
        BtnCerrarSesion.Location = New Point(729, 12)
        BtnCerrarSesion.Name = "BtnCerrarSesion"
        BtnCerrarSesion.Size = New Size(197, 37)
        BtnCerrarSesion.TabIndex = 13
        BtnCerrarSesion.Text = "Cerrar Sesión"
        BtnCerrarSesion.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F)
        Label3.Location = New Point(10, 59)
        Label3.Name = "Label3"
        Label3.Size = New Size(441, 25)
        Label3.TabIndex = 13
        Label3.Text = "¡Buenas tardes! esto es lo más nuevo en tu negocio"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ActiveCaptionText
        Panel3.Location = New Point(3, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1, 680)
        Panel3.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaptionText
        Panel2.Location = New Point(3, 98)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(932, 1)
        Panel2.TabIndex = 1
        ' 
        ' FrmMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1164, 681)
        Controls.Add(SplitContainer1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FrmMenu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FrmMenu"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(Chart1, ComponentModel.ISupportInitialize).EndInit()
        CType(DgvAgotados, ComponentModel.ISupportInitialize).EndInit()
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnUsuario As Button
    Friend WithEvents BtnProveedor As Button
    Friend WithEvents BtnProducto As Button
    Friend WithEvents BtnCliente As Button
    Friend WithEvents BtnCategoria As Button
    Friend WithEvents BtnReportes As Button
    Friend WithEvents BtnAbono As Button
    Friend WithEvents BtnVenta As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnCerrarSesion As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents LblProductos As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents LblVentasMes As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents LblVentasHoy As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents LblClientes As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DgvAgotados As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
