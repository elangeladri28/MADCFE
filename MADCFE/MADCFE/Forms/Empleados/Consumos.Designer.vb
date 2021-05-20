<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consumos
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
        Me.dgvConsumos_Clientes = New System.Windows.Forms.DataGridView()
        Me.dgvConsumos_Consumos = New System.Windows.Forms.DataGridView()
        Me.txtConsumos_NombreCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConsumos_BuscarCliente = New System.Windows.Forms.Button()
        Me.txtConsumos_Medidor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtConsumos_Kw = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpConsumos_Date = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnConsumos_Insertar = New System.Windows.Forms.Button()
        Me.btnConsumos_Editar = New System.Windows.Forms.Button()
        Me.btnConsumos_Eliminar = New System.Windows.Forms.Button()
        Me.lblConsumos_idCliente = New System.Windows.Forms.Label()
        Me.cbConsumos_Regimen = New System.Windows.Forms.ComboBox()
        CType(Me.dgvConsumos_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvConsumos_Consumos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvConsumos_Clientes
        '
        Me.dgvConsumos_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsumos_Clientes.Location = New System.Drawing.Point(12, 59)
        Me.dgvConsumos_Clientes.Name = "dgvConsumos_Clientes"
        Me.dgvConsumos_Clientes.Size = New System.Drawing.Size(540, 168)
        Me.dgvConsumos_Clientes.TabIndex = 0
        '
        'dgvConsumos_Consumos
        '
        Me.dgvConsumos_Consumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsumos_Consumos.Location = New System.Drawing.Point(12, 478)
        Me.dgvConsumos_Consumos.Name = "dgvConsumos_Consumos"
        Me.dgvConsumos_Consumos.Size = New System.Drawing.Size(540, 200)
        Me.dgvConsumos_Consumos.TabIndex = 1
        '
        'txtConsumos_NombreCliente
        '
        Me.txtConsumos_NombreCliente.Location = New System.Drawing.Point(12, 33)
        Me.txtConsumos_NombreCliente.Name = "txtConsumos_NombreCliente"
        Me.txtConsumos_NombreCliente.Size = New System.Drawing.Size(213, 20)
        Me.txtConsumos_NombreCliente.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre del cliente:"
        '
        'btnConsumos_BuscarCliente
        '
        Me.btnConsumos_BuscarCliente.Location = New System.Drawing.Point(231, 30)
        Me.btnConsumos_BuscarCliente.Name = "btnConsumos_BuscarCliente"
        Me.btnConsumos_BuscarCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnConsumos_BuscarCliente.TabIndex = 4
        Me.btnConsumos_BuscarCliente.Text = "Buscar"
        Me.btnConsumos_BuscarCliente.UseVisualStyleBackColor = True
        '
        'txtConsumos_Medidor
        '
        Me.txtConsumos_Medidor.Location = New System.Drawing.Point(11, 283)
        Me.txtConsumos_Medidor.Name = "txtConsumos_Medidor"
        Me.txtConsumos_Medidor.ReadOnly = True
        Me.txtConsumos_Medidor.Size = New System.Drawing.Size(100, 20)
        Me.txtConsumos_Medidor.TabIndex = 5
        Me.txtConsumos_Medidor.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 267)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Número de medidor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(118, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Esquema de cobro:"
        '
        'txtConsumos_Kw
        '
        Me.txtConsumos_Kw.Location = New System.Drawing.Point(13, 332)
        Me.txtConsumos_Kw.Name = "txtConsumos_Kw"
        Me.txtConsumos_Kw.Size = New System.Drawing.Size(100, 20)
        Me.txtConsumos_Kw.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 316)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "KW consumidos:"
        '
        'dtpConsumos_Date
        '
        Me.dtpConsumos_Date.CustomFormat = ""
        Me.dtpConsumos_Date.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpConsumos_Date.Location = New System.Drawing.Point(121, 333)
        Me.dtpConsumos_Date.MaxDate = New Date(2021, 5, 17, 0, 0, 0, 0)
        Me.dtpConsumos_Date.Name = "dtpConsumos_Date"
        Me.dtpConsumos_Date.Size = New System.Drawing.Size(200, 20)
        Me.dtpConsumos_Date.TabIndex = 11
        Me.dtpConsumos_Date.Value = New Date(2021, 5, 17, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(118, 317)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Fecha de consumo:"
        '
        'btnConsumos_Insertar
        '
        Me.btnConsumos_Insertar.Location = New System.Drawing.Point(26, 440)
        Me.btnConsumos_Insertar.Name = "btnConsumos_Insertar"
        Me.btnConsumos_Insertar.Size = New System.Drawing.Size(75, 23)
        Me.btnConsumos_Insertar.TabIndex = 13
        Me.btnConsumos_Insertar.Text = "Insertar"
        Me.btnConsumos_Insertar.UseVisualStyleBackColor = True
        '
        'btnConsumos_Editar
        '
        Me.btnConsumos_Editar.Location = New System.Drawing.Point(129, 440)
        Me.btnConsumos_Editar.Name = "btnConsumos_Editar"
        Me.btnConsumos_Editar.Size = New System.Drawing.Size(75, 23)
        Me.btnConsumos_Editar.TabIndex = 14
        Me.btnConsumos_Editar.Text = "Editar"
        Me.btnConsumos_Editar.UseVisualStyleBackColor = True
        '
        'btnConsumos_Eliminar
        '
        Me.btnConsumos_Eliminar.Location = New System.Drawing.Point(231, 440)
        Me.btnConsumos_Eliminar.Name = "btnConsumos_Eliminar"
        Me.btnConsumos_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnConsumos_Eliminar.TabIndex = 15
        Me.btnConsumos_Eliminar.Text = "Eliminar"
        Me.btnConsumos_Eliminar.UseVisualStyleBackColor = True
        '
        'lblConsumos_idCliente
        '
        Me.lblConsumos_idCliente.AutoSize = True
        Me.lblConsumos_idCliente.Location = New System.Drawing.Point(385, 17)
        Me.lblConsumos_idCliente.Name = "lblConsumos_idCliente"
        Me.lblConsumos_idCliente.Size = New System.Drawing.Size(39, 13)
        Me.lblConsumos_idCliente.TabIndex = 16
        Me.lblConsumos_idCliente.Text = "Label6"
        '
        'cbConsumos_Regimen
        '
        Me.cbConsumos_Regimen.FormattingEnabled = True
        Me.cbConsumos_Regimen.ItemHeight = 13
        Me.cbConsumos_Regimen.Location = New System.Drawing.Point(116, 282)
        Me.cbConsumos_Regimen.Name = "cbConsumos_Regimen"
        Me.cbConsumos_Regimen.Size = New System.Drawing.Size(121, 21)
        Me.cbConsumos_Regimen.TabIndex = 8
        '
        'Consumos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 690)
        Me.Controls.Add(Me.cbConsumos_Regimen)
        Me.Controls.Add(Me.lblConsumos_idCliente)
        Me.Controls.Add(Me.btnConsumos_Eliminar)
        Me.Controls.Add(Me.btnConsumos_Editar)
        Me.Controls.Add(Me.btnConsumos_Insertar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpConsumos_Date)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtConsumos_Kw)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtConsumos_Medidor)
        Me.Controls.Add(Me.btnConsumos_BuscarCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtConsumos_NombreCliente)
        Me.Controls.Add(Me.dgvConsumos_Consumos)
        Me.Controls.Add(Me.dgvConsumos_Clientes)
        Me.Name = "Consumos"
        Me.Text = "Consumos"
        CType(Me.dgvConsumos_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvConsumos_Consumos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvConsumos_Clientes As DataGridView
    Friend WithEvents dgvConsumos_Consumos As DataGridView
    Friend WithEvents txtConsumos_NombreCliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnConsumos_BuscarCliente As Button
    Friend WithEvents txtConsumos_Medidor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtConsumos_Kw As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpConsumos_Date As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents btnConsumos_Insertar As Button
    Friend WithEvents btnConsumos_Editar As Button
    Friend WithEvents btnConsumos_Eliminar As Button
    Friend WithEvents lblConsumos_idCliente As Label
    Friend WithEvents cbConsumos_Regimen As ComboBox
End Class
