<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recibo_Final
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtSaldos2 = New System.Windows.Forms.TextBox()
        Me.txtCliente2 = New System.Windows.Forms.TextBox()
        Me.btnSalir2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombre2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPais2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SkyBlue
        Me.Button1.Font = New System.Drawing.Font("Consolas", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(210, 455)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 39)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Imprimir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(105, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(300, 44)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Revise los datos y seleccione" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " ""Aceptar"" e ""Imprimir"""
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(23, 463)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(166, 26)
        Me.CheckBox1.TabIndex = 19
        Me.CheckBox1.Text = "Aceptar Datos"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'txtSaldos2
        '
        Me.txtSaldos2.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldos2.Location = New System.Drawing.Point(210, 331)
        Me.txtSaldos2.Name = "txtSaldos2"
        Me.txtSaldos2.Size = New System.Drawing.Size(109, 31)
        Me.txtSaldos2.TabIndex = 18
        '
        'txtCliente2
        '
        Me.txtCliente2.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente2.Location = New System.Drawing.Point(174, 163)
        Me.txtCliente2.Name = "txtCliente2"
        Me.txtCliente2.Size = New System.Drawing.Size(194, 31)
        Me.txtCliente2.TabIndex = 17
        '
        'btnSalir2
        '
        Me.btnSalir2.BackColor = System.Drawing.Color.Tomato
        Me.btnSalir2.Font = New System.Drawing.Font("Consolas", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir2.Location = New System.Drawing.Point(364, 455)
        Me.btnSalir2.Name = "btnSalir2"
        Me.btnSalir2.Size = New System.Drawing.Size(111, 39)
        Me.btnSalir2.TabIndex = 16
        Me.btnSalir2.Text = "Salir"
        Me.btnSalir2.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(47, 397)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(406, 23)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "¡Gracias por Preferirnos, Lindo Dia!"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 334)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 23)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Saldo Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 23)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 28)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Recibo de la Transaccion:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(325, 339)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 23)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Lps"
        '
        'txtNombre2
        '
        Me.txtNombre2.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre2.Location = New System.Drawing.Point(149, 222)
        Me.txtNombre2.Name = "txtNombre2"
        Me.txtNombre2.Size = New System.Drawing.Size(194, 31)
        Me.txtNombre2.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(47, 166)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 23)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Identidad:"
        '
        'txtPais2
        '
        Me.txtPais2.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPais2.Location = New System.Drawing.Point(149, 274)
        Me.txtPais2.Name = "txtPais2"
        Me.txtPais2.Size = New System.Drawing.Size(194, 31)
        Me.txtPais2.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(47, 277)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 23)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Pais:"
        '
        'Recibo_Final
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(496, 515)
        Me.Controls.Add(Me.txtPais2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNombre2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtSaldos2)
        Me.Controls.Add(Me.txtCliente2)
        Me.Controls.Add(Me.btnSalir2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Recibo_Final"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recibo_Final"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Public WithEvents txtSaldos2 As TextBox
    Public WithEvents txtCliente2 As TextBox
    Public WithEvents btnSalir2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Public WithEvents txtNombre2 As TextBox
    Friend WithEvents Label7 As Label
    Public WithEvents txtPais2 As TextBox
    Friend WithEvents Label8 As Label
End Class
