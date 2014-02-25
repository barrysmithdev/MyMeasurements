using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMeasurements.Domain
{
    public class BrandMeasurement
    {
        public BrandMeasurement()
        {
            DateCreated = DateTime.Now;
        }

        public virtual int Id { get; set; }
        public virtual string BrandName { get; set; }
        public virtual string ItemType { get; set; }
        public virtual string Size { get; set; }
        public virtual  DateTime DateCreated { get; set; }
    }
}