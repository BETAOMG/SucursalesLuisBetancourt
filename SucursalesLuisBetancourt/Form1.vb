Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'CantidadSucursales Cantidad de sucursales
        'CantidadVentas Cantidad de ventas
        'VentaSucursales Venta por sucursales
        'i Indice de ciclo
        'j Indice de ciclo
        'iMayor Indice de la sucursal con mayores ventas
        'iMenor Indice de la sucursal con menores ventas
        'SumaVentas Suma de las ventas

        Dim CantidadSucursales, CantidadVentas, iMayor, iMenor, SumaVentas As Integer
        CantidadSucursales = TextBox1.Text
        Dim VentaSucursales(CantidadSucursales) As Integer

        iMayor = 1
        iMenor = 1

        TextBox2.Text = Chr(9) + "Ventas por sucursal" + vbCrLf + vbCrLf

        For i = 1 To CantidadSucursales
            CantidadVentas = Val(InputBox("Numero de ventas de la sucursal " + Str(i)))
            For j = 1 To CantidadVentas
                VentaSucursales(i) = VentaSucursales(i) + Val(InputBox("Venta " + Str(j) + " sucursal " + Str(i)))
            Next
            If VentaSucursales(i) < VentaSucursales(iMenor) Then
                iMenor = i
            End If
            If VentaSucursales(i) > VentaSucursales(iMayor) Then
                iMayor = i
            End If
            SumaVentas = SumaVentas + VentaSucursales(i)
            TextBox2.Text = TextBox2.Text + "Sucursal " + Str(i) + ": " + Str(VentaSucursales(i)) + vbCrLf
        Next

        TextBox3.Text = Str(iMayor)
        TextBox4.Text = Str(VentaSucursales(iMayor))
        TextBox5.Text = Str(iMenor)
        TextBox6.Text = Str(VentaSucursales(iMenor))
        TextBox7.Text = Str(SumaVentas)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
