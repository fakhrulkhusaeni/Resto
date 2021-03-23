Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RestoranDataSet.tbl_makanan' table. You can move, or remove it, as needed.
        Me.Tbl_makananTableAdapter.Fill(Me.RestoranDataSet.tbl_makanan)

        tampil()

    End Sub

    Private Sub simpan_Click_1(sender As Object, e As EventArgs) Handles simpan.Click
        Dim check As Integer
        If KodebrgTextBox.Text = "" Or NamabrgTextBox.Text = "" Or JmlbrgTextBox.Text = "" Or
            JmlbrgTextBox.Text = "" Or HrgbrgTextBox.Text = "" Then
            MsgBox("Data Belum Lengkap", MsgBoxStyle.OkOnly)
        Else

            Try
                bukakoneksi()
                sql = "SELECT * FROM tbl_makanan WHERE kodebrg='" & Trim(KodebrgTextBox.Text) & "'"
                Dim dabrg As New SqlDataAdapter(sql, conn)
                Dim dsbrg As New DataSet
                dabrg.Fill(dsbrg, "tbl_makanan")
                Dim dtbrg = dsbrg.Tables("tbl_makanan")

                If (dtbrg.Rows.Count > 0) Then
                    MsgBox("Data dengan Id " & Trim(KodebrgTextBox.Text) & " Sudah ada di database", MsgBoxStyle.OkOnly, "Pesan :")
                Else

                    sql = "INSERT INTO tbl_makanan (kodebrg,namabrg,jnsbrg,jmlbrg,hrgbrg) VALUES 
                         ('" & KodebrgTextBox.Text & "'," &
                              "'" & NamabrgTextBox.Text & "'," &
                              "'" & JnsbrgComboBox.Text & "'," &
                              "'" & JmlbrgTextBox.Text & "'," &
                              "'" & HrgbrgTextBox.Text & "')"

                    comSQL = New SqlCommand(sql, conn)
                    check = comSQL.ExecuteReader.RecordsAffected()
                    If check > 0 Then
                        MsgBox("Data Barang Kode: " & Trim(KodebrgTextBox.Text) & " Berhasil di Tamahkan", MsgBoxStyle.OkOnly, "Message :")

                    Else
                        MsgBox("Data Barang kode  " & Trim(KodebrgTextBox.Text) & "Gagal Dsimpan", MsgBoxStyle.OkOnly, "Message :")
                    End If

                    tutupkoneksi()
                    End If
                tampil()
            Catch ex As Exception
                    MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OKOnly, "Connection Error !!")
                End Try
            End If


    End Sub
    Private Sub tampil()
        bukakoneksi()
        sql = "SELECT *  From tbl_makanan"
        Dim da As New SqlDataAdapter(sql, conn)
        Dim ds As New DataSet
        da.Fill(ds)
        Dim dt As New DataTable
        For Each dt In ds.Tables
            DataGridView1.DataSource = dt

        Next
        tutupkoneksi()
    End Sub


    Private Sub btndel_Click_1(ByVal sender As System.Object,
    ByVal e As System.EventArgs) Handles btndel.Click

        bukakoneksi()
        sql = "SELECT * FROM tbl_makanan WHERE kodebrg='" & Trim(KodebrgTextBox.Text) & " ' "
        Dim dabrg As New SqlDataAdapter(sql, conn)
        Dim dsbrg As New DataSet
        dabrg.Fill(dsbrg, "tbl_makanan")
        Dim dtbrg = dsbrg.Tables("tbl_makanan")


        If MsgBox("Yakin Delet Data : " & KodebrgTextBox.Text & " ?", MsgBoxStyle.OkCancel, "Edit confirm") = MsgBoxResult.Cancel Then
        Else
            If DataGridView1.CurrentRow.Index <> DataGridView1.NewRowIndex Then
                DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)

                'bukakoneksi()
                sql = "DELETE FROM tbl_makanan WHERE kodebrg='" & KodebrgTextBox.Text & "'"

                comSQL = New SqlCommand(sql, conn)

                Try
                    comSQL.ExecuteNonQuery()
                    MsgBox("hapus berhasil")

                Catch ex As Exception
                    MsgBox("hapus gagal: " & ex.ToString)

                End Try
                tutupkoneksi()
                clear_form()
            End If
        End If
    End Sub
    Private Sub clear_form()
        KodebrgTextBox.Text = ""
        NamabrgTextBox.Text = ""
        JnsbrgComboBox.Text = ""
        JmlbrgTextBox.Text = ""
        HrgbrgTextBox.Text = ""
        KodebrgTextBox.ReadOnly = False
        KodebrgTextBox.Focus()
    End Sub
    Private Sub tampilkan_Click(sender As Object, e As EventArgs)
        'tampil()
    End Sub

    Private Sub Tambah_Click(sender As Object, e As EventArgs) Handles Tambah.Click
        clear_form()
    End Sub

    Private Sub KodebrgTextBox_TextChanged(sender As Object, e As EventArgs) Handles KodebrgTextBox.TextChanged
        If Not IsNumeric(KodebrgTextBox.Text) Then
            KodebrgTextBox.Text = 0
            KodebrgTextBox.SelectionStart = 0
            KodebrgTextBox.SelectionLength = KodebrgTextBox.TextLength
            'KodebrgTextBox.Text = KodebrgTextBox.ReadOnly
        End If
    End Sub

    Private Sub JmlbrgTextBox_TextChanged(sender As Object, e As EventArgs) Handles JmlbrgTextBox.TextChanged
        If Not IsNumeric(JmlbrgTextBox.Text) Then
            JmlbrgTextBox.Text = 0
            JmlbrgTextBox.SelectionStart = 0
            JmlbrgTextBox.SelectionLength = JmlbrgTextBox.TextLength
        End If
    End Sub

    Private Sub HrgbrgTextBox_TextChanged(sender As Object, e As EventArgs) Handles HrgbrgTextBox.TextChanged
        If Not IsNumeric(HrgbrgTextBox.Text) Then
            HrgbrgTextBox.Text = 0
            HrgbrgTextBox.SelectionStart = 0
            HrgbrgTextBox.SelectionLength = HrgbrgTextBox.TextLength
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        With DataGridView1
            KodebrgTextBox.Text = .Item(0, .CurrentRow.Index).Value
            NamabrgTextBox.Text = .Item(1, .CurrentRow.Index).Value
            JnsbrgComboBox.Text = .Item(2, .CurrentRow.Index).Value
            JmlbrgTextBox.Text = .Item(3, .CurrentRow.Index).Value
            HrgbrgTextBox.Text = .Item(4, .CurrentRow.Index).Value
        End With
        KodebrgTextBox.ReadOnly = True
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        Dim check As Integer
        If KodebrgTextBox.Text = "" Or NamabrgTextBox.Text = "" Or JmlbrgTextBox.Text = "" Or
            JmlbrgTextBox.Text = "" Or HrgbrgTextBox.Text = "" Then
            MsgBox("Data Belum Lengkap", MsgBoxStyle.OkOnly)
        Else

            Try
                bukakoneksi()
                sql = "SELECT * FROM tbl_makanan WHERE kodebrg='" & Trim(KodebrgTextBox.Text) & " ' "
                Dim dabrg As New SqlDataAdapter(sql, conn)
                Dim dsbrg As New DataSet
                dabrg.Fill(dsbrg, "tbl_makanan")
                Dim dtbrg = dsbrg.Tables("tbl_makanan")


                If MsgBox("Yakin Update Data : " & KodebrgTextBox.Text & " ?", MsgBoxStyle.OkCancel, "Edit confirm") = MsgBoxResult.Cancel Then
                Else
                    sql = "UPDATE tbl_makanan SET namabrg ='" & Trim(NamabrgTextBox.Text) & "', jnsbrg= '" & Trim(JnsbrgComboBox.Text) & "' , jmlbrg='" & Trim(JmlbrgTextBox.Text) & "', hrgbrg='" & Trim(HrgbrgTextBox.Text) & "' WHERE kodebrg ='" & Trim(KodebrgTextBox.Text) & "'"
                    comSQL = New SqlCommand(sql, conn)
                    check = comSQL.ExecuteReader.RecordsAffected()
                    If check > 0 Then
                        MsgBox("Data Barang Kode: " & Trim(KodebrgTextBox.Text) & " Berhasil di Update", MsgBoxStyle.OkOnly, "Message :")
                    Else
                        MsgBox("Data Barang Kode:" & Trim(KodebrgTextBox.Text) & "Gagal Update", MsgBoxStyle.OkOnly, "Message :")
                    End If
                    tutupkoneksi()
                End If

            Catch ex As Exception
                MsgBox("Error: " & ex.Source & ": " & ex.Message, MsgBoxStyle.OkOnly, "Connection Error !!")
            End Try
        End If
        tampil()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
