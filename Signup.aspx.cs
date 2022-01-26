using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SQLite;
using WebApp2.Users;

namespace WebApp2
{
    public partial class Signup : System.Web.UI.Page
    {

        protected void Button1_Click(object sender, EventArgs e)
        {
            UserRepository r = new UserRepository();
            string u = Convert.ToString(TextBox1.Text);
            string p = Convert.ToString(TextBox2.Text);
            string query = "INSERT INTO  Users (username,password) VALUES(@username,@password)";
            SQLiteCommand command = new SQLiteCommand(query, Dbconnection.GetConnection());

            command.Parameters.Add(new SQLiteParameter("@username", u));
            command.Parameters.Add(new SQLiteParameter("@password", p));
            try
            {
                command.ExecuteNonQuery();

            }
            catch
            {
                throw;

            }
            finally
            {
                Dbconnection.GetConnection().Close();
            }


        }
    }
}