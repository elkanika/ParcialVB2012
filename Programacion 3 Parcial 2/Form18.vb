Public Class Form18

    Private Sub Form18_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Remis_Access_2000DataSet.Choferes' Puede moverla o quitarla según sea necesario.
        Me.ChoferesTableAdapter.Fill(Me.Remis_Access_2000DataSet.Choferes)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class