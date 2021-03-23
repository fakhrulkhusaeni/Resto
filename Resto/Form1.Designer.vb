<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim KodebrgLabel As System.Windows.Forms.Label
        Dim NamabrgLabel As System.Windows.Forms.Label
        Dim JnsbrgLabel As System.Windows.Forms.Label
        Dim JmlbrgLabel As System.Windows.Forms.Label
        Dim HrgbrgLabel As System.Windows.Forms.Label
        Me.TabelbarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RestoDataSet = New Resto.restoDataSet()
        Me.btndel = New System.Windows.Forms.Button()
        Me.simpan = New System.Windows.Forms.Button()
        Me.TabelbarangTableAdapter = New Resto.restoDataSetTableAdapters.tabelbarangTableAdapter()
        Me.TableAdapterManager = New Resto.restoDataSetTableAdapters.TableAdapterManager()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.KodebrgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamabrgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JnsbrgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JmlbrgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HrgbrgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblmakananBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RestoranDataSet = New Resto.restoranDataSet()
        Me.KodebrgTextBox = New System.Windows.Forms.TextBox()
        Me.NamabrgTextBox = New System.Windows.Forms.TextBox()
        Me.JnsbrgComboBox = New System.Windows.Forms.ComboBox()
        Me.JmlbrgTextBox = New System.Windows.Forms.TextBox()
        Me.HrgbrgTextBox = New System.Windows.Forms.TextBox()
        Me.Tambah = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.update = New System.Windows.Forms.Button()
        Me.Tbl_makananTableAdapter = New Resto.restoranDataSetTableAdapters.tbl_makananTableAdapter()
        Me.TableAdapterManager1 = New Resto.restoranDataSetTableAdapters.TableAdapterManager()
        KodebrgLabel = New System.Windows.Forms.Label()
        NamabrgLabel = New System.Windows.Forms.Label()
        JnsbrgLabel = New System.Windows.Forms.Label()
        JmlbrgLabel = New System.Windows.Forms.Label()
        HrgbrgLabel = New System.Windows.Forms.Label()
        CType(Me.TabelbarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblmakananBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestoranDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KodebrgLabel
        '
        KodebrgLabel.AutoSize = True
        KodebrgLabel.Location = New System.Drawing.Point(29, 24)
        KodebrgLabel.Name = "KodebrgLabel"
        KodebrgLabel.Size = New System.Drawing.Size(49, 13)
        KodebrgLabel.TabIndex = 14
        KodebrgLabel.Text = "kodebrg:"
        '
        'NamabrgLabel
        '
        NamabrgLabel.AutoSize = True
        NamabrgLabel.Location = New System.Drawing.Point(27, 50)
        NamabrgLabel.Name = "NamabrgLabel"
        NamabrgLabel.Size = New System.Drawing.Size(51, 13)
        NamabrgLabel.TabIndex = 15
        NamabrgLabel.Text = "namabrg:"
        '
        'JnsbrgLabel
        '
        JnsbrgLabel.AutoSize = True
        JnsbrgLabel.Location = New System.Drawing.Point(40, 76)
        JnsbrgLabel.Name = "JnsbrgLabel"
        JnsbrgLabel.Size = New System.Drawing.Size(38, 13)
        JnsbrgLabel.TabIndex = 16
        JnsbrgLabel.Text = "jnsbrg:"
        '
        'JmlbrgLabel
        '
        JmlbrgLabel.AutoSize = True
        JmlbrgLabel.Location = New System.Drawing.Point(461, 20)
        JmlbrgLabel.Name = "JmlbrgLabel"
        JmlbrgLabel.Size = New System.Drawing.Size(37, 13)
        JmlbrgLabel.TabIndex = 17
        JmlbrgLabel.Text = "jmlbrg:"
        '
        'HrgbrgLabel
        '
        HrgbrgLabel.AutoSize = True
        HrgbrgLabel.Location = New System.Drawing.Point(458, 46)
        HrgbrgLabel.Name = "HrgbrgLabel"
        HrgbrgLabel.Size = New System.Drawing.Size(40, 13)
        HrgbrgLabel.TabIndex = 18
        HrgbrgLabel.Text = "hrgbrg:"
        '
        'TabelbarangBindingSource
        '
        Me.TabelbarangBindingSource.DataMember = "tabelbarang"
        Me.TabelbarangBindingSource.DataSource = Me.RestoDataSet
        '
        'RestoDataSet
        '
        Me.RestoDataSet.DataSetName = "restoDataSet"
        Me.RestoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btndel
        '
        Me.btndel.Location = New System.Drawing.Point(212, 131)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(69, 23)
        Me.btndel.TabIndex = 11
        Me.btndel.Text = "Hapus"
        Me.btndel.UseVisualStyleBackColor = True
        '
        'simpan
        '
        Me.simpan.Location = New System.Drawing.Point(131, 131)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(75, 23)
        Me.simpan.TabIndex = 12
        Me.simpan.Text = "Simpan"
        Me.simpan.UseVisualStyleBackColor = True
        '
        'TabelbarangTableAdapter
        '
        Me.TabelbarangTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.tabelbarangTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Resto.restoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodebrgDataGridViewTextBoxColumn, Me.NamabrgDataGridViewTextBoxColumn, Me.JnsbrgDataGridViewTextBoxColumn, Me.JmlbrgDataGridViewTextBoxColumn, Me.HrgbrgDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblmakananBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(47, 185)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(729, 252)
        Me.DataGridView1.TabIndex = 14
        '
        'KodebrgDataGridViewTextBoxColumn
        '
        Me.KodebrgDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.KodebrgDataGridViewTextBoxColumn.DataPropertyName = "kodebrg"
        Me.KodebrgDataGridViewTextBoxColumn.HeaderText = "KODE BARANG"
        Me.KodebrgDataGridViewTextBoxColumn.Name = "KodebrgDataGridViewTextBoxColumn"
        Me.KodebrgDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamabrgDataGridViewTextBoxColumn
        '
        Me.NamabrgDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NamabrgDataGridViewTextBoxColumn.DataPropertyName = "namabrg"
        Me.NamabrgDataGridViewTextBoxColumn.HeaderText = "NAMA BARANG"
        Me.NamabrgDataGridViewTextBoxColumn.Name = "NamabrgDataGridViewTextBoxColumn"
        Me.NamabrgDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JnsbrgDataGridViewTextBoxColumn
        '
        Me.JnsbrgDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.JnsbrgDataGridViewTextBoxColumn.DataPropertyName = "jnsbrg"
        Me.JnsbrgDataGridViewTextBoxColumn.HeaderText = "JENIS BARANG"
        Me.JnsbrgDataGridViewTextBoxColumn.Name = "JnsbrgDataGridViewTextBoxColumn"
        Me.JnsbrgDataGridViewTextBoxColumn.ReadOnly = True
        '
        'JmlbrgDataGridViewTextBoxColumn
        '
        Me.JmlbrgDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.JmlbrgDataGridViewTextBoxColumn.DataPropertyName = "jmlbrg"
        Me.JmlbrgDataGridViewTextBoxColumn.HeaderText = "JUMLAH BARANG"
        Me.JmlbrgDataGridViewTextBoxColumn.Name = "JmlbrgDataGridViewTextBoxColumn"
        Me.JmlbrgDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HrgbrgDataGridViewTextBoxColumn
        '
        Me.HrgbrgDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.HrgbrgDataGridViewTextBoxColumn.DataPropertyName = "hrgbrg"
        Me.HrgbrgDataGridViewTextBoxColumn.HeaderText = "HARGA BARANG"
        Me.HrgbrgDataGridViewTextBoxColumn.Name = "HrgbrgDataGridViewTextBoxColumn"
        Me.HrgbrgDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblmakananBindingSource
        '
        Me.TblmakananBindingSource.DataMember = "tbl_makanan"
        Me.TblmakananBindingSource.DataSource = Me.RestoranDataSet
        '
        'RestoranDataSet
        '
        Me.RestoranDataSet.DataSetName = "restoranDataSet"
        Me.RestoranDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KodebrgTextBox
        '
        Me.KodebrgTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblmakananBindingSource, "kodebrg", True))
        Me.KodebrgTextBox.Location = New System.Drawing.Point(84, 21)
        Me.KodebrgTextBox.Name = "KodebrgTextBox"
        Me.KodebrgTextBox.Size = New System.Drawing.Size(100, 20)
        Me.KodebrgTextBox.TabIndex = 15
        '
        'NamabrgTextBox
        '
        Me.NamabrgTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblmakananBindingSource, "namabrg", True))
        Me.NamabrgTextBox.Location = New System.Drawing.Point(84, 47)
        Me.NamabrgTextBox.Name = "NamabrgTextBox"
        Me.NamabrgTextBox.Size = New System.Drawing.Size(230, 20)
        Me.NamabrgTextBox.TabIndex = 16
        '
        'JnsbrgComboBox
        '
        Me.JnsbrgComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblmakananBindingSource, "jnsbrg", True))
        Me.JnsbrgComboBox.FormattingEnabled = True
        Me.JnsbrgComboBox.Items.AddRange(New Object() {"Makanan", "Minuman", "Snack"})
        Me.JnsbrgComboBox.Location = New System.Drawing.Point(84, 73)
        Me.JnsbrgComboBox.Name = "JnsbrgComboBox"
        Me.JnsbrgComboBox.Size = New System.Drawing.Size(121, 21)
        Me.JnsbrgComboBox.TabIndex = 17
        '
        'JmlbrgTextBox
        '
        Me.JmlbrgTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblmakananBindingSource, "jmlbrg", True))
        Me.JmlbrgTextBox.Location = New System.Drawing.Point(504, 17)
        Me.JmlbrgTextBox.Name = "JmlbrgTextBox"
        Me.JmlbrgTextBox.Size = New System.Drawing.Size(100, 20)
        Me.JmlbrgTextBox.TabIndex = 18
        '
        'HrgbrgTextBox
        '
        Me.HrgbrgTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblmakananBindingSource, "hrgbrg", True))
        Me.HrgbrgTextBox.Location = New System.Drawing.Point(504, 43)
        Me.HrgbrgTextBox.Name = "HrgbrgTextBox"
        Me.HrgbrgTextBox.Size = New System.Drawing.Size(100, 20)
        Me.HrgbrgTextBox.TabIndex = 19
        '
        'Tambah
        '
        Me.Tambah.Location = New System.Drawing.Point(47, 131)
        Me.Tambah.Name = "Tambah"
        Me.Tambah.Size = New System.Drawing.Size(75, 23)
        Me.Tambah.TabIndex = 20
        Me.Tambah.Text = "Add New"
        Me.Tambah.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.JnsbrgComboBox)
        Me.GroupBox1.Controls.Add(Me.KodebrgTextBox)
        Me.GroupBox1.Controls.Add(HrgbrgLabel)
        Me.GroupBox1.Controls.Add(KodebrgLabel)
        Me.GroupBox1.Controls.Add(Me.HrgbrgTextBox)
        Me.GroupBox1.Controls.Add(Me.NamabrgTextBox)
        Me.GroupBox1.Controls.Add(JmlbrgLabel)
        Me.GroupBox1.Controls.Add(NamabrgLabel)
        Me.GroupBox1.Controls.Add(Me.JmlbrgTextBox)
        Me.GroupBox1.Controls.Add(JnsbrgLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(47, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(729, 108)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Form Input Barang"
        '
        'update
        '
        Me.update.Location = New System.Drawing.Point(287, 132)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(83, 22)
        Me.update.TabIndex = 22
        Me.update.Text = "Update"
        Me.update.UseVisualStyleBackColor = True
        '
        'Tbl_makananTableAdapter
        '
        Me.Tbl_makananTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.tbl_makananTableAdapter = Me.Tbl_makananTableAdapter
        Me.TableAdapterManager1.tbl_userTableAdapter = Nothing
        Me.TableAdapterManager1.transaksiTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = Resto.restoranDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 466)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Tambah)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.btndel)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Barang"
        CType(Me.TabelbarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblmakananBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestoranDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RestoDataSet As restoDataSet
    Friend WithEvents TabelbarangBindingSource As BindingSource
    Friend WithEvents TabelbarangTableAdapter As restoDataSetTableAdapters.tabelbarangTableAdapter
    Friend WithEvents TableAdapterManager As restoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btndel As Button
    Friend WithEvents simpan As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RestoranDataSet As restoranDataSet
    Friend WithEvents TblmakananBindingSource As BindingSource
    Friend WithEvents Tbl_makananTableAdapter As restoranDataSetTableAdapters.tbl_makananTableAdapter
    Friend WithEvents TableAdapterManager1 As restoranDataSetTableAdapters.TableAdapterManager
    Friend WithEvents KodebrgTextBox As TextBox
    Friend WithEvents NamabrgTextBox As TextBox
    Friend WithEvents JnsbrgComboBox As ComboBox
    Friend WithEvents JmlbrgTextBox As TextBox
    Friend WithEvents HrgbrgTextBox As TextBox
    Friend WithEvents Tambah As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents update As Button
    Friend WithEvents KodebrgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamabrgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JnsbrgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JmlbrgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HrgbrgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
