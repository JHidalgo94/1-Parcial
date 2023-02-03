Public Class Form1
    Private Sub CalcularButton1_Click(sender As Object, e As EventArgs) Handles CalcularButton1.Click
        Dim numero As Decimal = Convert.ToDecimal(CalcularTextBox1.Text)

        If numero Mod 2 = 0 Then
            MsgBox("El numero es par")
        ElseIf numero Mod 2 <> 0 Then
            MsgBox("El numero es Impar")
        End If

        If numero > 0 Then
            MsgBox("El numero es positivo")
        ElseIf numero < 0 Then
            MsgBox("El numero es negativo")
        End If
    End Sub
End Class
