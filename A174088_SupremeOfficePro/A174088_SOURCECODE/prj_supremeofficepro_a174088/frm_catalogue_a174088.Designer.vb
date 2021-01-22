<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_catalogue_a174088
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_catalogue_a174088))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.grd_product = New System.Windows.Forms.DataGridView()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.Label()
        Me.txtprice = New System.Windows.Forms.Label()
        Me.txtcolour = New System.Windows.Forms.Label()
        Me.txtbrand = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttype = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtqty = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Black
        Me.lbl_title.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Gold
        Me.lbl_title.Location = New System.Drawing.Point(570, 26)
        Me.lbl_title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(380, 36)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "PRODUCT CATALOGUE"
        '
        'grd_product
        '
        Me.grd_product.AllowUserToAddRows = False
        Me.grd_product.AllowUserToDeleteRows = False
        Me.grd_product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_product.BackgroundColor = System.Drawing.Color.White
        Me.grd_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_product.Location = New System.Drawing.Point(28, 90)
        Me.grd_product.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grd_product.Name = "grd_product"
        Me.grd_product.ReadOnly = True
        Me.grd_product.RowHeadersWidth = 51
        Me.grd_product.RowTemplate.Height = 24
        Me.grd_product.Size = New System.Drawing.Size(992, 503)
        Me.grd_product.TabIndex = 2
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.Gold
        Me.btn_back.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(28, 613)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(90, 40)
        Me.btn_back.TabIndex = 5
        Me.btn_back.Text = "< Back"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'pic_product
        '
        Me.pic_product.BackColor = System.Drawing.Color.Transparent
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(1037, 71)
        Me.pic_product.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(399, 247)
        Me.pic_product.TabIndex = 6
        Me.pic_product.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(1061, 346)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 23)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Product ID : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(1100, 477)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 23)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Brand : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(1106, 440)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 23)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Price : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(1094, 586)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 23)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Colour : "
        '
        'txtid
        '
        Me.txtid.AutoSize = True
        Me.txtid.BackColor = System.Drawing.Color.Transparent
        Me.txtid.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.ForeColor = System.Drawing.Color.Gold
        Me.txtid.Location = New System.Drawing.Point(1184, 346)
        Me.txtid.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(20, 23)
        Me.txtid.TabIndex = 16
        Me.txtid.Text = "1"
        '
        'txtprice
        '
        Me.txtprice.AutoSize = True
        Me.txtprice.BackColor = System.Drawing.Color.Transparent
        Me.txtprice.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprice.ForeColor = System.Drawing.Color.Gold
        Me.txtprice.Location = New System.Drawing.Point(1184, 440)
        Me.txtprice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(20, 23)
        Me.txtprice.TabIndex = 17
        Me.txtprice.Text = "1"
        '
        'txtcolour
        '
        Me.txtcolour.AutoSize = True
        Me.txtcolour.BackColor = System.Drawing.Color.Transparent
        Me.txtcolour.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcolour.ForeColor = System.Drawing.Color.Gold
        Me.txtcolour.Location = New System.Drawing.Point(1185, 586)
        Me.txtcolour.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtcolour.Name = "txtcolour"
        Me.txtcolour.Size = New System.Drawing.Size(20, 23)
        Me.txtcolour.TabIndex = 18
        Me.txtcolour.Text = "1"
        '
        'txtbrand
        '
        Me.txtbrand.AutoSize = True
        Me.txtbrand.BackColor = System.Drawing.Color.Transparent
        Me.txtbrand.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbrand.ForeColor = System.Drawing.Color.Gold
        Me.txtbrand.Location = New System.Drawing.Point(1184, 477)
        Me.txtbrand.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtbrand.Name = "txtbrand"
        Me.txtbrand.Size = New System.Drawing.Size(20, 23)
        Me.txtbrand.TabIndex = 19
        Me.txtbrand.Text = "1"
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.Transparent
        Me.txtname.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.ForeColor = System.Drawing.Color.Gold
        Me.txtname.Location = New System.Drawing.Point(1184, 384)
        Me.txtname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(279, 56)
        Me.txtname.TabIndex = 21
        Me.txtname.Text = "1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gold
        Me.Label6.Location = New System.Drawing.Point(1033, 384)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 23)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Product Name : "
        '
        'txttype
        '
        Me.txttype.AutoSize = True
        Me.txttype.BackColor = System.Drawing.Color.Transparent
        Me.txttype.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttype.ForeColor = System.Drawing.Color.Gold
        Me.txttype.Location = New System.Drawing.Point(1185, 512)
        Me.txttype.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txttype.Name = "txttype"
        Me.txttype.Size = New System.Drawing.Size(20, 23)
        Me.txttype.TabIndex = 23
        Me.txttype.Text = "1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gold
        Me.Label7.Location = New System.Drawing.Point(1110, 512)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 23)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Type : "
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(197, 67)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'txtqty
        '
        Me.txtqty.AutoSize = True
        Me.txtqty.BackColor = System.Drawing.Color.Transparent
        Me.txtqty.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqty.ForeColor = System.Drawing.Color.Gold
        Me.txtqty.Location = New System.Drawing.Point(1185, 550)
        Me.txtqty.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(20, 23)
        Me.txtqty.TabIndex = 26
        Me.txtqty.Text = "1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gold
        Me.Label8.Location = New System.Drawing.Point(1077, 550)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 23)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Quantity : "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(28, 10)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(204, 74)
        Me.Panel1.TabIndex = 50
        '
        'frm_catalogue_a174088
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1443, 684)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txttype)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtbrand)
        Me.Controls.Add(Me.txtcolour)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.grd_product)
        Me.Controls.Add(Me.lbl_title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.Name = "frm_catalogue_a174088"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_productlist_a174088"
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents grd_product As DataGridView
    Friend WithEvents btn_back As Button
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Label4 As Label
    Friend WithEvents txtid As Label
    Friend WithEvents txtprice As Label
    Friend WithEvents txtcolour As Label
    Friend WithEvents txtbrand As Label
    Friend WithEvents txtname As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txttype As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtqty As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
End Class
