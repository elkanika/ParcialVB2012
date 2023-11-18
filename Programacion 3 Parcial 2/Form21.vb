Public Class Form21

    Private Sub Form21_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Remis_Access_2000DataSet.Marcas' Puede moverla o quitarla según sea necesario.
        Me.MarcasTableAdapter.Fill(Me.Remis_Access_2000DataSet.Marcas)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class