using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using MvcSolution.Entity;
using System.Data.Entity;
using Autofac.Integration.WebApi;
using System.Web.Http;
using MvcSolution.WebApi.Resolver;
using AutoMapper;

namespace MvcSolution.WebApi
{
    public class BootStrapper
    {
        /// <summary>
        /// Below Configuiration for .net MVC
        /// </summary>
        //public static void ConfigureIOC()
        //{
        //    ContainerBuilder _builder = new ContainerBuilder();
        //    _builder.RegisterModule(new RepositoryResolver());
        //    _builder.RegisterModule(new ServiceResolver());
        //    _builder.RegisterType(typeof(EntityDbFirstEntities)).As(typeof(DbContext)).InstancePerLifetimeScope();
        //    IContainer container = _builder.Build();
        //    DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        //}


        public static void ConfigureIOC(HttpConfiguration _configuration)
        {
            ContainerBuilder _builder = new ContainerBuilder();
            _builder.RegisterModule(new RepositoryResolver());
            _builder.RegisterModule(new ServiceResolver());
            _builder.RegisterType(typeof(TestEntities)).As(typeof(DbContext)).InstancePerLifetimeScope();
            _builder.RegisterInstance(EntityMapper._mapper).As<IMapper>();
            IContainer container = _builder.Build();
            _configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
