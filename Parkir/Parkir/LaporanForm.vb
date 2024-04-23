Public Class LaporanForm
    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Dim FormUtama As New FormUtama()
        FormUtama.Show()

        Me.Close()
    End Sub
End Class