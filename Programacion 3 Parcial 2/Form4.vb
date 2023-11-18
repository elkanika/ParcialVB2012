Public Class Form4

    Private Sub ChoferesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ChoferesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Remis_Access_2000DataSet1)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Remis_Access_2000DataSet1.Viajes' Puede moverla o quitarla según sea necesario.
        Me.ViajesTableAdapter.Fill(Me.Remis_Access_2000DataSet1.Viajes)
        'TODO: esta línea de código carga datos en la tabla 'Remis_Access_2000DataSet1.Colores' Puede moverla o quitarla según sea necesario.
        Me.ColoresTableAdapter.Fill(Me.Remis_Access_2000DataSet1.Colores)
        'TODO: esta línea de código carga datos en la tabla 'Remis_Access_2000DataSet1.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.Remis_Access_2000DataSet1.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'Remis_Access_2000DataSet1.Choferes' Puede moverla o quitarla según sea necesario.
        Me.ChoferesTableAdapter.Fill(Me.Remis_Access_2000DataSet1.Choferes)

    End Sub

    Private Sub ChoferesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form5.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form6.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form7.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form8.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form9.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form10.Show()
    End Sub
End Class