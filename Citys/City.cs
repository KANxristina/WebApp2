using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp2.Citys
{
    public class City
    {
       
            private string country;
        private string citycode;

            public string Country
            {
                get
                {
                    return country;
                }
                set
                {
                    country = value;
                }
            }
            public string CityCode
            {
                get
                {
                return citycode;
                }
                set
                {
                    if (value.Length > 2)
                    {

                    }
                citycode = value;
                }
            }
        }
}