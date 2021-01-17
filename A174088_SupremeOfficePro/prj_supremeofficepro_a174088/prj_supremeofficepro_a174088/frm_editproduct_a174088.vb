Public Class frm_editproduct_a174088
    Private Sub get_current_code()
        Dim current_row As Integer = grd_product.CurrentRow.Index

        txt_id.Text = grd_product(0, current_row).Value
        txt_name.Text = grd_product(1, current_row).Value
        txt_price.Text = grd_product(2, current_row).Value
        txt_brand.Text = grd_product(3, current_row).Value
        cmb_type.Text = grd_product(4, current_row).Value
        txt_qty.Text = grd_product(5, current_row).Value
        txt_color.Text = grd_product(6, current_row).Value

    End Sub

    Private Sub refresh_grid()
        grd_product.DataSource = run_sql_4_query("SELECT * FROM TBL_PRODUCT_A174088")
        Me.grd_product.Columns(2).DefaultCellStyle.Format = "c"
        grd_product.Sort(grd_product.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frm_mainmenu_a174088.Show()
        Me.Close()

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a174088.Show()
        Me.Close()
    End Sub


    Private Sub frm_editproduct_a174088_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()

        Me.BackgroundImage = Image.FromFile("wallpaper/b2.jpg")


        cmb_type.Items.Add("Table")
        cmb_type.Items.Add("Chair")
        cmb_type.Items.Add("Drawer")
        cmb_type.Items.Add("Shelf")

        AssignValidation(Me.txt_price, ValidationType.Only_Numbers)

        get_current_code()


    End Sub


    Private Sub txt_qty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_qty.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub grd_product_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_product.CellContentClick, grd_product.CellClick
        Try
            Dim value As String = grd_product.Rows(e.RowIndex).Cells(0).Value.ToString
            If IsDBNull(value) Then

            Else
                Dim current_row As Integer = grd_product.CurrentRow.Index
                txt_id.Text = grd_product(0, current_row).Value
                txt_name.Text = grd_product(1, current_row).Value
                txt_price.Text = grd_product(2, current_row).Value
                txt_brand.Text = grd_product(3, current_row).Value
                cmb_type.Text = grd_product(4, current_row).Value
                txt_qty.Text = grd_product(5, current_row).Value
                txt_color.Text = grd_product(6, current_row).Value

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If MsgBox("Are you sure want to edit this product's details?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim current_row As Integer = grd_product.CurrentRow.Index
            run_sql_4_command("UPDATE TBL_PRODUCT_A174088 SET FLD_PRODUCT_NAME='" & txt_name.Text & "', FLD_PRICE='" & txt_price.Text & "', FLD_BRAND='" & txt_brand.Text & "', FLD_TYPE='" & cmb_type.Text & "', FLD_QUANTITY=" & txt_qty.Text & ", FLD_COLOUR='" & txt_color.Text & "' WHERE FLD_PRODUCT_ID='" & grd_product(0, current_row).Value & "'")
            Beep()
            MsgBox("You have successfully updated the product """ & grd_product(0, current_row).Value & """ details.")
            grd_product.DataSource = run_sql_4_query("SELECT * FROM TBL_PRODUCT_A174088")

            txt_id.Text = ""
            txt_name.Text = ""
            txt_price.Text = ""
            txt_brand.Text = ""
            cmb_type.Text = ""
            txt_qty.Text = ""
            txt_color.Text = ""

            get_current_code()
            refresh_grid()

        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim current_row As Integer = grd_product.CurrentRow.Index
        If MsgBox("Are you sure want to delete this product?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            run_sql_4_command("DELETE FROM TBL_PRODUCT_A174088 WHERE FLD_PRODUCT_ID='" & grd_product(0, current_row).Value & "'")

            My.Computer.FileSystem.DeleteFile("pictures\" & txt_id.Text & ".jpg")

            Beep()
            MsgBox("The product """ & grd_product(0, current_row).Value & """ has been successfully deleted.")

            txt_id.Text = ""
            txt_name.Text = ""
            txt_price.Text = ""
            txt_brand.Text = ""
            cmb_type.Text = ""
            txt_qty.Text = ""
            txt_color.Text = ""



            get_current_code()
            refresh_grid()


        End If
    End Sub

    Private Sub frm_editproduct_a174088_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class