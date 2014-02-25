using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMeasurements.Domain;

namespace MyMeasurements.Web.Tests
{
    [TestClass]
    public class ProfileMeasurementTests
    {
        [TestMethod]
        public void ProfileMeasurement_OnSetSuitMeasurement_is38s()
        {
            //Arrange
            var profileMeasurement = new ProfileMeasurement();

            //Act
            profileMeasurement.SuitMeasurement = "38s";

            //Assert
            Assert.AreEqual("38s", profileMeasurement.SuitMeasurement, ignoreCase: true);

        }

        [TestMethod]
        public void ProfileMeasurement_OnSetShirtMeasurement_is38()
        {
            //Arrange
            var profileMeasurement = new ProfileMeasurement();

            //Act
            profileMeasurement.ShirtMeasurement = "38";

            //Assert
            Assert.AreEqual("38", profileMeasurement.ShirtMeasurement, ignoreCase: true);
        }


        [TestMethod]
        public void BrandMeasurement_OnSetBrandName_isNike()
        {
            //Arrange
            var brandMeasurement = new BrandMeasurement();

            //Act
            brandMeasurement.BrandName = "Nike";

            //Assert
            Assert.AreEqual("Nike", brandMeasurement.BrandName, ignoreCase: true);
        }

        [TestMethod]
        public void User_OnCreateMultipleBrandMeasurement_isMostRecent()
        {
            //Arrange
            var user = new User();
             user.BrandMeasurements = new List<BrandMeasurement>()
                {
                    new BrandMeasurement(){Id=3,DateCreated = DateTime.Now.AddDays(-120)},
                    new BrandMeasurement(){Id=2,DateCreated = DateTime.Now.AddDays(-2)},
                    new BrandMeasurement(){Id=1, DateCreated = DateTime.Now.AddDays(-222)},
                };

            //Act
          var ordered =  user.BrandMeasurements.OrderByDescending(x => x.DateCreated);

            //Assert
          Assert.IsTrue(ordered.First().DateCreated > ordered.Last().DateCreated);
        }


    

      
    }

   
}
