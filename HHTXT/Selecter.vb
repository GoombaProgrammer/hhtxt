Public Class Selecter

    Private Sub Selecter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each i As Form In MDIParent1.MdiChildren
            ListBox1.Items.Add(i.Text)

        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim msg = MsgBox("Do you want to save " & ListBox1.SelectedItem & "?", MsgBoxStyle.YesNo)
        If msg = MsgBoxResult.Yes Then
            If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim sw As IO.StreamWriter = New IO.StreamWriter(SaveFileDialog1.FileName)
                MsgBox("You are in a unused form of HHTXT, Please go to the main form")
                Application.Exit()
            End If
        End If
    End Sub
End Class