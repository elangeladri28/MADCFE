<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerarRecibo
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
        Me.dgvRecibo_Usuarios = New System.Windows.Forms.DataGridView()
        Me.dgvRecibo_Medidor = New System.Windows.Forms.DataGridView()
        Me.dgvRecibo_Periodo = New System.Windows.Forms.DataGridView()
        Me.lblRecibo_idUser = New System.Windows.Forms.Label()
        Me.lblRecibos_idMedidor = New System.Windows.Forms.Label()
        Me.lblRecibos_idPeriodo = New System.Windows.Forms.Label()
        Me.txtRecibo_NombreCliente = New System.Windows.Forms.TextBox()
        Me.txtRecibo_Direccion = New System.Windows.Forms.TextBox()
        Me.txtRecibo_Medidor = New System.Windows.Forms.TextBox()
        Me.txtRecibo_Periodo = New System.Windows.Forms.TextBox()
        Me.txtRecibo_kwBase = New System.Windows.Forms.TextBox()
        Me.txtRecibo_kwIntermedia = New System.Windows.Forms.TextBox()
        Me.txtRecibo_Excedente = New System.Windows.Forms.TextBox()
        Me.txtRecibo_RateBase = New System.Windows.Forms.TextBox()
        Me.txtRecibo_rateIntermediate = New System.Windows.Forms.TextBox()
        Me.txtRecibo_rateExcedent = New System.Windows.Forms.TextBox()
        Me.txtRecibo_Subtotal = New System.Windows.Forms.TextBox()
        Me.txtRecibo_IVA = New System.Windows.Forms.TextBox()
        Me.txtRecibo_Total = New System.Windows.Forms.TextBox()
        Me.btnRecibo_Pagar = New System.Windows.Forms.Button()
        CType(Me.dgvRecibo_Usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRecibo_Medidor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRecibo_Periodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRecibo_Usuarios
        '
        Me.dgvRecibo_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecibo_Usuarios.Location = New System.Drawing.Point(12, 43)
        Me.dgvRecibo_Usuarios.Name = "dgvRecibo_Usuarios"
        Me.dgvRecibo_Usuarios.Size = New System.Drawing.Size(342, 150)
        Me.dgvRecibo_Usuarios.TabIndex = 0
        '
        'dgvRecibo_Medidor
        '
        Me.dgvRecibo_Medidor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecibo_Medidor.Location = New System.Drawing.Point(12, 222)
        Me.dgvRecibo_Medidor.Name = "dgvRecibo_Medidor"
        Me.dgvRecibo_Medidor.Size = New System.Drawing.Size(342, 150)
        Me.dgvRecibo_Medidor.TabIndex = 1
        '
        'dgvRecibo_Periodo
        '
        Me.dgvRecibo_Periodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecibo_Periodo.Location = New System.Drawing.Point(12, 403)
        Me.dgvRecibo_Periodo.Name = "dgvRecibo_Periodo"
        Me.dgvRecibo_Periodo.Size = New System.Drawing.Size(342, 150)
        Me.dgvRecibo_Periodo.TabIndex = 2
        '
        'lblRecibo_idUser
        '
        Me.lblRecibo_idUser.AutoSize = True
        Me.lblRecibo_idUser.Location = New System.Drawing.Point(12, 27)
        Me.lblRecibo_idUser.Name = "lblRecibo_idUser"
        Me.lblRecibo_idUser.Size = New System.Drawing.Size(39, 13)
        Me.lblRecibo_idUser.TabIndex = 3
        Me.lblRecibo_idUser.Text = "Label1"
        Me.lblRecibo_idUser.Visible = False
        '
        'lblRecibos_idMedidor
        '
        Me.lblRecibos_idMedidor.AutoSize = True
        Me.lblRecibos_idMedidor.Location = New System.Drawing.Point(12, 206)
        Me.lblRecibos_idMedidor.Name = "lblRecibos_idMedidor"
        Me.lblRecibos_idMedidor.Size = New System.Drawing.Size(39, 13)
        Me.lblRecibos_idMedidor.TabIndex = 4
        Me.lblRecibos_idMedidor.Text = "Label1"
        Me.lblRecibos_idMedidor.Visible = False
        '
        'lblRecibos_idPeriodo
        '
        Me.lblRecibos_idPeriodo.AutoSize = True
        Me.lblRecibos_idPeriodo.Location = New System.Drawing.Point(12, 387)
        Me.lblRecibos_idPeriodo.Name = "lblRecibos_idPeriodo"
        Me.lblRecibos_idPeriodo.Size = New System.Drawing.Size(39, 13)
        Me.lblRecibos_idPeriodo.TabIndex = 5
        Me.lblRecibos_idPeriodo.Text = "Label1"
        Me.lblRecibos_idPeriodo.Visible = False
        '
        'txtRecibo_NombreCliente
        '
        Me.txtRecibo_NombreCliente.Location = New System.Drawing.Point(418, 43)
        Me.txtRecibo_NombreCliente.Name = "txtRecibo_NombreCliente"
        Me.txtRecibo_NombreCliente.ReadOnly = True
        Me.txtRecibo_NombreCliente.Size = New System.Drawing.Size(205, 20)
        Me.txtRecibo_NombreCliente.TabIndex = 6
        '
        'txtRecibo_Direccion
        '
        Me.txtRecibo_Direccion.Location = New System.Drawing.Point(418, 85)
        Me.txtRecibo_Direccion.Name = "txtRecibo_Direccion"
        Me.txtRecibo_Direccion.ReadOnly = True
        Me.txtRecibo_Direccion.Size = New System.Drawing.Size(117, 20)
        Me.txtRecibo_Direccion.TabIndex = 7
        '
        'txtRecibo_Medidor
        '
        Me.txtRecibo_Medidor.Location = New System.Drawing.Point(418, 125)
        Me.txtRecibo_Medidor.Name = "txtRecibo_Medidor"
        Me.txtRecibo_Medidor.ReadOnly = True
        Me.txtRecibo_Medidor.Size = New System.Drawing.Size(117, 20)
        Me.txtRecibo_Medidor.TabIndex = 8
        '
        'txtRecibo_Periodo
        '
        Me.txtRecibo_Periodo.Location = New System.Drawing.Point(418, 162)
        Me.txtRecibo_Periodo.Name = "txtRecibo_Periodo"
        Me.txtRecibo_Periodo.ReadOnly = True
        Me.txtRecibo_Periodo.Size = New System.Drawing.Size(117, 20)
        Me.txtRecibo_Periodo.TabIndex = 9
        '
        'txtRecibo_kwBase
        '
        Me.txtRecibo_kwBase.Location = New System.Drawing.Point(418, 260)
        Me.txtRecibo_kwBase.Name = "txtRecibo_kwBase"
        Me.txtRecibo_kwBase.ReadOnly = True
        Me.txtRecibo_kwBase.Size = New System.Drawing.Size(117, 20)
        Me.txtRecibo_kwBase.TabIndex = 10
        '
        'txtRecibo_kwIntermedia
        '
        Me.txtRecibo_kwIntermedia.Location = New System.Drawing.Point(418, 306)
        Me.txtRecibo_kwIntermedia.Name = "txtRecibo_kwIntermedia"
        Me.txtRecibo_kwIntermedia.ReadOnly = True
        Me.txtRecibo_kwIntermedia.Size = New System.Drawing.Size(117, 20)
        Me.txtRecibo_kwIntermedia.TabIndex = 11
        '
        'txtRecibo_Excedente
        '
        Me.txtRecibo_Excedente.Location = New System.Drawing.Point(418, 352)
        Me.txtRecibo_Excedente.Name = "txtRecibo_Excedente"
        Me.txtRecibo_Excedente.ReadOnly = True
        Me.txtRecibo_Excedente.Size = New System.Drawing.Size(117, 20)
        Me.txtRecibo_Excedente.TabIndex = 12
        '
        'txtRecibo_RateBase
        '
        Me.txtRecibo_RateBase.Location = New System.Drawing.Point(572, 260)
        Me.txtRecibo_RateBase.Name = "txtRecibo_RateBase"
        Me.txtRecibo_RateBase.ReadOnly = True
        Me.txtRecibo_RateBase.Size = New System.Drawing.Size(117, 20)
        Me.txtRecibo_RateBase.TabIndex = 13
        '
        'txtRecibo_rateIntermediate
        '
        Me.txtRecibo_rateIntermediate.Location = New System.Drawing.Point(572, 306)
        Me.txtRecibo_rateIntermediate.Name = "txtRecibo_rateIntermediate"
        Me.txtRecibo_rateIntermediate.ReadOnly = True
        Me.txtRecibo_rateIntermediate.Size = New System.Drawing.Size(117, 20)
        Me.txtRecibo_rateIntermediate.TabIndex = 14
        '
        'txtRecibo_rateExcedent
        '
        Me.txtRecibo_rateExcedent.Location = New System.Drawing.Point(572, 352)
        Me.txtRecibo_rateExcedent.Name = "txtRecibo_rateExcedent"
        Me.txtRecibo_rateExcedent.ReadOnly = True
        Me.txtRecibo_rateExcedent.Size = New System.Drawing.Size(117, 20)
        Me.txtRecibo_rateExcedent.TabIndex = 15
        '
        'txtRecibo_Subtotal
        '
        Me.txtRecibo_Subtotal.Location = New System.Drawing.Point(714, 413)
        Me.txtRecibo_Subtotal.Name = "txtRecibo_Subtotal"
        Me.txtRecibo_Subtotal.ReadOnly = True
        Me.txtRecibo_Subtotal.Size = New System.Drawing.Size(117, 20)
        Me.txtRecibo_Subtotal.TabIndex = 16
        '
        'txtRecibo_IVA
        '
        Me.txtRecibo_IVA.Location = New System.Drawing.Point(755, 439)
        Me.txtRecibo_IVA.Name = "txtRecibo_IVA"
        Me.txtRecibo_IVA.ReadOnly = True
        Me.txtRecibo_IVA.Size = New System.Drawing.Size(76, 20)
        Me.txtRecibo_IVA.TabIndex = 17
        '
        'txtRecibo_Total
        '
        Me.txtRecibo_Total.Location = New System.Drawing.Point(714, 465)
        Me.txtRecibo_Total.Name = "txtRecibo_Total"
        Me.txtRecibo_Total.ReadOnly = True
        Me.txtRecibo_Total.Size = New System.Drawing.Size(117, 20)
        Me.txtRecibo_Total.TabIndex = 18
        '
        'btnRecibo_Pagar
        '
        Me.btnRecibo_Pagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecibo_Pagar.Location = New System.Drawing.Point(716, 514)
        Me.btnRecibo_Pagar.Name = "btnRecibo_Pagar"
        Me.btnRecibo_Pagar.Size = New System.Drawing.Size(115, 39)
        Me.btnRecibo_Pagar.TabIndex = 19
        Me.btnRecibo_Pagar.Text = "Pagar"
        Me.btnRecibo_Pagar.UseVisualStyleBackColor = True
        '
        'GenerarRecibo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 566)
        Me.Controls.Add(Me.btnRecibo_Pagar)
        Me.Controls.Add(Me.txtRecibo_Total)
        Me.Controls.Add(Me.txtRecibo_IVA)
        Me.Controls.Add(Me.txtRecibo_Subtotal)
        Me.Controls.Add(Me.txtRecibo_rateExcedent)
        Me.Controls.Add(Me.txtRecibo_rateIntermediate)
        Me.Controls.Add(Me.txtRecibo_RateBase)
        Me.Controls.Add(Me.txtRecibo_Excedente)
        Me.Controls.Add(Me.txtRecibo_kwIntermedia)
        Me.Controls.Add(Me.txtRecibo_kwBase)
        Me.Controls.Add(Me.txtRecibo_Periodo)
        Me.Controls.Add(Me.txtRecibo_Medidor)
        Me.Controls.Add(Me.txtRecibo_Direccion)
        Me.Controls.Add(Me.txtRecibo_NombreCliente)
        Me.Controls.Add(Me.lblRecibos_idPeriodo)
        Me.Controls.Add(Me.lblRecibos_idMedidor)
        Me.Controls.Add(Me.lblRecibo_idUser)
        Me.Controls.Add(Me.dgvRecibo_Periodo)
        Me.Controls.Add(Me.dgvRecibo_Medidor)
        Me.Controls.Add(Me.dgvRecibo_Usuarios)
        Me.Name = "GenerarRecibo"
        Me.Text = "GenerarRecibo"
        CType(Me.dgvRecibo_Usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRecibo_Medidor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRecibo_Periodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvRecibo_Usuarios As DataGridView
    Friend WithEvents dgvRecibo_Medidor As DataGridView
    Friend WithEvents dgvRecibo_Periodo As DataGridView
    Friend WithEvents lblRecibo_idUser As Label
    Friend WithEvents lblRecibos_idMedidor As Label
    Friend WithEvents lblRecibos_idPeriodo As Label
    Friend WithEvents txtRecibo_NombreCliente As TextBox
    Friend WithEvents txtRecibo_Direccion As TextBox
    Friend WithEvents txtRecibo_Medidor As TextBox
    Friend WithEvents txtRecibo_Periodo As TextBox
    Friend WithEvents txtRecibo_kwBase As TextBox
    Friend WithEvents txtRecibo_kwIntermedia As TextBox
    Friend WithEvents txtRecibo_Excedente As TextBox
    Friend WithEvents txtRecibo_RateBase As TextBox
    Friend WithEvents txtRecibo_rateIntermediate As TextBox
    Friend WithEvents txtRecibo_rateExcedent As TextBox
    Friend WithEvents txtRecibo_Subtotal As TextBox
    Friend WithEvents txtRecibo_IVA As TextBox
    Friend WithEvents txtRecibo_Total As TextBox
    Friend WithEvents btnRecibo_Pagar As Button
End Class
