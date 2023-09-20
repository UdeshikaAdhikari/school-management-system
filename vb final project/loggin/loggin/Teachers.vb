Imports System.Data.SqlClient

Public Class Teachers
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
        Dim query = "select * from TeacherTbl"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        TeacherDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub Clear()
        TnameTb.Text = ""
        AdTb.Text = ""
        PhoneTb.Text = ""
        GenCb.SelectedIndex = 0
        DepCb.SelectedIndex = 0

    End Sub


    Private Sub Teachers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
        FillDepartment()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.Exit()
    End Sub

    Dim key = 0
    Private Sub TeacherDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles TeacherDGV.CellMouseClick
        Dim row As DataGridViewRow = TeacherDGV.Rows(e.RowIndex)
        TnameTb.Text = row.Cells(1).Value.ToString
        AdTb.Text = row.Cells(2).Value.ToString
        GenCb.SelectedItem = row.Cells(3).Value.ToString
        TDOB.Text = row.Cells(4).Value.ToString
        PhoneTb.Text = row.Cells(5).Value.ToString

        DepCb.SelectedValue = row.Cells(7).Value.ToString


        If TnameTb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub



    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Dim Obj = New logging()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim Obj = New frmstudent()
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


        Strsql = "insert into TeacherTbl values(@Tname,@Addres,@Tgender,@TPhone,@TScheme,@DOB)"
        Dim cmd1 As New SqlCommand(Strsql, Con)

        cmd1.Parameters.AddWithValue("@Tname", TnameTb.Text)
        cmd1.Parameters.AddWithValue("@Addres", AdTb.Text)
        cmd1.Parameters.AddWithValue("@Tgender", GenCb.SelectedItem)
        cmd1.Parameters.AddWithValue("@TPhone", PhoneTb.Text)
        cmd1.Parameters.AddWithValue("@TScheme", DepCb.SelectedValue)
        cmd1.Parameters.AddWithValue("@DOB", TDOB.Value.Date)

        Con.Open()
        cmd1.ExecuteNonQuery()
        Con.Close()
        Display()
        MessageBox.Show("One Row is inserted", "Insert Record")
        Clear()
    End Sub

    Private Sub btnEdit_Click_1(sender As Object, e As EventArgs) Handles btnEdit.Click
        If TnameTb.Text = "" Or AdTb.Text = "" Or PhoneTb.Text = "" Or TDOB.Text = "" Or GenCb.SelectedIndex = -1 Or DepCb.SelectedIndex = -1 Then
            MsgBox("Missing Informations")
        Else
            Try
                Con.Open()
                Dim query = "update TeacherTbl set TName='" & TnameTb.Text & "', TAddress='" & AdTb.Text & "',TGender ='" & GenCb.SelectedItem.ToString & "', TDOB='" & TDOB.Text & "', TPhone='" & PhoneTb.Text & "', TScheme = '" & DepCb.SelectedValue.ToString & "' where TId = " & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox(" Updated")
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

    Private Sub btnDelete_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click
        If key = 0 Then
            MsgBox("Select the Teacher")
        Else
            Try
                Con.Open()
                Dim query = "Delete from TeacherTbl where TId = " & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Teacher Deleted")
                Con.Close()
                Display()
                Clear()

            Catch ex As Exception
                MsgBox("ex.Messages")


            End Try
        End If
    End Sub
End Class