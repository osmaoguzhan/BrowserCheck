using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrowserCheck.Model;
using BrowserCheck.DatabaseOperations;
using BrowserCheck.Global;
using BrowserCheck.Validator;
namespace BrowserCheck.Controller
{
    class UserController
    {
        UserDatabase dbOp = new UserDatabase();
        public string checkUser(string email,string password)
        {
            string message = String.Empty;
            bool check = dbOp.checkUser(email, password);
            if (!check)
            {
                message = Const.Constants.WRONG_CREDENTIALS;
            }
            return message;
        }
        public string saveUser(string name,string surname,string email,string password)
        {
            User user = new User();
            string ErrorMessage = String.Empty;
            bool checkEmail = Validator.UserValidator.Instance.checkEmail(email);
            bool checkPassword = Validator.UserValidator.Instance.checkPassword(password);
            bool checkTextBoxes = Validator.UserValidator.Instance.isNanOrEmpty(name, surname, email, password);

            if (!checkEmail) ErrorMessage += "\n"+ Const.Constants.NO_EMAIL;
            if (!checkPassword) ErrorMessage += "\n" + Const.Constants.SHORT_PASSWORD;
            if (checkTextBoxes) ErrorMessage += "\n" + Const.Constants.EMPTY_AREAS;
            user.Name = name;
            user.Surname = surname;
            user.Email = email;
            user.Password = password;
            if(string.IsNullOrEmpty(ErrorMessage)){
                bool addUserCheck = dbOp.addUser(user);
                if (!addUserCheck)
                {
                    ErrorMessage = Const.Constants.ERROR_WHILE_ADDING;
                }
            }
            return ErrorMessage;
        }
    }
}
