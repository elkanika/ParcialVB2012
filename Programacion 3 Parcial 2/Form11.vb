Public Class Form11

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Remis_Access_2000DataSet.Choferes' Puede moverla o quitarla según sea necesario.
        Me.ChoferesTableAdapter.Fill(Me.Remis_Access_2000DataSet.Choferes)

    End Sub
End Class