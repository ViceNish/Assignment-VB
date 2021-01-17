Public Class frm_addproduct_a174088

    Dim default_pic As String = Application.StartupPath & "\pictures\no image.png"




    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a174088.Show()
        Me.Close()

    End Sub

    Private Sub frm_addproduct_a174088_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_product.DataSource = run_sql_4_query("SELECT * FROM TBL_PRODUCT_A174088")
        Me.grd_product.Columns(2).DefaultCellStyle.Format = "c"
        grd_product.Sort(grd_product.Columns(0), System.ComponentModel.ListSortDirection.Ascending)

        Me.BackgroundImage = Image.FromFile("wallpaper/b1.jpg")

        txt_id.Text = generate_id()
        txt_pic.Text = default_pic

        cmb_type.Items.Add("Table")
        cmb_type.Items.Add("Chair")
        cmb_type.Items.Add("Drawer")
        cmb_type.Items.Add("Shelf")

        'cmb_type.DataSource = run_sql_4_query("SELECT FLD_TYPE FROM TBL_PRODUCT_A174088")
        'cmb_type.DisplayMember = "FLD_TYPE"

        pic_product.BackgroundImage = Image.FromFile(default_pic)

        AssignValidation(Me.txt_price, ValidationType.Only_Numbers)



    End Sub

    Private Function generate_id() As String
        Dim lastID As String = run_sql_4_query("SELECT MAX(FLD_PRODUCT_ID) AS LASTID FROM TBL_PRODUCT_A174088").Rows(0).Item("LASTID")
        'Dim newID As String = "F" & Mid(lastID, 2) + 1
        'Return newID
        Dim newID As Integer = Mid(lastID, 2) + 1
        Return String.Format("F{0:00}", newID)
    End Function

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

    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click

        Try
            Using ofd As New OpenFileDialog
                Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

                ofd.InitialDirectory = mydesktop
                ofd.FileName = ""
                ofd.Filter = "JPG files (*.jpg)|*.jpg"
                ofd.ShowDialog()

                pic_product.BackgroundImage = Image.FromFile(ofd.FileName)
                txt_pic.Text = ofd.FileName
            End Using
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        If String.IsNullOrEmpty(txt_id.Text) Or String.IsNullOrEmpty(txt_name.Text) Or String.IsNullOrEmpty(txt_price.Text) Or String.IsNullOrEmpty(txt_brand.Text) Or String.IsNullOrEmpty(cmb_type.Text) Or String.IsNullOrEmpty(txt_qty.Text) Or String.IsNullOrEmpty(txt_color.Text) Then
            Beep()
            MsgBox("Please Complete the data before insert the product")
        Else
            Dim mysql As String = "INSERT INTO TBL_PRODUCT_A174088 VALUES ('" & txt_id.Text & "', '" & txt_name.Text & "', '" & txt_price.Text & "', '" & txt_brand.Text & "', '" & cmb_type.Text & "', " & txt_qty.Text & ", '" & txt_color.Text & "')"
            Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)
            Try
                mywriter.Connection.Open()
                mywriter.ExecuteNonQuery()
                mywriter.Connection.Close()

                My.Computer.FileSystem.CopyFile(txt_pic.Text, "pictures\" & txt_id.Text & ".jpg")
                grd_product.DataSource = run_sql_4_query("SELECT * FROM TBL_PRODUCT_A174088")
                txt_id.Text = generate_id()
                txt_name.Text = ""
                txt_price.Text = ""
                txt_brand.Text = ""
                cmb_type.Text = ""
                txt_qty.Text = ""
                txt_color.Text = ""

                txt_pic.Text = default_pic
                pic_product.BackgroundImage = Image.FromFile(default_pic)

                Beep()
                MsgBox("You have successfully inserted the product")
            Catch ex As Exception
                Beep()
                MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
                mywriter.Connection.Close()
            End Try
            grd_product.Sort(grd_product.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
        End If



    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frm_mainmenu_a174088.Show()
        Me.Close()

    End Sub

    Private Sub frm_addproduct_a174088_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class