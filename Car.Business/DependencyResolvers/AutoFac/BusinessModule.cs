using Autofac;
using Car.Business.Abstract;
using Car.Business.Concrete;
using Car.DataAccess.Abstract;
using Car.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Business.DependencyResolvers.AutoFac
{
    public class BusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ArabaManager>().As<IArabaService>();
            builder.RegisterType<HasarManager>().As<IHasarService>();
            builder.RegisterType<ArabaDal>().As<IArabaDal>();
            builder.RegisterType<HasarDal>().As<IHasarDal>();
            base.Load(builder);
        }
    }
}
