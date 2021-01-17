Public Class frm_makeorder_a174088
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frm_mainmenu_a174088.Show()
        Me.Close()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frm_mainmenu_a174088.Show()
        Me.Close()
    End Sub
    Private Sub get_current_code()
        Dim current_row As Integer = grd_customer.CurrentRow.Index
        Dim orderdate As String = DateTime.Now.ToString("dd MMM yyyy, HH:mm:dddd")

        txt_custid.Text = grd_customer(0, current_row).Value
        txt_custname.Text = grd_customer(1, current_row).Value
        txt_custdate.Text = orderdate

    End Sub

    Private Sub frm_makeorder_a174088_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = Image.FromFile("wallpaper/b2.jpg")
        'For order ID
        GenerateID()
        'For Staff ID
        cmb_staffID.DataSource = run_sql_4_query("SELECT FLD_STAFF_ID FROM TBL_STAFF_A174088 ORDER BY FLD_STAFF_ID ASC")
        cmb_staffID.DisplayMember = "FLD_STAFF_ID"
        'For Customer
        grd_customer.DataSource = run_sql_4_query("SELECT FLD_CUSTOMER_ID, FLD_CUSTOMER_NAME FROM TBL_CUSTOMER_A174088")
        grd_customer.Sort(grd_customer.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
        get_current_code()
        'For Product
        cmb_productID.DataSource = run_sql_4_query("SELECT FLD_PRODUCT_ID FROM TBL_PRODUCT_A174088 ORDER BY FLD_PRODUCT_ID ASC")
        cmb_productID.DisplayMember = "FLD_PRODUCT_ID"
        ref_text(cmb_productID.Text)
        qty.Value = "1"
        ' tptemp.Text = txtprice.Text
        'Cart


        Dim data As DataTable = run_sql_4_query("SELECT * FROM TBL_PURCHASE_A174088")
        grd_cart.ColumnCount = data.Columns.Count
        For i = 0 To data.Columns.Count - 1
            grd_cart.Columns(i).HeaderText = data.Columns(i).ColumnName

        Next





    End Sub

    Private Sub GenerateID()
        Dim count As Integer = 1
        Dim mysql As String = "SELECT COUNT (FLD_ORDER_ID) As count_id FROM TBL_ORDER_A174088"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        count += mydatatable.Rows(0).Item("count_id")
        lblID.Text = "P" + count.ToString("00")
    End Sub

    Private Sub frm_makeorder_a174088_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()

    End Sub

    Private Sub grd_customer_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grd_customer.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = grd_customer.Rows(e.RowIndex)
            txt_custid.Text = row.Cells(0).Value.ToString
            txt_custname.Text = row.Cells(1).Value.ToString

        End If
    End Sub
    Private Sub ref_text(product As String)
        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_A174088 WHERE FLD_PRODUCT_ID = '" & product & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        txtname.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        txtprice.Text = "RM " & mydatatable.Rows(0).Item("FLD_PRICE")
        txtbrand.Text = mydatatable.Rows(0).Item("FLD_BRAND")
        txttype.Text = mydatatable.Rows(0).Item("FLD_TYPE")
        txtcolour.Text = mydatatable.Rows(0).Item("FLD_COLOUR")


        Try
            pic_product.BackgroundImage = Image.FromFile("Pictures/" & product & ".jpg")
        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile("Pictures/no image.png")
        End Try
    End Sub

    Private Sub cmb_productID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_productID.SelectedIndexChanged
        Try
            ref_text(cmb_productID.Text)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_addtocart_Click(sender As Object, e As EventArgs) Handles btn_addtocart.Click
        For Each row As DataGridViewRow In grd_cart.Rows
            If (row.Cells(0).Value = lblID.Text And row.Cells(1).Value = cmb_productID.Text) Then
                row.Cells(2).Value = Val(row.Cells(2).Value) + qty.Text
                row.Cells(3).Value = row.Cells(2).Value * txtprice.Text
                ' totalprice.Text = Val(totalprice.Text) + Val(totalprice.Text)
                Return
            Else

            End If
        Next
    End Sub


    Private Sub qty_MouseDown(sender As Object, e As MouseEventArgs) Handles qty.MouseDown, qty.MouseUp, qty.MouseClick
        Dim quantity As Integer = qty.Text
        Dim price As Integer = txtprice.Text
        tptemp.Text = "RM " & quantity * price
    End Sub
End Class