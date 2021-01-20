<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_makeorder_a174088
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_makeorder_a174088))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.grp1 = New System.Windows.Forms.GroupBox()
        Me.cmb_staffID = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblOrderID = New System.Windows.Forms.Label()
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
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
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
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.grd_cart = New System.Windows.Forms.DataGridView()
        Me.totalprice = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btn_checkout = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
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
        Me.Panel1.Location = New System.Drawing.Point(23, 21)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(204, 74)
        Me.Panel1.TabIndex = 51
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(197, 67)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Black
        Me.lbl_title.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Gold
        Me.lbl_title.Location = New System.Drawing.Point(432, 43)
        Me.lbl_title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(239, 36)
        Me.lbl_title.TabIndex = 52
        Me.lbl_title.Text = "MAKE ORDER"
        '
        'grp1
        '
        Me.grp1.BackColor = System.Drawing.Color.Black
        Me.grp1.Controls.Add(Me.cmb_staffID)
        Me.grp1.Controls.Add(Me.Label3)
        Me.grp1.Controls.Add(Me.lblOrderID)
        Me.grp1.Controls.Add(Me.Label1)
        Me.grp1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp1.ForeColor = System.Drawing.Color.Gold
        Me.grp1.Location = New System.Drawing.Point(23, 111)
        Me.grp1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grp1.Name = "grp1"
        Me.grp1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grp1.Size = New System.Drawing.Size(479, 92)
        Me.grp1.TabIndex = 53
        Me.grp1.TabStop = False
        Me.grp1.Text = "1. General"
        '
        'cmb_staffID
        '
        Me.cmb_staffID.BackColor = System.Drawing.Color.White
        Me.cmb_staffID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_staffID.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_staffID.FormattingEnabled = True
        Me.cmb_staffID.Location = New System.Drawing.Point(307, 38)
        Me.cmb_staffID.Name = "cmb_staffID"
        Me.cmb_staffID.Size = New System.Drawing.Size(127, 25)
        Me.cmb_staffID.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(218, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 23)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Staff ID :"
        '
        'lblOrderID
        '
        Me.lblOrderID.AutoSize = True
        Me.lblOrderID.BackColor = System.Drawing.Color.Transparent
        Me.lblOrderID.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderID.ForeColor = System.Drawing.Color.Gold
        Me.lblOrderID.Location = New System.Drawing.Point(119, 38)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(31, 23)
        Me.lblOrderID.TabIndex = 37
        Me.lblOrderID.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(18, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Order ID :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.txt_custdate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_custname)
        Me.GroupBox1.Controls.Add(Me.txt_custid)
        Me.GroupBox1.Controls.Add(Me.grd_customer)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox1.Location = New System.Drawing.Point(23, 217)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(479, 347)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "2. Customer Informations"
        '
        'txt_custdate
        '
        Me.txt_custdate.BackColor = System.Drawing.Color.White
        Me.txt_custdate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_custdate.Location = New System.Drawing.Point(204, 279)
        Me.txt_custdate.Name = "txt_custdate"
        Me.txt_custdate.ReadOnly = True
        Me.txt_custdate.Size = New System.Drawing.Size(236, 25)
        Me.txt_custdate.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(87, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 23)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Order Date :"
        '
        'txt_custname
        '
        Me.txt_custname.BackColor = System.Drawing.Color.White
        Me.txt_custname.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_custname.Location = New System.Drawing.Point(204, 249)
        Me.txt_custname.Name = "txt_custname"
        Me.txt_custname.ReadOnly = True
        Me.txt_custname.Size = New System.Drawing.Size(236, 25)
        Me.txt_custname.TabIndex = 42
        '
        'txt_custid
        '
        Me.txt_custid.BackColor = System.Drawing.Color.White
        Me.txt_custid.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_custid.Location = New System.Drawing.Point(204, 219)
        Me.txt_custid.Name = "txt_custid"
        Me.txt_custid.ReadOnly = True
        Me.txt_custid.Size = New System.Drawing.Size(98, 25)
        Me.txt_custid.TabIndex = 41
        '
        'grd_customer
        '
        Me.grd_customer.AllowUserToAddRows = False
        Me.grd_customer.AllowUserToDeleteRows = False
        Me.grd_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_customer.BackgroundColor = System.Drawing.Color.White
        Me.grd_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_customer.GridColor = System.Drawing.Color.Black
        Me.grd_customer.Location = New System.Drawing.Point(13, 28)
        Me.grd_customer.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grd_customer.Name = "grd_customer"
        Me.grd_customer.ReadOnly = True
        Me.grd_customer.RowHeadersWidth = 51
        Me.grd_customer.RowTemplate.Height = 24
        Me.grd_customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grd_customer.Size = New System.Drawing.Size(452, 150)
        Me.grd_customer.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(131, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 23)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Name :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gold
        Me.Label5.Location = New System.Drawing.Point(74, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 23)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Customer ID :"
        '
        'pic_product
        '
        Me.pic_product.BackColor = System.Drawing.Color.Transparent
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(20, 30)
        Me.pic_product.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(308, 181)
        Me.pic_product.TabIndex = 55
        Me.pic_product.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Black
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label13)
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
        Me.GroupBox2.Location = New System.Drawing.Point(517, 111)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(620, 453)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "3. Choose Product"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Black
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Gold
        Me.Label17.Location = New System.Drawing.Point(169, 280)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(42, 23)
        Me.Label17.TabIndex = 76
        Me.Label17.Text = "RM"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Black
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.Control
        Me.Label13.Location = New System.Drawing.Point(267, 419)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 23)
        Me.Label13.TabIndex = 75
        Me.Label13.Text = "<< Click Here"
        '
        'tptemp
        '
        Me.tptemp.AutoSize = True
        Me.tptemp.BackColor = System.Drawing.Color.Black
        Me.tptemp.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tptemp.ForeColor = System.Drawing.Color.Gold
        Me.tptemp.Location = New System.Drawing.Point(498, 381)
        Me.tptemp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.tptemp.Name = "tptemp"
        Me.tptemp.Size = New System.Drawing.Size(20, 23)
        Me.tptemp.TabIndex = 74
        Me.tptemp.Text = "1"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Black
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Gold
        Me.Label15.Location = New System.Drawing.Point(368, 381)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(138, 23)
        Me.Label15.TabIndex = 73
        Me.Label15.Text = "Sub Total : RM"
        '
        'cmb_productID
        '
        Me.cmb_productID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_productID.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_productID.FormattingEnabled = True
        Me.cmb_productID.Location = New System.Drawing.Point(470, 38)
        Me.cmb_productID.Name = "cmb_productID"
        Me.cmb_productID.Size = New System.Drawing.Size(127, 25)
        Me.cmb_productID.TabIndex = 40
        '
        'qty
        '
        Me.qty.Location = New System.Drawing.Point(172, 419)
        Me.qty.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.qty.Name = "qty"
        Me.qty.Size = New System.Drawing.Size(76, 24)
        Me.qty.TabIndex = 72
        '
        'btn_addtocart
        '
        Me.btn_addtocart.BackColor = System.Drawing.Color.Orange
        Me.btn_addtocart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addtocart.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addtocart.ForeColor = System.Drawing.Color.Black
        Me.btn_addtocart.Location = New System.Drawing.Point(502, 406)
        Me.btn_addtocart.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_addtocart.Name = "btn_addtocart"
        Me.btn_addtocart.Size = New System.Drawing.Size(109, 35)
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
        Me.Label8.Location = New System.Drawing.Point(61, 418)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 23)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Quantity : "
        '
        'txttype
        '
        Me.txttype.AutoSize = True
        Me.txttype.BackColor = System.Drawing.Color.Black
        Me.txttype.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttype.ForeColor = System.Drawing.Color.Gold
        Me.txttype.Location = New System.Drawing.Point(169, 346)
        Me.txttype.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txttype.Name = "txttype"
        Me.txttype.Size = New System.Drawing.Size(20, 23)
        Me.txttype.TabIndex = 67
        Me.txttype.Text = "1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gold
        Me.Label7.Location = New System.Drawing.Point(94, 346)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 23)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Type : "
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.Black
        Me.txtname.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.ForeColor = System.Drawing.Color.Gold
        Me.txtname.Location = New System.Drawing.Point(168, 223)
        Me.txtname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(434, 53)
        Me.txtname.TabIndex = 65
        Me.txtname.Text = "1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gold
        Me.Label6.Location = New System.Drawing.Point(16, 223)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 23)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Product Name : "
        '
        'txtbrand
        '
        Me.txtbrand.AutoSize = True
        Me.txtbrand.BackColor = System.Drawing.Color.Black
        Me.txtbrand.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbrand.ForeColor = System.Drawing.Color.Gold
        Me.txtbrand.Location = New System.Drawing.Point(169, 312)
        Me.txtbrand.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtbrand.Name = "txtbrand"
        Me.txtbrand.Size = New System.Drawing.Size(20, 23)
        Me.txtbrand.TabIndex = 63
        Me.txtbrand.Text = "1"
        '
        'txtcolour
        '
        Me.txtcolour.AutoSize = True
        Me.txtcolour.BackColor = System.Drawing.Color.Black
        Me.txtcolour.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcolour.ForeColor = System.Drawing.Color.Gold
        Me.txtcolour.Location = New System.Drawing.Point(168, 384)
        Me.txtcolour.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtcolour.Name = "txtcolour"
        Me.txtcolour.Size = New System.Drawing.Size(20, 23)
        Me.txtcolour.TabIndex = 62
        Me.txtcolour.Text = "1"
        '
        'txtprice
        '
        Me.txtprice.AutoSize = True
        Me.txtprice.BackColor = System.Drawing.Color.Black
        Me.txtprice.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprice.ForeColor = System.Drawing.Color.Gold
        Me.txtprice.Location = New System.Drawing.Point(206, 280)
        Me.txtprice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(20, 23)
        Me.txtprice.TabIndex = 61
        Me.txtprice.Text = "1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Black
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gold
        Me.Label9.Location = New System.Drawing.Point(77, 384)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 23)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Colour : "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gold
        Me.Label10.Location = New System.Drawing.Point(90, 280)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 23)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "Price : "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Black
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gold
        Me.Label11.Location = New System.Drawing.Point(81, 312)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 23)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Brand : "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Black
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Gold
        Me.Label12.Location = New System.Drawing.Point(350, 38)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(119, 23)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "Product ID : "
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Black
        Me.GroupBox3.Controls.Add(Me.btn_remove)
        Me.GroupBox3.Controls.Add(Me.grd_cart)
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox3.Location = New System.Drawing.Point(23, 578)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(890, 217)
        Me.GroupBox3.TabIndex = 57
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "4. On Cart"
        '
        'btn_remove
        '
        Me.btn_remove.BackColor = System.Drawing.Color.OrangeRed
        Me.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_remove.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_remove.ForeColor = System.Drawing.Color.Black
        Me.btn_remove.Location = New System.Drawing.Point(415, 163)
        Me.btn_remove.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(109, 35)
        Me.btn_remove.TabIndex = 71
        Me.btn_remove.Text = "Remove"
        Me.btn_remove.UseVisualStyleBackColor = False
        '
        'grd_cart
        '
        Me.grd_cart.AllowUserToAddRows = False
        Me.grd_cart.AllowUserToDeleteRows = False
        Me.grd_cart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_cart.BackgroundColor = System.Drawing.Color.White
        Me.grd_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_cart.Location = New System.Drawing.Point(22, 28)
        Me.grd_cart.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grd_cart.Name = "grd_cart"
        Me.grd_cart.ReadOnly = True
        Me.grd_cart.RowHeadersWidth = 51
        Me.grd_cart.RowTemplate.Height = 24
        Me.grd_cart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grd_cart.Size = New System.Drawing.Size(846, 132)
        Me.grd_cart.TabIndex = 41
        '
        'totalprice
        '
        Me.totalprice.AutoSize = True
        Me.totalprice.BackColor = System.Drawing.Color.Black
        Me.totalprice.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalprice.ForeColor = System.Drawing.Color.Gold
        Me.totalprice.Location = New System.Drawing.Point(1005, 628)
        Me.totalprice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.totalprice.Name = "totalprice"
        Me.totalprice.Size = New System.Drawing.Size(30, 35)
        Me.totalprice.TabIndex = 64
        Me.totalprice.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Black
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Gold
        Me.Label14.Location = New System.Drawing.Point(946, 578)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(178, 35)
        Me.Label14.TabIndex = 63
        Me.Label14.Text = "Total Price : "
        '
        'btn_checkout
        '
        Me.btn_checkout.BackColor = System.Drawing.Color.Gold
        Me.btn_checkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_checkout.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_checkout.ForeColor = System.Drawing.Color.Black
        Me.btn_checkout.Location = New System.Drawing.Point(938, 674)
        Me.btn_checkout.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_checkout.Name = "btn_checkout"
        Me.btn_checkout.Size = New System.Drawing.Size(190, 160)
        Me.btn_checkout.TabIndex = 71
        Me.btn_checkout.Text = "Check Out"
        Me.btn_checkout.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gold
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(26, 810)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 40)
        Me.Button3.TabIndex = 72
        Me.Button3.Text = "< Back"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Black
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Gold
        Me.Label16.Location = New System.Drawing.Point(946, 628)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 35)
        Me.Label16.TabIndex = 73
        Me.Label16.Text = "RM"
        '
        'frm_makeorder_a174088
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1171, 862)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btn_checkout)
        Me.Controls.Add(Me.totalprice)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grp1)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frm_makeorder_a174088"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents lblOrderID As Label
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
    Friend WithEvents btn_remove As Button
    Friend WithEvents grd_cart As DataGridView
    Friend WithEvents totalprice As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btn_checkout As Button
    Friend WithEvents qty As NumericUpDown
    Friend WithEvents Button3 As Button
    Friend WithEvents cmb_productID As ComboBox
    Friend WithEvents tptemp As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
End Class
