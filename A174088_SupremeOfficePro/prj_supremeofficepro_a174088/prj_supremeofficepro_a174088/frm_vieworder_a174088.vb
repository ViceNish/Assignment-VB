Public Class frm_vieworder_a174088

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frm_mainmenu_a174088.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frm_mainmenu_a174088.Show()
        Me.Close()

    End Sub

    Private Sub frm_vieworder_a174088_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = Image.FromFile("wallpaper/b1.jpg")
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

    Private Sub cmb_OrderID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_OrderID.SelectedIndexChanged
        Try
            ref_invoice(cmb_OrderID.Text)
        Catch ex As Exception

        End Try
    End Sub


End Class