using BrowserCheck.Config;
using BrowserCheck.Controller;
using BrowserCheck.Model;
using Spire.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace BrowserCheck.Forms
{
    public partial class ChromeForm : Form
    {
        ChromeController chrome;
        List<KeywordSearchChrome> keywordList = new List<KeywordSearchChrome>();
        List<HistoryChrome> historyList = new List<HistoryChrome>();
        List<DownloadsChrome> downloadList = new List<DownloadsChrome>();
        List<AutoFillChrome> autofillList = new List<AutoFillChrome>();
        List<CookiesChrome> cookieList = new List<CookiesChrome>();
        List<TopSitesChrome> topSitesList = new List<TopSitesChrome>();
        static PdfController pdfController = new PdfController();
        PdfDocument doc = pdfController.create();
        PdfSection sec;
        PdfOperation setPdf = new PdfOperation();
        public ChromeForm(ChromeController chrome)
        {
            InitializeComponent();
            InitializeComboboxes();
            this.chrome = chrome;
        }

        private void ChromeForm_Load(object sender, EventArgs e)
        {
            nameLabel.Text = Global.Session.Instance.MyUser.Name;
            surnameLabel.Text = Global.Session.Instance.MyUser.Surname;
            emailLabel.Text = Global.Session.Instance.MyUser.Email;
            keywordList = chrome.getKeywords();
            keywordsGrid.DataSource = keywordList;
            historyList = chrome.getHistory();
            urlHistoryGrid.DataSource = historyList;
            downloadList = chrome.getDownloads();
            downloadsHistoryGrid.DataSource = downloadList;
            autofillList = chrome.getAutofill();
            autofillGrid.DataSource = autofillList;
            cookieList = chrome.getCookies();
            cookiesGrid.DataSource = cookieList;
            topSitesList = chrome.getTopSites();
            topsitesGrid.DataSource = topSitesList;


        }
        int counter = 0;

        private void reportNote_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (counter >= 60)
            {
                if ((char)e.KeyChar == ' ')
                {
                    counter = 0;
                    reportNote.AppendText(Environment.NewLine);
                }
            }
            if (Common.Common.Instance.IsDigitOrLetterOrSymbolOrSpace(e.KeyChar))
            {
                counter++;
            }
        }

        private void noForPhoto_CheckedChanged(object sender, EventArgs e)
        {
            addPicture.Enabled = false;
        }

        private void yesForPhoto_CheckedChanged(object sender, EventArgs e)
        {
            addPicture.Enabled = true;
        }

        private void addPicture_Click(object sender, EventArgs e)
        {
            openFilePicture.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFilePicture.InitialDirectory = @"C:\";
            openFilePicture.Title = "Please select an image file.";
            if (openFilePicture.ShowDialog() == DialogResult.OK)
            {
                profilePic.Load(openFilePicture.FileName);
            }
        }

        public void runCreatePdf(bool argument)
        {
            ProgressBarLoad progress = new ProgressBarLoad();
            progress.ShowDialog();
            bool controlForPhoto = pdfController.pdfIntro(doc, sec, reportNote.Text, profilePic.ImageLocation, reportNote.Lines.Length, argument);
            if (controlForPhoto)
            {
                pdfController.createPdf(doc, sec, keywordsGrid, 1, "Keyword History");
                pdfController.createPdf(doc, sec, urlHistoryGrid, 4, "Url History");
                pdfController.createPdf(doc, sec, downloadsHistoryGrid, 6, "Download History");
                pdfController.createPdf(doc, sec, autofillGrid, 5, "Autofill");
                pdfController.createPdf(doc, sec, cookiesGrid, 6, "Cookies");
                pdfController.createPdf(doc, sec, topsitesGrid, 3, "Top Sites");
                int check = setPdf.savePdf(doc, reportName.Text);
                if (check == 1)
                {
                    Exception.ThrowExc.Instance.InformationMessage(Const.Constants.REPORT_CREATED);
                    reportNote.Text = "";
                    reportName.Text = "";
                    this.Close();
                }
                else if (check == -1) Exception.ThrowExc.Instance.ErrorMessage(Const.Constants.REPORT_COULDNT_SAVED);
            }
            else
            {
                Exception.ThrowExc.Instance.ErrorMessage(Const.Constants.PICTURE_SIZE_ERROR);
                doc = null;
                doc = pdfController.create();
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            bool argument = true;
            if (yesForPhoto.Checked)
            {
                if (string.IsNullOrEmpty(profilePic.ImageLocation))
                {
                    Exception.ThrowExc.Instance.ErrorMessage(Const.Constants.NO_PHOTO);
                }
                else
                {

                    runCreatePdf(argument);
                }
            }
            else
            {

                runCreatePdf(!argument);
            }
        }

        private void keywordSearch_TextChanged(object sender, EventArgs e)
        {
            keywordsGrid.DataSource = keywordList.Where(x => x.Terms.Contains(keywordSearch.Text)).ToList(); 
        }

        private void urlSearch_TextChanged(object sender, EventArgs e)
        {
            urlHistoryGrid.DataSource = historyList.Where(x => x.Title.Contains(urlSearch.Text)).ToList();
        }

        private void downloadSearch_TextChanged(object sender, EventArgs e)
        {
            downloadsHistoryGrid.DataSource = downloadList.Where(x => x.TargetPath.Contains(downloadSearch.Text) 
            || x.Referer.Contains(downloadSearch.Text)
            ||x.MimeType.Contains(downloadSearch.Text)
            ||x.OriginalMimeType.Contains(downloadSearch.Text)).ToList();
        }

        private void autofillSearch_TextChanged(object sender, EventArgs e)
        {
            autofillGrid.DataSource = autofillList.Where(x => x.Name.Contains(autofillSearch.Text)
            ||x.Value.Contains(autofillSearch.Text)).ToList();
        }

        private void cookieSearch_TextChanged(object sender, EventArgs e)
        {
            cookiesGrid.DataSource = cookieList.Where(x => x.HostKey.Contains(cookieSearch.Text)
            || x.Name.Contains(cookieSearch.Text)
            || x.Value.Contains(cookieSearch.Text)
            || x.CookiePath.Contains(cookieSearch.Text)).ToList();
        }

        private void topsitesSearch_TextChanged(object sender, EventArgs e)
        {
            topsitesGrid.DataSource = topSitesList.Where(x => x.Title.Contains(topsitesSearch.Text) || x.Url.Contains(topsitesSearch.Text)).ToList();
        }

        private void sortKeyword_Click(object sender, EventArgs e)
        {
            keywordsGrid.DataSource = Common.Common.Instance.Sort_List<KeywordSearchChrome>(keywordAscDsc.SelectedItem.ToString(), "Terms", keywordList);
        }

        private void urlsSort_Click(object sender, EventArgs e)
        {
            urlHistoryGrid.DataSource = Common.Common.Instance.Sort_List<HistoryChrome>(urlsAscDsc.SelectedItem.ToString(), urlsCombo.SelectedItem.ToString(), historyList);
        }

        private void sortDownloads_Click(object sender, EventArgs e)
        {
            downloadsHistoryGrid.DataSource = Common.Common.Instance.Sort_List<DownloadsChrome>(downloadsAscDsc.SelectedItem.ToString(), downloadsCombo.SelectedItem.ToString(), downloadList);
        }

        private void sortAutofill_Click(object sender, EventArgs e)
        {
            autofillGrid.DataSource = Common.Common.Instance.Sort_List<AutoFillChrome>(autofillAscDsc.SelectedItem.ToString(), autofillCombo.SelectedItem.ToString(), autofillList);
        }

        private void sortCookies_Click(object sender, EventArgs e)
        {
            cookiesGrid.DataSource = Common.Common.Instance.Sort_List<CookiesChrome>(cookiesAscDsc.SelectedItem.ToString(), cookiesCombo.SelectedItem.ToString(), cookieList);
        }

        private void topsitesSort_Click(object sender, EventArgs e)
        {
            topsitesGrid.DataSource = Common.Common.Instance.Sort_List<TopSitesChrome>(topsitesAscDsc.SelectedItem.ToString(), topsitesCombo.SelectedItem.ToString(), topSitesList);
        }

        private void urlHistoryGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var send = (DataGridView)sender;
            if (send.Columns[e.ColumnIndex] is DataGridViewLinkColumn && e.RowIndex >= 0)
            {
                DataGridViewRow row = urlHistoryGrid.Rows[e.RowIndex];
                Process.Start("IExplore.exe", row.Cells[1].Value.ToString());

            }
        }
    }
}
