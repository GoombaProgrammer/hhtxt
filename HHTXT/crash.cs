using System;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class crash
    {
        public crash()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            BringToFront();
        }

        private void crash_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C)
            {
                Application.Exit();
            }
        }

        private void crash_Load(object sender, EventArgs e)
        {

        }
    }
}