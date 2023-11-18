Public Class Form22

    Private Sub Form22_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Remis_Access_2000DataSet.Modelos' Puede moverla o quitarla según sea necesario.
        Me.ModelosTableAdapter.Fill(Me.Remis_Access_2000DataSet.Modelos)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class