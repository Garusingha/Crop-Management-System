<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Foreign_Transaction
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.lblpromiseddate = New System.Windows.Forms.Label()
        Me.lblordereddate = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lblunitprice = New System.Windows.Forms.Label()
        Me.lblquantity = New System.Windows.Forms.Label()
        Me.lblcrop = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lbladdress = New System.Windows.Forms.Label()
        Me.lbltp = New System.Windows.Forms.Label()
        Me.lblforeignimportername = New System.Windows.Forms.Label()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btncalculate = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.foreignimportername = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cropname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unitprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalvalue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.odereddate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.promiseddate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Elephant", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(170, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(741, 60)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FOREIGN TRANSACTION"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TextBox10)
        Me.Panel1.Controls.Add(Me.TextBox9)
        Me.Panel1.Controls.Add(Me.lblpromiseddate)
        Me.Panel1.Controls.Add(Me.lblordereddate)
        Me.Panel1.Controls.Add(Me.TextBox8)
        Me.Panel1.Controls.Add(Me.TextBox7)
        Me.Panel1.Controls.Add(Me.TextBox6)
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.lbltotal)
        Me.Panel1.Controls.Add(Me.lblunitprice)
        Me.Panel1.Controls.Add(Me.lblquantity)
        Me.Panel1.Controls.Add(Me.lblcrop)
        Me.Panel1.Controls.Add(Me.lblemail)
        Me.Panel1.Controls.Add(Me.lbladdress)
        Me.Panel1.Controls.Add(Me.lbltp)
        Me.Panel1.Controls.Add(Me.lblforeignimportername)
        Me.Panel1.Controls.Add(Me.btnclear)
        Me.Panel1.Controls.Add(Me.btncalculate)
        Me.Panel1.Font = New System.Drawing.Font("Modern No. 20", 10.0!)
        Me.Panel1.Location = New System.Drawing.Point(24, 95)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(822, 431)
        Me.Panel1.TabIndex = 2
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(570, 233)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(207, 22)
        Me.TextBox10.TabIndex = 21
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(570, 179)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(207, 22)
        Me.TextBox9.TabIndex = 20
        '
        'lblpromiseddate
        '
        Me.lblpromiseddate.AutoSize = True
        Me.lblpromiseddate.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpromiseddate.Location = New System.Drawing.Point(415, 234)
        Me.lblpromiseddate.Name = "lblpromiseddate"
        Me.lblpromiseddate.Size = New System.Drawing.Size(107, 17)
        Me.lblpromiseddate.TabIndex = 19
        Me.lblpromiseddate.Text = "Promised Date :"
        '
        'lblordereddate
        '
        Me.lblordereddate.AutoSize = True
        Me.lblordereddate.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblordereddate.Location = New System.Drawing.Point(415, 180)
        Me.lblordereddate.Name = "lblordereddate"
        Me.lblordereddate.Size = New System.Drawing.Size(108, 18)
        Me.lblordereddate.TabIndex = 18
        Me.lblordereddate.Text = "Ordered Date :"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(570, 124)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(207, 22)
        Me.TextBox8.TabIndex = 17
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(570, 70)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(207, 22)
        Me.TextBox7.TabIndex = 16
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(570, 19)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(207, 22)
        Me.TextBox6.TabIndex = 15
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(187, 229)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(209, 22)
        Me.TextBox5.TabIndex = 14
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(187, 176)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(209, 22)
        Me.TextBox4.TabIndex = 13
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(187, 121)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(209, 22)
        Me.TextBox3.TabIndex = 12
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(187, 70)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(209, 22)
        Me.TextBox2.TabIndex = 11
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(187, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(209, 22)
        Me.TextBox1.TabIndex = 10
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(415, 125)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(91, 18)
        Me.lbltotal.TabIndex = 9
        Me.lbltotal.Text = "Total Value :"
        '
        'lblunitprice
        '
        Me.lblunitprice.AutoSize = True
        Me.lblunitprice.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblunitprice.Location = New System.Drawing.Point(415, 74)
        Me.lblunitprice.Name = "lblunitprice"
        Me.lblunitprice.Size = New System.Drawing.Size(81, 18)
        Me.lblunitprice.TabIndex = 8
        Me.lblunitprice.Text = "Unit Price :"
        '
        'lblquantity
        '
        Me.lblquantity.AutoSize = True
        Me.lblquantity.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblquantity.Location = New System.Drawing.Point(412, 19)
        Me.lblquantity.Name = "lblquantity"
        Me.lblquantity.Size = New System.Drawing.Size(73, 18)
        Me.lblquantity.TabIndex = 7
        Me.lblquantity.Text = "Quantity :"
        '
        'lblcrop
        '
        Me.lblcrop.AutoSize = True
        Me.lblcrop.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcrop.Location = New System.Drawing.Point(16, 230)
        Me.lblcrop.Name = "lblcrop"
        Me.lblcrop.Size = New System.Drawing.Size(93, 18)
        Me.lblcrop.TabIndex = 6
        Me.lblcrop.Text = "Crop Name :"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.Location = New System.Drawing.Point(16, 177)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(55, 17)
        Me.lblemail.TabIndex = 5
        Me.lblemail.Text = "E-Mail :"
        '
        'lbladdress
        '
        Me.lbladdress.AutoSize = True
        Me.lbladdress.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdress.Location = New System.Drawing.Point(16, 125)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(70, 18)
        Me.lbladdress.TabIndex = 4
        Me.lbladdress.Text = "Address :"
        '
        'lbltp
        '
        Me.lbltp.AutoSize = True
        Me.lbltp.Font = New System.Drawing.Font("Microsoft PhagsPa", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltp.Location = New System.Drawing.Point(16, 74)
        Me.lbltp.Name = "lbltp"
        Me.lbltp.Size = New System.Drawing.Size(86, 18)
        Me.lbltp.TabIndex = 3
        Me.lbltp.Text = "Telephone :"
        '
        'lblforeignimportername
        '
        Me.lblforeignimportername.AutoSize = True
        Me.lblforeignimportername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblforeignimportername.Location = New System.Drawing.Point(7, 18)
        Me.lblforeignimportername.Name = "lblforeignimportername"
        Me.lblforeignimportername.Size = New System.Drawing.Size(175, 16)
        Me.lblforeignimportername.TabIndex = 2
        Me.lblforeignimportername.Text = "Foreign Importer Name :"
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnclear.Font = New System.Drawing.Font("Modern No. 20", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btnclear.Location = New System.Drawing.Point(457, 334)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(216, 41)
        Me.btnclear.TabIndex = 1
        Me.btnclear.Text = "CLEAR"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'btncalculate
        '
        Me.btncalculate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncalculate.Font = New System.Drawing.Font("Modern No. 20", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btncalculate.Location = New System.Drawing.Point(187, 334)
        Me.btncalculate.Name = "btncalculate"
        Me.btncalculate.Size = New System.Drawing.Size(209, 41)
        Me.btncalculate.TabIndex = 0
        Me.btncalculate.Text = "CALCULATE"
        Me.btncalculate.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Chocolate
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.foreignimportername, Me.cropname, Me.quantity1, Me.unitprice, Me.totalvalue, Me.odereddate, Me.promiseddate, Me.telep, Me.mail, Me.address})
        Me.DataGridView1.GridColor = System.Drawing.Color.LightSalmon
        Me.DataGridView1.Location = New System.Drawing.Point(15, 550)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 21
        Me.DataGridView1.RowTemplate.Height = 12
        Me.DataGridView1.Size = New System.Drawing.Size(1322, 140)
        Me.DataGridView1.TabIndex = 3
        '
        'foreignimportername
        '
        Me.foreignimportername.HeaderText = "Foreign Importer Name"
        Me.foreignimportername.Name = "foreignimportername"
        Me.foreignimportername.Width = 200
        '
        'cropname
        '
        Me.cropname.HeaderText = "Crop Name"
        Me.cropname.Name = "cropname"
        Me.cropname.Width = 200
        '
        'quantity1
        '
        Me.quantity1.HeaderText = "Quantity"
        Me.quantity1.Name = "quantity1"
        '
        'unitprice
        '
        Me.unitprice.HeaderText = "Unit Price"
        Me.unitprice.Name = "unitprice"
        '
        'totalvalue
        '
        Me.totalvalue.HeaderText = "Total Value"
        Me.totalvalue.Name = "totalvalue"
        '
        'odereddate
        '
        Me.odereddate.HeaderText = "Ordered Date"
        Me.odereddate.Name = "odereddate"
        '
        'promiseddate
        '
        Me.promiseddate.HeaderText = "Promised Date"
        Me.promiseddate.Name = "promiseddate"
        '
        'telep
        '
        Me.telep.HeaderText = "Telephone"
        Me.telep.Name = "telep"
        '
        'mail
        '
        Me.mail.HeaderText = "E-Mail"
        Me.mail.Name = "mail"
        '
        'address
        '
        Me.address.HeaderText = "Address"
        Me.address.Name = "address"
        Me.address.Width = 200
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Smal_Export_Crop_System.My.Resources.Resources.IMG_20230730_WA0017
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(5, 4)
        Me.Button1.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 55)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Foreign_Transaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Modern No. 20", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.Name = "Foreign_Transaction"
        Me.Text = "Foreign_Transaction"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lbltotal As Label
    Friend WithEvents lblunitprice As Label
    Friend WithEvents lblquantity As Label
    Friend WithEvents lblcrop As Label
    Friend WithEvents lblemail As Label
    Friend WithEvents lbladdress As Label
    Friend WithEvents lbltp As Label
    Friend WithEvents lblforeignimportername As Label
    Friend WithEvents btnclear As Button
    Friend WithEvents btncalculate As Button
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents lblpromiseddate As Label
    Friend WithEvents lblordereddate As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents foreignimportername As DataGridViewTextBoxColumn
    Friend WithEvents cropname As DataGridViewTextBoxColumn
    Friend WithEvents quantity1 As DataGridViewTextBoxColumn
    Friend WithEvents unitprice As DataGridViewTextBoxColumn
    Friend WithEvents totalvalue As DataGridViewTextBoxColumn
    Friend WithEvents odereddate As DataGridViewTextBoxColumn
    Friend WithEvents promiseddate As DataGridViewTextBoxColumn
    Friend WithEvents telep As DataGridViewTextBoxColumn
    Friend WithEvents mail As DataGridViewTextBoxColumn
    Friend WithEvents address As DataGridViewTextBoxColumn
End Class
