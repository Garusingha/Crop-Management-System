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
        Me.lbllogin = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.btnsignup = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ckbpw = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbllogin
        '
        Me.lbllogin.AutoSize = True
        Me.lbllogin.Font = New System.Drawing.Font("Nirmala UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbllogin.Location = New System.Drawing.Point(211, 13)
        Me.lbllogin.Name = "lbllogin"
        Me.lbllogin.Size = New System.Drawing.Size(145, 54)
        Me.lbllogin.TabIndex = 0
        Me.lbllogin.Text = "LOGIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(114, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(114, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password :"
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(251, 88)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(189, 26)
        Me.txtusername.TabIndex = 3
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(251, 148)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(189, 26)
        Me.txtpassword.TabIndex = 4
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.DarkOrange
        Me.btnlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.Color.Sienna
        Me.btnlogin.Location = New System.Drawing.Point(200, 222)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(156, 39)
        Me.btnlogin.TabIndex = 5
        Me.btnlogin.Text = "SIGN IN"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'btnsignup
        '
        Me.btnsignup.BackColor = System.Drawing.Color.DarkOrange
        Me.btnsignup.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsignup.ForeColor = System.Drawing.Color.Sienna
        Me.btnsignup.Location = New System.Drawing.Point(200, 289)
        Me.btnsignup.Name = "btnsignup"
        Me.btnsignup.Size = New System.Drawing.Size(156, 40)
        Me.btnsignup.TabIndex = 6
        Me.btnsignup.Text = "SIGN UP"
        Me.btnsignup.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SaddleBrown
        Me.Panel1.Controls.Add(Me.ckbpw)
        Me.Panel1.Controls.Add(Me.lbllogin)
        Me.Panel1.Controls.Add(Me.btnsignup)
        Me.Panel1.Controls.Add(Me.txtusername)
        Me.Panel1.Controls.Add(Me.btnlogin)
        Me.Panel1.Controls.Add(Me.txtpassword)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(391, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(552, 431)
        Me.Panel1.TabIndex = 7
        '
        'ckbpw
        '
        Me.ckbpw.AutoSize = True
        Me.ckbpw.BackgroundImage = Global.Smal_Export_Crop_System.My.Resources.Resources.vector_eye_icon_symbol_sign
        Me.ckbpw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ckbpw.Location = New System.Drawing.Point(425, 156)
        Me.ckbpw.Name = "ckbpw"
        Me.ckbpw.Size = New System.Drawing.Size(15, 14)
        Me.ckbpw.TabIndex = 7
        Me.ckbpw.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Smal_Export_Crop_System.My.Resources.Resources._02131809e5714cc7c55e124f9f159186_XL__1_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1135, 614)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbllogin As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents btnsignup As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ckbpw As CheckBox
End Class
