﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        CType(Me.dgvMedidores_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMedidores_Domicilio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMedidores_Medidores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMedidores_Clientes
        '
        Me.dgvMedidores_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMedidores_Clientes.Location = New System.Drawing.Point(12, 34)
        Me.dgvMedidores_Clientes.Name = "dgvMedidores_Clientes"
        Me.dgvMedidores_Clientes.Size = New System.Drawing.Size(478, 257)
        Me.dgvMedidores_Clientes.TabIndex = 0
        '
        'dgvMedidores_Domicilio
        '
        Me.dgvMedidores_Domicilio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMedidores_Domicilio.Location = New System.Drawing.Point(12, 342)
        Me.dgvMedidores_Domicilio.Name = "dgvMedidores_Domicilio"
        Me.dgvMedidores_Domicilio.Size = New System.Drawing.Size(478, 252)
        Me.dgvMedidores_Domicilio.TabIndex = 1
        '
        'cbMedidores_Regimen
        '
        Me.cbMedidores_Regimen.FormattingEnabled = True
        Me.cbMedidores_Regimen.Location = New System.Drawing.Point(632, 168)
        Me.cbMedidores_Regimen.Name = "cbMedidores_Regimen"
        Me.cbMedidores_Regimen.Size = New System.Drawing.Size(186, 21)
        Me.cbMedidores_Regimen.TabIndex = 2
        '
        'cbMedidores_PeriodoCobro
        '
        Me.cbMedidores_PeriodoCobro.FormattingEnabled = True
        Me.cbMedidores_PeriodoCobro.Location = New System.Drawing.Point(861, 168)
        Me.cbMedidores_PeriodoCobro.Name = "cbMedidores_PeriodoCobro"
        Me.cbMedidores_PeriodoCobro.Size = New System.Drawing.Size(186, 21)
        Me.cbMedidores_PeriodoCobro.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(633, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Regimen de costos:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(858, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Periodo de cobro"
        '
        'btnMedidores_Insertar
        '
        Me.btnMedidores_Insertar.Location = New System.Drawing.Point(730, 215)
        Me.btnMedidores_Insertar.Name = "btnMedidores_Insertar"
        Me.btnMedidores_Insertar.Size = New System.Drawing.Size(75, 23)
        Me.btnMedidores_Insertar.TabIndex = 6
        Me.btnMedidores_Insertar.Text = "Generar"
        Me.btnMedidores_Insertar.UseVisualStyleBackColor = True
        '
        'btnMedidores_Editar
        '
        Me.btnMedidores_Editar.Location = New System.Drawing.Point(822, 215)
        Me.btnMedidores_Editar.Name = "btnMedidores_Editar"
        Me.btnMedidores_Editar.Size = New System.Drawing.Size(75, 23)
        Me.btnMedidores_Editar.TabIndex = 7
        Me.btnMedidores_Editar.Text = "Editar"
        Me.btnMedidores_Editar.UseVisualStyleBackColor = True
        '
        'btnMedidores_Eliminar
        '
        Me.btnMedidores_Eliminar.Location = New System.Drawing.Point(913, 215)
        Me.btnMedidores_Eliminar.Name = "btnMedidores_Eliminar"
        Me.btnMedidores_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnMedidores_Eliminar.TabIndex = 8
        Me.btnMedidores_Eliminar.Text = "Eliminar"
        Me.btnMedidores_Eliminar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Seleccione un cliente:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 326)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Seleccione un domicilio:"
        '
        'dgvMedidores_Medidores
        '
        Me.dgvMedidores_Medidores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMedidores_Medidores.Location = New System.Drawing.Point(606, 263)
        Me.dgvMedidores_Medidores.Name = "dgvMedidores_Medidores"
        Me.dgvMedidores_Medidores.Size = New System.Drawing.Size(480, 345)
        Me.dgvMedidores_Medidores.TabIndex = 11
        '
        'Medidores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 620)
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
        Me.Name = "Medidores"
        Me.Text = "Medidores"
        CType(Me.dgvMedidores_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMedidores_Domicilio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMedidores_Medidores, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
