
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp2.Users
{
    public  class User
    {                   
       private int id;
       private string username;
       private string password;
            public int ID {
            get
            {
                return id;
            }
            set
            {
                this.id = value;
            }
                 }
            public string Username
        {
            get
            {
                return username;
            }
            set
            {
                this.username = value;
            }
        }
        
            public string Password
        {
            get
            {
                return password;
            }
            set
            {
                this.password = value;
            }
        }

       
    }
}