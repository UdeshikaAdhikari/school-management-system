Imports System.Data.SqlClient
Public Class Department
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\CollegeVBOb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Display()
        Con1.Open()
        Dim query = "select * from Department1Tbl"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con1)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        dgvDepartment.DataSource = ds.Tables(0)
        Con1.Close()
    End Sub


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.Exit()
    End Sub

    Private Sub Department_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
    End Sub

    Private Sub Reset()
        DepNameTb.Text = ""
        DurationTb.Text = ""
        DescTb.Text = ""

    End Sub

    Dim key = 0

    Public Property Con1 As Object
        Get
            Return Con
        End Get
        Set(value As Object)
            Con = value
        End Set
    End Property

    Private Sub dgvDepartment_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDepartment.CellMouseClick
        Dim row As DataGridViewRow = dgvDepartment.Rows(e.RowIndex)
        DepNameTb.Text = row.Cells(1).Value.ToString
        DescTb.Text = row.Cells(2).Value.ToString
        DurationTb.Text = row.Cells(3).Value.ToString
        If DepNameTb.Text = "" Then
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

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Dstudentslbl.Click
        Dim Obj = New frmstudent()
        Obj.Show()
        Me.Hide()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles DTeacherlbl.Click
        Dim Obj = New Teachers()
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

    Private Sub btnSchSave_Click_1(sender As Object, e As EventArgs) Handles btnSchSave.Click
        If DepNameTb.Text = "" Or DescTb.Text = "" Or DurationTb.Text = "" Then
            MsgBox("Missing Informations")
        Else
            Try
                Con1.Open()
                Dim query = "insert into Department1Tbl values('" & DepNameTb.Text & "','" & DescTb.Text & "'," & DurationTb.Text & ")"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con1)
                cmd.ExecuteNonQuery()
                MsgBox("Department Saved")
                Con1.Close()
                Display()
                'Reset()

            Catch ex As Exception
                MsgBox("ex.Messages")


            End Try
        End If
    End Sub

    Private Sub btnSchEdit_Click_1(sender As Object, e As EventArgs) Handles btnSchEdit.Click
        If DepNameTb.Text = "" Or DescTb.Text = "" Or DurationTb.Text = "" Then
            MsgBox("Missing Informations")
        Else
            Try
                Con1.Open()
                Dim query = "update Department1Tbl set DepName='" & DepNameTb.Text & "', DepDscription='" & DescTb.Text & "', DepDuration =" & DurationTb.Text & " where DepId = " & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con1)
                cmd.ExecuteNonQuery()
                MsgBox("Department Updated")
                Con1.Close()
                Display()
                Reset()

            Catch ex As Exception
                MsgBox("ex.Messages")
            End Try
        End If
    End Sub

    Private Sub btnSchReset_Click_1(sender As Object, e As EventArgs) Handles btnSchReset.Click
        Reset()
    End Sub

    Private Sub btnSchDelete_Click_1(sender As Object, e As EventArgs) Handles btnSchDelete.Click
        If key = 0 Then
            MsgBox("Select the Department")
        Else
            Try
                Con1.Open()
                Dim query = "Delete from Department1Tbl where DepId = " & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con1)
                cmd.ExecuteNonQuery()
                MsgBox("Department Deleted")
                Con1.Close()
                Display()
                Reset()

            Catch ex As Exception
                MsgBox("ex.Messages")


            End Try
        End If
    End Sub
End Class