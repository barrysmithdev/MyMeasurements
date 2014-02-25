using System.Web.Mvc;
using MyMeasurements.DependencyResolution;
using StructureMap;

[assembly: WebActivator.PreApplicationStartMethod(typeof(MyMeasurements.App_Start.StructuremapMvc), "Start")]

namespace MyMeasurements.App_Start {
    public static class StructuremapMvc {
        public static void Start() {
            var container = (IContainer) IoC.Initialize();
            DependencyResolver.SetResolver(new StructureMapDependencyResolver(container));
        }
    }
}