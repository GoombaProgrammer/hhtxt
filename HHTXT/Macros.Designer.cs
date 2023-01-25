namespace WindowsApplication1
{
    partial class Macros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.macrosListBox = new System.Windows.Forms.ListBox();
            this.addNewMacroButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // macrosListBox
            // 
            this.macrosListBox.FormattingEnabled = true;
            this.macrosListBox.ItemHeight = 15;
            this.macrosListBox.Location = new System.Drawing.Point(12, 12);
            this.macrosListBox.Name = "macrosListBox";
            this.macrosListBox.Size = new System.Drawing.Size(241, 424);
            this.macrosListBox.TabIndex = 0;
            this.macrosListBox.SelectedIndexChanged += new System.EventHandler(this.macrosListBox_SelectedIndexChanged);
            this.macrosListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.macrosListBox_MouseDoubleClick);
            // 
            // addNewMacroButton
            // 
            this.addNewMacroButton.Location = new System.Drawing.Point(259, 12);
            this.addNewMacroButton.Name = "addNewMacroButton";
            this.addNewMacroButton.Size = new System.Drawing.Size(75, 23);
            this.addNewMacroButton.TabIndex = 1;
            this.addNewMacroButton.Text = "Add new";
            this.addNewMacroButton.UseVisualStyleBackColor = true;
            this.addNewMacroButton.Click += new System.EventHandler(this.addNewMacroButton_Click);
            // 
            // Macros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addNewMacroButton);
            this.Controls.Add(this.macrosListBox);
            this.Name = "Macros";
            this.Text = "Macros";
            this.Load += new System.EventHandler(this.Macros_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox macrosListBox;
        private System.Windows.Forms.Button addNewMacroButton;
    }
}