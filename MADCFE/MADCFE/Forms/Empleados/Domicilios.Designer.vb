<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Domicilios
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
        Me.dgvDomicilios_Clientes = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDomicilios_Direccion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDomicilios_Ciudad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDomicilios_Estado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDomicilios_CodigoPostal = New System.Windows.Forms.TextBox()
        Me.dgvDomicilios_Domicilios = New System.Windows.Forms.DataGridView()
        Me.btnDomicilios_Insertar = New System.Windows.Forms.Button()
        Me.btnDomicilios_Editar = New System.Windows.Forms.Button()
        Me.btnDomicilios_Eliminar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDomicilios_idClient = New System.Windows.Forms.Label()
        Me.chbDomicilios_Activo = New System.Windows.Forms.CheckBox()
        Me.lblDomicilios_idDomicilio = New System.Windows.Forms.Label()
        CType(Me.dgvDomicilios_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDomicilios_Domicilios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDomicilios_Clientes
        '
        Me.dgvDomicilios_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDomicilios_Clientes.Location = New System.Drawing.Point(16, 32)
        Me.dgvDomicilios_Clientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvDomicilios_Clientes.Name = "dgvDomicilios_Clientes"
        Me.dgvDomicilios_Clientes.RowHeadersWidth = 51
        Me.dgvDomicilios_Clientes.Size = New System.Drawing.Size(740, 335)
        Me.dgvDomicilios_Clientes.TabIndex = 0
        Me.dgvDomicilios_Clientes.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 382)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Colonia, Calle y Número:"
        '
        'txtDomicilios_Direccion
        '
        Me.txtDomicilios_Direccion.Location = New System.Drawing.Point(20, 401)
        Me.txtDomicilios_Direccion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDomicilios_Direccion.Name = "txtDomicilios_Direccion"
        Me.txtDomicilios_Direccion.Size = New System.Drawing.Size(295, 22)
        Me.txtDomicilios_Direccion.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(320, 382)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ciudad:"
        '
        'txtDomicilios_Ciudad
        '
        Me.txtDomicilios_Ciudad.Location = New System.Drawing.Point(324, 401)
        Me.txtDomicilios_Ciudad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDomicilios_Ciudad.Name = "txtDomicilios_Ciudad"
        Me.txtDomicilios_Ciudad.Size = New System.Drawing.Size(192, 22)
        Me.txtDomicilios_Ciudad.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(521, 382)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Estado:"
        '
        'txtDomicilios_Estado
        '
        Me.txtDomicilios_Estado.Location = New System.Drawing.Point(525, 401)
        Me.txtDomicilios_Estado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDomicilios_Estado.Name = "txtDomicilios_Estado"
        Me.txtDomicilios_Estado.Size = New System.Drawing.Size(196, 22)
        Me.txtDomicilios_Estado.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 443)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "CP:"
        '
        'txtDomicilios_CodigoPostal
        '
        Me.txtDomicilios_CodigoPostal.Location = New System.Drawing.Point(20, 463)
        Me.txtDomicilios_CodigoPostal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDomicilios_CodigoPostal.Name = "txtDomicilios_CodigoPostal"
        Me.txtDomicilios_CodigoPostal.Size = New System.Drawing.Size(139, 22)
        Me.txtDomicilios_CodigoPostal.TabIndex = 8
        '
        'dgvDomicilios_Domicilios
        '
        Me.dgvDomicilios_Domicilios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDomicilios_Domicilios.Location = New System.Drawing.Point(16, 508)
        Me.dgvDomicilios_Domicilios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvDomicilios_Domicilios.Name = "dgvDomicilios_Domicilios"
        Me.dgvDomicilios_Domicilios.RowHeadersWidth = 51
        Me.dgvDomicilios_Domicilios.Size = New System.Drawing.Size(740, 240)
        Me.dgvDomicilios_Domicilios.TabIndex = 9
        Me.dgvDomicilios_Domicilios.TabStop = False
        '
        'btnDomicilios_Insertar
        '
        Me.btnDomicilios_Insertar.Location = New System.Drawing.Point(359, 457)
        Me.btnDomicilios_Insertar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDomicilios_Insertar.Name = "btnDomicilios_Insertar"
        Me.btnDomicilios_Insertar.Size = New System.Drawing.Size(100, 28)
        Me.btnDomicilios_Insertar.TabIndex = 10
        Me.btnDomicilios_Insertar.Text = "Insertar"
        Me.btnDomicilios_Insertar.UseVisualStyleBackColor = True
        '
        'btnDomicilios_Editar
        '
        Me.btnDomicilios_Editar.Location = New System.Drawing.Point(491, 457)
        Me.btnDomicilios_Editar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDomicilios_Editar.Name = "btnDomicilios_Editar"
        Me.btnDomicilios_Editar.Size = New System.Drawing.Size(100, 28)
        Me.btnDomicilios_Editar.TabIndex = 11
        Me.btnDomicilios_Editar.Text = "Editar"
        Me.btnDomicilios_Editar.UseVisualStyleBackColor = True
        '
        'btnDomicilios_Eliminar
        '
        Me.btnDomicilios_Eliminar.Location = New System.Drawing.Point(623, 457)
        Me.btnDomicilios_Eliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDomicilios_Eliminar.Name = "btnDomicilios_Eliminar"
        Me.btnDomicilios_Eliminar.Size = New System.Drawing.Size(100, 28)
        Me.btnDomicilios_Eliminar.TabIndex = 12
        Me.btnDomicilios_Eliminar.Text = "Eliminar"
        Me.btnDomicilios_Eliminar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 12)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Seleccione un cliente:"
        '
        'lblDomicilios_idClient
        '
        Me.lblDomicilios_idClient.AutoSize = True
        Me.lblDomicilios_idClient.Location = New System.Drawing.Point(435, 12)
        Me.lblDomicilios_idClient.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDomicilios_idClient.Name = "lblDomicilios_idClient"
        Me.lblDomicilios_idClient.Size = New System.Drawing.Size(146, 17)
        Me.lblDomicilios_idClient.TabIndex = 14
        Me.lblDomicilios_idClient.Text = "Seleccione un cliente:"
        Me.lblDomicilios_idClient.Visible = False
        '
        'chbDomicilios_Activo
        '
        Me.chbDomicilios_Activo.AutoSize = True
        Me.chbDomicilios_Activo.Location = New System.Drawing.Point(197, 462)
        Me.chbDomicilios_Activo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chbDomicilios_Activo.Name = "chbDomicilios_Activo"
        Me.chbDomicilios_Activo.Size = New System.Drawing.Size(68, 21)
        Me.chbDomicilios_Activo.TabIndex = 15
        Me.chbDomicilios_Activo.Text = "Activo"
        Me.chbDomicilios_Activo.UseVisualStyleBackColor = True
        '
        'lblDomicilios_idDomicilio
        '
        Me.lblDomicilios_idDomicilio.AutoSize = True
        Me.lblDomicilios_idDomicilio.Location = New System.Drawing.Point(648, 382)
        Me.lblDomicilios_idDomicilio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDomicilios_idDomicilio.Name = "lblDomicilios_idDomicilio"
        Me.lblDomicilios_idDomicilio.Size = New System.Drawing.Size(51, 17)
        Me.lblDomicilios_idDomicilio.TabIndex = 16
        Me.lblDomicilios_idDomicilio.Text = "Label6"
        Me.lblDomicilios_idDomicilio.Visible = False
        '
        'Domicilios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 763)
        Me.Controls.Add(Me.lblDomicilios_idDomicilio)
        Me.Controls.Add(Me.chbDomicilios_Activo)
        Me.Controls.Add(Me.lblDomicilios_idClient)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnDomicilios_Eliminar)
        Me.Controls.Add(Me.btnDomicilios_Editar)
        Me.Controls.Add(Me.btnDomicilios_Insertar)
        Me.Controls.Add(Me.dgvDomicilios_Domicilios)
        Me.Controls.Add(Me.txtDomicilios_CodigoPostal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDomicilios_Estado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDomicilios_Ciudad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDomicilios_Direccion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvDomicilios_Clientes)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Domicilios"
        Me.Text = "Domicilios"
        CType(Me.dgvDomicilios_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDomicilios_Domicilios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDomicilios_Clientes As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDomicilios_Direccion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDomicilios_Ciudad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDomicilios_Estado As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDomicilios_CodigoPostal As TextBox
    Friend WithEvents dgvDomicilios_Domicilios As DataGridView
    Friend WithEvents btnDomicilios_Insertar As Button
    Friend WithEvents btnDomicilios_Editar As Button
    Friend WithEvents btnDomicilios_Eliminar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lblDomicilios_idClient As Label
    Friend WithEvents chbDomicilios_Activo As CheckBox
    Friend WithEvents lblDomicilios_idDomicilio As Label
End Class
