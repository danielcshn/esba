<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnPaises = New System.Windows.Forms.Button()
        Me.btnEmpleados = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPaises
        '
        Me.btnPaises.Location = New System.Drawing.Point(12, 12)
        Me.btnPaises.Name = "btnPaises"
        Me.btnPaises.Size = New System.Drawing.Size(120, 50)
        Me.btnPaises.TabIndex = 0
        Me.btnPaises.Text = "FrmPaises"
        Me.btnPaises.UseVisualStyleBackColor = True
        '
        'btnEmpleados
        '
        Me.btnEmpleados.Location = New System.Drawing.Point(138, 12)
        Me.btnEmpleados.Name = "btnEmpleados"
        Me.btnEmpleados.Size = New System.Drawing.Size(120, 50)
        Me.btnEmpleados.TabIndex = 1
        Me.btnEmpleados.Text = "FrmEmpleados"
        Me.btnEmpleados.UseVisualStyleBackColor = True
        '
        'btnProductos
        '
        Me.btnProductos.Location = New System.Drawing.Point(264, 12)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(120, 50)
        Me.btnProductos.TabIndex = 2
        Me.btnProductos.Text = "FrmProductos"
        Me.btnProductos.UseVisualStyleBackColor = True
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 76)
        Me.Controls.Add(Me.btnProductos)
        Me.Controls.Add(Me.btnEmpleados)
        Me.Controls.Add(Me.btnPaises)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPrincipal"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPaises As Button
    Friend WithEvents btnEmpleados As Button
    Friend WithEvents btnProductos As Button
End Class
