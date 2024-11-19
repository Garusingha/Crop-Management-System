<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Foreign_Importer
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
        Me.txtcompanyname = New System.Windows.Forms.TextBox()
        Me.txtpersonname = New System.Windows.Forms.TextBox()
        Me.txtpoition = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblage = New System.Windows.Forms.Label()
        Me.lblregno = New System.Windows.Forms.Label()
        Me.lbltp = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txttp = New System.Windows.Forms.TextBox()
        Me.txtregno = New System.Windows.Forms.TextBox()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblposition = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lbladdress = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.dgvforeignimporter = New System.Windows.Forms.DataGridView()
        Me.company = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.personname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.position1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.age1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.regno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnback3 = New System.Windows.Forms.Button()
        Me.lblregdate = New System.Windows.Forms.Label()
        Me.dtpforeignimporter = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvforeignimporter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtcompanyname
        '
        Me.txtcompanyname.Location = New System.Drawing.Point(175, 12)
        Me.txtcompanyname.Name = "txtcompanyname"
        Me.txtcompanyname.Size = New System.Drawing.Size(415, 20)
        Me.txtcompanyname.TabIndex = 1
        '
        'txtpersonname
        '
        Me.txtpersonname.Location = New System.Drawing.Point(175, 43)
        Me.txtpersonname.Name = "txtpersonname"
        Me.txtpersonname.Size = New System.Drawing.Size(415, 20)
        Me.txtpersonname.TabIndex = 2
        '
        'txtpoition
        '
        Me.txtpoition.Location = New System.Drawing.Point(175, 78)
        Me.txtpoition.Name = "txtpoition"
        Me.txtpoition.Size = New System.Drawing.Size(415, 20)
        Me.txtpoition.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 7
        '
        'lblage
        '
        Me.lblage.AutoSize = True
        Me.lblage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblage.Location = New System.Drawing.Point(27, 112)
        Me.lblage.Name = "lblage"
        Me.lblage.Size = New System.Drawing.Size(46, 17)
        Me.lblage.TabIndex = 8
        Me.lblage.Text = "Age :"
        '
        'lblregno
        '
        Me.lblregno.AutoSize = True
        Me.lblregno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblregno.Location = New System.Drawing.Point(27, 148)
        Me.lblregno.Name = "lblregno"
        Me.lblregno.Size = New System.Drawing.Size(72, 17)
        Me.lblregno.TabIndex = 9
        Me.lblregno.Text = "Reg No :"
        '
        'lbltp
        '
        Me.lbltp.AutoSize = True
        Me.lbltp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltp.Location = New System.Drawing.Point(27, 183)
        Me.lbltp.Name = "lbltp"
        Me.lbltp.Size = New System.Drawing.Size(48, 17)
        Me.lbltp.TabIndex = 10
        Me.lbltp.Text = "T.P. :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(320, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(588, 63)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "FOREIGN IMPORTER"
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.Color.DarkRed
        Me.btnadd.Location = New System.Drawing.Point(77, 326)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(121, 44)
        Me.btnadd.TabIndex = 14
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.Color.DarkRed
        Me.btnclear.Location = New System.Drawing.Point(470, 326)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(120, 44)
        Me.btnclear.TabIndex = 15
        Me.btnclear.Text = "CLEAR"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaShell
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.dtpforeignimporter)
        Me.Panel1.Controls.Add(Me.lblregdate)
        Me.Panel1.Controls.Add(Me.txtemail)
        Me.Panel1.Controls.Add(Me.txtaddress)
        Me.Panel1.Controls.Add(Me.txttp)
        Me.Panel1.Controls.Add(Me.txtregno)
        Me.Panel1.Controls.Add(Me.txtage)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.lblposition)
        Me.Panel1.Controls.Add(Me.lblemail)
        Me.Panel1.Controls.Add(Me.lbladdress)
        Me.Panel1.Controls.Add(Me.lblname)
        Me.Panel1.Controls.Add(Me.txtcompanyname)
        Me.Panel1.Controls.Add(Me.btnadd)
        Me.Panel1.Controls.Add(Me.btnclear)
        Me.Panel1.Controls.Add(Me.txtpersonname)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lbltp)
        Me.Panel1.Controls.Add(Me.lblregno)
        Me.Panel1.Controls.Add(Me.txtpoition)
        Me.Panel1.Controls.Add(Me.lblage)
        Me.Panel1.Location = New System.Drawing.Point(639, 94)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(617, 419)
        Me.Panel1.TabIndex = 16
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(175, 249)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(415, 20)
        Me.txtemail.TabIndex = 25
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(175, 210)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(415, 20)
        Me.txtaddress.TabIndex = 24
        '
        'txttp
        '
        Me.txttp.Location = New System.Drawing.Point(175, 180)
        Me.txttp.Name = "txttp"
        Me.txttp.Size = New System.Drawing.Size(415, 20)
        Me.txttp.TabIndex = 23
        '
        'txtregno
        '
        Me.txtregno.Location = New System.Drawing.Point(175, 145)
        Me.txtregno.Name = "txtregno"
        Me.txtregno.Size = New System.Drawing.Size(415, 20)
        Me.txtregno.TabIndex = 22
        '
        'txtage
        '
        Me.txtage.Location = New System.Drawing.Point(175, 112)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(415, 20)
        Me.txtage.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(27, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 17)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Company Name :"
        '
        'lblposition
        '
        Me.lblposition.AutoSize = True
        Me.lblposition.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblposition.Location = New System.Drawing.Point(27, 78)
        Me.lblposition.Name = "lblposition"
        Me.lblposition.Size = New System.Drawing.Size(76, 17)
        Me.lblposition.TabIndex = 19
        Me.lblposition.Text = "Position :"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.Location = New System.Drawing.Point(27, 249)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(63, 17)
        Me.lblemail.TabIndex = 18
        Me.lblemail.Text = "E-Mail :"
        '
        'lbladdress
        '
        Me.lbladdress.AutoSize = True
        Me.lbladdress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdress.Location = New System.Drawing.Point(27, 211)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(77, 17)
        Me.lbladdress.TabIndex = 17
        Me.lbladdress.Text = "Address :"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(27, 46)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(115, 17)
        Me.lblname.TabIndex = 16
        Me.lblname.Text = "Person Name :"
        '
        'dgvforeignimporter
        '
        Me.dgvforeignimporter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvforeignimporter.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.company, Me.personname, Me.position1, Me.age1, Me.regno, Me.tp, Me.address1, Me.email})
        Me.dgvforeignimporter.Location = New System.Drawing.Point(3, 519)
        Me.dgvforeignimporter.Name = "dgvforeignimporter"
        Me.dgvforeignimporter.Size = New System.Drawing.Size(1253, 158)
        Me.dgvforeignimporter.TabIndex = 18
        '
        'company
        '
        Me.company.HeaderText = "Company Name"
        Me.company.Name = "company"
        Me.company.Width = 200
        '
        'personname
        '
        Me.personname.HeaderText = "Person name"
        Me.personname.Name = "personname"
        Me.personname.Width = 200
        '
        'position1
        '
        Me.position1.HeaderText = "Position"
        Me.position1.Name = "position1"
        '
        'age1
        '
        Me.age1.HeaderText = "Age"
        Me.age1.Name = "age1"
        '
        'regno
        '
        Me.regno.HeaderText = "Reg No"
        Me.regno.Name = "regno"
        '
        'tp
        '
        Me.tp.HeaderText = "T.P."
        Me.tp.Name = "tp"
        Me.tp.Width = 150
        '
        'address1
        '
        Me.address1.HeaderText = "Address"
        Me.address1.Name = "address1"
        Me.address1.Width = 200
        '
        'email
        '
        Me.email.HeaderText = "E-mail"
        Me.email.Name = "email"
        Me.email.Width = 170
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Smal_Export_Crop_System.My.Resources.Resources.IMG_20230730_WA0022
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(3, 94)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(630, 419)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'btnback3
        '
        Me.btnback3.BackgroundImage = Global.Smal_Export_Crop_System.My.Resources.Resources.IMG_20230730_WA0017
        Me.btnback3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnback3.Location = New System.Drawing.Point(3, 4)
        Me.btnback3.Name = "btnback3"
        Me.btnback3.Size = New System.Drawing.Size(49, 42)
        Me.btnback3.TabIndex = 0
        Me.btnback3.UseVisualStyleBackColor = True
        '
        'lblregdate
        '
        Me.lblregdate.AutoSize = True
        Me.lblregdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblregdate.Location = New System.Drawing.Point(30, 285)
        Me.lblregdate.Name = "lblregdate"
        Me.lblregdate.Size = New System.Drawing.Size(86, 17)
        Me.lblregdate.TabIndex = 26
        Me.lblregdate.Text = "Reg Date :"
        '
        'dtpforeignimporter
        '
        Me.dtpforeignimporter.Location = New System.Drawing.Point(175, 285)
        Me.dtpforeignimporter.Name = "dtpforeignimporter"
        Me.dtpforeignimporter.Size = New System.Drawing.Size(415, 20)
        Me.dtpforeignimporter.TabIndex = 27
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSalmon
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkRed
        Me.Button1.Location = New System.Drawing.Point(258, 326)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 44)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "SEARCH"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Foreign_Importer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 749)
        Me.Controls.Add(Me.dgvforeignimporter)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnback3)
        Me.Name = "Foreign_Importer"
        Me.Text = "Foreign_Importer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvforeignimporter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnback3 As Button
    Friend WithEvents txtcompanyname As TextBox
    Friend WithEvents txtpersonname As TextBox
    Friend WithEvents txtpoition As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblage As Label
    Friend WithEvents lblregno As Label
    Friend WithEvents lbltp As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnadd As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblname As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblposition As Label
    Friend WithEvents lblemail As Label
    Friend WithEvents lbladdress As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txttp As TextBox
    Friend WithEvents txtregno As TextBox
    Friend WithEvents txtage As TextBox
    Friend WithEvents dgvforeignimporter As DataGridView
    Friend WithEvents company As DataGridViewTextBoxColumn
    Friend WithEvents personname As DataGridViewTextBoxColumn
    Friend WithEvents position1 As DataGridViewTextBoxColumn
    Friend WithEvents age1 As DataGridViewTextBoxColumn
    Friend WithEvents regno As DataGridViewTextBoxColumn
    Friend WithEvents tp As DataGridViewTextBoxColumn
    Friend WithEvents address1 As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents dtpforeignimporter As DateTimePicker
    Friend WithEvents lblregdate As Label
    Friend WithEvents Button1 As Button
End Class
