Public Class Form10

    Private Sub ViajesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ViajesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ViajesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Remis_Access_2000DataSet)

    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Remis_Access_2000DataSet.Viajes' Puede moverla o quitarla según sea necesario.
        Me.ViajesTableAdapter.Fill(Me.Remis_Access_2000DataSet.Viajes)

    End Sub
End Class