Public Class Entrega_BolsaSolidaria
    Private Datos(9, 6), id, nombre, direccion, IntgFam, tipoBolsa As String

    Private beneficiado, cont As Integer

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        beneficiado = 0
        Dim descrip1 As String
        Dim descrip2 As String

        descrip1 = "3lbs_arroz,3lbs_maseca,3lbs_frijoles"
        descrip2 = "5lbs_arroz,5lbs_maseca,5lbs_frijoles"

        id = InputBox("Ingrese la identidad:", "Registro beneficiado")
        nombre = InputBox("Ingrese el nombre completo:", "Registro beneficiado")
        direccion = InputBox("Ingrese la direccion de residencia:", "Registro beneficiado")
        IntgFam = InputBox("Ingrese el No. de integrantes en la familia:", "Registro beneficiado")
        tipoBolsa = Datos(cont, 5)

        If id.Length <> 13 Then
            MessageBox.Show("La Idenidad no es Correcta", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf BuscarId(id) = 1 Then
            Datos(cont, 0) = id
            Datos(cont, 1) = nombre
            Datos(cont, 2) = IntgFam
            Datos(cont, 3) = direccion


            If chkPobreza.Checked = True Then
                Datos(cont, 4) = "Pobreza"
            Else
                Datos(cont, 4) = "Pobreza Externa"
            End If

            If Val(Datos(cont, 2)) >= 0 And Val(Datos(cont, 2)) <= 3 Then

                chkBasica.Checked = True
                Datos(cont, 5) = "Bolsa Basica"
                txtDescripcion.Text = "3lbs_arroz,3lbs_maseca,3lbs_frijoles"
            Else
                chkRegular.Checked = True
                Datos(cont, 5) = "Bolsa Regular"
                txtDescripcion.Text = "5lbs_arroz,5lbs_maseca,5lbs_frijoles"
            End If

            Do While id <> Datos(cont, 0)
                cont += 1
            Loop

        Else
            MessageBox.Show("A este usuario ya se le ha entregado la bolsa", "Error de Entrega", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Clear()
        End If

    End Sub

    Private Function BuscarId(beneficiario)
        Dim op As Integer

        For i = 0 To 9 Step 1
            If op <> Datos(cont, 0) = 0 Then
                op = 1
            Else
                op = 0
            End If
        Next

        If op = 1 Then
            Return 1
        Else
            Return 0
        End If

    End Function
    Private Sub Clear()
        chkBasica.Checked = False
        chkRegular.Checked = False
        chkPobreza.Checked = False
        chkPobrezaExtrema.Checked = False
        txtDescripcion.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Clear()
    End Sub
    Private Sub btnEntregar_Click(sender As Object, e As EventArgs) Handles btnEntregar.Click
        dgvReporte.Rows.Add(id, nombre, direccion, IntgFam, tipoBolsa)
    End Sub
End Class