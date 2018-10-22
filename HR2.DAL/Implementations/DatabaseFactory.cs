using HR2.DAL.Contracts;
using HR2.Model;

namespace HR2.DAL.Implementations
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private AdventureWorksEntities dataContext;
        public AdventureWorksEntities Get()
        {
            return dataContext ?? (dataContext = new AdventureWorksEntities());
        }
        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}
