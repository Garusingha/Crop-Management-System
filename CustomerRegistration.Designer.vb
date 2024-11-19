<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerRegistration
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.dtpregdate = New System.Windows.Forms.DateTimePicker()
        Me.btnview = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtcropname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txttp = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblpassword1 = New System.Windows.Forms.Label()
        Me.lblusername1 = New System.Windows.Forms.Label()
        Me.lblregdate = New System.Windows.Forms.Label()
        Me.lbltelephone = New System.Windows.Forms.Label()
        Me.lblcustomeraddress = New System.Windows.Forms.Label()
        Me.lblcustomerage = New System.Windows.Forms.Label()
        Me.lblcustomername = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvcustomerragistration = New System.Windows.Forms.DataGridView()
        Me.btnbackcustomer = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvcustomerragistration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel2.Controls.Add(Me.btnsearch)
        Me.Panel2.Controls.Add(Me.dtpregdate)
        Me.Panel2.Controls.Add(Me.btnview)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.txtcropname)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtpassword)
        Me.Panel2.Controls.Add(Me.txtusername)
        Me.Panel2.Controls.Add(Me.txttp)
        Me.Panel2.Controls.Add(Me.txtaddress)
        Me.Panel2.Controls.Add(Me.txtage)
        Me.Panel2.Controls.Add(Me.txtname)
        Me.Panel2.Controls.Add(Me.btnclear)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.lblpassword1)
        Me.Panel2.Controls.Add(Me.lblusername1)
        Me.Panel2.Controls.Add(Me.lblregdate)
        Me.Panel2.Controls.Add(Me.lbltelephone)
        Me.Panel2.Controls.Add(Me.lblcustomeraddress)
        Me.Panel2.Controls.Add(Me.lblcustomerage)
        Me.Panel2.Controls.Add(Me.lblcustomername)
        Me.Panel2.Location = New System.Drawing.Point(34, 109)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1315, 462)
        Me.Panel2.TabIndex = 0
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.Coral
        Me.btnsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.Location = New System.Drawing.Point(485, 388)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(123, 39)
        Me.btnsearch.TabIndex = 21
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'dtpregdate
        '
        Me.dtpregdate.Location = New System.Drawing.Point(240, 184)
        Me.dtpregdate.Name = "dtpregdate"
        Me.dtpregdate.Size = New System.Drawing.Size(383, 20)
        Me.dtpregdate.TabIndex = 20
        '
        'btnview
        '
        Me.btnview.BackColor = System.Drawing.Color.Coral
        Me.btnview.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnview.Location = New System.Drawing.Point(330, 385)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(133, 42)
        Me.btnview.TabIndex = 19
        Me.btnview.Text = "VIEW"
        Me.btnview.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.BackgroundImage = Global.Smal_Export_Crop_System.My.Resources.Resources.spices
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(647, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(644, 423)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'txtcropname
        '
        Me.txtcropname.Location = New System.Drawing.Point(240, 228)
        Me.txtcropname.Name = "txtcropname"
        Me.txtcropname.Size = New System.Drawing.Size(383, 20)
        Me.txtcropname.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Crop Name :"
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(240, 315)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(383, 20)
        Me.txtpassword.TabIndex = 15
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(240, 273)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(383, 20)
        Me.txtusername.TabIndex = 14
        '
        'txttp
        '
        Me.txttp.Location = New System.Drawing.Point(240, 142)
        Me.txttp.Name = "txttp"
        Me.txttp.Size = New System.Drawing.Size(383, 20)
        Me.txttp.TabIndex = 12
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(240, 100)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(383, 20)
        Me.txtaddress.TabIndex = 11
        '
        'txtage
        '
        Me.txtage.Location = New System.Drawing.Point(240, 60)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(383, 20)
        Me.txtage.TabIndex = 10
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(240, 18)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(383, 20)
        Me.txtname.TabIndex = 9
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.Coral
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(27, 388)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(130, 39)
        Me.btnclear.TabIndex = 8
        Me.btnclear.Text = "CLEAR"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Coral
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(178, 385)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 42)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "REGISTER"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblpassword1
        '
        Me.lblpassword1.AutoSize = True
        Me.lblpassword1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpassword1.Location = New System.Drawing.Point(59, 316)
        Me.lblpassword1.Name = "lblpassword1"
        Me.lblpassword1.Size = New System.Drawing.Size(87, 17)
        Me.lblpassword1.TabIndex = 6
        Me.lblpassword1.Text = "Password :"
        '
        'lblusername1
        '
        Me.lblusername1.AutoSize = True
        Me.lblusername1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername1.Location = New System.Drawing.Point(59, 274)
        Me.lblusername1.Name = "lblusername1"
        Me.lblusername1.Size = New System.Drawing.Size(91, 17)
        Me.lblusername1.TabIndex = 5
        Me.lblusername1.Text = "Username :"
        '
        'lblregdate
        '
        Me.lblregdate.AutoSize = True
        Me.lblregdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblregdate.Location = New System.Drawing.Point(59, 185)
        Me.lblregdate.Name = "lblregdate"
        Me.lblregdate.Size = New System.Drawing.Size(91, 17)
        Me.lblregdate.TabIndex = 4
        Me.lblregdate.Text = "Reg. Date :"
        '
        'lbltelephone
        '
        Me.lbltelephone.AutoSize = True
        Me.lbltelephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltelephone.Location = New System.Drawing.Point(59, 143)
        Me.lbltelephone.Name = "lbltelephone"
        Me.lbltelephone.Size = New System.Drawing.Size(48, 17)
        Me.lbltelephone.TabIndex = 3
        Me.lbltelephone.Text = "T.P. :"
        '
        'lblcustomeraddress
        '
        Me.lblcustomeraddress.AutoSize = True
        Me.lblcustomeraddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcustomeraddress.Location = New System.Drawing.Point(59, 101)
        Me.lblcustomeraddress.Name = "lblcustomeraddress"
        Me.lblcustomeraddress.Size = New System.Drawing.Size(77, 17)
        Me.lblcustomeraddress.TabIndex = 2
        Me.lblcustomeraddress.Text = "Address :"
        '
        'lblcustomerage
        '
        Me.lblcustomerage.AutoSize = True
        Me.lblcustomerage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcustomerage.Location = New System.Drawing.Point(61, 61)
        Me.lblcustomerage.Name = "lblcustomerage"
        Me.lblcustomerage.Size = New System.Drawing.Size(46, 17)
        Me.lblcustomerage.TabIndex = 1
        Me.lblcustomerage.Text = "Age :"
        '
        'lblcustomername
        '
        Me.lblcustomername.AutoSize = True
        Me.lblcustomername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcustomername.Location = New System.Drawing.Point(61, 19)
        Me.lblcustomername.Name = "lblcustomername"
        Me.lblcustomername.Size = New System.Drawing.Size(59, 17)
        Me.lblcustomername.TabIndex = 0
        Me.lblcustomername.Text = "Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(376, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(586, 63)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customer Registration"
        '
        'dgvcustomerragistration
        '
        Me.dgvcustomerragistration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcustomerragistration.Location = New System.Drawing.Point(34, 577)
        Me.dgvcustomerragistration.Name = "dgvcustomerragistration"
        Me.dgvcustomerragistration.Size = New System.Drawing.Size(1315, 104)
        Me.dgvcustomerragistration.TabIndex = 3
        '
        'btnbackcustomer
        '
        Me.btnbackcustomer.BackgroundImage = Global.Smal_Export_Crop_System.My.Resources.Resources.IMG_20230730_WA0017
        Me.btnbackcustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnbackcustomer.Location = New System.Drawing.Point(12, 10)
        Me.btnbackcustomer.Name = "btnbackcustomer"
        Me.btnbackcustomer.Size = New System.Drawing.Size(53, 48)
        Me.btnbackcustomer.TabIndex = 2
        Me.btnbackcustomer.UseVisualStyleBackColor = True
        '
        'CustomerRegistration
        '
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.dgvcustomerragistration)
        Me.Controls.Add(Me.btnbackcustomer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "CustomerRegistration"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvcustomerragistration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblname As Label
    Friend WithEvents lblage As Label
    Friend WithEvents lbladdress As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblcrop As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnadd As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnregister As Button
    Friend WithEvents Name1 As DataGridViewTextBoxColumn
    Friend WithEvents age As DataGridViewTextBoxColumn
    Friend WithEvents address As DataGridViewTextBoxColumn
    Friend WithEvents day As DataGridViewTextBoxColumn
    Friend WithEvents crop As DataGridViewTextBoxColumn
    Friend WithEvents btnback As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txttp As TextBox
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txtage As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents btnclear As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblpassword1 As Label
    Friend WithEvents lblusername1 As Label
    Friend WithEvents lblregdate As Label
    Friend WithEvents lbltelephone As Label
    Friend WithEvents lblcustomeraddress As Label
    Friend WithEvents lblcustomerage As Label
    Friend WithEvents lblcustomername As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnbackcustomer As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtcropname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvcustomerragistration As DataGridView
    Friend WithEvents btnview As Button
    Friend WithEvents dtpregdate As DateTimePicker
    Friend WithEvents btnsearch As Button
End Class
