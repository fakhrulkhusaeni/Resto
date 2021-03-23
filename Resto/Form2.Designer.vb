<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Me.TableAdapterManager1 = New Resto.restoDataSetTableAdapters.TableAdapterManager()
        Me.RestoranDataSet = New Resto.restoranDataSet()
        Me.Tbl_userBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_userTableAdapter = New Resto.restoranDataSetTableAdapters.tbl_userTableAdapter()
        Me.TableAdapterManager = New Resto.restoranDataSetTableAdapters.TableAdapterManager()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        CType(Me.RestoranDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_userBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(43, 60)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(56, 13)
        UsernameLabel.TabIndex = 1
        UsernameLabel.Text = "username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(44, 86)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(55, 13)
        PasswordLabel.TabIndex = 2
        PasswordLabel.Text = "password:"
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.tabelbarangTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = Resto.restoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RestoranDataSet
        '
        Me.RestoranDataSet.DataSetName = "restoranDataSet"
        Me.RestoranDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_userBindingSource
        '
        Me.Tbl_userBindingSource.DataMember = "tbl_user"
        Me.Tbl_userBindingSource.DataSource = Me.RestoranDataSet
        '
        'Tbl_userTableAdapter
        '
        Me.Tbl_userTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_makananTableAdapter = Nothing
        Me.TableAdapterManager.tbl_userTableAdapter = Me.Tbl_userTableAdapter
        Me.TableAdapterManager.transaksiTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Resto.restoranDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_userBindingSource, "username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(105, 57)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(131, 20)
        Me.UsernameTextBox.TabIndex = 2
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tbl_userBindingSource, "password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(105, 83)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(131, 20)
        Me.PasswordTextBox.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(105, 109)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 31)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(178, 109)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(58, 31)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 183)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.RestoranDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_userBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableAdapterManager1 As restoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RestoranDataSet As restoranDataSet
    Friend WithEvents Tbl_userBindingSource As BindingSource
    Friend WithEvents Tbl_userTableAdapter As restoranDataSetTableAdapters.tbl_userTableAdapter
    Friend WithEvents TableAdapterManager As restoranDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
