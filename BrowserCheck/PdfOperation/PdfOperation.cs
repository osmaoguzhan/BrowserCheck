using Spire.Pdf;
using Spire.Pdf.Graphics;
using Spire.Pdf.Tables;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BrowserCheck.Config
{
    class PdfOperation
    {

        PdfBrush brush1 = PdfBrushes.Black;
        PdfPageBase page;
        PdfTrueTypeFont font1 = new PdfTrueTypeFont(new Font("Arial", 16f, FontStyle.Bold));
        PdfTrueTypeFont fontInfo = new PdfTrueTypeFont(new Font("Arial", 12f, FontStyle.Regular));
        PdfStringFormat format1 = new PdfStringFormat(PdfTextAlignment.Center);
        PdfStringFormat leftAlignment = new PdfStringFormat(PdfTextAlignment.Left, PdfVerticalAlignment.Middle);
        private static string yourRoot = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Reports\\"+Global.Session.Instance.MyUser.Email;
        public bool printPdf(PdfDocument doc, PdfSection sec, string name, string[] dataset)
        {
            float y = 10;
            bool check = true;
            if (dataset.Length != 1)
            {
                page = sec.Pages.Add();
                try
                {
                    page.Canvas.DrawString(name, font1, brush1, page.Canvas.ClientSize.Width / 2, y, format1);
                    y += font1.MeasureString("Country List", format1).Height;
                    y += 5;
                    String[][] dataSource = new String[dataset.Length][];
                    for (int i = 0; i < dataset.Length; i++)
                    {
                        dataSource[i] = dataset[i].Split(';');
                    }
                    PdfTable table = new PdfTable();
                    table.Style.CellPadding = 2;
                    table.Style.BorderPen = new PdfPen(brush1, 0.75f);
                    table.Style.HeaderStyle.StringFormat = new PdfStringFormat(PdfTextAlignment.Center);
                    table.Style.HeaderSource = PdfHeaderSource.Rows;
                    table.Style.HeaderRowCount = 1;
                    table.Style.ShowHeader = true;
                    table.Style.HeaderStyle.BackgroundBrush = PdfBrushes.CadetBlue;
                    table.DataSource = dataSource;
                    foreach (PdfColumn column in table.Columns)
                    {
                        column.StringFormat = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
                    }
                    table.Draw(page, new PointF(0, y));
                }
                catch
                {
                    check = false;
                }
            }
            return check;
        }
        public bool introPdf(PdfDocument doc, PdfSection sec, string name, string surname, string email, string note, string pathOfImage, int numberOfNewLine,bool argument)
        {
            float intro = 10;
            try
            {
                page = sec.Pages.Add();

                float width = 0;
                float height = 0;
                if (argument)
                {
                    PdfImage image = PdfImage.FromFile(pathOfImage);
                    if (image.Width < 150 || image.Height < 150)
                    {
                        return false;
                    }
                    else
                    {
                        width = 150;height = 150;
                        float x = (page.Canvas.ClientSize.Width - width) / 2;
                        page.Canvas.DrawImage(image, x, intro, width, height);
                    }
                }
                intro += height;
                page.Canvas.DrawString("Browser Report", font1, brush1, page.Canvas.ClientSize.Width / 2, intro, format1);
                intro += fontInfo.MeasureString("Country List", format1).Height;
                intro += 20;
                page.Canvas.DrawString("Name    : " + name, fontInfo, brush1, 0, intro, leftAlignment);
                intro += 20;
                page.Canvas.DrawString("Surname : " + surname, fontInfo, brush1, 0, intro, leftAlignment);
                intro += 20;
                page.Canvas.DrawString("E-Mail  : " + email, fontInfo, brush1, 0, intro, leftAlignment);
                if (numberOfNewLine <= 1)
                {
                    intro = intro + 20 * numberOfNewLine;
                }
                else
                {
                    intro = intro + (20 * numberOfNewLine)- fontInfo.MeasureString("Country List", format1).Height;
                }
               
                if (note.Length != 0)
                    page.Canvas.DrawString("Notes   : " + note, fontInfo, brush1, 0, intro, leftAlignment);
                return true;
                
            }
            catch
            {
                Exception.ThrowExc.Instance.ErrorMessage(Const.Constants.ERROR_WHILE_CREATING);
                return false;
            }

        }

        public int savePdf(PdfDocument doc, string name)
        {
            if (!Directory.Exists(yourRoot))
            {
                Directory.CreateDirectory(yourRoot);
            }
            yourRoot += "\\";
            if (File.Exists(yourRoot+name + ".pdf"))
            {
                DialogResult result = Exception.ThrowExc.Instance.WarningYesNo(Const.Constants.WANT_OVERWRITE);
                switch (result)
                {
                    case DialogResult.Yes:
                        try
                        {
                            doc.SaveToFile(yourRoot + name + ".pdf");
                            return 1;
                        }
                        catch
                        {
                            return -1;
                        }
                    case DialogResult.No:
                        break;
                }
            }
            else
            {
                try
                {
                    doc.SaveToFile(yourRoot + name + ".pdf");
                    return 1;
                }
                catch
                {
                    return -1;
                }
            }
            return 0;
        }
    }
}
