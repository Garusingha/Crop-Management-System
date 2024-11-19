<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stores
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
        Me.lblcropname = New System.Windows.Forms.Label()
        Me.lblqantity = New System.Windows.Forms.Label()
        Me.lblreceive = New System.Windows.Forms.Label()
        Me.txtcropname = New System.Windows.Forms.TextBox()
        Me.txtcurrentquantity = New System.Windows.Forms.TextBox()
        Me.txtreceive = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.cmbstore = New System.Windows.Forms.ComboBox()
        Me.dtpstore = New System.Windows.Forms.DateTimePicker()
        Me.txtunitprice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcurrentvalue = New System.Windows.Forms.TextBox()
        Me.lblvalue = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.lblstores = New System.Windows.Forms.Label()
        Me.dgvstores = New System.Windows.Forms.DataGridView()
        Me.btnback2 = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvstores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblcropname
        '
        Me.lblcropname.AutoSize = True
        Me.lblcropname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcropname.Location = New System.Drawing.Point(60, 21)
        Me.lblcropname.Name = "lblcropname"
        Me.lblcropname.Size = New System.Drawing.Size(98, 17)
        Me.lblcropname.TabIndex = 0
        Me.lblcropname.Text = "Crop Name :"
        '
        'lblqantity
        '
        Me.lblqantity.AutoSize = True
        Me.lblqantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblqantity.Location = New System.Drawing.Point(60, 62)
        Me.lblqantity.Name = "lblqantity"
        Me.lblqantity.Size = New System.Drawing.Size(138, 17)
        Me.lblqantity.TabIndex = 1
        Me.lblqantity.Text = "Current Quantity :"
        '
        'lblreceive
        '
        Me.lblreceive.AutoSize = True
        Me.lblreceive.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreceive.Location = New System.Drawing.Point(60, 138)
        Me.lblreceive.Name = "lblreceive"
        Me.lblreceive.Size = New System.Drawing.Size(79, 17)
        Me.lblreceive.TabIndex = 2
        Me.lblreceive.Text = "Quantity :"
        '
        'txtcropname
        '
        Me.txtcropname.Location = New System.Drawing.Point(223, 18)
        Me.txtcropname.Name = "txtcropname"
        Me.txtcropname.Size = New System.Drawing.Size(245, 20)
        Me.txtcropname.TabIndex = 4
        '
        'txtcurrentquantity
        '
        Me.txtcurrentquantity.Location = New System.Drawing.Point(223, 59)
        Me.txtcurrentquantity.Name = "txtcurrentquantity"
        Me.txtcurrentquantity.Size = New System.Drawing.Size(245, 20)
        Me.txtcurrentquantity.TabIndex = 5
        '
        'txtreceive
        '
        Me.txtreceive.Location = New System.Drawing.Point(223, 138)
        Me.txtreceive.Name = "txtreceive"
        Me.txtreceive.Size = New System.Drawing.Size(245, 20)
        Me.txtreceive.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Moccasin
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Controls.Add(Me.btnclear)
        Me.Panel1.Controls.Add(Me.cmbstore)
        Me.Panel1.Controls.Add(Me.dtpstore)
        Me.Panel1.Controls.Add(Me.txtunitprice)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtcurrentvalue)
        Me.Panel1.Controls.Add(Me.lblvalue)
        Me.Panel1.Controls.Add(Me.lbldate)
        Me.Panel1.Controls.Add(Me.btnsearch)
        Me.Panel1.Controls.Add(Me.btnadd)
        Me.Panel1.Controls.Add(Me.txtcropname)
        Me.Panel1.Controls.Add(Me.lblreceive)
        Me.Panel1.Controls.Add(Me.txtcurrentquantity)
        Me.Panel1.Controls.Add(Me.lblqantity)
        Me.Panel1.Controls.Add(Me.txtreceive)
        Me.Panel1.Controls.Add(Me.lblcropname)
        Me.Panel1.Location = New System.Drawing.Point(312, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(747, 382)
        Me.Panel1.TabIndex = 8
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.Peru
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(364, 323)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(104, 35)
        Me.btnclear.TabIndex = 20
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'cmbstore
        '
        Me.cmbstore.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbstore.FormattingEnabled = True
        Me.cmbstore.Items.AddRange(New Object() {"receive", "issue"})
        Me.cmbstore.Location = New System.Drawing.Point(500, 46)
        Me.cmbstore.Name = "cmbstore"
        Me.cmbstore.Size = New System.Drawing.Size(168, 24)
        Me.cmbstore.TabIndex = 19
        Me.cmbstore.Text = "Transaction Type"
        '
        'dtpstore
        '
        Me.dtpstore.Location = New System.Drawing.Point(223, 223)
        Me.dtpstore.Name = "dtpstore"
        Me.dtpstore.Size = New System.Drawing.Size(245, 20)
        Me.dtpstore.TabIndex = 18
        '
        'txtunitprice
        '
        Me.txtunitprice.Location = New System.Drawing.Point(223, 179)
        Me.txtunitprice.Name = "txtunitprice"
        Me.txtunitprice.Size = New System.Drawing.Size(245, 20)
        Me.txtunitprice.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Unit Price :"
        '
        'txtcurrentvalue
        '
        Me.txtcurrentvalue.Location = New System.Drawing.Point(223, 97)
        Me.txtcurrentvalue.Name = "txtcurrentvalue"
        Me.txtcurrentvalue.Size = New System.Drawing.Size(245, 20)
        Me.txtcurrentvalue.TabIndex = 13
        '
        'lblvalue
        '
        Me.lblvalue.AutoSize = True
        Me.lblvalue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvalue.Location = New System.Drawing.Point(60, 100)
        Me.lblvalue.Name = "lblvalue"
        Me.lblvalue.Size = New System.Drawing.Size(118, 17)
        Me.lblvalue.TabIndex = 12
        Me.lblvalue.Text = "Current Value :"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(63, 223)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(52, 17)
        Me.lbldate.TabIndex = 10
        Me.lbldate.Text = "Date :"
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.Peru
        Me.btnsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.Location = New System.Drawing.Point(194, 323)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(116, 36)
        Me.btnsearch.TabIndex = 9
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.Peru
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(66, 324)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(82, 35)
        Me.btnadd.TabIndex = 8
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'lblstores
        '
        Me.lblstores.AutoSize = True
        Me.lblstores.Font = New System.Drawing.Font("Mongolian Baiti", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblstores.Location = New System.Drawing.Point(548, 9)
        Me.lblstores.Name = "lblstores"
        Me.lblstores.Size = New System.Drawing.Size(226, 58)
        Me.lblstores.TabIndex = 9
        Me.lblstores.Text = "STORES"
        '
        'dgvstores
        '
        Me.dgvstores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvstores.Location = New System.Drawing.Point(312, 506)
        Me.dgvstores.Name = "dgvstores"
        Me.dgvstores.Size = New System.Drawing.Size(747, 150)
        Me.dgvstores.TabIndex = 10
        '
        'btnback2
        '
        Me.btnback2.BackgroundImage = Global.Smal_Export_Crop_System.My.Resources.Resources.IMG_20230730_WA0017
        Me.btnback2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnback2.Location = New System.Drawing.Point(4, 12)
        Me.btnback2.Name = "btnback2"
        Me.btnback2.Size = New System.Drawing.Size(52, 39)
        Me.btnback2.TabIndex = 11
        Me.btnback2.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.Peru
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(516, 324)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(119, 34)
        Me.btndelete.TabIndex = 21
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'Stores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Smal_Export_Crop_System.My.Resources.Resources.best_deal_21
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.btnback2)
        Me.Controls.Add(Me.dgvstores)
        Me.Controls.Add(Me.lblstores)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Stores"
        Me.Text = "Stores"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvstores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblcropname As Label
    Friend WithEvents lblqantity As Label
    Friend WithEvents lblreceive As Label
    Friend WithEvents txtcropname As TextBox
    Friend WithEvents txtcurrentquantity As TextBox
    Friend WithEvents txtreceive As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnsearch As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents lblstores As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents dgvstores As DataGridView
    Friend WithEvents btnback2 As Button
    Friend WithEvents txtcurrentvalue As TextBox
    Friend WithEvents lblvalue As Label
    Friend WithEvents txtunitprice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpstore As DateTimePicker
    Friend WithEvents cmbstore As ComboBox
    Friend WithEvents btnclear As Button
    Friend WithEvents btndelete As Button
End Class
