using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMeasurements.Domain
{
    public interface IDataRepository
    {
       IQueryable<User>  Get(string emailAddress);
    }
}
