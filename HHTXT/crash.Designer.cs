using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsApplication1
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class crash : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(crash));
            Timer1 = new Timer(components);
            Timer1.Tick += new EventHandler(Timer1_Tick);
            SuspendLayout();
            // 
            // Timer1
            // 
            Timer1.Interval = 1;
            // 
            // crash
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(837, 534);
            FormBorderStyle = FormBorderStyle.None;
            Name = "crash";
            ShowInTaskbar = false;
            Text = "crash";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            KeyUp += new KeyEventHandler(crash_KeyUp);
            Load += new EventHandler(crash_Load);
            ResumeLayout(false);

        }
        internal Timer Timer1;
    }
}