using HR2.Utility.Unity;
using Microsoft.Practices.Unity;
using System.Web.Http.Dependencies;

namespace HR2.Web
{
    public class UnityResolver : UnityDependencyResolver, IDependencyResolver
    {
        private readonly IUnityContainer _container;
        public UnityResolver(IUnityContainer container)
            : base(container)
        {
            this._container = container;
        }

        public IDependencyScope BeginScope()
        {
            var child = this._container.CreateChildContainer();
            return new UnityResolver(child);
        }
    }
}