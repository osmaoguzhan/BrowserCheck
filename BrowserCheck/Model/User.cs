using System;
using System.IO;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserCheck.Model
{
    public class User
    {

        private string name; public string Name { get { return name; } set { this.name = value; } }
        private string surname; public string Surname { get {return surname;} set {this.surname = value;} }
        private string email; public string Email { get {return email;} set {this.email = value;} }
        private string password; public string Password { get {return password;} set {this.password = value;} }

    }
}
