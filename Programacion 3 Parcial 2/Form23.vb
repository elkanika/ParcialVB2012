Public Class Form23

    Private Sub Form23_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Remis_Access_2000DataSet.Viajes' Puede moverla o quitarla según sea necesario.
        Me.ViajesTableAdapter.Fill(Me.Remis_Access_2000DataSet.Viajes)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class