using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp2.Package
{
    public class Package
    {
        private int id;
        private string countryname;
        private string cityname;
        private string description;
        private int days;
        private int price;

        public int ID {
            get
            {
                return id;
            }
            set
            {
                //+query
                id = value+1;


            }
        }
        public string Country {
            get
            {
                return countryname;
            }
            set
            {
                
               countryname = value;
                

            }
        }
        public string City {
            get
            {
                return cityname;
            }
            set
            {
                if (value.Length < 2)
                {
                    cityname = value;
                }
               
            }
        }
        public string Description {
            get
            {
                return description;
            }
            set
            {

                description = value;


            }
        }
        public int Days {
            get
            {
                return days;
            }
            set
            {

                days = value;


            }
        }
        public int Price {
            get
            {
                return price;
            }
            set
            {

                price = value;


            }
        }
    }
}