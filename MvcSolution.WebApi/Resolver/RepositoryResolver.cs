using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Autofac.Integration.WebApi;

namespace MvcSolution.WebApi
{
    public class RepositoryResolver : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(System.Reflection.Assembly.Load("MVCSolution.WebApi")).PropertiesAutowired();


            builder.RegisterAssemblyTypes(System.Reflection.Assembly.Load("MvcSolution.Data"))
             .Where(t => t.Name.EndsWith("Repository"))
             .AsImplementedInterfaces()
             .InstancePerLifetimeScope();


            //.Where(t => t.Name.EndsWith("Controller"));
        }

    }
}