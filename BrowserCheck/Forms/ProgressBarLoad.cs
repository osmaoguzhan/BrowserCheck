using System;
using System.Windows.Forms;

namespace BrowserCheck.Forms
{
    public partial class ProgressBarLoad : Form
    {
        public ProgressBarLoad()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value != progressBar1.Maximum)
            {
                progressBar1.Increment(20);
            }
            else
            {
                this.Close();
            }
        }

        private void ProgressBarLoad_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            timer1.Start();
        }
    }
}
