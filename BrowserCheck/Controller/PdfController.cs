using Spire.Pdf;
using System;
using BrowserCheck.Config;
using System.Windows.Forms;

namespace BrowserCheck.Controller
{
    class PdfController
    {
        readonly PdfOperation pdfOp = new PdfOperation();
        public PdfDocument Create()
        {
            return new PdfDocument();
        }
        public void CreatePdf(PdfDocument doc, PdfSection sec,DataGridView grid, int columnNumber, string title)
        {
            string[] datasetArray = new string[Calculate(grid, columnNumber) + 1];
            datasetArray = FillArray(grid, datasetArray, columnNumber);
            sec = doc.Sections.Add();
            sec.PageSettings.Width = PdfPageSize.A4.Width;
            bool check = pdfOp.PrintPdf(sec, title, datasetArray);
            if (!check)
                MessageBox.Show("During " + title + " pdf operations got an error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        public bool PdfIntro(PdfDocument doc, PdfSection sec,string note,string imageLocation,int lineCount,bool argument)
        {
            sec = doc.Sections.Add();
            sec.PageSettings.Width = PdfPageSize.A4.Width;
            return pdfOp.IntroPdf(sec, Global.Session.Instance.MyUser.Name, Global.Session.Instance.MyUser.Surname, Global.Session.Instance.MyUser.Email, note, imageLocation, lineCount, argument);
        }
        string[] FillArray(DataGridView grid, string[] array, int columnNumber)
        {

            string header = "";
            for (int i = 0; i < columnNumber; i++)
            {
                header += grid.Columns[i].HeaderText + ";";
            }
            header = header.Remove(header.Length - 1);
            array[0] = header;
            int j = 1;
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (Convert.ToBoolean(row.Cells[columnNumber].Value))
                {
                    array[j] = "";
                    for (int i = 0; i < columnNumber; i++)
                    {
                        array[j] += row.Cells[i].Value.ToString() + ";";
                    }
                    array[j] = array[j].Remove(array[j].Length - 1);
                    j++;

                }

            }
            return array;
        }
        int Calculate(DataGridView grid, int checkboxCell)
        {
            int counter = 0;
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (Convert.ToBoolean(row.Cells[checkboxCell].Value))
                {
                    counter++;
                }
            }
            return counter;
        }

    }

}

