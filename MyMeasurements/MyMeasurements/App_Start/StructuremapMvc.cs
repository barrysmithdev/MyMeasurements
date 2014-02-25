using System.Web.Mvc;
using MyMeasurements.Web.DependencyResolution;
using StructureMap;

[assembly: WebActivator.PreApplicationStartMethod(typeof(MyMeasurements.Web.App_Start.StructuremapMvc), "Start")]

namespace MyMeasurements.Web.App_Start {
    public static class StructuremapMvc {
        public static void Start() {
            var container = (IContainer) IoC.Initialize();
            DependencyResolver.SetResolver(new StructureMapDependencyResolver(container));
        }
    }
}