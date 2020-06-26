Imports System.Runtime.InteropServices
Public Class Menu_Principal
    Private Sub Menu_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OcultarSubsMenus()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        btnMaximizar.Visible = False
        btnRestore.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        btnRestore.Visible = False
        btnMaximizar.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub OcultarSubsMenus()
        PanelMenuClase.Visible = False
        Panel_Menu_Tareas.Visible = False
    End Sub

    Private Sub MostrarSubsMenus(OpMenu As Panel)

        If OpMenu.Visible = False Then
            OcultarSubsMenus()
            OpMenu.Visible = True
        Else
            OpMenu.Visible = False
        End If
    End Sub

    Private Sub btnClase_Click(sender As Object, e As EventArgs) Handles btnClase.Click
        MostrarSubsMenus(PanelMenuClase)
    End Sub

    Private Sub btnTareas_Click(sender As Object, e As EventArgs) Handles btnTareas.Click
        MostrarSubsMenus(Panel_Menu_Tareas)
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click

        If Panel_SubsMenus.Width = 173 Then
            Panel_SubsMenus.Visible = False
            Panel_SubsMenus.Width = 60
            titleSeparator.Width = 48
            BT_PanelSubsMenus.Show(Panel_SubsMenus)
        Else
            Panel_SubsMenus.Visible = False
            Panel_SubsMenus.Width = 173
            titleSeparator.Width = 158
            BT2_PanelSubsMenus.Show(Panel_SubsMenus)
        End If

    End Sub

    Private Sub OpenForms_Panel(ByVal formHijo As Object)

        If PanelForms.Controls.Count > 0 Then
            Me.PanelForms.Controls.RemoveAt(0)
        End If

        Dim frm As Form = TryCast(formHijo, Form)

        frm.TopLevel = False
        frm.Dock = DockStyle.Fill

        Me.PanelForms.Controls.Add(frm)
        Me.PanelForms.Tag = frm

        frm.Show()

    End Sub

    Private Sub btnArreglos_Click(sender As Object, e As EventArgs) Handles btnArreglos.Click
        OpenForms_Panel(Arreglos)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLibretaBanco.Click
        OpenForms_Panel(libreta_Bancaria)
    End Sub

    Private Sub btnBolsaSolidaria_Click(sender As Object, e As EventArgs) Handles btnBolsaSolidaria.Click
        OpenForms_Panel(Entrega_BolsaSolidaria)
    End Sub

    Private Sub btnArreglos_MouseHover(sender As Object, e As EventArgs) Handles btnArreglos.MouseHover
        ToolTip1.SetToolTip(btnArreglos, "Abrir programa Arreglos")
        ToolTip1.ToolTipTitle = "Arreglos"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnLibretaBanco_MouseHover(sender As Object, e As EventArgs) Handles btnLibretaBanco.MouseHover
        ToolTip1.SetToolTip(btnLibretaBanco, "Abrir programa Libreta Banco")
        ToolTip1.ToolTipTitle = "Libreta Bancaria"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnBolsaSolidaria_MouseHover(sender As Object, e As EventArgs) Handles btnBolsaSolidaria.MouseHover
        ToolTip1.SetToolTip(btnBolsaSolidaria, "Abrir programa Solidary Bag")
        ToolTip1.ToolTipTitle = "Bolsa Solidaria"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnMenu_MouseHover(sender As Object, e As EventArgs) Handles btnMenu.MouseHover
        ToolTip1.SetToolTip(btnMenu, "Ver SubMenus")
        ToolTip1.ToolTipTitle = "Menu Principal"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnClase_MouseHover(sender As Object, e As EventArgs) Handles btnClase.MouseHover
        ToolTip1.SetToolTip(btnClase, "Ver Programas Clases")
        ToolTip1.ToolTipTitle = "Programas en Clase"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnTareas_MouseHover(sender As Object, e As EventArgs) Handles btnTareas.MouseHover
        ToolTip1.SetToolTip(btnTareas, "Ver Programas Tareas")
        ToolTip1.ToolTipTitle = "Programas de Tarea"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnCerrar_MouseHover(sender As Object, e As EventArgs) Handles btnCerrar.MouseHover
        ToolTip1.SetToolTip(btnCerrar, "Cerrar")
    End Sub

    Private Sub btnMaximizar_MouseHover(sender As Object, e As EventArgs) Handles btnMaximizar.MouseHover
        ToolTip1.SetToolTip(btnMaximizar, "Maximizar")
    End Sub

    Private Sub btnRestore_MouseHover(sender As Object, e As EventArgs) Handles btnRestore.MouseHover
        ToolTip1.SetToolTip(btnRestore, "Restaurar")
    End Sub

    Private Sub btnMinimizar_MouseHover(sender As Object, e As EventArgs) Handles btnMinimizar.MouseHover
        ToolTip1.SetToolTip(btnMinimizar, "Minimizar")
    End Sub
End Class