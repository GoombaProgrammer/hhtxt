using System;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Project
    {
        public Project()
        {
            InitializeComponent();
        }

        private void Project_FormClosed(object sender, FormClosedEventArgs e)
        {
            MDIParent1.instance.AmountOfProjects -= 1;
        }

        private void Project_Load(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            MacroManager.Instance.InvokeEvent(MacroTrigger.CONTENT_CHANGED);
        }
    }
}