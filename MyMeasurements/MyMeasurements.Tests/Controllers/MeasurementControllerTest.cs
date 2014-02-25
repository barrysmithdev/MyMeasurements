using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace MyMeasurements.Tests.Controllers
{
    [TestClass]
    public class MeasurementControllerTest
    {

        public interface IDataRepository  { }

        public readonly IDataRepository _dataRepository;

        public MeasurementControllerTest()
        {
            _dataRepository = new Mock<IDataRepository>().Object;
        }

        [TestMethod]
        public void Index_Action_Display_Profile()
        {
            //arrange
            _dataRepository.Get

            //act

            //assert

        }
    }
}
