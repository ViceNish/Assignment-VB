Public Class frm_mainmenu_a174088
    Private Sub frm_mainmenu_a174088_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = Image.FromFile("wallpaper/b9.jpg")
        lbl_timedate.Text = Date.Now
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()

    End Sub

    Private Sub btn_product_Click(sender As Object, e As EventArgs) Handles btn_product.Click
        Timer1.Start()
        If Not pnl_product.Width = 0 Then
            pnl_product.Width = 0
            Timer1.Enabled = False

        End If
    End Sub
    Private Sub btn_prolist_Click(sender As Object, e As EventArgs) Handles btn_prolist.Click
        frm_productlist_a174088.ShowDialog()
        'Me.Hide()

    End Sub
    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click
        Timer2.Start()
        If Not pnl_customer.Width = 0 Then
            pnl_customer.Width = 0
            Timer2.Enabled = False

        End If
    End Sub
    Private Sub btn_cuslist_Click(sender As Object, e As EventArgs) Handles btn_cuslist.Click
        frm_customerlist_a174088.ShowDialog()
        'Me.Hide()

    End Sub
    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click
        Timer3.Start()
        If Not pnl_staff.Width = 0 Then
            pnl_staff.Width = 0
            Timer3.Enabled = False

        End If
    End Sub
    Private Sub btn_stafflist_Click(sender As Object, e As EventArgs) Handles btn_stafflist.Click
        frm_stafflist_a174088.ShowDialog()
        'Me.Hide()

    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        Timer4.Start()
        If Not pnl_order.Width = 0 Then
            pnl_order.Width = 0
            Timer4.Enabled = False

        End If

    End Sub
    Private Sub btn_orlist_Click(sender As Object, e As EventArgs) Handles btn_orlist.Click
        frm_orderlist_a174088.ShowDialog()
        'Me.Hide()

    End Sub
    Private Sub btn_purchase_Click(sender As Object, e As EventArgs) Handles btn_purchase.Click
        Timer5.Start()
        If Not pnl_purchase.Width = 0 Then
            pnl_purchase.Width = 0
            Timer5.Enabled = False

        End If
    End Sub
    Private Sub btn_purlist_Click(sender As Object, e As EventArgs) Handles btn_purlist.Click
        frm_purchaselist_a174088.ShowDialog()
        ' Me.Hide()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox1.Image = Image.FromFile("wallpaper/phoenix.png")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_catalogue.Click
        frm_catalogue_a174088.ShowDialog()
        'Me.Hide()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        pnl_product.Width = 480
        Timer1.Stop()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        pnl_customer.Width = 418
        Timer2.Stop()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        pnl_staff.Width = 368
        Timer3.Stop()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        pnl_order.Width = 326
        Timer4.Stop()
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        pnl_purchase.Width = 171
        Timer5.Stop()
    End Sub

    Private Sub btn_addpro_Click(sender As Object, e As EventArgs) Handles btn_addpro.Click
        frm_addproduct_a174088.ShowDialog()
        'Me.Hide()

    End Sub

    Private Sub btn_addcust_Click(sender As Object, e As EventArgs) Handles btn_addcust.Click
        frm_addcustomer_a174088.ShowDialog()
        'Me.Hide()

    End Sub

    Private Sub btna_addstaff_Click(sender As Object, e As EventArgs) Handles btna_addstaff.Click
        frm_addstaff_a174088.ShowDialog()
        'Me.Hide()

    End Sub

    Private Sub btn_editstaff_Click(sender As Object, e As EventArgs) Handles btn_editstaff.Click
        frm_editstaff_a174088.ShowDialog()
        ' Me.Hide()

    End Sub

    Private Sub btn_editcust_Click(sender As Object, e As EventArgs) Handles btn_editcust.Click
        frm_editcustomer_a174088.ShowDialog()
        ' Me.Hide()

    End Sub

    Private Sub btn_editpro_Click(sender As Object, e As EventArgs) Handles btn_editpro.Click
        frm_editproduct_a174088.ShowDialog()
        ' Me.Hide()

    End Sub

    Private Sub btn_makeorder_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        frm_makeorder_a174088.ShowDialog()
    End Sub
End Class
