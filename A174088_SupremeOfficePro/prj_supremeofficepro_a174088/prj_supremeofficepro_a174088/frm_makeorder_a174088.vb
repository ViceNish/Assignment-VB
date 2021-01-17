Public Class frm_makeorder_a174088
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frm_mainmenu_a174088.Show()
        Me.Close()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frm_mainmenu_a174088.Show()
        Me.Close()
    End Sub

    Private Sub frm_makeorder_a174088_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = Image.FromFile("wallpaper/b2.jpg")
        'For order ID
        GenerateID()
        'For Staff ID
        cmb_staffID.DataSource = run_sql_4_query("SELECT FLD_STAFF_ID FROM TBL_STAFF_A174088 ORDER BY FLD_STAFF_ID ASC")
        cmb_staffID.DisplayMember = "FLD_STAFF_ID"

        grd_customer.DataSource = run_sql_4_query("SELECT FLD_CUSTOMER_ID, FLD_CUSTOMER_NAME FROM TBL_CUSTOMER_A174088")
        grd_customer.Sort(grd_customer.Columns(0), System.ComponentModel.ListSortDirection.Ascending)




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
End Class