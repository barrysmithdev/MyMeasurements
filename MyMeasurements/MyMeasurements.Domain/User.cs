using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMeasurements.Domain
{
    public class User
    {
        public virtual int Id { get; set; }
        public virtual string Email { get; set; }
        public virtual string Name { get; set; }
        public virtual  ProfileMeasurement ProfileMeasurement { get; set; }
        public virtual IEnumerable<BrandMeasurement> BrandMeasurements { get; set; }
        public virtual ProfileMeasurement PartnersProfileMeasurement { get; set; }

    }
}