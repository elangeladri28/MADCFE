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
        CType(Me.dgvHistorial_Usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvHistorial_Medidores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvHistorial_Historial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvHistorial_Usuarios
        '
        Me.dgvHistorial_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistorial_Usuarios.Location = New System.Drawing.Point(12, 120)
        Me.dgvHistorial_Usuarios.Name = "dgvHistorial_Usuarios"
        Me.dgvHistorial_Usuarios.Size = New System.Drawing.Size(437, 150)
        Me.dgvHistorial_Usuarios.TabIndex = 0
        '
        'dgvHistorial_Medidores
        '
        Me.dgvHistorial_Medidores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistorial_Medidores.Location = New System.Drawing.Point(12, 320)
        Me.dgvHistorial_Medidores.Name = "dgvHistorial_Medidores"
        Me.dgvHistorial_Medidores.Size = New System.Drawing.Size(437, 150)
        Me.dgvHistorial_Medidores.TabIndex = 1
        '
        'dgvHistorial_Historial
        '
        Me.dgvHistorial_Historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistorial_Historial.Location = New System.Drawing.Point(524, 120)
        Me.dgvHistorial_Historial.Name = "dgvHistorial_Historial"
        Me.dgvHistorial_Historial.Size = New System.Drawing.Size(733, 350)
        Me.dgvHistorial_Historial.TabIndex = 2
        '
        'Historial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1269, 840)
        Me.Controls.Add(Me.dgvHistorial_Historial)
        Me.Controls.Add(Me.dgvHistorial_Medidores)
        Me.Controls.Add(Me.dgvHistorial_Usuarios)
        Me.Name = "Historial"
        Me.Text = "Historial"
        CType(Me.dgvHistorial_Usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvHistorial_Medidores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvHistorial_Historial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvHistorial_Usuarios As DataGridView
    Friend WithEvents dgvHistorial_Medidores As DataGridView
    Friend WithEvents dgvHistorial_Historial As DataGridView
End Class
