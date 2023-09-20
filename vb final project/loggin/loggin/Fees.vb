Imports System.Data.SqlClient

Public Class Fees
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\CollegeVBOb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub FillStudents()
        Con.Open()
        Dim query = "Select * from StudentTable"
        Dim cmd As New SqlCommand(query, Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        StIdcb.DataSource = Tbl
        StIdcb.DisplayMember = "StId"
        StIdcb.ValueMember = "StId"
        Con.Close()
    End Sub
    Private Sub Display()
        Con.Open()
        Dim query = "select * from Payment1Tbl"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        dgvFees.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub Clear()

        AmountTb.Text = ""
        StnameTb.Text = ""
        StIdcb.SelectedIndex = -1

    End Sub
    Private Sub UpdateStudent()
        Try
            Con.Open()
            Dim query = "update StudentTable set StFees='" & AmountTb.Text & "',  where StId= " & StIdcb.SelectedValue.ToString() & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Student Updated")
            Con.Close()
            'Display()
            'Clear()

        Catch ex As Exception
            MsgBox("ex.Messages")
        End Try
    End Sub

    Private Sub GetStName()
        Con.Open()
        Dim Query = "Select * StudentTable where StId=" & StIdcb.SelectedValue.ToString() & ""
        Dim cmd As New SqlCommand(Query, Con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            StnameTb.Text = reader(1).ToString()

        End While

        Con.Close()
    End Sub
    Private Sub Fees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
        FillStudents()
    End Sub

    Private Sub StIdcb_SelectionChangeCommitted(sender As Object, e As EventArgs)
        GetStName()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Application.Exit()
    End Sub

    Private Sub btnPay_Click_1(sender As Object, e As EventArgs) Handles btnPay.Click
        If StnameTb.Text = "" Or AmountTb.Text = "" Then
            MsgBox("Missing Informations")
        ElseIf Convert.ToInt32(AmountTb.Text) > 100000 Or Convert.ToInt32(AmountTb.Text) < 1 Then
            MsgBox("Wrong Amount")
        Else
            Try
                Con.Open()
                Dim query = "insert into Payment1Tbl values('" & StIdcb.SelectedValue.ToString() & "','" & StnameTb.Text & "','" & Period.Value.Date & "', " & AmountTb.Text & ")"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Payment Successuful")
                Con.Close()
                Display()
                UpdateStudent()
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

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim Obj = New frmstudent()
        Obj.Show()
        Me.Hide()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim Obj = New Teachers()
        Obj.Show()
        Me.Hide()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim Obj = New Department()
        Obj.Show()
        Me.Hide()

    End Sub

    Private Sub lblDashBoard_Click(sender As Object, e As EventArgs) Handles lblDashBoard.Click
        Dim Obj = New Dashboard()
        Obj.Show()
        Me.Hide()

    End Sub
End Class