Public Class Form7

    Private Sub ColoresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ColoresBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ColoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Remis_Access_2000DataSet)

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Remis_Access_2000DataSet.Colores' Puede moverla o quitarla según sea necesario.
        Me.ColoresTableAdapter.Fill(Me.Remis_Access_2000DataSet.Colores)

    End Sub
End Class