using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SQLite;
using WebApp2.Users;
using System.Data.SQLite;

namespace WebApp2
{
    public class UserRepository
    {
        public static User GetUser(string username, string password)
        {
            User user = null;
            
            string query = "Select * FROM Users where username=@username and password=@password";
            SQLiteCommand command = new SQLiteCommand(query, Dbconnection.GetConnection());
            command.Parameters.Add(new SQLiteParameter("@username", username));
            command.Parameters.Add(new SQLiteParameter("@password", password));
            try
            {
                SQLiteDataReader reader = command.ExecuteReader();
                if (!reader.HasRows) 
                {
                    return null;
                     

                }
                while (reader.Read())
                {
                    user = new User();
                    username = Convert.ToString("username");
                    password = Convert.ToString("password");
                    user.Username = username;
                    user.Password = password;
                   
                   
                    break;
                }

            }
            catch
            {
                throw;

            }
            finally
            {
                Dbconnection.GetConnection().Close();
            }
            return user;
            
        }
    }
}