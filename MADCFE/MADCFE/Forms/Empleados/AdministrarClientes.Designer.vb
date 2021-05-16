<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdministrarClientes
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
        Me.DGVAdministrarClientes_ = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxAdministrarClientes_Nombre = New System.Windows.Forms.TextBox()
        Me.TextBoxAdministrarClientes_Apellidos = New System.Windows.Forms.TextBox()
        Me.TextBoxAdministrarClientes_Email = New System.Windows.Forms.TextBox()
        Me.TextBoxAdministrarClientes_Curp = New System.Windows.Forms.TextBox()
        Me.DTPAdministrarClientes_FechaNac = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxAdministrarCliente_Genero = New System.Windows.Forms.ComboBox()
        Me.DTPAdministrarClientes_FechaAlta = New System.Windows.Forms.DateTimePicker()
        Me.ButtonAdministrarCliente_Insertar = New System.Windows.Forms.Button()
        Me.ButtonAdministrarClientes_Modificar = New System.Windows.Forms.Button()
        Me.ButtonAdministrarClientes_Eliminar = New System.Windows.Forms.Button()
        Me.ButtonAdministrarClientes_Aceptar = New System.Windows.Forms.Button()
        CType(Me.DGVAdministrarClientes_, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVAdministrarClientes_
        '
        Me.DGVAdministrarClientes_.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAdministrarClientes_.Location = New System.Drawing.Point(484, 46)
        Me.DGVAdministrarClientes_.Name = "DGVAdministrarClientes_"
        Me.DGVAdministrarClientes_.RowHeadersWidth = 51
        Me.DGVAdministrarClientes_.RowTemplate.Height = 24
        Me.DGVAdministrarClientes_.Size = New System.Drawing.Size(576, 386)
        Me.DGVAdministrarClientes_.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre(s)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Apellidos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "CURP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 325)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Fecha de Nacimiento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 390)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Fecha de alta"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 261)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Genero"
        '
        'TextBoxAdministrarClientes_Nombre
        '
        Me.TextBoxAdministrarClientes_Nombre.Location = New System.Drawing.Point(28, 46)
        Me.TextBoxAdministrarClientes_Nombre.Name = "TextBoxAdministrarClientes_Nombre"
        Me.TextBoxAdministrarClientes_Nombre.Size = New System.Drawing.Size(272, 22)
        Me.TextBoxAdministrarClientes_Nombre.TabIndex = 2
        '
        'TextBoxAdministrarClientes_Apellidos
        '
        Me.TextBoxAdministrarClientes_Apellidos.Location = New System.Drawing.Point(28, 109)
        Me.TextBoxAdministrarClientes_Apellidos.Name = "TextBoxAdministrarClientes_Apellidos"
        Me.TextBoxAdministrarClientes_Apellidos.Size = New System.Drawing.Size(272, 22)
        Me.TextBoxAdministrarClientes_Apellidos.TabIndex = 4
        '
        'TextBoxAdministrarClientes_Email
        '
        Me.TextBoxAdministrarClientes_Email.Location = New System.Drawing.Point(28, 169)
        Me.TextBoxAdministrarClientes_Email.Name = "TextBoxAdministrarClientes_Email"
        Me.TextBoxAdministrarClientes_Email.Size = New System.Drawing.Size(272, 22)
        Me.TextBoxAdministrarClientes_Email.TabIndex = 6
        '
        'TextBoxAdministrarClientes_Curp
        '
        Me.TextBoxAdministrarClientes_Curp.Location = New System.Drawing.Point(28, 226)
        Me.TextBoxAdministrarClientes_Curp.Name = "TextBoxAdministrarClientes_Curp"
        Me.TextBoxAdministrarClientes_Curp.Size = New System.Drawing.Size(272, 22)
        Me.TextBoxAdministrarClientes_Curp.TabIndex = 8
        '
        'DTPAdministrarClientes_FechaNac
        '
        Me.DTPAdministrarClientes_FechaNac.Location = New System.Drawing.Point(28, 345)
        Me.DTPAdministrarClientes_FechaNac.Name = "DTPAdministrarClientes_FechaNac"
        Me.DTPAdministrarClientes_FechaNac.Size = New System.Drawing.Size(272, 22)
        Me.DTPAdministrarClientes_FechaNac.TabIndex = 12
        '
        'ComboBoxAdministrarCliente_Genero
        '
        Me.ComboBoxAdministrarCliente_Genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxAdministrarCliente_Genero.FormattingEnabled = True
        Me.ComboBoxAdministrarCliente_Genero.Items.AddRange(New Object() {"Hombre", "Mujer"})
        Me.ComboBoxAdministrarCliente_Genero.Location = New System.Drawing.Point(28, 281)
        Me.ComboBoxAdministrarCliente_Genero.Name = "ComboBoxAdministrarCliente_Genero"
        Me.ComboBoxAdministrarCliente_Genero.Size = New System.Drawing.Size(272, 24)
        Me.ComboBoxAdministrarCliente_Genero.TabIndex = 10
        '
        'DTPAdministrarClientes_FechaAlta
        '
        Me.DTPAdministrarClientes_FechaAlta.Location = New System.Drawing.Point(28, 410)
        Me.DTPAdministrarClientes_FechaAlta.Name = "DTPAdministrarClientes_FechaAlta"
        Me.DTPAdministrarClientes_FechaAlta.Size = New System.Drawing.Size(272, 22)
        Me.DTPAdministrarClientes_FechaAlta.TabIndex = 14
        '
        'ButtonAdministrarCliente_Insertar
        '
        Me.ButtonAdministrarCliente_Insertar.Location = New System.Drawing.Point(484, 454)
        Me.ButtonAdministrarCliente_Insertar.Name = "ButtonAdministrarCliente_Insertar"
        Me.ButtonAdministrarCliente_Insertar.Size = New System.Drawing.Size(138, 46)
        Me.ButtonAdministrarCliente_Insertar.TabIndex = 15
        Me.ButtonAdministrarCliente_Insertar.Text = "Insertar"
        Me.ButtonAdministrarCliente_Insertar.UseVisualStyleBackColor = True
        '
        'ButtonAdministrarClientes_Modificar
        '
        Me.ButtonAdministrarClientes_Modificar.Location = New System.Drawing.Point(710, 454)
        Me.ButtonAdministrarClientes_Modificar.Name = "ButtonAdministrarClientes_Modificar"
        Me.ButtonAdministrarClientes_Modificar.Size = New System.Drawing.Size(138, 46)
        Me.ButtonAdministrarClientes_Modificar.TabIndex = 16
        Me.ButtonAdministrarClientes_Modificar.Text = "Modificar"
        Me.ButtonAdministrarClientes_Modificar.UseVisualStyleBackColor = True
        '
        'ButtonAdministrarClientes_Eliminar
        '
        Me.ButtonAdministrarClientes_Eliminar.Location = New System.Drawing.Point(922, 454)
        Me.ButtonAdministrarClientes_Eliminar.Name = "ButtonAdministrarClientes_Eliminar"
        Me.ButtonAdministrarClientes_Eliminar.Size = New System.Drawing.Size(138, 46)
        Me.ButtonAdministrarClientes_Eliminar.TabIndex = 17
        Me.ButtonAdministrarClientes_Eliminar.Text = "Eliminar"
        Me.ButtonAdministrarClientes_Eliminar.UseVisualStyleBackColor = True
        '
        'ButtonAdministrarClientes_Aceptar
        '
        Me.ButtonAdministrarClientes_Aceptar.Location = New System.Drawing.Point(922, 555)
        Me.ButtonAdministrarClientes_Aceptar.Name = "ButtonAdministrarClientes_Aceptar"
        Me.ButtonAdministrarClientes_Aceptar.Size = New System.Drawing.Size(138, 37)
        Me.ButtonAdministrarClientes_Aceptar.TabIndex = 18
        Me.ButtonAdministrarClientes_Aceptar.Text = "Aceptar"
        Me.ButtonAdministrarClientes_Aceptar.UseVisualStyleBackColor = True
        '
        'AdministrarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MADCFE.My.Resources.Resources.CFE_removebg_preview
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1099, 619)
        Me.Controls.Add(Me.ButtonAdministrarClientes_Aceptar)
        Me.Controls.Add(Me.ButtonAdministrarClientes_Eliminar)
        Me.Controls.Add(Me.ButtonAdministrarClientes_Modificar)
        Me.Controls.Add(Me.ButtonAdministrarCliente_Insertar)
        Me.Controls.Add(Me.DTPAdministrarClientes_FechaAlta)
        Me.Controls.Add(Me.ComboBoxAdministrarCliente_Genero)
        Me.Controls.Add(Me.DTPAdministrarClientes_FechaNac)
        Me.Controls.Add(Me.TextBoxAdministrarClientes_Curp)
        Me.Controls.Add(Me.TextBoxAdministrarClientes_Email)
        Me.Controls.Add(Me.TextBoxAdministrarClientes_Apellidos)
        Me.Controls.Add(Me.TextBoxAdministrarClientes_Nombre)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVAdministrarClientes_)
        Me.DoubleBuffered = True
        Me.Name = "AdministrarClientes"
        Me.Text = "Administrar Clientes"
        CType(Me.DGVAdministrarClientes_, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVAdministrarClientes_ As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxAdministrarClientes_Nombre As TextBox
    Friend WithEvents TextBoxAdministrarClientes_Apellidos As TextBox
    Friend WithEvents TextBoxAdministrarClientes_Email As TextBox
    Friend WithEvents TextBoxAdministrarClientes_Curp As TextBox
    Friend WithEvents DTPAdministrarClientes_FechaNac As DateTimePicker
    Friend WithEvents ComboBoxAdministrarCliente_Genero As ComboBox
    Friend WithEvents DTPAdministrarClientes_FechaAlta As DateTimePicker
    Friend WithEvents ButtonAdministrarCliente_Insertar As Button
    Friend WithEvents ButtonAdministrarClientes_Modificar As Button
    Friend WithEvents ButtonAdministrarClientes_Eliminar As Button
    Friend WithEvents ButtonAdministrarClientes_Aceptar As Button
End Class
