using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsApplication1
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Selecter : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Selecter));
            ListBox1 = new ListBox();
            ListBox1.SelectedIndexChanged += new EventHandler(ListBox1_SelectedIndexChanged);
            SaveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // ListBox1
            // 
            ListBox1.FormattingEnabled = true;
            ListBox1.ItemHeight = 16;
            ListBox1.Location = new Point(12, 11);
            ListBox1.Name = "ListBox1";
            ListBox1.Size = new Size(205, 468);
            ListBox1.TabIndex = 0;
            // 
            // Selecter
            // 
            AutoScaleDimensions = new SizeF(8.0f, 16.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(229, 491);
            Controls.Add(ListBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Selecter";
            Text = "Selecter";
            Load += new EventHandler(Selecter_Load);
            ResumeLayout(false);

        }
        internal ListBox ListBox1;
        internal SaveFileDialog SaveFileDialog1;
    }
}