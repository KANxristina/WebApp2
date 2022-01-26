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
    public partial class Login : System.Web.UI.Page
    {
             protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                User user = null;
                string labeltext = "This users doesn't exist or the credentials are wrong! Try again!";

                string username = Convert.ToString(TextBox1.Text);
                string password = Convert.ToString(TextBox2.Text);
                UserRepository rep = new UserRepository();
                 user = UserRepository.GetUser(username, password);
                string text = Convert.ToString(user);
                if (user==null)
                 {
                    Label3.Text = labeltext;

                 }
                 else
                 {
                     Response.Redirect("Default.aspx");
                 }
               
            }
            catch
            {
                throw;
            }
            finally
            {

            }
         
        }

        
    }
}