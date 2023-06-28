<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tnama = New System.Windows.Forms.TextBox()
        Me.tnim = New System.Windows.Forms.TextBox()
        Me.cbmk = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NAMAMAHASISWADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NIMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MATAKULIAHDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TANGGALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MahasiswatblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbmahasiswaDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbmahasiswaDataSet = New AsdosProjek.dbmahasiswaDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MahasiswatblTableAdapter = New AsdosProjek.dbmahasiswaDataSetTableAdapters.mahasiswatblTableAdapter()
        Me.ttgl = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MahasiswatblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbmahasiswaDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbmahasiswaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(213, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(378, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DATA MAHASISWA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(196, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NAMA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(196, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NIM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(196, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "MATAKULIAH"
        '
        'tnama
        '
        Me.tnama.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswatblBindingSource, "NAMA MAHASISWA", True))
        Me.tnama.Location = New System.Drawing.Point(376, 111)
        Me.tnama.Name = "tnama"
        Me.tnama.Size = New System.Drawing.Size(245, 22)
        Me.tnama.TabIndex = 4
        '
        'tnim
        '
        Me.tnim.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswatblBindingSource, "NIM", True))
        Me.tnim.Location = New System.Drawing.Point(376, 154)
        Me.tnim.Name = "tnim"
        Me.tnim.Size = New System.Drawing.Size(245, 22)
        Me.tnim.TabIndex = 5
        '
        'cbmk
        '
        Me.cbmk.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswatblBindingSource, "MATAKULIAH", True))
        Me.cbmk.FormattingEnabled = True
        Me.cbmk.Location = New System.Drawing.Point(376, 199)
        Me.cbmk.Name = "cbmk"
        Me.cbmk.Size = New System.Drawing.Size(245, 24)
        Me.cbmk.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NAMAMAHASISWADataGridViewTextBoxColumn, Me.NIMDataGridViewTextBoxColumn, Me.MATAKULIAHDataGridViewTextBoxColumn, Me.TANGGALDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MahasiswatblBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(90, 320)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(605, 182)
        Me.DataGridView1.TabIndex = 7
        '
        'NAMAMAHASISWADataGridViewTextBoxColumn
        '
        Me.NAMAMAHASISWADataGridViewTextBoxColumn.DataPropertyName = "NAMA MAHASISWA"
        Me.NAMAMAHASISWADataGridViewTextBoxColumn.HeaderText = "NAMA MAHASISWA"
        Me.NAMAMAHASISWADataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NAMAMAHASISWADataGridViewTextBoxColumn.Name = "NAMAMAHASISWADataGridViewTextBoxColumn"
        Me.NAMAMAHASISWADataGridViewTextBoxColumn.Width = 125
        '
        'NIMDataGridViewTextBoxColumn
        '
        Me.NIMDataGridViewTextBoxColumn.DataPropertyName = "NIM"
        Me.NIMDataGridViewTextBoxColumn.HeaderText = "NIM"
        Me.NIMDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NIMDataGridViewTextBoxColumn.Name = "NIMDataGridViewTextBoxColumn"
        Me.NIMDataGridViewTextBoxColumn.Width = 125
        '
        'MATAKULIAHDataGridViewTextBoxColumn
        '
        Me.MATAKULIAHDataGridViewTextBoxColumn.DataPropertyName = "MATAKULIAH"
        Me.MATAKULIAHDataGridViewTextBoxColumn.HeaderText = "MATAKULIAH"
        Me.MATAKULIAHDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MATAKULIAHDataGridViewTextBoxColumn.Name = "MATAKULIAHDataGridViewTextBoxColumn"
        Me.MATAKULIAHDataGridViewTextBoxColumn.Width = 125
        '
        'TANGGALDataGridViewTextBoxColumn
        '
        Me.TANGGALDataGridViewTextBoxColumn.DataPropertyName = "TANGGAL"
        Me.TANGGALDataGridViewTextBoxColumn.HeaderText = "TANGGAL"
        Me.TANGGALDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TANGGALDataGridViewTextBoxColumn.Name = "TANGGALDataGridViewTextBoxColumn"
        Me.TANGGALDataGridViewTextBoxColumn.Width = 125
        '
        'MahasiswatblBindingSource
        '
        Me.MahasiswatblBindingSource.DataMember = "mahasiswatbl"
        Me.MahasiswatblBindingSource.DataSource = Me.DbmahasiswaDataSetBindingSource
        '
        'DbmahasiswaDataSetBindingSource
        '
        Me.DbmahasiswaDataSetBindingSource.DataSource = Me.DbmahasiswaDataSet
        Me.DbmahasiswaDataSetBindingSource.Position = 0
        '
        'DbmahasiswaDataSet
        '
        Me.DbmahasiswaDataSet.DataSetName = "dbmahasiswaDataSet"
        Me.DbmahasiswaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(527, 241)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 30)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "SIMPAN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MahasiswatblTableAdapter
        '
        Me.MahasiswatblTableAdapter.ClearBeforeFill = True
        '
        'ttgl
        '
        Me.ttgl.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswatblBindingSource, "TANGGAL", True))
        Me.ttgl.Location = New System.Drawing.Point(90, 292)
        Me.ttgl.Name = "ttgl"
        Me.ttgl.Size = New System.Drawing.Size(240, 22)
        Me.ttgl.TabIndex = 9
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(790, 529)
        Me.Controls.Add(Me.ttgl)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cbmk)
        Me.Controls.Add(Me.tnim)
        Me.Controls.Add(Me.tnama)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MahasiswatblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbmahasiswaDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbmahasiswaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tnama As TextBox
    Friend WithEvents tnim As TextBox
    Friend WithEvents cbmk As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents DbmahasiswaDataSetBindingSource As BindingSource
    Friend WithEvents DbmahasiswaDataSet As dbmahasiswaDataSet
    Friend WithEvents MahasiswatblBindingSource As BindingSource
    Friend WithEvents MahasiswatblTableAdapter As dbmahasiswaDataSetTableAdapters.mahasiswatblTableAdapter
    Friend WithEvents NAMAMAHASISWADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NIMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MATAKULIAHDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TANGGALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ttgl As TextBox
End Class
