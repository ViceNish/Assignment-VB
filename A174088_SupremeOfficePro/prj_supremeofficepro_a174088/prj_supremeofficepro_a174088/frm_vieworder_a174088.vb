Public Class frm_vieworder_a174088
    Dim bitmap As Bitmap

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frm_mainmenu_a174088.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frm_mainmenu_a174088.Show()
        Me.Close()

    End Sub

    Private Sub frm_vieworder_a174088_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = Image.FromFile("wallpaper/splash3.jpg")
        'Order ID
        cmb_OrderID.DataSource = run_sql_4_query("SELECT FLD_ORDER_ID FROM TBL_ORDER_A174088 ORDER BY FLD_ORDER_ID ASC")
        cmb_OrderID.DisplayMember = "FLD_ORDER_ID"
        ref_invoice(cmb_OrderID.Text)

    End Sub


    Private Sub ref_invoice(Id As String)

        Dim mysql As String = "SELECT * FROM TBL_ORDER_A174088 WHERE FLD_ORDER_ID = '" & Id & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        lblOrderID.Text = mydatatable.Rows(0).Item("FLD_ORDER_ID")
        custID.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_ID")
        staffID.Text = mydatatable.Rows(0).Item("FLD_STAFF_ID")
        lbl_date.Text = mydatatable.Rows(0).Item("FLD_ORDER_DATE")

        ref_cust(custID.Text)
        ref_staff(staffID.Text)

        ref_details(lblOrderID.Text)





    End Sub

    Private Sub ref_cust(Id As String)
        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A174088 WHERE FLD_CUSTOMER_ID = '" & Id & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        custName.Text = mydatatable.Rows(0).Item("FLD_CUSTOMER_NAME")
    End Sub
    Private Sub ref_staff(Id As String)
        Dim mysql As String = "SELECT * FROM TBL_STAFF_A174088 WHERE FLD_STAFF_ID = '" & Id & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        staffName.Text = mydatatable.Rows(0).Item("FLD_STAFF_NAME")
    End Sub
    Private Sub ref_details(Id As String)
        lbl_product.Text = ""
        lbl_qty.Text = ""
        lbl_unit.Text = ""
        lblSubTotal.Text = ""
        lbl_Total.Text = ""

        Dim purchase As DataTable = run_sql_4_query("SELECT * FROM TBL_PURCHASE_A174088 WHERE FLD_ORDER_ID = '" & Id & "'")
        For Each row As DataRow In purchase.Rows
            Dim product As DataTable = run_sql_4_query("SELECT FLD_PRODUCT_NAME, FLD_PRICE FROM TBL_PRODUCT_A174088 WHERE FLD_PRODUCT_ID = '" & row.Item("FLD_PRODUCT_ID") & "'")
            lbl_product.Text += "#" + product.Rows(0).Item("FLD_PRODUCT_NAME") + Environment.NewLine
            lbl_qty.Text += row.Item("FLD_QUANTITY").ToString + Environment.NewLine
            lbl_unit.Text += "RM " + product.Rows(0).Item("FLD_PRICE").ToString + Environment.NewLine
            lblSubTotal.Text += "RM " + row.Item("FLD_PRICE").ToString + Environment.NewLine
            lbl_Total.Text = Val(lbl_Total.Text) + row.Item("FLD_PRICE")
        Next

        lbl_product.Text = lbl_product.Text.Remove(lbl_product.Text.LastIndexOf(Environment.NewLine))
        lbl_qty.Text = lbl_qty.Text.Remove(lbl_qty.Text.LastIndexOf(Environment.NewLine))
        lbl_unit.Text = lbl_unit.Text.Remove(lbl_unit.Text.LastIndexOf(Environment.NewLine))
        lblSubTotal.Text = lblSubTotal.Text.Remove(lblSubTotal.Text.LastIndexOf(Environment.NewLine))
        lbl_Total.Text = "RM " + lbl_Total.Text
    End Sub

    Private Sub cmb_OrderID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_OrderID.SelectedIndexChanged
        Try
            ref_invoice(cmb_OrderID.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frm_vieworder_a174088_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 0, 0)
        PrintDocument1.PrinterSettings.PrinterName = "Microsoft Print to PDF"
        ' PrintDocument1.PrinterSettings.PrintFileName = "ali.pdf"
    End Sub

    Private Sub print_order_Click(sender As Object, e As EventArgs) Handles print_order.Click
        'Dim graphic As Graphics
        'bitmap = New Bitmap(Me.Width, Me.Height)
        'graphic = Graphics.FromImage(bitmap)
        'graphic.CopyFromScreen(Me.Location.X, Me.Location.Y, 0, 0, bitmap.Size)
        'PrintDocument1.DefaultPageSettings.Landscape = True
        'PrintDocument1.DefaultPageSettings.PaperSize = New System.Drawing.Printing.PaperSize("custom", Me.Width + 100, Me.Height - 60)


        'Me.PrintDocument1.Pr
        'Me.PrintDocument1.Print()

        Me.PrintPreviewDialog1.Prin
    End Sub
End Class