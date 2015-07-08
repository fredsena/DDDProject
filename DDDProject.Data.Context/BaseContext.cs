using DDDProject.Data.Context.Interfaces;
using System.Data.Entity;

namespace DDDProject.Data.Context
{
    public class BaseDbContext : DbContext, IDbContext
    {
        public BaseDbContext(string connectionStringName): base(connectionStringName)
        {            
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
    }
}
