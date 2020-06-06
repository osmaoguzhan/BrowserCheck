using BrowserCheck.Controller;
using BrowserCheck.Model;
using System;
using System.Collections.Generic;
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
        public ChromeForm(ChromeController chrome)
        {
            InitializeComponent();
            this.chrome = chrome;
        }

        private void ChromeForm_Load(object sender, EventArgs e)
        {
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

        private void reportNote_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void printButton_Click(object sender, EventArgs e)
        {

        }
    }
}
