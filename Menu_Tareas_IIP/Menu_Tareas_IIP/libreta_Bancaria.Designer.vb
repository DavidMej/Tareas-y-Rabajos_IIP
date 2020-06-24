<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class libreta_Bancaria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(libreta_Bancaria))
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ImprimirRecibo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mtxtID = New System.Windows.Forms.MaskedTextBox()
        Me.btnAbrirCuenta = New System.Windows.Forms.Button()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lstRetiros = New System.Windows.Forms.ListBox()
        Me.lstDepositos = New System.Windows.Forms.ListBox()
        Me.txtSaldos = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnRetiro = New System.Windows.Forms.Button()
        Me.btnDeposito = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnRegresarMenu = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(889, 273)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(52, 26)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "Si"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ImprimirRecibo
        '
        Me.ImprimirRecibo.Font = New System.Drawing.Font("Segoe Print", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImprimirRecibo.Location = New System.Drawing.Point(808, 211)
        Me.ImprimirRecibo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ImprimirRecibo.Name = "ImprimirRecibo"
        Me.ImprimirRecibo.Size = New System.Drawing.Size(214, 44)
        Me.ImprimirRecibo.TabIndex = 14
        Me.ImprimirRecibo.Text = "Imprimir Recibo"
        Me.ImprimirRecibo.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Tomato
        Me.btnSalir.Font = New System.Drawing.Font("Segoe Print", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(859, 420)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(108, 44)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnNuevo.Font = New System.Drawing.Font("Segoe Print", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(859, 338)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(108, 44)
        Me.btnNuevo.TabIndex = 12
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtCiudad)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtPais)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.mtxtID)
        Me.GroupBox1.Controls.Add(Me.btnAbrirCuenta)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(127, 22)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(617, 290)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese los Datos:"
        '
        'txtCiudad
        '
        Me.txtCiudad.Location = New System.Drawing.Point(369, 228)
        Me.txtCiudad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(162, 35)
        Me.txtCiudad.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(277, 236)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 22)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Cuidad:"
        '
        'txtPais
        '
        Me.txtPais.Location = New System.Drawing.Point(88, 224)
        Me.txtPais.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(115, 35)
        Me.txtPais.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 22)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Pais:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(115, 166)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(182, 35)
        Me.txtNombre.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nombre:"
        '
        'mtxtID
        '
        Me.mtxtID.Location = New System.Drawing.Point(136, 54)
        Me.mtxtID.Mask = "9999-9999-99999"
        Me.mtxtID.Name = "mtxtID"
        Me.mtxtID.Size = New System.Drawing.Size(192, 35)
        Me.mtxtID.TabIndex = 5
        '
        'btnAbrirCuenta
        '
        Me.btnAbrirCuenta.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnAbrirCuenta.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbrirCuenta.Location = New System.Drawing.Point(404, 120)
        Me.btnAbrirCuenta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAbrirCuenta.Name = "btnAbrirCuenta"
        Me.btnAbrirCuenta.Size = New System.Drawing.Size(153, 44)
        Me.btnAbrirCuenta.TabIndex = 4
        Me.btnAbrirCuenta.Text = "Abrir Cuenta"
        Me.btnAbrirCuenta.UseVisualStyleBackColor = False
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(160, 109)
        Me.txtMonto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(94, 35)
        Me.txtMonto.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Monto Inicial:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Identidad:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.lstRetiros)
        Me.GroupBox3.Controls.Add(Me.lstDepositos)
        Me.GroupBox3.Controls.Add(Me.txtSaldos)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(128, 463)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(616, 224)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cuenta de Ahorros:"
        '
        'lstRetiros
        '
        Me.lstRetiros.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRetiros.FormattingEnabled = True
        Me.lstRetiros.ItemHeight = 23
        Me.lstRetiros.Location = New System.Drawing.Point(256, 79)
        Me.lstRetiros.Name = "lstRetiros"
        Me.lstRetiros.Size = New System.Drawing.Size(96, 119)
        Me.lstRetiros.TabIndex = 7
        '
        'lstDepositos
        '
        Me.lstDepositos.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDepositos.FormattingEnabled = True
        Me.lstDepositos.ItemHeight = 23
        Me.lstDepositos.Location = New System.Drawing.Point(69, 79)
        Me.lstDepositos.Name = "lstDepositos"
        Me.lstDepositos.Size = New System.Drawing.Size(96, 119)
        Me.lstDepositos.TabIndex = 6
        '
        'txtSaldos
        '
        Me.txtSaldos.Location = New System.Drawing.Point(425, 153)
        Me.txtSaldos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSaldos.Name = "txtSaldos"
        Me.txtSaldos.Size = New System.Drawing.Size(94, 35)
        Me.txtSaldos.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(443, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 23)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Saldo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(263, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 23)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Retiros:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(67, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Depósitos:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btnRetiro)
        Me.GroupBox2.Controls.Add(Me.btnDeposito)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(127, 338)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(617, 102)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de Transacciones:"
        '
        'btnRetiro
        '
        Me.btnRetiro.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnRetiro.Font = New System.Drawing.Font("Times New Roman", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetiro.Location = New System.Drawing.Point(374, 46)
        Me.btnRetiro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRetiro.Name = "btnRetiro"
        Me.btnRetiro.Size = New System.Drawing.Size(140, 39)
        Me.btnRetiro.TabIndex = 1
        Me.btnRetiro.Text = "Retiro"
        Me.btnRetiro.UseVisualStyleBackColor = False
        '
        'btnDeposito
        '
        Me.btnDeposito.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnDeposito.Font = New System.Drawing.Font("Times New Roman", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeposito.Location = New System.Drawing.Point(153, 46)
        Me.btnDeposito.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDeposito.Name = "btnDeposito"
        Me.btnDeposito.Size = New System.Drawing.Size(140, 39)
        Me.btnDeposito.TabIndex = 0
        Me.btnDeposito.Text = "Depósito"
        Me.btnDeposito.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnRegresarMenu)
        Me.GroupBox6.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(840, 505)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(160, 110)
        Me.GroupBox6.TabIndex = 16
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Regresar:"
        '
        'btnRegresarMenu
        '
        Me.btnRegresarMenu.BackColor = System.Drawing.Color.Tomato
        Me.btnRegresarMenu.BackgroundImage = CType(resources.GetObject("btnRegresarMenu.BackgroundImage"), System.Drawing.Image)
        Me.btnRegresarMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRegresarMenu.Location = New System.Drawing.Point(51, 29)
        Me.btnRegresarMenu.Name = "btnRegresarMenu"
        Me.btnRegresarMenu.Size = New System.Drawing.Size(73, 65)
        Me.btnRegresarMenu.TabIndex = 5
        Me.btnRegresarMenu.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnRegresarMenu.UseVisualStyleBackColor = False
        '
        'libreta_Bancaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1045, 728)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ImprimirRecibo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "libreta_Bancaria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "libreta_Bancaria"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ImprimirRecibo As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAbrirCuenta As Button
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lstRetiros As ListBox
    Friend WithEvents lstDepositos As ListBox
    Friend WithEvents txtSaldos As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnRetiro As Button
    Friend WithEvents btnDeposito As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents btnRegresarMenu As Button
    Friend WithEvents mtxtID As MaskedTextBox
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPais As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
End Class
