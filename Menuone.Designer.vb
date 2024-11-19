<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menuone
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menuone))
        Me.lblsmall = New System.Windows.Forms.Label()
        Me.btncustomer = New System.Windows.Forms.Button()
        Me.btnstore = New System.Windows.Forms.Button()
        Me.btnforeignimporter = New System.Windows.Forms.Button()
        Me.btnpurchases = New System.Windows.Forms.Button()
        Me.btnforeigntransaction = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pcbforeigntransaction = New System.Windows.Forms.PictureBox()
        Me.pcbpurchases = New System.Windows.Forms.PictureBox()
        Me.pcbforeignimporter = New System.Windows.Forms.PictureBox()
        Me.pcbstores = New System.Windows.Forms.PictureBox()
        Me.pcbcustomer = New System.Windows.Forms.PictureBox()
        Me.pcbimage1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pcbforeigntransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbpurchases, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbforeignimporter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbstores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbcustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbimage1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblsmall
        '
        Me.lblsmall.AutoSize = True
        Me.lblsmall.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsmall.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblsmall.Location = New System.Drawing.Point(129, 17)
        Me.lblsmall.Name = "lblsmall"
        Me.lblsmall.Size = New System.Drawing.Size(1051, 63)
        Me.lblsmall.TabIndex = 0
        Me.lblsmall.Text = "Small Export Crops Management System"
        '
        'btncustomer
        '
        Me.btncustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btncustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncustomer.ForeColor = System.Drawing.Color.Maroon
        Me.btncustomer.Location = New System.Drawing.Point(70, 50)
        Me.btncustomer.Name = "btncustomer"
        Me.btncustomer.Size = New System.Drawing.Size(326, 41)
        Me.btncustomer.TabIndex = 1
        Me.btncustomer.Text = "CUSTOMER REGITRATION"
        Me.btncustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncustomer.UseVisualStyleBackColor = False
        '
        'btnstore
        '
        Me.btnstore.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnstore.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstore.ForeColor = System.Drawing.Color.Maroon
        Me.btnstore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnstore.Location = New System.Drawing.Point(70, 141)
        Me.btnstore.Name = "btnstore"
        Me.btnstore.Size = New System.Drawing.Size(326, 46)
        Me.btnstore.TabIndex = 2
        Me.btnstore.Text = "STORES"
        Me.btnstore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnstore.UseVisualStyleBackColor = False
        '
        'btnforeignimporter
        '
        Me.btnforeignimporter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnforeignimporter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnforeignimporter.ForeColor = System.Drawing.Color.Maroon
        Me.btnforeignimporter.Location = New System.Drawing.Point(76, 323)
        Me.btnforeignimporter.Name = "btnforeignimporter"
        Me.btnforeignimporter.Size = New System.Drawing.Size(323, 44)
        Me.btnforeignimporter.TabIndex = 3
        Me.btnforeignimporter.Text = "FOREIGN IMPORTER"
        Me.btnforeignimporter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnforeignimporter.UseVisualStyleBackColor = False
        '
        'btnpurchases
        '
        Me.btnpurchases.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnpurchases.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpurchases.ForeColor = System.Drawing.Color.Maroon
        Me.btnpurchases.Location = New System.Drawing.Point(70, 232)
        Me.btnpurchases.Name = "btnpurchases"
        Me.btnpurchases.Size = New System.Drawing.Size(329, 46)
        Me.btnpurchases.TabIndex = 4
        Me.btnpurchases.Text = "PURCHASES"
        Me.btnpurchases.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnpurchases.UseVisualStyleBackColor = False
        '
        'btnforeigntransaction
        '
        Me.btnforeigntransaction.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnforeigntransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnforeigntransaction.ForeColor = System.Drawing.Color.Maroon
        Me.btnforeigntransaction.Location = New System.Drawing.Point(70, 406)
        Me.btnforeigntransaction.Name = "btnforeigntransaction"
        Me.btnforeigntransaction.Size = New System.Drawing.Size(326, 44)
        Me.btnforeigntransaction.TabIndex = 5
        Me.btnforeigntransaction.Text = "FOREIGN TRANSACTION"
        Me.btnforeigntransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnforeigntransaction.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pcbforeigntransaction)
        Me.Panel1.Controls.Add(Me.pcbpurchases)
        Me.Panel1.Controls.Add(Me.pcbforeignimporter)
        Me.Panel1.Controls.Add(Me.pcbstores)
        Me.Panel1.Controls.Add(Me.pcbcustomer)
        Me.Panel1.Controls.Add(Me.btnforeigntransaction)
        Me.Panel1.Controls.Add(Me.btnpurchases)
        Me.Panel1.Controls.Add(Me.btnforeignimporter)
        Me.Panel1.Controls.Add(Me.btnstore)
        Me.Panel1.Controls.Add(Me.btncustomer)
        Me.Panel1.Location = New System.Drawing.Point(866, 83)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(423, 570)
        Me.Panel1.TabIndex = 12
        '
        'pcbforeigntransaction
        '
        Me.pcbforeigntransaction.BackgroundImage = CType(resources.GetObject("pcbforeigntransaction.BackgroundImage"), System.Drawing.Image)
        Me.pcbforeigntransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcbforeigntransaction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbforeigntransaction.Location = New System.Drawing.Point(0, 406)
        Me.pcbforeigntransaction.Name = "pcbforeigntransaction"
        Me.pcbforeigntransaction.Size = New System.Drawing.Size(62, 44)
        Me.pcbforeigntransaction.TabIndex = 10
        Me.pcbforeigntransaction.TabStop = False
        '
        'pcbpurchases
        '
        Me.pcbpurchases.BackgroundImage = CType(resources.GetObject("pcbpurchases.BackgroundImage"), System.Drawing.Image)
        Me.pcbpurchases.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcbpurchases.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbpurchases.Location = New System.Drawing.Point(0, 232)
        Me.pcbpurchases.Name = "pcbpurchases"
        Me.pcbpurchases.Size = New System.Drawing.Size(62, 46)
        Me.pcbpurchases.TabIndex = 9
        Me.pcbpurchases.TabStop = False
        '
        'pcbforeignimporter
        '
        Me.pcbforeignimporter.BackgroundImage = CType(resources.GetObject("pcbforeignimporter.BackgroundImage"), System.Drawing.Image)
        Me.pcbforeignimporter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcbforeignimporter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbforeignimporter.Location = New System.Drawing.Point(0, 323)
        Me.pcbforeignimporter.Name = "pcbforeignimporter"
        Me.pcbforeignimporter.Size = New System.Drawing.Size(59, 44)
        Me.pcbforeignimporter.TabIndex = 8
        Me.pcbforeignimporter.TabStop = False
        '
        'pcbstores
        '
        Me.pcbstores.BackgroundImage = CType(resources.GetObject("pcbstores.BackgroundImage"), System.Drawing.Image)
        Me.pcbstores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcbstores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbstores.Location = New System.Drawing.Point(0, 141)
        Me.pcbstores.Name = "pcbstores"
        Me.pcbstores.Size = New System.Drawing.Size(62, 46)
        Me.pcbstores.TabIndex = 7
        Me.pcbstores.TabStop = False
        '
        'pcbcustomer
        '
        Me.pcbcustomer.BackgroundImage = CType(resources.GetObject("pcbcustomer.BackgroundImage"), System.Drawing.Image)
        Me.pcbcustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcbcustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbcustomer.Location = New System.Drawing.Point(3, 50)
        Me.pcbcustomer.Name = "pcbcustomer"
        Me.pcbcustomer.Size = New System.Drawing.Size(59, 41)
        Me.pcbcustomer.TabIndex = 6
        Me.pcbcustomer.TabStop = False
        '
        'pcbimage1
        '
        Me.pcbimage1.BackgroundImage = CType(resources.GetObject("pcbimage1.BackgroundImage"), System.Drawing.Image)
        Me.pcbimage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcbimage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pcbimage1.Location = New System.Drawing.Point(45, 117)
        Me.pcbimage1.Name = "pcbimage1"
        Me.pcbimage1.Size = New System.Drawing.Size(839, 536)
        Me.pcbimage1.TabIndex = 11
        Me.pcbimage1.TabStop = False
        '
        'Menuone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1292, 690)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pcbimage1)
        Me.Controls.Add(Me.lblsmall)
        Me.Name = "Menuone"
        Me.Text = "Menuone"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.pcbforeigntransaction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbpurchases, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbforeignimporter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbstores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbcustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbimage1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblsmall As Label
    Friend WithEvents btncustomer As Button
    Friend WithEvents btnstore As Button
    Friend WithEvents btnforeignimporter As Button
    Friend WithEvents btnpurchases As Button
    Friend WithEvents btnforeigntransaction As Button
    Friend WithEvents pcbcustomer As PictureBox
    Friend WithEvents pcbstores As PictureBox
    Friend WithEvents pcbforeignimporter As PictureBox
    Friend WithEvents pcbpurchases As PictureBox
    Friend WithEvents pcbforeigntransaction As PictureBox
    Friend WithEvents pcbimage1 As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
