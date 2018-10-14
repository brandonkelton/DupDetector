using Autofac;
using DupDetector.Resources;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DupDetector
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            new Startup();

            //this.Resources["Locator"] = new ResourceLocator(property => Bootstrapper.Container.Resolve(Type.GetType(property)));
        }
    }
}
