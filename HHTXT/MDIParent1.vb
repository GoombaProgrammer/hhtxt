Imports System.Windows.Forms
Imports System.Text
Imports Word = Microsoft.Office.Interop.Word
Public Class MDIParent1
    Dim cloneValue As Integer = 0
    Dim openedFile As String
    Public AmountOfProjects As Integer = 0
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click
        Dim ChildForm As New Project
        ChildForm.MdiParent = Me
        AmountOfProjects += 1
        m_ChildFormNumber += 1
        ChildForm.Text = "Project" & m_ChildFormNumber
        ToolStripStatusLabel1.Text = "Created new project (" & Date.Now.ToString("hh:mm:ss") & ")"
        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "All Files|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            If Not OpenFileDialog.FileName.EndsWith(".txt") Then
                MsgBox("You are opening a file that doesn't end with .TXT, You might get errors.")
            End If
            openedFile = OpenFileDialog.FileName
            Dim sr As IO.StreamReader = New IO.StreamReader(OpenFileDialog.FileName, True)
            Dim FileName As String = OpenFileDialog.FileName
            Dim ChildForm As New Project
            ChildForm.MdiParent = Me
            AmountOfProjects += 1
            m_ChildFormNumber += 1
            ChildForm.Text = "Project" & m_ChildFormNumber
            Dim stringfs As String = sr.ReadToEnd
            ChildForm.RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog.FileName)
            ChildForm.Show()
            ToolStripStatusLabel1.Text = "Opened project (" & Date.Now.ToString("hh:mm:ss") & ")"
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim Answer = MsgBox("Do you want to save " & Me.ActiveMdiChild.Text & "?", MsgBoxStyle.YesNo)
        If Answer = MsgBoxResult.Yes Then
            If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim p As IO.StreamWriter = New IO.StreamWriter(SaveFileDialog1.FileName, True)
                For Each Ob As Object In ActiveMdiChild.Controls
                    Dim rtb As RichTextBox = CType(Ob, RichTextBox)
                    p.WriteLine(rtb.Text)
                    p.Flush()
                    p.Close()
                    ToolStripStatusLabel1.Text = "Saved project (" & Date.Now.ToString("hh:mm:ss") & ")"
                Next

            End If
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        For Each Ob As Object In ActiveMdiChild.Controls
            Dim rtb As RichTextBox = CType(Ob, RichTextBox)
            rtb.Text += My.Computer.Clipboard.GetText
        Next
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        PrintDocument1.Print()
    End Sub

    Private Sub EditMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditMenu.Click

    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click

    End Sub

    Private Sub HelpToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripButton.Click
        MsgBox("Copyright 2023 Creeperpower Inc., Made with Visual Basic 2010 Express")
        Dim abb As New AboutBox1
        abb.Text = "About"
        ToolStripStatusLabel1.Text = "Help Opened (" & Date.Now.ToString("hh:mm:ss") & ")"
        abb.MdiParent = Me
        abb.Show()
    End Sub

    Private Sub MDIParent1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click

        For Each Ob As Object In ActiveMdiChild.Controls
            Dim rtb As RichTextBox = CType(Ob, RichTextBox)
            My.Computer.FileSystem.DeleteFile(openedFile)
            System.IO.File.Create(openedFile).Close()
            Dim p As IO.StreamWriter = New IO.StreamWriter(openedFile, True)
            p.Write(rtb.Text)
            p.Flush()
            p.Close()
        Next
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        For Each Ob As Object In ActiveMdiChild.Controls
            Dim rtb As RichTextBox = CType(Ob, RichTextBox)
            My.Computer.FileSystem.DeleteFile(openedFile)
            System.IO.File.Create(openedFile).Close()
            Dim p As IO.StreamWriter = New IO.StreamWriter(openedFile, True)
            p.Write(rtb.Text)
            p.Flush()
            p.Close()
            ToolStripStatusLabel1.Text = "Saved project (" & Date.Now.ToString("hh:mm:ss") & ")"
        Next
    End Sub

    Private Sub PrintPreviewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewToolStripButton.Click

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        On Error Resume Next
        For Each Ob As Object In ActiveMdiChild.Controls
            Dim rtb As RichTextBox = CType(Ob, RichTextBox)
            Dim font1 As New Font(FontDialog1.Font.FontFamily, FontDialog1.Font.SizeInPoints, FontStyle.Regular)
            e.Graphics.DrawString(rtb.Text, font1, Brushes.Black, 100, 100)
            ToolStripStatusLabel1.Text = "Printed project (" & Date.Now.ToString("hh:mm:ss") & ")"
        Next
    End Sub
    Sub PrintError()
        MsgBox("Cannot preview!")
    End Sub
    Private Sub PrintPreviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Sub PrintToolStripButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click
        PrintDocument1.Print()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        PrintDocument2.Print()
        AmountOfProjects -= 1
        If AmountOfProjects > 0 Then
            Me.ActivateMdiChild(Me.MdiChildren(AmountOfProjects))
            Threading.Thread.Sleep(3400)
            If Me.MdiChildren.Length > 0 Then
                ToolStripButton1.PerformClick()
            Else

            End If
        End If
    End Sub

    Private Sub PrintDocument2_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        For Each frm In ActiveMdiChild.Controls
            Dim rtb As RichTextBox = CType(frm, RichTextBox)
            Dim font1 As New Font(FontDialog1.Font.FontFamily, FontDialog1.Font.SizeInPoints, FontStyle.Regular)
            e.Graphics.DrawString(rtb.Text, font1, Brushes.Black, 100, 100)
            ToolStripStatusLabel1.Text = "Printed project (" & Date.Now.ToString("hh:mm:ss") & ")"
        Next
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ToolStripLabel1.Text = AmountOfProjects & " Projects"
    End Sub

    Private Sub PrintFontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintFontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
    End Sub

    Private Sub HelpMeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpMeToolStripMenuItem.Click
        If Not IO.File.Exists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\hhtxt.chm") Then
            IO.File.WriteAllBytes(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\hhtxt.chm", My.Resources.MyHelp)
        End If
        Process.Start(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\hhtxt.chm")
    End Sub
    Private Sub MacroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Macro is not allowed")
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        AmountOfProjects += m_ChildFormNumber
        cloneValue = m_ChildFormNumber
        For i As Integer = cloneValue To m_ChildFormNumber + m_ChildFormNumber - 1
            Dim p As New Project
            p.MdiParent = Me
            m_ChildFormNumber += 1
            p.Text = "Project" & m_ChildFormNumber
            p.Show()
            If i = 0 Then
                cloneValue = 0
            End If
        Next
    End Sub
    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        For Each frmApproval As Form In Me.MdiChildren
            frmApproval.Close()
        Next
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        ToolStripStatusLabel1.Text = "Secret Gray Label Clicked (" & Date.Now.ToString("hh:mm:ss") & ")"
    End Sub

    Private Sub AddHHUSERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CrashToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("The application you just executed is not responding.", MsgBoxStyle.SystemModal)
        crash.Show()
    End Sub

    Private Sub MDIParent1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim fn As String() = Environment.GetCommandLineArgs()
        If fn.Length > 1 Then
            Dim a As New IO.StreamReader(fn(1))
            openedFile = fn(1)
            Dim ChildForm As New Project
            ChildForm.MdiParent = Me
            ChildForm.Text = fn(1)
            AmountOfProjects += 1
            m_ChildFormNumber += 1
            ChildForm.Text = "Project" & m_ChildFormNumber
            ToolStripStatusLabel1.Text = "Loaded existing project from file (" & Date.Now.ToString("hh:mm:ss") & ")"
            ChildForm.Show()
            Me.ActiveMdiChild.ActiveControl.Text = a.ReadToEnd
            a.Close()
        End If
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        For Each Ob As Object In ActiveMdiChild.Controls
            Dim rtb As RichTextBox = CType(Ob, RichTextBox)
            rtb.SelectAll()
        Next
    End Sub
End Class