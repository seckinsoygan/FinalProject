using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module //IoC Container
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance(); //Biri senden IProductService isterse ona ProductManager instancesi ver.
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance(); // Biri senden IProductDal isterse ona EfProductDal instancesi ver.

        }
    }
}
