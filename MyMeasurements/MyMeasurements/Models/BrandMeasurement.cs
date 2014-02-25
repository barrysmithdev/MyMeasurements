using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMeasurements.Models
{
    public class BrandMeasurement
    {
        public BrandMeasurement()
        {
            DateCreated = DateTime.Now;
        }

        public int Id { get; set; }
        public string BrandName { get; set; }
        public string ItemType { get; set; }
        public string Size { get; set; }
        public DateTime DateCreated { get; set; }
    }
}