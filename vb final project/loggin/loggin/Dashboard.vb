Imports System.Data.SqlClient

Public Class Dashboard
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\CollegeVBOb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub CountStud()
        Dim StNum As Integer
        Con.open()
        Dim sql = "Select COUNT (*) from TeacherTbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)
        StNum = cmd.ExecuteScalar
        StNumlbl.Text = StNum
        Con.Close()
    End Sub
    Private Sub CountTeachers()
        Dim TNum As Integer
        Con.open()
        Dim sql = "Select COUNT (*) from TeacherTbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)
        TNum = cmd.ExecuteScalar
        TCountlbl.Text = TNum
        Con.Close()
    End Sub

    Private Sub CountDepartment()
        Dim DepNum As Integer
        Con.open()
        Dim sql = "Select COUNT (*) from Department1Tbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)
        DepNum = cmd.ExecuteScalar
        DepNumlbl.Text = DepNum
        Con.Close()
    End Sub

    Private Sub SumFees()
        Dim FeesAmount As Integer
        Con.open()
        Dim sql = "Select Sum (Amount) from Payment1Tbl"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(sql, Con)
        FeesAmount = cmd.ExecuteScalar
        Dim Am As String
        Am = Convert.ToString(FeesAmount)
        Feescolbl.Text = "Rs" + Am
        Con.Close()
    End Sub
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CountStud()
        CountTeachers()
        CountDepartment()
        SumFees()

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Application.Exit()
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

    Private Sub lblCfees_Click(sender As Object, e As EventArgs) Handles lblCfees.Click
        Dim Obj = New Fees()
        Obj.Show()
        Me.Hide()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim Obj = New Department()
        Obj.Show()
        Me.Hide()

    End Sub
End Class