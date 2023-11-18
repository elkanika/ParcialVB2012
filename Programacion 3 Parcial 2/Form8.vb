Public Class Form8

    Private Sub MarcasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MarcasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MarcasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Remis_Access_2000DataSet)

    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Remis_Access_2000DataSet.Marcas' Puede moverla o quitarla según sea necesario.
        Me.MarcasTableAdapter.Fill(Me.Remis_Access_2000DataSet.Marcas)

    End Sub
End Class