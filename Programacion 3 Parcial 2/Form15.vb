Public Class Form15

    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Remis_Access_2000DataSet.Modelos' Puede moverla o quitarla según sea necesario.
        Me.ModelosTableAdapter.Fill(Me.Remis_Access_2000DataSet.Modelos)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class