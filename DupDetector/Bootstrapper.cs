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
    public class Bootstrapper : IDisposable
    {
        private static ILifetimeScope _rootScope;
        public ContainerBuilder Builder = new ContainerBuilder();

        public void Start()
        {
            if (_rootScope != null)
            {
                throw new Exception("You may not re-start the current Bootstrapper. Call dispose on this instance and create a new one.");
            }
            
            _rootScope = Builder.Build();
        }

        public void Dispose()
        {
            _rootScope.Dispose();
        }

        public static T Resolve<T>()
        {
            if (_rootScope == null)
            {
                throw new Exception("Bootstrapper hasn't been started!");
            }

            return _rootScope.Resolve<T>(new Parameter[0]);
        }

        public static T Resolve<T>(Parameter[] parameters)
        {
            if (_rootScope == null)
            {
                throw new Exception("Bootstrapper hasn't been started!");
            }

            return _rootScope.Resolve<T>(parameters);
        }
    }
}
