using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;

namespace MvcSolution.WebApi
{
    public class ServiceResolver : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(System.Reflection.Assembly.Load("MvcSolution.Services"))
            .Where(t => t.Name.EndsWith("Service"))
            .AsImplementedInterfaces()
            .InstancePerLifetimeScope();
        }
    }
}