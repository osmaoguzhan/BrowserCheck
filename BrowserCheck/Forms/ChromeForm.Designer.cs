namespace BrowserCheck.Forms
{
    partial class ChromeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChromeForm));
            this.chromeTabControl = new System.Windows.Forms.TabControl();
            this.keywordHistoryTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.sortKeyword = new System.Windows.Forms.Button();
            this.keywordAscDsc = new System.Windows.Forms.ComboBox();
            this.keywordSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.keywordsGrid = new System.Windows.Forms.DataGridView();
            this.addToReportKeyword = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.urlHistoryTab = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.urlsCombo = new System.Windows.Forms.ComboBox();
            this.urlsSort = new System.Windows.Forms.Button();
            this.urlsAscDsc = new System.Windows.Forms.ComboBox();
            this.urlSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.urlHistoryGrid = new System.Windows.Forms.DataGridView();
            this.addToReportHistory = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.downloadHistory = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.downloadsCombo = new System.Windows.Forms.ComboBox();
            this.sortDownloads = new System.Windows.Forms.Button();
            this.downloadsAscDsc = new System.Windows.Forms.ComboBox();
            this.downloadSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.downloadsHistoryGrid = new System.Windows.Forms.DataGridView();
            this.Referer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addToReportDownloads = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.autofillTab = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.autofillCombo = new System.Windows.Forms.ComboBox();
            this.sortAutofill = new System.Windows.Forms.Button();
            this.autofillAscDsc = new System.Windows.Forms.ComboBox();
            this.autofillSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.autofillGrid = new System.Windows.Forms.DataGridView();
            this.addToReportAutofill = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cookiesTab = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.cookiesCombo = new System.Windows.Forms.ComboBox();
            this.sortCookies = new System.Windows.Forms.Button();
            this.cookiesAscDsc = new System.Windows.Forms.ComboBox();
            this.cookieSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cookiesGrid = new System.Windows.Forms.DataGridView();
            this.addToReportCookie = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.topSites = new System.Windows.Forms.TabPage();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.topsitesCombo = new System.Windows.Forms.ComboBox();
            this.topsitesSort = new System.Windows.Forms.Button();
            this.topsitesAscDsc = new System.Windows.Forms.ComboBox();
            this.topsitesSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.topsitesGrid = new System.Windows.Forms.DataGridView();
            this.addToReportTopSites = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.printPdf = new System.Windows.Forms.TabPage();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.printButton = new System.Windows.Forms.Button();
            this.imageListButton = new System.Windows.Forms.ImageList(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.reportName = new System.Windows.Forms.TextBox();
            this.reportNote = new System.Windows.Forms.RichTextBox();
            this.addPicture = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.noForPhoto = new System.Windows.Forms.RadioButton();
            this.yesForPhoto = new System.Windows.Forms.RadioButton();
            this.evidenceNumber = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.openFilePicture = new System.Windows.Forms.OpenFileDialog();
            this.termsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keywordSearchChromeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastVisitTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitDurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historyChromeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.targetPathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mimeTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originalMimeTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.downloadsChromeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateLastUsedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoFillChromeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.creationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cookiePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cookiesChromeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlRankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topSitesChromeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chromeTabControl.SuspendLayout();
            this.keywordHistoryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keywordsGrid)).BeginInit();
            this.urlHistoryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urlHistoryGrid)).BeginInit();
            this.downloadHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.downloadsHistoryGrid)).BeginInit();
            this.autofillTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autofillGrid)).BeginInit();
            this.cookiesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cookiesGrid)).BeginInit();
            this.topSites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topsitesGrid)).BeginInit();
            this.printPdf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keywordSearchChromeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyChromeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downloadsChromeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoFillChromeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cookiesChromeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topSitesChromeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chromeTabControl
            // 
            this.chromeTabControl.Controls.Add(this.keywordHistoryTab);
            this.chromeTabControl.Controls.Add(this.urlHistoryTab);
            this.chromeTabControl.Controls.Add(this.downloadHistory);
            this.chromeTabControl.Controls.Add(this.autofillTab);
            this.chromeTabControl.Controls.Add(this.cookiesTab);
            this.chromeTabControl.Controls.Add(this.topSites);
            this.chromeTabControl.Controls.Add(this.printPdf);
            this.chromeTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromeTabControl.Location = new System.Drawing.Point(0, 0);
            this.chromeTabControl.Name = "chromeTabControl";
            this.chromeTabControl.SelectedIndex = 0;
            this.chromeTabControl.Size = new System.Drawing.Size(1067, 611);
            this.chromeTabControl.TabIndex = 0;
            // 
            // keywordHistoryTab
            // 
            this.keywordHistoryTab.Controls.Add(this.splitContainer1);
            this.keywordHistoryTab.Location = new System.Drawing.Point(4, 22);
            this.keywordHistoryTab.Name = "keywordHistoryTab";
            this.keywordHistoryTab.Padding = new System.Windows.Forms.Padding(3);
            this.keywordHistoryTab.Size = new System.Drawing.Size(1059, 585);
            this.keywordHistoryTab.TabIndex = 0;
            this.keywordHistoryTab.Text = "Keyword History";
            this.keywordHistoryTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.sortKeyword);
            this.splitContainer1.Panel1.Controls.Add(this.keywordAscDsc);
            this.splitContainer1.Panel1.Controls.Add(this.keywordSearch);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.keywordsGrid);
            this.splitContainer1.Size = new System.Drawing.Size(1053, 579);
            this.splitContainer1.SplitterDistance = 31;
            this.splitContainer1.TabIndex = 1;
            // 
            // sortKeyword
            // 
            this.sortKeyword.Location = new System.Drawing.Point(962, 4);
            this.sortKeyword.Name = "sortKeyword";
            this.sortKeyword.Size = new System.Drawing.Size(75, 23);
            this.sortKeyword.TabIndex = 6;
            this.sortKeyword.Text = "Sort";
            this.sortKeyword.UseVisualStyleBackColor = true;
            this.sortKeyword.Click += new System.EventHandler(this.sortKeyword_Click);
            // 
            // keywordAscDsc
            // 
            this.keywordAscDsc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.keywordAscDsc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.keywordAscDsc.FormattingEnabled = true;
            this.keywordAscDsc.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.keywordAscDsc.Location = new System.Drawing.Point(817, 6);
            this.keywordAscDsc.Name = "keywordAscDsc";
            this.keywordAscDsc.Size = new System.Drawing.Size(121, 21);
            this.keywordAscDsc.TabIndex = 5;
            // 
            // keywordSearch
            // 
            this.keywordSearch.Location = new System.Drawing.Point(96, 6);
            this.keywordSearch.Name = "keywordSearch";
            this.keywordSearch.Size = new System.Drawing.Size(241, 20);
            this.keywordSearch.TabIndex = 3;
            this.keywordSearch.TextChanged += new System.EventHandler(this.keywordSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search in Table:";
            // 
            // keywordsGrid
            // 
            this.keywordsGrid.AllowUserToAddRows = false;
            this.keywordsGrid.AllowUserToDeleteRows = false;
            this.keywordsGrid.AutoGenerateColumns = false;
            this.keywordsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.keywordsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.keywordsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.termsDataGridViewTextBoxColumn,
            this.addToReportKeyword});
            this.keywordsGrid.DataSource = this.keywordSearchChromeBindingSource;
            this.keywordsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keywordsGrid.Location = new System.Drawing.Point(0, 0);
            this.keywordsGrid.Name = "keywordsGrid";
            this.keywordsGrid.Size = new System.Drawing.Size(1053, 544);
            this.keywordsGrid.TabIndex = 0;
            // 
            // addToReportKeyword
            // 
            this.addToReportKeyword.HeaderText = "Add To Report";
            this.addToReportKeyword.Name = "addToReportKeyword";
            // 
            // urlHistoryTab
            // 
            this.urlHistoryTab.Controls.Add(this.splitContainer2);
            this.urlHistoryTab.Location = new System.Drawing.Point(4, 22);
            this.urlHistoryTab.Name = "urlHistoryTab";
            this.urlHistoryTab.Padding = new System.Windows.Forms.Padding(3);
            this.urlHistoryTab.Size = new System.Drawing.Size(1059, 585);
            this.urlHistoryTab.TabIndex = 1;
            this.urlHistoryTab.Text = "URL History";
            this.urlHistoryTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.urlsCombo);
            this.splitContainer2.Panel1.Controls.Add(this.urlsSort);
            this.splitContainer2.Panel1.Controls.Add(this.urlsAscDsc);
            this.splitContainer2.Panel1.Controls.Add(this.urlSearch);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.urlHistoryGrid);
            this.splitContainer2.Size = new System.Drawing.Size(1053, 579);
            this.splitContainer2.SplitterDistance = 32;
            this.splitContainer2.TabIndex = 0;
            // 
            // urlsCombo
            // 
            this.urlsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.urlsCombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.urlsCombo.FormattingEnabled = true;
            this.urlsCombo.Items.AddRange(new object[] {
            "Title",
            "VisitCount",
            "LastVisitTime",
            "VisitDuration"});
            this.urlsCombo.Location = new System.Drawing.Point(693, 6);
            this.urlsCombo.Name = "urlsCombo";
            this.urlsCombo.Size = new System.Drawing.Size(121, 21);
            this.urlsCombo.TabIndex = 11;
            // 
            // urlsSort
            // 
            this.urlsSort.Location = new System.Drawing.Point(973, 4);
            this.urlsSort.Name = "urlsSort";
            this.urlsSort.Size = new System.Drawing.Size(75, 23);
            this.urlsSort.TabIndex = 10;
            this.urlsSort.Text = "Sort";
            this.urlsSort.UseVisualStyleBackColor = true;
            this.urlsSort.Click += new System.EventHandler(this.urlsSort_Click);
            // 
            // urlsAscDsc
            // 
            this.urlsAscDsc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.urlsAscDsc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.urlsAscDsc.FormattingEnabled = true;
            this.urlsAscDsc.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.urlsAscDsc.Location = new System.Drawing.Point(820, 6);
            this.urlsAscDsc.Name = "urlsAscDsc";
            this.urlsAscDsc.Size = new System.Drawing.Size(121, 21);
            this.urlsAscDsc.TabIndex = 9;
            // 
            // urlSearch
            // 
            this.urlSearch.Location = new System.Drawing.Point(96, 6);
            this.urlSearch.Name = "urlSearch";
            this.urlSearch.Size = new System.Drawing.Size(241, 20);
            this.urlSearch.TabIndex = 8;
            this.urlSearch.TextChanged += new System.EventHandler(this.urlSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Search in Table:";
            // 
            // urlHistoryGrid
            // 
            this.urlHistoryGrid.AllowUserToAddRows = false;
            this.urlHistoryGrid.AllowUserToDeleteRows = false;
            this.urlHistoryGrid.AutoGenerateColumns = false;
            this.urlHistoryGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.urlHistoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.urlHistoryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.visitCountDataGridViewTextBoxColumn,
            this.lastVisitTimeDataGridViewTextBoxColumn,
            this.visitDurationDataGridViewTextBoxColumn,
            this.addToReportHistory});
            this.urlHistoryGrid.DataSource = this.historyChromeBindingSource;
            this.urlHistoryGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.urlHistoryGrid.Location = new System.Drawing.Point(0, 0);
            this.urlHistoryGrid.Name = "urlHistoryGrid";
            this.urlHistoryGrid.Size = new System.Drawing.Size(1053, 543);
            this.urlHistoryGrid.TabIndex = 0;
            // 
            // addToReportHistory
            // 
            this.addToReportHistory.HeaderText = "Add To Report";
            this.addToReportHistory.Name = "addToReportHistory";
            // 
            // downloadHistory
            // 
            this.downloadHistory.Controls.Add(this.splitContainer3);
            this.downloadHistory.Location = new System.Drawing.Point(4, 22);
            this.downloadHistory.Name = "downloadHistory";
            this.downloadHistory.Size = new System.Drawing.Size(1059, 585);
            this.downloadHistory.TabIndex = 2;
            this.downloadHistory.Text = "Downloads";
            this.downloadHistory.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.downloadsCombo);
            this.splitContainer3.Panel1.Controls.Add(this.sortDownloads);
            this.splitContainer3.Panel1.Controls.Add(this.downloadsAscDsc);
            this.splitContainer3.Panel1.Controls.Add(this.downloadSearch);
            this.splitContainer3.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.downloadsHistoryGrid);
            this.splitContainer3.Size = new System.Drawing.Size(1059, 585);
            this.splitContainer3.SplitterDistance = 34;
            this.splitContainer3.TabIndex = 0;
            // 
            // downloadsCombo
            // 
            this.downloadsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.downloadsCombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.downloadsCombo.FormattingEnabled = true;
            this.downloadsCombo.Items.AddRange(new object[] {
            "TargetPath",
            "StartTime",
            "EndTime",
            "Referer",
            "MimeType",
            "OriginalMimeType"});
            this.downloadsCombo.Location = new System.Drawing.Point(701, 6);
            this.downloadsCombo.Name = "downloadsCombo";
            this.downloadsCombo.Size = new System.Drawing.Size(121, 21);
            this.downloadsCombo.TabIndex = 12;
            // 
            // sortDownloads
            // 
            this.sortDownloads.Location = new System.Drawing.Point(976, 4);
            this.sortDownloads.Name = "sortDownloads";
            this.sortDownloads.Size = new System.Drawing.Size(75, 23);
            this.sortDownloads.TabIndex = 10;
            this.sortDownloads.Text = "Sort";
            this.sortDownloads.UseVisualStyleBackColor = true;
            this.sortDownloads.Click += new System.EventHandler(this.sortDownloads_Click);
            // 
            // downloadsAscDsc
            // 
            this.downloadsAscDsc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.downloadsAscDsc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.downloadsAscDsc.FormattingEnabled = true;
            this.downloadsAscDsc.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.downloadsAscDsc.Location = new System.Drawing.Point(828, 6);
            this.downloadsAscDsc.Name = "downloadsAscDsc";
            this.downloadsAscDsc.Size = new System.Drawing.Size(121, 21);
            this.downloadsAscDsc.TabIndex = 9;
            // 
            // downloadSearch
            // 
            this.downloadSearch.Location = new System.Drawing.Point(99, 6);
            this.downloadSearch.Name = "downloadSearch";
            this.downloadSearch.Size = new System.Drawing.Size(241, 20);
            this.downloadSearch.TabIndex = 8;
            this.downloadSearch.TextChanged += new System.EventHandler(this.downloadSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Search in Table:";
            // 
            // downloadsHistoryGrid
            // 
            this.downloadsHistoryGrid.AllowUserToAddRows = false;
            this.downloadsHistoryGrid.AllowUserToDeleteRows = false;
            this.downloadsHistoryGrid.AutoGenerateColumns = false;
            this.downloadsHistoryGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.downloadsHistoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.downloadsHistoryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.targetPathDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.Referer,
            this.mimeTypeDataGridViewTextBoxColumn,
            this.originalMimeTypeDataGridViewTextBoxColumn,
            this.addToReportDownloads});
            this.downloadsHistoryGrid.DataSource = this.downloadsChromeBindingSource;
            this.downloadsHistoryGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downloadsHistoryGrid.Location = new System.Drawing.Point(0, 0);
            this.downloadsHistoryGrid.Name = "downloadsHistoryGrid";
            this.downloadsHistoryGrid.Size = new System.Drawing.Size(1059, 547);
            this.downloadsHistoryGrid.TabIndex = 0;
            // 
            // Referer
            // 
            this.Referer.DataPropertyName = "Referer";
            this.Referer.HeaderText = "Referer";
            this.Referer.Name = "Referer";
            this.Referer.ReadOnly = true;
            // 
            // addToReportDownloads
            // 
            this.addToReportDownloads.HeaderText = "Add To Report";
            this.addToReportDownloads.Name = "addToReportDownloads";
            // 
            // autofillTab
            // 
            this.autofillTab.Controls.Add(this.splitContainer4);
            this.autofillTab.Location = new System.Drawing.Point(4, 22);
            this.autofillTab.Name = "autofillTab";
            this.autofillTab.Padding = new System.Windows.Forms.Padding(3);
            this.autofillTab.Size = new System.Drawing.Size(1059, 585);
            this.autofillTab.TabIndex = 3;
            this.autofillTab.Text = "Autofill";
            this.autofillTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.autofillCombo);
            this.splitContainer4.Panel1.Controls.Add(this.sortAutofill);
            this.splitContainer4.Panel1.Controls.Add(this.autofillAscDsc);
            this.splitContainer4.Panel1.Controls.Add(this.autofillSearch);
            this.splitContainer4.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.autofillGrid);
            this.splitContainer4.Size = new System.Drawing.Size(1053, 579);
            this.splitContainer4.SplitterDistance = 33;
            this.splitContainer4.TabIndex = 0;
            // 
            // autofillCombo
            // 
            this.autofillCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.autofillCombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.autofillCombo.FormattingEnabled = true;
            this.autofillCombo.Items.AddRange(new object[] {
            "Name",
            "Value",
            "DateCreated",
            "DateLastUsed",
            "Count"});
            this.autofillCombo.Location = new System.Drawing.Point(698, 7);
            this.autofillCombo.Name = "autofillCombo";
            this.autofillCombo.Size = new System.Drawing.Size(121, 21);
            this.autofillCombo.TabIndex = 13;
            // 
            // sortAutofill
            // 
            this.sortAutofill.Location = new System.Drawing.Point(962, 5);
            this.sortAutofill.Name = "sortAutofill";
            this.sortAutofill.Size = new System.Drawing.Size(75, 23);
            this.sortAutofill.TabIndex = 10;
            this.sortAutofill.Text = "Sort";
            this.sortAutofill.UseVisualStyleBackColor = true;
            this.sortAutofill.Click += new System.EventHandler(this.sortAutofill_Click);
            // 
            // autofillAscDsc
            // 
            this.autofillAscDsc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.autofillAscDsc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.autofillAscDsc.FormattingEnabled = true;
            this.autofillAscDsc.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.autofillAscDsc.Location = new System.Drawing.Point(825, 6);
            this.autofillAscDsc.Name = "autofillAscDsc";
            this.autofillAscDsc.Size = new System.Drawing.Size(121, 21);
            this.autofillAscDsc.TabIndex = 9;
            // 
            // autofillSearch
            // 
            this.autofillSearch.Location = new System.Drawing.Point(101, 7);
            this.autofillSearch.Name = "autofillSearch";
            this.autofillSearch.Size = new System.Drawing.Size(241, 20);
            this.autofillSearch.TabIndex = 8;
            this.autofillSearch.TextChanged += new System.EventHandler(this.autofillSearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Search in Table:";
            // 
            // autofillGrid
            // 
            this.autofillGrid.AllowUserToAddRows = false;
            this.autofillGrid.AllowUserToDeleteRows = false;
            this.autofillGrid.AutoGenerateColumns = false;
            this.autofillGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.autofillGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.autofillGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.dateCreatedDataGridViewTextBoxColumn,
            this.dateLastUsedDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.addToReportAutofill});
            this.autofillGrid.DataSource = this.autoFillChromeBindingSource;
            this.autofillGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autofillGrid.Location = new System.Drawing.Point(0, 0);
            this.autofillGrid.Name = "autofillGrid";
            this.autofillGrid.Size = new System.Drawing.Size(1053, 542);
            this.autofillGrid.TabIndex = 0;
            // 
            // addToReportAutofill
            // 
            this.addToReportAutofill.HeaderText = "Add To Report";
            this.addToReportAutofill.Name = "addToReportAutofill";
            // 
            // cookiesTab
            // 
            this.cookiesTab.Controls.Add(this.splitContainer5);
            this.cookiesTab.Location = new System.Drawing.Point(4, 22);
            this.cookiesTab.Name = "cookiesTab";
            this.cookiesTab.Size = new System.Drawing.Size(1059, 585);
            this.cookiesTab.TabIndex = 4;
            this.cookiesTab.Text = "Cookies";
            this.cookiesTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.cookiesCombo);
            this.splitContainer5.Panel1.Controls.Add(this.sortCookies);
            this.splitContainer5.Panel1.Controls.Add(this.cookiesAscDsc);
            this.splitContainer5.Panel1.Controls.Add(this.cookieSearch);
            this.splitContainer5.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.cookiesGrid);
            this.splitContainer5.Size = new System.Drawing.Size(1059, 585);
            this.splitContainer5.SplitterDistance = 37;
            this.splitContainer5.TabIndex = 0;
            // 
            // cookiesCombo
            // 
            this.cookiesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cookiesCombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cookiesCombo.FormattingEnabled = true;
            this.cookiesCombo.Items.AddRange(new object[] {
            "Creation",
            "HostKey",
            "Name",
            "Value",
            "CookiePath",
            "Expires"});
            this.cookiesCombo.Location = new System.Drawing.Point(700, 11);
            this.cookiesCombo.Name = "cookiesCombo";
            this.cookiesCombo.Size = new System.Drawing.Size(121, 21);
            this.cookiesCombo.TabIndex = 14;
            // 
            // sortCookies
            // 
            this.sortCookies.Location = new System.Drawing.Point(976, 10);
            this.sortCookies.Name = "sortCookies";
            this.sortCookies.Size = new System.Drawing.Size(75, 23);
            this.sortCookies.TabIndex = 10;
            this.sortCookies.Text = "Sort";
            this.sortCookies.UseVisualStyleBackColor = true;
            this.sortCookies.Click += new System.EventHandler(this.sortCookies_Click);
            // 
            // cookiesAscDsc
            // 
            this.cookiesAscDsc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cookiesAscDsc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cookiesAscDsc.FormattingEnabled = true;
            this.cookiesAscDsc.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.cookiesAscDsc.Location = new System.Drawing.Point(827, 11);
            this.cookiesAscDsc.Name = "cookiesAscDsc";
            this.cookiesAscDsc.Size = new System.Drawing.Size(121, 21);
            this.cookiesAscDsc.TabIndex = 9;
            // 
            // cookieSearch
            // 
            this.cookieSearch.Location = new System.Drawing.Point(104, 12);
            this.cookieSearch.Name = "cookieSearch";
            this.cookieSearch.Size = new System.Drawing.Size(241, 20);
            this.cookieSearch.TabIndex = 8;
            this.cookieSearch.TextChanged += new System.EventHandler(this.cookieSearch_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Search in Table:";
            // 
            // cookiesGrid
            // 
            this.cookiesGrid.AllowUserToAddRows = false;
            this.cookiesGrid.AllowUserToDeleteRows = false;
            this.cookiesGrid.AutoGenerateColumns = false;
            this.cookiesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cookiesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cookiesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.creationDataGridViewTextBoxColumn,
            this.hostKeyDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.valueDataGridViewTextBoxColumn1,
            this.cookiePathDataGridViewTextBoxColumn,
            this.expiresDataGridViewTextBoxColumn,
            this.addToReportCookie});
            this.cookiesGrid.DataSource = this.cookiesChromeBindingSource;
            this.cookiesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cookiesGrid.Location = new System.Drawing.Point(0, 0);
            this.cookiesGrid.Name = "cookiesGrid";
            this.cookiesGrid.Size = new System.Drawing.Size(1059, 544);
            this.cookiesGrid.TabIndex = 0;
            // 
            // addToReportCookie
            // 
            this.addToReportCookie.HeaderText = "Add To Report";
            this.addToReportCookie.Name = "addToReportCookie";
            // 
            // topSites
            // 
            this.topSites.Controls.Add(this.splitContainer6);
            this.topSites.Location = new System.Drawing.Point(4, 22);
            this.topSites.Name = "topSites";
            this.topSites.Size = new System.Drawing.Size(1059, 585);
            this.topSites.TabIndex = 5;
            this.topSites.Text = "Top Sites";
            this.topSites.UseVisualStyleBackColor = true;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.topsitesCombo);
            this.splitContainer6.Panel1.Controls.Add(this.topsitesSort);
            this.splitContainer6.Panel1.Controls.Add(this.topsitesAscDsc);
            this.splitContainer6.Panel1.Controls.Add(this.topsitesSearch);
            this.splitContainer6.Panel1.Controls.Add(this.label6);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.topsitesGrid);
            this.splitContainer6.Size = new System.Drawing.Size(1059, 585);
            this.splitContainer6.SplitterDistance = 38;
            this.splitContainer6.TabIndex = 0;
            // 
            // topsitesCombo
            // 
            this.topsitesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.topsitesCombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.topsitesCombo.FormattingEnabled = true;
            this.topsitesCombo.Items.AddRange(new object[] {
            "Url",
            "UrlRank",
            "Title"});
            this.topsitesCombo.Location = new System.Drawing.Point(700, 11);
            this.topsitesCombo.Name = "topsitesCombo";
            this.topsitesCombo.Size = new System.Drawing.Size(121, 21);
            this.topsitesCombo.TabIndex = 15;
            // 
            // topsitesSort
            // 
            this.topsitesSort.Location = new System.Drawing.Point(970, 9);
            this.topsitesSort.Name = "topsitesSort";
            this.topsitesSort.Size = new System.Drawing.Size(75, 23);
            this.topsitesSort.TabIndex = 10;
            this.topsitesSort.Text = "Sort";
            this.topsitesSort.UseVisualStyleBackColor = true;
            this.topsitesSort.Click += new System.EventHandler(this.topsitesSort_Click);
            // 
            // topsitesAscDsc
            // 
            this.topsitesAscDsc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.topsitesAscDsc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.topsitesAscDsc.FormattingEnabled = true;
            this.topsitesAscDsc.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.topsitesAscDsc.Location = new System.Drawing.Point(827, 11);
            this.topsitesAscDsc.Name = "topsitesAscDsc";
            this.topsitesAscDsc.Size = new System.Drawing.Size(121, 21);
            this.topsitesAscDsc.TabIndex = 9;
            // 
            // topsitesSearch
            // 
            this.topsitesSearch.Location = new System.Drawing.Point(104, 11);
            this.topsitesSearch.Name = "topsitesSearch";
            this.topsitesSearch.Size = new System.Drawing.Size(241, 20);
            this.topsitesSearch.TabIndex = 8;
            this.topsitesSearch.Text = " ";
            this.topsitesSearch.TextChanged += new System.EventHandler(this.topsitesSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Search in Table:";
            // 
            // topsitesGrid
            // 
            this.topsitesGrid.AllowUserToAddRows = false;
            this.topsitesGrid.AllowUserToDeleteRows = false;
            this.topsitesGrid.AutoGenerateColumns = false;
            this.topsitesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.topsitesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.topsitesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urlDataGridViewTextBoxColumn,
            this.urlRankDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn1,
            this.addToReportTopSites});
            this.topsitesGrid.DataSource = this.topSitesChromeBindingSource;
            this.topsitesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topsitesGrid.Location = new System.Drawing.Point(0, 0);
            this.topsitesGrid.Name = "topsitesGrid";
            this.topsitesGrid.Size = new System.Drawing.Size(1059, 543);
            this.topsitesGrid.TabIndex = 0;
            // 
            // addToReportTopSites
            // 
            this.addToReportTopSites.HeaderText = "Add To Report";
            this.addToReportTopSites.Name = "addToReportTopSites";
            // 
            // printPdf
            // 
            this.printPdf.Controls.Add(this.splitContainer7);
            this.printPdf.Location = new System.Drawing.Point(4, 22);
            this.printPdf.Name = "printPdf";
            this.printPdf.Size = new System.Drawing.Size(1059, 585);
            this.printPdf.TabIndex = 6;
            this.printPdf.Text = "Print";
            this.printPdf.UseVisualStyleBackColor = true;
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer7.Panel1.Controls.Add(this.printButton);
            this.splitContainer7.Panel1.Controls.Add(this.label8);
            this.splitContainer7.Panel1.Controls.Add(this.label7);
            this.splitContainer7.Panel1.Controls.Add(this.reportName);
            this.splitContainer7.Panel1.Controls.Add(this.reportNote);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer7.Panel2.Controls.Add(this.addPicture);
            this.splitContainer7.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer7.Panel2.Controls.Add(this.profilePic);
            this.splitContainer7.Size = new System.Drawing.Size(1059, 585);
            this.splitContainer7.SplitterDistance = 719;
            this.splitContainer7.TabIndex = 0;
            // 
            // printButton
            // 
            this.printButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.printButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printButton.ImageIndex = 1;
            this.printButton.ImageList = this.imageListButton;
            this.printButton.Location = new System.Drawing.Point(328, 535);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 28);
            this.printButton.TabIndex = 22;
            this.printButton.Text = "Print";
            this.printButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // imageListButton
            // 
            this.imageListButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListButton.ImageStream")));
            this.imageListButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListButton.Images.SetKeyName(0, "plus.png");
            this.imageListButton.Images.SetKeyName(1, "save.png");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Report Notes:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Report Name:";
            // 
            // reportName
            // 
            this.reportName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportName.Location = new System.Drawing.Point(73, 72);
            this.reportName.Name = "reportName";
            this.reportName.Size = new System.Drawing.Size(575, 20);
            this.reportName.TabIndex = 19;
            // 
            // reportNote
            // 
            this.reportNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportNote.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.reportNote.Location = new System.Drawing.Point(73, 124);
            this.reportNote.MaxLength = 300;
            this.reportNote.Name = "reportNote";
            this.reportNote.Size = new System.Drawing.Size(575, 405);
            this.reportNote.TabIndex = 18;
            this.reportNote.Text = "";
            this.reportNote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.reportNote_KeyPress);
            // 
            // addPicture
            // 
            this.addPicture.Enabled = false;
            this.addPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addPicture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addPicture.ImageIndex = 0;
            this.addPicture.ImageList = this.imageListButton;
            this.addPicture.Location = new System.Drawing.Point(113, 174);
            this.addPicture.Name = "addPicture";
            this.addPicture.Size = new System.Drawing.Size(123, 27);
            this.addPicture.TabIndex = 2;
            this.addPicture.Text = "Add Picture";
            this.addPicture.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addPicture.UseVisualStyleBackColor = true;
            this.addPicture.Click += new System.EventHandler(this.addPicture_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.emailLabel);
            this.groupBox1.Controls.Add(this.surnameLabel);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.noForPhoto);
            this.groupBox1.Controls.Add(this.yesForPhoto);
            this.groupBox1.Controls.Add(this.evidenceNumber);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(48, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 298);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(84, 132);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(0, 13);
            this.emailLabel.TabIndex = 9;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(84, 91);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(0, 13);
            this.surnameLabel.TabIndex = 8;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(84, 53);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 13);
            this.nameLabel.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(13, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(203, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Would you like to add the photo to report:";
            // 
            // noForPhoto
            // 
            this.noForPhoto.AutoSize = true;
            this.noForPhoto.Checked = true;
            this.noForPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.noForPhoto.Location = new System.Drawing.Point(65, 202);
            this.noForPhoto.Name = "noForPhoto";
            this.noForPhoto.Size = new System.Drawing.Size(44, 20);
            this.noForPhoto.TabIndex = 5;
            this.noForPhoto.TabStop = true;
            this.noForPhoto.Text = "No";
            this.noForPhoto.UseVisualStyleBackColor = true;
            this.noForPhoto.CheckedChanged += new System.EventHandler(this.noForPhoto_CheckedChanged);
            // 
            // yesForPhoto
            // 
            this.yesForPhoto.AutoSize = true;
            this.yesForPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yesForPhoto.Location = new System.Drawing.Point(16, 202);
            this.yesForPhoto.Name = "yesForPhoto";
            this.yesForPhoto.Size = new System.Drawing.Size(50, 20);
            this.yesForPhoto.TabIndex = 4;
            this.yesForPhoto.Text = "Yes";
            this.yesForPhoto.UseVisualStyleBackColor = true;
            this.yesForPhoto.CheckedChanged += new System.EventHandler(this.yesForPhoto_CheckedChanged);
            // 
            // evidenceNumber
            // 
            this.evidenceNumber.AutoSize = true;
            this.evidenceNumber.Location = new System.Drawing.Point(13, 156);
            this.evidenceNumber.Name = "evidenceNumber";
            this.evidenceNumber.Size = new System.Drawing.Size(0, 13);
            this.evidenceNumber.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(13, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "E-Mail : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(13, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Surname : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(13, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Name : ";
            // 
            // profilePic
            // 
            this.profilePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.profilePic.Image = ((System.Drawing.Image)(resources.GetObject("profilePic.Image")));
            this.profilePic.Location = new System.Drawing.Point(90, 3);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(171, 156);
            this.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePic.TabIndex = 0;
            this.profilePic.TabStop = false;
            // 
            // termsDataGridViewTextBoxColumn
            // 
            this.termsDataGridViewTextBoxColumn.DataPropertyName = "Terms";
            this.termsDataGridViewTextBoxColumn.HeaderText = "Terms";
            this.termsDataGridViewTextBoxColumn.Name = "termsDataGridViewTextBoxColumn";
            this.termsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // keywordSearchChromeBindingSource
            // 
            this.keywordSearchChromeBindingSource.DataSource = typeof(BrowserCheck.Model.KeywordSearchChrome);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visitCountDataGridViewTextBoxColumn
            // 
            this.visitCountDataGridViewTextBoxColumn.DataPropertyName = "VisitCount";
            this.visitCountDataGridViewTextBoxColumn.HeaderText = "VisitCount";
            this.visitCountDataGridViewTextBoxColumn.Name = "visitCountDataGridViewTextBoxColumn";
            this.visitCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastVisitTimeDataGridViewTextBoxColumn
            // 
            this.lastVisitTimeDataGridViewTextBoxColumn.DataPropertyName = "LastVisitTime";
            this.lastVisitTimeDataGridViewTextBoxColumn.HeaderText = "LastVisitTime";
            this.lastVisitTimeDataGridViewTextBoxColumn.Name = "lastVisitTimeDataGridViewTextBoxColumn";
            this.lastVisitTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visitDurationDataGridViewTextBoxColumn
            // 
            this.visitDurationDataGridViewTextBoxColumn.DataPropertyName = "VisitDuration";
            this.visitDurationDataGridViewTextBoxColumn.HeaderText = "VisitDuration";
            this.visitDurationDataGridViewTextBoxColumn.Name = "visitDurationDataGridViewTextBoxColumn";
            this.visitDurationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // historyChromeBindingSource
            // 
            this.historyChromeBindingSource.DataSource = typeof(BrowserCheck.Model.HistoryChrome);
            // 
            // targetPathDataGridViewTextBoxColumn
            // 
            this.targetPathDataGridViewTextBoxColumn.DataPropertyName = "TargetPath";
            this.targetPathDataGridViewTextBoxColumn.HeaderText = "TargetPath";
            this.targetPathDataGridViewTextBoxColumn.Name = "targetPathDataGridViewTextBoxColumn";
            this.targetPathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mimeTypeDataGridViewTextBoxColumn
            // 
            this.mimeTypeDataGridViewTextBoxColumn.DataPropertyName = "MimeType";
            this.mimeTypeDataGridViewTextBoxColumn.HeaderText = "MimeType";
            this.mimeTypeDataGridViewTextBoxColumn.Name = "mimeTypeDataGridViewTextBoxColumn";
            this.mimeTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // originalMimeTypeDataGridViewTextBoxColumn
            // 
            this.originalMimeTypeDataGridViewTextBoxColumn.DataPropertyName = "OriginalMimeType";
            this.originalMimeTypeDataGridViewTextBoxColumn.HeaderText = "OriginalMimeType";
            this.originalMimeTypeDataGridViewTextBoxColumn.Name = "originalMimeTypeDataGridViewTextBoxColumn";
            this.originalMimeTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // downloadsChromeBindingSource
            // 
            this.downloadsChromeBindingSource.DataSource = typeof(BrowserCheck.Model.DownloadsChrome);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateCreatedDataGridViewTextBoxColumn
            // 
            this.dateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.HeaderText = "DateCreated";
            this.dateCreatedDataGridViewTextBoxColumn.Name = "dateCreatedDataGridViewTextBoxColumn";
            this.dateCreatedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateLastUsedDataGridViewTextBoxColumn
            // 
            this.dateLastUsedDataGridViewTextBoxColumn.DataPropertyName = "DateLastUsed";
            this.dateLastUsedDataGridViewTextBoxColumn.HeaderText = "DateLastUsed";
            this.dateLastUsedDataGridViewTextBoxColumn.Name = "dateLastUsedDataGridViewTextBoxColumn";
            this.dateLastUsedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // autoFillChromeBindingSource
            // 
            this.autoFillChromeBindingSource.DataSource = typeof(BrowserCheck.Model.AutoFillChrome);
            // 
            // creationDataGridViewTextBoxColumn
            // 
            this.creationDataGridViewTextBoxColumn.DataPropertyName = "Creation";
            this.creationDataGridViewTextBoxColumn.HeaderText = "Creation";
            this.creationDataGridViewTextBoxColumn.Name = "creationDataGridViewTextBoxColumn";
            this.creationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hostKeyDataGridViewTextBoxColumn
            // 
            this.hostKeyDataGridViewTextBoxColumn.DataPropertyName = "HostKey";
            this.hostKeyDataGridViewTextBoxColumn.HeaderText = "HostKey";
            this.hostKeyDataGridViewTextBoxColumn.Name = "hostKeyDataGridViewTextBoxColumn";
            this.hostKeyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // valueDataGridViewTextBoxColumn1
            // 
            this.valueDataGridViewTextBoxColumn1.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn1.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn1.Name = "valueDataGridViewTextBoxColumn1";
            this.valueDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cookiePathDataGridViewTextBoxColumn
            // 
            this.cookiePathDataGridViewTextBoxColumn.DataPropertyName = "CookiePath";
            this.cookiePathDataGridViewTextBoxColumn.HeaderText = "CookiePath";
            this.cookiePathDataGridViewTextBoxColumn.Name = "cookiePathDataGridViewTextBoxColumn";
            this.cookiePathDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expiresDataGridViewTextBoxColumn
            // 
            this.expiresDataGridViewTextBoxColumn.DataPropertyName = "Expires";
            this.expiresDataGridViewTextBoxColumn.HeaderText = "Expires";
            this.expiresDataGridViewTextBoxColumn.Name = "expiresDataGridViewTextBoxColumn";
            this.expiresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cookiesChromeBindingSource
            // 
            this.cookiesChromeBindingSource.DataSource = typeof(BrowserCheck.Model.CookiesChrome);
            // 
            // urlDataGridViewTextBoxColumn
            // 
            this.urlDataGridViewTextBoxColumn.DataPropertyName = "Url";
            this.urlDataGridViewTextBoxColumn.HeaderText = "Url";
            this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            this.urlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urlRankDataGridViewTextBoxColumn
            // 
            this.urlRankDataGridViewTextBoxColumn.DataPropertyName = "UrlRank";
            this.urlRankDataGridViewTextBoxColumn.HeaderText = "UrlRank";
            this.urlRankDataGridViewTextBoxColumn.Name = "urlRankDataGridViewTextBoxColumn";
            this.urlRankDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn1
            // 
            this.titleDataGridViewTextBoxColumn1.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn1.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
            this.titleDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // topSitesChromeBindingSource
            // 
            this.topSitesChromeBindingSource.DataSource = typeof(BrowserCheck.Model.TopSitesChrome);
            // 
            // ChromeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 611);
            this.Controls.Add(this.chromeTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChromeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chrome Datas";
            this.Load += new System.EventHandler(this.ChromeForm_Load);
            this.chromeTabControl.ResumeLayout(false);
            this.keywordHistoryTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.keywordsGrid)).EndInit();
            this.urlHistoryTab.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.urlHistoryGrid)).EndInit();
            this.downloadHistory.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.downloadsHistoryGrid)).EndInit();
            this.autofillTab.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.autofillGrid)).EndInit();
            this.cookiesTab.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cookiesGrid)).EndInit();
            this.topSites.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel1.PerformLayout();
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.topsitesGrid)).EndInit();
            this.printPdf.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel1.PerformLayout();
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keywordSearchChromeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyChromeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downloadsChromeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoFillChromeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cookiesChromeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topSitesChromeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }
        private void InitializeComboboxes()
        {
            urlsAscDsc.SelectedIndex = 0;
            urlsCombo.SelectedIndex = 0;
            keywordAscDsc.SelectedIndex = 0;
            cookiesAscDsc.SelectedIndex = 0;
            cookiesCombo.SelectedIndex = 0;
            topsitesAscDsc.SelectedIndex = 0;
            topsitesCombo.SelectedIndex = 0;
            downloadsAscDsc.SelectedIndex = 0;
            downloadsCombo.SelectedIndex = 0;
            autofillAscDsc.SelectedIndex = 0;
            autofillCombo.SelectedIndex = 0;
        }
        #endregion
        private System.Windows.Forms.BindingSource keywordSearchChromeBindingSource;
        private System.Windows.Forms.TabControl chromeTabControl;
        private System.Windows.Forms.TabPage keywordHistoryTab;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView keywordsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn termsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn addToReportKeyword;
        private System.Windows.Forms.TabPage urlHistoryTab;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabPage downloadHistory;
        private System.Windows.Forms.DataGridView urlHistoryGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastVisitTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitDurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn addToReportHistory;
        private System.Windows.Forms.BindingSource historyChromeBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView downloadsHistoryGrid;
        private System.Windows.Forms.BindingSource downloadsChromeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetPathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referer;
        private System.Windows.Forms.DataGridViewTextBoxColumn mimeTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originalMimeTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn addToReportDownloads;
        private System.Windows.Forms.TabPage autofillTab;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.DataGridView autofillGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateLastUsedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn addToReportAutofill;
        private System.Windows.Forms.BindingSource autoFillChromeBindingSource;
        private System.Windows.Forms.TabPage cookiesTab;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.DataGridView cookiesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostKeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cookiePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn addToReportCookie;
        private System.Windows.Forms.BindingSource cookiesChromeBindingSource;
        private System.Windows.Forms.TabPage topSites;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.DataGridView topsitesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlRankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn addToReportTopSites;
        private System.Windows.Forms.BindingSource topSitesChromeBindingSource;
        private System.Windows.Forms.TabPage printPdf;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.Button addPicture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton noForPhoto;
        private System.Windows.Forms.RadioButton yesForPhoto;
        private System.Windows.Forms.Label evidenceNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.ImageList imageListButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox reportName;
        private System.Windows.Forms.RichTextBox reportNote;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.TextBox keywordSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sortKeyword;
        private System.Windows.Forms.ComboBox keywordAscDsc;
        private System.Windows.Forms.Button urlsSort;
        private System.Windows.Forms.ComboBox urlsAscDsc;
        private System.Windows.Forms.TextBox urlSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sortDownloads;
        private System.Windows.Forms.ComboBox downloadsAscDsc;
        private System.Windows.Forms.TextBox downloadSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sortAutofill;
        private System.Windows.Forms.ComboBox autofillAscDsc;
        private System.Windows.Forms.TextBox autofillSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sortCookies;
        private System.Windows.Forms.ComboBox cookiesAscDsc;
        private System.Windows.Forms.TextBox cookieSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button topsitesSort;
        private System.Windows.Forms.ComboBox topsitesAscDsc;
        private System.Windows.Forms.TextBox topsitesSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFilePicture;
        private System.Windows.Forms.ComboBox urlsCombo;
        private System.Windows.Forms.ComboBox downloadsCombo;
        private System.Windows.Forms.ComboBox autofillCombo;
        private System.Windows.Forms.ComboBox cookiesCombo;
        private System.Windows.Forms.ComboBox topsitesCombo;
    }
}