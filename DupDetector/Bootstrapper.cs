using Autofac;
using Autofac.Core;
using DupDetector.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DupDetector
{
    public static class Bootstrapper
    {
        public static IContainer Container;

        public static void Dispose()
        {
            Container.Dispose();
        }

        public static void ConfigureServices()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MainWindow>().SingleInstance();
            builder.RegisterType<MainViewModel>().SingleInstance();
            builder.RegisterType<ProductViewModel>().SingleInstance();
            builder.RegisterType<ProductGridViewModel>().SingleInstance();
            builder.RegisterType<FileService>().As<IFileService>().SingleInstance();
            Container = builder.Build();
        }

        public static T Resolve<T>()
        {
            if (Container == null)
            {
                throw new Exception("Bootstrapper hasn't been configured!");
            }

            return Container.Resolve<T>(new Parameter[0]);
        }

        public static T Resolve<T>(Parameter[] parameters)
        {
            if (Container == null)
            {
                throw new Exception("Bootstrapper hasn't been configured!");
            }

            return Container.Resolve<T>(parameters);
        }
    }
}
