<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MacroPrincipal
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
        Me.grdClicks = New System.Windows.Forms.DataGridView()
        Me.btnEjecutar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEjecutarMacro = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Segundos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.X = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Y = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grdClicks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdClicks
        '
        Me.grdClicks.AllowUserToAddRows = False
        Me.grdClicks.AllowUserToDeleteRows = False
        Me.grdClicks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdClicks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdClicks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fecha, Me.Segundos, Me.X, Me.Y})
        Me.grdClicks.Location = New System.Drawing.Point(12, 82)
        Me.grdClicks.Name = "grdClicks"
        Me.grdClicks.ReadOnly = True
        Me.grdClicks.Size = New System.Drawing.Size(550, 273)
        Me.grdClicks.TabIndex = 0
        '
        'btnEjecutar
        '
        Me.btnEjecutar.Location = New System.Drawing.Point(12, 23)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(75, 23)
        Me.btnEjecutar.TabIndex = 1
        Me.btnEjecutar.Text = "Grabar"
        Me.btnEjecutar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(217, 23)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnEjecutarMacro
        '
        Me.btnEjecutarMacro.Location = New System.Drawing.Point(12, 52)
        Me.btnEjecutarMacro.Name = "btnEjecutarMacro"
        Me.btnEjecutarMacro.Size = New System.Drawing.Size(100, 23)
        Me.btnEjecutarMacro.TabIndex = 3
        Me.btnEjecutarMacro.Text = "Ejecutar Macro"
        Me.btnEjecutarMacro.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(137, 53)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 4
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Fecha
        '
        Me.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'Segundos
        '
        Me.Segundos.HeaderText = "Segundos"
        Me.Segundos.Name = "Segundos"
        Me.Segundos.ReadOnly = True
        '
        'X
        '
        Me.X.HeaderText = "X"
        Me.X.Name = "X"
        Me.X.ReadOnly = True
        '
        'Y
        '
        Me.Y.HeaderText = "Y"
        Me.Y.Name = "Y"
        Me.Y.ReadOnly = True
        '
        'MacroPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(574, 367)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnEjecutarMacro)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnEjecutar)
        Me.Controls.Add(Me.grdClicks)
        Me.Name = "MacroPrincipal"
        Me.Text = "Form1"
        CType(Me.grdClicks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdClicks As DataGridView
    Friend WithEvents btnEjecutar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEjecutarMacro As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Segundos As DataGridViewTextBoxColumn
    Friend WithEvents X As DataGridViewTextBoxColumn
    Friend WithEvents Y As DataGridViewTextBoxColumn
End Class
