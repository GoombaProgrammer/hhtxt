using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsApplication1
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Project : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Project));
            RichTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // RichTextBox1
            // 
            RichTextBox1.Dock = DockStyle.Fill;
            RichTextBox1.Location = new Point(0, 0);
            RichTextBox1.Name = "RichTextBox1";
            RichTextBox1.Size = new Size(403, 369);
            RichTextBox1.TabIndex = 0;
            RichTextBox1.Text = "";
            // 
            // Project
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 369);
            Controls.Add(RichTextBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Project";
            Text = "Project";
            FormClosed += new FormClosedEventHandler(Project_FormClosed);
            Load += new EventHandler(Project_Load);
            ResumeLayout(false);

        }
        internal RichTextBox RichTextBox1;
    }
}