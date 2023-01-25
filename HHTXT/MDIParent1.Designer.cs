using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsApplication1
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class MDIParent1 : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }


        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent1));
            MenuStrip = new MenuStrip();
            FileMenu = new ToolStripMenuItem();
            NewToolStripMenuItem = new ToolStripMenuItem();
            NewToolStripMenuItem.Click += new EventHandler(ShowNewForm);
            OpenToolStripMenuItem = new ToolStripMenuItem();
            OpenToolStripMenuItem.Click += new EventHandler(OpenFile);
            ToolStripSeparator3 = new ToolStripSeparator();
            SaveToolStripMenuItem = new ToolStripMenuItem();
            SaveToolStripMenuItem.Click += new EventHandler(SaveToolStripMenuItem_Click);
            SaveAsToolStripMenuItem = new ToolStripMenuItem();
            SaveAsToolStripMenuItem.Click += new EventHandler(SaveAsToolStripMenuItem_Click);
            ToolStripSeparator4 = new ToolStripSeparator();
            PrintToolStripMenuItem = new ToolStripMenuItem();
            PrintToolStripMenuItem.Click += new EventHandler(PrintToolStripMenuItem_Click);
            PrintPreviewToolStripMenuItem = new ToolStripMenuItem();
            PrintPreviewToolStripMenuItem.Click += new EventHandler(PrintPreviewToolStripMenuItem_Click);
            PrintSetupToolStripMenuItem = new ToolStripMenuItem();
            ToolStripSeparator5 = new ToolStripSeparator();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            ExitToolStripMenuItem.Click += new EventHandler(ExitToolsStripMenuItem_Click);
            EditMenu = new ToolStripMenuItem();
            EditMenu.Click += new EventHandler(EditMenu_Click);
            UndoToolStripMenuItem = new ToolStripMenuItem();
            UndoToolStripMenuItem.Click += new EventHandler(UndoToolStripMenuItem_Click);
            RedoToolStripMenuItem = new ToolStripMenuItem();
            ToolStripSeparator6 = new ToolStripSeparator();
            CutToolStripMenuItem = new ToolStripMenuItem();
            CutToolStripMenuItem.Click += new EventHandler(CutToolStripMenuItem_Click);
            CopyToolStripMenuItem = new ToolStripMenuItem();
            CopyToolStripMenuItem.Click += new EventHandler(CopyToolStripMenuItem_Click);
            PasteToolStripMenuItem = new ToolStripMenuItem();
            PasteToolStripMenuItem.Click += new EventHandler(PasteToolStripMenuItem_Click);
            ToolStripSeparator7 = new ToolStripSeparator();
            SelectAllToolStripMenuItem = new ToolStripMenuItem();
            SelectAllToolStripMenuItem.Click += new EventHandler(SelectAllToolStripMenuItem_Click);
            ViewMenu = new ToolStripMenuItem();
            ToolBarToolStripMenuItem = new ToolStripMenuItem();
            ToolBarToolStripMenuItem.Click += new EventHandler(ToolBarToolStripMenuItem_Click);
            StatusBarToolStripMenuItem = new ToolStripMenuItem();
            StatusBarToolStripMenuItem.Click += new EventHandler(StatusBarToolStripMenuItem_Click);
            ToolsMenu = new ToolStripMenuItem();
            SelectEncodingToolStripMenuItem = new ToolStripMenuItem();
            UTF8ToolStripMenuItem = new ToolStripMenuItem();
            UTF32ToolStripMenuItem = new ToolStripMenuItem();
            PrintFontToolStripMenuItem = new ToolStripMenuItem();
            PrintFontToolStripMenuItem.Click += new EventHandler(PrintFontToolStripMenuItem_Click);
            HelpMeToolStripMenuItem = new ToolStripMenuItem();
            HelpMeToolStripMenuItem.Click += new EventHandler(HelpMeToolStripMenuItem_Click);
            ProjectToolStripMenuItem = new ToolStripMenuItem();
            DeleteToolStripMenuItem = new ToolStripMenuItem();
            DeleteToolStripMenuItem.Click += new EventHandler(DeleteToolStripMenuItem_Click);
            CloseToolStripMenuItem = new ToolStripMenuItem();
            CloseToolStripMenuItem.Click += new EventHandler(CloseToolStripMenuItem_Click);
            ToolStrip = new ToolStrip();
            NewToolStripButton = new ToolStripButton();
            NewToolStripButton.Click += new EventHandler(ShowNewForm);
            OpenToolStripButton = new ToolStripButton();
            OpenToolStripButton.Click += new EventHandler(OpenFile);
            SaveToolStripButton = new ToolStripButton();
            SaveToolStripButton.Click += new EventHandler(SaveToolStripButton_Click);
            ToolStripSeparator1 = new ToolStripSeparator();
            PrintToolStripButton = new ToolStripButton();
            PrintToolStripButton.Click += new EventHandler(PrintToolStripButton_Click);
            PrintPreviewToolStripButton = new ToolStripButton();
            PrintPreviewToolStripButton.Click += new EventHandler(PrintPreviewToolStripButton_Click);
            ToolStripSeparator2 = new ToolStripSeparator();
            HelpToolStripButton = new ToolStripButton();
            HelpToolStripButton.Click += new EventHandler(HelpToolStripButton_Click);
            ToolStripButton1 = new ToolStripButton();
            ToolStripButton1.Click += new EventHandler(ToolStripButton1_Click);
            ToolStripLabel1 = new ToolStripLabel();
            StatusStrip = new StatusStrip();
            ToolStripStatusLabel = new ToolStripStatusLabel();
            ToolStripStatusLabel1 = new ToolStripStatusLabel();
            ToolTip = new ToolTip(components);
            SaveFileDialog1 = new SaveFileDialog();
            PrintPreviewDialog1 = new PrintPreviewDialog();
            PrintDocument1 = new System.Drawing.Printing.PrintDocument();
            PrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(PrintDocument1_PrintPage);
            PrintDocument2 = new System.Drawing.Printing.PrintDocument();
            PrintDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(PrintDocument2_PrintPage);
            Timer1 = new Timer(components);
            Timer1.Tick += new EventHandler(Timer1_Tick);
            FontDialog1 = new FontDialog();
            Label1 = new Label();
            Label1.Click += new EventHandler(Label1_Click);
            MainMenu1 = new System.Windows.Forms.MenuStrip();
            
            MenuStrip.SuspendLayout();
            ToolStrip.SuspendLayout();
            StatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MenuStrip
            // 
            MenuStrip.Items.AddRange(new ToolStripItem[] { FileMenu, EditMenu, ViewMenu, ToolsMenu, ProjectToolStripMenuItem });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Padding = new Padding(8, 2, 0, 2);
            MenuStrip.Size = new Size(843, 28);
            MenuStrip.TabIndex = 5;
            MenuStrip.Text = "MenuStrip";
            // 
            // FileMenu
            // 
            FileMenu.DropDownItems.AddRange(new ToolStripItem[] { NewToolStripMenuItem, OpenToolStripMenuItem, ToolStripSeparator3, SaveToolStripMenuItem, SaveAsToolStripMenuItem, ToolStripSeparator4, PrintToolStripMenuItem, PrintPreviewToolStripMenuItem, PrintSetupToolStripMenuItem, ToolStripSeparator5, ExitToolStripMenuItem });
            FileMenu.ImageTransparentColor = SystemColors.ActiveBorder;
            FileMenu.Name = "FileMenu";
            FileMenu.Size = new Size(44, 24);
            FileMenu.Text = "&File";
            // 
            // NewToolStripMenuItem
            // 
            NewToolStripMenuItem.Image = (Image)resources.GetObject("NewToolStripMenuItem.Image");
            NewToolStripMenuItem.ImageTransparentColor = Color.Black;
            NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            NewToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            NewToolStripMenuItem.Size = new Size(167, 24);
            NewToolStripMenuItem.Text = "&New";
            // 
            // OpenToolStripMenuItem
            // 
            OpenToolStripMenuItem.Image = (Image)resources.GetObject("OpenToolStripMenuItem.Image");
            OpenToolStripMenuItem.ImageTransparentColor = Color.Black;
            OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            OpenToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            OpenToolStripMenuItem.Size = new Size(167, 24);
            OpenToolStripMenuItem.Text = "&Open";
            // 
            // ToolStripSeparator3
            // 
            ToolStripSeparator3.Name = "ToolStripSeparator3";
            ToolStripSeparator3.Size = new Size(164, 6);
            // 
            // SaveToolStripMenuItem
            // 
            SaveToolStripMenuItem.Image = (Image)resources.GetObject("SaveToolStripMenuItem.Image");
            SaveToolStripMenuItem.ImageTransparentColor = Color.Black;
            SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            SaveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            SaveToolStripMenuItem.Size = new Size(167, 24);
            SaveToolStripMenuItem.Text = "&Save";
            // 
            // SaveAsToolStripMenuItem
            // 
            SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            SaveAsToolStripMenuItem.Size = new Size(167, 24);
            SaveAsToolStripMenuItem.Text = "Save &As";
            // 
            // ToolStripSeparator4
            // 
            ToolStripSeparator4.Name = "ToolStripSeparator4";
            ToolStripSeparator4.Size = new Size(164, 6);
            // 
            // PrintToolStripMenuItem
            // 
            PrintToolStripMenuItem.Image = (Image)resources.GetObject("PrintToolStripMenuItem.Image");
            PrintToolStripMenuItem.ImageTransparentColor = Color.Black;
            PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
            PrintToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            PrintToolStripMenuItem.Size = new Size(167, 24);
            PrintToolStripMenuItem.Text = "&Print";
            // 
            // PrintPreviewToolStripMenuItem
            // 
            PrintPreviewToolStripMenuItem.Image = (Image)resources.GetObject("PrintPreviewToolStripMenuItem.Image");
            PrintPreviewToolStripMenuItem.ImageTransparentColor = Color.Black;
            PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem";
            PrintPreviewToolStripMenuItem.Size = new Size(167, 24);
            PrintPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // PrintSetupToolStripMenuItem
            // 
            PrintSetupToolStripMenuItem.Name = "PrintSetupToolStripMenuItem";
            PrintSetupToolStripMenuItem.Size = new Size(167, 24);
            PrintSetupToolStripMenuItem.Text = "Print Setup";
            // 
            // ToolStripSeparator5
            // 
            ToolStripSeparator5.Name = "ToolStripSeparator5";
            ToolStripSeparator5.Size = new Size(164, 6);
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(167, 24);
            ExitToolStripMenuItem.Text = "E&xit";
            // 
            // EditMenu
            // 
            EditMenu.DropDownItems.AddRange(new ToolStripItem[] { UndoToolStripMenuItem, RedoToolStripMenuItem, ToolStripSeparator6, CutToolStripMenuItem, CopyToolStripMenuItem, PasteToolStripMenuItem, ToolStripSeparator7, SelectAllToolStripMenuItem });
            EditMenu.Name = "EditMenu";
            EditMenu.Size = new Size(47, 24);
            EditMenu.Text = "&Edit";
            // 
            // UndoToolStripMenuItem
            // 
            UndoToolStripMenuItem.Image = (Image)resources.GetObject("UndoToolStripMenuItem.Image");
            UndoToolStripMenuItem.ImageTransparentColor = Color.Black;
            UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
            UndoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            UndoToolStripMenuItem.Size = new Size(192, 24);
            UndoToolStripMenuItem.Text = "&Undo";
            // 
            // RedoToolStripMenuItem
            // 
            RedoToolStripMenuItem.Image = (Image)resources.GetObject("RedoToolStripMenuItem.Image");
            RedoToolStripMenuItem.ImageTransparentColor = Color.Black;
            RedoToolStripMenuItem.Name = "RedoToolStripMenuItem";
            RedoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            RedoToolStripMenuItem.Size = new Size(192, 24);
            RedoToolStripMenuItem.Text = "&Redo";
            // 
            // ToolStripSeparator6
            // 
            ToolStripSeparator6.Name = "ToolStripSeparator6";
            ToolStripSeparator6.Size = new Size(189, 6);
            // 
            // CutToolStripMenuItem
            // 
            CutToolStripMenuItem.Image = (Image)resources.GetObject("CutToolStripMenuItem.Image");
            CutToolStripMenuItem.ImageTransparentColor = Color.Black;
            CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            CutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            CutToolStripMenuItem.Size = new Size(192, 24);
            CutToolStripMenuItem.Text = "Cu&t";
            // 
            // CopyToolStripMenuItem
            // 
            CopyToolStripMenuItem.Image = (Image)resources.GetObject("CopyToolStripMenuItem.Image");
            CopyToolStripMenuItem.ImageTransparentColor = Color.Black;
            CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            CopyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            CopyToolStripMenuItem.Size = new Size(192, 24);
            CopyToolStripMenuItem.Text = "&Copy";
            // 
            // PasteToolStripMenuItem
            // 
            PasteToolStripMenuItem.Image = (Image)resources.GetObject("PasteToolStripMenuItem.Image");
            PasteToolStripMenuItem.ImageTransparentColor = Color.Black;
            PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            PasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            PasteToolStripMenuItem.Size = new Size(192, 24);
            PasteToolStripMenuItem.Text = "&Paste";
            // 
            // ToolStripSeparator7
            // 
            ToolStripSeparator7.Name = "ToolStripSeparator7";
            ToolStripSeparator7.Size = new Size(189, 6);
            // 
            // SelectAllToolStripMenuItem
            // 
            SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem";
            SelectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            SelectAllToolStripMenuItem.Size = new Size(192, 24);
            SelectAllToolStripMenuItem.Text = "Select &All";
            // 
            // ViewMenu
            // 
            ViewMenu.DropDownItems.AddRange(new ToolStripItem[] { ToolBarToolStripMenuItem, StatusBarToolStripMenuItem });
            ViewMenu.Name = "ViewMenu";
            ViewMenu.Size = new Size(53, 24);
            ViewMenu.Text = "&View";
            // 
            // ToolBarToolStripMenuItem
            // 
            ToolBarToolStripMenuItem.Checked = true;
            ToolBarToolStripMenuItem.CheckOnClick = true;
            ToolBarToolStripMenuItem.CheckState = CheckState.Checked;
            ToolBarToolStripMenuItem.Name = "ToolBarToolStripMenuItem";
            ToolBarToolStripMenuItem.Size = new Size(152, 24);
            ToolBarToolStripMenuItem.Text = "&Toolbar";
            // 
            // StatusBarToolStripMenuItem
            // 
            StatusBarToolStripMenuItem.Checked = true;
            StatusBarToolStripMenuItem.CheckOnClick = true;
            StatusBarToolStripMenuItem.CheckState = CheckState.Checked;
            StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem";
            StatusBarToolStripMenuItem.Size = new Size(152, 24);
            StatusBarToolStripMenuItem.Text = "&Status Bar";
            // 
            // ToolsMenu
            // 
            ToolsMenu.DropDownItems.AddRange(new ToolStripItem[] { SelectEncodingToolStripMenuItem, PrintFontToolStripMenuItem, HelpMeToolStripMenuItem });
            ToolsMenu.Name = "ToolsMenu";
            ToolsMenu.Size = new Size(56, 24);
            ToolsMenu.Text = "&Tools";
            // 
            // SelectEncodingToolStripMenuItem
            // 
            SelectEncodingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { UTF8ToolStripMenuItem, UTF32ToolStripMenuItem });
            SelectEncodingToolStripMenuItem.Name = "SelectEncodingToolStripMenuItem";
            SelectEncodingToolStripMenuItem.Size = new Size(184, 24);
            SelectEncodingToolStripMenuItem.Text = "Select Encoding";
            // 
            // UTF8ToolStripMenuItem
            // 
            UTF8ToolStripMenuItem.Name = "UTF8ToolStripMenuItem";
            UTF8ToolStripMenuItem.Size = new Size(125, 24);
            UTF8ToolStripMenuItem.Text = "UTF-8";
            // 
            // UTF32ToolStripMenuItem
            // 
            UTF32ToolStripMenuItem.Name = "UTF32ToolStripMenuItem";
            UTF32ToolStripMenuItem.Size = new Size(125, 24);
            UTF32ToolStripMenuItem.Text = "UTF-32";
            // 
            // PrintFontToolStripMenuItem
            // 
            PrintFontToolStripMenuItem.Name = "PrintFontToolStripMenuItem";
            PrintFontToolStripMenuItem.Size = new Size(184, 24);
            PrintFontToolStripMenuItem.Text = "Print Font...";
            // 
            // HelpMeToolStripMenuItem
            // 
            HelpMeToolStripMenuItem.Name = "HelpMeToolStripMenuItem";
            HelpMeToolStripMenuItem.Size = new Size(184, 24);
            HelpMeToolStripMenuItem.Text = "Help Me";
            // 
            // ProjectToolStripMenuItem
            // 
            ProjectToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DeleteToolStripMenuItem, CloseToolStripMenuItem });
            ProjectToolStripMenuItem.Name = "ProjectToolStripMenuItem";
            ProjectToolStripMenuItem.Size = new Size(73, 24);
            ProjectToolStripMenuItem.Text = "Projects";
            // 
            // DeleteToolStripMenuItem
            // 
            DeleteToolStripMenuItem.Image = (Image)resources.GetObject("DeleteToolStripMenuItem.Image");
            DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            DeleteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.M;
            DeleteToolStripMenuItem.Size = new Size(171, 24);
            DeleteToolStripMenuItem.Text = "&Clone";
            // 
            // CloseToolStripMenuItem
            // 
            CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            CloseToolStripMenuItem.Size = new Size(171, 24);
            CloseToolStripMenuItem.Text = "Close";
            // 
            // ToolStrip
            // 
            ToolStrip.Items.AddRange(new ToolStripItem[] { NewToolStripButton, OpenToolStripButton, SaveToolStripButton, ToolStripSeparator1, PrintToolStripButton, PrintPreviewToolStripButton, ToolStripSeparator2, HelpToolStripButton, ToolStripButton1, ToolStripLabel1 });
            ToolStrip.Location = new Point(0, 28);
            ToolStrip.Name = "ToolStrip";
            ToolStrip.Size = new Size(843, 25);
            ToolStrip.TabIndex = 6;
            ToolStrip.Text = "ToolStrip";
            // 
            // NewToolStripButton
            // 
            NewToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            NewToolStripButton.Image = (Image)resources.GetObject("NewToolStripButton.Image");
            NewToolStripButton.ImageTransparentColor = Color.Black;
            NewToolStripButton.Name = "NewToolStripButton";
            NewToolStripButton.Size = new Size(23, 22);
            NewToolStripButton.Text = "New";
            // 
            // OpenToolStripButton
            // 
            OpenToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            OpenToolStripButton.Image = (Image)resources.GetObject("OpenToolStripButton.Image");
            OpenToolStripButton.ImageTransparentColor = Color.Black;
            OpenToolStripButton.Name = "OpenToolStripButton";
            OpenToolStripButton.Size = new Size(23, 22);
            OpenToolStripButton.Text = "Open";
            // 
            // SaveToolStripButton
            // 
            SaveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            SaveToolStripButton.Image = (Image)resources.GetObject("SaveToolStripButton.Image");
            SaveToolStripButton.ImageTransparentColor = Color.Black;
            SaveToolStripButton.Name = "SaveToolStripButton";
            SaveToolStripButton.Size = new Size(23, 22);
            SaveToolStripButton.Text = "Save";
            // 
            // ToolStripSeparator1
            // 
            ToolStripSeparator1.Name = "ToolStripSeparator1";
            ToolStripSeparator1.Size = new Size(6, 25);
            // 
            // PrintToolStripButton
            // 
            PrintToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            PrintToolStripButton.Image = (Image)resources.GetObject("PrintToolStripButton.Image");
            PrintToolStripButton.ImageTransparentColor = Color.Black;
            PrintToolStripButton.Name = "PrintToolStripButton";
            PrintToolStripButton.Size = new Size(23, 22);
            PrintToolStripButton.Text = "Print";
            // 
            // PrintPreviewToolStripButton
            // 
            PrintPreviewToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            PrintPreviewToolStripButton.Image = (Image)resources.GetObject("PrintPreviewToolStripButton.Image");
            PrintPreviewToolStripButton.ImageTransparentColor = Color.Black;
            PrintPreviewToolStripButton.Name = "PrintPreviewToolStripButton";
            PrintPreviewToolStripButton.Size = new Size(23, 22);
            PrintPreviewToolStripButton.Text = "Print Preview";
            // 
            // ToolStripSeparator2
            // 
            ToolStripSeparator2.Name = "ToolStripSeparator2";
            ToolStripSeparator2.Size = new Size(6, 25);
            // 
            // HelpToolStripButton
            // 
            HelpToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            HelpToolStripButton.Image = (Image)resources.GetObject("HelpToolStripButton.Image");
            HelpToolStripButton.ImageTransparentColor = Color.Black;
            HelpToolStripButton.Name = "HelpToolStripButton";
            HelpToolStripButton.Size = new Size(23, 22);
            HelpToolStripButton.Text = "Help";
            // 
            // ToolStripButton1
            // 
            ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton1.Image = (Image)resources.GetObject("ToolStripButton1.Image");
            ToolStripButton1.ImageTransparentColor = Color.Magenta;
            ToolStripButton1.Name = "ToolStripButton1";
            ToolStripButton1.Size = new Size(23, 22);
            ToolStripButton1.Text = "Print All";
            // 
            // ToolStripLabel1
            // 
            ToolStripLabel1.Name = "ToolStripLabel1";
            ToolStripLabel1.Size = new Size(73, 22);
            ToolStripLabel1.Text = "0 Projects";
            // 
            // StatusStrip
            // 
            StatusStrip.Items.AddRange(new ToolStripItem[] { ToolStripStatusLabel, ToolStripStatusLabel1 });
            StatusStrip.Location = new Point(0, 533);
            StatusStrip.Name = "StatusStrip";
            StatusStrip.Padding = new Padding(1, 0, 19, 0);
            StatusStrip.Size = new Size(843, 25);
            StatusStrip.TabIndex = 7;
            StatusStrip.Text = "StatusStrip";
            // 
            // ToolStripStatusLabel
            // 
            ToolStripStatusLabel.Name = "ToolStripStatusLabel";
            ToolStripStatusLabel.Size = new Size(52, 20);
            ToolStripStatusLabel.Text = "Status:";
            // 
            // ToolStripStatusLabel1
            // 
            ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            ToolStripStatusLabel1.Size = new Size(127, 20);
            ToolStripStatusLabel1.Text = " Opened Program";
            // 
            // SaveFileDialog1
            // 
            SaveFileDialog1.Filter = "Custom|*.*|Text Files|*.txt|CreeperTXT Files|*.crtxt";
            // 
            // PrintPreviewDialog1
            // 
            PrintPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            PrintPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            PrintPreviewDialog1.ClientSize = new Size(400, 300);
            PrintPreviewDialog1.Enabled = true;
            PrintPreviewDialog1.Icon = (Icon)resources.GetObject("PrintPreviewDialog1.Icon");
            PrintPreviewDialog1.Name = "PrintPreviewDialog1";
            PrintPreviewDialog1.ShowIcon = false;
            PrintPreviewDialog1.Visible = false;
            // 
            // PrintDocument1
            // 
            // 
            // PrintDocument2
            // 
            // 
            // Timer1
            // 
            Timer1.Enabled = true;
            Timer1.Interval = 10;
            // 
            // FontDialog1
            // 
            FontDialog1.Font = new Font("Arial", 16.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(819, 9);
            Label1.Name = "Label1";
            Label1.Size = new Size(12, 17);
            Label1.TabIndex = 9;
            Label1.Text = " ";
            // 
            // MDIParent1
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 558);
            Controls.Add(Label1);
            Controls.Add(ToolStrip);
            Controls.Add(MenuStrip);
            Controls.Add(StatusStrip);
            Cursor = Cursors.Default;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = MenuStrip;
            Margin = new Padding(4);
            this.MainMenuStrip = MainMenu1;
            Name = "MDIParent1";
            Text = "HHTXT - Free Text Editor";
            WindowState = FormWindowState.Maximized;
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ToolStrip.ResumeLayout(false);
            ToolStrip.PerformLayout();
            StatusStrip.ResumeLayout(false);
            StatusStrip.PerformLayout();
            FormClosing += new FormClosingEventHandler(MDIParent1_FormClosing);
            Load += new EventHandler(MDIParent1_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal ToolStripButton HelpToolStripButton;
        internal ToolStripSeparator ToolStripSeparator2;
        internal ToolStripButton PrintPreviewToolStripButton;
        internal ToolTip ToolTip;
        internal ToolStripStatusLabel ToolStripStatusLabel;
        internal StatusStrip StatusStrip;
        internal ToolStripButton PrintToolStripButton;
        internal ToolStripButton NewToolStripButton;
        internal ToolStrip ToolStrip;
        internal ToolStripButton OpenToolStripButton;
        internal ToolStripButton SaveToolStripButton;
        internal ToolStripSeparator ToolStripSeparator1;
        internal ToolStripMenuItem PrintPreviewToolStripMenuItem;
        internal ToolStripMenuItem PrintToolStripMenuItem;
        internal ToolStripSeparator ToolStripSeparator4;
        internal ToolStripMenuItem ExitToolStripMenuItem;
        internal ToolStripSeparator ToolStripSeparator5;
        internal ToolStripMenuItem PrintSetupToolStripMenuItem;
        internal ToolStripMenuItem SaveAsToolStripMenuItem;
        internal ToolStripMenuItem NewToolStripMenuItem;
        internal ToolStripMenuItem FileMenu;
        internal ToolStripMenuItem OpenToolStripMenuItem;
        internal ToolStripSeparator ToolStripSeparator3;
        internal ToolStripMenuItem SaveToolStripMenuItem;
        internal MenuStrip MenuStrip;
        internal ToolStripMenuItem EditMenu;
        internal ToolStripMenuItem UndoToolStripMenuItem;
        internal ToolStripMenuItem RedoToolStripMenuItem;
        internal ToolStripSeparator ToolStripSeparator6;
        internal ToolStripMenuItem CutToolStripMenuItem;
        internal ToolStripMenuItem CopyToolStripMenuItem;
        internal ToolStripMenuItem PasteToolStripMenuItem;
        internal ToolStripSeparator ToolStripSeparator7;
        internal ToolStripMenuItem SelectAllToolStripMenuItem;
        internal ToolStripMenuItem ViewMenu;
        internal ToolStripMenuItem ToolBarToolStripMenuItem;
        internal ToolStripMenuItem StatusBarToolStripMenuItem;
        internal ToolStripMenuItem ToolsMenu;
        internal ToolStripMenuItem SelectEncodingToolStripMenuItem;
        internal ToolStripMenuItem UTF8ToolStripMenuItem;
        internal ToolStripMenuItem UTF32ToolStripMenuItem;
        internal SaveFileDialog SaveFileDialog1;
        internal PrintPreviewDialog PrintPreviewDialog1;
        internal System.Drawing.Printing.PrintDocument PrintDocument1;
        internal ToolStripButton ToolStripButton1;
        internal System.Drawing.Printing.PrintDocument PrintDocument2;
        internal ToolStripLabel ToolStripLabel1;
        internal Timer Timer1;
        internal ToolStripMenuItem PrintFontToolStripMenuItem;
        internal FontDialog FontDialog1;
        internal ToolStripStatusLabel ToolStripStatusLabel1;
        internal ToolStripMenuItem HelpMeToolStripMenuItem;
        internal ToolStripMenuItem ProjectToolStripMenuItem;
        internal ToolStripMenuItem DeleteToolStripMenuItem;
        internal ToolStripMenuItem CloseToolStripMenuItem;
        internal Label Label1;
        internal System.Windows.Forms.MenuStrip MainMenu1;

    }
}