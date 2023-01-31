using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Macros : Form
    {
        public Macros()
        {
            InitializeComponent();
        }

        private void addNewMacroButton_Click(object sender, EventArgs e)
        {   
            Guid guid = Guid.NewGuid();
            MacroManager.Instance.macros.Add(new()
            {
                name = "New Macro",
                macroGuid = guid,
                code = "",
                trigger = MacroTrigger.ON_START
            });

            var f = new EditMacro(guid);
            f.Show();
        }

        private void Macros_Load(object sender, EventArgs e)
        {
            macrosListBox.DisplayMember = "Name";
            macrosListBox.DataSource = MacroManager.Instance.macros;
        }

        private void macrosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void macrosListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.macrosListBox.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                var f = new EditMacro(MacroManager.Instance.macros[index].macroGuid);
                f.Show();
            }
        }
    }
}
