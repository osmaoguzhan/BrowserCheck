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

        
        private void CasePage_Load(object sender, EventArgs e)
        {
            string[] dirs = { };
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            pathOfDir.Text = path + "\\Mozilla\\Firefox\\Profiles";
            dirs = checkDirsMozilla(pathOfDir.Text);
            DefaultPopup popup = new DefaultPopup(dirs);
            if (dirs.Length > 1)
            {
                if (popup.ShowDialog() == DialogResult.OK)
                {
                     pathOfDir.Text = popup.Path;
                }
            }
            else if(dirs.Length == 1)
            {
                pathOfDir.Text = dirs[0];
            }
            else
            {
                pathOfDir.Text = "";
            }
            
          

        }

        private string[] checkDirsMozilla(string path)
        {
            string[] dirs = { };
            try
            {
                dirs = Directory.GetDirectories(path, "*default*", SearchOption.TopDirectoryOnly);
            }
            catch
            {
                ;
            }
            return dirs;
        }

        private void chooseDir_Click_1(object sender, EventArgs e)
        {
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
                MozillaController mozilla = new MozillaController();
                mozilla.setPath(pathOfDir.Text);
                MozillaForm mozillaForm = new MozillaForm(mozilla);
                mozillaForm.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChromeController chrome= new ChromeController();
            chrome.setPath("C:\\Users\\VV\\AppData\\Local\\Google\\Chrome\\User Data\\Default\\History");
            ChromeForm chromeForm = new ChromeForm(chrome);
            chromeForm.Show();
            this.Close();
        }
    }
}
