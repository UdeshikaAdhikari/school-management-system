Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Image

Public Class frmstudent
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\CollegeVBOb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub FillDepartment()
        Con.Open()
        Dim query = "Select * from Department1Tbl"
        Dim cmd As New SqlCommand(query, Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        DepCb.DataSource = Tbl
        DepCb.DisplayMember = "DepName"
        DepCb.ValueMember = "DepName"
        Con.Close()
    End Sub
    Private Sub Display()
        Con.Open()
        Dim query = "select * from StudentTable"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        dgvStudent.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub NoDueList()
        Con.Open()
        Dim query = "select * from StudentTable where StFees <= 100000 "
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        dgvStudent.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub Clear()
        StnameTb.Text = ""
        StaddressTb.Text = ""
        phoneTb.Text = ""
        FeesTb.Text = ""
        GenCb.SelectedIndex = 0
        DepCb.SelectedIndex = 0
    End Sub



    Private Sub frmstudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillDepartment()
        Display()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.Exit()
    End Sub


    Dim key = 0
    Private Sub dgvStudent_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvStudent.CellMouseClick
        Dim row As DataGridViewRow = dgvStudent.Rows(e.RowIndex)
        StnameTb.Text = row.Cells(1).Value.ToString
        StaddressTb.Text = row.Cells(2).Value.ToString
        GenCb.SelectedItem = row.Cells(3).Value.ToString
        STDOB.Text = row.Cells(4).Value.ToString
        phoneTb.Text = row.Cells(5).Value.ToString
        FeesTb.Text = row.Cells(6).Value.ToString
        DepCb.SelectedValue = row.Cells(7).Value.ToString


        If StnameTb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        NoDueList()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Display()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openfiledialog1 As New OpenFileDialog
        openfiledialog1.Filter = "images|*.jpg;*.png;*.gif;*.bmp"

        If openfiledialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PicStpicture.Image = Image.FromFile(openfiledialog1.FileName)
        End If
    End Sub

    Private Sub btnEdit_Click_1(sender As Object, e As EventArgs) Handles btnEdit.Click
        If StnameTb.Text = "" Or StaddressTb.Text = "" Or phoneTb.Text = "" Or FeesTb.Text = "" Or STDOB.Text = "" Or GenCb.SelectedIndex = -1 Or DepCb.SelectedIndex = -1 Then
            MsgBox("Missing Informations")
        Else
            Try
                Con.Open()
                Dim query = "update StudentTable set StName='" & StnameTb.Text & "', StAddress='" & StaddressTb.Text & "',StGender ='" & GenCb.SelectedItem.ToString & "', StDOB='" & STDOB.Text & "', StPhone='" & phoneTb.Text & "', StFees  ='" & FeesTb.Text & "',StDepartment = '" & DepCb.SelectedValue.ToString & "' where StId = " & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Student Updated")
                Con.Close()
                Display()
                Clear()

            Catch ex As Exception
                MsgBox("ex.Messages")
            End Try
        End If

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Dim Obj = New logging()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub lblTeachers_Click(sender As Object, e As EventArgs) Handles lblTeachers.Click
        Dim Obj = New Teachers()
        Obj.Show()
        Me.Hide()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim Obj = New Department()
        Obj.Show()
        Me.Hide()

    End Sub

    Private Sub lblCfees_Click(sender As Object, e As EventArgs) Handles lblCfees.Click
        Dim Obj = New Fees()
        Obj.Show()
        Me.Hide()

    End Sub

    Private Sub lblDashBoard_Click(sender As Object, e As EventArgs) Handles lblDashBoard.Click
        Dim Obj = New Dashboard()
        Obj.Show()
        Me.Hide()

    End Sub

    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim Strsql As String
        Strsql = "insert into StudentTable values(@StName,@StAddress,@StGender,@StDOB, @StPhone,@StFees,@StDepartment)"
        Dim cmd1 As New SqlCommand(Strsql, Con)

        cmd1.Parameters.AddWithValue("@StName", StnameTb.Text)
        cmd1.Parameters.AddWithValue("@StAddress", StaddressTb.Text)
        cmd1.Parameters.AddWithValue("@StGender", GenCb.SelectedItem)
        cmd1.Parameters.AddWithValue("@StDOB", STDOB.Value.Date)
        cmd1.Parameters.AddWithValue("@StPhone", phoneTb.Text)
        cmd1.Parameters.AddWithValue("@StFees", FeesTb.Text)
        cmd1.Parameters.AddWithValue("@StDepartment", DepCb.SelectedValue)


        Con.Open()
        cmd1.ExecuteNonQuery()
        Con.Close()
        Display()
        MessageBox.Show("One Row is inserted", "Insert Record")

    End Sub

    Private Sub btnDelete_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click
        If key = 0 Then
            MsgBox("Select the Student")
        Else
            Try
                Con.Open()
                Dim query = "Delete from StudentTable where StId = " & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Student Deleted")
                Con.Close()
                Display()
                Clear()

            Catch ex As Exception
                MsgBox("ex.Messages")


            End Try
        End If
    End Sub

    Private Sub btnReset_Click_1(sender As Object, e As EventArgs) Handles btnReset.Click
        Clear()
    End Sub
End Class