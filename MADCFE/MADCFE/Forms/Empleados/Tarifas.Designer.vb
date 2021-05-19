<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tarifas
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
        Me.dgvTarifas = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTarifas_Nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbTarifas_Tipo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTarifas_Base = New System.Windows.Forms.TextBox()
        Me.txtTarifas_Intermedia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTarifas_Excedente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chbTarifas_Activo = New System.Windows.Forms.CheckBox()
        Me.dtpTarifas_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.btnTarifas_Insertar = New System.Windows.Forms.Button()
        Me.btnTarifas_Editar = New System.Windows.Forms.Button()
        Me.btnTaifas_Eliminar = New System.Windows.Forms.Button()
        CType(Me.dgvTarifas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTarifas
        '
        Me.dgvTarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTarifas.Location = New System.Drawing.Point(12, 213)
        Me.dgvTarifas.Name = "dgvTarifas"
        Me.dgvTarifas.Size = New System.Drawing.Size(733, 293)
        Me.dgvTarifas.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre de tarifa:"
        '
        'txtTarifas_Nombre
        '
        Me.txtTarifas_Nombre.Location = New System.Drawing.Point(24, 25)
        Me.txtTarifas_Nombre.Name = "txtTarifas_Nombre"
        Me.txtTarifas_Nombre.Size = New System.Drawing.Size(179, 20)
        Me.txtTarifas_Nombre.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(232, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tipo de tarifa:"
        '
        'cbTarifas_Tipo
        '
        Me.cbTarifas_Tipo.FormattingEnabled = True
        Me.cbTarifas_Tipo.Location = New System.Drawing.Point(235, 24)
        Me.cbTarifas_Tipo.Name = "cbTarifas_Tipo"
        Me.cbTarifas_Tipo.Size = New System.Drawing.Size(170, 21)
        Me.cbTarifas_Tipo.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tarifa base:"
        '
        'txtTarifas_Base
        '
        Me.txtTarifas_Base.Location = New System.Drawing.Point(24, 76)
        Me.txtTarifas_Base.Name = "txtTarifas_Base"
        Me.txtTarifas_Base.Size = New System.Drawing.Size(120, 20)
        Me.txtTarifas_Base.TabIndex = 6
        '
        'txtTarifas_Intermedia
        '
        Me.txtTarifas_Intermedia.Location = New System.Drawing.Point(166, 76)
        Me.txtTarifas_Intermedia.Name = "txtTarifas_Intermedia"
        Me.txtTarifas_Intermedia.Size = New System.Drawing.Size(120, 20)
        Me.txtTarifas_Intermedia.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(163, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tarifa intermedia:"
        '
        'txtTarifas_Excedente
        '
        Me.txtTarifas_Excedente.Location = New System.Drawing.Point(310, 76)
        Me.txtTarifas_Excedente.Name = "txtTarifas_Excedente"
        Me.txtTarifas_Excedente.Size = New System.Drawing.Size(120, 20)
        Me.txtTarifas_Excedente.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(307, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tarifa excedente:"
        '
        'chbTarifas_Activo
        '
        Me.chbTarifas_Activo.AutoSize = True
        Me.chbTarifas_Activo.Location = New System.Drawing.Point(28, 124)
        Me.chbTarifas_Activo.Name = "chbTarifas_Activo"
        Me.chbTarifas_Activo.Size = New System.Drawing.Size(56, 17)
        Me.chbTarifas_Activo.TabIndex = 11
        Me.chbTarifas_Activo.Text = "Activo"
        Me.chbTarifas_Activo.UseVisualStyleBackColor = True
        '
        'dtpTarifas_Fecha
        '
        Me.dtpTarifas_Fecha.Location = New System.Drawing.Point(90, 121)
        Me.dtpTarifas_Fecha.Name = "dtpTarifas_Fecha"
        Me.dtpTarifas_Fecha.Size = New System.Drawing.Size(200, 20)
        Me.dtpTarifas_Fecha.TabIndex = 12
        '
        'btnTarifas_Insertar
        '
        Me.btnTarifas_Insertar.Location = New System.Drawing.Point(23, 171)
        Me.btnTarifas_Insertar.Name = "btnTarifas_Insertar"
        Me.btnTarifas_Insertar.Size = New System.Drawing.Size(75, 23)
        Me.btnTarifas_Insertar.TabIndex = 13
        Me.btnTarifas_Insertar.Text = "Insertar"
        Me.btnTarifas_Insertar.UseVisualStyleBackColor = True
        '
        'btnTarifas_Editar
        '
        Me.btnTarifas_Editar.Location = New System.Drawing.Point(108, 171)
        Me.btnTarifas_Editar.Name = "btnTarifas_Editar"
        Me.btnTarifas_Editar.Size = New System.Drawing.Size(75, 23)
        Me.btnTarifas_Editar.TabIndex = 14
        Me.btnTarifas_Editar.Text = "Editar"
        Me.btnTarifas_Editar.UseVisualStyleBackColor = True
        '
        'btnTaifas_Eliminar
        '
        Me.btnTaifas_Eliminar.Location = New System.Drawing.Point(197, 171)
        Me.btnTaifas_Eliminar.Name = "btnTaifas_Eliminar"
        Me.btnTaifas_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnTaifas_Eliminar.TabIndex = 15
        Me.btnTaifas_Eliminar.Text = "Eliminar"
        Me.btnTaifas_Eliminar.UseVisualStyleBackColor = True
        '
        'Tarifas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 519)
        Me.Controls.Add(Me.btnTaifas_Eliminar)
        Me.Controls.Add(Me.btnTarifas_Editar)
        Me.Controls.Add(Me.btnTarifas_Insertar)
        Me.Controls.Add(Me.dtpTarifas_Fecha)
        Me.Controls.Add(Me.chbTarifas_Activo)
        Me.Controls.Add(Me.txtTarifas_Excedente)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTarifas_Intermedia)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTarifas_Base)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbTarifas_Tipo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTarifas_Nombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvTarifas)
        Me.Name = "Tarifas"
        Me.Text = "Tarifas"
        CType(Me.dgvTarifas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvTarifas As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTarifas_Nombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbTarifas_Tipo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTarifas_Base As TextBox
    Friend WithEvents txtTarifas_Intermedia As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTarifas_Excedente As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chbTarifas_Activo As CheckBox
    Friend WithEvents dtpTarifas_Fecha As DateTimePicker
    Friend WithEvents btnTarifas_Insertar As Button
    Friend WithEvents btnTarifas_Editar As Button
    Friend WithEvents btnTaifas_Eliminar As Button
End Class
