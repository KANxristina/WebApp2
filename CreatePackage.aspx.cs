using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

namespace WebApp2
{

    public partial class CreatePackage : System.Web.UI.Page
    {
        public static List<string> CountryList()
        {
            //Creating List
            List<string> CultureList = new List<string>();
            //getting the specific cultureInfo from cultureInfo class
            CultureInfo[] getcultureinfo = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            foreach (CultureInfo getCulture in getcultureinfo)
            {
                //creating the object of RegionInfo class.
                RegionInfo GetRegionInfo = new RegionInfo(getCulture.LCID);
                //adding each country name into the Array list
                if (!(CultureList.Contains(GetRegionInfo.EnglishName)))
                {
                    CultureList.Add(GetRegionInfo.EnglishName);
                }
            }
            CultureList.Sort();
            return CultureList;
        }
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.DataSource = CountryList();
                DropDownList1.DataBind();

                DropDownList2.DataSource = CountryList();
                DropDownList2.DataBind();


            }


        }

        
    }
}