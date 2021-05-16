<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultarRecibo
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
        Me.ComboBoxConsultarRecibo_TipodeServicio = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTPConsultarRecibo_FechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.DTPConsultarRecibo_FechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.DGVConsultarRecibo_Recibos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonConsultarRecibos_Descargar = New System.Windows.Forms.Button()
        Me.ButtonConsultarRecibos_Pagar = New System.Windows.Forms.Button()
        Me.ButtonConsultarRecibos_Salir = New System.Windows.Forms.Button()
        CType(Me.DGVConsultarRecibo_Recibos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(507, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(365, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "2.-SELECCIONA UN PERIODO DE FACTURACION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "1.-TIPO DE SERVICIO"
        '
        'ComboBoxConsultarRecibo_TipodeServicio
        '
        Me.ComboBoxConsultarRecibo_TipodeServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxConsultarRecibo_TipodeServicio.FormattingEnabled = True
        Me.ComboBoxConsultarRecibo_TipodeServicio.Items.AddRange(New Object() {"Doméstico", "Industrial"})
        Me.ComboBoxConsultarRecibo_TipodeServicio.Location = New System.Drawing.Point(27, 58)
        Me.ComboBoxConsultarRecibo_TipodeServicio.Name = "ComboBoxConsultarRecibo_TipodeServicio"
        Me.ComboBoxConsultarRecibo_TipodeServicio.Size = New System.Drawing.Size(238, 24)
        Me.ComboBoxConsultarRecibo_TipodeServicio.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(507, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Fecha inicial"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(779, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Fecha Final"
        '
        'DTPConsultarRecibo_FechaInicial
        '
        Me.DTPConsultarRecibo_FechaInicial.Location = New System.Drawing.Point(510, 104)
        Me.DTPConsultarRecibo_FechaInicial.Name = "DTPConsultarRecibo_FechaInicial"
        Me.DTPConsultarRecibo_FechaInicial.Size = New System.Drawing.Size(200, 22)
        Me.DTPConsultarRecibo_FechaInicial.TabIndex = 5
        '
        'DTPConsultarRecibo_FechaFinal
        '
        Me.DTPConsultarRecibo_FechaFinal.Location = New System.Drawing.Point(782, 104)
        Me.DTPConsultarRecibo_FechaFinal.Name = "DTPConsultarRecibo_FechaFinal"
        Me.DTPConsultarRecibo_FechaFinal.Size = New System.Drawing.Size(200, 22)
        Me.DTPConsultarRecibo_FechaFinal.TabIndex = 6
        '
        'DGVConsultarRecibo_Recibos
        '
        Me.DGVConsultarRecibo_Recibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVConsultarRecibo_Recibos.Location = New System.Drawing.Point(46, 237)
        Me.DGVConsultarRecibo_Recibos.Name = "DGVConsultarRecibo_Recibos"
        Me.DGVConsultarRecibo_Recibos.RowHeadersWidth = 51
        Me.DGVConsultarRecibo_Recibos.RowTemplate.Height = 24
        Me.DGVConsultarRecibo_Recibos.Size = New System.Drawing.Size(1004, 344)
        Me.DGVConsultarRecibo_Recibos.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBoxConsultarRecibo_TipodeServicio)
        Me.GroupBox1.Controls.Add(Me.DTPConsultarRecibo_FechaFinal)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DTPConsultarRecibo_FechaInicial)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(46, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1004, 193)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'ButtonConsultarRecibos_Descargar
        '
        Me.ButtonConsultarRecibos_Descargar.Location = New System.Drawing.Point(202, 600)
        Me.ButtonConsultarRecibos_Descargar.Name = "ButtonConsultarRecibos_Descargar"
        Me.ButtonConsultarRecibos_Descargar.Size = New System.Drawing.Size(190, 55)
        Me.ButtonConsultarRecibos_Descargar.TabIndex = 9
        Me.ButtonConsultarRecibos_Descargar.Text = "DESCARGAR"
        Me.ButtonConsultarRecibos_Descargar.UseVisualStyleBackColor = True
        '
        'ButtonConsultarRecibos_Pagar
        '
        Me.ButtonConsultarRecibos_Pagar.Location = New System.Drawing.Point(467, 600)
        Me.ButtonConsultarRecibos_Pagar.Name = "ButtonConsultarRecibos_Pagar"
        Me.ButtonConsultarRecibos_Pagar.Size = New System.Drawing.Size(190, 55)
        Me.ButtonConsultarRecibos_Pagar.TabIndex = 10
        Me.ButtonConsultarRecibos_Pagar.Text = "PAGAR"
        Me.ButtonConsultarRecibos_Pagar.UseVisualStyleBackColor = True
        '
        'ButtonConsultarRecibos_Salir
        '
        Me.ButtonConsultarRecibos_Salir.Location = New System.Drawing.Point(728, 600)
        Me.ButtonConsultarRecibos_Salir.Name = "ButtonConsultarRecibos_Salir"
        Me.ButtonConsultarRecibos_Salir.Size = New System.Drawing.Size(190, 55)
        Me.ButtonConsultarRecibos_Salir.TabIndex = 11
        Me.ButtonConsultarRecibos_Salir.Text = "SALIR"
        Me.ButtonConsultarRecibos_Salir.UseVisualStyleBackColor = True
        '
        'ConsultarRecibo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1096, 683)
        Me.Controls.Add(Me.ButtonConsultarRecibos_Salir)
        Me.Controls.Add(Me.ButtonConsultarRecibos_Pagar)
        Me.Controls.Add(Me.ButtonConsultarRecibos_Descargar)
        Me.Controls.Add(Me.DGVConsultarRecibo_Recibos)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Name = "ConsultarRecibo"
        Me.Text = "Consultar Recibo"
        CType(Me.DGVConsultarRecibo_Recibos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxConsultarRecibo_TipodeServicio As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DTPConsultarRecibo_FechaInicial As DateTimePicker
    Friend WithEvents DTPConsultarRecibo_FechaFinal As DateTimePicker
    Friend WithEvents DGVConsultarRecibo_Recibos As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonConsultarRecibos_Descargar As Button
    Friend WithEvents ButtonConsultarRecibos_Pagar As Button
    Friend WithEvents ButtonConsultarRecibos_Salir As Button
End Class
