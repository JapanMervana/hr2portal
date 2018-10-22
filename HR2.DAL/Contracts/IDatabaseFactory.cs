using HR2.Model;
using System;

namespace HR2.DAL.Contracts
{
    public interface IDatabaseFactory : IDisposable
    {
        AdventureWorksEntities Get();
    }
}
