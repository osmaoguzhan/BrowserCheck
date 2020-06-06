using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrowserCheck.Const;

namespace BrowserCheck.Validator
{
    class UserValidator
    {
        private static UserValidator _Instance;

        public static UserValidator Instance
        {

            get
            {
                if (_Instance == null)
                {
                    _Instance = new UserValidator();
                }
                return (_Instance);
            }
        }

        public bool checkEmail(string email)
        {
            bool isEmail = Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (isEmail)
            {
                return true;
            }
            else
            {
                return false;
            }
               
            
        }

        public bool checkPassword(string password)
        {
            if(password.Length < 6)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool isNanOrEmpty(string name, string surname, string email, string password)
        {
            return string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password);
        }
    }
}
