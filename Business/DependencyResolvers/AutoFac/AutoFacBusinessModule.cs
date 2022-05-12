using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.AutoFac
{
    public class AutoFacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StockGroupManager>().As<IStockGroupService>().SingleInstance();
            builder.RegisterType<EfStockGroupDal>().As<IStockGroupDal>().SingleInstance();

            builder.RegisterType<StockManager>().As<IStockService>().SingleInstance();
            builder.RegisterType<EfStockDal>().As<IStockDal>().SingleInstance();

            builder.RegisterType<CustomerManager>().As<ICustomerService>().SingleInstance();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>().SingleInstance();

            builder.RegisterType<CustomerGroupManager>().As<ICustomerGroupService>().SingleInstance();
            builder.RegisterType<EfCustomerGroupDal>().As<ICustomerGroupDal>().SingleInstance();


        }
    }
}
