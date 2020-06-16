using BrowserCheck.Controller;
using System;
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
 
            folderItem.RootFolder = Environment.SpecialFolder.MyComputer;
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
                    mozilla.SetPath(pathOfDir.Text);
                    MozillaForm mozillaForm = new MozillaForm(mozilla);
                    mozillaForm.Show();
                }
                else
                {
                    ChromeController chrome = new ChromeController();
                    chrome.SetPath(pathOfDir.Text);
                    ChromeForm chromeForm = new ChromeForm(chrome);
                    chromeForm.Show();
                }
                this.Close();
            }
        }
    }
}
