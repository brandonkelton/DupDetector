using DupDetector.ViewModels;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DupDetector.Resources
{
    public class ResourceLocator : DynamicObject
    {
        public IViewModel MainViewModel => Bootstrapper.Resolve<MainViewModel>();

        public IViewModel ProductViewModel => Bootstrapper.Resolve<ProductViewModel>();

        public IViewModel ProductGridViewModel => Bootstrapper.Resolve<ProductGridViewModel>();


        //public Func<string, object> Resolver { get; private set; }

        //public ResourceLocator(Func<string, object> resolver)
        //{
        //    this.Resolver = resolver;
        //}

        //public override bool TryGetMember(GetMemberBinder binder, out object result)
        //{
        //    bool successful;

        //    string property = binder.Name;

        //    var resolver = this.Resolver;

        //    if (resolver != null)
        //    {
        //        try
        //        {
        //            result = resolver(property);
        //            successful = true;
        //        }
        //        catch { result = null; successful = false; }
        //    }
        //    else
        //    {
        //        result = null;
        //        successful = false;
        //    }

        //    return successful;
        //}
    }
}
