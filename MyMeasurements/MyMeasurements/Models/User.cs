using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMeasurements.Models
{
    public class User
    {
        public ProfileMeasurement ProfileMeasurement { get; set; }
        public IEnumerable<BrandMeasurement> BrandMeasurements { get; set; }
        public ProfileMeasurement PartnersProfileMeasurement { get; set; }

    }
}