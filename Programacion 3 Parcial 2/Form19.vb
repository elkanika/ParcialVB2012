Public Class Form19

    Private Sub Form19_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Remis_Access_2000DataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.Remis_Access_2000DataSet.Clientes)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class