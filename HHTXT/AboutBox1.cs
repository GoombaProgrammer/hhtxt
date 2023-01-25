using System;

namespace WindowsApplication1
{
    public sealed partial class AboutBox1
    {
        public AboutBox1()
        {
            InitializeComponent();
        }
        private void OKButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}