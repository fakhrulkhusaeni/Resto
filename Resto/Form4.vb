Public Class Form4
    Private Sub Tbl_makananBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Tbl_makananBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tbl_makananBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RestoranDataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RestoranDataSet.tbl_makanan' table. You can move, or remove it, as needed.
        Me.Tbl_makananTableAdapter.Fill(Me.RestoranDataSet.tbl_makanan)

    End Sub
End Class