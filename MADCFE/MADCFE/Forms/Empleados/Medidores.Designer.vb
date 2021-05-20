<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Medidores
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
        Me.dgvMedidores_Clientes = New System.Windows.Forms.DataGridView()
        Me.dgvMedidores_Domicilio = New System.Windows.Forms.DataGridView()
        Me.cbMedidores_Regimen = New System.Windows.Forms.ComboBox()
        Me.cbMedidores_PeriodoCobro = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnMedidores_Insertar = New System.Windows.Forms.Button()
        Me.btnMedidores_Editar = New System.Windows.Forms.Button()
        Me.btnMedidores_Eliminar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvMedidores_Medidores = New System.Windows.Forms.DataGridView()
        Me.lblMedidores_idCliente = New System.Windows.Forms.Label()
        Me.lblMedidores_idDomicilio = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMedidores_PrecioExcedente = New System.Windows.Forms.TextBox()
        Me.txtMedidores_PrecioIntermedio = New System.Windows.Forms.TextBox()
        Me.txtMedidores_PrecioBase = New System.Windows.Forms.TextBox()
        Me.dgv_invi = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMedidores_NombreCliente = New System.Windows.Forms.TextBox()
        Me.txtMedidores_Calle = New System.Windows.Forms.TextBox()
        CType(Me.dgvMedidores_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMedidores_Domicilio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMedidores_Medidores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_invi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMedidores_Clientes
        '
        Me.dgvMedidores_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMedidores_Clientes.Location = New System.Drawing.Point(16, 42)
        Me.dgvMedidores_Clientes.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvMedidores_Clientes.Name = "dgvMedidores_Clientes"
        Me.dgvMedidores_Clientes.RowHeadersWidth = 51
        Me.dgvMedidores_Clientes.Size = New System.Drawing.Size(637, 316)
        Me.dgvMedidores_Clientes.TabIndex = 0
        '
        'dgvMedidores_Domicilio
        '
        Me.dgvMedidores_Domicilio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMedidores_Domicilio.Location = New System.Drawing.Point(16, 421)
        Me.dgvMedidores_Domicilio.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvMedidores_Domicilio.Name = "dgvMedidores_Domicilio"
        Me.dgvMedidores_Domicilio.RowHeadersWidth = 51
        Me.dgvMedidores_Domicilio.Size = New System.Drawing.Size(637, 310)
        Me.dgvMedidores_Domicilio.TabIndex = 1
        '
        'cbMedidores_Regimen
        '
        Me.cbMedidores_Regimen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMedidores_Regimen.FormattingEnabled = True
        Me.cbMedidores_Regimen.Location = New System.Drawing.Point(838, 127)
        Me.cbMedidores_Regimen.Margin = New System.Windows.Forms.Padding(4)
        Me.cbMedidores_Regimen.Name = "cbMedidores_Regimen"
        Me.cbMedidores_Regimen.Size = New System.Drawing.Size(247, 24)
        Me.cbMedidores_Regimen.TabIndex = 2
        '
        'cbMedidores_PeriodoCobro
        '
        Me.cbMedidores_PeriodoCobro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMedidores_PeriodoCobro.FormattingEnabled = True
        Me.cbMedidores_PeriodoCobro.Items.AddRange(New Object() {"Mensual", "Trimestral", "Semestral"})
        Me.cbMedidores_PeriodoCobro.Location = New System.Drawing.Point(1143, 127)
        Me.cbMedidores_PeriodoCobro.Margin = New System.Windows.Forms.Padding(4)
        Me.cbMedidores_PeriodoCobro.Name = "cbMedidores_PeriodoCobro"
        Me.cbMedidores_PeriodoCobro.Size = New System.Drawing.Size(247, 24)
        Me.cbMedidores_PeriodoCobro.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(839, 103)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Regimen de costos:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1139, 103)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Periodo de cobro"
        '
        'btnMedidores_Insertar
        '
        Me.btnMedidores_Insertar.Location = New System.Drawing.Point(964, 262)
        Me.btnMedidores_Insertar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMedidores_Insertar.Name = "btnMedidores_Insertar"
        Me.btnMedidores_Insertar.Size = New System.Drawing.Size(100, 28)
        Me.btnMedidores_Insertar.TabIndex = 6
        Me.btnMedidores_Insertar.Text = "Generar"
        Me.btnMedidores_Insertar.UseVisualStyleBackColor = True
        '
        'btnMedidores_Editar
        '
        Me.btnMedidores_Editar.Location = New System.Drawing.Point(1087, 262)
        Me.btnMedidores_Editar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMedidores_Editar.Name = "btnMedidores_Editar"
        Me.btnMedidores_Editar.Size = New System.Drawing.Size(100, 28)
        Me.btnMedidores_Editar.TabIndex = 7
        Me.btnMedidores_Editar.Text = "Editar"
        Me.btnMedidores_Editar.UseVisualStyleBackColor = True
        '
        'btnMedidores_Eliminar
        '
        Me.btnMedidores_Eliminar.Location = New System.Drawing.Point(1208, 262)
        Me.btnMedidores_Eliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMedidores_Eliminar.Name = "btnMedidores_Eliminar"
        Me.btnMedidores_Eliminar.Size = New System.Drawing.Size(100, 28)
        Me.btnMedidores_Eliminar.TabIndex = 8
        Me.btnMedidores_Eliminar.Text = "Eliminar"
        Me.btnMedidores_Eliminar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Seleccione un cliente:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 401)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Seleccione un domicilio:"
        '
        'dgvMedidores_Medidores
        '
        Me.dgvMedidores_Medidores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMedidores_Medidores.Location = New System.Drawing.Point(808, 324)
        Me.dgvMedidores_Medidores.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvMedidores_Medidores.Name = "dgvMedidores_Medidores"
        Me.dgvMedidores_Medidores.RowHeadersWidth = 51
        Me.dgvMedidores_Medidores.Size = New System.Drawing.Size(640, 425)
        Me.dgvMedidores_Medidores.TabIndex = 11
        '
        'lblMedidores_idCliente
        '
        Me.lblMedidores_idCliente.AutoSize = True
        Me.lblMedidores_idCliente.Location = New System.Drawing.Point(343, 16)
        Me.lblMedidores_idCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMedidores_idCliente.Name = "lblMedidores_idCliente"
        Me.lblMedidores_idCliente.Size = New System.Drawing.Size(73, 17)
        Me.lblMedidores_idCliente.TabIndex = 12
        Me.lblMedidores_idCliente.Text = "ID CHETO"
        Me.lblMedidores_idCliente.Visible = False
        '
        'lblMedidores_idDomicilio
        '
        Me.lblMedidores_idDomicilio.AutoSize = True
        Me.lblMedidores_idDomicilio.Location = New System.Drawing.Point(343, 400)
        Me.lblMedidores_idDomicilio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMedidores_idDomicilio.Name = "lblMedidores_idDomicilio"
        Me.lblMedidores_idDomicilio.Size = New System.Drawing.Size(112, 17)
        Me.lblMedidores_idDomicilio.TabIndex = 13
        Me.lblMedidores_idDomicilio.Text = "IdChetoDomicilio"
        Me.lblMedidores_idDomicilio.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1205, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 17)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Precio Excedente:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1074, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 17)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Precio Intermedio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(937, 195)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 17)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Precio Base:"
        '
        'txtMedidores_PrecioExcedente
        '
        Me.txtMedidores_PrecioExcedente.Location = New System.Drawing.Point(1208, 215)
        Me.txtMedidores_PrecioExcedente.Name = "txtMedidores_PrecioExcedente"
        Me.txtMedidores_PrecioExcedente.ReadOnly = True
        Me.txtMedidores_PrecioExcedente.Size = New System.Drawing.Size(111, 22)
        Me.txtMedidores_PrecioExcedente.TabIndex = 25
        Me.txtMedidores_PrecioExcedente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMedidores_PrecioIntermedio
        '
        Me.txtMedidores_PrecioIntermedio.Location = New System.Drawing.Point(1076, 215)
        Me.txtMedidores_PrecioIntermedio.Name = "txtMedidores_PrecioIntermedio"
        Me.txtMedidores_PrecioIntermedio.ReadOnly = True
        Me.txtMedidores_PrecioIntermedio.Size = New System.Drawing.Size(111, 22)
        Me.txtMedidores_PrecioIntermedio.TabIndex = 24
        Me.txtMedidores_PrecioIntermedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMedidores_PrecioBase
        '
        Me.txtMedidores_PrecioBase.Location = New System.Drawing.Point(940, 215)
        Me.txtMedidores_PrecioBase.Name = "txtMedidores_PrecioBase"
        Me.txtMedidores_PrecioBase.ReadOnly = True
        Me.txtMedidores_PrecioBase.Size = New System.Drawing.Size(111, 22)
        Me.txtMedidores_PrecioBase.TabIndex = 23
        Me.txtMedidores_PrecioBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgv_invi
        '
        Me.dgv_invi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_invi.Location = New System.Drawing.Point(684, 195)
        Me.dgv_invi.Name = "dgv_invi"
        Me.dgv_invi.RowHeadersWidth = 51
        Me.dgv_invi.RowTemplate.Height = 24
        Me.dgv_invi.Size = New System.Drawing.Size(104, 95)
        Me.dgv_invi.TabIndex = 29
        Me.dgv_invi.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(835, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 17)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Nombre del Cliente:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1140, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 17)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Calle:"
        '
        'txtMedidores_NombreCliente
        '
        Me.txtMedidores_NombreCliente.Location = New System.Drawing.Point(838, 42)
        Me.txtMedidores_NombreCliente.Name = "txtMedidores_NombreCliente"
        Me.txtMedidores_NombreCliente.ReadOnly = True
        Me.txtMedidores_NombreCliente.Size = New System.Drawing.Size(247, 22)
        Me.txtMedidores_NombreCliente.TabIndex = 32
        '
        'txtMedidores_Calle
        '
        Me.txtMedidores_Calle.Location = New System.Drawing.Point(1142, 42)
        Me.txtMedidores_Calle.Name = "txtMedidores_Calle"
        Me.txtMedidores_Calle.ReadOnly = True
        Me.txtMedidores_Calle.Size = New System.Drawing.Size(247, 22)
        Me.txtMedidores_Calle.TabIndex = 33
        '
        'Medidores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1459, 763)
        Me.Controls.Add(Me.txtMedidores_Calle)
        Me.Controls.Add(Me.txtMedidores_NombreCliente)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgv_invi)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtMedidores_PrecioExcedente)
        Me.Controls.Add(Me.txtMedidores_PrecioIntermedio)
        Me.Controls.Add(Me.txtMedidores_PrecioBase)
        Me.Controls.Add(Me.lblMedidores_idDomicilio)
        Me.Controls.Add(Me.lblMedidores_idCliente)
        Me.Controls.Add(Me.dgvMedidores_Medidores)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnMedidores_Eliminar)
        Me.Controls.Add(Me.btnMedidores_Editar)
        Me.Controls.Add(Me.btnMedidores_Insertar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbMedidores_PeriodoCobro)
        Me.Controls.Add(Me.cbMedidores_Regimen)
        Me.Controls.Add(Me.dgvMedidores_Domicilio)
        Me.Controls.Add(Me.dgvMedidores_Clientes)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Medidores"
        Me.Text = "Medidores"
        CType(Me.dgvMedidores_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMedidores_Domicilio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMedidores_Medidores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_invi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvMedidores_Clientes As DataGridView
    Friend WithEvents dgvMedidores_Domicilio As DataGridView
    Friend WithEvents cbMedidores_Regimen As ComboBox
    Friend WithEvents cbMedidores_PeriodoCobro As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnMedidores_Insertar As Button
    Friend WithEvents btnMedidores_Editar As Button
    Friend WithEvents btnMedidores_Eliminar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvMedidores_Medidores As DataGridView
    Friend WithEvents lblMedidores_idCliente As Label
    Friend WithEvents lblMedidores_idDomicilio As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMedidores_PrecioExcedente As TextBox
    Friend WithEvents txtMedidores_PrecioIntermedio As TextBox
    Friend WithEvents txtMedidores_PrecioBase As TextBox
    Friend WithEvents dgv_invi As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtMedidores_NombreCliente As TextBox
    Friend WithEvents txtMedidores_Calle As TextBox
End Class
