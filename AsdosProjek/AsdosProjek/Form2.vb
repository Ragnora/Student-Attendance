Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbmahasiswaDataSet.mahasiswatbl' table. You can move, or remove it, as needed.
        Me.MahasiswatblTableAdapter.Fill(Me.DbmahasiswaDataSet.mahasiswatbl)

        ttgl.Text = Today
        ttgl.Enabled = False

        cbmk.Items.Add("PBO")
        cbmk.Items.Add("Algoritma")
        cbmk.Items.Add("Basis Data")
        cbmk.Items.Add("Sistem Digital")
        cbmk.Items.Add("Jaringan Komputer")
        cbmk.Items.Add("Matematika Diskrit")
        cbmk.Items.Add("Teori Graf")
        cbmk.Items.Add("Bahasa Indonesia")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MahasiswatblBindingSource.EndEdit()
        MahasiswatblTableAdapter.Update(DbmahasiswaDataSet.mahasiswatbl)
        MsgBox("Data Telah Disimpan!", vbInformation + vbOKOnly, "informasi")
    End Sub
End Class