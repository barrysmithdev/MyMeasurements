using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MyMeasurements.Domain;

namespace MyMeasurements.Web.Infrastructure
{
    public class DataRepositoryDb :DbContext, IDataRepository
    {

        public DbSet<User> User { get; set; }

     IQueryable<User> IDataRepository.Get(string emailAddress)
        {
            return User;
        }
    }
}