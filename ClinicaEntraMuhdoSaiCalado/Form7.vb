Public Class Form7
    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Form1.Close()
    End Sub

    Private Sub Btn_Principal_Click(sender As Object, e As EventArgs) Handles Btn_Principal.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Consultas_Click(sender As Object, e As EventArgs) Handles Btn_Consultas.Click
        Form6.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Utentes_Click(sender As Object, e As EventArgs) Handles Btn_Utentes.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Medicos_Click(sender As Object, e As EventArgs) Handles Btn_Medicos.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Especializacoes_Click(sender As Object, e As EventArgs) Handles Btn_Especializacoes.Click
        Form5.Show()
        Me.Close()
        LastForm = 1
    End Sub
End Class