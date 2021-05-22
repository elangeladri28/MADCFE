<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Historial
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
        Me.dgvHistorial_Usuarios = New System.Windows.Forms.DataGridView()
        Me.dgvHistorial_Medidores = New System.Windows.Forms.DataGridView()
        Me.dgvHistorial_Historial = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblIDHistorial_Cliente = New System.Windows.Forms.Label()
        Me.lblIDHistorial_Medidor = New System.Windows.Forms.Label()
        CType(Me.dgvHistorial_Usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvHistorial_Medidores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvHistorial_Historial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvHistorial_Usuarios
        '
        Me.dgvHistorial_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistorial_Usuarios.Location = New System.Drawing.Point(18, 46)
        Me.dgvHistorial_Usuarios.Name = "dgvHistorial_Usuarios"
        Me.dgvHistorial_Usuarios.RowHeadersWidth = 51
        Me.dgvHistorial_Usuarios.Size = New System.Drawing.Size(437, 150)
        Me.dgvHistorial_Usuarios.TabIndex = 0
        '
        'dgvHistorial_Medidores
        '
        Me.dgvHistorial_Medidores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistorial_Medidores.Location = New System.Drawing.Point(18, 246)
        Me.dgvHistorial_Medidores.Name = "dgvHistorial_Medidores"
        Me.dgvHistorial_Medidores.RowHeadersWidth = 51
        Me.dgvHistorial_Medidores.Size = New System.Drawing.Size(437, 150)
        Me.dgvHistorial_Medidores.TabIndex = 1
        '
        'dgvHistorial_Historial
        '
        Me.dgvHistorial_Historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistorial_Historial.Location = New System.Drawing.Point(485, 46)
        Me.dgvHistorial_Historial.Name = "dgvHistorial_Historial"
        Me.dgvHistorial_Historial.RowHeadersWidth = 51
        Me.dgvHistorial_Historial.Size = New System.Drawing.Size(536, 350)
        Me.dgvHistorial_Historial.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Selecciona un Cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 228)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Selecciona un Medidor:"
        '
        'lblIDHistorial_Cliente
        '
        Me.lblIDHistorial_Cliente.AutoSize = True
        Me.lblIDHistorial_Cliente.Location = New System.Drawing.Point(344, 29)
        Me.lblIDHistorial_Cliente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIDHistorial_Cliente.Name = "lblIDHistorial_Cliente"
        Me.lblIDHistorial_Cliente.Size = New System.Drawing.Size(53, 13)
        Me.lblIDHistorial_Cliente.TabIndex = 5
        Me.lblIDHistorial_Cliente.Text = "ID Cliente"
        '
        'lblIDHistorial_Medidor
        '
        Me.lblIDHistorial_Medidor.AutoSize = True
        Me.lblIDHistorial_Medidor.Location = New System.Drawing.Point(344, 228)
        Me.lblIDHistorial_Medidor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIDHistorial_Medidor.Name = "lblIDHistorial_Medidor"
        Me.lblIDHistorial_Medidor.Size = New System.Drawing.Size(59, 13)
        Me.lblIDHistorial_Medidor.TabIndex = 6
        Me.lblIDHistorial_Medidor.Text = "ID Medidor"
        '
        'Historial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 428)
        Me.Controls.Add(Me.lblIDHistorial_Medidor)
        Me.Controls.Add(Me.lblIDHistorial_Cliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvHistorial_Historial)
        Me.Controls.Add(Me.dgvHistorial_Medidores)
        Me.Controls.Add(Me.dgvHistorial_Usuarios)
        Me.Name = "Historial"
        Me.Text = "Historial"
        CType(Me.dgvHistorial_Usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvHistorial_Medidores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvHistorial_Historial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvHistorial_Usuarios As DataGridView
    Friend WithEvents dgvHistorial_Medidores As DataGridView
    Friend WithEvents dgvHistorial_Historial As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblIDHistorial_Cliente As Label
    Friend WithEvents lblIDHistorial_Medidor As Label
End Class
