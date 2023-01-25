using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsApplication1
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class AboutBox1 : Form
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

        internal TableLayoutPanel TableLayoutPanel;
        internal PictureBox LogoPictureBox;
        internal Label LabelProductName;
        internal Label LabelVersion;
        internal Label LabelCompanyName;
        internal TextBox TextBoxDescription;
        internal Button OKButton;
        internal Label LabelCopyright;

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.LabelProductName = new System.Windows.Forms.Label();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.LabelCopyright = new System.Windows.Forms.Label();
            this.LabelCompanyName = new System.Windows.Forms.Label();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.TableLayoutPanel.Controls.Add(this.LogoPictureBox, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.LabelProductName, 1, 0);
            this.TableLayoutPanel.Controls.Add(this.LabelVersion, 1, 1);
            this.TableLayoutPanel.Controls.Add(this.LabelCopyright, 1, 2);
            this.TableLayoutPanel.Controls.Add(this.LabelCompanyName, 1, 3);
            this.TableLayoutPanel.Controls.Add(this.TextBoxDescription, 1, 4);
            this.TableLayoutPanel.Controls.Add(this.OKButton, 1, 5);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(10, 10);
            this.TableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 6;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(463, 299);
            this.TableLayoutPanel.TabIndex = 0;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoPictureBox.Location = new System.Drawing.Point(4, 4);
            this.LogoPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.TableLayoutPanel.SetRowSpan(this.LogoPictureBox, 6);
            this.LogoPictureBox.Size = new System.Drawing.Size(144, 291);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            // 
            // LabelProductName
            // 
            this.LabelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelProductName.Location = new System.Drawing.Point(159, 0);
            this.LabelProductName.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.LabelProductName.MaximumSize = new System.Drawing.Size(0, 20);
            this.LabelProductName.Name = "LabelProductName";
            this.LabelProductName.Size = new System.Drawing.Size(300, 20);
            this.LabelProductName.TabIndex = 0;
            this.LabelProductName.Text = "HHTXT";
            this.LabelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelVersion
            // 
            this.LabelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelVersion.Location = new System.Drawing.Point(159, 29);
            this.LabelVersion.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.LabelVersion.MaximumSize = new System.Drawing.Size(0, 20);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(300, 20);
            this.LabelVersion.TabIndex = 0;
            this.LabelVersion.Text = "1.0.0.0";
            this.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelCopyright
            // 
            this.LabelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelCopyright.Location = new System.Drawing.Point(159, 58);
            this.LabelCopyright.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.LabelCopyright.MaximumSize = new System.Drawing.Size(0, 20);
            this.LabelCopyright.Name = "LabelCopyright";
            this.LabelCopyright.Size = new System.Drawing.Size(300, 20);
            this.LabelCopyright.TabIndex = 0;
            this.LabelCopyright.Text = "(c) 2023 HHTXT Contributors";
            this.LabelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelCompanyName
            // 
            this.LabelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelCompanyName.Location = new System.Drawing.Point(159, 87);
            this.LabelCompanyName.Margin = new System.Windows.Forms.Padding(7, 0, 4, 0);
            this.LabelCompanyName.MaximumSize = new System.Drawing.Size(0, 20);
            this.LabelCompanyName.Name = "LabelCompanyName";
            this.LabelCompanyName.Size = new System.Drawing.Size(300, 20);
            this.LabelCompanyName.TabIndex = 0;
            this.LabelCompanyName.Text = "Ava/Imusing, GoldenretriverYT";
            this.LabelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxDescription.Location = new System.Drawing.Point(159, 120);
            this.TextBoxDescription.Margin = new System.Windows.Forms.Padding(7, 4, 4, 4);
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.ReadOnly = true;
            this.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBoxDescription.Size = new System.Drawing.Size(300, 141);
            this.TextBoxDescription.TabIndex = 0;
            this.TextBoxDescription.TabStop = false;
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OKButton.Location = new System.Drawing.Point(371, 270);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(88, 25);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "&OK";
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // AboutBox1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.OKButton;
            this.ClientSize = new System.Drawing.Size(483, 319);
            this.Controls.Add(this.TableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox1";
            this.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutBox1";
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

    }
}