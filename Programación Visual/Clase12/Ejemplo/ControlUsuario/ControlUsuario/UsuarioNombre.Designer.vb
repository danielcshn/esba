<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsuarioNombre
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.segundoNombre = New System.Windows.Forms.TextBox()
        Me.primerNombre = New System.Windows.Forms.TextBox()
        Me.apellido = New System.Windows.Forms.TextBox()
        Me.Apellido_Nombres = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.segundoNombre)
        Me.Panel1.Controls.Add(Me.primerNombre)
        Me.Panel1.Controls.Add(Me.apellido)
        Me.Panel1.Controls.Add(Me.Apellido_Nombres)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(548, 119)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(358, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Segundo Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(186, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Primer Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Apellido"
        '
        'segundoNombre
        '
        Me.segundoNombre.Location = New System.Drawing.Point(361, 68)
        Me.segundoNombre.Name = "segundoNombre"
        Me.segundoNombre.Size = New System.Drawing.Size(166, 20)
        Me.segundoNombre.TabIndex = 3
        '
        'primerNombre
        '
        Me.primerNombre.Location = New System.Drawing.Point(189, 68)
        Me.primerNombre.Name = "primerNombre"
        Me.primerNombre.Size = New System.Drawing.Size(166, 20)
        Me.primerNombre.TabIndex = 2
        '
        'apellido
        '
        Me.apellido.Location = New System.Drawing.Point(17, 68)
        Me.apellido.Name = "apellido"
        Me.apellido.Size = New System.Drawing.Size(166, 20)
        Me.apellido.TabIndex = 1
        '
        'Apellido_Nombres
        '
        Me.Apellido_Nombres.AutoSize = True
        Me.Apellido_Nombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Apellido_Nombres.Location = New System.Drawing.Point(14, 15)
        Me.Apellido_Nombres.Name = "Apellido_Nombres"
        Me.Apellido_Nombres.Size = New System.Drawing.Size(145, 18)
        Me.Apellido_Nombres.TabIndex = 0
        Me.Apellido_Nombres.Text = "Apellido y Nombre"
        '
        'UsuarioNombre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UsuarioNombre"
        Me.Size = New System.Drawing.Size(548, 119)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents apellido As Windows.Forms.TextBox
    Friend WithEvents Apellido_Nombres As Windows.Forms.Label
    Friend WithEvents segundoNombre As Windows.Forms.TextBox
    Friend WithEvents primerNombre As Windows.Forms.TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
End Class
