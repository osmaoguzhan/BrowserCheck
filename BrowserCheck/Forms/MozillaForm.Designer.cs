namespace BrowserCheck.Forms
{
    partial class MozillaForm
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
        /// 
        private void InitializeComboboxes()
        {
            sortColumnsCombo.SelectedIndex = 0;
            ascDsc.SelectedIndex = 0;
            sortWeb.SelectedIndex = 0;
            webAscDsc.SelectedIndex = 0;
            inputSort.SelectedIndex = 0;
            inputAscDsc.SelectedIndex = 0;
            sortBookmarks.SelectedIndex = 0;
            bookmarkAscDsc.SelectedIndex = 0;
            sortCookies.SelectedIndex = 0;
            cookiesAscDsc.SelectedIndex = 0;
            annosAscDsc.SelectedIndex = 0;
            sortAnnos.SelectedIndex = 0;
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MozillaForm));
            this.mozillaTabControl = new System.Windows.Forms.TabControl();
            this.formHistoryMozilla = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.sortButton = new System.Windows.Forms.Button();
            this.ascDsc = new System.Windows.Forms.ComboBox();
            this.sortColumnsCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.formHistoryGrid = new System.Windows.Forms.DataGridView();
            this.fieldNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeUsedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addToReport = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.formHistoryMozillaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.webHistoryMozilla = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.webHistorySort = new System.Windows.Forms.Button();
            this.webAscDsc = new System.Windows.Forms.ComboBox();
            this.sortWeb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBoxWeb = new System.Windows.Forms.TextBox();
            this.webHistoryGrid = new System.Windows.Forms.DataGridView();
            this.browseUrl = new System.Windows.Forms.DataGridViewLinkColumn();
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastVisitDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addToReportWeb = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.webHistoryMozillaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inputHistoryMozilla = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.inputHistorySort = new System.Windows.Forms.Button();
            this.inputAscDsc = new System.Windows.Forms.ComboBox();
            this.inputSort = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchBoxInput = new System.Windows.Forms.TextBox();
            this.inputHistoryGrid = new System.Windows.Forms.DataGridView();
            this.ınputDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usecountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addToReportInput = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ınputHistoryMozillaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookmarkMozilla = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.bookmarkSort = new System.Windows.Forms.Button();
            this.bookmarkAscDsc = new System.Windows.Forms.ComboBox();
            this.sortBookmarks = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.searchBoxBookmark = new System.Windows.Forms.TextBox();
            this.bookmarkMozillaGrid = new System.Windows.Forms.DataGridView();
            this.urlDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAddedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastModifiedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addToReportBookmark = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bookmarksMozillaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cookiesMozilla = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.cookiesMozillaSort = new System.Windows.Forms.Button();
            this.cookiesAscDsc = new System.Windows.Forms.ComboBox();
            this.sortCookies = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.searchBoxCookies = new System.Windows.Forms.TextBox();
            this.cookiesMozillaGrid = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CookiePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastAccessedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addToReportCookies = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cookiesMozillaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.annosMozilla = new System.Windows.Forms.TabPage();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.sortAnnosMozilla = new System.Windows.Forms.Button();
            this.annosAscDsc = new System.Windows.Forms.ComboBox();
            this.sortAnnos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.searcBoxAnnos = new System.Windows.Forms.TextBox();
            this.annosMozillaGrid = new System.Windows.Forms.DataGridView();
            this.contentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAddedDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastModifiedDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addToReportAnnos = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.annosMozillaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.reportName = new System.Windows.Forms.TextBox();
            this.reportNote = new System.Windows.Forms.RichTextBox();
            this.printButton = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
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
            this.openFilePicutre = new System.Windows.Forms.OpenFileDialog();
            this.mozillaTabControl.SuspendLayout();
            this.formHistoryMozilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formHistoryGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formHistoryMozillaBindingSource)).BeginInit();
            this.webHistoryMozilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webHistoryGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webHistoryMozillaBindingSource)).BeginInit();
            this.inputHistoryMozilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputHistoryGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ınputHistoryMozillaBindingSource)).BeginInit();
            this.bookmarkMozilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookmarkMozillaGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookmarksMozillaBindingSource)).BeginInit();
            this.cookiesMozilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cookiesMozillaGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cookiesMozillaBindingSource)).BeginInit();
            this.annosMozilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.annosMozillaGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.annosMozillaBindingSource)).BeginInit();
            this.printTab.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // mozillaTabControl
            // 
            this.mozillaTabControl.Controls.Add(this.formHistoryMozilla);
            this.mozillaTabControl.Controls.Add(this.webHistoryMozilla);
            this.mozillaTabControl.Controls.Add(this.inputHistoryMozilla);
            this.mozillaTabControl.Controls.Add(this.bookmarkMozilla);
            this.mozillaTabControl.Controls.Add(this.cookiesMozilla);
            this.mozillaTabControl.Controls.Add(this.annosMozilla);
            this.mozillaTabControl.Controls.Add(this.printTab);
            this.mozillaTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mozillaTabControl.Location = new System.Drawing.Point(0, 0);
            this.mozillaTabControl.Multiline = true;
            this.mozillaTabControl.Name = "mozillaTabControl";
            this.mozillaTabControl.SelectedIndex = 0;
            this.mozillaTabControl.Size = new System.Drawing.Size(1064, 580);
            this.mozillaTabControl.TabIndex = 1;
            // 
            // formHistoryMozilla
            // 
            this.formHistoryMozilla.Controls.Add(this.splitContainer1);
            this.formHistoryMozilla.Location = new System.Drawing.Point(4, 22);
            this.formHistoryMozilla.Name = "formHistoryMozilla";
            this.formHistoryMozilla.Padding = new System.Windows.Forms.Padding(3);
            this.formHistoryMozilla.Size = new System.Drawing.Size(1056, 554);
            this.formHistoryMozilla.TabIndex = 1;
            this.formHistoryMozilla.Text = "Form History";
            this.formHistoryMozilla.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.sortButton);
            this.splitContainer1.Panel1.Controls.Add(this.ascDsc);
            this.splitContainer1.Panel1.Controls.Add(this.sortColumnsCombo);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.searchBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.formHistoryGrid);
            this.splitContainer1.Size = new System.Drawing.Size(1050, 548);
            this.splitContainer1.SplitterDistance = 37;
            this.splitContainer1.TabIndex = 1;
            // 
            // sortButton
            // 
            this.sortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sortButton.Location = new System.Drawing.Point(970, 5);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(75, 23);
            this.sortButton.TabIndex = 4;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // ascDsc
            // 
            this.ascDsc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ascDsc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ascDsc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ascDsc.FormattingEnabled = true;
            this.ascDsc.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.ascDsc.Location = new System.Drawing.Point(828, 7);
            this.ascDsc.Name = "ascDsc";
            this.ascDsc.Size = new System.Drawing.Size(121, 21);
            this.ascDsc.TabIndex = 1;
            // 
            // sortColumnsCombo
            // 
            this.sortColumnsCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sortColumnsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortColumnsCombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sortColumnsCombo.FormattingEnabled = true;
            this.sortColumnsCombo.Items.AddRange(new object[] {
            "FieldName",
            "Value",
            "TimeUsed",
            "FirstDate",
            "LastDate"});
            this.sortColumnsCombo.Location = new System.Drawing.Point(690, 7);
            this.sortColumnsCombo.Name = "sortColumnsCombo";
            this.sortColumnsCombo.Size = new System.Drawing.Size(121, 21);
            this.sortColumnsCombo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search in Table:";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(91, 7);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(244, 20);
            this.searchBox.TabIndex = 0;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // formHistoryGrid
            // 
            this.formHistoryGrid.AllowUserToAddRows = false;
            this.formHistoryGrid.AllowUserToDeleteRows = false;
            this.formHistoryGrid.AutoGenerateColumns = false;
            this.formHistoryGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.formHistoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.formHistoryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fieldNameDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.timeUsedDataGridViewTextBoxColumn,
            this.firstDateDataGridViewTextBoxColumn,
            this.lastDateDataGridViewTextBoxColumn,
            this.addToReport});
            this.formHistoryGrid.DataSource = this.formHistoryMozillaBindingSource;
            this.formHistoryGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formHistoryGrid.Location = new System.Drawing.Point(0, 0);
            this.formHistoryGrid.Name = "formHistoryGrid";
            this.formHistoryGrid.Size = new System.Drawing.Size(1050, 507);
            this.formHistoryGrid.TabIndex = 0;
            // 
            // fieldNameDataGridViewTextBoxColumn
            // 
            this.fieldNameDataGridViewTextBoxColumn.DataPropertyName = "FieldName";
            this.fieldNameDataGridViewTextBoxColumn.FillWeight = 91.85447F;
            this.fieldNameDataGridViewTextBoxColumn.HeaderText = "FieldName";
            this.fieldNameDataGridViewTextBoxColumn.Name = "fieldNameDataGridViewTextBoxColumn";
            this.fieldNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.FillWeight = 91.85447F;
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeUsedDataGridViewTextBoxColumn
            // 
            this.timeUsedDataGridViewTextBoxColumn.DataPropertyName = "TimeUsed";
            this.timeUsedDataGridViewTextBoxColumn.FillWeight = 91.85447F;
            this.timeUsedDataGridViewTextBoxColumn.HeaderText = "TimeUsed";
            this.timeUsedDataGridViewTextBoxColumn.Name = "timeUsedDataGridViewTextBoxColumn";
            this.timeUsedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstDateDataGridViewTextBoxColumn
            // 
            this.firstDateDataGridViewTextBoxColumn.DataPropertyName = "FirstDate";
            this.firstDateDataGridViewTextBoxColumn.FillWeight = 91.85447F;
            this.firstDateDataGridViewTextBoxColumn.HeaderText = "FirstDate";
            this.firstDateDataGridViewTextBoxColumn.Name = "firstDateDataGridViewTextBoxColumn";
            this.firstDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastDateDataGridViewTextBoxColumn
            // 
            this.lastDateDataGridViewTextBoxColumn.DataPropertyName = "LastDate";
            this.lastDateDataGridViewTextBoxColumn.FillWeight = 91.85447F;
            this.lastDateDataGridViewTextBoxColumn.HeaderText = "LastDate";
            this.lastDateDataGridViewTextBoxColumn.Name = "lastDateDataGridViewTextBoxColumn";
            this.lastDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addToReport
            // 
            this.addToReport.FillWeight = 91.85447F;
            this.addToReport.HeaderText = "Add To Report";
            this.addToReport.Name = "addToReport";
            // 
            // formHistoryMozillaBindingSource
            // 
            this.formHistoryMozillaBindingSource.DataSource = typeof(BrowserCheck.Model.FormHistoryMozilla);
            // 
            // webHistoryMozilla
            // 
            this.webHistoryMozilla.Controls.Add(this.splitContainer2);
            this.webHistoryMozilla.Location = new System.Drawing.Point(4, 22);
            this.webHistoryMozilla.Name = "webHistoryMozilla";
            this.webHistoryMozilla.Padding = new System.Windows.Forms.Padding(3);
            this.webHistoryMozilla.Size = new System.Drawing.Size(1056, 554);
            this.webHistoryMozilla.TabIndex = 0;
            this.webHistoryMozilla.Text = "Web History";
            this.webHistoryMozilla.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.webHistorySort);
            this.splitContainer2.Panel1.Controls.Add(this.webAscDsc);
            this.splitContainer2.Panel1.Controls.Add(this.sortWeb);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.searchBoxWeb);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.webHistoryGrid);
            this.splitContainer2.Size = new System.Drawing.Size(1050, 548);
            this.splitContainer2.SplitterDistance = 36;
            this.splitContainer2.TabIndex = 0;
            // 
            // webHistorySort
            // 
            this.webHistorySort.Location = new System.Drawing.Point(970, 3);
            this.webHistorySort.Name = "webHistorySort";
            this.webHistorySort.Size = new System.Drawing.Size(75, 23);
            this.webHistorySort.TabIndex = 7;
            this.webHistorySort.Text = "Sort";
            this.webHistorySort.UseVisualStyleBackColor = true;
            this.webHistorySort.Click += new System.EventHandler(this.webHistorySort_Click);
            // 
            // webAscDsc
            // 
            this.webAscDsc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.webAscDsc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.webAscDsc.FormattingEnabled = true;
            this.webAscDsc.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.webAscDsc.Location = new System.Drawing.Point(828, 5);
            this.webAscDsc.Name = "webAscDsc";
            this.webAscDsc.Size = new System.Drawing.Size(121, 21);
            this.webAscDsc.TabIndex = 6;
            // 
            // sortWeb
            // 
            this.sortWeb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortWeb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sortWeb.FormattingEnabled = true;
            this.sortWeb.Items.AddRange(new object[] {
            "Url",
            "Title",
            "VisitCount",
            "LastVisitDate",
            "Description"});
            this.sortWeb.Location = new System.Drawing.Point(690, 5);
            this.sortWeb.Name = "sortWeb";
            this.sortWeb.Size = new System.Drawing.Size(121, 21);
            this.sortWeb.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search in Table:";
            // 
            // searchBoxWeb
            // 
            this.searchBoxWeb.Location = new System.Drawing.Point(94, 5);
            this.searchBoxWeb.Name = "searchBoxWeb";
            this.searchBoxWeb.Size = new System.Drawing.Size(244, 20);
            this.searchBoxWeb.TabIndex = 2;
            this.searchBoxWeb.TextChanged += new System.EventHandler(this.searchBoxWeb_TextChanged);
            // 
            // webHistoryGrid
            // 
            this.webHistoryGrid.AllowUserToAddRows = false;
            this.webHistoryGrid.AllowUserToDeleteRows = false;
            this.webHistoryGrid.AutoGenerateColumns = false;
            this.webHistoryGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.webHistoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.webHistoryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.browseUrl,
            this.urlDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.visitCountDataGridViewTextBoxColumn,
            this.lastVisitDateDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.addToReportWeb});
            this.webHistoryGrid.DataSource = this.webHistoryMozillaBindingSource;
            this.webHistoryGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webHistoryGrid.Location = new System.Drawing.Point(0, 0);
            this.webHistoryGrid.Name = "webHistoryGrid";
            this.webHistoryGrid.Size = new System.Drawing.Size(1050, 508);
            this.webHistoryGrid.TabIndex = 0;
            this.webHistoryGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.webHistoryGrid_CellContentClick);
            // 
            // browseUrl
            // 
            this.browseUrl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.browseUrl.DataPropertyName = "Url";
            this.browseUrl.FillWeight = 177.665F;
            this.browseUrl.HeaderText = "Browse";
            this.browseUrl.Name = "browseUrl";
            this.browseUrl.Text = "Browse";
            this.browseUrl.UseColumnTextForLinkValue = true;
            this.browseUrl.Width = 48;
            // 
            // urlDataGridViewTextBoxColumn
            // 
            this.urlDataGridViewTextBoxColumn.DataPropertyName = "Url";
            this.urlDataGridViewTextBoxColumn.FillWeight = 87.05586F;
            this.urlDataGridViewTextBoxColumn.HeaderText = "Url";
            this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            this.urlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.FillWeight = 87.05586F;
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visitCountDataGridViewTextBoxColumn
            // 
            this.visitCountDataGridViewTextBoxColumn.DataPropertyName = "VisitCount";
            this.visitCountDataGridViewTextBoxColumn.FillWeight = 87.05586F;
            this.visitCountDataGridViewTextBoxColumn.HeaderText = "VisitCount";
            this.visitCountDataGridViewTextBoxColumn.Name = "visitCountDataGridViewTextBoxColumn";
            this.visitCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastVisitDateDataGridViewTextBoxColumn
            // 
            this.lastVisitDateDataGridViewTextBoxColumn.DataPropertyName = "LastVisitDate";
            this.lastVisitDateDataGridViewTextBoxColumn.FillWeight = 87.05586F;
            this.lastVisitDateDataGridViewTextBoxColumn.HeaderText = "LastVisitDate";
            this.lastVisitDateDataGridViewTextBoxColumn.Name = "lastVisitDateDataGridViewTextBoxColumn";
            this.lastVisitDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.FillWeight = 87.05586F;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addToReportWeb
            // 
            this.addToReportWeb.FillWeight = 87.05586F;
            this.addToReportWeb.HeaderText = "Add To Report";
            this.addToReportWeb.Name = "addToReportWeb";
            // 
            // webHistoryMozillaBindingSource
            // 
            this.webHistoryMozillaBindingSource.DataSource = typeof(BrowserCheck.Model.WebHistoryMozilla);
            // 
            // inputHistoryMozilla
            // 
            this.inputHistoryMozilla.Controls.Add(this.splitContainer3);
            this.inputHistoryMozilla.Location = new System.Drawing.Point(4, 22);
            this.inputHistoryMozilla.Name = "inputHistoryMozilla";
            this.inputHistoryMozilla.Size = new System.Drawing.Size(1056, 554);
            this.inputHistoryMozilla.TabIndex = 3;
            this.inputHistoryMozilla.Text = "Input History";
            this.inputHistoryMozilla.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.inputHistorySort);
            this.splitContainer3.Panel1.Controls.Add(this.inputAscDsc);
            this.splitContainer3.Panel1.Controls.Add(this.inputSort);
            this.splitContainer3.Panel1.Controls.Add(this.label3);
            this.splitContainer3.Panel1.Controls.Add(this.searchBoxInput);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.inputHistoryGrid);
            this.splitContainer3.Size = new System.Drawing.Size(1056, 554);
            this.splitContainer3.SplitterDistance = 38;
            this.splitContainer3.TabIndex = 0;
            // 
            // inputHistorySort
            // 
            this.inputHistorySort.Location = new System.Drawing.Point(978, 5);
            this.inputHistorySort.Name = "inputHistorySort";
            this.inputHistorySort.Size = new System.Drawing.Size(75, 23);
            this.inputHistorySort.TabIndex = 12;
            this.inputHistorySort.Text = "Sort";
            this.inputHistorySort.UseVisualStyleBackColor = true;
            this.inputHistorySort.Click += new System.EventHandler(this.inputHistorySort_Click);
            // 
            // inputAscDsc
            // 
            this.inputAscDsc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputAscDsc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inputAscDsc.FormattingEnabled = true;
            this.inputAscDsc.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.inputAscDsc.Location = new System.Drawing.Point(836, 7);
            this.inputAscDsc.Name = "inputAscDsc";
            this.inputAscDsc.Size = new System.Drawing.Size(121, 21);
            this.inputAscDsc.TabIndex = 11;
            // 
            // inputSort
            // 
            this.inputSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inputSort.FormattingEnabled = true;
            this.inputSort.Items.AddRange(new object[] {
            "Input",
            "Use_count"});
            this.inputSort.Location = new System.Drawing.Point(698, 7);
            this.inputSort.Name = "inputSort";
            this.inputSort.Size = new System.Drawing.Size(121, 21);
            this.inputSort.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Search in Table:";
            // 
            // searchBoxInput
            // 
            this.searchBoxInput.Location = new System.Drawing.Point(99, 7);
            this.searchBoxInput.Name = "searchBoxInput";
            this.searchBoxInput.Size = new System.Drawing.Size(244, 20);
            this.searchBoxInput.TabIndex = 8;
            this.searchBoxInput.TextChanged += new System.EventHandler(this.searchBoxInput_TextChanged);
            // 
            // inputHistoryGrid
            // 
            this.inputHistoryGrid.AllowUserToAddRows = false;
            this.inputHistoryGrid.AllowUserToDeleteRows = false;
            this.inputHistoryGrid.AutoGenerateColumns = false;
            this.inputHistoryGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inputHistoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inputHistoryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ınputDataGridViewTextBoxColumn,
            this.usecountDataGridViewTextBoxColumn,
            this.addToReportInput});
            this.inputHistoryGrid.DataSource = this.ınputHistoryMozillaBindingSource;
            this.inputHistoryGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputHistoryGrid.Location = new System.Drawing.Point(0, 0);
            this.inputHistoryGrid.Name = "inputHistoryGrid";
            this.inputHistoryGrid.Size = new System.Drawing.Size(1056, 512);
            this.inputHistoryGrid.TabIndex = 0;
            // 
            // ınputDataGridViewTextBoxColumn
            // 
            this.ınputDataGridViewTextBoxColumn.DataPropertyName = "Input";
            this.ınputDataGridViewTextBoxColumn.HeaderText = "Input";
            this.ınputDataGridViewTextBoxColumn.Name = "ınputDataGridViewTextBoxColumn";
            this.ınputDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usecountDataGridViewTextBoxColumn
            // 
            this.usecountDataGridViewTextBoxColumn.DataPropertyName = "Use_count";
            this.usecountDataGridViewTextBoxColumn.HeaderText = "Use_count";
            this.usecountDataGridViewTextBoxColumn.Name = "usecountDataGridViewTextBoxColumn";
            this.usecountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addToReportInput
            // 
            this.addToReportInput.HeaderText = "Add To Report";
            this.addToReportInput.Name = "addToReportInput";
            // 
            // ınputHistoryMozillaBindingSource
            // 
            this.ınputHistoryMozillaBindingSource.DataSource = typeof(BrowserCheck.Model.InputHistoryMozilla);
            // 
            // bookmarkMozilla
            // 
            this.bookmarkMozilla.Controls.Add(this.splitContainer4);
            this.bookmarkMozilla.Location = new System.Drawing.Point(4, 22);
            this.bookmarkMozilla.Name = "bookmarkMozilla";
            this.bookmarkMozilla.Size = new System.Drawing.Size(1056, 554);
            this.bookmarkMozilla.TabIndex = 4;
            this.bookmarkMozilla.Text = "Bookmarks";
            this.bookmarkMozilla.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.bookmarkSort);
            this.splitContainer4.Panel1.Controls.Add(this.bookmarkAscDsc);
            this.splitContainer4.Panel1.Controls.Add(this.sortBookmarks);
            this.splitContainer4.Panel1.Controls.Add(this.label4);
            this.splitContainer4.Panel1.Controls.Add(this.searchBoxBookmark);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.bookmarkMozillaGrid);
            this.splitContainer4.Size = new System.Drawing.Size(1056, 554);
            this.splitContainer4.SplitterDistance = 37;
            this.splitContainer4.TabIndex = 0;
            // 
            // bookmarkSort
            // 
            this.bookmarkSort.Location = new System.Drawing.Point(978, 5);
            this.bookmarkSort.Name = "bookmarkSort";
            this.bookmarkSort.Size = new System.Drawing.Size(75, 23);
            this.bookmarkSort.TabIndex = 17;
            this.bookmarkSort.Text = "Sort";
            this.bookmarkSort.UseVisualStyleBackColor = true;
            this.bookmarkSort.Click += new System.EventHandler(this.bookmarkSort_Click);
            // 
            // bookmarkAscDsc
            // 
            this.bookmarkAscDsc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookmarkAscDsc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bookmarkAscDsc.FormattingEnabled = true;
            this.bookmarkAscDsc.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.bookmarkAscDsc.Location = new System.Drawing.Point(836, 7);
            this.bookmarkAscDsc.Name = "bookmarkAscDsc";
            this.bookmarkAscDsc.Size = new System.Drawing.Size(121, 21);
            this.bookmarkAscDsc.TabIndex = 16;
            // 
            // sortBookmarks
            // 
            this.sortBookmarks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortBookmarks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sortBookmarks.FormattingEnabled = true;
            this.sortBookmarks.Items.AddRange(new object[] {
            "Url",
            "Title",
            "DateAdded",
            "LastModified"});
            this.sortBookmarks.Location = new System.Drawing.Point(698, 7);
            this.sortBookmarks.Name = "sortBookmarks";
            this.sortBookmarks.Size = new System.Drawing.Size(121, 21);
            this.sortBookmarks.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Search in Table:";
            // 
            // searchBoxBookmark
            // 
            this.searchBoxBookmark.Location = new System.Drawing.Point(99, 7);
            this.searchBoxBookmark.Name = "searchBoxBookmark";
            this.searchBoxBookmark.Size = new System.Drawing.Size(244, 20);
            this.searchBoxBookmark.TabIndex = 13;
            this.searchBoxBookmark.TextChanged += new System.EventHandler(this.searchBoxBookmark_TextChanged);
            // 
            // bookmarkMozillaGrid
            // 
            this.bookmarkMozillaGrid.AllowUserToAddRows = false;
            this.bookmarkMozillaGrid.AllowUserToDeleteRows = false;
            this.bookmarkMozillaGrid.AutoGenerateColumns = false;
            this.bookmarkMozillaGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bookmarkMozillaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookmarkMozillaGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urlDataGridViewTextBoxColumn1,
            this.titleDataGridViewTextBoxColumn1,
            this.dateAddedDataGridViewTextBoxColumn,
            this.lastModifiedDataGridViewTextBoxColumn,
            this.addToReportBookmark});
            this.bookmarkMozillaGrid.DataSource = this.bookmarksMozillaBindingSource;
            this.bookmarkMozillaGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookmarkMozillaGrid.Location = new System.Drawing.Point(0, 0);
            this.bookmarkMozillaGrid.Name = "bookmarkMozillaGrid";
            this.bookmarkMozillaGrid.Size = new System.Drawing.Size(1056, 513);
            this.bookmarkMozillaGrid.TabIndex = 0;
            // 
            // urlDataGridViewTextBoxColumn1
            // 
            this.urlDataGridViewTextBoxColumn1.DataPropertyName = "Url";
            this.urlDataGridViewTextBoxColumn1.HeaderText = "Url";
            this.urlDataGridViewTextBoxColumn1.Name = "urlDataGridViewTextBoxColumn1";
            this.urlDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn1
            // 
            this.titleDataGridViewTextBoxColumn1.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn1.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
            this.titleDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dateAddedDataGridViewTextBoxColumn
            // 
            this.dateAddedDataGridViewTextBoxColumn.DataPropertyName = "DateAdded";
            this.dateAddedDataGridViewTextBoxColumn.HeaderText = "DateAdded";
            this.dateAddedDataGridViewTextBoxColumn.Name = "dateAddedDataGridViewTextBoxColumn";
            this.dateAddedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastModifiedDataGridViewTextBoxColumn
            // 
            this.lastModifiedDataGridViewTextBoxColumn.DataPropertyName = "LastModified";
            this.lastModifiedDataGridViewTextBoxColumn.HeaderText = "LastModified";
            this.lastModifiedDataGridViewTextBoxColumn.Name = "lastModifiedDataGridViewTextBoxColumn";
            this.lastModifiedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addToReportBookmark
            // 
            this.addToReportBookmark.HeaderText = "Add To Report";
            this.addToReportBookmark.Name = "addToReportBookmark";
            // 
            // bookmarksMozillaBindingSource
            // 
            this.bookmarksMozillaBindingSource.DataSource = typeof(BrowserCheck.Model.BookmarksMozilla);
            // 
            // cookiesMozilla
            // 
            this.cookiesMozilla.Controls.Add(this.splitContainer5);
            this.cookiesMozilla.Location = new System.Drawing.Point(4, 22);
            this.cookiesMozilla.Name = "cookiesMozilla";
            this.cookiesMozilla.Size = new System.Drawing.Size(1056, 554);
            this.cookiesMozilla.TabIndex = 5;
            this.cookiesMozilla.Text = "Cookies";
            this.cookiesMozilla.UseVisualStyleBackColor = true;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.IsSplitterFixed = true;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.cookiesMozillaSort);
            this.splitContainer5.Panel1.Controls.Add(this.cookiesAscDsc);
            this.splitContainer5.Panel1.Controls.Add(this.sortCookies);
            this.splitContainer5.Panel1.Controls.Add(this.label5);
            this.splitContainer5.Panel1.Controls.Add(this.searchBoxCookies);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.cookiesMozillaGrid);
            this.splitContainer5.Size = new System.Drawing.Size(1056, 554);
            this.splitContainer5.SplitterDistance = 38;
            this.splitContainer5.TabIndex = 0;
            // 
            // cookiesMozillaSort
            // 
            this.cookiesMozillaSort.Location = new System.Drawing.Point(973, 7);
            this.cookiesMozillaSort.Name = "cookiesMozillaSort";
            this.cookiesMozillaSort.Size = new System.Drawing.Size(75, 23);
            this.cookiesMozillaSort.TabIndex = 22;
            this.cookiesMozillaSort.Text = "Sort";
            this.cookiesMozillaSort.UseVisualStyleBackColor = true;
            this.cookiesMozillaSort.Click += new System.EventHandler(this.cookiesMozillaSort_Click);
            // 
            // cookiesAscDsc
            // 
            this.cookiesAscDsc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cookiesAscDsc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cookiesAscDsc.FormattingEnabled = true;
            this.cookiesAscDsc.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.cookiesAscDsc.Location = new System.Drawing.Point(831, 9);
            this.cookiesAscDsc.Name = "cookiesAscDsc";
            this.cookiesAscDsc.Size = new System.Drawing.Size(121, 21);
            this.cookiesAscDsc.TabIndex = 21;
            // 
            // sortCookies
            // 
            this.sortCookies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortCookies.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sortCookies.FormattingEnabled = true;
            this.sortCookies.Items.AddRange(new object[] {
            "Name",
            "Value",
            "Host",
            "CookiePath",
            "Expiry",
            "LastAccessed",
            "CreationTime"});
            this.sortCookies.Location = new System.Drawing.Point(693, 9);
            this.sortCookies.Name = "sortCookies";
            this.sortCookies.Size = new System.Drawing.Size(121, 21);
            this.sortCookies.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Search in Table:";
            // 
            // searchBoxCookies
            // 
            this.searchBoxCookies.Location = new System.Drawing.Point(102, 9);
            this.searchBoxCookies.Name = "searchBoxCookies";
            this.searchBoxCookies.Size = new System.Drawing.Size(244, 20);
            this.searchBoxCookies.TabIndex = 18;
            this.searchBoxCookies.TextChanged += new System.EventHandler(this.searchBoxCookies_TextChanged_1);
            // 
            // cookiesMozillaGrid
            // 
            this.cookiesMozillaGrid.AllowUserToAddRows = false;
            this.cookiesMozillaGrid.AllowUserToDeleteRows = false;
            this.cookiesMozillaGrid.AutoGenerateColumns = false;
            this.cookiesMozillaGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cookiesMozillaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cookiesMozillaGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn1,
            this.hostDataGridViewTextBoxColumn,
            this.CookiePath,
            this.expiryDataGridViewTextBoxColumn,
            this.lastAccessedDataGridViewTextBoxColumn,
            this.creationTimeDataGridViewTextBoxColumn,
            this.addToReportCookies});
            this.cookiesMozillaGrid.DataSource = this.cookiesMozillaBindingSource;
            this.cookiesMozillaGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cookiesMozillaGrid.Location = new System.Drawing.Point(0, 0);
            this.cookiesMozillaGrid.Name = "cookiesMozillaGrid";
            this.cookiesMozillaGrid.Size = new System.Drawing.Size(1056, 512);
            this.cookiesMozillaGrid.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valueDataGridViewTextBoxColumn1
            // 
            this.valueDataGridViewTextBoxColumn1.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn1.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn1.Name = "valueDataGridViewTextBoxColumn1";
            this.valueDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // hostDataGridViewTextBoxColumn
            // 
            this.hostDataGridViewTextBoxColumn.DataPropertyName = "Host";
            this.hostDataGridViewTextBoxColumn.HeaderText = "Host";
            this.hostDataGridViewTextBoxColumn.Name = "hostDataGridViewTextBoxColumn";
            this.hostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CookiePath
            // 
            this.CookiePath.DataPropertyName = "CookiePath";
            this.CookiePath.HeaderText = "CookiePath";
            this.CookiePath.Name = "CookiePath";
            this.CookiePath.ReadOnly = true;
            // 
            // expiryDataGridViewTextBoxColumn
            // 
            this.expiryDataGridViewTextBoxColumn.DataPropertyName = "Expiry";
            this.expiryDataGridViewTextBoxColumn.HeaderText = "Expiry";
            this.expiryDataGridViewTextBoxColumn.Name = "expiryDataGridViewTextBoxColumn";
            this.expiryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastAccessedDataGridViewTextBoxColumn
            // 
            this.lastAccessedDataGridViewTextBoxColumn.DataPropertyName = "LastAccessed";
            this.lastAccessedDataGridViewTextBoxColumn.HeaderText = "LastAccessed";
            this.lastAccessedDataGridViewTextBoxColumn.Name = "lastAccessedDataGridViewTextBoxColumn";
            this.lastAccessedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creationTimeDataGridViewTextBoxColumn
            // 
            this.creationTimeDataGridViewTextBoxColumn.DataPropertyName = "CreationTime";
            this.creationTimeDataGridViewTextBoxColumn.HeaderText = "CreationTime";
            this.creationTimeDataGridViewTextBoxColumn.Name = "creationTimeDataGridViewTextBoxColumn";
            this.creationTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addToReportCookies
            // 
            this.addToReportCookies.HeaderText = "Add To Report";
            this.addToReportCookies.Name = "addToReportCookies";
            // 
            // cookiesMozillaBindingSource
            // 
            this.cookiesMozillaBindingSource.DataSource = typeof(BrowserCheck.Model.CookiesMozilla);
            // 
            // annosMozilla
            // 
            this.annosMozilla.Controls.Add(this.splitContainer6);
            this.annosMozilla.Location = new System.Drawing.Point(4, 22);
            this.annosMozilla.Name = "annosMozilla";
            this.annosMozilla.Padding = new System.Windows.Forms.Padding(3);
            this.annosMozilla.Size = new System.Drawing.Size(1056, 554);
            this.annosMozilla.TabIndex = 6;
            this.annosMozilla.Text = "Downloads";
            this.annosMozilla.UseVisualStyleBackColor = true;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.IsSplitterFixed = true;
            this.splitContainer6.Location = new System.Drawing.Point(3, 3);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.sortAnnosMozilla);
            this.splitContainer6.Panel1.Controls.Add(this.annosAscDsc);
            this.splitContainer6.Panel1.Controls.Add(this.sortAnnos);
            this.splitContainer6.Panel1.Controls.Add(this.label6);
            this.splitContainer6.Panel1.Controls.Add(this.searcBoxAnnos);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.annosMozillaGrid);
            this.splitContainer6.Size = new System.Drawing.Size(1050, 548);
            this.splitContainer6.SplitterDistance = 34;
            this.splitContainer6.TabIndex = 0;
            // 
            // sortAnnosMozilla
            // 
            this.sortAnnosMozilla.Location = new System.Drawing.Point(970, 6);
            this.sortAnnosMozilla.Name = "sortAnnosMozilla";
            this.sortAnnosMozilla.Size = new System.Drawing.Size(75, 23);
            this.sortAnnosMozilla.TabIndex = 27;
            this.sortAnnosMozilla.Text = "Sort";
            this.sortAnnosMozilla.UseVisualStyleBackColor = true;
            this.sortAnnosMozilla.Click += new System.EventHandler(this.sortAnnosMozilla_Click);
            // 
            // annosAscDsc
            // 
            this.annosAscDsc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.annosAscDsc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.annosAscDsc.FormattingEnabled = true;
            this.annosAscDsc.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.annosAscDsc.Location = new System.Drawing.Point(828, 8);
            this.annosAscDsc.Name = "annosAscDsc";
            this.annosAscDsc.Size = new System.Drawing.Size(121, 21);
            this.annosAscDsc.TabIndex = 26;
            // 
            // sortAnnos
            // 
            this.sortAnnos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortAnnos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sortAnnos.FormattingEnabled = true;
            this.sortAnnos.Items.AddRange(new object[] {
            "Content",
            "DateAdded",
            "LastModified"});
            this.sortAnnos.Location = new System.Drawing.Point(690, 8);
            this.sortAnnos.Name = "sortAnnos";
            this.sortAnnos.Size = new System.Drawing.Size(121, 21);
            this.sortAnnos.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Search in Table:";
            // 
            // searcBoxAnnos
            // 
            this.searcBoxAnnos.Location = new System.Drawing.Point(99, 8);
            this.searcBoxAnnos.Name = "searcBoxAnnos";
            this.searcBoxAnnos.Size = new System.Drawing.Size(244, 20);
            this.searcBoxAnnos.TabIndex = 23;
            this.searcBoxAnnos.TextChanged += new System.EventHandler(this.searcBoxAnnos_TextChanged);
            // 
            // annosMozillaGrid
            // 
            this.annosMozillaGrid.AllowUserToAddRows = false;
            this.annosMozillaGrid.AllowUserToDeleteRows = false;
            this.annosMozillaGrid.AutoGenerateColumns = false;
            this.annosMozillaGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.annosMozillaGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.annosMozillaGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contentDataGridViewTextBoxColumn,
            this.dateAddedDataGridViewTextBoxColumn1,
            this.lastModifiedDataGridViewTextBoxColumn1,
            this.addToReportAnnos});
            this.annosMozillaGrid.DataSource = this.annosMozillaBindingSource;
            this.annosMozillaGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.annosMozillaGrid.Location = new System.Drawing.Point(0, 0);
            this.annosMozillaGrid.Name = "annosMozillaGrid";
            this.annosMozillaGrid.Size = new System.Drawing.Size(1050, 510);
            this.annosMozillaGrid.TabIndex = 0;
            // 
            // contentDataGridViewTextBoxColumn
            // 
            this.contentDataGridViewTextBoxColumn.DataPropertyName = "Content";
            this.contentDataGridViewTextBoxColumn.HeaderText = "Content";
            this.contentDataGridViewTextBoxColumn.Name = "contentDataGridViewTextBoxColumn";
            this.contentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateAddedDataGridViewTextBoxColumn1
            // 
            this.dateAddedDataGridViewTextBoxColumn1.DataPropertyName = "DateAdded";
            this.dateAddedDataGridViewTextBoxColumn1.HeaderText = "DateAdded";
            this.dateAddedDataGridViewTextBoxColumn1.Name = "dateAddedDataGridViewTextBoxColumn1";
            this.dateAddedDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lastModifiedDataGridViewTextBoxColumn1
            // 
            this.lastModifiedDataGridViewTextBoxColumn1.DataPropertyName = "LastModified";
            this.lastModifiedDataGridViewTextBoxColumn1.HeaderText = "LastModified";
            this.lastModifiedDataGridViewTextBoxColumn1.Name = "lastModifiedDataGridViewTextBoxColumn1";
            this.lastModifiedDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // addToReportAnnos
            // 
            this.addToReportAnnos.HeaderText = "Add To Report";
            this.addToReportAnnos.Name = "addToReportAnnos";
            // 
            // annosMozillaBindingSource
            // 
            this.annosMozillaBindingSource.DataSource = typeof(BrowserCheck.Model.AnnosMozilla);
            // 
            // printTab
            // 
            this.printTab.Controls.Add(this.panel1);
            this.printTab.Location = new System.Drawing.Point(4, 22);
            this.printTab.Name = "printTab";
            this.printTab.Size = new System.Drawing.Size(1056, 554);
            this.printTab.TabIndex = 2;
            this.printTab.Text = "Print";
            this.printTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 554);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.IsSplitterFixed = true;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer7.Panel1.Controls.Add(this.label8);
            this.splitContainer7.Panel1.Controls.Add(this.label7);
            this.splitContainer7.Panel1.Controls.Add(this.reportName);
            this.splitContainer7.Panel1.Controls.Add(this.reportNote);
            this.splitContainer7.Panel1.Controls.Add(this.printButton);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer7.Panel2.Controls.Add(this.addPicture);
            this.splitContainer7.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer7.Panel2.Controls.Add(this.profilePic);
            this.splitContainer7.Size = new System.Drawing.Size(1056, 554);
            this.splitContainer7.SplitterDistance = 722;
            this.splitContainer7.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Report Notes:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Report Name:";
            // 
            // reportName
            // 
            this.reportName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportName.Location = new System.Drawing.Point(57, 47);
            this.reportName.Name = "reportName";
            this.reportName.Size = new System.Drawing.Size(575, 20);
            this.reportName.TabIndex = 15;
            // 
            // reportNote
            // 
            this.reportNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportNote.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.reportNote.Location = new System.Drawing.Point(57, 99);
            this.reportNote.MaxLength = 300;
            this.reportNote.Name = "reportNote";
            this.reportNote.Size = new System.Drawing.Size(575, 405);
            this.reportNote.TabIndex = 14;
            this.reportNote.Text = "";
            this.reportNote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.reportNote_KeyPress);
            // 
            // printButton
            // 
            this.printButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.printButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printButton.ImageIndex = 1;
            this.printButton.ImageList = this.imageList;
            this.printButton.Location = new System.Drawing.Point(321, 510);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 28);
            this.printButton.TabIndex = 13;
            this.printButton.Text = "Print";
            this.printButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "user.png");
            this.imageList.Images.SetKeyName(1, "save.png");
            this.imageList.Images.SetKeyName(2, "plus.png");
            // 
            // addPicture
            // 
            this.addPicture.Enabled = false;
            this.addPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addPicture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addPicture.ImageIndex = 2;
            this.addPicture.ImageList = this.imageList;
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
            // openFilePicutre
            // 
            this.openFilePicutre.FileName = "filePicture";
            // 
            // MozillaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 580);
            this.Controls.Add(this.mozillaTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MozillaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mozilla Datas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mozillaTabControl.ResumeLayout(false);
            this.formHistoryMozilla.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.formHistoryGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formHistoryMozillaBindingSource)).EndInit();
            this.webHistoryMozilla.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webHistoryGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webHistoryMozillaBindingSource)).EndInit();
            this.inputHistoryMozilla.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputHistoryGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ınputHistoryMozillaBindingSource)).EndInit();
            this.bookmarkMozilla.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookmarkMozillaGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookmarksMozillaBindingSource)).EndInit();
            this.cookiesMozilla.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cookiesMozillaGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cookiesMozillaBindingSource)).EndInit();
            this.annosMozilla.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel1.PerformLayout();
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.annosMozillaGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.annosMozillaBindingSource)).EndInit();
            this.printTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel1.PerformLayout();
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource formHistoryMozillaBindingSource;
        private System.Windows.Forms.TabControl mozillaTabControl;
        private System.Windows.Forms.TabPage webHistoryMozilla;
        private System.Windows.Forms.TabPage formHistoryMozilla;
        private System.Windows.Forms.TabPage printTab;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ascDsc;
        private System.Windows.Forms.ComboBox sortColumnsCombo;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.DataGridView formHistoryGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button webHistorySort;
        private System.Windows.Forms.ComboBox webAscDsc;
        private System.Windows.Forms.ComboBox sortWeb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchBoxWeb;
        private System.Windows.Forms.DataGridView webHistoryGrid;
        private System.Windows.Forms.BindingSource webHistoryMozillaBindingSource;
        private System.Windows.Forms.TabPage inputHistoryMozilla;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button inputHistorySort;
        private System.Windows.Forms.ComboBox inputAscDsc;
        private System.Windows.Forms.ComboBox inputSort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchBoxInput;
        private System.Windows.Forms.DataGridView inputHistoryGrid;
        private System.Windows.Forms.BindingSource ınputHistoryMozillaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ınputDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usecountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn addToReportInput;
        private System.Windows.Forms.TabPage bookmarkMozilla;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Button bookmarkSort;
        private System.Windows.Forms.ComboBox bookmarkAscDsc;
        private System.Windows.Forms.ComboBox sortBookmarks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchBoxBookmark;
        private System.Windows.Forms.DataGridView bookmarkMozillaGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAddedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastModifiedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn addToReportBookmark;
        private System.Windows.Forms.BindingSource bookmarksMozillaBindingSource;
        private System.Windows.Forms.TabPage cookiesMozilla;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.Button cookiesMozillaSort;
        private System.Windows.Forms.ComboBox cookiesAscDsc;
        private System.Windows.Forms.ComboBox sortCookies;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox searchBoxCookies;
        private System.Windows.Forms.DataGridView cookiesMozillaGrid;
        private System.Windows.Forms.BindingSource cookiesMozillaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CookiePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastAccessedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn addToReportCookies;
        private System.Windows.Forms.TabPage annosMozilla;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.Button sortAnnosMozilla;
        private System.Windows.Forms.ComboBox annosAscDsc;
        private System.Windows.Forms.ComboBox sortAnnos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox searcBoxAnnos;
        private System.Windows.Forms.DataGridView annosMozillaGrid;
        private System.Windows.Forms.BindingSource annosMozillaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAddedDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastModifiedDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn addToReportAnnos;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox reportName;
        private System.Windows.Forms.RichTextBox reportNote;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.Label evidenceNumber;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button addPicture;
        private System.Windows.Forms.OpenFileDialog openFilePicutre;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton noForPhoto;
        private System.Windows.Forms.RadioButton yesForPhoto;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeUsedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn addToReport;
        private System.Windows.Forms.DataGridViewLinkColumn browseUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastVisitDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn addToReportWeb;
    }
}