﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.txtConsumos_PrecioBase = New System.Windows.Forms.TextBox()
        Me.txtConsumos_PrecioIntermedio = New System.Windows.Forms.TextBox()
        Me.txtConsumos_PrecioExcedente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtboxConsumos_NombreCliente = New System.Windows.Forms.TextBox()
        Me.txtboxConsumos_Regimen = New System.Windows.Forms.TextBox()
        Me.txtboxConsumos_Domicilio = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.dgv_invi_consumos = New System.Windows.Forms.DataGridView()
        Me.lblConsumos_Username = New System.Windows.Forms.Label()
        CType(Me.dgvConsumos_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvConsumos_Consumos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_invi_consumos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvConsumos_Clientes
        '
        Me.dgvConsumos_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsumos_Clientes.Location = New System.Drawing.Point(16, 73)
        Me.dgvConsumos_Clientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvConsumos_Clientes.Name = "dgvConsumos_Clientes"
        Me.dgvConsumos_Clientes.RowHeadersWidth = 51
        Me.dgvConsumos_Clientes.Size = New System.Drawing.Size(931, 207)
        Me.dgvConsumos_Clientes.TabIndex = 0
        '
        'dgvConsumos_Consumos
        '
        Me.dgvConsumos_Consumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsumos_Consumos.Location = New System.Drawing.Point(15, 533)
        Me.dgvConsumos_Consumos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvConsumos_Consumos.Name = "dgvConsumos_Consumos"
        Me.dgvConsumos_Consumos.RowHeadersWidth = 51
        Me.dgvConsumos_Consumos.Size = New System.Drawing.Size(932, 302)
        Me.dgvConsumos_Consumos.TabIndex = 1
        '
        'txtConsumos_NombreCliente
        '
        Me.txtConsumos_NombreCliente.Location = New System.Drawing.Point(16, 41)
        Me.txtConsumos_NombreCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtConsumos_NombreCliente.Name = "txtConsumos_NombreCliente"
        Me.txtConsumos_NombreCliente.Size = New System.Drawing.Size(283, 22)
        Me.txtConsumos_NombreCliente.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre del cliente:"
        '
        'btnConsumos_BuscarCliente
        '
        Me.btnConsumos_BuscarCliente.Location = New System.Drawing.Point(308, 37)
        Me.btnConsumos_BuscarCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnConsumos_BuscarCliente.Name = "btnConsumos_BuscarCliente"
        Me.btnConsumos_BuscarCliente.Size = New System.Drawing.Size(100, 28)
        Me.btnConsumos_BuscarCliente.TabIndex = 4
        Me.btnConsumos_BuscarCliente.Text = "Buscar"
        Me.btnConsumos_BuscarCliente.UseVisualStyleBackColor = True
        '
        'txtConsumos_Medidor
        '
        Me.txtConsumos_Medidor.Location = New System.Drawing.Point(588, 341)
        Me.txtConsumos_Medidor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtConsumos_Medidor.Name = "txtConsumos_Medidor"
        Me.txtConsumos_Medidor.ReadOnly = True
        Me.txtConsumos_Medidor.Size = New System.Drawing.Size(132, 22)
        Me.txtConsumos_Medidor.TabIndex = 5
        Me.txtConsumos_Medidor.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(584, 321)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Número de medidor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(748, 321)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Esquema de cobro:"
        '
        'txtConsumos_Kw
        '
        Me.txtConsumos_Kw.Location = New System.Drawing.Point(17, 401)
        Me.txtConsumos_Kw.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtConsumos_Kw.Name = "txtConsumos_Kw"
        Me.txtConsumos_Kw.Size = New System.Drawing.Size(132, 22)
        Me.txtConsumos_Kw.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 382)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "KW consumidos:"
        '
        'dtpConsumos_Date
        '
        Me.dtpConsumos_Date.CustomFormat = ""
        Me.dtpConsumos_Date.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpConsumos_Date.Location = New System.Drawing.Point(161, 402)
        Me.dtpConsumos_Date.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpConsumos_Date.MaxDate = New Date(2021, 5, 17, 0, 0, 0, 0)
        Me.dtpConsumos_Date.Name = "dtpConsumos_Date"
        Me.dtpConsumos_Date.Size = New System.Drawing.Size(265, 22)
        Me.dtpConsumos_Date.TabIndex = 11
        Me.dtpConsumos_Date.Value = New Date(2021, 5, 17, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(157, 383)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Fecha de consumo:"
        '
        'btnConsumos_Insertar
        '
        Me.btnConsumos_Insertar.Location = New System.Drawing.Point(35, 460)
        Me.btnConsumos_Insertar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnConsumos_Insertar.Name = "btnConsumos_Insertar"
        Me.btnConsumos_Insertar.Size = New System.Drawing.Size(100, 28)
        Me.btnConsumos_Insertar.TabIndex = 13
        Me.btnConsumos_Insertar.Text = "Insertar"
        Me.btnConsumos_Insertar.UseVisualStyleBackColor = True
        '
        'btnConsumos_Editar
        '
        Me.btnConsumos_Editar.Location = New System.Drawing.Point(172, 460)
        Me.btnConsumos_Editar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnConsumos_Editar.Name = "btnConsumos_Editar"
        Me.btnConsumos_Editar.Size = New System.Drawing.Size(100, 28)
        Me.btnConsumos_Editar.TabIndex = 14
        Me.btnConsumos_Editar.Text = "Editar"
        Me.btnConsumos_Editar.UseVisualStyleBackColor = True
        '
        'btnConsumos_Eliminar
        '
        Me.btnConsumos_Eliminar.Location = New System.Drawing.Point(308, 460)
        Me.btnConsumos_Eliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnConsumos_Eliminar.Name = "btnConsumos_Eliminar"
        Me.btnConsumos_Eliminar.Size = New System.Drawing.Size(100, 28)
        Me.btnConsumos_Eliminar.TabIndex = 15
        Me.btnConsumos_Eliminar.Text = "Eliminar"
        Me.btnConsumos_Eliminar.UseVisualStyleBackColor = True
        '
        'lblConsumos_idCliente
        '
        Me.lblConsumos_idCliente.AutoSize = True
        Me.lblConsumos_idCliente.Location = New System.Drawing.Point(513, 21)
        Me.lblConsumos_idCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConsumos_idCliente.Name = "lblConsumos_idCliente"
        Me.lblConsumos_idCliente.Size = New System.Drawing.Size(51, 17)
        Me.lblConsumos_idCliente.TabIndex = 16
        Me.lblConsumos_idCliente.Text = "Label6"
        '
        'txtConsumos_PrecioBase
        '
        Me.txtConsumos_PrecioBase.Location = New System.Drawing.Point(504, 404)
        Me.txtConsumos_PrecioBase.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtConsumos_PrecioBase.Name = "txtConsumos_PrecioBase"
        Me.txtConsumos_PrecioBase.ReadOnly = True
        Me.txtConsumos_PrecioBase.Size = New System.Drawing.Size(111, 22)
        Me.txtConsumos_PrecioBase.TabIndex = 17
        '
        'txtConsumos_PrecioIntermedio
        '
        Me.txtConsumos_PrecioIntermedio.Location = New System.Drawing.Point(640, 404)
        Me.txtConsumos_PrecioIntermedio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtConsumos_PrecioIntermedio.Name = "txtConsumos_PrecioIntermedio"
        Me.txtConsumos_PrecioIntermedio.ReadOnly = True
        Me.txtConsumos_PrecioIntermedio.Size = New System.Drawing.Size(111, 22)
        Me.txtConsumos_PrecioIntermedio.TabIndex = 18
        '
        'txtConsumos_PrecioExcedente
        '
        Me.txtConsumos_PrecioExcedente.Location = New System.Drawing.Point(772, 404)
        Me.txtConsumos_PrecioExcedente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtConsumos_PrecioExcedente.Name = "txtConsumos_PrecioExcedente"
        Me.txtConsumos_PrecioExcedente.ReadOnly = True
        Me.txtConsumos_PrecioExcedente.Size = New System.Drawing.Size(111, 22)
        Me.txtConsumos_PrecioExcedente.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(501, 383)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 17)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Precio Base:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(638, 383)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 17)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Precio Intermedio:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(769, 383)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 17)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Precio Excedente:"
        '
        'txtboxConsumos_NombreCliente
        '
        Me.txtboxConsumos_NombreCliente.Location = New System.Drawing.Point(19, 341)
        Me.txtboxConsumos_NombreCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtboxConsumos_NombreCliente.Name = "txtboxConsumos_NombreCliente"
        Me.txtboxConsumos_NombreCliente.ReadOnly = True
        Me.txtboxConsumos_NombreCliente.Size = New System.Drawing.Size(132, 22)
        Me.txtboxConsumos_NombreCliente.TabIndex = 23
        Me.txtboxConsumos_NombreCliente.TabStop = False
        '
        'txtboxConsumos_Regimen
        '
        Me.txtboxConsumos_Regimen.Location = New System.Drawing.Point(751, 341)
        Me.txtboxConsumos_Regimen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtboxConsumos_Regimen.Name = "txtboxConsumos_Regimen"
        Me.txtboxConsumos_Regimen.ReadOnly = True
        Me.txtboxConsumos_Regimen.Size = New System.Drawing.Size(132, 22)
        Me.txtboxConsumos_Regimen.TabIndex = 24
        Me.txtboxConsumos_Regimen.TabStop = False
        '
        'txtboxConsumos_Domicilio
        '
        Me.txtboxConsumos_Domicilio.Location = New System.Drawing.Point(205, 341)
        Me.txtboxConsumos_Domicilio.Margin = New System.Windows.Forms.Padding(4)
        Me.txtboxConsumos_Domicilio.Name = "txtboxConsumos_Domicilio"
        Me.txtboxConsumos_Domicilio.ReadOnly = True
        Me.txtboxConsumos_Domicilio.Size = New System.Drawing.Size(150, 22)
        Me.txtboxConsumos_Domicilio.TabIndex = 25
        Me.txtboxConsumos_Domicilio.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 320)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(130, 17)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Nombre del cliente:"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(202, 321)
        Me.lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(68, 17)
        Me.lbl.TabIndex = 27
        Me.lbl.Text = "Domicilio:"
        '
        'dgv_invi_consumos
        '
        Me.dgv_invi_consumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_invi_consumos.Location = New System.Drawing.Point(450, 321)
        Me.dgv_invi_consumos.Name = "dgv_invi_consumos"
        Me.dgv_invi_consumos.RowHeadersWidth = 51
        Me.dgv_invi_consumos.RowTemplate.Height = 24
        Me.dgv_invi_consumos.Size = New System.Drawing.Size(58, 36)
        Me.dgv_invi_consumos.TabIndex = 28
        Me.dgv_invi_consumos.Visible = False
        '
        'lblConsumos_Username
        '
        Me.lblConsumos_Username.AutoSize = True
        Me.lblConsumos_Username.Location = New System.Drawing.Point(16, 284)
        Me.lblConsumos_Username.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConsumos_Username.Name = "lblConsumos_Username"
        Me.lblConsumos_Username.Size = New System.Drawing.Size(81, 17)
        Me.lblConsumos_Username.TabIndex = 29
        Me.lblConsumos_Username.Text = "Soy invi jsjs"
        Me.lblConsumos_Username.Visible = False
        '
        'Consumos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 849)
        Me.Controls.Add(Me.lblConsumos_Username)
        Me.Controls.Add(Me.dgv_invi_consumos)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtboxConsumos_Domicilio)
        Me.Controls.Add(Me.txtboxConsumos_Regimen)
        Me.Controls.Add(Me.txtboxConsumos_NombreCliente)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtConsumos_PrecioExcedente)
        Me.Controls.Add(Me.txtConsumos_PrecioIntermedio)
        Me.Controls.Add(Me.txtConsumos_PrecioBase)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Consumos"
        Me.Text = "Consumos"
        CType(Me.dgvConsumos_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvConsumos_Consumos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_invi_consumos, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtConsumos_PrecioBase As TextBox
    Friend WithEvents txtConsumos_PrecioIntermedio As TextBox
    Friend WithEvents txtConsumos_PrecioExcedente As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtboxConsumos_NombreCliente As TextBox
    Friend WithEvents txtboxConsumos_Regimen As TextBox
    Friend WithEvents txtboxConsumos_Domicilio As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl As Label
    Friend WithEvents dgv_invi_consumos As DataGridView
    Friend WithEvents lblConsumos_Username As Label
End Class
