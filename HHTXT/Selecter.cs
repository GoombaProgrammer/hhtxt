using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication1
{
    public partial class Selecter
    {
        public Selecter()
        {
            InitializeComponent();
        }

        private void Selecter_Load(object sender, EventArgs e)
        {
            foreach (Form i in MDIParent1.instance.MdiChildren)

                ListBox1.Items.Add(i.Text);
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var msg = Interaction.MsgBox(Operators.ConcatenateObject(Operators.ConcatenateObject("Do you want to save ", ListBox1.SelectedItem), "?"), MsgBoxStyle.YesNo);
            if (msg == MsgBoxResult.Yes)
            {
                if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    var sw = new System.IO.StreamWriter(SaveFileDialog1.FileName);
                    Interaction.MsgBox("You are in an unused form of HHTXT, please go to the main form");
                    Application.Exit();
                }
            }
        }
    }
}