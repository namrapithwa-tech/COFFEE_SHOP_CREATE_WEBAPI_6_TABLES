using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Coffee_Shop_Create_WebAPI_6_Tables.Models
{
    public class CityModel
    {
        public int CityID { get; set; }
        public string CityName { get; set; }
        public int CountryID { get; set; }

        public int StateID { get; set; }

        public string StateName { get; set; }
        public string CountryName { get; set; }
        public string CityCode { get; set; }
        public int? UserID { get; set; }
    }
}
