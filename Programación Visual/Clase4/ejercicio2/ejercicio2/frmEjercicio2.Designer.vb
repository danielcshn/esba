<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEjercicio2
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
        Me.lblDato = New System.Windows.Forms.Label()
        Me.BtnNombre = New System.Windows.Forms.Button()
        Me.BtnEdad = New System.Windows.Forms.Button()
        Me.BtnPais = New System.Windows.Forms.Button()
        Me.BtnFinalizar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDato
        '
        Me.lblDato.AutoSize = True
        Me.lblDato.Location = New System.Drawing.Point(12, 16)
        Me.lblDato.Name = "lblDato"
        Me.lblDato.Size = New System.Drawing.Size(39, 13)
        Me.lblDato.TabIndex = 0
        Me.lblDato.Text = "Label1"
        '
        'BtnNombre
        '
        Me.BtnNombre.Location = New System.Drawing.Point(15, 16)
        Me.BtnNombre.Name = "BtnNombre"
        Me.BtnNombre.Size = New System.Drawing.Size(100, 30)
        Me.BtnNombre.TabIndex = 1
        Me.BtnNombre.Text = "Nombre"
        Me.BtnNombre.UseVisualStyleBackColor = True
        '
        'BtnEdad
        '
        Me.BtnEdad.Location = New System.Drawing.Point(15, 52)
        Me.BtnEdad.Name = "BtnEdad"
        Me.BtnEdad.Size = New System.Drawing.Size(100, 30)
        Me.BtnEdad.TabIndex = 2
        Me.BtnEdad.Text = "Edad"
        Me.BtnEdad.UseVisualStyleBackColor = True
        '
        'BtnPais
        '
        Me.BtnPais.Location = New System.Drawing.Point(15, 88)
        Me.BtnPais.Name = "BtnPais"
        Me.BtnPais.Size = New System.Drawing.Size(100, 30)
        Me.BtnPais.TabIndex = 3
        Me.BtnPais.Text = "Pais"
        Me.BtnPais.UseVisualStyleBackColor = True
        '
        'BtnFinalizar
        '
        Me.BtnFinalizar.Location = New System.Drawing.Point(15, 124)
        Me.BtnFinalizar.Name = "BtnFinalizar"
        Me.BtnFinalizar.Size = New System.Drawing.Size(100, 30)
        Me.BtnFinalizar.TabIndex = 4
        Me.BtnFinalizar.Text = "Finalizar"
        Me.BtnFinalizar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BtnNombre)
        Me.Panel1.Controls.Add(Me.BtnFinalizar)
        Me.Panel1.Controls.Add(Me.BtnEdad)
        Me.Panel1.Controls.Add(Me.BtnPais)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(127, 167)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.lblDato)
        Me.Panel2.Location = New System.Drawing.Point(145, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(127, 167)
        Me.Panel2.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 190)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ejercicio2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblDato As Label
    Friend WithEvents BtnNombre As Button
    Friend WithEvents BtnEdad As Button
    Friend WithEvents BtnPais As Button
    Friend WithEvents BtnFinalizar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
