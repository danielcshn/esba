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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTrabajador = New System.Windows.Forms.TextBox()
        Me.txtSueldoBase = New System.Windows.Forms.TextBox()
        Me.txtHorasExtras = New System.Windows.Forms.TextBox()
        Me.txtPagoHoras = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbNocturno = New System.Windows.Forms.RadioButton()
        Me.rbDiurno = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbContribuciones = New System.Windows.Forms.CheckBox()
        Me.cbAportes = New System.Windows.Forms.CheckBox()
        Me.cbRenta = New System.Windows.Forms.CheckBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSueldoNeto = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Trabajador:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sueldo Basico:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Horas Extras:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Pago Horas Extras S/."
        '
        'txtTrabajador
        '
        Me.txtTrabajador.Location = New System.Drawing.Point(204, 22)
        Me.txtTrabajador.Name = "txtTrabajador"
        Me.txtTrabajador.Size = New System.Drawing.Size(200, 20)
        Me.txtTrabajador.TabIndex = 4
        '
        'txtSueldoBase
        '
        Me.txtSueldoBase.Location = New System.Drawing.Point(204, 62)
        Me.txtSueldoBase.Name = "txtSueldoBase"
        Me.txtSueldoBase.Size = New System.Drawing.Size(100, 20)
        Me.txtSueldoBase.TabIndex = 5
        '
        'txtHorasExtras
        '
        Me.txtHorasExtras.Location = New System.Drawing.Point(204, 103)
        Me.txtHorasExtras.Name = "txtHorasExtras"
        Me.txtHorasExtras.Size = New System.Drawing.Size(100, 20)
        Me.txtHorasExtras.TabIndex = 6
        '
        'txtPagoHoras
        '
        Me.txtPagoHoras.Enabled = False
        Me.txtPagoHoras.Location = New System.Drawing.Point(204, 142)
        Me.txtPagoHoras.Name = "txtPagoHoras"
        Me.txtPagoHoras.Size = New System.Drawing.Size(100, 20)
        Me.txtPagoHoras.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbNocturno)
        Me.GroupBox1.Controls.Add(Me.rbDiurno)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(310, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(133, 102)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Turno"
        '
        'rbNocturno
        '
        Me.rbNocturno.AutoSize = True
        Me.rbNocturno.Location = New System.Drawing.Point(17, 55)
        Me.rbNocturno.Name = "rbNocturno"
        Me.rbNocturno.Size = New System.Drawing.Size(92, 24)
        Me.rbNocturno.TabIndex = 13
        Me.rbNocturno.TabStop = True
        Me.rbNocturno.Text = "Nocturno"
        Me.rbNocturno.UseVisualStyleBackColor = True
        '
        'rbDiurno
        '
        Me.rbDiurno.AutoSize = True
        Me.rbDiurno.Checked = True
        Me.rbDiurno.Location = New System.Drawing.Point(17, 25)
        Me.rbDiurno.Name = "rbDiurno"
        Me.rbDiurno.Size = New System.Drawing.Size(74, 24)
        Me.rbDiurno.TabIndex = 12
        Me.rbDiurno.TabStop = True
        Me.rbDiurno.Text = "Diurno"
        Me.rbDiurno.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbContribuciones)
        Me.GroupBox2.Controls.Add(Me.cbAportes)
        Me.GroupBox2.Controls.Add(Me.cbRenta)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(24, 186)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 120)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Descuentos"
        '
        'cbContribuciones
        '
        Me.cbContribuciones.AutoSize = True
        Me.cbContribuciones.Location = New System.Drawing.Point(13, 85)
        Me.cbContribuciones.Name = "cbContribuciones"
        Me.cbContribuciones.Size = New System.Drawing.Size(134, 24)
        Me.cbContribuciones.TabIndex = 0
        Me.cbContribuciones.Text = "Contribuciones"
        Me.cbContribuciones.UseVisualStyleBackColor = True
        '
        'cbAportes
        '
        Me.cbAportes.AutoSize = True
        Me.cbAportes.Location = New System.Drawing.Point(13, 55)
        Me.cbAportes.Name = "cbAportes"
        Me.cbAportes.Size = New System.Drawing.Size(84, 24)
        Me.cbAportes.TabIndex = 11
        Me.cbAportes.Text = "Aportes"
        Me.cbAportes.UseVisualStyleBackColor = True
        '
        'cbRenta
        '
        Me.cbRenta.AutoSize = True
        Me.cbRenta.Location = New System.Drawing.Point(13, 25)
        Me.cbRenta.Name = "cbRenta"
        Me.cbRenta.Size = New System.Drawing.Size(72, 24)
        Me.cbRenta.TabIndex = 10
        Me.cbRenta.Text = "Renta"
        Me.cbRenta.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(310, 186)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 10
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(310, 215)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 11
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(310, 244)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 325)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Sueldo Neto S/."
        '
        'txtSueldoNeto
        '
        Me.txtSueldoNeto.Enabled = False
        Me.txtSueldoNeto.Location = New System.Drawing.Point(146, 327)
        Me.txtSueldoNeto.Name = "txtSueldoNeto"
        Me.txtSueldoNeto.Size = New System.Drawing.Size(100, 20)
        Me.txtSueldoNeto.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(465, 376)
        Me.Controls.Add(Me.txtSueldoNeto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtPagoHoras)
        Me.Controls.Add(Me.txtHorasExtras)
        Me.Controls.Add(Me.txtSueldoBase)
        Me.Controls.Add(Me.txtTrabajador)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Boleta de Sueldo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTrabajador As TextBox
    Friend WithEvents txtSueldoBase As TextBox
    Friend WithEvents txtHorasExtras As TextBox
    Friend WithEvents txtPagoHoras As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbAportes As CheckBox
    Friend WithEvents cbRenta As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbContribuciones As CheckBox
    Friend WithEvents rbNocturno As RadioButton
    Friend WithEvents rbDiurno As RadioButton
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSueldoNeto As TextBox
End Class
