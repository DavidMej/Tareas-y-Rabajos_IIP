Public Class Recibo_Final
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            txtCliente2.Text = Module1.Date_begin
            txtSaldos2.Text = Module1.Date_total
            txtNombre2.Text = Module1.nombre
            txtPais2.Text = Module1.pais
        End If
    End Sub
    Private Sub btnSalir2_Click(sender As Object, e As EventArgs) Handles btnSalir2.Click

        Me.Close()
        Menu_Principal.Show()

    End Sub

    Private Sub Recibo_Final_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class