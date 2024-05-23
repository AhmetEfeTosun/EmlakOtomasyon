using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakOtomasyon
{
    public class Listing
    {
        public int ListingId { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public int SquareMeter { get; set; }
        public bool Status { get; set; }

        //not exist in table
        public string CityName { get; set; }
        public string DistrictName { get; set; }
        public double MinPrice { get; set; }
        public double MaxPrice { get; set; }
        public int MinSquareMeter { get; set; }
        public int MaxSquareMeter { get; set; }

    }
}
