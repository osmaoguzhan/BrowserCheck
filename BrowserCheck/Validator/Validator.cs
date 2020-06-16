using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserCheck.Validator
{
    class Validator
    {
        BrowserValidator BrowserValidator = new BrowserValidator();
        UserValidator UserValidator = new UserValidator();

        private static Validator _Instance;

        public static Validator Instance
        {

            get
            {
                if (_Instance == null)
                {
                    _Instance = new Validator();
                }
                return (_Instance);
            }
        }
    }
}
