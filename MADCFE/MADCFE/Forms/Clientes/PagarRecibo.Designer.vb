<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PagarRecibo
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxPagarRecibo_TipoTarjeta = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxPagarRecibo_Numeracion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxPagarRecibo_Mes = New System.Windows.Forms.TextBox()
        Me.TextBoxPagarRecibo_Year = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxPagarRecibo_CVV = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonPagarRecibo_Pagar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonPagarRecibo_Generar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipo de Tarjeta"
        '
        'ComboBoxPagarRecibo_TipoTarjeta
        '
        Me.ComboBoxPagarRecibo_TipoTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPagarRecibo_TipoTarjeta.FormattingEnabled = True
        Me.ComboBoxPagarRecibo_TipoTarjeta.Items.AddRange(New Object() {"Visa", "MasterCard"})
        Me.ComboBoxPagarRecibo_TipoTarjeta.Location = New System.Drawing.Point(23, 89)
        Me.ComboBoxPagarRecibo_TipoTarjeta.Name = "ComboBoxPagarRecibo_TipoTarjeta"
        Me.ComboBoxPagarRecibo_TipoTarjeta.Size = New System.Drawing.Size(255, 33)
        Me.ComboBoxPagarRecibo_TipoTarjeta.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(305, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ingresa los datos de tu Tarjeta"
        '
        'TextBoxPagarRecibo_Numeracion
        '
        Me.TextBoxPagarRecibo_Numeracion.Enabled = False
        Me.TextBoxPagarRecibo_Numeracion.Location = New System.Drawing.Point(23, 224)
        Me.TextBoxPagarRecibo_Numeracion.Name = "TextBoxPagarRecibo_Numeracion"
        Me.TextBoxPagarRecibo_Numeracion.Size = New System.Drawing.Size(257, 30)
        Me.TextBoxPagarRecibo_Numeracion.TabIndex = 5
        Me.TextBoxPagarRecibo_Numeracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Numero (16 digitos)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Fecha de Caducidad"
        '
        'TextBoxPagarRecibo_Mes
        '
        Me.TextBoxPagarRecibo_Mes.Enabled = False
        Me.TextBoxPagarRecibo_Mes.Location = New System.Drawing.Point(23, 301)
        Me.TextBoxPagarRecibo_Mes.Name = "TextBoxPagarRecibo_Mes"
        Me.TextBoxPagarRecibo_Mes.Size = New System.Drawing.Size(55, 30)
        Me.TextBoxPagarRecibo_Mes.TabIndex = 7
        Me.TextBoxPagarRecibo_Mes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxPagarRecibo_Year
        '
        Me.TextBoxPagarRecibo_Year.Enabled = False
        Me.TextBoxPagarRecibo_Year.Location = New System.Drawing.Point(123, 300)
        Me.TextBoxPagarRecibo_Year.Name = "TextBoxPagarRecibo_Year"
        Me.TextBoxPagarRecibo_Year.Size = New System.Drawing.Size(54, 30)
        Me.TextBoxPagarRecibo_Year.TabIndex = 9
        Me.TextBoxPagarRecibo_Year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(88, 301)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 29)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "/"
        '
        'TextBoxPagarRecibo_CVV
        '
        Me.TextBoxPagarRecibo_CVV.Enabled = False
        Me.TextBoxPagarRecibo_CVV.Location = New System.Drawing.Point(24, 367)
        Me.TextBoxPagarRecibo_CVV.Name = "TextBoxPagarRecibo_CVV"
        Me.TextBoxPagarRecibo_CVV.Size = New System.Drawing.Size(54, 30)
        Me.TextBoxPagarRecibo_CVV.TabIndex = 11
        Me.TextBoxPagarRecibo_CVV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 344)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "CVV (3 Digitos)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonPagarRecibo_Pagar)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBoxPagarRecibo_CVV)
        Me.GroupBox1.Controls.Add(Me.ComboBoxPagarRecibo_TipoTarjeta)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxPagarRecibo_Year)
        Me.GroupBox1.Controls.Add(Me.TextBoxPagarRecibo_Numeracion)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBoxPagarRecibo_Mes)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(76, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 500)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pago con Tarjeta"
        '
        'ButtonPagarRecibo_Pagar
        '
        Me.ButtonPagarRecibo_Pagar.Enabled = False
        Me.ButtonPagarRecibo_Pagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPagarRecibo_Pagar.Location = New System.Drawing.Point(70, 419)
        Me.ButtonPagarRecibo_Pagar.Name = "ButtonPagarRecibo_Pagar"
        Me.ButtonPagarRecibo_Pagar.Size = New System.Drawing.Size(192, 69)
        Me.ButtonPagarRecibo_Pagar.TabIndex = 12
        Me.ButtonPagarRecibo_Pagar.Text = "PAGAR"
        Me.ButtonPagarRecibo_Pagar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ButtonPagarRecibo_Generar)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(580, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(354, 500)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pago en Efectivo"
        '
        'ButtonPagarRecibo_Generar
        '
        Me.ButtonPagarRecibo_Generar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPagarRecibo_Generar.Location = New System.Drawing.Point(63, 328)
        Me.ButtonPagarRecibo_Generar.Name = "ButtonPagarRecibo_Generar"
        Me.ButtonPagarRecibo_Generar.Size = New System.Drawing.Size(235, 80)
        Me.ButtonPagarRecibo_Generar.TabIndex = 20
        Me.ButtonPagarRecibo_Generar.Text = "GENERAR"
        Me.ButtonPagarRecibo_Generar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(333, 125)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Los pagos en efectivo se realizan en " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cualquier tienda de auto-servicio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(OXXO o" &
    " Seven), en este momento" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "generaras la referencia y pagaras " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "directo en la tien" &
    "da."
        '
        'PagarRecibo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 577)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PagarRecibo"
        Me.Text = "Pagar Recibo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxPagarRecibo_TipoTarjeta As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxPagarRecibo_Numeracion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxPagarRecibo_Mes As TextBox
    Friend WithEvents TextBoxPagarRecibo_Year As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxPagarRecibo_CVV As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ButtonPagarRecibo_Generar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonPagarRecibo_Pagar As Button
End Class
