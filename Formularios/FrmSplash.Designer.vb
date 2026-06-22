<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSplash
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSplash))
        PictureBox1 = New PictureBox()
        PnlPrecarga = New Panel()
        PnlCarga = New Panel()
        LblPorcentaje = New Label()
        LblCarga = New Label()
        Timer1 = New Timer(components)
        Label1 = New Label()
        Label2 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PnlPrecarga.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(188, 54)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(141, 137)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' PnlPrecarga
        ' 
        PnlPrecarga.BackColor = Color.White
        PnlPrecarga.Controls.Add(PnlCarga)
        PnlPrecarga.Location = New Point(28, 388)
        PnlPrecarga.Name = "PnlPrecarga"
        PnlPrecarga.Size = New Size(455, 31)
        PnlPrecarga.TabIndex = 2
        ' 
        ' PnlCarga
        ' 
        PnlCarga.BackColor = Color.LightSkyBlue
        PnlCarga.BackgroundImage = CType(resources.GetObject("PnlCarga.BackgroundImage"), Image)
        PnlCarga.BackgroundImageLayout = ImageLayout.Stretch
        PnlCarga.Location = New Point(0, 0)
        PnlCarga.Name = "PnlCarga"
        PnlCarga.Size = New Size(10, 31)
        PnlCarga.TabIndex = 3
        ' 
        ' LblPorcentaje
        ' 
        LblPorcentaje.AutoSize = True
        LblPorcentaje.BackColor = Color.Transparent
        LblPorcentaje.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblPorcentaje.ForeColor = Color.White
        LblPorcentaje.Location = New Point(228, 364)
        LblPorcentaje.Name = "LblPorcentaje"
        LblPorcentaje.Size = New Size(56, 21)
        LblPorcentaje.TabIndex = 3
        LblPorcentaje.Text = "Label1"
        ' 
        ' LblCarga
        ' 
        LblCarga.AutoSize = True
        LblCarga.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblCarga.ForeColor = Color.White
        LblCarga.Location = New Point(28, 364)
        LblCarga.Name = "LblCarga"
        LblCarga.Size = New Size(0, 21)
        LblCarga.TabIndex = 4
        ' 
        ' Timer1
        ' 
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 25F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(173, 206)
        Label1.Name = "Label1"
        Label1.Size = New Size(168, 46)
        Label1.TabIndex = 5
        Label1.Text = "Mi Tienda"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 18F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(139, 266)
        Label2.Name = "Label2"
        Label2.Size = New Size(232, 32)
        Label2.TabIndex = 6
        Label2.Text = "- Gestión de Barrio -"
        ' 
        ' FrmSplash
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Navy
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(508, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(LblCarga)
        Controls.Add(LblPorcentaje)
        Controls.Add(PnlPrecarga)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FrmSplash"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FrmSplash"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PnlPrecarga.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PnlPrecarga As Panel
    Friend WithEvents PnlCarga As Panel
    Friend WithEvents LblPorcentaje As Label
    Friend WithEvents LblCarga As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
