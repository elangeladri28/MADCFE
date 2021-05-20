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
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Contraseña"
        '
        'TextBoxInicioSesion_Usuario
        '
        Me.TextBoxInicioSesion_Usuario.Location = New System.Drawing.Point(85, 126)
        Me.TextBoxInicioSesion_Usuario.Name = "TextBoxInicioSesion_Usuario"
        Me.TextBoxInicioSesion_Usuario.Size = New System.Drawing.Size(210, 22)
        Me.TextBoxInicioSesion_Usuario.TabIndex = 3
        '
        'TextBoxInicioSesion_Contraseña
        '
        Me.TextBoxInicioSesion_Contraseña.Location = New System.Drawing.Point(85, 195)
        Me.TextBoxInicioSesion_Contraseña.Name = "TextBoxInicioSesion_Contraseña"
        Me.TextBoxInicioSesion_Contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxInicioSesion_Contraseña.Size = New System.Drawing.Size(210, 22)
        Me.TextBoxInicioSesion_Contraseña.TabIndex = 4
        '
        'ButtonInicioSesion_Iniciar
        '
        Me.ButtonInicioSesion_Iniciar.Location = New System.Drawing.Point(143, 255)
        Me.ButtonInicioSesion_Iniciar.Name = "ButtonInicioSesion_Iniciar"
        Me.ButtonInicioSesion_Iniciar.Size = New System.Drawing.Size(99, 33)
        Me.ButtonInicioSesion_Iniciar.TabIndex = 5
        Me.ButtonInicioSesion_Iniciar.Text = "Iniciar"
        Me.ButtonInicioSesion_Iniciar.UseVisualStyleBackColor = True
        '
        'ComboBoxInicioSesion_Tipo
        '
        Me.ComboBoxInicioSesion_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxInicioSesion_Tipo.FormattingEnabled = True
        Me.ComboBoxInicioSesion_Tipo.Items.AddRange(New Object() {"Cliente", "Empleado"})
        Me.ComboBoxInicioSesion_Tipo.Location = New System.Drawing.Point(85, 64)
        Me.ComboBoxInicioSesion_Tipo.Name = "ComboBoxInicioSesion_Tipo"
        Me.ComboBoxInicioSesion_Tipo.Size = New System.Drawing.Size(210, 24)
        Me.ComboBoxInicioSesion_Tipo.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Tipo"
        '
        'InicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MADCFE.My.Resources.Resources.CFE_removebg_preview
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(380, 346)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBoxInicioSesion_Tipo)
        Me.Controls.Add(Me.ButtonInicioSesion_Iniciar)
        Me.Controls.Add(Me.TextBoxInicioSesion_Contraseña)
        Me.Controls.Add(Me.TextBoxInicioSesion_Usuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "InicioSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de Sesión"
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
End Class
