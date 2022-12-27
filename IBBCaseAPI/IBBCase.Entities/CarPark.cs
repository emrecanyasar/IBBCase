using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBBCase.Entities
{
    public class CarPark
    {
        [Key]
        public int CarParkId { get; set; }
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
