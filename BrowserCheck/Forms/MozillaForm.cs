﻿using BrowserCheck.Config;
using BrowserCheck.Controller;
using BrowserCheck.Model;
using Spire.Pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BrowserCheck.Forms
{
    public partial class MozillaForm : Form
    {
        MozillaController mozilla;
        static PdfController pdfController = new PdfController();
        PdfDocument doc = pdfController.create();
        PdfSection sec;
        PdfOperation setPdf = new PdfOperation();
        List<FormHistoryMozilla> formList = new List<FormHistoryMozilla>();
        List<WebHistoryMozilla> webList = new List<WebHistoryMozilla>();
        List<InputHistoryMozilla> inputList = new List<InputHistoryMozilla>();
        List<BookmarksMozilla> bookmarkList = new List<BookmarksMozilla>();
        List<CookiesMozilla> cookiesList = new List<CookiesMozilla>();
        List<AnnosMozilla> annosList = new List<AnnosMozilla>();
        public MozillaForm(MozillaController mozilla)
        {
            InitializeComponent();
            InitializeComboboxes();
            this.mozilla = mozilla;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            nameLabel.Text = Global.Session.Instance.MyUser.Name;
            surnameLabel.Text = Global.Session.Instance.MyUser.Surname;
            emailLabel.Text = Global.Session.Instance.MyUser.Email;
            formList = mozilla.getFormHistory();
            formHistoryGrid.DataSource = formList;
            webList = mozilla.getWebHistory();
            webHistoryGrid.DataSource = webList;
            inputList = mozilla.getInputHistory();
            inputHistoryGrid.DataSource = inputList;
            bookmarkList = mozilla.getBookmarks();
            bookmarkMozillaGrid.DataSource = bookmarkList;
            cookiesList = mozilla.getCookies();
            cookiesMozillaGrid.DataSource = cookiesList;
            annosList = mozilla.getAnnos();
            annosMozillaGrid.DataSource = annosList;

        }
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            formHistoryGrid.DataSource = formList.Where(x => x.Value.Contains(searchBox.Text) || x.FieldName.Contains(searchBox.Text)).ToList();
        }
        private void sortButton_Click(object sender, EventArgs e)
        {
            formHistoryGrid.DataSource = Common.Common.Instance.Sort_List<FormHistoryMozilla>(ascDsc.SelectedItem.ToString(), sortColumnsCombo.SelectedItem.ToString(), formList);
        }
        private void searchBoxWeb_TextChanged(object sender, EventArgs e)
        {
            webHistoryGrid.DataSource = webList.Where(x => x.Url.Contains(searchBoxWeb.Text) || x.Title.Contains(searchBoxWeb.Text) || x.Description.Contains(searchBoxWeb.Text)).ToList();
        }
        private void webHistorySort_Click(object sender, EventArgs e)
        {
            webHistoryGrid.DataSource = Common.Common.Instance.Sort_List<WebHistoryMozilla>(webAscDsc.SelectedItem.ToString(), sortWeb.SelectedItem.ToString(), webList);
        }
        private void searchBoxInput_TextChanged(object sender, EventArgs e)
        {
            inputHistoryGrid.DataSource = inputList.Where(x => x.Input.Contains(searchBoxInput.Text)).ToList();
        }
        private void inputHistorySort_Click(object sender, EventArgs e)
        {
            inputHistoryGrid.DataSource = Common.Common.Instance.Sort_List<InputHistoryMozilla>(inputAscDsc.SelectedItem.ToString(), inputSort.SelectedItem.ToString(), inputList);
        }
        private void searchBoxBookmark_TextChanged(object sender, EventArgs e)
        {
            bookmarkMozillaGrid.DataSource = bookmarkList.Where(x => x.Url.Contains(searchBoxBookmark.Text) || x.Title.Contains(searchBoxBookmark.Text)).ToList();

        }
        private void bookmarkSort_Click(object sender, EventArgs e)
        {
            bookmarkMozillaGrid.DataSource = Common.Common.Instance.Sort_List<BookmarksMozilla>(bookmarkAscDsc.SelectedItem.ToString(), sortBookmarks.SelectedItem.ToString(), bookmarkList);
        }
        private void searchBoxCookies_TextChanged_1(object sender, EventArgs e)
        {
            cookiesMozillaGrid.DataSource = cookiesList.Where(x => x.Host.Contains(searchBoxCookies.Text)
            || x.Name.Contains(searchBoxCookies.Text)
            || x.Value.Contains(searchBoxCookies.Text)
            || x.CookiePath.Contains(searchBoxCookies.Text)).ToList();
        }
        private void cookiesMozillaSort_Click(object sender, EventArgs e)
        {
            cookiesMozillaGrid.DataSource = Common.Common.Instance.Sort_List<CookiesMozilla>(cookiesAscDsc.SelectedItem.ToString(), sortCookies.SelectedItem.ToString(), cookiesList);
        }
        private void searcBoxAnnos_TextChanged(object sender, EventArgs e)
        {
            annosMozillaGrid.DataSource = annosList.Where(x => x.Content.Contains(searcBoxAnnos.Text)).ToList();
        }
        private void sortAnnosMozilla_Click(object sender, EventArgs e)
        {
            annosMozillaGrid.DataSource = Common.Common.Instance.Sort_List<AnnosMozilla>(annosAscDsc.SelectedItem.ToString(), sortAnnos.SelectedItem.ToString(), annosList);
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
        private void mozillaTabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == printTab)
            {
                this.MaximizeBox = false;
            }
            else
            {
                this.MaximizeBox = true;
            }
        }
        private void addPicture_Click(object sender, EventArgs e)
        {
            openFilePicutre.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFilePicutre.InitialDirectory = @"C:\";
            openFilePicutre.Title = "Please select an image file.";
            if (openFilePicutre.ShowDialog() == DialogResult.OK)
            {
                profilePic.Load(openFilePicutre.FileName);
            }
        }
        private void yesForPhoto_CheckedChanged(object sender, EventArgs e)
        {
            addPicture.Enabled = true;
        }
        private void noForPhoto_CheckedChanged(object sender, EventArgs e)
        {
            addPicture.Enabled = false;
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
        public void runCreatePdf(bool argument)
        {
            ProgressBarLoad progress = new ProgressBarLoad();
            progress.ShowDialog();
            bool controlForPhoto = pdfController.pdfIntro(doc,sec,reportNote.Text,profilePic.ImageLocation,reportNote.Lines.Count(), argument);
            if (controlForPhoto)
            {
                pdfController.createPdf(doc, sec, formHistoryGrid, 5, "Form History");
                pdfController.createPdf(doc, sec, webHistoryGrid, 5, "Web History");
                pdfController.createPdf(doc, sec, inputHistoryGrid, 2, "Input History");
                pdfController.createPdf(doc, sec, bookmarkMozillaGrid, 4, "Bookmark");
                pdfController.createPdf(doc, sec, cookiesMozillaGrid, 7, "Cookies");
                pdfController.createPdf(doc, sec, annosMozillaGrid, 3, "Downloads");
                int check = setPdf.savePdf(doc, reportName.Text);
                if (check == 1)
                {
                    Exception.ThrowExc.Instance.InformationMessage(Const.Constants.REPORT_CREATED);
                    reportNote.Text = "";
                    reportName.Text = "";
                    this.Close();
                }
                else if (check == -1) Exception.ThrowExc.Instance.ErrorMessage(Const.Constants.REPORT_COULDNT_SAVED);
            }else
            {
                Exception.ThrowExc.Instance.ErrorMessage(Const.Constants.PICTURE_SIZE_ERROR);
                doc = null;
                doc = pdfController.create();
            }           
        }
       
    }
}