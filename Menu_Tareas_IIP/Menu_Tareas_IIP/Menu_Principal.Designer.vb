<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Principal
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Principal))
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.btnRestore = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.PanelForms = New System.Windows.Forms.Panel()
        Me.Panel_SubsMenus = New System.Windows.Forms.Panel()
        Me.Panel_Menu_Tareas = New System.Windows.Forms.Panel()
        Me.btnBolsaSolidaria = New System.Windows.Forms.Button()
        Me.btnTareas = New System.Windows.Forms.Button()
        Me.PanelMenuClase = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnArreglos = New System.Windows.Forms.Button()
        Me.btnClase = New System.Windows.Forms.Button()
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.titleSeparator = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BT_PanelSubsMenus = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BT2_PanelSubsMenus = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.MoverMenu = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.PanelSuperior.SuspendLayout()
        Me.Panel_SubsMenus.SuspendLayout()
        Me.Panel_Menu_Tareas.SuspendLayout()
        Me.PanelMenuClase.SuspendLayout()
        Me.PanelTitulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelSuperior
        '
        Me.PanelSuperior.BackColor = System.Drawing.Color.LimeGreen
        Me.PanelSuperior.Controls.Add(Me.btnRestore)
        Me.PanelSuperior.Controls.Add(Me.btnMinimizar)
        Me.PanelSuperior.Controls.Add(Me.btnMaximizar)
        Me.PanelSuperior.Controls.Add(Me.btnCerrar)
        Me.BT2_PanelSubsMenus.SetDecoration(Me.PanelSuperior, BunifuAnimatorNS.DecorationType.None)
        Me.BT_PanelSubsMenus.SetDecoration(Me.PanelSuperior, BunifuAnimatorNS.DecorationType.None)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(1149, 50)
        Me.PanelSuperior.TabIndex = 0
        '
        'btnRestore
        '
        Me.btnRestore.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_PanelSubsMenus.SetDecoration(Me.btnRestore, BunifuAnimatorNS.DecorationType.None)
        Me.BT2_PanelSubsMenus.SetDecoration(Me.btnRestore, BunifuAnimatorNS.DecorationType.None)
        Me.btnRestore.FlatAppearance.BorderSize = 0
        Me.btnRestore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnRestore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestore.Image = Global.Menu_Tareas_IIP.My.Resources.Resources.restore_down_32px1
        Me.btnRestore.Location = New System.Drawing.Point(1043, -2)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(38, 46)
        Me.btnRestore.TabIndex = 3
        Me.btnRestore.UseVisualStyleBackColor = True
        Me.btnRestore.Visible = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_PanelSubsMenus.SetDecoration(Me.btnMinimizar, BunifuAnimatorNS.DecorationType.None)
        Me.BT2_PanelSubsMenus.SetDecoration(Me.btnMinimizar, BunifuAnimatorNS.DecorationType.None)
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Image = Global.Menu_Tareas_IIP.My.Resources.Resources.negative_32px
        Me.btnMinimizar.Location = New System.Drawing.Point(988, -2)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(40, 49)
        Me.btnMinimizar.TabIndex = 2
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_PanelSubsMenus.SetDecoration(Me.btnMaximizar, BunifuAnimatorNS.DecorationType.None)
        Me.BT2_PanelSubsMenus.SetDecoration(Me.btnMaximizar, BunifuAnimatorNS.DecorationType.None)
        Me.btnMaximizar.FlatAppearance.BorderSize = 0
        Me.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizar.Image = Global.Menu_Tareas_IIP.My.Resources.Resources.maximize_window_32px
        Me.btnMaximizar.Location = New System.Drawing.Point(1043, -2)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(39, 49)
        Me.btnMaximizar.TabIndex = 1
        Me.btnMaximizar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_PanelSubsMenus.SetDecoration(Me.btnCerrar, BunifuAnimatorNS.DecorationType.None)
        Me.BT2_PanelSubsMenus.SetDecoration(Me.btnCerrar, BunifuAnimatorNS.DecorationType.None)
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = Global.Menu_Tareas_IIP.My.Resources.Resources.close_window_32px
        Me.btnCerrar.Location = New System.Drawing.Point(1099, -2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(38, 49)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'PanelForms
        '
        Me.PanelForms.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BT2_PanelSubsMenus.SetDecoration(Me.PanelForms, BunifuAnimatorNS.DecorationType.None)
        Me.BT_PanelSubsMenus.SetDecoration(Me.PanelForms, BunifuAnimatorNS.DecorationType.None)
        Me.PanelForms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelForms.Location = New System.Drawing.Point(0, 50)
        Me.PanelForms.Name = "PanelForms"
        Me.PanelForms.Size = New System.Drawing.Size(1149, 688)
        Me.PanelForms.TabIndex = 2
        '
        'Panel_SubsMenus
        '
        Me.Panel_SubsMenus.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel_SubsMenus.Controls.Add(Me.Panel_Menu_Tareas)
        Me.Panel_SubsMenus.Controls.Add(Me.btnTareas)
        Me.Panel_SubsMenus.Controls.Add(Me.PanelMenuClase)
        Me.Panel_SubsMenus.Controls.Add(Me.btnClase)
        Me.Panel_SubsMenus.Controls.Add(Me.PanelTitulo)
        Me.BT2_PanelSubsMenus.SetDecoration(Me.Panel_SubsMenus, BunifuAnimatorNS.DecorationType.None)
        Me.BT_PanelSubsMenus.SetDecoration(Me.Panel_SubsMenus, BunifuAnimatorNS.DecorationType.None)
        Me.Panel_SubsMenus.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_SubsMenus.Location = New System.Drawing.Point(0, 50)
        Me.Panel_SubsMenus.Name = "Panel_SubsMenus"
        Me.Panel_SubsMenus.Size = New System.Drawing.Size(259, 688)
        Me.Panel_SubsMenus.TabIndex = 3
        '
        'Panel_Menu_Tareas
        '
        Me.Panel_Menu_Tareas.Controls.Add(Me.btnBolsaSolidaria)
        Me.BT2_PanelSubsMenus.SetDecoration(Me.Panel_Menu_Tareas, BunifuAnimatorNS.DecorationType.None)
        Me.BT_PanelSubsMenus.SetDecoration(Me.Panel_Menu_Tareas, BunifuAnimatorNS.DecorationType.None)
        Me.Panel_Menu_Tareas.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Menu_Tareas.Location = New System.Drawing.Point(0, 356)
        Me.Panel_Menu_Tareas.Name = "Panel_Menu_Tareas"
        Me.Panel_Menu_Tareas.Size = New System.Drawing.Size(259, 88)
        Me.Panel_Menu_Tareas.TabIndex = 4
        '
        'btnBolsaSolidaria
        '
        Me.btnBolsaSolidaria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_PanelSubsMenus.SetDecoration(Me.btnBolsaSolidaria, BunifuAnimatorNS.DecorationType.None)
        Me.BT2_PanelSubsMenus.SetDecoration(Me.btnBolsaSolidaria, BunifuAnimatorNS.DecorationType.None)
        Me.btnBolsaSolidaria.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBolsaSolidaria.FlatAppearance.BorderSize = 0
        Me.btnBolsaSolidaria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBolsaSolidaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBolsaSolidaria.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBolsaSolidaria.Location = New System.Drawing.Point(0, 0)
        Me.btnBolsaSolidaria.Name = "btnBolsaSolidaria"
        Me.btnBolsaSolidaria.Size = New System.Drawing.Size(259, 72)
        Me.btnBolsaSolidaria.TabIndex = 3
        Me.btnBolsaSolidaria.Text = "Solidary Bag"
        Me.btnBolsaSolidaria.UseVisualStyleBackColor = True
        '
        'btnTareas
        '
        Me.btnTareas.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnTareas.Cursor = System.Windows.Forms.Cursors.Default
        Me.BT_PanelSubsMenus.SetDecoration(Me.btnTareas, BunifuAnimatorNS.DecorationType.None)
        Me.BT2_PanelSubsMenus.SetDecoration(Me.btnTareas, BunifuAnimatorNS.DecorationType.None)
        Me.btnTareas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTareas.FlatAppearance.BorderSize = 0
        Me.btnTareas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.btnTareas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTareas.Font = New System.Drawing.Font("Segoe Print", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTareas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnTareas.Image = Global.Menu_Tareas_IIP.My.Resources.Resources.homework_48px
        Me.btnTareas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTareas.Location = New System.Drawing.Point(0, 278)
        Me.btnTareas.Name = "btnTareas"
        Me.btnTareas.Size = New System.Drawing.Size(259, 78)
        Me.btnTareas.TabIndex = 3
        Me.btnTareas.Text = "  Tareas"
        Me.btnTareas.UseVisualStyleBackColor = False
        '
        'PanelMenuClase
        '
        Me.PanelMenuClase.Controls.Add(Me.Button1)
        Me.PanelMenuClase.Controls.Add(Me.btnArreglos)
        Me.BT2_PanelSubsMenus.SetDecoration(Me.PanelMenuClase, BunifuAnimatorNS.DecorationType.None)
        Me.BT_PanelSubsMenus.SetDecoration(Me.PanelMenuClase, BunifuAnimatorNS.DecorationType.None)
        Me.PanelMenuClase.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMenuClase.Location = New System.Drawing.Point(0, 158)
        Me.PanelMenuClase.Name = "PanelMenuClase"
        Me.PanelMenuClase.Size = New System.Drawing.Size(259, 120)
        Me.PanelMenuClase.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_PanelSubsMenus.SetDecoration(Me.Button1, BunifuAnimatorNS.DecorationType.None)
        Me.BT2_PanelSubsMenus.SetDecoration(Me.Button1, BunifuAnimatorNS.DecorationType.None)
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(0, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(259, 70)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Libreta Banco"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnArreglos
        '
        Me.btnArreglos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BT_PanelSubsMenus.SetDecoration(Me.btnArreglos, BunifuAnimatorNS.DecorationType.None)
        Me.BT2_PanelSubsMenus.SetDecoration(Me.btnArreglos, BunifuAnimatorNS.DecorationType.None)
        Me.btnArreglos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnArreglos.FlatAppearance.BorderSize = 0
        Me.btnArreglos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnArreglos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArreglos.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArreglos.Location = New System.Drawing.Point(0, 0)
        Me.btnArreglos.Name = "btnArreglos"
        Me.btnArreglos.Size = New System.Drawing.Size(259, 35)
        Me.btnArreglos.TabIndex = 0
        Me.btnArreglos.Text = "Arreglos"
        Me.btnArreglos.UseVisualStyleBackColor = True
        '
        'btnClase
        '
        Me.btnClase.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnClase.Cursor = System.Windows.Forms.Cursors.Default
        Me.BT_PanelSubsMenus.SetDecoration(Me.btnClase, BunifuAnimatorNS.DecorationType.None)
        Me.BT2_PanelSubsMenus.SetDecoration(Me.btnClase, BunifuAnimatorNS.DecorationType.None)
        Me.btnClase.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClase.FlatAppearance.BorderSize = 0
        Me.btnClase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.btnClase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClase.Font = New System.Drawing.Font("Segoe Print", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClase.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClase.Image = Global.Menu_Tareas_IIP.My.Resources.Resources.classroom_48px
        Me.btnClase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClase.Location = New System.Drawing.Point(0, 100)
        Me.btnClase.Name = "btnClase"
        Me.btnClase.Size = New System.Drawing.Size(259, 58)
        Me.btnClase.TabIndex = 1
        Me.btnClase.Text = "      Proyectos Clase"
        Me.btnClase.UseVisualStyleBackColor = False
        '
        'PanelTitulo
        '
        Me.PanelTitulo.Controls.Add(Me.btnMenu)
        Me.PanelTitulo.Controls.Add(Me.titleSeparator)
        Me.PanelTitulo.Controls.Add(Me.Label1)
        Me.BT2_PanelSubsMenus.SetDecoration(Me.PanelTitulo, BunifuAnimatorNS.DecorationType.None)
        Me.BT_PanelSubsMenus.SetDecoration(Me.PanelTitulo, BunifuAnimatorNS.DecorationType.None)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(259, 100)
        Me.PanelTitulo.TabIndex = 0
        '
        'btnMenu
        '
        Me.btnMenu.BackgroundImage = CType(resources.GetObject("btnMenu.BackgroundImage"), System.Drawing.Image)
        Me.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BT_PanelSubsMenus.SetDecoration(Me.btnMenu, BunifuAnimatorNS.DecorationType.None)
        Me.BT2_PanelSubsMenus.SetDecoration(Me.btnMenu, BunifuAnimatorNS.DecorationType.None)
        Me.btnMenu.FlatAppearance.BorderSize = 0
        Me.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.Location = New System.Drawing.Point(18, 0)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(52, 58)
        Me.btnMenu.TabIndex = 3
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'titleSeparator
        '
        Me.titleSeparator.BackColor = System.Drawing.Color.Transparent
        Me.BT2_PanelSubsMenus.SetDecoration(Me.titleSeparator, BunifuAnimatorNS.DecorationType.None)
        Me.BT_PanelSubsMenus.SetDecoration(Me.titleSeparator, BunifuAnimatorNS.DecorationType.None)
        Me.titleSeparator.ForeColor = System.Drawing.SystemColors.Control
        Me.titleSeparator.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.titleSeparator.LineThickness = 2
        Me.titleSeparator.Location = New System.Drawing.Point(12, 62)
        Me.titleSeparator.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.titleSeparator.Name = "titleSeparator"
        Me.titleSeparator.Size = New System.Drawing.Size(237, 10)
        Me.titleSeparator.TabIndex = 2
        Me.titleSeparator.Transparency = 255
        Me.titleSeparator.Vertical = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.BT_PanelSubsMenus.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.BT2_PanelSubsMenus.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(84, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menu Trabajos"
        '
        'BT_PanelSubsMenus
        '
        Me.BT_PanelSubsMenus.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind
        Me.BT_PanelSubsMenus.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.BT_PanelSubsMenus.DefaultAnimation = Animation1
        '
        'BT2_PanelSubsMenus
        '
        Me.BT2_PanelSubsMenus.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.BT2_PanelSubsMenus.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.BT2_PanelSubsMenus.DefaultAnimation = Animation2
        '
        'MoverMenu
        '
        Me.MoverMenu.Fixed = True
        Me.MoverMenu.Horizontal = True
        Me.MoverMenu.TargetControl = Me.PanelSuperior
        Me.MoverMenu.Vertical = True
        '
        'Menu_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1149, 738)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel_SubsMenus)
        Me.Controls.Add(Me.PanelForms)
        Me.Controls.Add(Me.PanelSuperior)
        Me.BT2_PanelSubsMenus.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.BT_PanelSubsMenus.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Menu_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PanelSuperior.ResumeLayout(False)
        Me.Panel_SubsMenus.ResumeLayout(False)
        Me.Panel_Menu_Tareas.ResumeLayout(False)
        Me.PanelMenuClase.ResumeLayout(False)
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents PanelForms As Panel
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnRestore As Button
    Friend WithEvents Panel_SubsMenus As Panel
    Friend WithEvents titleSeparator As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelMenuClase As Panel
    Friend WithEvents btnArreglos As Button
    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents btnMenu As Button
    Friend WithEvents Panel_Menu_Tareas As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents btnClase As Button
    Friend WithEvents btnTareas As Button
    Friend WithEvents BT_PanelSubsMenus As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BT2_PanelSubsMenus As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents MoverMenu As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents btnBolsaSolidaria As Button
End Class
