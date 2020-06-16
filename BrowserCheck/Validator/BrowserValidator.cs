using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserCheck.Validator
{
    class BrowserValidator
    {
        private static BrowserValidator _Instance;

        public static BrowserValidator Instance
        {

            get
            {
                if (_Instance == null)
                {
                    _Instance = new BrowserValidator();
                }
                return (_Instance);
            }
        }
        public bool checkFile(string path)
        {
            bool control = false;
            if (File.Exists(path))
            {
                control = true;
            }
            return control;
        }
    }
}
