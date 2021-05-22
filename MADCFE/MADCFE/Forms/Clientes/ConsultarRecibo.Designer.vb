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
        Me.DGVConsultarRecibo_Recibos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtboxConsultarRecibo_NumMedidor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonConsultarRecibos_Descargar = New System.Windows.Forms.Button()
        Me.ButtonConsultarRecibos_Pagar = New System.Windows.Forms.Button()
        Me.ButtonConsultarRecibos_Salir = New System.Windows.Forms.Button()
        Me.btnConsultar_Historial = New System.Windows.Forms.Button()
        CType(Me.DGVConsultarRecibo_Recibos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVConsultarRecibo_Recibos
        '
        Me.DGVConsultarRecibo_Recibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVConsultarRecibo_Recibos.Location = New System.Drawing.Point(27, 113)
        Me.DGVConsultarRecibo_Recibos.Name = "DGVConsultarRecibo_Recibos"
        Me.DGVConsultarRecibo_Recibos.RowHeadersWidth = 51
        Me.DGVConsultarRecibo_Recibos.RowTemplate.Height = 24
        Me.DGVConsultarRecibo_Recibos.Size = New System.Drawing.Size(953, 344)
        Me.DGVConsultarRecibo_Recibos.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtboxConsultarRecibo_NumMedidor)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DGVConsultarRecibo_Recibos)
        Me.GroupBox1.Location = New System.Drawing.Point(46, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1004, 492)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recibos"
        '
        'txtboxConsultarRecibo_NumMedidor
        '
        Me.txtboxConsultarRecibo_NumMedidor.Location = New System.Drawing.Point(27, 57)
        Me.txtboxConsultarRecibo_NumMedidor.Name = "txtboxConsultarRecibo_NumMedidor"
        Me.txtboxConsultarRecibo_NumMedidor.ReadOnly = True
        Me.txtboxConsultarRecibo_NumMedidor.Size = New System.Drawing.Size(283, 22)
        Me.txtboxConsultarRecibo_NumMedidor.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "NUMERO DE MEDIDOR:"
        '
        'ButtonConsultarRecibos_Descargar
        '
        Me.ButtonConsultarRecibos_Descargar.Enabled = False
        Me.ButtonConsultarRecibos_Descargar.Location = New System.Drawing.Point(323, 593)
        Me.ButtonConsultarRecibos_Descargar.Name = "ButtonConsultarRecibos_Descargar"
        Me.ButtonConsultarRecibos_Descargar.Size = New System.Drawing.Size(190, 55)
        Me.ButtonConsultarRecibos_Descargar.TabIndex = 10
        Me.ButtonConsultarRecibos_Descargar.Text = "DESCARGAR"
        Me.ButtonConsultarRecibos_Descargar.UseVisualStyleBackColor = True
        '
        'ButtonConsultarRecibos_Pagar
        '
        Me.ButtonConsultarRecibos_Pagar.Location = New System.Drawing.Point(579, 593)
        Me.ButtonConsultarRecibos_Pagar.Name = "ButtonConsultarRecibos_Pagar"
        Me.ButtonConsultarRecibos_Pagar.Size = New System.Drawing.Size(190, 55)
        Me.ButtonConsultarRecibos_Pagar.TabIndex = 11
        Me.ButtonConsultarRecibos_Pagar.Text = "PAGAR"
        Me.ButtonConsultarRecibos_Pagar.UseVisualStyleBackColor = True
        '
        'ButtonConsultarRecibos_Salir
        '
        Me.ButtonConsultarRecibos_Salir.Location = New System.Drawing.Point(836, 593)
        Me.ButtonConsultarRecibos_Salir.Name = "ButtonConsultarRecibos_Salir"
        Me.ButtonConsultarRecibos_Salir.Size = New System.Drawing.Size(190, 55)
        Me.ButtonConsultarRecibos_Salir.TabIndex = 12
        Me.ButtonConsultarRecibos_Salir.Text = "SALIR"
        Me.ButtonConsultarRecibos_Salir.UseVisualStyleBackColor = True
        '
        'btnConsultar_Historial
        '
        Me.btnConsultar_Historial.Enabled = False
        Me.btnConsultar_Historial.Location = New System.Drawing.Point(73, 593)
        Me.btnConsultar_Historial.Name = "btnConsultar_Historial"
        Me.btnConsultar_Historial.Size = New System.Drawing.Size(190, 55)
        Me.btnConsultar_Historial.TabIndex = 9
        Me.btnConsultar_Historial.Text = "HISTORIAL"
        Me.btnConsultar_Historial.UseVisualStyleBackColor = True
        '
        'ConsultarRecibo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1096, 683)
        Me.Controls.Add(Me.btnConsultar_Historial)
        Me.Controls.Add(Me.ButtonConsultarRecibos_Salir)
        Me.Controls.Add(Me.ButtonConsultarRecibos_Pagar)
        Me.Controls.Add(Me.ButtonConsultarRecibos_Descargar)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Name = "ConsultarRecibo"
        Me.Text = "Consultar Recibo"
        CType(Me.DGVConsultarRecibo_Recibos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGVConsultarRecibo_Recibos As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonConsultarRecibos_Descargar As Button
    Friend WithEvents ButtonConsultarRecibos_Pagar As Button
    Friend WithEvents ButtonConsultarRecibos_Salir As Button
    Friend WithEvents txtboxConsultarRecibo_NumMedidor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnConsultar_Historial As Button
End Class
