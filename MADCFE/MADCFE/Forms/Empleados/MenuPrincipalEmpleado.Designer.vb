<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipalEmpleado
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
        Me.MenuStrip_MenuEmpleado = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarClientesToolStripMenuItem_MenuEmpleado = New System.Windows.Forms.ToolStripMenuItem()
        Me.Contratos_MenuEmpleado = New System.Windows.Forms.ToolStripMenuItem()
        Me.SERVICIOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarUsuarios_MenuEmpleado = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tarifas_Cargas_MenuEmpleado = New System.Windows.Forms.ToolStripMenuItem()
        Me.Consumos_Cargas_MenuPrincipal = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Recibos_Generacion_MenuEmpleado = New System.Windows.Forms.ToolStripMenuItem()
        Me.Reportes_Generacion_MenuEmpleado = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip_MenuEmpleado.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip_MenuEmpleado
        '
        Me.MenuStrip_MenuEmpleado.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip_MenuEmpleado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.CLIENTESToolStripMenuItem, Me.SERVICIOSToolStripMenuItem})
        Me.MenuStrip_MenuEmpleado.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip_MenuEmpleado.Name = "MenuStrip_MenuEmpleado"
        Me.MenuStrip_MenuEmpleado.Size = New System.Drawing.Size(837, 28)
        Me.MenuStrip_MenuEmpleado.TabIndex = 0
        Me.MenuStrip_MenuEmpleado.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(14, 24)
        '
        'CLIENTESToolStripMenuItem
        '
        Me.CLIENTESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrarClientesToolStripMenuItem_MenuEmpleado, Me.Contratos_MenuEmpleado})
        Me.CLIENTESToolStripMenuItem.Name = "CLIENTESToolStripMenuItem"
        Me.CLIENTESToolStripMenuItem.Size = New System.Drawing.Size(86, 24)
        Me.CLIENTESToolStripMenuItem.Text = "CLIENTES"
        '
        'AdministrarClientesToolStripMenuItem_MenuEmpleado
        '
        Me.AdministrarClientesToolStripMenuItem_MenuEmpleado.Name = "AdministrarClientesToolStripMenuItem_MenuEmpleado"
        Me.AdministrarClientesToolStripMenuItem_MenuEmpleado.Size = New System.Drawing.Size(225, 26)
        Me.AdministrarClientesToolStripMenuItem_MenuEmpleado.Text = "Administrar Clientes"
        '
        'Contratos_MenuEmpleado
        '
        Me.Contratos_MenuEmpleado.Name = "Contratos_MenuEmpleado"
        Me.Contratos_MenuEmpleado.Size = New System.Drawing.Size(225, 26)
        Me.Contratos_MenuEmpleado.Text = "Contratos"
        '
        'SERVICIOSToolStripMenuItem
        '
        Me.SERVICIOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrarUsuarios_MenuEmpleado, Me.CargasToolStripMenuItem, Me.GeneraciónToolStripMenuItem})
        Me.SERVICIOSToolStripMenuItem.Name = "SERVICIOSToolStripMenuItem"
        Me.SERVICIOSToolStripMenuItem.Size = New System.Drawing.Size(120, 24)
        Me.SERVICIOSToolStripMenuItem.Text = "OPERACIONES"
        '
        'AdministrarUsuarios_MenuEmpleado
        '
        Me.AdministrarUsuarios_MenuEmpleado.Name = "AdministrarUsuarios_MenuEmpleado"
        Me.AdministrarUsuarios_MenuEmpleado.Size = New System.Drawing.Size(229, 26)
        Me.AdministrarUsuarios_MenuEmpleado.Text = "Administrar Usuarios"
        '
        'CargasToolStripMenuItem
        '
        Me.CargasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tarifas_Cargas_MenuEmpleado, Me.Consumos_Cargas_MenuPrincipal})
        Me.CargasToolStripMenuItem.Name = "CargasToolStripMenuItem"
        Me.CargasToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.CargasToolStripMenuItem.Text = "Cargas"
        '
        'Tarifas_Cargas_MenuEmpleado
        '
        Me.Tarifas_Cargas_MenuEmpleado.Name = "Tarifas_Cargas_MenuEmpleado"
        Me.Tarifas_Cargas_MenuEmpleado.Size = New System.Drawing.Size(160, 26)
        Me.Tarifas_Cargas_MenuEmpleado.Text = "Tarifas"
        '
        'Consumos_Cargas_MenuPrincipal
        '
        Me.Consumos_Cargas_MenuPrincipal.Name = "Consumos_Cargas_MenuPrincipal"
        Me.Consumos_Cargas_MenuPrincipal.Size = New System.Drawing.Size(160, 26)
        Me.Consumos_Cargas_MenuPrincipal.Text = "Consumos"
        '
        'GeneraciónToolStripMenuItem
        '
        Me.GeneraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Recibos_Generacion_MenuEmpleado, Me.Reportes_Generacion_MenuEmpleado})
        Me.GeneraciónToolStripMenuItem.Name = "GeneraciónToolStripMenuItem"
        Me.GeneraciónToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.GeneraciónToolStripMenuItem.Text = "Generación"
        '
        'Recibos_Generacion_MenuEmpleado
        '
        Me.Recibos_Generacion_MenuEmpleado.Name = "Recibos_Generacion_MenuEmpleado"
        Me.Recibos_Generacion_MenuEmpleado.Size = New System.Drawing.Size(151, 26)
        Me.Recibos_Generacion_MenuEmpleado.Text = "Recibos"
        '
        'Reportes_Generacion_MenuEmpleado
        '
        Me.Reportes_Generacion_MenuEmpleado.Name = "Reportes_Generacion_MenuEmpleado"
        Me.Reportes_Generacion_MenuEmpleado.Size = New System.Drawing.Size(151, 26)
        Me.Reportes_Generacion_MenuEmpleado.Text = "Reportes"
        '
        'MenuPrincipalEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MADCFE.My.Resources.Resources.CFE_removebg_preview
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(837, 539)
        Me.Controls.Add(Me.MenuStrip_MenuEmpleado)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip_MenuEmpleado
        Me.Name = "MenuPrincipalEmpleado"
        Me.Text = "Menu Principal Empleado"
        Me.MenuStrip_MenuEmpleado.ResumeLayout(False)
        Me.MenuStrip_MenuEmpleado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip_MenuEmpleado As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CLIENTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarClientesToolStripMenuItem_MenuEmpleado As ToolStripMenuItem
    Friend WithEvents Contratos_MenuEmpleado As ToolStripMenuItem
    Friend WithEvents SERVICIOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Tarifas_Cargas_MenuEmpleado As ToolStripMenuItem
    Friend WithEvents Consumos_Cargas_MenuPrincipal As ToolStripMenuItem
    Friend WithEvents GeneraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Recibos_Generacion_MenuEmpleado As ToolStripMenuItem
    Friend WithEvents Reportes_Generacion_MenuEmpleado As ToolStripMenuItem
    Friend WithEvents AdministrarUsuarios_MenuEmpleado As ToolStripMenuItem
End Class
