using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMeasurements.Domain;


namespace MyMeasurements.Web.Controllers
{
    public class MeasurementController : Controller
    {
        //
        // GET: /Measurement/
        private readonly IDataRepository _dataRepository ;

        public MeasurementController(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public ActionResult Index()
        {
            var user =_dataRepository.Get("");
            return View(user);
        }

    }
}
