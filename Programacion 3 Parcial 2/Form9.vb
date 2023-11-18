Public Class Form9

    Private Sub ModelosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ModelosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ModelosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Remis_Access_2000DataSet)

    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Remis_Access_2000DataSet.Modelos' Puede moverla o quitarla según sea necesario.
        Me.ModelosTableAdapter.Fill(Me.Remis_Access_2000DataSet.Modelos)

    End Sub
End Class