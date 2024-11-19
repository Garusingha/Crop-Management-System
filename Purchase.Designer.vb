<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Purchase
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
        Me.lblcustomer = New System.Windows.Forms.Label()
        Me.lblcropname = New System.Windows.Forms.Label()
        Me.lblquantity = New System.Windows.Forms.Label()
        Me.lblunitprice = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lblpurchasedate = New System.Windows.Forms.Label()
        Me.txtcustomername = New System.Windows.Forms.TextBox()
        Me.txtcropname = New System.Windows.Forms.TextBox()
        Me.txtquantity = New System.Windows.Forms.TextBox()
        Me.txtunitprice = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.btncalculate = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.dgvpurchase = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnpurchase = New System.Windows.Forms.Button()
        Me.dtppurcase = New System.Windows.Forms.DateTimePicker()
        Me.btnsearch = New System.Windows.Forms.Button()
        CType(Me.dgvpurchase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(496, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(412, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Purchase Details"
        '
        'lblcustomer
        '
        Me.lblcustomer.AutoSize = True
        Me.lblcustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcustomer.Location = New System.Drawing.Point(46, 100)
        Me.lblcustomer.Name = "lblcustomer"
        Me.lblcustomer.Size = New System.Drawing.Size(180, 25)
        Me.lblcustomer.TabIndex = 2
        Me.lblcustomer.Text = "Customer Name :"
        '
        'lblcropname
        '
        Me.lblcropname.AutoSize = True
        Me.lblcropname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcropname.Location = New System.Drawing.Point(46, 145)
        Me.lblcropname.Name = "lblcropname"
        Me.lblcropname.Size = New System.Drawing.Size(134, 25)
        Me.lblcropname.TabIndex = 3
        Me.lblcropname.Text = "Crop Name :"
        '
        'lblquantity
        '
        Me.lblquantity.AutoSize = True
        Me.lblquantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblquantity.Location = New System.Drawing.Point(43, 189)
        Me.lblquantity.Name = "lblquantity"
        Me.lblquantity.Size = New System.Drawing.Size(106, 25)
        Me.lblquantity.TabIndex = 4
        Me.lblquantity.Text = "Quantity :"
        '
        'lblunitprice
        '
        Me.lblunitprice.AutoSize = True
        Me.lblunitprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblunitprice.Location = New System.Drawing.Point(43, 238)
        Me.lblunitprice.Name = "lblunitprice"
        Me.lblunitprice.Size = New System.Drawing.Size(118, 25)
        Me.lblunitprice.TabIndex = 5
        Me.lblunitprice.Text = "Unit Price :"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(44, 282)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(136, 25)
        Me.lbltotal.TabIndex = 6
        Me.lbltotal.Text = "Total Value :"
        '
        'lblpurchasedate
        '
        Me.lblpurchasedate.AutoSize = True
        Me.lblpurchasedate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpurchasedate.Location = New System.Drawing.Point(43, 328)
        Me.lblpurchasedate.Name = "lblpurchasedate"
        Me.lblpurchasedate.Size = New System.Drawing.Size(167, 25)
        Me.lblpurchasedate.TabIndex = 7
        Me.lblpurchasedate.Text = "Purchase Date :"
        '
        'txtcustomername
        '
        Me.txtcustomername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcustomername.Location = New System.Drawing.Point(280, 100)
        Me.txtcustomername.Name = "txtcustomername"
        Me.txtcustomername.Size = New System.Drawing.Size(413, 30)
        Me.txtcustomername.TabIndex = 8
        '
        'txtcropname
        '
        Me.txtcropname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcropname.Location = New System.Drawing.Point(280, 145)
        Me.txtcropname.Name = "txtcropname"
        Me.txtcropname.Size = New System.Drawing.Size(413, 30)
        Me.txtcropname.TabIndex = 9
        '
        'txtquantity
        '
        Me.txtquantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtquantity.Location = New System.Drawing.Point(280, 189)
        Me.txtquantity.Name = "txtquantity"
        Me.txtquantity.Size = New System.Drawing.Size(413, 30)
        Me.txtquantity.TabIndex = 10
        '
        'txtunitprice
        '
        Me.txtunitprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtunitprice.Location = New System.Drawing.Point(280, 238)
        Me.txtunitprice.Name = "txtunitprice"
        Me.txtunitprice.Size = New System.Drawing.Size(413, 30)
        Me.txtunitprice.TabIndex = 11
        '
        'txttotal
        '
        Me.txttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.Location = New System.Drawing.Point(280, 282)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(413, 30)
        Me.txttotal.TabIndex = 12
        '
        'btncalculate
        '
        Me.btncalculate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalculate.Location = New System.Drawing.Point(48, 400)
        Me.btncalculate.Name = "btncalculate"
        Me.btncalculate.Size = New System.Drawing.Size(154, 35)
        Me.btncalculate.TabIndex = 14
        Me.btncalculate.Text = "CALCULATE"
        Me.btncalculate.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(302, 404)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(161, 32)
        Me.btnclear.TabIndex = 15
        Me.btnclear.Text = "CLEAR"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'dgvpurchase
        '
        Me.dgvpurchase.AllowUserToOrderColumns = True
        Me.dgvpurchase.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvpurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvpurchase.Location = New System.Drawing.Point(85, 481)
        Me.dgvpurchase.Name = "dgvpurchase"
        Me.dgvpurchase.RowHeadersWidth = 9
        Me.dgvpurchase.Size = New System.Drawing.Size(1208, 202)
        Me.dgvpurchase.TabIndex = 50
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Smal_Export_Crop_System.My.Resources.Resources._360_F_197544457_dAtb2OlYuMf2HxlScN3w0TdIimp2BCtf
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(759, 105)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(599, 370)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'btnpurchase
        '
        Me.btnpurchase.BackgroundImage = Global.Smal_Export_Crop_System.My.Resources.Resources.IMG_20230730_WA0017
        Me.btnpurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnpurchase.Location = New System.Drawing.Point(13, 13)
        Me.btnpurchase.Name = "btnpurchase"
        Me.btnpurchase.Size = New System.Drawing.Size(64, 56)
        Me.btnpurchase.TabIndex = 1
        Me.btnpurchase.UseVisualStyleBackColor = True
        '
        'dtppurcase
        '
        Me.dtppurcase.Location = New System.Drawing.Point(280, 332)
        Me.dtppurcase.Name = "dtppurcase"
        Me.dtppurcase.Size = New System.Drawing.Size(413, 20)
        Me.dtppurcase.TabIndex = 51
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.Location = New System.Drawing.Point(565, 403)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(128, 34)
        Me.btnsearch.TabIndex = 53
        Me.btnsearch.Text = "SEARCH"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'Purchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.dtppurcase)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgvpurchase)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btncalculate)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.txtunitprice)
        Me.Controls.Add(Me.txtquantity)
        Me.Controls.Add(Me.txtcropname)
        Me.Controls.Add(Me.txtcustomername)
        Me.Controls.Add(Me.lblpurchasedate)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.lblunitprice)
        Me.Controls.Add(Me.lblquantity)
        Me.Controls.Add(Me.lblcropname)
        Me.Controls.Add(Me.lblcustomer)
        Me.Controls.Add(Me.btnpurchase)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Purchase"
        Me.Text = "Purchase"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvpurchase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnpurchase As Button
    Friend WithEvents lblcustomer As Label
    Friend WithEvents lblcropname As Label
    Friend WithEvents lblquantity As Label
    Friend WithEvents lblunitprice As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents lblpurchasedate As Label
    Friend WithEvents txtcustomername As TextBox
    Friend WithEvents txtcropname As TextBox
    Friend WithEvents txtquantity As TextBox
    Friend WithEvents txtunitprice As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents btncalculate As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents dgvpurchase As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dtppurcase As DateTimePicker
    Friend WithEvents btnsearch As Button
End Class
