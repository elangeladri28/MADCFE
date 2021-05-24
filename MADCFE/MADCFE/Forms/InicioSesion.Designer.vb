<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InicioSesion
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxInicioSesion_Usuario = New System.Windows.Forms.TextBox()
        Me.TextBoxInicioSesion_Contraseña = New System.Windows.Forms.TextBox()
        Me.ButtonInicioSesion_Iniciar = New System.Windows.Forms.Button()
        Me.ComboBoxInicioSesion_Tipo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chbIniciarSesion_RememberMe = New System.Windows.Forms.CheckBox()
        Me.dgvLogin_Users = New System.Windows.Forms.DataGridView()
        Me.dgvLogin_password = New System.Windows.Forms.DataGridView()
        Me.dgviniciosesion = New System.Windows.Forms.DataGridView()
        Me.dgvnopassword = New System.Windows.Forms.DataGridView()
        Me.LblBloqueado = New System.Windows.Forms.Label()
        CType(Me.dgvLogin_Users, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLogin_password, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgviniciosesion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvnopassword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Contraseña"
        '
        'TextBoxInicioSesion_Usuario
        '
        Me.TextBoxInicioSesion_Usuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBoxInicioSesion_Usuario.Location = New System.Drawing.Point(81, 126)
        Me.TextBoxInicioSesion_Usuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxInicioSesion_Usuario.Name = "TextBoxInicioSesion_Usuario"
        Me.TextBoxInicioSesion_Usuario.Size = New System.Drawing.Size(209, 22)
        Me.TextBoxInicioSesion_Usuario.TabIndex = 3
        '
        'TextBoxInicioSesion_Contraseña
        '
        Me.TextBoxInicioSesion_Contraseña.Location = New System.Drawing.Point(81, 194)
        Me.TextBoxInicioSesion_Contraseña.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxInicioSesion_Contraseña.Name = "TextBoxInicioSesion_Contraseña"
        Me.TextBoxInicioSesion_Contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxInicioSesion_Contraseña.Size = New System.Drawing.Size(209, 22)
        Me.TextBoxInicioSesion_Contraseña.TabIndex = 4
        '
        'ButtonInicioSesion_Iniciar
        '
        Me.ButtonInicioSesion_Iniciar.Location = New System.Drawing.Point(201, 278)
        Me.ButtonInicioSesion_Iniciar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonInicioSesion_Iniciar.Name = "ButtonInicioSesion_Iniciar"
        Me.ButtonInicioSesion_Iniciar.Size = New System.Drawing.Size(99, 33)
        Me.ButtonInicioSesion_Iniciar.TabIndex = 6
        Me.ButtonInicioSesion_Iniciar.Text = "Iniciar"
        Me.ButtonInicioSesion_Iniciar.UseVisualStyleBackColor = True
        '
        'ComboBoxInicioSesion_Tipo
        '
        Me.ComboBoxInicioSesion_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxInicioSesion_Tipo.FormattingEnabled = True
        Me.ComboBoxInicioSesion_Tipo.Items.AddRange(New Object() {"Cliente", "Empleado", "Administrador"})
        Me.ComboBoxInicioSesion_Tipo.Location = New System.Drawing.Point(81, 64)
        Me.ComboBoxInicioSesion_Tipo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxInicioSesion_Tipo.Name = "ComboBoxInicioSesion_Tipo"
        Me.ComboBoxInicioSesion_Tipo.Size = New System.Drawing.Size(209, 24)
        Me.ComboBoxInicioSesion_Tipo.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Tipo"
        '
        'chbIniciarSesion_RememberMe
        '
        Me.chbIniciarSesion_RememberMe.AutoSize = True
        Me.chbIniciarSesion_RememberMe.Location = New System.Drawing.Point(68, 286)
        Me.chbIniciarSesion_RememberMe.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chbIniciarSesion_RememberMe.Name = "chbIniciarSesion_RememberMe"
        Me.chbIniciarSesion_RememberMe.Size = New System.Drawing.Size(108, 21)
        Me.chbIniciarSesion_RememberMe.TabIndex = 5
        Me.chbIniciarSesion_RememberMe.Text = "Recordarme"
        Me.chbIniciarSesion_RememberMe.UseVisualStyleBackColor = True
        '
        'dgvLogin_Users
        '
        Me.dgvLogin_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLogin_Users.Location = New System.Drawing.Point(185, 423)
        Me.dgvLogin_Users.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvLogin_Users.Name = "dgvLogin_Users"
        Me.dgvLogin_Users.RowHeadersWidth = 51
        Me.dgvLogin_Users.Size = New System.Drawing.Size(68, 129)
        Me.dgvLogin_Users.TabIndex = 7
        Me.dgvLogin_Users.Visible = False
        '
        'dgvLogin_password
        '
        Me.dgvLogin_password.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLogin_password.Location = New System.Drawing.Point(16, 423)
        Me.dgvLogin_password.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvLogin_password.Name = "dgvLogin_password"
        Me.dgvLogin_password.RowHeadersWidth = 51
        Me.dgvLogin_password.Size = New System.Drawing.Size(124, 137)
        Me.dgvLogin_password.TabIndex = 8
        Me.dgvLogin_password.Visible = False
        '
        'dgviniciosesion
        '
        Me.dgviniciosesion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgviniciosesion.Location = New System.Drawing.Point(429, 258)
        Me.dgviniciosesion.Name = "dgviniciosesion"
        Me.dgviniciosesion.RowHeadersWidth = 51
        Me.dgviniciosesion.RowTemplate.Height = 24
        Me.dgviniciosesion.Size = New System.Drawing.Size(240, 150)
        Me.dgviniciosesion.TabIndex = 9
        '
        'dgvnopassword
        '
        Me.dgvnopassword.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvnopassword.Location = New System.Drawing.Point(429, 66)
        Me.dgvnopassword.Name = "dgvnopassword"
        Me.dgvnopassword.RowHeadersWidth = 51
        Me.dgvnopassword.RowTemplate.Height = 24
        Me.dgvnopassword.Size = New System.Drawing.Size(240, 150)
        Me.dgvnopassword.TabIndex = 10
        '
        'LblBloqueado
        '
        Me.LblBloqueado.AutoSize = True
        Me.LblBloqueado.Location = New System.Drawing.Point(85, 9)
        Me.LblBloqueado.Name = "LblBloqueado"
        Me.LblBloqueado.Size = New System.Drawing.Size(96, 17)
        Me.LblBloqueado.TabIndex = 11
        Me.LblBloqueado.Text = "BLOQUEADO"
        '
        'InicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MADCFE.My.Resources.Resources.CFE_removebg_preview
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(844, 728)
        Me.Controls.Add(Me.LblBloqueado)
        Me.Controls.Add(Me.dgvnopassword)
        Me.Controls.Add(Me.dgviniciosesion)
        Me.Controls.Add(Me.dgvLogin_password)
        Me.Controls.Add(Me.dgvLogin_Users)
        Me.Controls.Add(Me.chbIniciarSesion_RememberMe)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBoxInicioSesion_Tipo)
        Me.Controls.Add(Me.ButtonInicioSesion_Iniciar)
        Me.Controls.Add(Me.TextBoxInicioSesion_Contraseña)
        Me.Controls.Add(Me.TextBoxInicioSesion_Usuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "InicioSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de Sesión"
        CType(Me.dgvLogin_Users, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLogin_password, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgviniciosesion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvnopassword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxInicioSesion_Usuario As TextBox
    Friend WithEvents TextBoxInicioSesion_Contraseña As TextBox
    Friend WithEvents ButtonInicioSesion_Iniciar As Button
    Friend WithEvents ComboBoxInicioSesion_Tipo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents chbIniciarSesion_RememberMe As CheckBox
    Friend WithEvents dgvLogin_Users As DataGridView
    Friend WithEvents dgvLogin_password As DataGridView
    Friend WithEvents dgviniciosesion As DataGridView
    Friend WithEvents dgvnopassword As DataGridView
    Friend WithEvents LblBloqueado As Label
End Class
