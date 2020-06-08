using BrowserCheck.Model;
using System;
using System.Data.SQLite;
using System.IO;

namespace BrowserCheck.DatabaseOperations
{
    class UserDatabase
    {
        private static string path = Directory.GetCurrentDirectory();
        private SQLiteConnection conn = new SQLiteConnection("Data Source=" + path + "/../../ApplicationFiles/Database/users.db;Version=3;");

        public bool checkUser(string email, string password)
        {
           
            bool check = false;
            User user = new User();
            using (conn)
            {
                try
                {                
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandText = @"Select name,surname,email,password from user where email = @email and password = @password";
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("email", email);
                        cmd.Parameters.AddWithValue("password", password);
                        using (SQLiteDataReader rdr = cmd.ExecuteReader())
                        {
                            if (rdr.HasRows)
                            {
                                while (rdr.Read())
                                {
                                    user.Name = rdr.GetValue(0).ToString();
                                    user.Surname = rdr.GetValue(1).ToString();
                                    user.Email = rdr.GetValue(2).ToString();
                                    Global.Session.Instance.MyUser = user;
                                }
                                check = true;
                            }
                        }

                    }
                }
                catch
                {
                    check = false;
                }
                finally
                {
                    conn.Close();

                }
            }
            return check;
        }

        public bool addUser(User user)
        {
         
            bool check = false;  
            using (conn)
            {
                try
                {

                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        SQLiteTransaction transaction = null;
                        transaction = conn.BeginTransaction();

                        cmd.CommandText = "insert into user (name, surname, email, password) Values (@name, @surname, @email, @password)";
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("name", user.Name);
                        cmd.Parameters.AddWithValue("surname", user.Surname);
                        cmd.Parameters.AddWithValue("email", user.Email);
                        cmd.Parameters.AddWithValue("password", user.Password);
                        cmd.ExecuteNonQuery();

                        transaction.Commit();
                        check = true;
                    }
                }    
                catch
                {
                    check = false;
                }
                finally
                {
                    conn.Close();
                }
            }
            return check;
        }

    }
}
