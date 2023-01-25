using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsApplication1
{
    public partial class MDIParent1
    {
        private int cloneValue = 0;
        private string openedFile;
        
        public int AmountOfProjects { get; set; } = 0;

        public static MDIParent1 instance;

        public MDIParent1()
        {
            instance = this;
            InitializeComponent();
        }
        
        private void ShowNewForm(object sender, EventArgs e)
        {
            var ChildForm = new Project();
            ChildForm.MdiParent = this;
            AmountOfProjects += 1;
            m_ChildFormNumber += 1;
            ChildForm.Text = "Project" + m_ChildFormNumber;
            ToolStripStatusLabel1.Text = "Created new project (" + DateTime.Now.ToString("hh:mm:ss") + ")";
            ChildForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            var OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            OpenFileDialog.Filter = "All Files|*.*";
            if (OpenFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                if (!OpenFileDialog.FileName.EndsWith(".txt"))
                {
                    Interaction.MsgBox("You are opening a file that doesn't end with .TXT, You might get errors.");
                }
                openedFile = OpenFileDialog.FileName;
                var sr = new System.IO.StreamReader(OpenFileDialog.FileName, true);
                string FileName = OpenFileDialog.FileName;
                var ChildForm = new Project();
                ChildForm.MdiParent = this;
                AmountOfProjects += 1;
                m_ChildFormNumber += 1;
                ChildForm.Text = "Project" + m_ChildFormNumber;
                string stringfs = sr.ReadToEnd();
                ChildForm.RichTextBox1.Text = System.IO.File.ReadAllText(OpenFileDialog.FileName);
                ChildForm.Show();
                ToolStripStatusLabel1.Text = "Opened project (" + DateTime.Now.ToString("hh:mm:ss") + ")";
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Answer = Interaction.MsgBox("Do you want to save " + ActiveMdiChild.Text + "?", MsgBoxStyle.YesNo);
            if (Answer == MsgBoxResult.Yes)
            {
                if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    var p = new System.IO.StreamWriter(SaveFileDialog1.FileName, true);
                    foreach (object Ob in ActiveMdiChild.Controls)
                    {
                        RichTextBox rtb = (RichTextBox)Ob;
                        p.WriteLine(rtb.Text);
                        p.Flush();
                        p.Close();
                        ToolStripStatusLabel1.Text = "Saved project (" + DateTime.Now.ToString("hh:mm:ss") + ")";
                    }

                }
            }
        }


        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (object Ob in ActiveMdiChild.Controls)
            {
                RichTextBox rtb = (RichTextBox)Ob;
                rtb.Text += Clipboard.GetText();
            }
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStrip.Visible = ToolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusStrip.Visible = StatusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form ChildForm in MdiChildren)
                ChildForm.Close();
        }

        private int m_ChildFormNumber;

        private void OptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument1.Print();
        }

        private void EditMenu_Click(object sender, EventArgs e)
        {

        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void HelpToolStripButton_Click(object sender, EventArgs e)
        {
            Interaction.MsgBox("Copyright 2023 HHTXT Contributors, Made with Visual Studio");
            var abb = new AboutBox1();
            abb.Text = "About";
            ToolStripStatusLabel1.Text = "Help Opened (" + DateTime.Now.ToString("hh:mm:ss") + ")";
            abb.MdiParent = this;
            abb.Show();
        }

        private void MDIParent1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (object Ob in ActiveMdiChild.Controls)
            {
                RichTextBox rtb = (RichTextBox)Ob;
                System.IO.File.Delete(openedFile);
                System.IO.File.Create(openedFile).Close();
                var p = new System.IO.StreamWriter(openedFile, true);
                p.Write(rtb.Text);
                p.Flush();
                p.Close();
            }
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            foreach (object Ob in ActiveMdiChild.Controls)
            {
                RichTextBox rtb = (RichTextBox)Ob;
                System.IO.File.Delete(openedFile);
                System.IO.File.Create(openedFile).Close();
                var p = new System.IO.StreamWriter(openedFile, true);
                p.Write(rtb.Text);
                p.Flush();
                p.Close();
                ToolStripStatusLabel1.Text = "Saved project (" + DateTime.Now.ToString("hh:mm:ss") + ")";
            }
        }

        private void PrintPreviewToolStripButton_Click(object sender, EventArgs e)
        {

            PrintPreviewDialog1.Document = PrintDocument1;
            PrintPreviewDialog1.ShowDialog();
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            foreach (object Ob in ActiveMdiChild.Controls)
            {
                RichTextBox rtb = (RichTextBox)Ob;
                var font1 = new Font(FontDialog1.Font.FontFamily, FontDialog1.Font.SizeInPoints, FontStyle.Regular);
                e.Graphics.DrawString(rtb.Text, font1, Brushes.Black, 100f, 100f);
                ToolStripStatusLabel1.Text = "Printed project (" + DateTime.Now.ToString("hh:mm:ss") + ")";
            }
        }
        public void PrintError()
        {
            Interaction.MsgBox("Cannot preview!");
        }
        private void PrintPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog1.ShowDialog();
        }
        private void PrintToolStripButton_Click(object sender, EventArgs e)
        {
            PrintDocument1.Print();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            PrintDocument2.Print();
            AmountOfProjects -= 1;
            if (AmountOfProjects > 0)
            {
                ActivateMdiChild(MdiChildren[AmountOfProjects]);
                System.Threading.Thread.Sleep(3400);
                if (MdiChildren.Length > 0)
                {
                    ToolStripButton1.PerformClick();
                }
                else
                {

                }
            }
        }

        private void PrintDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            foreach (var frm in ActiveMdiChild.Controls)
            {
                RichTextBox rtb = (RichTextBox)frm;
                var font1 = new Font(FontDialog1.Font.FontFamily, FontDialog1.Font.SizeInPoints, FontStyle.Regular);
                e.Graphics.DrawString(rtb.Text, font1, Brushes.Black, 100f, 100f);
                ToolStripStatusLabel1.Text = "Printed project (" + DateTime.Now.ToString("hh:mm:ss") + ")";
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            ToolStripLabel1.Text = AmountOfProjects + " Projects";
        }

        private void PrintFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog1.ShowDialog();
        }

        private void HelpMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            path = Path.Combine(path, @"\hhtxt.chm");

            if (!File.Exists(path))
            {
                File.WriteAllBytes(path, Properties.Resources.MyHelp);
            }
            
            Process.Start(path);
        }
        private void MacroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interaction.MsgBox("Macro is not allowed");
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AmountOfProjects += m_ChildFormNumber;
            cloneValue = m_ChildFormNumber;
            for (int i = cloneValue, loopTo = m_ChildFormNumber + m_ChildFormNumber - 1; i <= loopTo; i++)
            {
                var p = new Project();
                p.MdiParent = this;
                m_ChildFormNumber += 1;
                p.Text = "Project" + m_ChildFormNumber;
                p.Show();
                if (i == 0)
                {
                    cloneValue = 0;
                }
            }
        }
        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frmApproval in MdiChildren)
                frmApproval.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            ToolStripStatusLabel1.Text = "Secret Gray Label Clicked (" + DateTime.Now.ToString("hh:mm:ss") + ")";
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            string[] fn = Environment.GetCommandLineArgs();
            if (fn.Length > 1)
            {
                var a = new System.IO.StreamReader(fn[1]);
                openedFile = fn[1];
                var ChildForm = new Project();
                ChildForm.MdiParent = this;
                ChildForm.Text = fn[1];
                AmountOfProjects += 1;
                m_ChildFormNumber += 1;
                ChildForm.Text = "Project" + m_ChildFormNumber;
                ToolStripStatusLabel1.Text = "Loaded existing project from file (" + DateTime.Now.ToString("hh:mm:ss") + ")";
                ChildForm.Show();
                ActiveMdiChild.ActiveControl.Text = a.ReadToEnd();
                a.Close();
            }
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (object Ob in ActiveMdiChild.Controls)
            {
                RichTextBox rtb = (RichTextBox)Ob;
                rtb.SelectAll();
            }
        }
    }
}