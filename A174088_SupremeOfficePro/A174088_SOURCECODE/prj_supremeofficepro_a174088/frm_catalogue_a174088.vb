Public Class frm_catalogue_a174088

    Private Sub get_current_code()
        Dim current_row As Integer = grd_product.CurrentRow.Index

        txtid.Text = grd_product(0, current_row).Value
        txtname.Text = grd_product(1, current_row).Value
        txtprice.Text = grd_product(2, current_row).Value
        txtbrand.Text = grd_product(3, current_row).Value
        txttype.Text = grd_product(4, current_row).Value
        txtqty.Text = grd_product(5, current_row).Value
        txtcolour.Text = grd_product(6, current_row).Value

        Try
            pic_product.BackgroundImage = Image.FromFile("pictures/" & txtid.Text & ".jpg")
        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile("pictures/no image.png")
        End Try
    End Sub

    Private Sub frm_productlist_a174088_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_product.DataSource = run_sql_4_query("SELECT * FROM TBL_PRODUCT_A174088")
        Me.BackgroundImage = Image.FromFile("wallpaper/b1.jpg")

        Me.grd_product.Columns(2).DefaultCellStyle.Format = "c"
        grd_product.Sort(grd_product.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
        get_current_code()


    End Sub


    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a174088.Show()
        Me.Close()

    End Sub

    Private Sub grd_product_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_product.CellContentClick, grd_product.CellClick


        Try
            Dim value As String = grd_product.Rows(e.RowIndex).Cells(0).Value.ToString
            If IsDBNull(value) Then

            Else

                ref_pic(value)

            End If
        Catch ex As Exception

        End Try

    End Sub


    Private Sub ref_pic(picid As String)
        Try
            pic_product.BackgroundImage = Image.FromFile("Pictures/" & picid & ".jpg")
        Catch ex As Exception
            pic_product.BackgroundImage = Image.FromFile("Pictures/no image.png")
        End Try
    End Sub

    Private Sub grd_product_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grd_product.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = grd_product.Rows(e.RowIndex)
            txtid.Text = row.Cells(0).Value.ToString
            txtname.Text = row.Cells(1).Value.ToString
            txtprice.Text = "RM " & row.Cells(2).Value.ToString & ".00"
            txtbrand.Text = row.Cells(3).Value.ToString
            txttype.Text = row.Cells(4).Value.ToString
            txtqty.Text = row.Cells(5).Value.ToString
            txtcolour.Text = row.Cells(6).Value.ToString
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frm_mainmenu_a174088.Show()
        Me.Close()
    End Sub

    Private Sub frm_catalogue_a174088_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class