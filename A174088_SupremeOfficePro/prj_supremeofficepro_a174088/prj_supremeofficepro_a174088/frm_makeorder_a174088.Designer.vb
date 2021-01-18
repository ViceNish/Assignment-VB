<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_makeorder_a174088
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_makeorder_a174088))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.grp1 = New System.Windows.Forms.GroupBox()
        Me.cmb_staffID = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_custdate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_custname = New System.Windows.Forms.TextBox()
        Me.txt_custid = New System.Windows.Forms.TextBox()
        Me.grd_customer = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tptemp = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmb_productID = New System.Windows.Forms.ComboBox()
        Me.qty = New System.Windows.Forms.NumericUpDown()
        Me.btn_addtocart = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txttype = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtbrand = New System.Windows.Forms.Label()
        Me.txtcolour = New System.Windows.Forms.Label()
        Me.txtprice = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grd_cart = New System.Windows.Forms.DataGridView()
        Me.totalprice = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.qty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grd_cart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(31, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(272, 91)
        Me.Panel1.TabIndex = 51
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(263, 82)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Black
        Me.lbl_title.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Gold
        Me.lbl_title.Location = New System.Drawing.Point(576, 53)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(300, 45)
        Me.lbl_title.TabIndex = 52
        Me.lbl_title.Text = "MAKE ORDER"
        '
        'grp1
        '
        Me.grp1.BackColor = System.Drawing.Color.Transparent
        Me.grp1.Controls.Add(Me.cmb_staffID)
        Me.grp1.Controls.Add(Me.Label3)
        Me.grp1.Controls.Add(Me.lblID)
        Me.grp1.Controls.Add(Me.Label1)
        Me.grp1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp1.ForeColor = System.Drawing.Color.Gold
        Me.grp1.Location = New System.Drawing.Point(31, 137)
        Me.grp1.Name = "grp1"
        Me.grp1.Size = New System.Drawing.Size(639, 113)
        Me.grp1.TabIndex = 53
        Me.grp1.TabStop = False
        Me.grp1.Text = "1. General"
        '
        'cmb_staffID
        '
        Me.cmb_staffID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_staffID.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_staffID.FormattingEnabled = True
        Me.cmb_staffID.Location = New System.Drawing.Point(409, 47)
        Me.cmb_staffID.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_staffID.Name = "cmb_staffID"
        Me.cmb_staffID.Size = New System.Drawing.Size(168, 29)
        Me.cmb_staffID.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(290, 47)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 29)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Staff ID :"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.Transparent
        Me.lblID.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.Gold
        Me.lblID.Location = New System.Drawing.Point(159, 47)
        Me.lblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(41, 29)
        Me.lblID.TabIndex = 37
        Me.lblID.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(24, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 29)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Order ID :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txt_custdate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_custname)
        Me.GroupBox1.Controls.Add(Me.txt_custid)
        Me.GroupBox1.Controls.Add(Me.grd_customer)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox1.Location = New System.Drawing.Point(31, 267)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(639, 427)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "2. Customer Informations"
        '
        'txt_custdate
        '
        Me.txt_custdate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_custdate.Location = New System.Drawing.Point(272, 343)
        Me.txt_custdate.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_custdate.Name = "txt_custdate"
        Me.txt_custdate.Size = New System.Drawing.Size(314, 29)
        Me.txt_custdate.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(116, 343)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 29)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Order Date :"
        '
        'txt_custname
        '
        Me.txt_custname.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_custname.Location = New System.Drawing.Point(272, 306)
        Me.txt_custname.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_custname.Name = "txt_custname"
        Me.txt_custname.Size = New System.Drawing.Size(314, 29)
        Me.txt_custname.TabIndex = 42
        '
        'txt_custid
        '
        Me.txt_custid.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_custid.Location = New System.Drawing.Point(272, 269)
        Me.txt_custid.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_custid.Name = "txt_custid"
        Me.txt_custid.ReadOnly = True
        Me.txt_custid.Size = New System.Drawing.Size(129, 29)
        Me.txt_custid.TabIndex = 41
        '
        'grd_customer
        '
        Me.grd_customer.AllowUserToAddRows = False
        Me.grd_customer.AllowUserToDeleteRows = False
        Me.grd_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_customer.BackgroundColor = System.Drawing.Color.White
        Me.grd_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_customer.Location = New System.Drawing.Point(29, 38)
        Me.grd_customer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grd_customer.Name = "grd_customer"
        Me.grd_customer.ReadOnly = True
        Me.grd_customer.RowHeadersWidth = 51
        Me.grd_customer.RowTemplate.Height = 24
        Me.grd_customer.Size = New System.Drawing.Size(578, 185)
        Me.grd_customer.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(175, 306)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 29)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Name :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gold
        Me.Label5.Location = New System.Drawing.Point(98, 269)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 29)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Customer ID :"
        '
        'pic_product
        '
        Me.pic_product.BackColor = System.Drawing.Color.Transparent
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(27, 37)
        Me.pic_product.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(411, 223)
        Me.pic_product.TabIndex = 55
        Me.pic_product.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.tptemp)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.cmb_productID)
        Me.GroupBox2.Controls.Add(Me.qty)
        Me.GroupBox2.Controls.Add(Me.btn_addtocart)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txttype)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtname)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtbrand)
        Me.GroupBox2.Controls.Add(Me.txtcolour)
        Me.GroupBox2.Controls.Add(Me.txtprice)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.pic_product)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox2.Location = New System.Drawing.Point(689, 137)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(827, 557)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "3. Choose Product"
        '
        'tptemp
        '
        Me.tptemp.AutoSize = True
        Me.tptemp.BackColor = System.Drawing.Color.Black
        Me.tptemp.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tptemp.ForeColor = System.Drawing.Color.Gold
        Me.tptemp.Location = New System.Drawing.Point(645, 440)
        Me.tptemp.Name = "tptemp"
        Me.tptemp.Size = New System.Drawing.Size(26, 29)
        Me.tptemp.TabIndex = 74
        Me.tptemp.Text = "1"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Black
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Gold
        Me.Label15.Location = New System.Drawing.Point(491, 440)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(148, 29)
        Me.Label15.TabIndex = 73
        Me.Label15.Text = "Total Price : "
        '
        'cmb_productID
        '
        Me.cmb_productID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_productID.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_productID.FormattingEnabled = True
        Me.cmb_productID.Location = New System.Drawing.Point(626, 47)
        Me.cmb_productID.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_productID.Name = "cmb_productID"
        Me.cmb_productID.Size = New System.Drawing.Size(168, 29)
        Me.cmb_productID.TabIndex = 40
        '
        'qty
        '
        Me.qty.Location = New System.Drawing.Point(229, 516)
        Me.qty.Name = "qty"
        Me.qty.Size = New System.Drawing.Size(102, 28)
        Me.qty.TabIndex = 72
        '
        'btn_addtocart
        '
        Me.btn_addtocart.BackColor = System.Drawing.Color.Gold
        Me.btn_addtocart.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addtocart.ForeColor = System.Drawing.Color.Black
        Me.btn_addtocart.Location = New System.Drawing.Point(649, 480)
        Me.btn_addtocart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_addtocart.Name = "btn_addtocart"
        Me.btn_addtocart.Size = New System.Drawing.Size(145, 43)
        Me.btn_addtocart.TabIndex = 70
        Me.btn_addtocart.Text = "Add To Cart"
        Me.btn_addtocart.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gold
        Me.Label8.Location = New System.Drawing.Point(81, 515)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 29)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Quantity : "
        '
        'txttype
        '
        Me.txttype.AutoSize = True
        Me.txttype.BackColor = System.Drawing.Color.Black
        Me.txttype.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttype.ForeColor = System.Drawing.Color.Gold
        Me.txttype.Location = New System.Drawing.Point(225, 426)
        Me.txttype.Name = "txttype"
        Me.txttype.Size = New System.Drawing.Size(26, 29)
        Me.txttype.TabIndex = 67
        Me.txttype.Text = "1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gold
        Me.Label7.Location = New System.Drawing.Point(125, 426)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 29)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Type : "
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.Black
        Me.txtname.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.ForeColor = System.Drawing.Color.Gold
        Me.txtname.Location = New System.Drawing.Point(224, 274)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(579, 65)
        Me.txtname.TabIndex = 65
        Me.txtname.Text = "1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gold
        Me.Label6.Location = New System.Drawing.Point(22, 274)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(187, 29)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Product Name : "
        '
        'txtbrand
        '
        Me.txtbrand.AutoSize = True
        Me.txtbrand.BackColor = System.Drawing.Color.Black
        Me.txtbrand.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbrand.ForeColor = System.Drawing.Color.Gold
        Me.txtbrand.Location = New System.Drawing.Point(225, 384)
        Me.txtbrand.Name = "txtbrand"
        Me.txtbrand.Size = New System.Drawing.Size(26, 29)
        Me.txtbrand.TabIndex = 63
        Me.txtbrand.Text = "1"
        '
        'txtcolour
        '
        Me.txtcolour.AutoSize = True
        Me.txtcolour.BackColor = System.Drawing.Color.Black
        Me.txtcolour.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcolour.ForeColor = System.Drawing.Color.Gold
        Me.txtcolour.Location = New System.Drawing.Point(224, 472)
        Me.txtcolour.Name = "txtcolour"
        Me.txtcolour.Size = New System.Drawing.Size(26, 29)
        Me.txtcolour.TabIndex = 62
        Me.txtcolour.Text = "1"
        '
        'txtprice
        '
        Me.txtprice.AutoSize = True
        Me.txtprice.BackColor = System.Drawing.Color.Black
        Me.txtprice.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprice.ForeColor = System.Drawing.Color.Gold
        Me.txtprice.Location = New System.Drawing.Point(225, 344)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(26, 29)
        Me.txtprice.TabIndex = 61
        Me.txtprice.Text = "1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Black
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gold
        Me.Label9.Location = New System.Drawing.Point(103, 472)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 29)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Colour : "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gold
        Me.Label10.Location = New System.Drawing.Point(120, 344)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 29)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "Price : "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Black
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gold
        Me.Label11.Location = New System.Drawing.Point(108, 384)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 29)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Brand : "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Black
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Gold
        Me.Label12.Location = New System.Drawing.Point(467, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(153, 29)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "Product ID : "
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.grd_cart)
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox3.Location = New System.Drawing.Point(31, 711)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1187, 267)
        Me.GroupBox3.TabIndex = 57
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "4. On Cart"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(553, 201)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 43)
        Me.Button1.TabIndex = 71
        Me.Button1.Text = "Remove"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'grd_cart
        '
        Me.grd_cart.AllowUserToAddRows = False
        Me.grd_cart.AllowUserToDeleteRows = False
        Me.grd_cart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_cart.BackgroundColor = System.Drawing.Color.White
        Me.grd_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_cart.Location = New System.Drawing.Point(29, 35)
        Me.grd_cart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grd_cart.Name = "grd_cart"
        Me.grd_cart.ReadOnly = True
        Me.grd_cart.RowHeadersWidth = 51
        Me.grd_cart.RowTemplate.Height = 24
        Me.grd_cart.Size = New System.Drawing.Size(1128, 162)
        Me.grd_cart.TabIndex = 41
        '
        'totalprice
        '
        Me.totalprice.AutoSize = True
        Me.totalprice.BackColor = System.Drawing.Color.Black
        Me.totalprice.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalprice.ForeColor = System.Drawing.Color.Gold
        Me.totalprice.Location = New System.Drawing.Point(1290, 773)
        Me.totalprice.Name = "totalprice"
        Me.totalprice.Size = New System.Drawing.Size(38, 43)
        Me.totalprice.TabIndex = 64
        Me.totalprice.Text = "1"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Black
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Gold
        Me.Label14.Location = New System.Drawing.Point(1261, 711)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(231, 43)
        Me.Label14.TabIndex = 63
        Me.Label14.Text = "Total Price : "
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gold
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(1250, 829)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(253, 197)
        Me.Button2.TabIndex = 71
        Me.Button2.Text = "Check Out"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gold
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(35, 997)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 49)
        Me.Button3.TabIndex = 72
        Me.Button3.Text = "< Back"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'frm_makeorder_a174088
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1561, 1072)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.totalprice)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grp1)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_makeorder_a174088"
        Me.Text = "frm_makeorder_a174088"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp1.ResumeLayout(False)
        Me.grp1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.qty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.grd_cart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents grp1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblID As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_staffID As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents grd_customer As DataGridView
    Friend WithEvents txt_custid As TextBox
    Friend WithEvents txt_custname As TextBox
    Friend WithEvents txt_custdate As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txttype As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtname As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtbrand As Label
    Friend WithEvents txtcolour As Label
    Friend WithEvents txtprice As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btn_addtocart As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents grd_cart As DataGridView
    Friend WithEvents totalprice As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents qty As NumericUpDown
    Friend WithEvents Button3 As Button
    Friend WithEvents cmb_productID As ComboBox
    Friend WithEvents tptemp As Label
    Friend WithEvents Label15 As Label
End Class
