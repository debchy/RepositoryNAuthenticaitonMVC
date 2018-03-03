using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMS.ViewModels
{
    public static class HelperViewModels
    {
        

        public static IEnumerable< SelectListItem> Genders() {
            
            List<SelectListItem> genders_ = new List<SelectListItem>();
            genders_.Add(new SelectListItem() { Text = "Select Gender", Value = "", Selected = true });
            genders_.Add(new SelectListItem() { Text = "Male", Value = "M", Selected = false });
            genders_.Add(new SelectListItem() { Text = "Female", Value = "F", Selected = false });
            return genders_;
            
        }

        public static IEnumerable<SelectListItem> Themes() {
            List<SelectListItem> themes_ = new List<SelectListItem>();
            themes_.Add(new SelectListItem() { Text = "Select Theme", Value = "", Selected = true });
            themes_.Add(new SelectListItem() { Text = "Orange", Value = "Orange", Selected = false });
            themes_.Add(new SelectListItem() { Text = "Black", Value = "Black", Selected = false });
            return themes_;           
        }
        public static SelectList CountryList()
        {
            //SCC.Areas.Admin.Models.DBContext db = new SCC.Areas.Admin.Models.DBContext();

            //var CountryDropDown = from row in db.CountryList
            //                      where row.Status == true
            //                      orderby row.CountryName
            //                      select new { row.CountryCode, row.CountryName };
            var CountryDropDown = new List<Country>();
            CountryDropDown.Add(new Country { CountryCode= "UAE", CountryName= "United Arab Emirates" });
            CountryDropDown.Add(new Country { CountryCode = "SA", CountryName = "Saudi Arabia" });
            var countries_ = new SelectList(CountryDropDown, "CountryCode", "CountryName","");

            return countries_;

        }
        public class Country
        {
            public string CountryCode { get; set; }
        public string CountryName { get; set; }
        }
        public static SelectList CountryList(string selectedValue)
        {
            var CountryDropDown = new Dictionary<string, string>();
            CountryDropDown.Add("UAE", "United Arab Emirates");
            CountryDropDown.Add("SA", "Saudi Arabia");

            var countries_ = new SelectList(CountryDropDown, "CountryCode", "CountryName", selectedValue);

            return countries_;

        }
    }

    //public class HelperShowMessageViewModel
    //{
    //    public string MessageToSHow { get; set; }
    //    public string SectionName { get; set; }
    //    public MessageTypes Type { get; set; }
    //}
    
}