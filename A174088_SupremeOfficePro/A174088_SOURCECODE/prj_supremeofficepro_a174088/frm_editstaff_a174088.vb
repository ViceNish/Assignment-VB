Public Class frm_editstaff_a174088

    Private Sub get_current_code()
        Dim current_row As Integer = grd_staff.CurrentRow.Index

        txt_id.Text = grd_staff(0, current_row).Value
        txt_name.Text = grd_staff(1, current_row).Value
    End Sub

    Private Sub refresh_grid()
        grd_staff.DataSource = run_sql_4_query("SELECT * FROM TBL_STAFF_A174088")
        grd_staff.Sort(grd_staff.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub frm_editstaff_a174088_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()

        Me.BackgroundImage = Image.FromFile("wallpaper/b2.jpg")

        get_current_code()


    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a174088.Show()
        Me.Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frm_mainmenu_a174088.Show()
        Me.Close()
    End Sub

    Private Sub grd_staff_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_staff.CellContentClick, grd_staff.CellClick
        Try
            Dim value As String = grd_staff.Rows(e.RowIndex).Cells(0).Value.ToString
            If IsDBNull(value) Then

            Else
                Dim current_row As Integer = grd_staff.CurrentRow.Index
                txt_id.Text = grd_staff(0, current_row).Value
                txt_name.Text = grd_staff(1, current_row).Value


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If MsgBox("Are you sure want to edit this staff's record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Dim current_row As Integer = grd_staff.CurrentRow.Index
            run_sql_4_command("UPDATE TBL_STAFF_A174088 SET FLD_STAFF_NAME='" & txt_name.Text & "' WHERE FLD_STAFF_ID='" & grd_staff(0, current_row).Value & "'")
            Beep()
            MsgBox("You have successfully updated the staff """ & grd_staff(0, current_row).Value & """ record.")
            grd_staff.DataSource = run_sql_4_query("SELECT * FROM TBL_STAFF_A174088")

            txt_id.Text = ""
            txt_name.Text = ""
            get_current_code()
            refresh_grid()

        End If



    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim current_row As Integer = grd_staff.CurrentRow.Index
        If MsgBox("Are you sure want to delete this product record?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            run_sql_4_command("DELETE FROM TBL_STAFF_A174088 WHERE FLD_STAFF_ID='" & grd_staff(0, current_row).Value & "'")


            Beep()
            MsgBox("The staff """ & grd_staff(0, current_row).Value & """ record has been successfully deleted.")

            txt_id.Text = ""
            txt_name.Text = ""


            get_current_code()
            refresh_grid()


        End If
    End Sub

    Private Sub frm_editstaff_a174088_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class