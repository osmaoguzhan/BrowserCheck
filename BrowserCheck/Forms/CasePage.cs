using BrowserCheck.Controller;
using BrowserCheck.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowserCheck.Forms
{
    public partial class CasePage : Form
    {
        public CasePage()
        {
            InitializeComponent();
        }

        private void chooseDir_Click_1(object sender, EventArgs e)
        {
            if (firefoxRadio.Checked)
            {
                folderItem.RootFolder = Environment.SpecialFolder.ApplicationData;
            }
            else
            {
                folderItem.RootFolder = Environment.SpecialFolder.LocalApplicationData;
            }
            folderItem.ShowDialog();
            pathOfDir.Text = folderItem.SelectedPath;
         }

        private void scanButton_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pathOfDir.Text))
            {
                MessageBox.Show("Please choose a path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (firefoxRadio.Checked)
                {
                    MozillaController mozilla = new MozillaController();
                    mozilla.setPath(pathOfDir.Text);
                    MozillaForm mozillaForm = new MozillaForm(mozilla);
                    mozillaForm.Show();
                }
                else
                {
                    ChromeController chrome = new ChromeController();
                    chrome.setPath(pathOfDir.Text);
                    ChromeForm chromeForm = new ChromeForm(chrome);
                    chromeForm.Show();
                }
                this.Close();
            }
        }
    }
}
