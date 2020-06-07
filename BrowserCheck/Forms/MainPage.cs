using Spire.Pdf;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace BrowserCheck.Forms
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private static string yourRoot = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\Reports\\" + Global.Session.Instance.MyUser.Email;

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Global.Session.Instance.isLoggedIn == true)
            {
                Application.Exit();
            }

        }

        private void MainPage_Load_1(object sender, EventArgs e)
        {
            clock.Start();
            DateTime thisDay = DateTime.Today;
            labelDate.Text = thisDay.ToString("d");
            nameSurnameLabel.Text = Global.Session.Instance.MyUser.Name + " " + Global.Session.Instance.MyUser.Surname;
            if (Global.Session.Instance.isLoggedIn)
            {
                this.user.Text = Global.Session.Instance.MyUser.Name.Substring(0,1) + Global.Session.Instance.MyUser.Surname.Substring(0, 1);
                Color c2 = Color.FromKnownColor(KnownColor.AliceBlue);
                this.user.BackColor = c2;
            }
            if (Directory.Exists(yourRoot))
            {
                initTree();
            }

        }
        private void ListDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);
            treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        }

        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var file in directoryInfo.GetFiles())
                directoryNode.Nodes.Add(new TreeNode(file.Name));
            return directoryNode;
        }
        public PdfDocument pdf = new PdfDocument();
        private void treeViewReport_AfterSelect(object sender, TreeViewEventArgs e)
        {
            printPreviewControl1.Document = null;

            FileInfo oFileInfo;
            string finalDir = yourRoot + "\\..\\" + treeViewReport.SelectedNode.FullPath;
            if (!Directory.Exists(finalDir))
            {
                if (pdf.DocumentInformation != null)
                    pdf.Close();
                oFileInfo = new FileInfo(finalDir);
                label4.Text = "Report Name: " + oFileInfo.Name.ToString();
                label2.Text = "Report Creation Time: " + oFileInfo.CreationTimeUtc.ToString();
                label3.Text = "Report Last Access Time: " + oFileInfo.LastAccessTimeUtc.ToString();

                pdf.LoadFromFile(finalDir);
                printPreviewControl1.Rows = pdf.Pages.Count;
                pdf.Preview(this.printPreviewControl1);
                zoomIn.Enabled = true;
                zoomOut.Enabled = true;
                
                
            }
            else
            {
                printPreviewControl1.Document=null;
                zoomIn.Enabled = false;
                zoomOut.Enabled = false;
            }
          

        }

        private void zoomIn_Click(object sender, EventArgs e)
        {
            this.printPreviewControl1.Zoom += 0.15;
        }

        private void zoomOut_Click(object sender, EventArgs e)
        {
            if(!(this.printPreviewControl1.Zoom-0.15<=0))
                this.printPreviewControl1.Zoom -= 0.15;
            else
                MessageBox.Show("Should not be zoomed in more!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
 
       private void newCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCollection forms = Application.OpenForms;
            bool formAlreadyOpened = false;
            foreach (Form form in forms)
            {
                if (form.Name == "CasePage" || form.Name == "MozillaForm" || form.Name == "ChromeForm")
                {
                    formAlreadyOpened = true;
                }
            }
            if (formAlreadyOpened)
            {
                Exception.ThrowExc.Instance.ErrorMessage(Const.Constants.ALREADY_OPENED);
            }
            else
            {
                CasePage newCase = new CasePage();
                newCase.Show();
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Application.OpenForms[0].Show();
            Global.Session.Instance.clearSession();
            this.Close();             
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(yourRoot))
            {
               
                initTree();
            }
            else
            {
                Exception.ThrowExc.Instance.ErrorMessage(Const.Constants.NO_REPORT_FOUND);
            }
        }
        public void initTree()
        {
            Cursor.Current = Cursors.WaitCursor;
            ListDirectory(treeViewReport, yourRoot);
            Cursor.Current = Cursors.Default;
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString();
        }

        private void showFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", yourRoot);
        }
    }
}
