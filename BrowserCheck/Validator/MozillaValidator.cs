using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserCheck.Validator
{
    class MozillaValidator
    {
        private static MozillaValidator _Instance;

        public static MozillaValidator Instance
        {

            get
            {
                if (_Instance == null)
                {
                    _Instance = new MozillaValidator();
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
