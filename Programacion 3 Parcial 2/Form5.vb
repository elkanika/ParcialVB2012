Public Class Form5

    Private Sub ChoferesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ChoferesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ChoferesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Remis_Access_2000DataSet)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Remis_Access_2000DataSet.Choferes' Puede moverla o quitarla según sea necesario.
        Me.ChoferesTableAdapter.Fill(Me.Remis_Access_2000DataSet.Choferes)

    End Sub
End Class