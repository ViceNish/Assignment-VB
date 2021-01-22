Public Class frm_editcustomer_a174088

    Private Sub get_current_code()
        Dim current_row As Integer = grd_customer.CurrentRow.Index

        txt_id.Text = grd_customer(0, current_row).Value
        txt_name.Text = grd_customer(1, current_row).Value
        txt_no.Text = grd_customer(2, current_row).Value

    End Sub
    Private Sub refresh_grid()
        grd_customer.DataSource = run_sql_4_query("SELECT * FROM TBL_CUSTOMER_A174088")
        grd_customer.Sort(grd_customer.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frm_mainmenu_a174088.Show()
        Me.Close()

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a174088.Show()
        Me.Close()
    End Sub

    Private Sub frm_editcustomer_a174088_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()

        Me.BackgroundImage = Image.FromFile("wallpaper/b2.jpg")
        AssignValidation(Me.txt_no, ValidationType.Phone_Number)

        get_current_code()

    End Sub

    Private Sub grd_staff_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_customer.CellContentClick, grd_customer.CellClick
        Try
            Dim value As String = grd_customer.Rows(e.RowIndex).Cells(0).Value.ToString
            If IsDBNull(value) Then

            Else
                Dim current_row As Integer = grd_customer.CurrentRow.Index
                txt_id.Text = grd_customer(0, current_row).Value
                txt_name.Text = grd_customer(1, current_row).Value
                txt_no.Text = grd_customer(2, current_row).Value

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_upate.Click
        If MsgBox("Are you sure want to edit this customer's record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim current_row As Integer = grd_customer.CurrentRow.Index
            run_sql_4_command("UPDATE TBL_CUSTOMER_A174088 SET FLD_CUSTOMER_NAME='" & txt_name.Text & "', FLD_CUSTOMER_PHONE='" & txt_no.Text & "' WHERE FLD_CUSTOMER_ID='" & grd_customer(0, current_row).Value & "'")
            Beep()
            MsgBox("You have successfully updated the customer """ & grd_customer(0, current_row).Value & """ record.")
            grd_customer.DataSource = run_sql_4_query("SELECT * FROM TBL_CUSTOMER_A174088")

            txt_id.Text = ""
            txt_name.Text = ""
            txt_no.Text = ""

            get_current_code()
            refresh_grid()

        End If

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim current_row As Integer = grd_customer.CurrentRow.Index
        If MsgBox("Are you sure want to delete this customer record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            run_sql_4_command("DELETE FROM TBL_CUSTOMER_A174088 WHERE FLD_CUSTOMER_ID='" & grd_customer(0, current_row).Value & "'")


            Beep()
            MsgBox("The customer """ & grd_customer(0, current_row).Value & """ record has been successfully deleted.")

            txt_id.Text = ""
            txt_name.Text = ""
            txt_no.Text = ""



            get_current_code()
            refresh_grid()


        End If
    End Sub

    Private Sub frm_editcustomer_a174088_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class