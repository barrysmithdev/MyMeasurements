using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MyMeasurements.Domain;
using MyMeasurements.Web.Controllers;

namespace MyMeasurements.Web.Tests.Controllers
{
    [TestClass]
    public class MeasurementControllerTest
    {

     

        //public readonly IDataRepository _dataRepository;
        //public readonly MeasurementController _controller;

        public MeasurementControllerTest()
        {
         //   _dataRepository = new Mock<IDataRepository>();
          //  _controller = new MeasurementController(_dataRepository);
        }

        [TestMethod]
        public void Index_Action_Display_View_Index()
        {
            //arrange
            var  _dataRepository = new Mock<IDataRepository>();
            var _controller = new MeasurementController(_dataRepository.Object);
           //   _dataRepository.Setup(x => x.Get(It.IsAny<string>())).Returns( new Collection<User>());  

            //act
            var result = _controller.Index() as ViewResult;
            

            //assert
            Assert.IsNotNull(result);
            //Assert.AreEqual("Index",result.ViewName);
        }

        [TestMethod]
        public void Index_Action_Returns_Model_Type()
        {
            //arrange
            var _dataRepository = new Mock<IDataRepository>();
            var _controller = new MeasurementController(_dataRepository.Object);
            var user = new User();
          //  _dataRepository.Setup(x => x.Get(It.IsAny<string>())).Returns(new List<User>);

            //act
            var result = _controller.Index() as ViewResult;


            //assert
            Assert.AreEqual(user.GetType(), result.Model.GetType());
        }
    }
}
