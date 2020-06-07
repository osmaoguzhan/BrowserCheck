namespace BrowserCheck.Forms
{
    partial class CasePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CasePage));
            this.folderItem = new System.Windows.Forms.FolderBrowserDialog();
            this.chooseDir = new System.Windows.Forms.Button();
            this.pathOfDir = new System.Windows.Forms.TextBox();
            this.chromeRadio = new System.Windows.Forms.RadioButton();
            this.firefoxRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.scanButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderItem
            // 
            this.folderItem.Description = "Choose Browser Path";
            this.folderItem.RootFolder = System.Environment.SpecialFolder.ApplicationData;
            this.folderItem.SelectedPath = "C:\\Users\\VV\\AppData";
            this.folderItem.ShowNewFolderButton = false;
            // 
            // chooseDir
            // 
            this.chooseDir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.chooseDir.FlatAppearance.BorderSize = 2;
            this.chooseDir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.chooseDir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.chooseDir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chooseDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chooseDir.Image = global::BrowserCheck.Properties.Resources.folder;
            this.chooseDir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chooseDir.Location = new System.Drawing.Point(263, 52);
            this.chooseDir.Name = "chooseDir";
            this.chooseDir.Size = new System.Drawing.Size(99, 29);
            this.chooseDir.TabIndex = 13;
            this.chooseDir.Text = "Choose Directory";
            this.chooseDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chooseDir.UseVisualStyleBackColor = false;
            this.chooseDir.Click += new System.EventHandler(this.chooseDir_Click_1);
            // 
            // pathOfDir
            // 
            this.pathOfDir.Enabled = false;
            this.pathOfDir.Location = new System.Drawing.Point(135, 12);
            this.pathOfDir.Name = "pathOfDir";
            this.pathOfDir.Size = new System.Drawing.Size(346, 20);
            this.pathOfDir.TabIndex = 12;
            // 
            // chromeRadio
            // 
            this.chromeRadio.AutoSize = true;
            this.chromeRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chromeRadio.Location = new System.Drawing.Point(6, 70);
            this.chromeRadio.Name = "chromeRadio";
            this.chromeRadio.Size = new System.Drawing.Size(83, 24);
            this.chromeRadio.TabIndex = 1;
            this.chromeRadio.Text = "Chrome";
            this.chromeRadio.UseVisualStyleBackColor = true;
            // 
            // firefoxRadio
            // 
            this.firefoxRadio.AutoSize = true;
            this.firefoxRadio.Checked = true;
            this.firefoxRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firefoxRadio.Location = new System.Drawing.Point(6, 40);
            this.firefoxRadio.Name = "firefoxRadio";
            this.firefoxRadio.Size = new System.Drawing.Size(75, 24);
            this.firefoxRadio.TabIndex = 0;
            this.firefoxRadio.TabStop = true;
            this.firefoxRadio.Text = "Firefox";
            this.firefoxRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chromeRadio);
            this.groupBox1.Controls.Add(this.firefoxRadio);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 119);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // scanButton
            // 
            this.scanButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.scanButton.FlatAppearance.BorderSize = 2;
            this.scanButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.scanButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.scanButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.scanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scanButton.Image = global::BrowserCheck.Properties.Resources.search;
            this.scanButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scanButton.Location = new System.Drawing.Point(400, 95);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(86, 36);
            this.scanButton.TabIndex = 11;
            this.scanButton.Text = "Scan";
            this.scanButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.scanButton.UseVisualStyleBackColor = false;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click_1);
            // 
            // CasePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 145);
            this.Controls.Add(this.chooseDir);
            this.Controls.Add(this.pathOfDir);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CasePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Case Page";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderItem;
        private System.Windows.Forms.Button chooseDir;
        private System.Windows.Forms.TextBox pathOfDir;
        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.RadioButton chromeRadio;
        private System.Windows.Forms.RadioButton firefoxRadio;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}