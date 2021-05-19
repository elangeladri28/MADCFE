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
        Me.TextBoxTarifas_FiltroYear = New System.Windows.Forms.TextBox()
        Me.btnTarifas_Filtrar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTarifa_id = New System.Windows.Forms.Label()
        CType(Me.dgvTarifas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTarifas
        '
        Me.dgvTarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTarifas.Location = New System.Drawing.Point(16, 262)
        Me.dgvTarifas.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvTarifas.Name = "dgvTarifas"
        Me.dgvTarifas.RowHeadersWidth = 51
        Me.dgvTarifas.Size = New System.Drawing.Size(977, 361)
        Me.dgvTarifas.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre de tarifa:"
        '
        'txtTarifas_Nombre
        '
        Me.txtTarifas_Nombre.Location = New System.Drawing.Point(32, 31)
        Me.txtTarifas_Nombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTarifas_Nombre.Name = "txtTarifas_Nombre"
        Me.txtTarifas_Nombre.Size = New System.Drawing.Size(237, 22)
        Me.txtTarifas_Nombre.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(309, 10)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tipo de tarifa:"
        '
        'cbTarifas_Tipo
        '
        Me.cbTarifas_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTarifas_Tipo.FormattingEnabled = True
        Me.cbTarifas_Tipo.Items.AddRange(New Object() {"Doméstico", "Industrial"})
        Me.cbTarifas_Tipo.Location = New System.Drawing.Point(313, 30)
        Me.cbTarifas_Tipo.Margin = New System.Windows.Forms.Padding(4)
        Me.cbTarifas_Tipo.Name = "cbTarifas_Tipo"
        Me.cbTarifas_Tipo.Size = New System.Drawing.Size(225, 24)
        Me.cbTarifas_Tipo.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 74)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tarifa base:"
        '
        'txtTarifas_Base
        '
        Me.txtTarifas_Base.Location = New System.Drawing.Point(32, 94)
        Me.txtTarifas_Base.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTarifas_Base.Name = "txtTarifas_Base"
        Me.txtTarifas_Base.Size = New System.Drawing.Size(159, 22)
        Me.txtTarifas_Base.TabIndex = 6
        '
        'txtTarifas_Intermedia
        '
        Me.txtTarifas_Intermedia.Location = New System.Drawing.Point(221, 94)
        Me.txtTarifas_Intermedia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTarifas_Intermedia.Name = "txtTarifas_Intermedia"
        Me.txtTarifas_Intermedia.Size = New System.Drawing.Size(159, 22)
        Me.txtTarifas_Intermedia.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(217, 74)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tarifa intermedia:"
        '
        'txtTarifas_Excedente
        '
        Me.txtTarifas_Excedente.Location = New System.Drawing.Point(413, 94)
        Me.txtTarifas_Excedente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTarifas_Excedente.Name = "txtTarifas_Excedente"
        Me.txtTarifas_Excedente.Size = New System.Drawing.Size(159, 22)
        Me.txtTarifas_Excedente.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(409, 74)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tarifa excedente:"
        '
        'chbTarifas_Activo
        '
        Me.chbTarifas_Activo.AutoSize = True
        Me.chbTarifas_Activo.Location = New System.Drawing.Point(37, 153)
        Me.chbTarifas_Activo.Margin = New System.Windows.Forms.Padding(4)
        Me.chbTarifas_Activo.Name = "chbTarifas_Activo"
        Me.chbTarifas_Activo.Size = New System.Drawing.Size(68, 21)
        Me.chbTarifas_Activo.TabIndex = 11
        Me.chbTarifas_Activo.Text = "Activo"
        Me.chbTarifas_Activo.UseVisualStyleBackColor = True
        '
        'dtpTarifas_Fecha
        '
        Me.dtpTarifas_Fecha.Location = New System.Drawing.Point(120, 149)
        Me.dtpTarifas_Fecha.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpTarifas_Fecha.Name = "dtpTarifas_Fecha"
        Me.dtpTarifas_Fecha.Size = New System.Drawing.Size(265, 22)
        Me.dtpTarifas_Fecha.TabIndex = 12
        '
        'btnTarifas_Insertar
        '
        Me.btnTarifas_Insertar.Location = New System.Drawing.Point(31, 210)
        Me.btnTarifas_Insertar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTarifas_Insertar.Name = "btnTarifas_Insertar"
        Me.btnTarifas_Insertar.Size = New System.Drawing.Size(100, 28)
        Me.btnTarifas_Insertar.TabIndex = 13
        Me.btnTarifas_Insertar.Text = "Insertar"
        Me.btnTarifas_Insertar.UseVisualStyleBackColor = True
        '
        'btnTarifas_Editar
        '
        Me.btnTarifas_Editar.Location = New System.Drawing.Point(144, 210)
        Me.btnTarifas_Editar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTarifas_Editar.Name = "btnTarifas_Editar"
        Me.btnTarifas_Editar.Size = New System.Drawing.Size(100, 28)
        Me.btnTarifas_Editar.TabIndex = 14
        Me.btnTarifas_Editar.Text = "Editar"
        Me.btnTarifas_Editar.UseVisualStyleBackColor = True
        '
        'btnTaifas_Eliminar
        '
        Me.btnTaifas_Eliminar.Location = New System.Drawing.Point(263, 210)
        Me.btnTaifas_Eliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTaifas_Eliminar.Name = "btnTaifas_Eliminar"
        Me.btnTaifas_Eliminar.Size = New System.Drawing.Size(100, 28)
        Me.btnTaifas_Eliminar.TabIndex = 15
        Me.btnTaifas_Eliminar.Text = "Eliminar"
        Me.btnTaifas_Eliminar.UseVisualStyleBackColor = True
        '
        'TextBoxTarifas_FiltroYear
        '
        Me.TextBoxTarifas_FiltroYear.Location = New System.Drawing.Point(778, 94)
        Me.TextBoxTarifas_FiltroYear.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxTarifas_FiltroYear.Name = "TextBoxTarifas_FiltroYear"
        Me.TextBoxTarifas_FiltroYear.Size = New System.Drawing.Size(159, 22)
        Me.TextBoxTarifas_FiltroYear.TabIndex = 16
        '
        'btnTarifas_Filtrar
        '
        Me.btnTarifas_Filtrar.Location = New System.Drawing.Point(797, 140)
        Me.btnTarifas_Filtrar.Name = "btnTarifas_Filtrar"
        Me.btnTarifas_Filtrar.Size = New System.Drawing.Size(117, 34)
        Me.btnTarifas_Filtrar.TabIndex = 17
        Me.btnTarifas_Filtrar.Text = "Filtrar"
        Me.btnTarifas_Filtrar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(775, 73)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Filtro por Año"
        '
        'lblTarifa_id
        '
        Me.lblTarifa_id.AutoSize = True
        Me.lblTarifa_id.Location = New System.Drawing.Point(476, 173)
        Me.lblTarifa_id.Name = "lblTarifa_id"
        Me.lblTarifa_id.Size = New System.Drawing.Size(118, 17)
        Me.lblTarifa_id.TabIndex = 19
        Me.lblTarifa_id.Text = "P e r m a t r a g o"
        Me.lblTarifa_id.Visible = False
        '
        'Tarifas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 639)
        Me.Controls.Add(Me.lblTarifa_id)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnTarifas_Filtrar)
        Me.Controls.Add(Me.TextBoxTarifas_FiltroYear)
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
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents TextBoxTarifas_FiltroYear As TextBox
    Friend WithEvents btnTarifas_Filtrar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTarifa_id As Label
End Class
