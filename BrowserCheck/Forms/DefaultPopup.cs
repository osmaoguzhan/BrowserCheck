using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowserCheck.Forms
{
    public partial class DefaultPopup : Form
    {
        string[] dirs;
       private string path; public string Path { get { return path; } set { this.path = value; } }
       public DefaultPopup(string[] dirs)
        {
            InitializeComponent();
            this.dirs = dirs;
            addRadio();
            
        }
        private void addRadio()
        {
            int max = 0;
            for (int i = 0; i < dirs.Length; i++)
            {
                RadioButton rdo = new RadioButton();
                if (i == 0)
                {
                    rdo.Checked = true;
                }
                rdo.Name = "defalutRadio" + i;
                rdo.Text = dirs[i];
                rdo.Width = (TextRenderer.MeasureText(rdo.Text, rdo.Font)).Width + 20;
                rdo.Location = new Point(5, 30 * i);
                this.Controls.Add(rdo);
                if ((TextRenderer.MeasureText(rdo.Text, rdo.Font)).Width + 20 > max)
                {
                    max = rdo.Width;
                }
                okButton.Location = new Point(this.Size.Width / 2, 30 * i + 30);
            }
            this.Size = new Size(max + 30, (okButton.Location.Y) + okButton.Size.Height * 2 + 30);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            var checkedButton = this.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (checkedButton == null)
            {
                MessageBox.Show("Please choose a path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Path = checkedButton.Text;
            }
        }

    }
}
