<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Monto Total Factura"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(15, 25)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(200, 20)
        Me.txtNombre.TabIndex = 2
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(15, 64)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(200, 20)
        Me.txtMonto.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 50)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Calcular Impuesto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblResultado
        '
        Me.lblResultado.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblResultado.Location = New System.Drawing.Point(12, 150)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(203, 155)
        Me.lblResultado.TabIndex = 5
        Me.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(230, 314)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ejercicio4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblResultado As Label
End Class
