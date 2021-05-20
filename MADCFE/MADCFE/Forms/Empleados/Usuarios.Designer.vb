<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsuarios_Username = New System.Windows.Forms.TextBox()
        Me.txtUsuarios_Password = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbUsuarios_TipoUsuario = New System.Windows.Forms.ComboBox()
        Me.txtUsuarios_Nombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUsuarios_Curp = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUsuarios_Rfc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpUsuarios_FechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbUsuarios_Genero = New System.Windows.Forms.ComboBox()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.btnUsuarios_Insertar = New System.Windows.Forms.Button()
        Me.btnUsuarios_Editar = New System.Windows.Forms.Button()
        Me.lblUsuarios_id = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtUsuarios_Modificado = New System.Windows.Forms.TextBox()
        Me.chbUsuarios_Bloqueado = New System.Windows.Forms.CheckBox()
        Me.chbUsuarios_Activo = New System.Windows.Forms.CheckBox()
        Me.lblUsuarios_Tried = New System.Windows.Forms.Label()
        Me.btnUsuarios_Eliminar = New System.Windows.Forms.Button()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(224, 85)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre completo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre de Usuario:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsuarios_Username
        '
        Me.txtUsuarios_Username.Location = New System.Drawing.Point(20, 48)
        Me.txtUsuarios_Username.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsuarios_Username.Name = "txtUsuarios_Username"
        Me.txtUsuarios_Username.Size = New System.Drawing.Size(163, 22)
        Me.txtUsuarios_Username.TabIndex = 3
        '
        'txtUsuarios_Password
        '
        Me.txtUsuarios_Password.Location = New System.Drawing.Point(228, 48)
        Me.txtUsuarios_Password.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsuarios_Password.Name = "txtUsuarios_Password"
        Me.txtUsuarios_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUsuarios_Password.Size = New System.Drawing.Size(163, 22)
        Me.txtUsuarios_Password.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(224, 28)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Contraseña:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 84)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tipo de usuario:"
        '
        'cbUsuarios_TipoUsuario
        '
        Me.cbUsuarios_TipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUsuarios_TipoUsuario.FormattingEnabled = True
        Me.cbUsuarios_TipoUsuario.Items.AddRange(New Object() {"Cliente", "Empleado", "Administrador"})
        Me.cbUsuarios_TipoUsuario.Location = New System.Drawing.Point(16, 103)
        Me.cbUsuarios_TipoUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.cbUsuarios_TipoUsuario.Name = "cbUsuarios_TipoUsuario"
        Me.cbUsuarios_TipoUsuario.Size = New System.Drawing.Size(163, 24)
        Me.cbUsuarios_TipoUsuario.TabIndex = 7
        '
        'txtUsuarios_Nombre
        '
        Me.txtUsuarios_Nombre.Location = New System.Drawing.Point(228, 105)
        Me.txtUsuarios_Nombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsuarios_Nombre.Name = "txtUsuarios_Nombre"
        Me.txtUsuarios_Nombre.Size = New System.Drawing.Size(276, 22)
        Me.txtUsuarios_Nombre.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 146)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "CURP:"
        '
        'txtUsuarios_Curp
        '
        Me.txtUsuarios_Curp.Location = New System.Drawing.Point(16, 166)
        Me.txtUsuarios_Curp.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsuarios_Curp.Name = "txtUsuarios_Curp"
        Me.txtUsuarios_Curp.Size = New System.Drawing.Size(233, 22)
        Me.txtUsuarios_Curp.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(288, 146)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "RFC:"
        '
        'txtUsuarios_Rfc
        '
        Me.txtUsuarios_Rfc.Location = New System.Drawing.Point(289, 166)
        Me.txtUsuarios_Rfc.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsuarios_Rfc.Name = "txtUsuarios_Rfc"
        Me.txtUsuarios_Rfc.Size = New System.Drawing.Size(163, 22)
        Me.txtUsuarios_Rfc.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 219)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Fecha de nacimiento:"
        '
        'dtpUsuarios_FechaNacimiento
        '
        Me.dtpUsuarios_FechaNacimiento.Location = New System.Drawing.Point(16, 239)
        Me.dtpUsuarios_FechaNacimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpUsuarios_FechaNacimiento.Name = "dtpUsuarios_FechaNacimiento"
        Me.dtpUsuarios_FechaNacimiento.Size = New System.Drawing.Size(265, 22)
        Me.dtpUsuarios_FechaNacimiento.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(305, 218)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Género:"
        '
        'cbUsuarios_Genero
        '
        Me.cbUsuarios_Genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUsuarios_Genero.FormattingEnabled = True
        Me.cbUsuarios_Genero.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.cbUsuarios_Genero.Location = New System.Drawing.Point(312, 238)
        Me.cbUsuarios_Genero.Margin = New System.Windows.Forms.Padding(4)
        Me.cbUsuarios_Genero.Name = "cbUsuarios_Genero"
        Me.cbUsuarios_Genero.Size = New System.Drawing.Size(140, 24)
        Me.cbUsuarios_Genero.TabIndex = 17
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Location = New System.Drawing.Point(513, 15)
        Me.dgvUsuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.RowHeadersWidth = 51
        Me.dgvUsuarios.Size = New System.Drawing.Size(1112, 489)
        Me.dgvUsuarios.TabIndex = 18
        '
        'btnUsuarios_Insertar
        '
        Me.btnUsuarios_Insertar.Location = New System.Drawing.Point(43, 400)
        Me.btnUsuarios_Insertar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUsuarios_Insertar.Name = "btnUsuarios_Insertar"
        Me.btnUsuarios_Insertar.Size = New System.Drawing.Size(100, 28)
        Me.btnUsuarios_Insertar.TabIndex = 19
        Me.btnUsuarios_Insertar.Text = "Insertar"
        Me.btnUsuarios_Insertar.UseVisualStyleBackColor = True
        '
        'btnUsuarios_Editar
        '
        Me.btnUsuarios_Editar.Location = New System.Drawing.Point(151, 400)
        Me.btnUsuarios_Editar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUsuarios_Editar.Name = "btnUsuarios_Editar"
        Me.btnUsuarios_Editar.Size = New System.Drawing.Size(100, 28)
        Me.btnUsuarios_Editar.TabIndex = 20
        Me.btnUsuarios_Editar.Text = "Editar"
        Me.btnUsuarios_Editar.UseVisualStyleBackColor = True
        '
        'lblUsuarios_id
        '
        Me.lblUsuarios_id.AutoSize = True
        Me.lblUsuarios_id.Location = New System.Drawing.Point(15, 348)
        Me.lblUsuarios_id.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuarios_id.Name = "lblUsuarios_id"
        Me.lblUsuarios_id.Size = New System.Drawing.Size(101, 17)
        Me.lblUsuarios_id.TabIndex = 21
        Me.lblUsuarios_id.Text = "OLA EQUISDE"
        Me.lblUsuarios_id.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 286)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 17)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Modificado por:"
        '
        'txtUsuarios_Modificado
        '
        Me.txtUsuarios_Modificado.Location = New System.Drawing.Point(16, 305)
        Me.txtUsuarios_Modificado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsuarios_Modificado.Name = "txtUsuarios_Modificado"
        Me.txtUsuarios_Modificado.ReadOnly = True
        Me.txtUsuarios_Modificado.Size = New System.Drawing.Size(163, 22)
        Me.txtUsuarios_Modificado.TabIndex = 23
        Me.txtUsuarios_Modificado.TabStop = False
        '
        'chbUsuarios_Bloqueado
        '
        Me.chbUsuarios_Bloqueado.AutoSize = True
        Me.chbUsuarios_Bloqueado.Location = New System.Drawing.Point(207, 305)
        Me.chbUsuarios_Bloqueado.Margin = New System.Windows.Forms.Padding(4)
        Me.chbUsuarios_Bloqueado.Name = "chbUsuarios_Bloqueado"
        Me.chbUsuarios_Bloqueado.Size = New System.Drawing.Size(98, 21)
        Me.chbUsuarios_Bloqueado.TabIndex = 24
        Me.chbUsuarios_Bloqueado.Text = "Bloqueado"
        Me.chbUsuarios_Bloqueado.UseVisualStyleBackColor = True
        '
        'chbUsuarios_Activo
        '
        Me.chbUsuarios_Activo.AutoSize = True
        Me.chbUsuarios_Activo.Location = New System.Drawing.Point(337, 305)
        Me.chbUsuarios_Activo.Margin = New System.Windows.Forms.Padding(4)
        Me.chbUsuarios_Activo.Name = "chbUsuarios_Activo"
        Me.chbUsuarios_Activo.Size = New System.Drawing.Size(68, 21)
        Me.chbUsuarios_Activo.TabIndex = 25
        Me.chbUsuarios_Activo.Text = "Activo"
        Me.chbUsuarios_Activo.UseVisualStyleBackColor = True
        '
        'lblUsuarios_Tried
        '
        Me.lblUsuarios_Tried.AutoSize = True
        Me.lblUsuarios_Tried.Location = New System.Drawing.Point(128, 348)
        Me.lblUsuarios_Tried.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuarios_Tried.Name = "lblUsuarios_Tried"
        Me.lblUsuarios_Tried.Size = New System.Drawing.Size(47, 17)
        Me.lblUsuarios_Tried.TabIndex = 26
        Me.lblUsuarios_Tried.Text = "LMAO"
        Me.lblUsuarios_Tried.Visible = False
        '
        'btnUsuarios_Eliminar
        '
        Me.btnUsuarios_Eliminar.Location = New System.Drawing.Point(259, 400)
        Me.btnUsuarios_Eliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUsuarios_Eliminar.Name = "btnUsuarios_Eliminar"
        Me.btnUsuarios_Eliminar.Size = New System.Drawing.Size(100, 28)
        Me.btnUsuarios_Eliminar.TabIndex = 27
        Me.btnUsuarios_Eliminar.Text = "Eliminar"
        Me.btnUsuarios_Eliminar.UseVisualStyleBackColor = True
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MADCFE.My.Resources.Resources.CFE_removebg_preview
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1641, 529)
        Me.Controls.Add(Me.btnUsuarios_Eliminar)
        Me.Controls.Add(Me.lblUsuarios_Tried)
        Me.Controls.Add(Me.chbUsuarios_Activo)
        Me.Controls.Add(Me.chbUsuarios_Bloqueado)
        Me.Controls.Add(Me.txtUsuarios_Modificado)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblUsuarios_id)
        Me.Controls.Add(Me.btnUsuarios_Editar)
        Me.Controls.Add(Me.btnUsuarios_Insertar)
        Me.Controls.Add(Me.dgvUsuarios)
        Me.Controls.Add(Me.cbUsuarios_Genero)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpUsuarios_FechaNacimiento)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtUsuarios_Rfc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtUsuarios_Curp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtUsuarios_Nombre)
        Me.Controls.Add(Me.cbUsuarios_TipoUsuario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtUsuarios_Password)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUsuarios_Username)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Usuarios"
        Me.Text = "Usuarios"
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsuarios_Username As TextBox
    Friend WithEvents txtUsuarios_Password As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbUsuarios_TipoUsuario As ComboBox
    Friend WithEvents txtUsuarios_Nombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtUsuarios_Curp As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtUsuarios_Rfc As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpUsuarios_FechaNacimiento As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents cbUsuarios_Genero As ComboBox
    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents btnUsuarios_Insertar As Button
    Friend WithEvents btnUsuarios_Editar As Button
    Friend WithEvents lblUsuarios_id As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtUsuarios_Modificado As TextBox
    Friend WithEvents chbUsuarios_Bloqueado As CheckBox
    Friend WithEvents chbUsuarios_Activo As CheckBox
    Friend WithEvents lblUsuarios_Tried As Label
    Friend WithEvents btnUsuarios_Eliminar As Button
End Class
