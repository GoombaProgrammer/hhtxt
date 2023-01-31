using FastColoredTextBoxNS;
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
    public partial class EditMacro : Form
    {
        public Guid SelectedMacroId { get; set; }

        public Macro SelectedMacro => MacroManager.Instance.macros.FirstOrDefault(x => x.macroGuid == SelectedMacroId);

        public EditMacro(Guid macroId)
        {
            SelectedMacroId = macroId;
            InitializeComponent();
            fastColoredTextBox1.Language = Language.Lua;
        }

        private void EditMacro_Load(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = SelectedMacro.code;
            triggerSel.SelectedIndex = (int)SelectedMacro.trigger;
            macroNameInput.Text = SelectedMacro.name;
        }

        // save button
        private void button1_Click(object sender, EventArgs e)
        {
            SelectedMacro.name = macroNameInput.Text;
            SelectedMacro.code = fastColoredTextBox1.Text;
            SelectedMacro.trigger = (MacroTrigger)triggerSel.SelectedIndex;
            SelectedMacro.Recompile();
            MacroManager.Instance.SaveToJson();
            Close();
        }
    }
}
