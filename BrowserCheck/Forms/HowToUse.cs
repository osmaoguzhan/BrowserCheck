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
    public partial class HowToUse : Form
    {
        public HowToUse()
        {
            InitializeComponent();

        }

        private void HowToUse_Load(object sender, EventArgs e)
        {

            string curDir = Directory.GetCurrentDirectory()+ "\\..\\..\\ApplicationFiles\\File\\howtouse.html";
            Console.WriteLine(curDir + "\\ApplicationFiles\\File\\howtouse.html");
            this.webBrowser.Url = new Uri(String.Format("file:///{0}", curDir));
        }
    }
}
