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
        CType(Me.dgvLogin_Users, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLogin_password, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 85)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 137)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Contraseña"
        '
        'TextBoxInicioSesion_Usuario
        '
        Me.TextBoxInicioSesion_Usuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBoxInicioSesion_Usuario.Location = New System.Drawing.Point(64, 102)
        Me.TextBoxInicioSesion_Usuario.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxInicioSesion_Usuario.Name = "TextBoxInicioSesion_Usuario"
        Me.TextBoxInicioSesion_Usuario.Size = New System.Drawing.Size(158, 20)
        Me.TextBoxInicioSesion_Usuario.TabIndex = 3
        '
        'TextBoxInicioSesion_Contraseña
        '
        Me.TextBoxInicioSesion_Contraseña.Location = New System.Drawing.Point(64, 158)
        Me.TextBoxInicioSesion_Contraseña.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxInicioSesion_Contraseña.Name = "TextBoxInicioSesion_Contraseña"
        Me.TextBoxInicioSesion_Contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxInicioSesion_Contraseña.Size = New System.Drawing.Size(158, 20)
        Me.TextBoxInicioSesion_Contraseña.TabIndex = 4
        '
        'ButtonInicioSesion_Iniciar
        '
        Me.ButtonInicioSesion_Iniciar.Location = New System.Drawing.Point(139, 227)
        Me.ButtonInicioSesion_Iniciar.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonInicioSesion_Iniciar.Name = "ButtonInicioSesion_Iniciar"
        Me.ButtonInicioSesion_Iniciar.Size = New System.Drawing.Size(74, 27)
        Me.ButtonInicioSesion_Iniciar.TabIndex = 6
        Me.ButtonInicioSesion_Iniciar.Text = "Iniciar"
        Me.ButtonInicioSesion_Iniciar.UseVisualStyleBackColor = True
        '
        'ComboBoxInicioSesion_Tipo
        '
        Me.ComboBoxInicioSesion_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxInicioSesion_Tipo.FormattingEnabled = True
        Me.ComboBoxInicioSesion_Tipo.Items.AddRange(New Object() {"Cliente", "Empleado"})
        Me.ComboBoxInicioSesion_Tipo.Location = New System.Drawing.Point(64, 52)
        Me.ComboBoxInicioSesion_Tipo.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxInicioSesion_Tipo.Name = "ComboBoxInicioSesion_Tipo"
        Me.ComboBoxInicioSesion_Tipo.Size = New System.Drawing.Size(158, 21)
        Me.ComboBoxInicioSesion_Tipo.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 36)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Tipo"
        '
        'chbIniciarSesion_RememberMe
        '
        Me.chbIniciarSesion_RememberMe.AutoSize = True
        Me.chbIniciarSesion_RememberMe.Location = New System.Drawing.Point(39, 233)
        Me.chbIniciarSesion_RememberMe.Name = "chbIniciarSesion_RememberMe"
        Me.chbIniciarSesion_RememberMe.Size = New System.Drawing.Size(84, 17)
        Me.chbIniciarSesion_RememberMe.TabIndex = 5
        Me.chbIniciarSesion_RememberMe.Text = "Recordarme"
        Me.chbIniciarSesion_RememberMe.UseVisualStyleBackColor = True
        '
        'dgvLogin_Users
        '
        Me.dgvLogin_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLogin_Users.Location = New System.Drawing.Point(228, 197)
        Me.dgvLogin_Users.Name = "dgvLogin_Users"
        Me.dgvLogin_Users.Size = New System.Drawing.Size(34, 31)
        Me.dgvLogin_Users.TabIndex = 7
        Me.dgvLogin_Users.Visible = False
        '
        'dgvLogin_password
        '
        Me.dgvLogin_password.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLogin_password.Location = New System.Drawing.Point(12, 307)
        Me.dgvLogin_password.Name = "dgvLogin_password"
        Me.dgvLogin_password.Size = New System.Drawing.Size(261, 148)
        Me.dgvLogin_password.TabIndex = 8
        '
        'InicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MADCFE.My.Resources.Resources.CFE_removebg_preview
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(285, 479)
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
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "InicioSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de Sesión"
        CType(Me.dgvLogin_Users, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLogin_password, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
