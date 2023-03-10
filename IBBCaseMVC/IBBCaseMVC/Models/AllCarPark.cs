using System.ComponentModel.DataAnnotations;

namespace IBBCaseMVC.Models
{
    public class AllCarPark
    {
        public int _id { get; set; }
        public string PARK_NAME { get; set; }
        public string LOCATION_NAME { get; set; }
        public string PARK_TYPE_ID { get; set; }
        public string PARK_TYPE_DESC { get; set; }
        public int CAPACITY_OF_PARK { get; set; }
        public string WORKING_TIME { get; set; }
        public string COUNTY_NAME { get; set; }
        public double LONGITUDE { get; set; }
        public double LATITUDE { get; set; }
    }
}
