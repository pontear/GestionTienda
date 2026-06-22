<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        TextUser = New TextBox()
        TextPassword = New TextBox()
        BtnCancelar = New Button()
        BtnLogin = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextUser
        ' 
        TextUser.BackColor = Color.Azure
        TextUser.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextUser.Location = New Point(96, 186)
        TextUser.Multiline = True
        TextUser.Name = "TextUser"
        TextUser.Size = New Size(198, 30)
        TextUser.TabIndex = 0
        ' 
        ' TextPassword
        ' 
        TextPassword.BackColor = Color.Azure
        TextPassword.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextPassword.Location = New Point(96, 258)
        TextPassword.Multiline = True
        TextPassword.Name = "TextPassword"
        TextPassword.PasswordChar = " "c
        TextPassword.Size = New Size(198, 33)
        TextPassword.TabIndex = 1
        ' 
        ' BtnCancelar
        ' 
        BtnCancelar.BackColor = Color.DeepSkyBlue
        BtnCancelar.FlatStyle = FlatStyle.Flat
        BtnCancelar.Font = New Font("Segoe UI", 12F)
        BtnCancelar.Location = New Point(191, 337)
        BtnCancelar.Name = "BtnCancelar"
        BtnCancelar.Size = New Size(103, 37)
        BtnCancelar.TabIndex = 3
        BtnCancelar.Text = "Salir"
        BtnCancelar.UseVisualStyleBackColor = False
        ' 
        ' BtnLogin
        ' 
        BtnLogin.BackColor = Color.SkyBlue
        BtnLogin.FlatStyle = FlatStyle.Flat
        BtnLogin.Font = New Font("Segoe UI", 12F)
        BtnLogin.Location = New Point(55, 337)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(103, 37)
        BtnLogin.TabIndex = 2
        BtnLogin.Text = "Iniciar"
        BtnLogin.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Azure
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(55, 186)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(35, 30)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Azure
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(55, 258)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(35, 33)
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox3.Location = New Point(124, 25)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(105, 98)
        PictureBox3.TabIndex = 6
        PictureBox3.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(94, 162)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 21)
        Label1.TabIndex = 7
        Label1.Text = "Usuario"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(96, 234)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 21)
        Label2.TabIndex = 8
        Label2.Text = "Contraseña"
        ' 
        ' FrmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Navy
        ClientSize = New Size(350, 429)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(BtnLogin)
        Controls.Add(BtnCancelar)
        Controls.Add(TextPassword)
        Controls.Add(TextUser)
        FormBorderStyle = FormBorderStyle.None
        Name = "FrmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FrmLogin"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextUser As TextBox
    Friend WithEvents TextPassword As TextBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnLogin As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
