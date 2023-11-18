Public Class Form20

    Private Sub Form20_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Remis_Access_2000DataSet.Colores' Puede moverla o quitarla según sea necesario.
        Me.ColoresTableAdapter.Fill(Me.Remis_Access_2000DataSet.Colores)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class