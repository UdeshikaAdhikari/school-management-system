<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class logging
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
        Me.lbluserloggin = New System.Windows.Forms.Label()
        Me.lblUname = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUname = New System.Windows.Forms.TextBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.lblReset = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbluserloggin
        '
        Me.lbluserloggin.AutoSize = True
        Me.lbluserloggin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluserloggin.Location = New System.Drawing.Point(35, 24)
        Me.lbluserloggin.Name = "lbluserloggin"
        Me.lbluserloggin.Size = New System.Drawing.Size(126, 25)
        Me.lbluserloggin.TabIndex = 0
        Me.lbluserloggin.Text = "User Login"
        '
        'lblUname
        '
        Me.lblUname.AutoSize = True
        Me.lblUname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUname.Location = New System.Drawing.Point(263, 130)
        Me.lblUname.Name = "lblUname"
        Me.lblUname.Size = New System.Drawing.Size(89, 20)
        Me.lblUname.TabIndex = 2
        Me.lblUname.Text = "User Name"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(263, 183)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(78, 20)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(358, 183)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(156, 20)
        Me.txtPassword.TabIndex = 4
        '
        'txtUname
        '
        Me.txtUname.Location = New System.Drawing.Point(358, 130)
        Me.txtUname.Name = "txtUname"
        Me.txtUname.Size = New System.Drawing.Size(156, 20)
        Me.txtUname.TabIndex = 5
        '
        'btnlogin
        '
        Me.btnlogin.AutoEllipsis = True
        Me.btnlogin.BackColor = System.Drawing.Color.SlateBlue
        Me.btnlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.Location = New System.Drawing.Point(385, 221)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(108, 37)
        Me.btnlogin.TabIndex = 6
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'lblReset
        '
        Me.lblReset.AutoSize = True
        Me.lblReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReset.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblReset.Location = New System.Drawing.Point(466, 262)
        Me.lblReset.Name = "lblReset"
        Me.lblReset.Size = New System.Drawing.Size(57, 20)
        Me.lblReset.TabIndex = 10
        Me.lblReset.Text = "Reset"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox3.Image = Global.loggin.My.Resources.Resources.close
        Me.PictureBox3.Location = New System.Drawing.Point(521, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(33, 27)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.Image = Global.loggin.My.Resources.Resources.LOGO_1
        Me.PictureBox2.Location = New System.Drawing.Point(429, 24)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(85, 67)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel2.Location = New System.Drawing.Point(40, 214)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(181, 14)
        Me.Panel2.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.loggin.My.Resources.Resources.com
        Me.PictureBox1.Location = New System.Drawing.Point(40, 85)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(181, 131)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'logging
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(560, 300)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblReset)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.txtUname)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUname)
        Me.Controls.Add(Me.lbluserloggin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "logging"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbluserloggin As Label
    Friend WithEvents lblUname As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUname As TextBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblReset As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
