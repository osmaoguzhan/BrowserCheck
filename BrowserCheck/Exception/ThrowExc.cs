using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowserCheck.Exception
{
    class ThrowExc
    {

        private static ThrowExc _Instance;

        public static ThrowExc Instance
        {

            get
            {
                if (_Instance == null)
                {
                    _Instance = new ThrowExc();
                }
                return (_Instance);
            }
        }

        public void ErrorMessage(string Message)
        {
            MessageBox.Show(Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void SuccessMessage(string Message)
        {
            MessageBox.Show(Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void WarningMessage(string Message)
        {
            MessageBox.Show(Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void InformationMessage(string Message)
        {
            MessageBox.Show(Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DialogResult WarningYesNo(string Message)
        {
            return MessageBox.Show(Message, "Overwrite", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}
