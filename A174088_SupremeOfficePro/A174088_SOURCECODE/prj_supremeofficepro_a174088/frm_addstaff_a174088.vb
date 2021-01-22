Public Class frm_addstaff_a174088
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_a174088.Show()
        Me.Close()

    End Sub

    Private Sub frm_addstaff_a174088_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_staff.DataSource = run_sql_4_query("SELECT * FROM TBL_STAFF_A174088")
        grd_staff.Sort(grd_staff.Columns(0), System.ComponentModel.ListSortDirection.Ascending)

        Me.BackgroundImage = Image.FromFile("wallpaper/b2.jpg")

        txt_id.Text = generate_id()


    End Sub

    Private Function generate_id() As String
        Dim lastID As String = run_sql_4_query("SELECT MAX(FLD_STAFF_ID) AS LASTID FROM TBL_STAFF_A174088").Rows(0).Item("LASTID")
        Dim newID As Integer = Mid(lastID, 2) + 1
        Return String.Format("S{0:00}", newID)
        'If Mid(lastID, 2) >= 9 Then
        '    Dim newID As String = "S" & Mid(lastID, 2) + 1
        '    Return newID
        'ElseIf Mid(lastID, 2) < 9 Then
        '    Dim newID As String = "S0" & Mid(lastID, 2) + 1
        '    Return newID
        'End If

    End Function

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If String.IsNullOrEmpty(txt_id.Text) Or String.IsNullOrEmpty(txt_name.Text) Then
            Beep()
            MsgBox("Please Complete the data before add the staff")
        Else
            Dim mysql As String = "INSERT INTO TBL_STAFF_A174088 VALUES ('" & txt_id.Text & "', '" & txt_name.Text & "')"
            Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

            Try
                mywriter.Connection.Open()
                mywriter.ExecuteNonQuery()
                mywriter.Connection.Close()

                grd_staff.DataSource = run_sql_4_query("SELECT * FROM TBL_STAFF_A174088")
                txt_id.Text = generate_id()
                txt_name.Text = ""


                MsgBox("You have successfully added customer")
            Catch ex As Exception
                Beep()
                MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
                mywriter.Connection.Close()
            End Try
            grd_staff.Sort(grd_staff.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        frm_mainmenu_a174088.Show()
        Me.Close()
    End Sub

    Private Sub frm_addstaff_a174088_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub
End Class