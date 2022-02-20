Public Class Form1


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If (MsgBox("¿Está seguro que quiere salir?", vbCritical + vbYesNo)) = vbYes Then
            End
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        If cbAlgodón.Checked = False And cbLarge.Checked = False And cbLona.Checked = False Then
            MsgBox("No se han selecionado tipo de aeronave")
        End If



    End Sub
End Class
